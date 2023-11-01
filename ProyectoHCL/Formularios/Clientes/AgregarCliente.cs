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

Programa:         Pantalla de Ingreso de agregar cliente
Fecha:             27 - septiembre - 2023
Programador:      Joel
descripcion:       Pantalla que controla las validaciones de Facturacion

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
using ProyectoHCL.clases;  /* hacer uso de las clases dentro del proyecto */
using System; /* directiva para identificar los bloques de codigo */
using System.Collections.Generic; /* libreria para lectura*/
using System.ComponentModel; /* jerarguia de los componentes funcionales */
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
    public partial class AgregarCliente : Form  /* clase publica agregar cliente */
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        MsgB msgB = new MsgB();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        int posY = 0;   /* declaracion de variable */
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)  /* condiciona IF */
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedItem.ToString() == "Natural")  /* seleccion de tipo mediante condicional IF*/
            {
                gb_juridico.Visible = false;
            }
            else if (cbTipo.SelectedItem.ToString() == "Juridico")
            {
                gb_juridico.Visible = true;
            }
        }

        Control control = new Control();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            if (VCamposVacios() == false) //Validar campos vacios
            {
                MsgB mbox = new MsgB("advertencia", "Favor llene todos los campos");
                DialogResult dR = mbox.ShowDialog();
            }
            else if (modelo.existeCliente(txtID.Text)) //Validar que el cliente ya existe
            {
                MsgB mbox1 = new MsgB("advertencia", "El cliente ya existe");
                DialogResult dR1 = mbox1.ShowDialog();
            }
            else if (modelo.existeNombre(txtNombre.Text)) //validar si ya existe el nombre del cliente
            {
                MsgB m = new MsgB("advertencia", "El nombre de usuario ya existe");
                DialogResult dR = m.ShowDialog();
            }
            else if (modelo.existeEmail(txtEmail1.Text)) //validar si ya existe el correo del cliente
            {
                MsgB m = new MsgB("advertencia", "El correo proporcionado ya está registrado");
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

                    MySqlConnection conn;  /* declaracion de variable para realizar la conexion con BD */
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand("insert into TBL_CLIENTE (NOMBRE, APELLIDO, DNI_PASAPORTE, " +  /* proceso para insertar datos en la tabla respectiva.*/
                        "ID_TIPOCLIENTE, NOMBRE_RTN, RTN, TELEFONO, EMAIL, TELEFONO2, EMAIL2)" +
                        "values ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtID.Text + "', " +
                        tip + ", '" + txtEmpresa.Text + "', '" + txtRTN.Text + "', '" + txtTele1.Text + "', '" +
                        txtEmail1.Text + "', '" + txtTele2.Text + "', '" + txtEmail2.Text + "');", conn);

                    cmd.ExecuteNonQuery();
                    MsgB mbox = new MsgB("informacion", "Cliente Agregado");
                    DialogResult dR = mbox.ShowDialog();
                    conn.Close();
                    this.Close();
                }
                catch (Exception ex)   /* detectar errores en ejecucion */
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private bool VCamposVacios()
        {
            bool ok = true; /* valor booleano y condicional IF */

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

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Add("--Seleccione--");
            cbTipo.SelectedIndex = 0;
            cbTipo.Items.Add("Juridico");
            cbTipo.Items.Add("Natural");
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtNumeros(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
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

        private void txtEmail1_TextChanged(object sender, EventArgs e)
        { }

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
    }
}
