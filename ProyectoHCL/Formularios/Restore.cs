using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

//Programa:         Restore
//Fecha:            25 - 09 - 2023
//Programador:      Gabriela Mancia
//descripcion:      Pantalla donde se muestra el botón para restaurar la base de datos

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
    public partial class Restore : Form
    {
        public Restore()
        {
            InitializeComponent();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            string ruta = ""; //Variable tipo string "ruta"

            OpenFileDialog selecciona = new OpenFileDialog(); //Cuadro de diálogo preconfigurado
            selecciona.Filter = "Archivos SQL (*.sql)|*.sql"; //Leyenda que visualiza el usuario
            selecciona.Title = " Seleccionar Respaldo "; // Título de la ventana
            selecciona.InitialDirectory = @" C:\Users\DAOdo\Desktop\SEGUNDO PERIODO 2023\Programacion he implementacion de Sistemas\ProyectoHotelCasaLomas\Backup\HotelCl.sql"; //Url de archivo

            if (selecciona.ShowDialog() == DialogResult.OK) //Condición que el usuario afirma al entrar a la ventana
            {
                ruta = selecciona.FileName; //Obtener la ruta del archivo seleccionado
                txtRuta.Text = ruta;

                //Cadena de conexion
                string cadena = "server=containers-us-west-29.railway.app;port=6844; user = root; database = railway; pwd = LpxjPRi2Ckkz7FiKNUHn;";

                MySqlConnection conexion = new MySqlConnection(cadena);
                MySqlCommand comando = new MySqlCommand();
                MySqlBackup respaldo = new MySqlBackup(comando);

                comando.Connection = conexion;
                conexion.Open();

                respaldo.ImportFromFile(ruta); //Selecciona la ruta de la variable de respaldo
                conexion.Close();

                MessageBox.Show("El respaldo se importó correctamente");
            }
        }

        //Botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botón minimizar
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
