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
using SpreadsheetLight.Drawing;
using SpreadsheetLight;
using iText.IO.Font.Constants;
using iText.Kernel.Events;
using iText.Kernel.Font;
using Rectangle = iText.Kernel.Geom.Rectangle;
using Image = System.Drawing.Image;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf;
using Document = iText.Layout.Document;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using Point = System.Drawing.Point;

namespace ProyectoHCL.Formularios
{
    public partial class CtrlPreguntas : Form
    {
        ShowPregunta R_E_pregu = new ShowPregunta();
        clases.Preguntas servicio = new clases.Preguntas();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;
        CDatos cDatos = new CDatos();

        public CtrlPreguntas()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();
        }

        private void CargarDG()
        {
            servicio.Inicio1 = pagInicio;
            servicio.Final1 = pagFinal;
            ds = servicio.PaginacionPreguntas();
            dgvPreguntas.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPreg.Text = cantidad.ToString();

            cmbPreg.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPreg.Items.Add(x.ToString());

            cmbPreg.SelectedIndex = indice;

            HabilitarBotones();
        }


        public void BuscarServicio(string buscarS)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarPregunta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreP", MySqlDbType.VarChar, 50).Value = buscarS;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPreguntas.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }





        private void cmbPreg_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPreg.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void cmbMostrar_SelectedIndexChanged_1(object sender, EventArgs e)
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

        public static class preg
        {
            public static string detalle;
            public static int op;
            public static int id;
        }

        private void dgvPreguntas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvPreguntas.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    preg.detalle = dgvPreguntas.CurrentRow.Cells["PREGUNTA"].Value.ToString();
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //Consulta
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("UPDATE TBL_PREGUNTA SET ID_ESTADO = 2 WHERE PREGUNTA lIKE '%" +
                            preg.detalle + "%';");

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();
                        MsgB mbox = new MsgB("informacion", "Registro eliminado");
                        DialogResult dR = mbox.ShowDialog();
                        CargarDG();
                    }

                }
                else if (dg == DialogResult.Cancel)
                {

                }
            }

            if (this.dgvPreguntas.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                preg.detalle = dgvPreguntas.CurrentRow.Cells["PREGUNTA"].Value.ToString();
                preg.op = 1;
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("SELECT * FROM TBL_PREGUNTA WHERE PREGUNTA LIKE  '%" +
                        preg.detalle + "%';");
                    MySqlDataReader leer = comando.ExecuteReader();
                    while (leer.Read())
                    {
                        preg.id = Convert.ToInt32(leer["ID_PREGUNTA"]);
                    }

                    comando.Connection.Close();

                }
                Form formulario = new Formularios.ShowPregunta();
                formulario.ShowDialog();
                CargarDG();
            }


        }

        private void btnAnt_Click_1(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPreg.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSig_Click_1(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPreg.Text) + 1;
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

            if (indice == (Convert.ToInt32(txtPreg.Text) - 1))
            {
                btnSig.Enabled = false;
            }
            else
            {
                btnSig.Enabled = true;
            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarServicio(txtBuscar.Text);
            }
            else
            {
                CargarDG();
            }
        }

        private void Permisos() //función para asignar permisos a la pantalla
        {
            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs); //lista de objetos que recibe el rol para validar el permiso

            foreach (var obj in LsObj) //recorrer los objetos en la lista
            {
                switch (obj.IdPermiso) //restringir acceso según el permiso
                {
                    case 2: //permiso crear
                        if (obj.ObjetoN == "PREGUNTAS" && !obj.Permitido) //Validar pantalla y el permiso
                        {
                            btnNuevo.Visible = false; //Ocultar botón para crear
                            button11.Visible = false;
                            button10.Visible = false;
                        }
                        break;
                    case 3: //permiso editar
                        if (obj.ObjetoN == "PREGUNTAS" && !obj.Permitido)
                        {
                            dgvPreguntas.Columns["EDITAR"].Visible = false; //Ocultar columna del botón para editar en datagrid
                        }
                        break;
                    case 4: //permiso eliminar
                        if (obj.ObjetoN == "PREGUNTAS" && !obj.Permitido)
                        {
                            dgvPreguntas.Columns["ELIMINAR"].Visible = false; //Ocultar columna del botón para eliminar en datagrid
                        }
                        break;
                }
            }
        }

        private void CtrlPreguntas_Load_1(object sender, EventArgs e)
        {
            DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
            btnUpdate.Name = "EDITAR";
            dgvPreguntas.Columns.Add(btnUpdate);

            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
            btnDelete.Name = "ELIMINAR";
            dgvPreguntas.Columns.Add(btnDelete);

            Permisos();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            //R_E_pregu.label11.Text = "Registrar parametro";
            preg.op = 2;
            Form formulario = new Formularios.ShowPregunta();
            formulario.ShowDialog();
            CargarDG();
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

            sl.SetCellValue("C2", "Reporte de Preguntas");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_Pregunta");
            sl.SetCellValue("B" + celdaCabecera, "Id");
            sl.SetCellValue("C" + celdaCabecera, "Pregunta");
            sl.SetCellValue("D" + celdaCabecera, "Id Estado");
            sl.SetCellValue("E" + celdaCabecera, "Estado");


            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "E" + celdaCabecera, estiloCa);

            string sql = "Select f.ID_PREGUNTA, f.PREGUNTA, f.ID_ESTADO, e.DESCRIPCION from TBL_PREGUNTA f INNER JOIN TBL_ESTADO e ON f.ID_ESTADO = e.ID_ESTADO";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["ID_PREGUNTA"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["PREGUNTA"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["ID_ESTADO"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["DESCRIPCION"].ToString());

            }

            SLStyle EstiloB = sl.CreateStyle();
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "E" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B", "E");

            SaveFileDialog sf = new SaveFileDialog();

            sf.DefaultExt = "*.xlsx";
            sf.FileName = "ExcelPreguntas";
            sf.Filter = " Libro de Excel (*.xlsx) | *.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                sl.SaveAs(sf.FileName);
                MsgB mbox = new MsgB("informacion", "Archivo Excel creado con éxito");
                DialogResult dR = mbox.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            crearExcel();
        }

        private void dgvPreguntas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvPreguntas.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                Image imagen = Properties.Resources.editar;

                dgvPreguntas.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvPreguntas.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvPreguntas.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                Image imagen = Properties.Resources.eliminar;

                dgvPreguntas.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvPreguntas.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
        }

        private void dgvPreguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            crearPDF();
            MsgB mbox = new MsgB("informacion", "PDF creado con éxito");
            DialogResult dR = mbox.ShowDialog();
        }

        private void crearPDF() //función para crear pdf
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                PdfWriter pdfWriter = new PdfWriter(filePath);
                PdfDocument pdf = new PdfDocument(pdfWriter);
                PageSize tamanioH = new PageSize(792, 612);
                Document documento = new Document(pdf, tamanioH);
                documento.SetMargins(70, 20, 55, 20);

                PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                var logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("C:/Users/DAOdo/Desktop/SEGUNDO PERIODO 2023/Programacion he implementacion de Sistemas/logo.jpeg")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);

                var nombre = new Paragraph("Hotel Casa Lomas");
                nombre.SetFontSize(12);

                var titulo = new Paragraph("Preguntas");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(14).SetBold();

                var dfecha = DateTime.Now.ToString("dd.MM.yyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
                fecha.SetTextAlignment(TextAlignment.RIGHT);
                fecha.SetFontSize(12);

                documento.ShowTextAligned(plogo, 30, 600, 1, TextAlignment.LEFT, VerticalAlignment.TOP, 0);
                documento.ShowTextAligned(nombre, 100, 580, 1, TextAlignment.LEFT, VerticalAlignment.TOP, 0);
                documento.ShowTextAligned(titulo, 396, 580, 1, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                documento.ShowTextAligned(fecha, 760, 580, 1, TextAlignment.RIGHT, VerticalAlignment.TOP, 0);

                string[] columnas = { "id_pregunta", "pregunta", "descripcion" };

                float[] tamanios = { 1, 2, 2 };
                Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
                tabla.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (string columna in columnas)
                {
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
                }

                string sql = "Select f.ID_PREGUNTA, f.PREGUNTA, f.ID_ESTADO, e.DESCRIPCION from TBL_PREGUNTA f INNER JOIN TBL_ESTADO e ON f.ID_ESTADO = e.ID_ESTADO";

                MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
                // conexionBD.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["id_pregunta"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["pregunta"].ToString()).SetFont(fontContenido)));
                   // tabla.AddCell(new Cell().Add(new Paragraph(reader["estado"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["descripcion"].ToString()).SetFont(fontContenido)));
                   
                }

                documento.Add(tabla);

                pdf.AddEventHandler(PdfDocumentEvent.END_PAGE, new HeaderFooterEventHandler());

                documento.Close();
            }
        }

        private class HeaderFooterEventHandler : IEventHandler
        {
            public void HandleEvent(Event currentEvent)
            {
                PdfDocumentEvent docEvent = (PdfDocumentEvent)currentEvent;
                PdfDocument pdfDoc = docEvent.GetDocument();
                PdfPage page = docEvent.GetPage();
                int pageNumber = pdfDoc.GetPageNumber(page);
                PdfCanvas pdfCanvas = new PdfCanvas(page.NewContentStreamBefore(), page.GetResources(), pdfDoc);

                Rectangle pageSize = page.GetPageSize();
                pdfCanvas.BeginText()
                    .SetFontAndSize(PdfFontFactory.CreateFont(StandardFonts.HELVETICA), 12)
                    .MoveText(pageSize.GetLeft() + 396, 20)
                    .ShowText("Página " + pageNumber)
                    .EndText();
                pdfCanvas.Release();
            }
        }
    }
}
