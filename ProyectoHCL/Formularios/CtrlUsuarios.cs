﻿using DocumentFormat.OpenXml.Vml;
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
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas;
using Rectangle = iText.Kernel.Geom.Rectangle;
using System.Reflection;
using Image = System.Drawing.Image;

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

//Programa:         Control Usuarios
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
    public partial class CtrlUsuarios : Form
    {
        R_E_Usuario R_E_user = new R_E_Usuario();
        AdmonUsuarios admonUsuario = new AdmonUsuarios();
        Usuarios user = new Usuarios();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        CDatos cDatos = new CDatos();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0;

        public CtrlUsuarios()
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
                switch (obj.IdPermiso) //restringir acceso según el permiso
                {
                    case 2:  //permiso crear
                        if (obj.ObjetoN == "USUARIOS" && !obj.Permitido) //Validar pantalla y el permiso
                        {
                            btnNuevo.Visible = false; //Ocultar botón para crear
                            btnExcel.Visible = false;
                            btnPdf.Visible = false;
                        }
                        break;
                    case 3: //permiso editar
                        if (obj.ObjetoN == "USUARIOS" && !obj.Permitido)
                        {
                            dgvUsuarios.Columns["EDITAR"].Visible = false; //Ocultar columna del botón para editar en datagrid
                        }
                        break;
                }
            }
        }

        private void CargarDG() //Cargar datagrid con registros utilizando la función de paginación
        {
            user.Inicio1 = pagInicio;
            user.Final1 = pagFinal;
            ds = user.PaginacionUsuarios();
            dgvUsuarios.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPaginacion.Text = cantidad.ToString();

            cmbPaginacion.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPaginacion.Items.Add(x.ToString());

            cmbPaginacion.SelectedIndex = indice;

            HabilitarBotones();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CtrlUsuarios_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn(); //se crea el boton en el dataGrid
            btnUpdate.Name = "EDITAR"; //Nombre del boton 
            dgvUsuarios.Columns.Add(btnUpdate); //Se especifica el nombre de dataGrid para agregar boton

            Permisos(); //Llamar la función permisos al cargar formulario
        }

        public void BuscarUsuarios(string buscarU) //Recibe string para buscar usuarios
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarUsuarios", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreU", MySqlDbType.VarChar, 50).Value = buscarU; //recibe el parametro nombreU definido en el procedimiento almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                dgvUsuarios.DataSource = dt; //se define la tabla en la que se devuelven los registros
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "") //si el textbox no está vacío devuelve el metodo buscar usuarios
            {
                BuscarUsuarios(txtBuscar.Text); //El metodo recibe el string desde el textbox
            }
            else
            {
                CargarDG(); //Si el textbox está vacio devuelve el metodo mostrar usuarios 
            }
        }

        public string ParametroDias() //función para obtener el valor del parámetro días vencimiento usuario de la tabla TBL_PARAMETRO
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR FROM TBL_PARAMETRO WHERE ID_PARAMETRO = 2;";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR"].ToString();
            }
            else
            {
                return null;

            }

            conn.Close();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e) //botón que abre el formulario para crear nuevo resgistro
        {
            int diasV = Convert.ToInt32(ParametroDias());
            R_E_user.lblTitulo.Text = "Registrar Usuario";
            R_E_user.cargarRolesR();
            R_E_user.cmbEstado.Visible = false;
            R_E_user.lblEstado.Visible = false;
            R_E_user.label14.Visible = false;
            R_E_user.label9.Visible = true;
            R_E_user.txtFechaC.Text = DateTime.Now.ToShortDateString();
            R_E_user.dtpVencimiento.Text = DateTime.Now.AddDays(diasV).ToShortDateString();
            R_E_user.ShowDialog();
            CargarDG();
        }

        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvUsuarios.Columns[e.ColumnIndex].Name == "EDITAR") //si se dio click en el botón editar hacer lo siguiente
            {
                R_E_user.lblTitulo.Text = "Editar Usuario";
                R_E_user.cargarRolesE();

                R_E_user.cmbEstado.Visible = true;
                R_E_user.lblEstado.Visible = true;
                R_E_user.label9.Visible = false;
                R_E_user.label14.Visible = true;
                //obtener los datos del datagrid del registro seleccionado
                R_E_user.idUs = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
                R_E_user.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["USUARIO"].Value.ToString(); //Traer los datos del dataGrid al form para editar
                R_E_user.txtNombre.Text = dgvUsuarios.CurrentRow.Cells["NOMBRE"].Value.ToString();
                R_E_user.txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["CORREO"].Value.ToString();
                R_E_user.cmbEstado.Text = dgvUsuarios.CurrentRow.Cells["ESTADO"].Value.ToString();
                R_E_user.cmbRol.Text = dgvUsuarios.CurrentRow.Cells["ROL"].Value.ToString();

                string fechaC = dgvUsuarios.CurrentRow.Cells["CREACION"].Value.ToString();
                DateTime fechaDT = DateTime.Parse(fechaC);
                string fechaC1 = fechaDT.ToString("dd/MM/yyyy");

                //R_E_user.dtpVencimiento.Text = dgvUsuarios.CurrentRow.Cells["VENCIMIENTO"].Value.ToString();
                string fechaV1 = dgvUsuarios.CurrentRow.Cells["VENCIMIENTO"].Value.ToString();
                DateTime fechaDT1 = DateTime.Parse(fechaV1);
                string fechaV = fechaDT1.ToString("yyyy-MM-dd");

                R_E_user.txtFechaC.Text = fechaC1;
                R_E_user.dtpVencimiento.Text = fechaV;
                R_E_user.ShowDialog();
                R_E_user.limpiarCampos();
                CargarDG(); //Se llama el metodo Mostrar usuarios para actualizar el DataGrid al editar 
            }
        }

        private void cmbPaginacion_SelectionChangeCommitted(object sender, EventArgs e)  //Seleccionar página para mostrar registros
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e) //botón anterior paginación
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSiguiente_Click(object sender, EventArgs e) //botón siguiente paginación
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text) + 1;
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

            if (indice == (Convert.ToInt32(txtPaginacion.Text) - 1))
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
            this.Close();  //cerrar formulario
        }

        private void crearPDF()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";

            saveFileDialog.FileName = "Usuarios.pdf";

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

                var titulo = new Paragraph("Usuarios");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(14).SetBold();

                var dfecha = DateTime.Now.ToString("dd.MM.yyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
                fecha.SetTextAlignment(TextAlignment.RIGHT);
                fecha.SetFontSize(12);

                //documento.ShowTextAligned(plogo, 30, 600, 1, TextAlignment.LEFT, VerticalAlignment.TOP, 0);
                documento.ShowTextAligned(nombre, 100, 580, 1, TextAlignment.LEFT, VerticalAlignment.TOP, 0);
                documento.ShowTextAligned(titulo, 396, 580, 1, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                documento.ShowTextAligned(fecha, 760, 580, 1, TextAlignment.RIGHT, VerticalAlignment.TOP, 0);

                string[] columnas = { "Id", "Nombre", "Usuario", "Correo", "Estado", "Rol", "Creacion", "Vencimiento" };

                float[] tamanios = { 1, 3, 2, 3, 2, 2, 2, 2 };
                Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
                tabla.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (string columna in columnas)
                {
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
                }

                string sql = "SELECT ID_USUARIO AS ID, NOMBRE_USUARIO AS NOMBRE, USUARIO, EMAIL AS CORREO, TBL_ESTADO.DESCRIPCION AS ESTADO, " +
                    "TBL_ROL.ROL AS ROL, PRIMERINGRESO AS CREACION, FECHAVENCIMIENTO AS VENCIMIENTO FROM TBL_USUARIO INNER JOIN " +
                    "TBL_ESTADO ON TBL_USUARIO.ID_ESTADO = TBL_ESTADO.ID_ESTADO INNER JOIN TBL_ROL ON TBL_USUARIO.ID_ROL = " +
                    "TBL_ROL.ID_ROL";

                MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
                // conexionBD.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Id"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Nombre"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Usuario"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Correo"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Estado"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Rol"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Creacion"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Vencimiento"].ToString()).SetFont(fontContenido)));
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

        //private class HeaderEventHandler : IEventHandler
        //{
        //    public void HandleEvent(Event currentEvent)
        //    {
        //        PdfDocumentEvent docEvent = (PdfDocumentEvent)currentEvent;
        //        PdfDocument pdfDoc = docEvent.GetDocument();
        //        PdfPage page = docEvent.GetPage();
        //        int pageNumber = pdfDoc.GetPageNumber(page);
        //        PdfCanvas pdfCanvas = new PdfCanvas(page.NewContentStreamBefore(), page.GetResources(), pdfDoc);

        //        Rectangle pageSize = page.GetPageSize();

        //        // Logo y nombre de la empresa a la izquierda
        //        pdfCanvas.BeginText()
        //            .SetFontAndSize(PdfFontFactory.CreateFont(StandardFonts.HELVETICA), 12)
        //            .MoveText(pageSize.GetLeft() + 72, pageSize.GetTop() - 35)
        //            .ShowText("Hotel Casa Lomas")
        //            .EndText();

        //        // Título del documento en el centro
        //        pdfCanvas.BeginText()
        //            .SetFontAndSize(PdfFontFactory.CreateFont(StandardFonts.HELVETICA), 14)
        //            .MoveText(((pageSize.GetLeft() + pageSize.GetRight()) / 2) - 5, pageSize.GetTop() - 35)
        //            .ShowText("Usuarios")
        //            .EndText();

        //        // Fecha y hora a la derecha
        //        pdfCanvas.BeginText()
        //            .SetFontAndSize(PdfFontFactory.CreateFont(StandardFonts.HELVETICA), 12)
        //            .MoveText(pageSize.GetRight() - 100, pageSize.GetTop() - 35)
        //            .ShowText("Fecha: " + DateTime.Now.ToString("dd.MM.yyy"))
        //            .EndText();

        //        pdfCanvas.Release();
        //    }
        //}

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

            sl.SetCellValue("C2", "Usuarios");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_USUARIO");
            sl.SetCellValue("B" + celdaCabecera, "Id");
            sl.SetCellValue("C" + celdaCabecera, "Nombre");
            sl.SetCellValue("D" + celdaCabecera, "Usuario");
            sl.SetCellValue("E" + celdaCabecera, "Correo");
            sl.SetCellValue("F" + celdaCabecera, "Estado");
            sl.SetCellValue("G" + celdaCabecera, "Rol");
            sl.SetCellValue("H" + celdaCabecera, "Creacion");
            sl.SetCellValue("I" + celdaCabecera, "Vencimiento");

            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "I" + celdaCabecera, estiloCa);

            string sql = "SELECT ID_USUARIO AS ID, NOMBRE_USUARIO AS NOMBRE, USUARIO, EMAIL AS CORREO, TBL_ESTADO.DESCRIPCION AS ESTADO, " +
                "TBL_ROL.DESCRIPCION AS ROL, PRIMERINGRESO AS CREACION, FECHAVENCIMIENTO AS VENCIMIENTO FROM TBL_USUARIO INNER JOIN " +
                "TBL_ESTADO ON TBL_USUARIO.ID_ESTADO = TBL_ESTADO.ID_ESTADO INNER JOIN TBL_ROL ON TBL_USUARIO.ID_ROL = " +
                "TBL_ROL.ID_ROL";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["id"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["nombre"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["usuario"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["correo"].ToString());
                sl.SetCellValue("F" + celdaCabecera, reader["estado"].ToString());
                sl.SetCellValue("G" + celdaCabecera, reader["rol"].ToString());
                sl.SetCellValue("H" + celdaCabecera, reader["creacion"].ToString());
                sl.SetCellValue("I" + celdaCabecera, reader["vencimiento"].ToString());
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
            sf.FileName = "Usuarios Registrados";
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

        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvUsuarios.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                Image imagen = Properties.Resources.editar;

                dgvUsuarios.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvUsuarios.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
        }
    }
}
