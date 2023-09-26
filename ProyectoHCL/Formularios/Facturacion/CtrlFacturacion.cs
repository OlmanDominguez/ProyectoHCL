using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using ProyectoHCL.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoHCL.Formularios;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;

namespace ProyectoHCL.Formularios
{
    public partial class CtrlFacturacion : Form
    {
        Facturacion user = new Facturacion();
        DataSet ds = new DataSet();
        CDatos cDatos = new CDatos();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0;

        public CtrlFacturacion()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();

        }

        private void Permisos()
        {
            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs);

            foreach (var obj in LsObj)
            {
                switch (obj.IdPermiso)
                {
                    case 2:
                        if (obj.ObjetoN == "FACTURACION" && !obj.Permitido) //Validar pantalla y el permiso
                        {
                            btnNuevo.Enabled = false; //Deshabilitar botón para crear
                        }
                        break;
                    case 3:
                        if (obj.ObjetoN == "FACTURACION" && !obj.Permitido)
                        {
                            dgvFacturas.Columns["EDITAR"].Visible = false; //Ocultar columna del botón para editar en datagrid
                        }
                        break;
                    case 4:
                        if (obj.ObjetoN == "FACTURACION" && !obj.Permitido)
                        {
                            dgvFacturas.Columns["ELIMINAR"].Visible = false; //Ocultar columna del botón para eliminar en datagrid
                        }
                        break;
                }
            }
        }

        private void CargarDG()
        {
            user.Inicio1 = pagInicio;
            user.Final1 = pagFinal;
            ds = user.PaginacionFacturas();
            dgvFacturas.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPaginacion.Text = cantidad.ToString();

            cmbPaginacion.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPaginacion.Items.Add(x.ToString());

            cmbPaginacion.SelectedIndex = indice;
            HabilitarBotones();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CtrlFacturacion_Load(object sender, EventArgs e)
        {
            //MostrarUsuarios(); 

            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn(); //se crea el boton en el dataGrid
            btnVer.Name = "VER"; //Nombre del boton 
            dgvFacturas.Columns.Add(btnVer); //Se especifica el nombre de dataGrid para agregar boton

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "EDITAR";
            dgvFacturas.Columns.Add(btnDelete);

            Permisos();
        }


        public void BuscarFacturas(string buscarF) //Recibe string para buscar usuarios
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarFacturas", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreF", MySqlDbType.VarChar, 50).Value = buscarF; //recibe el parametro nombreU definido en el parametro almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                dgvFacturas.DataSource = dt; //se define la tabla en la que se devuelven los registros
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "") //si el textbox no está vacío devuelve el metodo buscar usuarios
            {
                BuscarFacturas(txtBuscar.Text); //El metodo recibe el string desde el textbox
            }
            else
            {
                CargarDG();  /*MostrarUsuarios();*/ //Si el textbox está vacio devuelve el metodo mostrar usuarios 
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Form formulario = new Formularios.NuevaFact();
            formulario.ShowDialog();
            CargarDG();
        }

        private void dgvFacturas_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvFacturas.Columns[e.ColumnIndex].Name == "VER" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvFacturas.Rows[e.RowIndex].Cells["VER"] as DataGridViewButtonCell;
                Icon icoVer = new Icon(Environment.CurrentDirectory + "\\ver.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvFacturas.Rows[e.RowIndex].Height = icoVer.Height + 8;
                this.dgvFacturas.Columns[e.ColumnIndex].Width = icoVer.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvFacturas.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvFacturas.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvFacturas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvFacturas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        public static class info
        {
            public static string factura;
            public static string fecha;
            public static string ingreso;
            public static string salida;
            public static string reserva;
            public static int est = 0;
        }


        private void dgvFacturas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvFacturas.Columns[e.ColumnIndex].Name == "VER")
            {
                try
                {
                    info.factura = dgvFacturas.CurrentRow.Cells["FACTURA"].Value.ToString();
                    DateTime ingreso = Convert.ToDateTime(dgvFacturas.CurrentRow.Cells["INGRESO"].Value.ToString());
                    string ingreso1 = ingreso.ToString("dd/MM/yyyy");
                    info.ingreso = ingreso1;
                    DateTime salida = Convert.ToDateTime(dgvFacturas.CurrentRow.Cells["SALIDA"].Value.ToString());
                    string salida1 = salida.ToString("dd/MM/yyyy");
                    info.salida = salida1;
                    info.reserva = dgvFacturas.CurrentRow.Cells["RESERVA"].Value.ToString();
                    info.est = 1;
                    DateTime fecha2 = Convert.ToDateTime(dgvFacturas.CurrentRow.Cells["SALIDA"].Value.ToString());
                    string fecha1 = fecha2.ToString("dd/MM/yyyy");
                    info.fecha = fecha1;
                    Form form = new Formularios.ShowFactura();
                    form.ShowDialog();

                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un error");
                }

            }

            if (this.dgvFacturas.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                try
                {
                    info.factura = dgvFacturas.CurrentRow.Cells["FACTURA"].Value.ToString();
                    DateTime ingreso = Convert.ToDateTime(dgvFacturas.CurrentRow.Cells["INGRESO"].Value.ToString());
                    string ingreso1 = ingreso.ToString("dd/MM/yyyy");
                    info.ingreso = ingreso1;
                    DateTime salida = Convert.ToDateTime(dgvFacturas.CurrentRow.Cells["SALIDA"].Value.ToString());
                    string salida1 = salida.ToString("dd/MM/yyyy");
                    info.salida = salida1;
                    info.reserva = dgvFacturas.CurrentRow.Cells["RESERVA"].Value.ToString();
                    info.est = 0;
                    Form form = new Formularios.ShowFactura();
                    form.ShowDialog();

                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un error");
                }
            }
        }

        private void cmbPaginacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIndice = cmbMostrar.SelectedIndex;
            switch (cmbIndice)
            {
                case 0:
                    numFilas = 5;
                    break;
                case 1:
                    numFilas = 10;
                    break;
                case 2:
                    numFilas = 20;
                    break;
                case 3:
                    numFilas = 30;
                    break;
                case 4:
                    numFilas = 40;
                    break;
            }
            pagFinal = numFilas;
            CargarDG();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void HabilitarBotones()
        {
            if (pagInicio == 1)
            {
                btnAnt.Enabled = false;
                cmbMostrar.Enabled = true;
            }
            else
            {
                btnAnt.Enabled = true;
                cmbMostrar.Enabled = false;
            }

            if (indice == (Convert.ToInt32(txtPaginacion.Text) - 1))
            {
                btnSig.Enabled = false;
            }
            else
            {
                btnSig.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void crearExcel()
        {
            SLDocument sl = new SLDocument();

            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(Properties.Resources.logo);
            Byte[] ba;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                bm.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Close();
                ba = ms.ToArray();
            }
            SLPicture pic = new SLPicture(ba, DocumentFormat.OpenXml.Packaging.ImagePartType.Jpeg);
            pic.SetPosition(0, 0);
            pic.ResizeInPixels(80, 80);
            sl.InsertPicture(pic);

            sl.SetCellValue("C2", "Reporte de Facturas");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_FACTURA");
            sl.SetCellValue("B" + celdaCabecera, "Factura");
            sl.SetCellValue("C" + celdaCabecera, "Id Soli. Reserva");
            sl.SetCellValue("D" + celdaCabecera, "Nombre");
            sl.SetCellValue("E" + celdaCabecera, "Apellido");
            sl.SetCellValue("F" + celdaCabecera, "Identificacion");
            sl.SetCellValue("G" + celdaCabecera, "Fecha");
            sl.SetCellValue("H" + celdaCabecera, "Ingreso");
            sl.SetCellValue("I" + celdaCabecera, "Salida");
            sl.SetCellValue("J" + celdaCabecera, "Total");

            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "J" + celdaCabecera, estiloCa);

            string sql = "SELECT NFACTURA, s.ID_SOLICITUDRESERVA, c.NOMBRE, c.APELLIDO, c.DNI_PASAPORTE, f.FECHA, s.INGRESO, s.SALIDA, f.TOTAL FROM TBL_FACTURA f INNER JOIN TBL_SOLICITUDRESERVA s ON f.ID_SOLICITUDRESERVA = s.ID_SOLICITUDRESERVA INNER JOIN TBL_CLIENTE c ON s.COD_CLIENTE = c.CODIGO;";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["NFACTURA"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["ID_SOLICITUDRESERVA"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["NOMBRE"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["APELLIDO"].ToString());
                sl.SetCellValue("F" + celdaCabecera, reader["DNI_PASAPORTE"].ToString());
                sl.SetCellValue("G" + celdaCabecera, reader["FECHA"].ToString());
                sl.SetCellValue("H" + celdaCabecera, reader["INGRESO"].ToString());
                sl.SetCellValue("I" + celdaCabecera, reader["SALIDA"].ToString());
                sl.SetCellValue("J" + celdaCabecera, reader["TOTAL"].ToString());
            }

            SLStyle EstiloB = sl.CreateStyle();
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "J" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B", "J");

            SaveFileDialog sf = new SaveFileDialog();

            sf.DefaultExt = "*.xlsx";
            sf.FileName = "ExcelFacturas";
            sf.Filter = " Libro de Excel (*.xlsx) | *.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                sl.SaveAs(sf.FileName);
                MsgB mbox = new MsgB("informacion", "Archivo Excel creado con éxito");
                DialogResult dR = mbox.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            crearExcel();
        }
    }
}
