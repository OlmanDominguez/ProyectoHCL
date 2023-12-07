using DocumentFormat.OpenXml.Vml;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Properties;
using Microsoft.VisualBasic.ApplicationServices;
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
using System.Reflection.Metadata;
using Document = iText.Layout.Document;
using iText.Kernel.Geom;
using iText.Layout.Element;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using static ProyectoHCL.RecuContra; //Para uso del user y IDUser iniciado
using System.Windows.Controls;
using Point = System.Drawing.Point;
using iText.IO.Image;
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas;
using Rectangle = iText.Kernel.Geom.Rectangle;
using System.Reflection;
using Image = System.Drawing.Image;
using DocumentFormat.OpenXml.Spreadsheet;
using Color = System.Drawing.Color;
using Table = iText.Layout.Element.Table;
using Cell = iText.Layout.Element.Cell;

namespace ProyectoHCL.Formularios
{
    public partial class CtrlTipoHabitacion : Form
    {
        R_E_TipHab R_E_tip = new R_E_TipHab();
        AdmonTipHab admonTipHab = new AdmonTipHab();
        TipoHabitacion tipHab = new TipoHabitacion();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        CDatos cDatos = new CDatos();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0;

        public CtrlTipoHabitacion()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG(); //Mostrar registros en datagridwiew
        }

        private void Permisos() //Función para asignar permisos
        {
            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs);

            foreach (var obj in LsObj)
            {
                switch (obj.IdPermiso)
                {
                    case 2:
                        if (obj.ObjetoN == "TIPO HABITACION" && !obj.Permitido)
                        {
                            btnNuevo.Visible = false;
                            btnExcel.Visible = false;
                            btnPdf.Visible = false;
                        }
                        break;
                    case 3:
                        if (obj.ObjetoN == "TIPO HABITACION" && !obj.Permitido)
                        {
                            dgvTH.Columns["EDITAR"].Visible = false;
                        }
                        break;
                    case 4:
                        if (obj.ObjetoN == "TIPO HABITACION" && !obj.Permitido)
                        {
                            dgvTH.Columns["ELIMINAR"].Visible = false;
                        }
                        break;
                }
            }
        }

        private void CargarDG()
        {
            tipHab.Inicio1 = pagInicio;
            tipHab.Final1 = pagFinal;
            ds = tipHab.PaginacionTipoHab();
            dgvTH.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPagTH.Text = cantidad.ToString();

            cboxPag.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cboxPag.Items.Add(x.ToString());

            cboxPag.SelectedIndex = indice;

            HabilitarBotones();
        }

        private void CtrlTipoHabitacion_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
            btnUpdate.Name = "EDITAR";
            dgvTH.Columns.Add(btnUpdate);

            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
            btnDelete.Name = "ELIMINAR";
            dgvTH.Columns.Add(btnDelete);

            Permisos();
        }

        public void BuscarTipHab(string buscarTH)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarTipHab", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreTH", MySqlDbType.VarChar, 50).Value = buscarTH;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTH.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            R_E_tip.lblTitulo.Text = "Registrar Tipo de Habitación";
            R_E_tip.ShowDialog();
            CargarDG();
        }

        private void cboxPag_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cboxPag.Text);
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

        private void dgvTH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvTH.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    bool elimino = admonTipHab.EliminarTipHab(dgvTH.CurrentRow.Cells["ID"].Value.ToString());

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

            if (this.dgvTH.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                R_E_tip.lblTitulo.Text = "Editar Tipo de Habitación";

                R_E_tip.idTH = dgvTH.CurrentRow.Cells["ID"].Value.ToString();
                R_E_tip.txtTipo.Text = dgvTH.CurrentRow.Cells["TIPO"].Value.ToString();
                R_E_tip.txtCapacidad.Text = dgvTH.CurrentRow.Cells["CAPACIDAD"].Value.ToString();
                R_E_tip.txtPrecio.Text = dgvTH.CurrentRow.Cells["PRECIO"].Value.ToString();
                R_E_tip.cmbEstado.Text = dgvTH.CurrentRow.Cells["ESTADO"].Value.ToString();
                R_E_tip.ShowDialog();
                R_E_tip.limpiarCampos();
                CargarDG();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarTipHab(txtBuscar.Text);
            }
            else
            {
                CargarDG();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cboxPag.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cboxPag.Text) + 1;
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

            if (indice == (Convert.ToInt32(txtPagTH.Text) - 1))
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

        private void crearPDF() //Función para crear PDF
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";

            saveFileDialog.FileName = "Tipo de Habitación.pdf";

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

               /* iText.Layout.Element.Image logo;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    Properties.Resources.logo.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] logoBytes = memoryStream.ToArray();

                    logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(logoBytes)).SetWidth(50);
                }
               */

               var logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("C:/Users/HP TOUCH/source/repos/OlmanDominguez/ProyectoHCL/Logo HCL.jpeg")).SetWidth(50);
               var plogo = new Paragraph("").Add(logo);

                var nombre = new Paragraph("Hotel Casa Lomas");
                nombre.SetFontSize(12);

                var titulo = new Paragraph("Tipo de Habitación");
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

                string[] columnas = { "Id", "Tipo", "Capacidad", "Precio" };

                float[] tamanios = { 1, 3, 2, 3, 2, 2, 2, 2 };
                Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
                tabla.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (string columna in columnas)
                {
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
                }

                string sql = "SELECT ID_TIPOHABITACION AS ID, TIPO, CAPACIDAD, PRECIO FROM TBL_TIPOHABITACION";

                MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
                // conexionBD.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Id"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Tipo"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Capacidad"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Precio"].ToString()).SetFont(fontContenido))); 
                }

                documento.Add(tabla);

                pdf.AddEventHandler(PdfDocumentEvent.END_PAGE, new HeaderFooterEventHandler());

                documento.Close();
            }
        }

        private class HeaderFooterEventHandler : IEventHandler //Pie de página
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            crearPDF();
            MsgB mbox = new MsgB("informacion", "PDF creado con éxito");
            DialogResult dR = mbox.ShowDialog();
        }

        private void crearExcel() //función para crear excel
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

            sl.SetCellValue("C2", "Reporte de Usuarios");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_TIPOHABITACION");
            sl.SetCellValue("B" + celdaCabecera, "Id");
            sl.SetCellValue("C" + celdaCabecera, "Tipo");
            sl.SetCellValue("D" + celdaCabecera, "Capacidad");
            sl.SetCellValue("E" + celdaCabecera, "Precio");

            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "I" + celdaCabecera, estiloCa);

            string sql = "SELECT ID_TIPOHABITACION AS ID, TIPO, CAPACIDAD, PRECIO FROM TBL_TIPOHABITACION";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["id"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["tipo"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["capacidad"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["precio"].ToString());
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
            sf.FileName = "ExcelTipoHabitacion";
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

        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvUsuarios.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                Image imagen = Properties.Resources.editar;

                dgvUsuarios.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvUsuarios.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvUsuarios.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                Image imagen = Properties.Resources.eliminar;

                dgvUsuarios.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvUsuarios.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
        }

        private void dgvTH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvTH.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                Image imagen = Properties.Resources.editar;

                dgvTH.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvTH.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvTH.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                Image imagen = Properties.Resources.eliminar;

                dgvTH.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvTH.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }

        }
    }
}
