using iText.Kernel.Pdf;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Metadata;
using Document = iText.Layout.Document;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using static iText.Kernel.Pdf.Colorspace.PdfDeviceCs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using DocumentFormat.OpenXml.Office2013.Excel;

namespace ProyectoHCL.Formularios
{
    public partial class CtrlDescuentos : Form
    {
        R_E_Descuento R_E_desc = new R_E_Descuento();
        AdmonDescuento admonDesc = new AdmonDescuento();
        Descuentos descuento = new Descuentos();
        MsgB msgB = new MsgB();
        DataSet ds = new DataSet();
        CDatos cDatos = new CDatos();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0;

        public CtrlDescuentos()
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
                        if (obj.IdObjeto == "DESCUENTOS" && !obj.Permitido) //Validar pantalla y el permiso
                        {
                            btnNuevo.Visible = false; //Ocultar botón para crear
                        }
                        break;
                    case 3:
                        if (obj.IdObjeto == "DESCUENTOS" && !obj.Permitido)
                        {
                            dgvDesc.Columns["EDITAR"].Visible = false; //Ocultar columna del botón para editar en datagrid
                        }
                        break;
                    case 4:
                        if (obj.IdObjeto == "DESCUENTOS" && !obj.Permitido)
                        {
                            dgvDesc.Columns["ELIMINAR"].Visible = false; //Ocultar columna del botón para eliminar en datagrid
                        }
                        break;
                }
            }
        }
        private void CargarDG()
        {
            descuento.Inicio1 = pagInicio;
            descuento.Final1 = pagFinal;
            ds = descuento.PaginacionDescuento();
            dgvDesc.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtDesc.Text = cantidad.ToString();

            cmbDesc.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbDesc.Items.Add(x.ToString());

            cmbDesc.SelectedIndex = indice;

            HabilitarBotones();
        }

        private void CtrlDescuentos_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvDesc.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvDesc.Columns.Add(btnDelete);

            Permisos();
        }

        public void BuscarDescuento(string buscarD)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarDescuento", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreD", MySqlDbType.VarChar, 200).Value = buscarD;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDesc.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            R_E_desc.lblTitulo.Text = "Registrar Descuento";
            R_E_desc.ShowDialog();
            CargarDG();
        }

        private void dgvDesc_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvDesc.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvDesc.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvDesc.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvDesc.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvDesc.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvDesc.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvDesc.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvDesc.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        private void cmbDesc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbDesc.Text);
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
                    numFilas = 10;
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

        private void dgvDesc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDesc.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    bool elimino = admonDesc.EliminarDescuento(dgvDesc.CurrentRow.Cells["ID"].Value.ToString());

                    if (elimino)
                    {
                        MsgB mbox = new MsgB("informacion", "Registro eliminado");
                        DialogResult dR = mbox.ShowDialog();
                        CargarDG();
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

            if (this.dgvDesc.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                R_E_desc.lblTitulo.Text = "Editar Descuento";
                R_E_desc.idDesc = dgvDesc.CurrentRow.Cells["ID"].Value.ToString();
                R_E_desc.txtDesc.Text = dgvDesc.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                R_E_desc.txtPorcentaje.Text = dgvDesc.CurrentRow.Cells["PORCENTAJE"].Value.ToString();
                R_E_desc.cmbEstado.Text = dgvDesc.CurrentRow.Cells["ESTADO"].Value.ToString();
                R_E_desc.ShowDialog();
                R_E_desc.limpiarCampos();
                CargarDG();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarDescuento(txtBuscar.Text);
            }
            else
            {
                CargarDG();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbDesc.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbDesc.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void HabilitarBotones()
        {
            if (pagInicio == 1)
            {
                btnAnterior.Enabled = false;
                cmbMostrar.Enabled = true;
            }
            else
            {
                btnAnterior.Enabled = true;
                cmbMostrar.Enabled = false;
            }

            if (indice == (Convert.ToInt32(txtDesc.Text) - 1))
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("Reporte.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            //1 pulgada = 72 pt (8 1/2 x 11) (612 x 792) 
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);
            // Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(70, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "Id", "Descripcion", "Porcentaje", "Creado_Por", "Actualizado_Por" };

            float[] tamanios = { 1, 2, 2, 3, 3 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql = "SELECT id_descuento as id, descripcion, porcentaje, creado_por, actualizado_por FROM TBL_DESCUENTO";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
            // conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(reader["id"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["descripcion"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["porcentaje"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["creado_por"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["actualizado_por"].ToString()).SetFont(fontContenido)));
            }

            documento.Add(tabla);
            documento.Close();

            var logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("C:/Users/jmont/OneDrive/Documentos/HM/ProyectoIP/logoCL.png")).SetWidth(50);
            var plogo = new Paragraph("").Add(logo);

            var nombre = new Paragraph("Hotel Casa Lomas");
            nombre.SetTextAlignment(TextAlignment.CENTER);
            nombre.SetFontSize(12);

            var titulo = new Paragraph("Reporte Descuentos");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(14);
            titulo.SetBold();

            var dfecha = DateTime.Now.ToString("dd.MM.yyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter
                ("ReporteDescuentos.pdf"));
            Document doc = new Document(pdfDoc);

            int numeros = pdfDoc.GetNumberOfPages();

            for (int i = 1; i <= numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);

                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(nombre, 115, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 396, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 700, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("pagina {0} de {1}", i, numeros)), pdfDoc.GetPage
                    (i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i,
                    TextAlignment.CENTER, VerticalAlignment.TOP, 0);
            }

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "PDF document (*.pdf)|*.pdf";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                string fileName = sf.FileName;


            }

            //sfd.Title = "Save As PDF";
            //sfd.Filter = "(*.pdf)|*.pdf";
            //sfd.InitialDirectory = @"C:\";
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //   dialog.Title = "Generate PDF";
            //dialog.Filter = "PDF document (*.pdf)|*.pdf";
            //DialogResult result = dialog.ShowDialog();
            //string fileName = dialog.FileName;
            //if (result == DialogResult.OK)
            //{
            //    document.Save(fileName);
            //}
            //}

            doc.Close();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            crearPDF();
            MsgB mbox = new MsgB("informacion", "PDF creado con éxito");
            DialogResult dR = mbox.ShowDialog();
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

            sl.SetCellValue("C2", "Reporte de Descuentos");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_DESCUENTO");
            sl.SetCellValue("B" + celdaCabecera, "Id");
            sl.SetCellValue("C" + celdaCabecera, "Descripcion");
            sl.SetCellValue("D" + celdaCabecera, "Porcentaje");
            sl.SetCellValue("E" + celdaCabecera, "Creado por");
            sl.SetCellValue("F" + celdaCabecera, "Actualizado por");

            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "F" + celdaCabecera, estiloCa);

            string sql = "SELECT id_descuento as id, descripcion, porcentaje, creado_por, actualizado_por FROM TBL_DESCUENTO";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["id"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["descripcion"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["porcentaje"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["creado_por"].ToString());
                sl.SetCellValue("F" + celdaCabecera, reader["actualizado_por"].ToString());
            }

            SLStyle EstiloB = sl.CreateStyle();
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "F" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B", "F");

            SaveFileDialog sf = new SaveFileDialog();

            sf.DefaultExt = "*.xlsx";
            sf.FileName = "ExcelDescuentos";
            sf.Filter = " Libro de Excel (*.xlsx) | *.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                sl.SaveAs(sf.FileName);
                MsgB mbox = new MsgB("informacion", "Archivo Excel creado con éxito");
                DialogResult dR = mbox.ShowDialog();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            crearExcel();
        }

        private void btnNuevo_EnabledChanged(object sender, EventArgs e)
        {
            btnNuevo.BackColor = Color.DarkGray;
        }
    }
}
