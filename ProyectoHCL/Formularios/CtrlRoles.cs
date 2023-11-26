/*-----------------------------------------------------------------------
    Universidad Nacional Autonoma de Honduras (UNAH)
		Facultad de Ciencias Economicas
	Departamento de Informatica administrativa
         Analisis, Programacion y Evaluacion de Sistemas
                    Primer Periodo 2016


Equipo:
GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

JOEL ENRIQUE GODOY BONILLA---------(joel.bonilla@unah.hn)

OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

Catedratico analisis y diseño:             Lic.Giancarlo Martini Scalici Aguilar 
catedratico programacion e implementacion: Lic.Karla Melisa Garcia Pineda 
catedratico evaluacion de sistemas:        Lic.Karla Melisa Garcia Pineda 


---------------------------------------------------------------------

Programa:         Pantalla de ctrlRoles
Fecha:             26 - sept - 2023
Programador: Olman
descripcion:       Pantalla que controla el registro de roles, eliminar y editar roles 

-----------------------------------------------------------------------

                Historial de Cambio

-----------------------------------------------------------------------

Programador               Fecha                      Descripcion
GABRIELA  MANCIA  

HILDEGARD  MONTALVAN   

NELSON SALGADO  

JOEL  GODOY 

OLMAN  DOMÍNGUEZ 

-----------------------------------------------------------------------*/


using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;//libreria que nos permite la concxion a la base ded datos 
using ProyectoHCL.clases;//libreria que nos permite funciones o variables de las clases 
using System;//libreria para identificar los bloques de codigo
using System.Collections.Generic;//libreria de lectura
using System.ComponentModel;//libreria para escribir la gerarquia de los componetes funcionales 
using System.Data;//Libreria para la conecxion a la base de datos 
using System.Drawing;//Libreria para impresion en excel 
//using System.Drawing.Text;
using System.Linq;//libreria para las clases he interfaces
using System.Text;//Libreria para manipular la informacion dentro de la aplicacion 
using System.Threading.Tasks;//Libreria para ejecutar tareas y tareas simultaneas al mismo tiempo
using System.Windows.Forms;//libreria para operaciones unicas que no devuelven ningun valor 
//estas librerias se instalaron para imprimir un documento pdf
using Microsoft.VisualBasic.ApplicationServices;
using iText.Kernel.Pdf;//para crear documentos en pdf 
using System.Reflection.Metadata;//libreria que se utiliza para extraer tipos,metdos y atributos 
using Document = iText.Layout.Document;//para crear documentos en pdf 
using iText.Kernel.Geom;//libreria que se utiliza para trabajar con pdf 
using iText.Layout.Element;//Libreria que se utiliza para trabajr con texto he imagenes en pdf
using iText.Kernel.Font;//Libreria qque se utiliza para dar fuente a los ducumentos en pdf 
using iText.IO.Font.Constants;//se utiliza para trabajar con documentos pdf y para codificacion de caracteres
using iText.Layout.Properties;//Librereria que se utiliza para trabajar en el diseño de pdf 
using SpreadsheetLight;//permite la manipulacion de un documento en excel 
using SpreadsheetLight.Drawing;//libreria que permite manipular cualquier documento excel
using DocumentFormat.OpenXml.Vml;//libreria utilizada para el momento de crear un documento pdf 
using Point = System.Drawing.Point;//para definir el punto de una clase unica
using iTextSharp.tool.xml;//libreria para dar formato al exportar el archivo 
using System.IO;//Libreria que se utiliza para verificar la existencia de archivos
using Image = System.Drawing.Image;
using Rectangle = iText.Kernel.Geom.Rectangle;//para crear los iconos 
using System.Net.NetworkInformation;
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas;

namespace ProyectoHCL.Formularios
{
    public partial class CtrlRoles : Form
    {
        R_E_Roles R_E_rolp = new R_E_Roles();//creamos r_e_roles para acceder a sus metodos y funciones 
        AdmonRoles rgtRoles = new AdmonRoles(); //crear objeto Rgtroles para acceder a sus metodos
        Roles rolr = new Roles();     //crear objetos roles para acceder a sus parametros 
        DataSet ds = new DataSet();// creamos objeto rolr  para acceder a sus funciones 
        MsgB msgB = new MsgB(); //creamos objeto msgb para reutilizar el mismo mensaje en todos los formularios 
        CDatos cDatos = new CDatos(); //creamos objeto  cDatos para acceder a sus funciones 
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0;// creamos las variable que utilizaremos para algunas funciones 
        public CtrlRoles()//creamos la funcion CtrlRoles para cargar los archivos 
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDT();

        }
        //se crea la funcion permisos para asi poder brindar los permisos correstpondientes a cada usuariio
        private void Permisos()
        {
            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs);// variable a utilzar en la funcion permiso

            foreach (var obj in LsObj)
            {
                switch (obj.IdPermiso)
                {
                    case 2:
                        if (obj.ObjetoN == "ROLES" && !obj.Permitido)//en esta condicion esta crear para que el usuario solo puede ver 
                        {
                            btnNuevo.Visible = false;
                            Excel.Visible = false;
                            pdf.Visible = false;
                        }
                        break;
                    case 3://en este caso se creo para poder dar acceso al usuario de editar 
                        if (obj.ObjetoN == "ROLES" && !obj.Permitido)
                        {
                            dgvRoles.Columns["EDITAR"].Visible = false;
                        }
                        break;
                    case 4://y en este caso creo para poder permitir al usuario eliminar 
                        if (obj.ObjetoN == "ROLES" && !obj.Permitido)
                        {
                            dgvRoles.Columns["ELIMINAR"].Visible = false;
                        }
                        break;
                }
            }
        }

        //funcion crear para traer los datos al datagrip 
        private void CargarDT()
        {
            //vaariables que ocuparemos 
            rolr.Inicio1 = pagInicio;
            rolr.Final1 = pagFinal;
            ds = rolr.PaginacionRoles();
            dgvRoles.DataSource = ds.Tables[1];

            //conversion de enteros a varchar 
            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPagR.Text = cantidad.ToString();

            cmbPagR.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPagR.Items.Add(x.ToString());

            cmbPagR.SelectedIndex = indice;

            HabilitarBotones();
        }

        private void CtrlRoles_Load_1(object sender, EventArgs e)
        {
            DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
            btnUpdate.Name = "EDITAR";
            dgvRoles.Columns.Add(btnUpdate);

            DataGridViewImageColumn btnEliminar = new DataGridViewImageColumn();
            btnEliminar.Name = "ELIMINAR";
            dgvRoles.Columns.Add(btnEliminar);

            Permisos(); //Llamar la función permisos al cargar formulario
        }



        public void BuscarRol(string buscarR) //Recibe string para buscar rol
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarRol", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreR", MySqlDbType.VarChar, 30).Value = buscarR; //recibe el parametro buscarR definido en el parametro almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                dgvRoles.DataSource = dt; //se define la tabla en la que se devuelven los registros
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)//se crea el siguinete boton para crear un nuevo rol
        {

            R_E_rolp.label11.Text = "Registrar Rol";
            R_E_rolp.ShowDialog();//dirige al formulario  registrar y editar rol
            CargarDT();//carga los datos en el datagrip
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)//se crea el texbos donde se ingresara texto para buscar un rol determinado
        {
            if (txtBuscarR.Text != "")
            {
                BuscarRol(txtBuscarR.Text);//buscara el rol
            }
            else
            {
                CargarDT();//carga los roles registrados 
            }
        }


        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)//creacion del datagrip 
        {
            if (this.dgvRoles.Columns[e.ColumnIndex].Name == "EDITAR")//crea el boton editar
            {
                //mostrara los texbox que se pueden editar 
                R_E_rolp.label11.Text = "Editar Rol";//titulo del rol
                R_E_rolp.idRol = dgvRoles.CurrentRow.Cells["ID"].Value.ToString();
                R_E_rolp.txtRol.Text = dgvRoles.CurrentRow.Cells["NOMBRE"].Value.ToString();
                R_E_rolp.txtNumero.Text = dgvRoles.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                R_E_rolp.cmbEstado.Text = dgvRoles.CurrentRow.Cells["ESTADO"].Value.ToString();
                R_E_rolp.ShowDialog();
                R_E_rolp.limpiarCampos();//limpia los campos
                CargarDT();//carga los datos
            }
            if (this.dgvRoles.Columns[e.ColumnIndex].Name == "ELIMINAR")//esta condicional es si el usuario desea eliminar algun rol registrado
            {

                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");//mensaje de advertencia 
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    bool elimino = rgtRoles.EliminarRoles(dgvRoles.CurrentRow.Cells["ID"].Value.ToString()); //EL metodo eliminar recibe como string el id del DataGrid
                    if (elimino)
                    {
                        MsgB mbox = new MsgB("informacion", "Registro eliminado");
                        DialogResult dR = mbox.ShowDialog();//mensaje de confirmacion de eliminacion de codigo
                        CargarDT();//carga los datos ya con el rol eliminado 
                    }
                    else
                    {
                        MsgB mbox = new MsgB("informacion", "Registro no eliminado");
                        DialogResult dR = mbox.ShowDialog();//condicional en dado caso que no eliga ninguna de las anteriores 
                    }

                }
                else if (dg == DialogResult.Cancel)//cancela la operacion 
                {

                }
            }

        }





        private void pdf_Click(object sender, EventArgs e)//creacionde la funcion pdf
        {
            crearPDF();
            MsgB mbox = new MsgB("informacion", "PDF creado con éxito");//mensaje de confirmacion
            DialogResult dR = mbox.ShowDialog();
        }
        private void crearPDF()
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

                var titulo = new Paragraph("Roles");
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

                string[] columnas = { "id_rol", "rol", "descripcion", "estado_rol", "fecha_creacion", "fecha_actualizacion" };

                float[] tamanios = { 1, 2, 2, 3, 3, 3 };
                Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
                tabla.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (string columna in columnas)
                {
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
                }

                string sql = "SELECT id_rol, rol, descripcion, estado_rol, fecha_creacion, fecha_actualizacion FROM TBL_ROL";

                MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
                // conexionBD.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["id_rol"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["rol"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["descripcion"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["estado_rol"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_creacion"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_actualizacion"].ToString()).SetFont(fontContenido)));
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

        //funcion que se utilizara para crear pdf
        private void Excel_Click(object sender, EventArgs e)
        {


            SLDocument sl = new SLDocument();//objeto de documento
            //direcion donde guardar ael excel
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
            pic.ResizeInPixels(100, 80);
            sl.InsertPicture(pic);

            //especifiacion de la fuente del encabezado del excel
            sl.SetCellValue("C2", "Reporte de Roles");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");


            int celdaCabecera = 6, celdaInicial = 6;//estructura de lo que aparecera en el excel 

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_ROL");
            sl.SetCellValue("B" + celdaCabecera, "id_rol");
            sl.SetCellValue("C" + celdaCabecera, "rol");
            sl.SetCellValue("D" + celdaCabecera, "descripcion");
            sl.SetCellValue("E" + celdaCabecera, "estado rol");
            sl.SetCellValue("F" + celdaCabecera, "fecha creacion");
            sl.SetCellValue("G" + celdaCabecera, "fecha actualizacion");

            SLStyle estiloCa = sl.CreateStyle();//fuente de como aparecera la tabla en excel
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Red, System.Drawing.Color.Red);
            sl.SetCellStyle("B" + celdaCabecera, "g" + celdaCabecera, estiloCa);
            //seleccionando los campos que traera de la base de datos
            string sql = "SELECT id_rol, rol, descripcion, estado_rol,  fecha_creacion, fecha_actualizacion FROM TBL_ROL";
            //conecxion a la base de datos
            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
            // conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())//cabecera de la tabla 
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["id_rol"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["rol"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["descripcion"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["estado_rol"].ToString());
                sl.SetCellValue("F" + celdaCabecera, reader["fecha_creacion"].ToString());
                sl.SetCellValue("G" + celdaCabecera, reader["fecha_actualizacion"].ToString());

            }

            SLStyle EstiloB = sl.CreateStyle();//estructura del documento 
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "G" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B", "G");

            SaveFileDialog sf = new SaveFileDialog();//donde se guardara el documento 
            sf.DefaultExt = "*.xlsx";//formato en el que debe guardarse 
            sf.FileName = "ExcelRoles";//nombre que se le asigna 
            sf.Filter = " Libro de Excel (*.xlsx) | *.xlsx";//formato 

            if (sf.ShowDialog() == DialogResult.OK)
            {
                sl.SaveAs(sf.FileName);
                MsgB mbox = new MsgB("informacion", "Archivo Excel creado con éxito");
                DialogResult dR = mbox.ShowDialog();//mensaje de confirmacion que se ha guardado 
            }

        }


        private void btSiguiente_Click(object sender, EventArgs e)//funcion creada para el boton siguiente 
        {
            int pagina = Convert.ToInt32(cmbPagR.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDT();

        }

        private void btAnterior_Click(object sender, EventArgs e)//boton creado para la pagina anterior 
        {
            int pagina = Convert.ToInt32(cmbPagR.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDT();
        }


        private void HabilitarBotones()//funcion para habilidar los botones de siguiente y anterior 
        {
            if (pagInicio == 1)
            {
                btAnterior.Enabled = false;
                cmbMostrar.Enabled = true;
            }
            else
            {
                btAnterior.Enabled = true;
                cmbMostrar.Enabled = false;
            }

            if (indice == (Convert.ToInt32(txtPagR.Text) - 1))
            {
                btSiguiente.Enabled = false;
            }
            else
            {
                btSiguiente.Enabled = true;
            }
        }
        private void cmbPagR_SelectionChangeCommitted(object sender, EventArgs e)//este texbox sirve para mostrar el numero de pagina en que estamos 
        {
            int pagina = Convert.ToInt32(cmbPagR.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDT();

        }

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)//texbox muestra un numero determinado de paginas 
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
            CargarDT();
        }



        private void button6_Click(object sender, EventArgs e)//funcion que servira para cerrar el formulario
        {
            this.Close();
        }

        private void btnNuevo_EnabledChanged(object sender, EventArgs e)//funcion cambiar color del boton 
        {
            btnNuevo.BackColor = Color.DarkGray;
        }

        private void dgvRoles_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvRoles.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                Image imagen = Properties.Resources.editar;

                dgvRoles.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvRoles.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvRoles.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                Image imagen = Properties.Resources.eliminar;

                dgvRoles.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvRoles.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
        }
    }
}
