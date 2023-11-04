/*
 * -----------------------------------------------------------------------
	Universidad Nacional Autonoma de Honduras (UNAH)
		Facultad de Ciencias Economicas
	Departamento de Informatica administrativa
         Analisis, Programacion y Evaluacion de Sistemas
                    Tercer Periodo 2023


Equipo:
GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

JOEL ENRIQUE GODOY BONILLA---------(joel.bonilla@unah.hn)

OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

Catedratico analisis y diseño:             Lic. Giancarlo Martini Scalici Aguilar 
catedratico programacion e implementacion: Lic. Karla Melisa Garcia Pineda 
catedratico evaluacion de sistemas:        Lic. Karla Melisa Garcia Pineda 


---------------------------------------------------------------------

Programa:         Pantalla de reservaciones
Fecha:             25-09-2023
Programador:       Nelson Salgado
descripcion:       Pantalla en la que se puden ver y administrar las reservaciones 

-----------------------------------------------------------------------
using DocumentFormat.OpenXml.Vml;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Properties;
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
using Image = iText.Layout.Element.Image;
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas;
using Rectangle = iText.Kernel.Geom.Rectangle;
using System.Reflection;
 */
using System;
using DocumentFormat.OpenXml.Vml;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using SpreadsheetLight.Drawing;
using SpreadsheetLight;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout.Properties;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Events;
using Document = iText.Layout.Document;
using iText.Kernel.Geom;
using Rectangle = iText.Kernel.Geom.Rectangle;
using iText.Layout.Element;
using Point = System.Drawing.Point;
using ProyectoHCL.Formularios;

namespace ProyectoHCL
{
    public partial class Reservaciones : Form
    {

        AdminReserva adminReserva = new AdminReserva();
        NuevaReservacion reservacion = new NuevaReservacion();
        DatosReserva reserva = new DatosReserva();
        DataSet ds = new DataSet();
        CDatos cDatos = new CDatos();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;
        public Reservaciones()
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
                        if (obj.ObjetoN == "RESERVACION" && !obj.Permitido)
                        {
                            btnNuevo.Visible = false;
                        }
                        break;
                    case 3:
                        if (obj.ObjetoN == "RESERVACION" && !obj.Permitido)
                        {
                            dgv_reservaciones.Columns["EDITAR"].Visible = false;
                        }
                        break;
                    case 4:
                        if (obj.ObjetoN == "RESERVACION" && !obj.Permitido)
                        {
                            dgv_reservaciones.Columns["ELIMINAR"].Visible = false;
                        }
                        break;
                    case 5:
                        if (obj.ObjetoN == "RESERVACION" && !obj.Permitido)
                        {
                            dgv_reservaciones.Columns["VER"].Visible = false;
                        }
                        break;
                }
            }
        }

        private void CargarDG()
        {
            adminReserva.Inicio1 = pagInicio;
            adminReserva.Final1 = pagFinal;
            ds = adminReserva.PaginacionReserva();
            dgv_reservaciones.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            TXT_PAGINACION_X.Text = cantidad.ToString();

            CB_PAGINACION_R.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                CB_PAGINACION_R.Items.Add(x.ToString());

            CB_PAGINACION_R.SelectedIndex = indice;


        }
        public void BuscarReserva(string buscarU) //Recibe string para buscar usuarios
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarReserva", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreU", MySqlDbType.VarChar, 50).Value = buscarU; //recibe el parametro nombreU definido en el parametro almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                dgv_reservaciones.DataSource = dt; //se define la tabla en la que se devuelven los registros
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void Reservaciones_Load(object sender, EventArgs e)
        {
                        
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn(); //se crea el boton en el dataGrid
            btnUpdate.Name = "EDITAR";//Nombre del boton 
            dgv_reservaciones.Columns.Add(btnUpdate); //Se especifica el nombre de dataGrid para agregar boton

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgv_reservaciones.Columns.Add(btnDelete);
            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
            btnVer.Name = "VER";
            dgv_reservaciones.Columns.Add(btnVer);
            Permisos();
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnNuevo_Click_2(object sender, EventArgs e)
        {
            Form nuevo = new NuevaReservacion();
            nuevo.Show();

        }



        private void dgv_reservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_reservaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgv_reservaciones.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgv_reservaciones.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgv_reservaciones.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgv_reservaciones.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgv_reservaciones.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgv_reservaciones.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgv_reservaciones.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgv_reservaciones.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgv_reservaciones.Columns[e.ColumnIndex].Name == "VER" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgv_reservaciones.Rows[e.RowIndex].Cells["VER"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\ver.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgv_reservaciones.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgv_reservaciones.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        private void dgv_reservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_reservaciones.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    bool elimino = adminReserva.EliminarReserva(dgv_reservaciones.CurrentRow.Cells["ID"].Value.ToString());

                    if (elimino)
                    {
                        MsgB mbox = new MsgB("informacion", "Registro eliminado");
                        DialogResult dR = mbox.ShowDialog();
                        CargarDG();
                        //CargarReservas();

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
            if (this.dgv_reservaciones.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                reservacion.lbl_titulo.Text = "Editar Reservacion";
                reservacion.txt_id_solicitud.Text = dgv_reservaciones.CurrentRow.Cells["ID"].Value.ToString();
                reservacion.lbl_1c.Visible = true;
                reservacion.lbl_cliente.Visible = true;             
                reservacion.lbl_cliente.Text= dgv_reservaciones.CurrentRow.Cells["NOMBRE"].Value.ToString();
                
                reservacion.ShowDialog();

                CargarDG();
            }
            if (this.dgv_reservaciones.Columns[e.ColumnIndex].Name == "VER")
            {
                Form formulario = new DatosReserva();
                formulario.Show();

                CargarDG();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar_reservas.Text != "") //si el textbox no está vacío devuelve el metodo buscar usuarios
            {
                BuscarReserva(txtBuscar_reservas.Text); //El metodo recibe el string desde el textbox
            }
            else
            {
                CargarDG();
                //CargarReservas(); //Si el textbox está vacio devuelve el metodo mostrar usuarios 
            }
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(CB_PAGINACION_R.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(CB_PAGINACION_R.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
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

            sl.SetCellValue("C2", "Reporte de Reservaciones");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_SOLICITUDRESERVA");
            sl.SetCellValue("B" + celdaCabecera, "Id");
            sl.SetCellValue("C" + celdaCabecera, "Fecha");
            sl.SetCellValue("D" + celdaCabecera, "Ingreso");
            sl.SetCellValue("E" + celdaCabecera, "Salida");
            sl.SetCellValue("F" + celdaCabecera, "Huespedes");
            sl.SetCellValue("G" + celdaCabecera, "Nombre");
            sl.SetCellValue("H" + celdaCabecera, "Estado");
            sl.SetCellValue("I" + celdaCabecera, "Habitacion");

            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "I" + celdaCabecera, estiloCa);

            string sql = "select TBL_SOLICITUDRESERVA.ID_SOLICITUDRESERVA AS ID,TBL_SOLICITUDRESERVA.FECHACOTI AS FECHA, TBL_SOLICITUDRESERVA.INGRESO, TBL_SOLICITUDRESERVA.SALIDA, TBL_SOLICITUDRESERVA.NHUESPEDES AS HUESPEDES ,concat(TBL_CLIENTE.NOMBRE,\", \",TBL_CLIENTE.APELLIDO) AS NOMBRE, TBL_ESTADORESERVA.DESCRIPCION AS ESTADO,\r\nTBL_SOLICITUDRESERVA.NUMEROHABITACION AS HABITACION\r\nFROM TBL_CLIENTE INNER JOIN TBL_SOLICITUDRESERVA ON TBL_CLIENTE.CODIGO=TBL_SOLICITUDRESERVA.COD_CLIENTE\r\nINNER JOIN TBL_ESTADORESERVA ON TBL_SOLICITUDRESERVA.ID_ESTADORESERVA=TBL_ESTADORESERVA.ID_ESTADORESERVA\r\nINNER JOIN TBL_DETALLERESERVA ON TBL_ESTADORESERVA.ID_ESTADORESERVA=TBL_DETALLERESERVA.ID_DETALLERESERVA\r\nINNER JOIN TBL_HABITACION ON TBL_DETALLERESERVA.ID_HABITACION=TBL_HABITACION.ID_HABITACION ";


            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["ID"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["FECHA"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["INGRESO"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["SALIDA"].ToString());
                sl.SetCellValue("F" + celdaCabecera, reader["HUESPEDES"].ToString());
                sl.SetCellValue("G" + celdaCabecera, reader["NOMBRE"].ToString());
                sl.SetCellValue("H" + celdaCabecera, reader["ESTADO"].ToString());
                sl.SetCellValue("I" + celdaCabecera, reader["HABITACION"].ToString());
            }

            SLStyle EstiloB = sl.CreateStyle();
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "I" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B", "I");

            SaveFileDialog sf = new SaveFileDialog();

            sf.DefaultExt = "*.xlsx";
            sf.FileName = "ExcelReservas";
            sf.Filter = " Libro de Excel (*.xlsx) | *.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                sl.SaveAs(sf.FileName);
                MsgB mbox = new MsgB("informacion", "Archivo Excel creado con éxito");
                DialogResult dR = mbox.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            crearExcel();
        }

        private void crearPDF()
        {/*
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
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

                string[] columnas = { "ID", "FECHA", "INGRESO", "SALIDA", "HUESPEDES", "NOMBRE", "ESTADO", "HABITACION" };

                float[] tamanios = { 1, 3, 2, 3, 2, 2, 2, 2 };
                Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
                tabla.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (string columna in columnas)
                {
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
                }

                string sql = "select TBL_SOLICITUDRESERVA.ID_SOLICITUDRESERVA AS ID,TBL_SOLICITUDRESERVA.FECHACOTI AS FECHA, TBL_SOLICITUDRESERVA.INGRESO, TBL_SOLICITUDRESERVA.SALIDA, TBL_SOLICITUDRESERVA.NHUESPEDES AS HUESPEDES ,concat(TBL_CLIENTE.NOMBRE,\", \",TBL_CLIENTE.APELLIDO) AS NOMBRE, TBL_ESTADORESERVA.DESCRIPCION AS ESTADO,\r\nTBL_SOLICITUDRESERVA.NUMEROHABITACION AS HABITACION\r\nFROM TBL_CLIENTE INNER JOIN TBL_SOLICITUDRESERVA ON TBL_CLIENTE.CODIGO=TBL_SOLICITUDRESERVA.COD_CLIENTE\r\nINNER JOIN TBL_ESTADORESERVA ON TBL_SOLICITUDRESERVA.ID_ESTADORESERVA=TBL_ESTADORESERVA.ID_ESTADORESERVA\r\nINNER JOIN TBL_DETALLERESERVA ON TBL_ESTADORESERVA.ID_ESTADORESERVA=TBL_DETALLERESERVA.ID_DETALLERESERVA\r\nINNER JOIN TBL_HABITACION ON TBL_DETALLERESERVA.ID_HABITACION=TBL_HABITACION.ID_HABITACION ";


                MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
                // conexionBD.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["ID"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["FECHA"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["INGRESO"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["SALIDA"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["HUESPEDES"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["NOMBRE"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["ESTADO"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["HABITACION"].ToString()).SetFont(fontContenido)));
                }

                documento.Add(tabla);
                documento.Close();

                var logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("C:/Users/nelso/source/repos/OlmanDominguez/ProyectoHCL/ProyectoHCL/Resources/logo.png")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);

                var nombre = new Paragraph("Hotel Casa Lomas");
                nombre.SetTextAlignment(TextAlignment.CENTER);
                nombre.SetFontSize(12);

                var titulo = new Paragraph("Reporte de las Reservaciones");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(14);
                titulo.SetBold();

                var dfecha = DateTime.Now.ToString("dd.MM.yyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
                fecha.SetFontSize(12);

                PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter
                    ("ReporteReservaciones.pdf"));
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
            }*/

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

                //pdf.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler());

                var logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("C:/Users/nelso/source/repos/OlmanDominguez/ProyectoHCL/ProyectoHCL/Resources/logo.png")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);

                var nombre = new Paragraph("Hotel Casa Lomas");
                nombre.SetFontSize(12);

                var titulo = new Paragraph("Reservas");
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

                string[] columnas = { "ID", "FECHA", "INGRESO", "SALIDA", "HUESPEDES", "NOMBRE", "ESTADO", "HABITACION" };

                float[] tamanios = { 1, 3, 2, 3, 2, 2, 2, 2 };
                Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
                tabla.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (string columna in columnas)
                {
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
                }

                string sql = "select TBL_SOLICITUDRESERVA.ID_SOLICITUDRESERVA AS ID,TBL_SOLICITUDRESERVA.FECHACOTI AS FECHA, TBL_SOLICITUDRESERVA.INGRESO, TBL_SOLICITUDRESERVA.SALIDA, TBL_SOLICITUDRESERVA.NHUESPEDES AS HUESPEDES ,concat(TBL_CLIENTE.NOMBRE,\", \",TBL_CLIENTE.APELLIDO) AS NOMBRE, TBL_ESTADORESERVA.DESCRIPCION AS ESTADO,\r\nTBL_SOLICITUDRESERVA.NUMEROHABITACION AS HABITACION\r\nFROM TBL_CLIENTE INNER JOIN TBL_SOLICITUDRESERVA ON TBL_CLIENTE.CODIGO=TBL_SOLICITUDRESERVA.COD_CLIENTE\r\nINNER JOIN TBL_ESTADORESERVA ON TBL_SOLICITUDRESERVA.ID_ESTADORESERVA=TBL_ESTADORESERVA.ID_ESTADORESERVA\r\nINNER JOIN TBL_DETALLERESERVA ON TBL_ESTADORESERVA.ID_ESTADORESERVA=TBL_DETALLERESERVA.ID_DETALLERESERVA\r\nINNER JOIN TBL_HABITACION ON TBL_DETALLERESERVA.ID_HABITACION=TBL_HABITACION.ID_HABITACION ";


                MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
                // conexionBD.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["ID"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["FECHA"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["INGRESO"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["SALIDA"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["HUESPEDES"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["NOMBRE"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["ESTADO"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["HABITACION"].ToString()).SetFont(fontContenido)));
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

        private void button1_Click(object sender, EventArgs e)
        {
            crearPDF();
        }
    }
}
