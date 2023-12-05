using iText.IO.Font.Constants;
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
using Point = System.Drawing.Point;
using Image = System.Drawing.Image;
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas;
using Rectangle = iText.Kernel.Geom.Rectangle;

//-----------------------------------------------------------------------
//    Universidad Nacional Autonoma de Honduras (UNAH)
//		Facultad de Ciencias Economicas
//	Departamento de Informatica administrativa
//         Analisis, Programacion y Evaluacion de Sistemas
//                    Tercer Periodo 2023


//Equipo:
//GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

//HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

//NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

//JOEL ENRIQUE GODOY BONILLA---------(joel.bonilla@unah.hn)

//OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

//Catedratico analisis y diseño:             Lic.Giancarlo Martini Scalici Aguilar 
//catedratico programacion e implementacion: Lic.Karla Melisa Garcia Pineda 
//catedratico evaluacion de sistemas:        Lic.Karla Melisa Garcia Pineda 


//---------------------------------------------------------------------

//Programa:         Control Servicios
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Pantalla ABC donde se muestran los registros, se crean, editan y eliminan

//-----------------------------------------------------------------------

//                Historial de Cambio

//-----------------------------------------------------------------------

//Programador               Fecha                      Descripcion
//GABRIELA  MANCIA  

//HILDEGARD  MONTALVAN   

//NELSON SALGADO  

//JOEL  GODOY 

//OLMAN  DOMÍNGUEZ 

//-----------------------------------------------------------------------

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
            CargarDG(); //mostrar registros en datagridview
        }

        private void Permisos() //función para asignar permisos a la pantalla
        {
            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs); //lista de objetos que recibe el rol para validar el permiso

            foreach (var obj in LsObj)  //recorrer los objetos en la lista
            {
                switch (obj.IdPermiso) //restringir acceso según el permiso
                {
                    case 2: //permiso crear
                        if (obj.ObjetoN == "SERVICIOS" && !obj.Permitido)
                        {
                            btnNuevo.Visible = false; //Ocultar botón para crear
                            btnExcel.Visible = false;
                            btnPdf.Visible = false;
                        }
                        break;
                    case 3: //permiso editar
                        if (obj.ObjetoN == "SERVICIOS" && !obj.Permitido) //Ocultar columna del botón para editar en datagrid
                        {
                            dgvServ.Columns["EDITAR"].Visible = false;
                        }
                        break;
                    case 4: //permiso eliminar
                        if (obj.ObjetoN == "SERVICIOS" && !obj.Permitido) //Ocultar columna del botón para eliminar en datagrid
                        {
                            dgvServ.Columns["ELIMINAR"].Visible = false;
                        }
                        break;
                }
            }
        }

        private void CargarDG() //Cargar datagrid con registros utilizando la función de paginación
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
            DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
            btnUpdate.Name = "EDITAR";
            dgvServ.Columns.Add(btnUpdate);

            DataGridViewImageColumn btnEliminar = new DataGridViewImageColumn();
            btnEliminar.Name = "ELIMINAR";
            dgvServ.Columns.Add(btnEliminar);

            dgvServ.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Permisos(); //Llamar la función permisos al cargar formulario
        }

        public void BuscarServicio(string buscarS) //función para buscar un servicio
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

        private void cmbServ_SelectionChangeCommitted(object sender, EventArgs e) //Seleccionar página para mostrar registros
        {
            int pagina = Convert.ToInt32(cmbServ.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e) //Seleccionar la cantidad de registros a mostrar
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
            if (this.dgvServ.Columns[e.ColumnIndex].Name == "ELIMINAR") //si se dio click en el botón eliminar hacer lo siguiente
            {
                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                //eliminar registro
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

            if (this.dgvServ.Columns[e.ColumnIndex].Name == "EDITAR")  //si se dio click en el botón editar hacer lo siguiente
            {
                R_E_serv.lblTitulo.Text = "Editar Servicio";
                //obtener los datos del datagrid del registro seleccionado
                R_E_serv.idS = dgvServ.CurrentRow.Cells["ID"].Value.ToString();
                R_E_serv.txtServ.Text = dgvServ.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                R_E_serv.txtPrecio.Text = dgvServ.CurrentRow.Cells["PRECIO"].Value.ToString();
                R_E_serv.cmbEstado.Text = dgvServ.CurrentRow.Cells["ESTADO"].Value.ToString();
                R_E_serv.ShowDialog();
                R_E_serv.limpiarCampos();
                CargarDG();
            }


        }

        private void btnAnt_Click(object sender, EventArgs e) //botón anterior paginación
        {
            int pagina = Convert.ToInt32(cmbServ.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSig_Click(object sender, EventArgs e) //botón siguiente paginación
        {
            int pagina = Convert.ToInt32(cmbServ.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }
        private void HabilitarBotones() //mostrar los botones de anterior o siguiente
                                        //verificando si se está en la primera o ultima pagina
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
                BuscarServicio(txtBuscar.Text); //se llama la función para buscar registro
            }
            else
            {
                CargarDG();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar formulario
        }

        private void crearPDF() //función para crear pdf
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";

            saveFileDialog.FileName = "Servicios.pdf";

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

                iText.Layout.Element.Image logo;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    Properties.Resources.logo.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] logoBytes = memoryStream.ToArray();

                    // Crear la imagen con el MemoryStream
                    logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(logoBytes)).SetWidth(50);
                }

                var plogo = new Paragraph("").Add(logo);

                var nombre = new Paragraph("Hotel Casa Lomas");
                nombre.SetFontSize(12);

                var titulo = new Paragraph("Descuentos");
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

                string[] columnas = { "Id", "Descripcion", "Precio", "Estado" };

                float[] tamanios = { 1, 3, 2, 2 };
                Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
                tabla.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (string columna in columnas)
                {
                    if (columna.Equals("Precio"))
                    {
                        tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)).SetTextAlignment(TextAlignment.RIGHT));
                    }
                    else
                    {
                        tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
                    }
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

                    Cell porcentajeCell = new Cell().Add(new Paragraph(reader["Precio"].ToString()).SetFont(fontContenido));
                    porcentajeCell.SetTextAlignment(TextAlignment.RIGHT);
                    tabla.AddCell(porcentajeCell);

                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Estado"].ToString()).SetFont(fontContenido)));
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

        private void dgvServ_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvServ.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                Image imagen = Properties.Resources.editar;

                dgvServ.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvServ.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvServ.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                Image imagen = Properties.Resources.eliminar;

                dgvServ.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvServ.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
        }
    }
}
