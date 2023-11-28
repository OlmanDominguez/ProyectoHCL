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
using System.Windows.Controls;
using Point = System.Drawing.Point;
using iText.IO.Image;
using Image = System.Drawing.Image;
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas;
using Rectangle = iText.Kernel.Geom.Rectangle;
using System.Reflection;

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

//Programa:         Control Objetos
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
    public partial class CtrlObjetos : Form
    {
        R_E_Objeto R_E_obj = new R_E_Objeto();
        AdmonObjetos admonObjeto = new AdmonObjetos();
        Objetos obj = new Objetos();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        CDatos cDatos = new CDatos();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0;

        public CtrlObjetos()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG(); //mostrar registros en datagridview
        }

        private void Permisos() //función para asignar permisos a la pantalla
        {
            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs); //lista de objetos que recibe el rol para validar el permiso

            foreach (var obj in LsObj) //recorrer los objetos en la lista
            {
                switch (obj.IdPermiso)//restringir acceso según el permiso
                {
                    case 2: //permiso crear
                        if (obj.ObjetoN == "OBJETOS" && !obj.Permitido) //Validar pantalla y el permiso
                        {
                            btnNuevo.Visible = false;  //Ocultar botón para crear
                            btnExcel.Visible = false;  //Ocultar botón Excel
                            button6.Visible = false;  //Ocultar botón PDF
                        }
                        break;
                    case 3: //permiso editar
                        if (obj.ObjetoN == "OBJETOS" && !obj.Permitido)
                        {
                            dgvObjetos.Columns["EDITAR"].Visible = false;  //Ocultar columna del botón para editar en datagrid
                        }
                        break;
                    case 4: //permiso eliminar
                        if (obj.ObjetoN == "OBJETOS" && !obj.Permitido)
                        {
                            dgvObjetos.Columns["ELIMINAR"].Visible = false; //Ocultar columna del botón para eliminar en datagrid
                        }
                        break;
                }
            }
        }

        private void CargarDG() //Cargar datagrid con registros utilizando la función de paginación
        {
            obj.Inicio1 = pagInicio;
            obj.Final1 = pagFinal;
            ds = obj.PaginacionObjetos();
            dgvObjetos.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPag.Text = cantidad.ToString();

            cmbPag.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPag.Items.Add(x.ToString());

            cmbPag.SelectedIndex = indice;

            HabilitarBotones();
        }

        private void CtrlObjetos_Load(object sender, EventArgs e)
        {

            DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn(); //agregar botón de editar en datagrid
            btnUpdate.Name = "EDITAR";
            dgvObjetos.Columns.Add(btnUpdate);

            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn(); //agregar botón de eliminar en datagrid
            btnDelete.Name = "ELIMINAR";
            dgvObjetos.Columns.Add(btnDelete);

            Permisos(); //Llamar la función permisos al cargar formulario

        }

        public void BuscarObjetos(string buscarOb) //función para buscar un objeto
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarObjetos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreO", MySqlDbType.VarChar, 50).Value = buscarOb;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvObjetos.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            R_E_obj.lblTitulo.Text = "Registrar Objeto";
            R_E_obj.ShowDialog();
            CargarDG();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarObjetos(txtBuscar.Text);
            }
            else
            {
                CargarDG();
            }
        }

        private void dgvObjetos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvObjetos.Columns[e.ColumnIndex].Name == "EDITAR") //si se dio click en el botón editar hacer lo siguiente
            {
                R_E_obj.lblTitulo.Text = "Editar Objeto";
                //obtener los datos del datagrid del registro seleccionado
                R_E_obj.idObj = dgvObjetos.CurrentRow.Cells["ID"].Value.ToString();
                R_E_obj.txtObj.Text = dgvObjetos.CurrentRow.Cells["NOMBRE"].Value.ToString();
                R_E_obj.rTxtDesc.Text = dgvObjetos.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                R_E_obj.cmbEstado.Text = dgvObjetos.CurrentRow.Cells["ESTADO"].Value.ToString();
                R_E_obj.ShowDialog();
                R_E_obj.limpiarCampos();
                CargarDG();
            }

            if (this.dgvObjetos.Columns[e.ColumnIndex].Name == "ELIMINAR") //si se dio click en el botón eliminar hacer lo siguiente
            {
                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    bool elimino = admonObjeto.EliminarObjeto(dgvObjetos.CurrentRow.Cells["ID"].Value.ToString());

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
        }

        private void cmbPag_SelectionChangeCommitted(object sender, EventArgs e) //Seleccionar página para mostrar registros
        {
            int pagina = Convert.ToInt32(cmbPag.Text);
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

        private void btnAnterior_Click(object sender, EventArgs e) //botón anterior paginación
        {
            int pagina = Convert.ToInt32(cmbPag.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSiguiente_Click(object sender, EventArgs e) //botón siguiente paginación
        {
            int pagina = Convert.ToInt32(cmbPag.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void HabilitarBotones()//mostrar los botones de anterior o siguiente
                                       //verificando si se está en la primera o ultima pagina
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

            if (indice == (Convert.ToInt32(txtPag.Text) - 1))
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
            this.Close(); //cerrar formulario
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

                var logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("C:/Users/HP TOUCH/source/repos/OlmanDominguez/ProyectoHCL/Logo HCL.jpeg")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);

                var nombre = new Paragraph("Hotel Casa Lomas");
                nombre.SetFontSize(12);

                var titulo = new Paragraph("Reporte Objetos");
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

                string[] columnas = { "Id", "Nombre", "Descripcion", "Estado", "Creacion", "Actualizacion" };

                float[] tamanios = { 1, 2, 3, 2, 3, 3 };
                Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
                tabla.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (string columna in columnas)
                {
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
                }

                string sql = "SELECT ID_OBJETO AS ID, OBJETO AS NOMBRE, DESCRIPCION, ESTADO_OBJETO AS ESTADO, FECHA_CREACION AS CREACION," +
                    " FECHA_ACTUALIZACION AS ACTUALIZACION FROM TBL_OBJETO";

                MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
                // conexionBD.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Id"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Nombre"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Descripcion"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Estado"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Creacion"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Actualizacion"].ToString()).SetFont(fontContenido)));
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

        private void button6_Click(object sender, EventArgs e)
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

            sl.SetCellValue("C2", "Reporte de Objetos");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_OBJETO");
            sl.SetCellValue("B" + celdaCabecera, "Id");
            sl.SetCellValue("C" + celdaCabecera, "Nombre");
            sl.SetCellValue("D" + celdaCabecera, "Descripcion");
            sl.SetCellValue("E" + celdaCabecera, "Estado");
            sl.SetCellValue("F" + celdaCabecera, "Creacion");
            sl.SetCellValue("G" + celdaCabecera, "Actualizacion");

            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "G" + celdaCabecera, estiloCa);

            string sql = "SELECT ID_OBJETO AS ID, OBJETO AS NOMBRE, DESCRIPCION, ESTADO_OBJETO AS ESTADO, FECHA_CREACION AS CREACION," +
                " FECHA_ACTUALIZACION AS ACTUALIZACION FROM TBL_OBJETO";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["id"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["nombre"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["descripcion"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["estado"].ToString());
                sl.SetCellValue("F" + celdaCabecera, reader["creacion"].ToString());
                sl.SetCellValue("G" + celdaCabecera, reader["actualizacion"].ToString());
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
            sf.FileName = "ExcelObjetos";
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

        private void dgvObjeto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvObjetos.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                Image imagen = Properties.Resources.editar;

                dgvObjetos.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvObjetos.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvObjetos.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                Image imagen = Properties.Resources.eliminar;

                dgvObjetos.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvObjetos.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
        }

        private void dgvObjetos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvObjetos.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                Image imagen = Properties.Resources.editar;

                dgvObjetos.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvObjetos.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvObjetos.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                Image imagen = Properties.Resources.eliminar;

                dgvObjetos.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvObjetos.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }


        }
    }

}