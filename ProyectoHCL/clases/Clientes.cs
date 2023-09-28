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

Programa:         Pantalla de Ingreso de clientes
Fecha:             27 - septiembre - 2023
Programador:      Joel
descripcion:       Pantalla que contrala las validaciones de cliente

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
using DocumentFormat.OpenXml.InkML; 
using DocumentFormat.OpenXml.Wordprocessing; 
using MySql.Data.MySqlClient; /* libreria para conectar a la BD */
using System; /* directiva para identificar los bloques de codigo */
using System.Collections.Generic; /* libreria para lectura*/
using System.Data; /* Conexion a la BD*/
using System.Linq; /* libreria para clases e interfaces */
using System.Numerics; 
using System.Text; /* manipular informacion dentro de la aplicacion */
using System.Threading.Tasks; /* libreria para impresion */

namespace ProyectoHCL.clases
{
    public class Clientes      /* clase publica clientes */
    {
        private int ID_TIPOCLIENTE;  /* declaracion de variables */
        private string NOMBRE;
        private string APELLIDO;
        private string NOMBRE_RTN;
        private string RTN;
        private string TELEFONO;
        private string EMAIL;
        private string DNI_PASAPORTE;
        private int CODIGO;
        private int Inicio;
        private int Final;

        public int ID_TIPOCLIENTE1 { get => ID_TIPOCLIENTE; set => ID_TIPOCLIENTE = value; }  /* obtencion y colocacion de valores  */
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public string APELLIDO1 { get => APELLIDO; set => APELLIDO = value; }
        public string NOMBRE_RTN1 { get => NOMBRE_RTN; set => NOMBRE_RTN = value; }
        public string RTN1 { get => RTN; set => RTN = value; }
        public string TELEFONO1 { get => TELEFONO; set => TELEFONO = value; }
        public string EMAIL1 { get => EMAIL; set => EMAIL = value; }
        public string DNI_PASAPORTE1 { get => DNI_PASAPORTE; set => DNI_PASAPORTE = value; }
        public int CODIGO1 { get => CODIGO; set => CODIGO = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionClientes()
        {

            MySqlConnection conn;  /* variable para conectar a la BD */
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;"); /* proceso de conexion a la BD */
            conn.Open();

            cmd = new MySqlCommand("PagClientes", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inicio", Inicio1);
            cmd.Parameters.AddWithValue("@final", Final1);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            return dt;
        }

    }
}
