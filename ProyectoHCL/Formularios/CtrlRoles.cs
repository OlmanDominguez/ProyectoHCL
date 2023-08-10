using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

namespace ProyectoHCL.Formularios
{
    public partial class CtrlRoles : Form
    {
        Roles user = new Roles();
        DataSet ds = new DataSet();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal;

        public CtrlRoles()
        {
            InitializeComponent();
            pagFinal = numFilas;
            RellenarGrid();
        }


        private void CargarDT()
        {
            user.Inicio1 = pagInicio;
            user.Final1 = pagFinal;
            ds = user.PaginacionRoles();
            dgvRoles.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPagR.Text = cantidad.ToString();

            cmbPagR.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPagR.Items.Add(x.ToString());

            cmbPagR.SelectedIndex = indice;
        }


        AdmonRoles rgtRoles = new AdmonRoles(); //crear objeto Rgtroles para acceder a sus metodos
        Roles roles = new Roles();//crear objetos roles para acceder a sus parametros 
        private void CtrlRoles_Load(object sender, EventArgs e)
        {
            RellenarGrid(); //se muestran roles registrados en el dataGrid

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn(); //se crea el boton en el dataGrid
            btnUpdate.Name = "EDITAR"; //Nombre del boton 
            dgvRoles.Columns.Add(btnUpdate); //Se especifica el nombre de dataGrid para agregar boton

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvRoles.Columns.Add(btnDelete);
        }
        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgvRoles.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = rgtRoles.EliminarRoles(dgvRoles.CurrentRow.Cells["ID_ROL"].Value.ToString()); //EL metodo eliminar recibe como string el id del DataGrid

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar este Rol?",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (elimino)
                    {
                        MessageBox.Show("Rol eliminado");
                        RellenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Rol no eliminado");
                    }

                }
                else /*if (dialogResult == DialogResult.No)*/
                {

                }
            }
            if (this.dgvRoles.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarRoles editarRoles = new EditarRoles(); //Crear objeto del form Editarroles

                //  editarRoles.ID_rol= Roles_Permisos_DG.CurrentRow.Cells["ID"].Value.ToString();
                editarRoles.txtNombre.Text = dgvRoles.CurrentRow.Cells["NOMBRE_ROL"].Value.ToString();
                editarRoles.txtEstadoRol.Text = dgvRoles.CurrentRow.Cells["ESTADO_ROL"].Value.ToString();
                editarRoles.txtFechaC.Text = dgvRoles.CurrentRow.Cells["FECHA_CREACION"].Value.ToString();
                editarRoles.txtFechaActualizacion.Text = dgvRoles.CurrentRow.Cells["FECHA_ACTUALIZACION"].Value.ToString();
                editarRoles.ShowDialog(); //Se oculta el form principal y solo muestra el form editarRol
                RellenarGrid(); //Se llama el metodo Mostrar Roles para actualizar el DataGrid al editar 
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
        public void RellenarGrid()
        {
            dgvRoles.DataSource = rgtRoles.RellenarGrid(); //Llamar metodo mostrar Roles en dataGrid
        }


        private void pdf_Click(object sender, EventArgs e)
        {
            crearPDF();
        }
        private void crearPDF()
        {


            PdfWriter pdfWriter = new PdfWriter("Reporte.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            //1 pulgada = 72 pt (8 1/2 x 11) (612 x 792)
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);
            // Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "id_rol", "rol", "descripcion", "estado_rol", "fecha_creacion", "fecha_ actualizacion" };

            float[] tamanios = { 2, 2, 2, 2, 4, 4, };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));


            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql = "SELECT id_rol, rol, descripcion, estado_rol,  fecha_creacion, fecha_actualizacion FROM TBL_ROL";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
            // conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                //for (int x = 1; x < 100; x++)
                {


                    tabla.AddCell(new Cell().Add(new Paragraph(reader["id_rol"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["rol"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["descripcion"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["estado_rol"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_creacion"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_actualizacion"].ToString()).SetFont(fontContenido)));

                }
            }

            /* SaveFileDialog selecciona = new SaveFileDialog();
             selecciona.Filter = "PDF (*.pdf)|*.pdf";
             selecciona.InitialDirectory = @"C:\Users\Descargas\ReporteRoles.pdf";
             selecciona.Title = "Seleccionar la Carpeta";

             if (selecciona.ShowDialog() == DialogResult.OK)

             {
                 string ruta = selecciona.FileName;*/
            documento.Add(tabla);
            documento.Close();

            var logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("C:/Users/DAOdo/Desktop/SEGUNDO PERIODO 2023/Programacion he implementacion de Sistemas/ProyectoHotelCasaLomas/logo.jpeg")).SetWidth(50);
            var plogo = new Paragraph("").Add(logo);

            var nombre = new Paragraph("Hotel Casa Lomas");
            nombre.SetTextAlignment(TextAlignment.CENTER);
            nombre.SetFontSize(12);

            var titulo = new Paragraph("Reporte Roles");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd.MM.yyy");
            var dhora = DateTime.Now.ToString("hh.mm.ss");
            var fecha = new Paragraph("fecha:" + dfecha + "\nHora:" + dhora);
            fecha.SetFontSize(12);


            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter
                ("ReporteRoles.pdf"));
            Document doc = new Document(pdfDoc);

            int numeros = pdfDoc.GetNumberOfPages();


            for (int i = 1; i <= numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);

                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(nombre, 110, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 396, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 700, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("pagina {0} de {1}", i, numeros)), pdfDoc.GetPage
                    (i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i,
                    TextAlignment.CENTER, VerticalAlignment.TOP, 0);


            }
            doc.Close();


        }

        private void Excel_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog selecciona = new SaveFileDialog();
          selecciona.Filter = "Archivo Libro de Excel (*.Libro de Excel)|*.Libro de Excel";
          selecciona.InitialDirectory = @"C:\Users\Descargas\Excdl.xlsx";
          selecciona.Title = "Seleccionar la Carpeta";

          if (selecciona.ShowDialog() == DialogResult.OK)

          {
              string ruta = selecciona.FileName;*/

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


            sl.SaveAs("Excel.xlsx");
        }

        public void txtBuscar_TextChanged(string buscarR) //Recibe string para buscar usuarios
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarrol", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreR", MySqlDbType.VarChar, 30).Value = buscarR; //recibe el parametro nombreR definido en el parametro almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                dgvrRoles.DataSource = dt; //se define la tabla en la que se devuelven los registros
            }
            catch (Exception)
            {

                throw;
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


        private void RolesBotones()
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

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // numFilas = int.Parse(mostrarR.Text);
            // pagFinal = numFilas;

            indice = cmbMostrar.SelectedIndex;
            switch (indice)
            {
                case 0:
                    numFilas = 2;
                    break;
                case 1:
                    numFilas = 3;
                    break;
                case 2:
                    numFilas = 4;
                    break;
                case 3:
                    numFilas = 5;
                    break;
                case 4:
                    numFilas = 6;
                    break;
            }
            pagFinal = numFilas;
            CargarDT();
        }




    }
}
