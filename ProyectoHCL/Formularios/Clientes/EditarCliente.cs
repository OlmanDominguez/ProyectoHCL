/*-----------------------------------------------------------------------
    Universidad Nacional Autonoma de Honduras (UNAH)
		Facultad de Ciencias Economicas
	Departamento de Informatica administrativa
         Analisis, Programacion y Evaluacion de Sistemas
                    Tercer Periodo 2013


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

Programa:         Pantalla de Ingreso de editar cliente
Fecha:             27 - septiembre - 2023
Programador:       Joel
descripcion:       Pantalla que contrala las validaciones de editar cliente

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
using MySql.Data.MySqlClient; /* libreria para conectar a la BD */
using ProyectoHCL.clases; /* hacer uso de las clases dentro del proyecto */
using System; /* directiva para identificar los bloques de codigo */
using System.Collections.Generic; /* libreria para lectura*/
using System.ComponentModel;  /* jerarguia de los componentes funcionales */
using System.Data; /* Conexion a la BD*/
using System.Drawing; /* impresion de archivos en excel */
using System.Linq; /* libreria para clases e interfaces */
using System.Text; /* manipular informacion dentro de la aplicacion */
using System.Threading.Tasks; /* libreria para impresion */
using System.Windows.Forms;
using static ProyectoHCL.Formularios.CtrlClientes;
using ProyectoHCL.Formularios;

namespace ProyectoHCL.Formularios
{
    public partial class EditarCliente : Form  /* clase publica editar cliente */
    {

        public EditarCliente()
        {
            InitializeComponent();
        }

        public string id = null;
        MsgB msgB = new MsgB();

        int posY = 0; /* declaracion de variables */
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)  /* validacion mediante condicional IF */
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

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("SELECT C.NOMBRE, C.APELLIDO, C.DNI_PASAPORTE, C.TELEFONO," +
                        " C.TELEFONO2, C.EMAIL, C.EMAIL2, C.RTN, C.NOMBRE_RTN, T.DESCRIPCION " +
                        "FROM TBL_CLIENTE C INNER JOIN TBL_TIPOCLIENTE T ON C.ID_TIPOCLIENTE = " +
                        "T.ID_TIPOCLIENTE WHERE C.CODIGO = " + claseCod.id);

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        txtNombre.Text = (string)leer["NOMBRE"];
                        txtApellido.Text = (string)leer["APELLIDO"];
                        txtID.Text = (string)leer["DNI_PASAPORTE"];
                        txtEmail1.Text = (string)leer["EMAIL"];
                        txtEmail2.Text = (string)leer["EMAIL2"];
                        txtTele1.Text = (string)leer["TELEFONO"];
                        txtTele2.Text = (string)leer["TELEFONO2"];
                        string tipoCl = (string)leer["DESCRIPCION"];
                        txtEmpresa.Text = (string)leer["NOMBRE_RTN"];
                        txtRTN.Text = (string)leer["RTN"];
                        comando.Connection.Close();

                        cbTipo.Items.Add(tipoCl);
                        cbTipo.SelectedIndex = 0;
                        if (tipoCl == "Natural")
                        {
                            cbTipo.Items.Add("Juridico");
                        }
                        else
                        {
                            cbTipo.Items.Add("Natural");
                        }


                    }


                }

            }
            catch (Exception a)   /* detectar errores en ejecucion */
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedItem.ToString() == "Natural")    /* seleccion de tipo mediante IF */
            {
                gb_juridico.Visible = false;
            }
            else if (cbTipo.SelectedItem.ToString() == "Juridico")
            {
                gb_juridico.Visible = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoDNI = txtID.Text;
            string nuevoNombre1 = txtNombre.Text;
            string nuevoEmail = txtEmail1.Text;
            string nuevoEmail1 = txtEmail2.Text;
            string nuevoTelefono = txtTele1.Text;
            string nuevoTelefono1 = txtTele2.Text;
            string idRegistro = id;
            Control control = new Control();


            Modelo modelo = new Modelo();

            if (VCamposVacios() == false) // Validar campos vacios
            {
                MsgB mbox = new MsgB("advertencia", "Favor llene todos los campos");
                DialogResult dR = mbox.ShowDialog();
            }
            else if (modelo.DNIEditarBD(txtID.Text, claseCod.id)) //Validar que el DNI del usuario ya existe
            {
                MsgB mbox1 = new MsgB("advertencia", "El DNI de usuario ya está registrado");
                DialogResult dR1 = mbox1.ShowDialog();
            }
            else if (modelo.NombreClienteEditarBD(txtNombre.Text, claseCod.id)) //validar si ya existe el nombre del cliente
            {
                MsgB m = new MsgB("advertencia", "El nombre de cliente ya está registrado");
                DialogResult dR = m.ShowDialog();
            }
            else if (modelo.EmailEditarBD(txtEmail1.Text, claseCod.id)) //validar si ya está registrado el correo del cliente
            {
                MsgB m = new MsgB("advertencia", "El correo proporcionado ya está registrado");
                DialogResult dR = m.ShowDialog();
            }
            else if (modelo.EmailDosEditarBD(txtEmail2.Text, claseCod.id)) //validar si ya está registrado el correo del cliente
            {
                MsgB m = new MsgB("advertencia", "El correo proporcionado ya está registrado");
                DialogResult dR = m.ShowDialog();
            }
            else if (modelo.TelefonoEditarBD(txtTele1.Text, claseCod.id)) //validar si ya está registrado el teléfono del cliente
            {
                MsgB m = new MsgB("advertencia", "El teléfono proporcionado ya está registrado");
                DialogResult dR = m.ShowDialog();
            }
            else if (modelo.TelefonoDosEditarBD(txtTele2.Text, claseCod.id)) //validar si ya está registrado el teléfono del cliente
            {
                MsgB m = new MsgB("advertencia", "El teléfono proporcionado ya está registrado");
                DialogResult dR = m.ShowDialog();
            }
            else if (!ValidarTxt.CorreoValido(txtEmail1.Text)) //validar correo
            {
                MsgB m = new MsgB("advertencia", "Dirección de correo no válido");
                DialogResult dR = m.ShowDialog();
            }
            else if (txtNombre.TextLength < 5) //validar que el nombre del cliente no tenga menos de 5 caracteres
            {
                MsgB m = new MsgB("advertencia", "El nombre debe contener al menos 5 letras");
                DialogResult dR = m.ShowDialog();
            }
            else if (txtApellido.TextLength < 5) //validar que el apellido del cliente no tenga menos de 5 caracteres
            {
                MsgB m = new MsgB("advertencia", "El apellido debe contener al menos 5 letras");
                DialogResult dR = m.ShowDialog();
            }
            else
            {
                try
                {

                    int tip = 0;
                    string nombre;
                    if (txtEmpresa.Text.Trim() == "") { txtEmpresa.Text = "N/A"; }
                    if (txtRTN.Text.Trim() == "") { txtRTN.Text = "N/A"; }
                    if (txtTele2.Text.Trim() == "") { txtTele2.Text = "N/A"; }
                    if (txtEmail2.Text.Trim() == "") { txtEmail2.Text = "N/A"; }
                    if (cbTipo.SelectedItem.ToString() == "Juridico") { tip = 2; } else { tip = 1; }

                    control.editarClie(claseCod.id, txtNombre.Text, tip, txtApellido.Text, txtEmpresa.Text,
                        txtRTN.Text, txtTele1.Text, txtEmail1.Text,
                        txtID.Text, txtTele2.Text, txtEmail2.Text);

                    MsgB mbox = new MsgB("informacion", "Cliente Agregado");
                    DialogResult dR = mbox.ShowDialog();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private bool VCamposVacios()    /* valor booleano y condicional IF */
        {
            bool ok = true;

            if (txtNombre.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtNombre, "Introduzca el nombre del cliente");
            }
            else
            {
                errorT.Clear();
            }

            if (txtApellido.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtApellido, "Introduzca el apellido del cliente");
            }
            else
            {
                errorT.Clear();
            }

            if (txtID.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtID, "Indroduzca el numero de identificación");
            }
            else
            {
                errorT.Clear();
            }
            if (txtEmail1.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtEmail1, "Indroduzca correo electronico");
            }
            else
            {
                errorT.Clear();
            }
            if (txtTele1.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtTele1, "Indroduzca numero telefonico");
            }
            else
            {
                errorT.Clear();
            }
            if (cbTipo.SelectedItem.ToString() == "Juridico")
            {
                if (txtRTN.Text.Trim() == "")
                {
                    ok = false;
                    errorT.SetError(txtRTN, "Indroduzca RTN");
                }
                else
                {
                    errorT.Clear();
                }
                if (txtEmpresa.Text.Trim() == "")
                {
                    ok = false;
                    errorT.SetError(txtEmpresa, "Indroduzca el nombre de la empresa");
                }
                else
                {
                    errorT.Clear();
                }

            }

            return ok;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtTele1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtNumeros(e);
        }

        private void txtTele2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtNumeros(e);
        }

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtNumeros(e);
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void txtEmail1_Leave(object sender, EventArgs e)
        {
            if (!ValidarTxt.CorreoValido(txtEmail1.Text))
            {
                errorT.SetError(txtEmail1, "Dirección de correo no válida");
                txtEmail1.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtEmail2_Leave(object sender, EventArgs e)
        {
            if (!ValidarTxt.CorreoValido(txtEmail2.Text))
            {
                errorT.SetError(txtEmail2, "Dirección de correo no válida");
                txtEmail2.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtID))
            {
                errorT.SetError(txtID, "Introduzca la identificación");

            }
            else if (txtID.TextLength <= 13)
            {
                errorT.SetError(txtID, "La identificación debe contener al menos 13 números");
                txtID.Focus();
            }
            else
            {
                errorT.Clear();

            }

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtNombre))
            {
                errorT.SetError(txtNombre, "Introduzca un nombre");

            }
            else if (txtNombre.TextLength <= 4)
            {
                errorT.SetError(txtNombre, "El nombre es muy corto");
                txtNombre.Focus();
            }
            else
            {
                errorT.Clear();

            }

        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtApellido))
            {
                errorT.SetError(txtApellido, "Introduzca un apellido");

            }
            else if (txtApellido.TextLength <= 4)
            {
                errorT.SetError(txtApellido, "El apellido es muy corto");
                txtApellido.Focus();
            }
            else
            {
                errorT.Clear();

            }

        }

        private void cbTipo_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.cmbVacio(cbTipo))
            {
                errorT.SetError(cbTipo, "Seleccione el tipo de cliente");
            }
            else
            {
                errorT.Clear();
            }

        }

        private void txtRTN_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtRTN))
            {
                errorT.SetError(txtRTN, "Introduzca un RTN");

            }
            else if (txtTele2.TextLength < 14)
            {
                errorT.SetError(txtRTN, "El RTN debe contener al menos 14 dígitos");
                txtRTN.Focus();
            }
            else
            {
                errorT.Clear();

            }
        }

        private void txtTele1_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtTele1))
            {
                errorT.SetError(txtTele1, "Introduzca un teléfono");

            }
            else if (txtTele1.TextLength < 8)
            {
                errorT.SetError(txtTele1, "El teléfono debe contener al menos 8 números");
                txtTele1.Focus();
            }
            else
            {
                errorT.Clear();

            }

        }

        private void txtTele2_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtTele2))
            {
                errorT.SetError(txtTele2, "Introduzca un teléfono");

            }
            else if (txtTele2.TextLength < 8)
            {
                errorT.SetError(txtTele2, "El teléfono debe contener al menos 8 números");
                txtTele2.Focus();
            }
            else
            {
                errorT.Clear();

            }

        }

        private void txtEmpresa_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtEmpresa))
            {
                errorT.SetError(txtEmpresa, "Introduzca una Empresa");

            }
            else if (txtEmpresa.TextLength < 5)
            {
                errorT.SetError(txtEmpresa, "El nombre de la empresa es muy corta");
                txtEmpresa.Focus();
            }
            else
            {
                errorT.Clear();

            }

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
