using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;
//estas librerias se instalaron para imprimir un documento pdf
using Microsoft.VisualBasic.ApplicationServices;
using iText.Kernel.Pdf;
using System.Reflection.Metadata;
using Document = iText.Layout.Document;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using DocumentFormat.OpenXml.Vml;
using Point = System.Drawing.Point;
/*using iTextSharp.text;*/  //pqara pdf
//using iTextSharp.text.pdf*/
using iTextSharp.tool.xml;
using System.IO;

namespace ProyectoHCL.Formularios
{
    public partial class CtrlRoles : Form
    {
        R_E_Roles R_E_rolp = new R_E_Roles();
        AdmonRoles rgtRoles = new AdmonRoles(); //crear objeto Rgtroles para acceder a sus metodos
        Roles rolr = new Roles();     //crear objetos roles para acceder a sus parametros 
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        CDatos cDatos = new CDatos();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0;
        public CtrlRoles()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDT();

        }

        private void Permisos()
        {
            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs);

            foreach (var obj in LsObj)
            {
                switch (obj.IdPermiso)
                {
                    case 2:
                        if (obj.ObjetoN == "ROLES" && !obj.Permitido)
                        {
                            btnNuevo.Visible = false;
                            label1.Location = new Point(28, 24);
                            txtBuscarR.Location = new Point(84, 22);
                        }
                        break;
                    case 3:
                        if (obj.ObjetoN == "ROLES" && !obj.Permitido)
                        {
                            dgvRoles.Columns["EDITAR"].Visible = false;
                        }
                        break;
                    case 4:
                        if (obj.ObjetoN == "ROLES" && !obj.Permitido)
                        {
                            dgvRoles.Columns["ELIMINAR"].Visible = false;
                        }
                        break;
                }
            }
        }

        private void CargarDT()
        {
            rolr.Inicio1 = pagInicio;
            rolr.Final1 = pagFinal;
            ds = rolr.PaginacionRoles();
            dgvRoles.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPagR.Text = cantidad.ToString();

            cmbPagR.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPagR.Items.Add(x.ToString());

            cmbPagR.SelectedIndex = indice;

            HabilitarBotones();
        }
        private void CtrlRoles_Load(object sender, EventArgs e)
        {


            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn(); //se crea el boton en el dataGrid
            btnUpdate.Name = "EDITAR"; //Nombre del boton 
            dgvRoles.Columns.Add(btnUpdate); //Se especifica el nombre de dataGrid para agregar boton

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvRoles.Columns.Add(btnDelete);

            Permisos();
        }


        public void BuscarRol(string buscarR) //Recibe string para buscar rol
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarRol", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreR", MySqlDbType.VarChar, 30).Value = buscarR; //recibe el parametro buscarR definido en el parametro almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                dgvRoles.DataSource = dt; //se define la tabla en la que se devuelven los registros
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {

            R_E_rolp.label11.Text = "Registrar Rol";
            R_E_rolp.ShowDialog();
            CargarDT();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarR.Text != "")
            {
                BuscarRol(txtBuscarR.Text);
            }
            else
            {
                CargarDT();
            }
        }


        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvRoles.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                R_E_rolp.label11.Text = "Editar Rol";
                R_E_rolp.idRol = dgvRoles.CurrentRow.Cells["ID"].Value.ToString();
                R_E_rolp.txtRol.Text = dgvRoles.CurrentRow.Cells["NOMBRE"].Value.ToString();
                R_E_rolp.txtNumero.Text = dgvRoles.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                R_E_rolp.cmbEstado.Text = dgvRoles.CurrentRow.Cells["ESTADO"].Value.ToString();
                R_E_rolp.ShowDialog();
                R_E_rolp.limpiarCampos();
                CargarDT();
            }
            if (this.dgvRoles.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {

                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    bool elimino = rgtRoles.EliminarRoles(dgvRoles.CurrentRow.Cells["ID"].Value.ToString()); //EL metodo eliminar recibe como string el id del DataGrid
                    if (elimino)
                    {
                        MsgB mbox = new MsgB("informacion", "Registro eliminado");
                        DialogResult dR = mbox.ShowDialog();
                        CargarDT();
                    }
                    else
                    {
                        MsgB mbox = new MsgB("informacion", "Registro no eliminado");
                        DialogResult dR = mbox.ShowDialog();
                    }

                }
                else if (dg == DialogResult.Cancel)
                {

                }
            }

        }

        private void dgvRoles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvRoles.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvRoles.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvRoles.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvRoles.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvRoles.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvRoles.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvRoles.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvRoles.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }
        private void pdf_Click(object sender, EventArgs e)
        {
            crearPDF();
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.ShowDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMYYYYHHmmss") + ".pdf";
            MsgB mbox = new MsgB("informacion", "PDF creado con éxito");
            DialogResult dR = mbox.ShowDialog();
        }
        private void crearPDF()
        {

        }

        private void Excel_Click(object sender, EventArgs e)
        {


            SLDocument sl = new SLDocument();

            System.Drawing.Bitmap bm = new System.Drawing.Bitmap("C:/Users/DAOdo/Desktop/SEGUNDO PERIODO 2023/Programacion he implementacion de Sistemas/ProyectoHotelCasaLomas/logo.jpeg");
            Byte[] ba;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                bm.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Close();
                ba = ms.ToArray();
            }
            SLPicture pic = new SLPicture(ba, DocumentFormat.OpenXml.Packaging.ImagePartType.Jpeg);
            pic.SetPosition(0, 0);
            pic.ResizeInPixels(100, 80);
            sl.InsertPicture(pic);

            sl.SetCellValue("C2", "Reporte de Roles");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");


            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_ROL");
            sl.SetCellValue("B" + celdaCabecera, "id_rol");
            sl.SetCellValue("C" + celdaCabecera, "rol");
            sl.SetCellValue("D" + celdaCabecera, "descripcion");
            sl.SetCellValue("E" + celdaCabecera, "estado rol");
            sl.SetCellValue("F" + celdaCabecera, "fecha creacion");
            sl.SetCellValue("G" + celdaCabecera, "fecha actualizacion");

            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Red, System.Drawing.Color.Red);
            sl.SetCellStyle("B" + celdaCabecera, "g" + celdaCabecera, estiloCa);

            string sql = "SELECT id_rol, rol, descripcion, estado_rol,  fecha_creacion, fecha_actualizacion FROM TBL_ROL";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
            // conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["id_rol"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["rol"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["descripcion"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["estado_rol"].ToString());
                sl.SetCellValue("F" + celdaCabecera, reader["fecha_creacion"].ToString());
                sl.SetCellValue("G" + celdaCabecera, reader["fecha_actualizacion"].ToString());

            }

            SLStyle EstiloB = sl.CreateStyle();
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "G" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B", "G");

            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = "*.xlsx";
            sf.FileName = "ExcelRoles";
            sf.Filter = " Libro de Excel (*.xlsx) | *.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                sl.SaveAs(sf.FileName);
                MsgB mbox = new MsgB("informacion", "Archivo Excel creado con éxito");
                DialogResult dR = mbox.ShowDialog();
            }

        }


        private void btSiguiente_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagR.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDT();

        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagR.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDT();
        }


        private void HabilitarBotones()
        {
            if (pagInicio == 1)
            {
                btAnterior.Enabled = false;
                cmbMostrar.Enabled = true;
            }
            else
            {
                btAnterior.Enabled = true;
                cmbMostrar.Enabled = false;
            }

            if (indice == (Convert.ToInt32(txtPagR.Text) - 1))
            {
                btSiguiente.Enabled = false;
            }
            else
            {
                btSiguiente.Enabled = true;
            }
        }
        private void cmbPagR_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagR.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDT();

        }

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {

            indice = cmbMostrar.SelectedIndex;
            switch (indice)
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
            CargarDT();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_EnabledChanged(object sender, EventArgs e)
        {
            btnNuevo.BackColor = Color.DarkGray;
        }
    }
}
