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

Programa:         Pantalla de Ingreso de Facturacion
Fecha:             26 - septiembre - 2023
Programador: Joel
descripcion:       Pantalla que contrala las validaciones de Facturacion

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
        MsgB msgB = new MsgB();
        public EditarCliente()
        {
            InitializeComponent();
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



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

        Control control = new Control();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VCamposVacios() == false)
            {
                MsgB mbox1 = new MsgB("advertencia", "Favor llene todos los campos");
                DialogResult dR1 = mbox1.ShowDialog();
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
                    control.editarClie(txtNombre.Text, tip, txtApellido.Text, txtEmpresa.Text,
                        txtRTN.Text, txtTele1.Text, txtEmail1.Text, int.Parse(claseCod.codigo),
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
    }
}
