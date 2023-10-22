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

Catedratico analisis y diseño:             Lic. Giancarlo Martini Scalici Aguilar 
catedratico programacion e implementacion: Lic. Karla Melisa Garcia Pineda 
catedratico evaluacion de sistemas:        Lic. Karla Melisa Garcia Pineda 


---------------------------------------------------------------------

Programa:         Pantalla de Ctrlparametro.
Fecha:             26-sept-2023
Programador:       Olman
descripcion:       Pantalla que controla los registros nuevos y tambien permite editar, eliminar cualquier parametro que se haya regsitrado 

-----------------------------------------------------------------------

                Historial de Cambio
Agrado de la documentacion 
-----------------------------------------------------------------------

Programador               Fecha                      Descripcion
GABRIELA  MANCIA  

HILDEGARD  MONTALVAN   

NELSON SALGADO  

JOEL  GODOY 

OLMAN  DOMÍNGUEZ 

-----------------------------------------------------------------------*/





using MySql.Data.MySqlClient;//libreria que nos permite realizar la conecxion a la BD
using ProyectoHCL.clases;//Libreria que nos permite utilizar las funciones de las clases 
using SpreadsheetLight.Drawing;//Libreria que la utilizamos 
using SpreadsheetLight;//Permite la manipulacion de datos en excel 
using System;//Libreria para identificar los bloques de codigo 
using System.Collections.Generic;//Libreria de lectura 
using System.ComponentModel;//Libreria para escribir la gerarquia de los componentes funcionales 
using System.Data;//Libreria que nos permite administrar datos de diferentes fuentes 
using System.Drawing;//libreria para impresion en excel 
using System.Linq;//Libreria para clases he interfaces 
using System.Text;//Libreria para manipular la informacion dentro de la aplicacion 
using System.Threading.Tasks;//Libreria para ejecutar tareas simultaneas al mismo tiempo 
using System.Windows.Forms;//libreria para operaciones unicas que no devuelven ningun valor 
//estas librerias se instalaron para imprimir un documento pdf
using static ProyectoHCL.Formularios.CtrlClientes;//Libreria que nos permite manipular las funciones de ctrlclientes 
using static ProyectoHCL.RecuContra;//Libreria que nos permite manipular las funciones recucontra 
using DocumentFormat.OpenXml.Office.Word;//Libreria que nos permite manipular documentos en formato word 

namespace ProyectoHCL.Formularios.Parametros
{
    public partial class CtrlParametro : Form
    {
        clases.Parametros para = new clases.Parametros();// creamos el objeto para para utilizar sus funciones  
        DataSet ds = new DataSet();//creamos el objeto ds para usar sus funciones 
        CDatos cDatos = new CDatos();//creamos el objeto cdatos par autilizar sus funciones 
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0; //creamos variales que ocuparemos 



        public CtrlParametro()//creamos la funcion  de ctrlparametro 
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDGP();

        }

        private void CargarDGP()//creamos la  funcion cargardgp para mostrar los datos en el datagrig
        {
            para.Inicio1 = pagInicio;
            para.Final1 = pagFinal;
            ds = para.PaginacionParametro();
            dgvParametros.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPagP.Text = cantidad.ToString();

            cmbPagP.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPagP.Items.Add(x.ToString());

            cmbPagP.SelectedIndex = indice;
            HabilitarBotones();

        }

        //creamos la columna con las funciones de editar y eliminar 
        private void CtrlParametro_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvParametros.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvParametros.Columns.Add(btnDelete);

            Permisos();
        }

        public void BuscarParametro(string buscarP)//creamos una funcion para buscar parametro  por medio de nombre 
        {

            try
            {
                //realizamos la conecxion a la BD
                MySqlConnection conn;
                MySqlCommand cmd;

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarParametro", conn);//Llamamos al procedimiento almacenado creado previamente 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreP", MySqlDbType.VarChar, 50).Value = buscarP;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvParametros.DataSource = dt;



            }
            catch (Exception)
            {

                throw;

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)//Se crea el boton de un nuevo registro 
        {
            //Para form de nuevo
            parame.p = 2;
            Form formulario = new Formularios.R_E_Parametro();
            formulario.ShowDialog();
            CargarDGP();

        }

        public static class parame
        {
            public static string parametro;
            public static int idparametro;
            public static string valor;
            public static int p;
        }


        private void dgvParametros_CellClick(object sender, DataGridViewCellEventArgs e)//creamos dos opciones 
        {
            if (this.dgvParametros.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                try
                {
                    parame.parametro = dgvParametros.CurrentRow.Cells["PARAMETRO"].Value.ToString();//columna parametro
                    parame.idparametro = Convert.ToInt32(dgvParametros.CurrentRow.Cells["IDPARAMETRO"].Value.ToString());
                    parame.valor = dgvParametros.CurrentRow.Cells["VALOR"].Value.ToString();
                    parame.p = 1;
                    Form formulario = new Formularios.R_E_Parametro();

                    string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//le decimos que la fecha se la actual 

                    MySqlConnection conn;
                    MySqlCommand cmd;

                    //Creamos la consulta  para editar                  
                    string sql = "INSERT INTO TBL_BITACORA (ID_USUARIO, ID_OBJETO, FECHA, ACCION, DESCRIPCION) VALUES " +
                        "('" + clasecompartida.iduser + "', '7', '" + ahora + "', 'INGRESO', 'INGRESO A EDITAR PARAMETRO " +
                        parame.idparametro + " " + parame.parametro + "');";
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    formulario.ShowDialog();
                    CargarDGP();
                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un error");
                }
            }


            if (this.dgvParametros.Columns[e.ColumnIndex].Name == "ELIMINAR")//le damos la segunda condicional en ddado caso que desee eliminar 
            {
                try
                {
                    //realizamos la conecion a la base de datos 
                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand("DeleteParametro", conn);//llamamos al procedimiento almacenado creado 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", dgvParametros.CurrentRow.Cells["IDPARAMETRO"].Value.ToString());

                    cmd.ExecuteNonQuery();
                    MsgB m = new MsgB("informacion", "Registro eliminado con éxito");
                    DialogResult dR = m.ShowDialog();//mensaje de confirmacion que se ha eliminado el parametro 
                    conn.Close();

                    string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//muestra todo el datagrip ya con el objeto eliminado 
                    string sql = "INSERT INTO TBL_BITACORA (ID_USUARIO, ID_OBJETO, FECHA, ACCION, DESCRIPCION) VALUES " +
                        "('" + clasecompartida.iduser + "', '7', '" + ahora + "', 'ELIMINACION', 'ELIMINACION PARAMETRO " +
                        dgvParametros.CurrentRow.Cells["PARAMETRO"].Value.ToString() + " " + dgvParametros.CurrentRow.Cells["VALOR"].Value.ToString() + "');";
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    CargarDGP();

                }
                catch (Exception ex)
                {
                    MsgB m = new MsgB("Error: ", ex.Message);
                    DialogResult dR = m.ShowDialog();//en dado qque no se realice ninguna de las anteriores enviara este error 
                }
            }
        }

        private void dgvParametros_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvParametros.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)//columna editar 
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvParametros.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoEditar = new Icon(Environment.CurrentDirectory + "\\editar.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvParametros.Rows[e.RowIndex].Height = icoEditar.Height + 8;
                this.dgvParametros.Columns[e.ColumnIndex].Width = icoEditar.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvParametros.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)//columna editar 
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvParametros.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");//el icono que se utilizara para representar el boton eliminar 
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvParametros.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvParametros.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        private void txtBuscarCl_TextChanged(object sender, EventArgs e)//creaxion de combox para buscar parametros creados 
        {
            if (txtBuscarCl.Text != "")
            {
                BuscarParametro(txtBuscarCl.Text);
            }
            else
            {
                CargarDGP();
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)//creacion de o clic de pagina anterior 
        {
            int pagina = Convert.ToInt32(cmbPagP.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGP();
        }

        private void btnSig_Click(object sender, EventArgs e)//creacion del evento onclic del label siguiente 
        {
            int pagina = Convert.ToInt32(cmbPagP.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGP();
        }

        private void HabilitarBotones()//habilitacion de los botnese siguiente anterior y mostrar 
        {
            if (pagInicio == 1)
            {
                btnAnt.Enabled = false;
                cmbMostrarP.Enabled = true;
            }
            else
            {
                btnAnt.Enabled = true;
                cmbMostrarP.Enabled = false;
            }

            if (indice == (Convert.ToInt32(txtPagP.Text) - 1))
            {
                btnSig.Enabled = false;
            }
            else
            {
                btnSig.Enabled = true;
            }
        }

        private void cmbMostrarP_SelectedIndexChanged(object sender, EventArgs e)//creacion del combobox de mostrar pagina  y donde se poúede seleccionar un numero determinado 
        {
            cmbIndice = cmbMostrarP.SelectedIndex;
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
            CargarDGP();
        }

        private void cmbPagP_SelectionChangeCommitted(object sender, EventArgs e)//creacion del evento seleccion donde solo se mostrara el numero de pagiana que se encuentra 
        {
            int pagina = Convert.ToInt32(cmbPagP.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGP();
        }

        private void btnCerrar_Click(object sender, EventArgs e)//creacion del boton cerrar pantalla 
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)//creacion del boton crear pdf
        {
            crearExcel();
        }

        private void crearExcel()//creacion de la funcion crear pdf
        {
            SLDocument sl = new SLDocument();

            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(Properties.Resources.logo);//ubicacion del logo que aparecera en el pdf 
            Byte[] ba;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                bm.Save(ms, System.Drawing.Imaging.ImageFormat.Png);//formato de la imagen 
                ms.Close();
                ba = ms.ToArray();
            }
            SLPicture pic = new SLPicture(ba, DocumentFormat.OpenXml.Packaging.ImagePartType.Jpeg);//librerias que se descargaron 
            pic.SetPosition(0, 0);
            pic.ResizeInPixels(80, 80);//posicion de la informacion 
            sl.InsertPicture(pic);

            //En los siguientes parrafos se muestra la fuente y diseño del pdf 
            sl.SetCellValue("C2", "Reporte de Parametros");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            //Se muestra el encabezado de la tabla que se descargara en pdf 
            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_Parametro");
            sl.SetCellValue("B" + celdaCabecera, "Codigo Parametro");
            sl.SetCellValue("C" + celdaCabecera, "Codigo Usuario");
            sl.SetCellValue("D" + celdaCabecera, "Usuario");
            sl.SetCellValue("E" + celdaCabecera, "Parametro");
            sl.SetCellValue("F" + celdaCabecera, "Valor");
            sl.SetCellValue("G" + celdaCabecera, "Creacion");
            sl.SetCellValue("H" + celdaCabecera, "Modificacion");


            SLStyle estiloCa = sl.CreateStyle();//Fuente y orden de como se mostrara el encabezado del pdf 
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "H" + celdaCabecera, estiloCa);

            //Realizando la consulta en la base de datos 
            string sql = "SELECT p.ID_PARAMETRO, p.ID_USUARIO, u.USUARIO, p.PARAMETRO, p.VALOR, p.FECHACRE, p.FECHAMODIFI FROM TBL_PARAMETRO p inner join TBL_USUARIO u on p.ID_USUARIO = u.ID_USUARIO";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())//Especificando donde y como debe ir cada columna en la impresion de pdf 
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["ID_PARAMETRO"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["ID_USUARIO"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["USUARIO"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["PARAMETRO"].ToString());
                sl.SetCellValue("F" + celdaCabecera, reader["VALOR"].ToString());
                sl.SetCellValue("G" + celdaCabecera, reader["FECHACRE"].ToString());
                sl.SetCellValue("H" + celdaCabecera, reader["FECHAMODIFI"].ToString());

            }

            SLStyle EstiloB = sl.CreateStyle();
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "H" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B", "H");//Celda donde debe iniar la tabla y donde debe finalizar 

            SaveFileDialog sf = new SaveFileDialog();

            //formato en que se debe guardar el archivo 
            sf.DefaultExt = "*.xlsx";
            sf.FileName = "ExcelParametros";
            sf.Filter = " Libro de Excel (*.xlsx) | *.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                sl.SaveAs(sf.FileName);//se guardara en una ruta estatica 
                MsgB mbox = new MsgB("informacion", "Archivo Excel creado con éxito");
                DialogResult dR = mbox.ShowDialog();
            }
        }

        private void Permisos()//creacion de la funcion  permiso
        {
            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs);

            foreach (var obj in LsObj)
            {
                switch (obj.IdPermiso)
                {
                    case 2:
                        if (obj.ObjetoN == "PARAMETROS" && !obj.Permitido) //Validar pantalla y el permiso
                        {
                            btnNuevo.Visible = false; //Deshabilitar botón para crear
                        }
                        break;
                    case 3:
                        if (obj.ObjetoN == "PARAMETROS" && !obj.Permitido)
                        {
                            dgvParametros.Columns["EDITAR"].Visible = false; //Ocultar columna del botón para editar en datagrid
                        }
                        break;
                    case 4:
                        if (obj.ObjetoN == "PARAMETROS" && !obj.Permitido)
                        {
                            dgvParametros.Columns["ELIMINAR"].Visible = false; //Ocultar columna del botón para eliminar en datagrid
                        }
                        break;
                }
            }
        }






    }
}
