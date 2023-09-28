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

Programa:         Pantalla de BACKUP .
Fecha:             26-sept-2023
Programador:       Olman
descripcion:       Pantalla donde se encuentra la funcion para realizar un backup
                   sirve para hacer un respaldo de la BD 

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



using System;//Libreria para identificar los bloques de codigo
using System.IO;//
using MySql.Data.MySqlClient;//Libreria para realizar la concexion a la BD
using IWshRuntimeLibrary;//Libreria que nos permite interactuar con archivos de acceso directo 
using System.Collections.Generic;//Libreria de lectura
using System.ComponentModel;//Libreria paraescribir la gerarquia de los componentes funcionales 
using System.Data;//Libreria que se utiliza para administrar datos de diferentes fuentes 
using System.Drawing;//Libreria para impresion de excel 
using System.Linq;//Libreria para las clases he interfaces 
using System.Text;//Libreria para manipular informacion dentro de la aplicacion 
using System.Threading.Tasks;//Libreria para ejecutar tareas simultaneas al mismo tiempo 
using System.Windows.Forms;//libreria para operaciones unicas que no devuelven ningun valor 
//estas librerias se instalaron para imprimir un documento pdf
//using DocumentFormat.OpenXml.Wordprocessing;

namespace ProyectoHCL.Formularios
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Backup_Load(object sender, EventArgs e)
        {

        }


        private void Generar_Backup_Click(object sender, EventArgs e)//creacion de la funcion 
        {

            SaveFileDialog selecciona = new SaveFileDialog();//Eligiendo el lugar donde se guardara 
            selecciona.Filter = "Archivo SQL (*.sql)|*.sql";//formato en el que se guardara sdl
            //Seleccionando la carpeta donde se alamacenara 
            selecciona.InitialDirectory = @"C:\Users\DAOdo\Desktop\SEGUNDO PERIODO 2023\Programacion he implementacion de Sistemas\ProyectoHotelCasaLomas\Backup\HotelCl.sql";
            selecciona.Title = "Seleccionar archivo de respaldo";//Nombre del archivo

            if (selecciona.ShowDialog() == DialogResult.OK)

            {
                string ruta = selecciona.FileName;
                //Selecionando la base 
                string cadena = "server=containers-us-west-29.railway.app;port=6844; user=root; database = railway; ; pwd = LpxjPRi2Ckkz7FiKNUHn;";
                cadena += "charset=utf8; convertzerodatetime=true";
                //selecionando el nombre la carpeta y el formato 
                // string ruta = @"C:\Users\DAOdo\Desktop\SEGUNDO PERIODO 2023\Programacion he implementacion de Sistemas\ProyectoHotelCasaLomas\Backup\HotelCl.sql";
                MySqlConnection conexion = new MySqlConnection(cadena);
                MySqlCommand comando = new MySqlCommand();
                MySqlBackup bk = new MySqlBackup(comando);

                comando.Connection = conexion;
                conexion.Open();
                bk.ExportToFile(ruta);
                conexion.Close();

                MessageBox.Show("Respaldo Generado");//mensaje de exito 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)//Evento click para cerrar la pantalla 
        {
            this.Close();

        }

        private void btnMin_Click(object sender, EventArgs e)//Evento click para minimizar la pantalla 
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

