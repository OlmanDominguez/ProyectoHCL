﻿using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

namespace ProyectoHCL.Formularios
{
    public partial class CtrlServicios : Form
    {
        R_E_Servicio R_E_serv = new R_E_Servicio();
        AdmonServicios admonServ = new AdmonServicios();
        Servicio servicio = new Servicio();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        CDatos cDatos = new CDatos();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0;

        public CtrlServicios()
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
                        if (obj.IdObjeto == "SERVICIOS" && !obj.Permitido)
                        {
                            btnNuevo.Visible = false;
                        }
                        break;
                    case 3:
                        if (obj.IdObjeto == "SERVICIOS" && !obj.Permitido)
                        {
                            dgvServ.Columns["EDITAR"].Visible = false;
                        }
                        break;
                    case 4:
                        if (obj.IdObjeto == "SERVICIOS" && !obj.Permitido)
                        {
                            dgvServ.Columns["ELIMINAR"].Visible = false;
                        }
                        break;
                }
            }
        }

        private void CargarDG()
        {
            servicio.Inicio1 = pagInicio;
            servicio.Final1 = pagFinal;
            ds = servicio.PaginacionServicio();
            dgvServ.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtServ.Text = cantidad.ToString();

            cmbServ.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbServ.Items.Add(x.ToString());

            cmbServ.SelectedIndex = indice;

            HabilitarBotones();
        }

        private void CtrlServicios_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvServ.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvServ.Columns.Add(btnDelete);

            Permisos();
        }

        public void BuscarServicio(string buscarS)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarServicio", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreS", MySqlDbType.VarChar, 50).Value = buscarS;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvServ.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            R_E_serv.lblTitulo.Text = "Registrar Servicio";
            R_E_serv.ShowDialog();
            CargarDG();
        }

        private void dgvServ_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvServ.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvServ.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvServ.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvServ.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvServ.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvServ.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvServ.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvServ.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }


        }

        private void cmbServ_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbServ.Text);
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

        private void dgvServ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvServ.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    bool elimino = admonServ.EliminarServicio(dgvServ.CurrentRow.Cells["ID"].Value.ToString());

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

            if (this.dgvServ.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                R_E_serv.lblTitulo.Text = "Editar Servicio";
                R_E_serv.idS = dgvServ.CurrentRow.Cells["ID"].Value.ToString();
                R_E_serv.txtServ.Text = dgvServ.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                R_E_serv.txtPrecio.Text = dgvServ.CurrentRow.Cells["PRECIO"].Value.ToString();
                R_E_serv.cmbEstado.Text = dgvServ.CurrentRow.Cells["ESTADO"].Value.ToString();
                R_E_serv.ShowDialog();
                R_E_serv.limpiarCampos();
                CargarDG();
            }


        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbServ.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbServ.Text) + 1;
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

            if (indice == (Convert.ToInt32(txtServ.Text) - 1))
            {
                btnSig.Enabled = false;
            }
            else
            {
                btnSig.Enabled = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
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

            string[] columnas = { "Id", "Descripcion", "Precio", "Estado" };

            float[] tamanios = { 1, 3, 2, 2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql = "SELECT ID_SERVICIO AS ID, DESCRIPCION, PRECIO, ESTADO_SERVICIO AS ESTADO FROM TBL_SERVICIO";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
            // conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Id"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Descripcion"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Precio"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Estado"].ToString()).SetFont(fontContenido)));
            }

            documento.Add(tabla);
            documento.Close();

            var logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("C:/Users/jmont/OneDrive/Documentos/HM/ProyectoIP/logoCL.png")).SetWidth(50);
            var plogo = new Paragraph("").Add(logo);

            var nombre = new Paragraph("Hotel Casa Lomas");
            nombre.SetTextAlignment(TextAlignment.CENTER);
            nombre.SetFontSize(12);

            var titulo = new Paragraph("Reporte Servicios");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(14);
            titulo.SetBold();

            var dfecha = DateTime.Now.ToString("dd.MM.yyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter
                ("ReporteServicios.pdf"));
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
            doc.Close();
        }

        private void btnPdf_Click(object sender, EventArgs e)
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

            sl.SetCellValue("C2", "Reporte de Servicios");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_SERVICIO");
            sl.SetCellValue("B" + celdaCabecera, "Id");
            sl.SetCellValue("C" + celdaCabecera, "Descripcion");
            sl.SetCellValue("D" + celdaCabecera, "Precio");
            sl.SetCellValue("E" + celdaCabecera, "Estado");

            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "E" + celdaCabecera, estiloCa);

            string sql = "SELECT ID_SERVICIO AS ID, DESCRIPCION, PRECIO, ESTADO_SERVICIO AS ESTADO FROM TBL_SERVICIO";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["id"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["descripcion"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["precio"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["estado"].ToString());
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
            sf.FileName = "ExcelServicios";
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
