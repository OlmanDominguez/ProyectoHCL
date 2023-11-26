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

Programa:         Pantalla de Ingreso de mostrar cliente
Fecha:             27 - septiembre - 2023
Programador:      Joel
descripcion:       Pantalla que contrala las validaciones de mostrar cliente

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
using System.ComponentModel; /* jerarguia de los componentes funcionales */
using System.Data; /* Conexion a la BD*/
using System.Drawing; /* impresion de archivos en excel */
using System.Linq; /* libreria para clases e interfaces */
using System.Text; /* manipular informacion dentro de la aplicacion */
using System.Threading.Tasks; /* libreria para impresion */
using System.Windows.Forms;
using static ProyectoHCL.Formularios.CtrlClientes;

namespace ProyectoHCL.Formularios
{
    public partial class ShowCliente : Form  /* clase publica mostrar cliente */
    {
        public ShowCliente()
        {
            InitializeComponent();
        }

        int posY = 0;   /* declaracion de variables */
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)  /* validacion mediante condicional IF*/
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

        private void ShowCliente_Load(object sender, EventArgs e)
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select * from TBL_CLIENTE WHERE CODIGO = " + claseCod.id +
                        "");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        lb_ID.Text = (string)leer["DNI_PASAPORTE"];
                        lb_nombres.Text = (string)leer["NOMBRE"];
                        lb_apellidos.Text = (string)leer["APELLIDO"];
                        lb_Tele1.Text = (string)leer["TELEFONO"];
                        lb_Tele2.Text = (string)leer["TELEFONO2"];
                        lb_RTN.Text = (string)leer["RTN"];
                        lb_email1.Text = (string)leer["EMAIL"];
                        lb_email2.Text = (string)leer["EMAIL2"];
                        lb_Empresa.Text = (string)leer["NOMBRE_RTN"];


                    }


                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
