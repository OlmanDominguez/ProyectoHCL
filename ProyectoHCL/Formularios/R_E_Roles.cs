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

Programa:         Pantalla de Registro y Editar Roles.
Fecha:             26-sept-2023
Programador:       Olman
descripcion:       Pantalla que contrala las validaciones para poder ingresar y editar los roles 

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



//estas librerias son las que se utilizaran para la base de datos ,para las clases del mismo programa
using MySql.Data.MySqlClient;//esta libreria es para usar la base de datos 
using ProyectoHCL.clases;//sirve para usar las  clases o libreria creadaas dentro del programa
using System;//Libreria para identificar los bloques de codigo 
using System.Collections.Generic;//Libreria de lectura 
using System.ComponentModel;//Libreria para escribir la gerarquia de los componentes funcionales 
using System.Data;//Libreria para la conexion a la base de datos 
using System.Drawing;//Libreria para la impresion en excel 
using System.Linq;//Libreria para las clases he interfaces
using System.Text;//Libreria para manipular la informacion dentro de la aplicacion 
using System.Threading.Tasks;//Libreria para ejecutar tareas simultaneas al mismo tiempo 
using System.Windows.Forms;////libreria para operaciones unicas que no devuelven ningun valor 
//estas librerias se instalaron para imprimir un documento pdf
using static ProyectoHCL.RecuContra;//LIbreria donde ocuaparemos objetos de recucontra

namespace ProyectoHCL.Formularios
{
    public partial class R_E_Roles : Form
    {
        //inicializamos algunas variables a utilizar
        public R_E_Roles()
        {
            InitializeComponent();
        }

        public string idRol = null;

        MsgB msgB = new MsgB();

        //al momento de cerrar se puedan limpiar los campos  que se llenaron 
        public void limpiarCampos()
        {
            txtRol.Clear();
            txtNumero.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError()
        {
            error1.SetError(txtRol, "");
            error1.SetError(txtNumero, "");
            error1.SetError(cmbEstado, "");
        }

        //va a minimizar la´pantalla al momento de dar clic 
        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //al dar clic en el siguiente boton cancelara  ya sea la edicion o  el registro que estaba realizando 
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
            limpiarCampos();
            limpiarError();
        }

        //al momento de dar clic  en el siguiente boton cerrara la ventana y a la vez limpiara los campos 
        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiarCampos();
            limpiarError();
        }

        int posY = 0;
        int posX = 0;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }



        }

        //validar que los texbox esten llenos y no queden vacios 
        private void txtRol_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtRol))
            {
                error1.SetError(txtRol, "Introduzca un nombre");
            }
            else
            {
                error1.Clear();
            }
        }

        //validara que el texbox estado este seleccionado con una de las dos opciones 
        private void cmbEstado_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.cmbVacio(cmbEstado))
            {
                error1.SetError(cmbEstado, "Seleccione un estado");
            }
            else
            {
                error1.Clear();
            }
        }

        // esta funcucion es creada para que al momento de dar clic al  boton se guarde la informacion ingresada en la base de datos 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (label11.Text == "Registrar Rol")
            {
                Modelo modelo = new Modelo();

                if (txtRol.Text.Trim() == "" || txtNumero.Text.Trim() == "" || cmbEstado.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");//mensaje de av¿dvertencia si los campos no han sido llenado 
                    DialogResult dR = m.ShowDialog();

                }
                else if (modelo.existeRol(txtRol.Text))//condicional if que verificara que el rol no se repita y en caso de ser asi mandara un mensaje con rol ya existe 
                {
                    MsgB m = new MsgB("advertencia", "El Rol ya existe");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        //conecion a la base de datos 
                        MySqlConnection conn;
                        MySqlCommand cmd;
                        conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                        conn.Open();

                        //inserta los datos en la tabla rol  
                        cmd = new MySqlCommand("insertarRol", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombrerol", txtRol.Text);
                        cmd.Parameters.AddWithValue("@descripcion", txtNumero.Text);
                        cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);


                        //mensaje de confirmacion de que el registro se ha realizado 
                        cmd.ExecuteNonQuery();
                        MsgB m = new MsgB("informacion", "Registro creado con éxito");
                        DialogResult dR = m.ShowDialog();
                        limpiarCampos();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MsgB m = new MsgB("Error: ", ex.Message);
                        DialogResult dR = m.ShowDialog();
                    }
                }
            }
            else if (label11.Text == "Editar Rol")// etiqueta para editar al momento de dar clic enviara a otro formulario donde permitira editar
            {
                string nuevoRol = txtRol.Text;
                string nuevoDescripcion = txtNumero.Text;
                string idRegistro = idRol;
                Control control = new Control();
                Modelo modelo = new Modelo();

                if (txtRol.Text.Trim() == "" || txtNumero.Text.Trim() == "" || cmbEstado.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                /* else if (modelo.existeditarRol(txtRol.Text))
                 {
                     MsgB m = new MsgB("advertencia", "El rol ya existe");
                     DialogResult dR = m.ShowDialog();
                 }
                 else if (modelo.existeditarDR(txtNumero.Text))
                 {
                     MsgB m = new MsgB("advertencia", "La descripcion ya existe");
                     DialogResult dR = m.ShowDialog();
                 }*/
                else if (modelo.RolEditarBD(nuevoRol, idRegistro))
                {
                    MsgB m = new MsgB("advertencia", "El usuario ya está registrado");
                    DialogResult dR = m.ShowDialog();
                }
                else if (modelo.DescripcionEditarBD(nuevoDescripcion, idRegistro))
                {
                    MsgB m = new MsgB("advertencia", "El usuario ya está registrado");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        control.editarR(idRol, txtRol.Text, txtNumero.Text, cmbEstado.Text);//campos los cuales podra editar 

                        MsgB m = new MsgB("informacion", "Registro modificado");//mensaje de confirmacion de que la edicion se llevo a cabo 
                        DialogResult dR = m.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MsgB m = new MsgB("Error: ", ex.Message);
                        DialogResult dR = m.ShowDialog();// en dado caso que no se guarde o que haya un error enviara este mensaje 
                    }
                }
            }

        }

        //esta funcion validara que el texbox se ingresen letras
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        //validara que este texbox no este vacio
        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtNumero))
            {
                error1.SetError(txtNumero, "Introduzca una descripción");
            }
            else
            {
                error1.Clear();
            }
        }

        private void txtRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (Char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MsgB m = new MsgB("advertencia", "Por favor, sólo ingrese letras");
                DialogResult dR = m.ShowDialog();
            }
        }
    }
}
