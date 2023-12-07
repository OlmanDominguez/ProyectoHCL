/*-----------------------------------------------------------------------
    //Universidad Nacional Autonoma de Honduras (UNAH)
		Facultad de Ciencias Economicas
	Departamento de Informatica administrativa
         Analisis, Programacion y Evaluacion de Sistemas
                    tercer Periodo 2023


Equipo:
GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

JOEL ENRIQUE GODOY BONILLA---------(joel.godoy@unah.hn)

OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

Catedratico analisis y diseño:             Lic.Giancarlo Martini Scalici Aguilar 
catedratico programacion e implementacion: Lic.Karla Melisa Garcia Pineda 
catedratico evaluacion de sistemas:        Lic.Karla Melisa Garcia Pineda 


---------------------------------------------------------------------

Programa:         Pantalla de clientes
Fecha:             27 - septiembre - 2023
Programador:      Joel
descripcion:       Pantalla que contrala las validaciones del cliente

-----------------------------------------------------------------------

                Historial de Cambio

-----------------------------------------------------------------------

Programador               Fecha                      Descripcion
GABRIELA  MANCIA  

HILDEGARD  MONTALVAN   

NELSON SALGADO  

JOEL  GODOY 

OLMAN  DOMÍNGUEZ 

----------------------------------------------------------------------- */

/* librerias utilizadas para facilitar el proceso */
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Vml;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using MySql.Data.MySqlClient; /* libreria para conectar a la BD */
using ProyectoHCL.clases; /* hacer uso de las clases dentro del proyecto */
using ProyectoHCL.Properties;
using System; /* directiva para identificar los bloques de codigo */
using System.Collections.Generic;  /* libreria para lectura*/
using System.ComponentModel; /* jerarguia de los componentes funcionales */
using System.Data; /* Conexion a la BD*/
using System.Drawing; /* impresion de archivos en excel */
using System.Linq; /* libreria para clases e interfaces */
using System.Text; /* manipular informacion dentro de la aplicacion */
using System.Threading.Tasks; /* libreria para impresion */
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using DocumentFormat.OpenXml.Office2013.Excel;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using System.Reflection;
using Image = System.Drawing.Image;
using iText.Kernel.Pdf;
using iText.Layout.Properties;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using Document = iText.Layout.Document;
using iText.Kernel.Geom;
using iText.Layout.Element;
using System.Windows.Controls;
using Point = System.Drawing.Point;
using iText.IO.Image;
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas;
using Rectangle = iText.Kernel.Geom.Rectangle;
using Cell = iText.Layout.Element.Cell;
using Table = iText.Layout.Element.Table;


namespace ProyectoHCL.Formularios
{
    public partial class CtrlClientes : Form
    {
        clases.Clientes clien = new clases.Clientes();  /* Referencias y declaracion de valores en variable*/
        AdmonClientes admonClientes = new AdmonClientes();
        DataSet ds = new DataSet();
        CDatos cDatos = new CDatos();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0;

        public CtrlClientes()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDGCl();
        }


        private void Permisos()
        {
            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs);

            foreach (var obj in LsObj)
            {
                switch (obj.IdPermiso)  /* Evaluacion de patrones */
                {
                    case 2:
                        if (obj.ObjetoN == "CLIENTES" && !obj.Permitido) //Validar pantalla y el permiso
                        {
                            btnNuevo.Visible = false; //Deshabilitar botón para crear
                            button6.Visible = false; // Deshabilitar botón PDF
                            button5.Visible = false; // Deshabilitar botón Excel

                        }
                        break;
                    case 3:
                        if (obj.ObjetoN == "CLIENTES" && !obj.Permitido)
                        {
                            dgvClientes.Columns["EDITAR"].Visible = false; //Ocultar columna del botón para editar en datagrid
                        }
                        break;
                    case 4:
                        if (obj.ObjetoN == "CLIENTES" && !obj.Permitido)
                        {
                            dgvClientes.Columns["ELIMINAR"].Visible = false; //Ocultar columna del botón para eliminar en datagrid
                        }
                        break;
                }
            }
        }

        private void CargarDGCl()
        {
            clien.Inicio1 = pagInicio;
            clien.Final1 = pagFinal;
            ds = clien.PaginacionClientes();
            dgvClientes.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;  /* Convertidor de variables a otros valores*/

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++; /* condicional IF */

            txtPagCl.Text = cantidad.ToString();

            cmbPagCl.Items.Clear();

            for (int x = 1; x <= cantidad; x++)  /*ciclo for */
                cmbPagCl.Items.Add(x.ToString());

            cmbPagCl.SelectedIndex = indice;
            HabilitarBotones();

        }

        private void CtrlClientes_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();  /* vista de botones */
            btnUpdate.Name = "VER";
            dgvClientes.Columns.Add(btnUpdate);

            DataGridViewImageColumn btnUpdate1 = new DataGridViewImageColumn();
            btnUpdate1.Name = "EDITAR";
            dgvClientes.Columns.Add(btnUpdate1);

            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
            btnDelete.Name = "ELIMINAR";
            dgvClientes.Columns.Add(btnDelete);

            Permisos();
        }


        public void BuscarClientes(string buscarCl)
        {

            try
            {

                MySqlConnection conn;  /*conexion a la BD*/
                MySqlCommand cmd;

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarClientes", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreC", MySqlDbType.VarChar, 50).Value = buscarCl;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvClientes.DataSource = dt;


            }
            catch (Exception)  /*para captar errores en ejecucion */
            {

                throw;
            }

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            AgregarCliente aggCliente = new AgregarCliente();
            aggCliente.ShowDialog();
            CargarDGCl();
        }

        public static class claseCod
        {
            public static string codigo;
            public static string id;
        }


        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "VER")
            {
                try
                {
                    claseCod.codigo = dgvClientes.CurrentRow.Cells["IDENTIFICACIÓN"].Value.ToString();
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //Consulta
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("SELECT * FROM TBL_CLIENTE WHERE DNI_PASAPORTE = " +
                            claseCod.codigo + ";");
                        MySqlDataReader leer = comando.ExecuteReader();
                        while (leer.Read())
                        {
                            claseCod.id = Convert.ToString(leer["CODIGO"]);
                        }

                        comando.Connection.Close();

                    }
                    Form formulario = new Formularios.ShowCliente();
                    formulario.ShowDialog();

                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un error");
                }
            }

            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                try
                {
                    claseCod.codigo = dgvClientes.CurrentRow.Cells["IDENTIFICACIÓN"].Value.ToString();
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //Consulta
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("SELECT * FROM TBL_CLIENTE WHERE DNI_PASAPORTE = " +
                            claseCod.codigo + ";");
                        MySqlDataReader leer = comando.ExecuteReader();
                        while (leer.Read())
                        {
                            claseCod.id = Convert.ToString(leer["CODIGO"]);
                        }

                        comando.Connection.Close();

                    }
                    Form formulario = new Formularios.EditarCliente();
                    formulario.ShowDialog();
                    CargarDGCl();

                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un error");
                }
            }

            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = admonClientes.EliminarCliente(dgvClientes.CurrentRow.Cells["CODIGO"].Value.ToString());

                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    if (elimino)
                    {
                        MsgB mbox = new MsgB("informacion", "Registro Eliminado");
                        DialogResult dR = mbox.ShowDialog();
                        CargarDGCl();
                    }
                    else
                    {
                        MsgB mbox = new MsgB("informacion", "Registro NO Eliminado");
                        DialogResult dR = mbox.ShowDialog();
                    }

                }
                else if (dg == DialogResult.Cancel)
                {
                    MsgB mbox = new MsgB("informacion", "Registro NO Eliminado");
                    DialogResult dR = mbox.ShowDialog();
                }
            }
        }

        private void txtBuscarCl_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCl.Text != "")
            {
                BuscarClientes(txtBuscarCl.Text);
            }
            else
            {
                CargarDGCl();
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagCl.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGCl();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagCl.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGCl();
        }

        private void HabilitarBotones()
        {
            if (pagInicio == 1)
            {
                btnAnt.Enabled = false;
                cmbMostrarCl.Enabled = true;
            }
            else
            {
                btnAnt.Enabled = true;
                cmbMostrarCl.Enabled = false;
            }

            if (indice == (Convert.ToInt32(txtPagCl.Text) - 1))
            {
                btnSig.Enabled = false;
            }
            else
            {
                btnSig.Enabled = true;
            }
        }

        private void cmbMostrarCl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIndice = cmbMostrarCl.SelectedIndex;
            switch (cmbIndice)     /* realizar las respectivas validaciones valor por valor */
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
            CargarDGCl();
        }

        private void cmbPagCl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagCl.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGCl();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            crearExcel();
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

            sl.SetCellValue("C2", "Reporte de Clientes");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_CLIENTE");
            sl.SetCellValue("B" + celdaCabecera, "Codigo");
            sl.SetCellValue("C" + celdaCabecera, "Nombre");
            sl.SetCellValue("D" + celdaCabecera, "Apellido");
            sl.SetCellValue("E" + celdaCabecera, "Identificacion");
            sl.SetCellValue("F" + celdaCabecera, "Id TipoCliente");
            sl.SetCellValue("G" + celdaCabecera, "Tipo Cliente");
            sl.SetCellValue("H" + celdaCabecera, "Nombre Juridico");
            sl.SetCellValue("I" + celdaCabecera, "RTN");
            sl.SetCellValue("J" + celdaCabecera, "Telefono1");
            sl.SetCellValue("K" + celdaCabecera, "Telefono2");
            sl.SetCellValue("L" + celdaCabecera, "Email1");
            sl.SetCellValue("M" + celdaCabecera, "Email2");

            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "M" + celdaCabecera, estiloCa);

            string sql = "SELECT c.CODIGO, c.NOMBRE, c.APELLIDO, c.DNI_PASAPORTE, c.ID_TIPOCLIENTE, t.DESCRIPCION, c.NOMBRE_RTN, c.RTN, c.TELEFONO, c.TELEFONO2, c.EMAIL, c.EMAIL2 FROM TBL_CLIENTE c INNER JOIN TBL_TIPOCLIENTE t ON c.ID_TIPOCLIENTE = t.ID_TIPOCLIENTE";  /* declaracion y llamada de valores de variables en las tablas en BD */

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion(); /* proceso de conexion a BD */

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["CODIGO"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["NOMBRE"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["APELLIDO"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["DNI_PASAPORTE"].ToString());
                sl.SetCellValue("F" + celdaCabecera, reader["ID_TIPOCLIENTE"].ToString());
                sl.SetCellValue("G" + celdaCabecera, reader["DESCRIPCION"].ToString());
                sl.SetCellValue("H" + celdaCabecera, reader["NOMBRE_RTN"].ToString());
                sl.SetCellValue("I" + celdaCabecera, reader["RTN"].ToString());
                sl.SetCellValue("J" + celdaCabecera, reader["TELEFONO"].ToString());
                sl.SetCellValue("K" + celdaCabecera, reader["TELEFONO2"].ToString());
                sl.SetCellValue("L" + celdaCabecera, reader["EMAIL"].ToString());
                sl.SetCellValue("M" + celdaCabecera, reader["EMAIL2"].ToString());
            }

            SLStyle EstiloB = sl.CreateStyle();
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "M" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B", "M");

            SaveFileDialog sf = new SaveFileDialog();

            sf.DefaultExt = "*.xlsx";
            sf.FileName = "ExcelClientes";
            sf.Filter = " Libro de Excel (*.xlsx) | *.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                sl.SaveAs(sf.FileName);
                MsgB mbox = new MsgB("informacion", "Archivo Excel creado con éxito");
                DialogResult dR = mbox.ShowDialog();
            }
        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvClientes.Columns[e.ColumnIndex].Name == "VER")
            {
                Image imagen = Properties.Resources.ojo;

                dgvClientes.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvClientes.Columns[e.ColumnIndex].Width = imagen.Width + 40;

                e.Value = imagen;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvClientes.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                Image imagen = Properties.Resources.editar;

                dgvClientes.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvClientes.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvClientes.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                Image imagen = Properties.Resources.eliminar;

                dgvClientes.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvClientes.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
        }

        //Botón para formulario pdf
        private void button6_Click(object sender, EventArgs e)
        {
            crearPDF();
            MsgB mbox = new MsgB("informacion", "PDF creado con éxito");
            DialogResult dR = mbox.ShowDialog();
        }

        private void crearPDF()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";

            saveFileDialog.FileName = "Clientes.pdf";

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

                var titulo = new Paragraph("Clientes");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(16).SetBold();

                var dfecha = DateTime.Now.ToString("dd.MM.yyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
                fecha.SetTextAlignment(TextAlignment.RIGHT);
                fecha.SetFontSize(13);

                documento.ShowTextAligned(plogo, 30, 600, 1, TextAlignment.LEFT, VerticalAlignment.TOP, 0);
                documento.ShowTextAligned(nombre, 100, 580, 1, TextAlignment.LEFT, VerticalAlignment.TOP, 0);
                documento.ShowTextAligned(titulo, 396, 580, 1, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                documento.ShowTextAligned(fecha, 760, 580, 1, TextAlignment.RIGHT, VerticalAlignment.TOP, 0);

                string[] columnas = { "Codigo", "Nombre", "Apellido", "Dni_pasaporte", "Descripcion", "Rtn", "Telefono", "Email"};

                float[] tamanios = { 1, 1, 1, 1, 1, 1, 1, 1 };
                Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
                tabla.SetWidth(UnitValue.CreatePercentValue(20));

                foreach (string columna in columnas)
                {
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
                }

                string sql = "SELECT c.CODIGO, c.NOMBRE, c.APELLIDO, c.DNI_PASAPORTE, t.DESCRIPCION, c.RTN, c.TELEFONO, c.EMAIL FROM TBL_CLIENTE c INNER JOIN TBL_TIPOCLIENTE t ON c.ID_TIPOCLIENTE = t.ID_TIPOCLIENTE";

                MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
                // conexionBD.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["CODIGO"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["NOMBRE"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["APELLIDO"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["DNI_PASAPORTE"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["DESCRIPCION"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["RTN"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["TELEFONO"].ToString()).SetFont(fontContenido)));
                   // tabla.AddCell(new Cell().Add(new Paragraph(reader["TELEFONO2"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["EMAIL"].ToString()).SetFont(fontContenido)));
                    //tabla.AddCell(new Cell().Add(new Paragraph(reader["EMAIL2"].ToString()).SetFont(fontContenido)));
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
