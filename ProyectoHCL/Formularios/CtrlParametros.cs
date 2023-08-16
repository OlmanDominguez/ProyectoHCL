using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Point = System.Drawing.Point;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;//todas estas librerias son para imprimir un documento de aqui en adelante
using Document = iText.Layout.Document;
using iText.Kernel.Geom;
using iText.Layout.Element;
using PageSize = iText.Kernel.Geom.PageSize;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using DocumentFormat.OpenXml.Vml;
using SpreadsheetLight.Drawing;
using SpreadsheetLight;

namespace ProyectoHCL.Formularios
{
    public partial class CtrlParametros : Form
    {

        R_E_Parametro R_E_pmo = new R_E_Parametro();
        AdmonParametros admonParametro = new AdmonParametros();
        Parametros parametro = new Parametros();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        CDatos cDatos = new CDatos();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0;

        public CtrlParametros()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();

        }

        private void CargarDG()
        {
            parametro.Inicio1 = pagInicio;
            parametro.Final1 = pagFinal;
            ds = parametro.PaginacionParametro();
            dgvParametro.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPagP.Text = cantidad.ToString();

            cmbPagP.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPagP.Items.Add(x.ToString());

            cmbPagP.SelectedIndex = indice;

            //HabilitarBotones();
        }

        private void CtrlParametros_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvParametro.Columns.Add(btnUpdate);
        }

        public void BuscarParametro(string buscarP)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarParametro", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreP", MySqlDbType.VarChar, 50).Value = buscarP;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvParametro.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnnuevoP_Click(object sender, EventArgs e)
        {
            R_E_pmo.lbPar.Text = "Registrar Parametro";
            R_E_pmo.Size = new System.Drawing.Size(800, 431);
            R_E_pmo.btnGuardar.Location = new Point(256, 282);
            R_E_pmo.btnCancelar.Location = new Point(466, 282);
            R_E_pmo.label2.Location = new Point(243, 34);
            R_E_pmo.texPa.Location = new Point(243, 65);
            R_E_pmo.label6.Visible = true;
            R_E_pmo.txtValor.Visible = true;
            R_E_pmo.ShowDialog();
            CargarDG();

        }

        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscarP.Text != "")
            {
                BuscarParametro(txtBuscarP.Text);
            }
            else
            {
                CargarDG();
            }

        }

        private void dgvParametro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvParametro.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvParametro.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvParametro.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvParametro.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            crearPDF();
        }
        private void crearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("Prueba.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            //1 pulgada = 72 pt (8 1/2 x 11) (612 x 792)
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);
            // Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "id_parametro", "id_usuario", "parametro", "valor", "fecha_ ", "feecha_modifi" };

            float[] tamanios = { 2, 2, 2, 2, 4, 4, };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql = "SELECT id_parametro, id_usuario, parametro, valor,  fecha_cre , fecha_modifi FROM TBL_PARAMETRO";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
            // conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                {


                    tabla.AddCell(new Cell().Add(new Paragraph(reader["id_parametro"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["id_usuario"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["parametro"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["valor"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_cre"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_modifi"].ToString()).SetFont(fontContenido)));

                }
            }

            documento.Add(tabla);
            documento.Close();

            var logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("C:/Users/DAOdo/Desktop/SEGUNDO PERIODO 2023/Programacion he implementacion de Sistemas/ProyectoHotelCasaLomas/logo.jpeg")).SetWidth(50);
            var plogo = new Paragraph("").Add(logo);

            var nombre = new Paragraph("Hotel Casa Lomas");
            nombre.SetTextAlignment(TextAlignment.CENTER);
            nombre.SetFontSize(12);

            var titulo = new Paragraph("Reporte Parametro");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd.MM.yyy");
            var dhora = DateTime.Now.ToString("hh.mm.ss");
            var fecha = new Paragraph("fecha:" + dfecha + "\nHora:" + dhora);
            fecha.SetFontSize(12);


            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter
                ("Reporte Parametro.pdf"));
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

        private void crearExcel()
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

            sl.SetCellValue("C2", "Reporte de Parametros");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "i2");


            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_PARAMETRO");
            sl.SetCellValue("B" + celdaCabecera, "id_parametro");
            sl.SetCellValue("C" + celdaCabecera, "parametro");
            sl.SetCellValue("D" + celdaCabecera, "valor");
            sl.SetCellValue("E" + celdaCabecera, "fecha creacion");
            sl.SetCellValue("F" + celdaCabecera, "fecha modificacion");


            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Red, System.Drawing.Color.Red);
            sl.SetCellStyle("B" + celdaCabecera, "F" + celdaCabecera, estiloCa);

            string sql = "SELECT id_Parametro, parametro, valor,  fecha_creacion, fecha_actualizacion FROM TBL_ROL";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
            // conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["id_parametro"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["parametro"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["Valor"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["fecha_creacion"].ToString());
                sl.SetCellValue("F" + celdaCabecera, reader["fecha_modificacion"].ToString());

            }

            SLStyle EstiloB = sl.CreateStyle();
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "F" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B", "F");


            sl.SaveAs("Excel.xlsx");
        }




        private void cmbPagP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagP.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void pmtMostrar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbIndice = pmtMostrar.SelectedIndex;
            switch (cmbIndice)
            {
                case 0:
                    numFilas = 5;
                    break;
                case 1:
                    numFilas = 20;
                    break;
                case 2:
                    numFilas = 30;
                    break;
                case 3:
                    numFilas = 40;
                    break;
                case 4:
                    numFilas = 50;
                    break;
            }
            pagFinal = numFilas;
            CargarDG();
        }

        private void dgvParametro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvParametro.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                R_E_pmo.lbPar.Text = "Editar Parametro";
                R_E_pmo.Size = new System.Drawing.Size(800, 371);
                R_E_pmo.btnGuardar.Location = new Point(256, 213);
                R_E_pmo.btnCancelar.Location = new Point(466, 213);
                R_E_pmo.label2.Location = new Point(59, 34);
                R_E_pmo.texPa.Location = new Point(59, 67);
                R_E_pmo.label6.Location = new Point(59, 115);
                R_E_pmo.txtValor.Location = new Point(59, 146);
                R_E_pmo.label6.Visible = true;
                R_E_pmo.txtValor.Visible = true;
                // R_E_pmo.label6.Location = new Point(421, 34);
                // R_E_pmo.rTxtDesc.Location = new Point(421, 65);
                R_E_pmo.idpar = dgvParametro.CurrentRow.Cells["ID_P"].Value.ToString();
                R_E_pmo.texPa.Text = dgvParametro.CurrentRow.Cells["PARAMETRO"].Value.ToString();
                R_E_pmo.txtValor.Text = dgvParametro.CurrentRow.Cells["VALOR"].Value.ToString();
                R_E_pmo.ShowDialog();
                R_E_pmo.limpiarCampos();
                CargarDG();
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagP.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagP.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            crearExcel();
        }

        private void btnnuevoP_EnabledChanged(object sender, EventArgs e)
        {
            btnnuevoP.BackColor = Color.DarkGray;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
