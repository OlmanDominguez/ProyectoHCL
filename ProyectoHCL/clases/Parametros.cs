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

Programa:         Pantalla de parametro .
Fecha:             26-sept-2023
Programador:       Olman
descripcion:       Aqui se encuentra el codigo de los metodos get y set y tambien se encunetra la funcion de paginacion 

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


using MySql.Data.MySqlClient;//Libreria que nos permite la conecxion a la BD
using System;//Directivas para identificar los bloques de codigo 
using System.Collections.Generic;//Libreria de lectura 
using System.Data;//Libreria que nos permite administrar datos de diferentes fuentes 
using System.Linq;//Libreria para clases he interfaces
using System.Text;//Libreria para manipular informacion dentro de la aplicacion 
using System.Threading.Tasks;//Libreria para ejecutar tareas al mismo tiempo 

namespace ProyectoHCL.clases
{
    public class Parametros//crecion de la clase parametro
    {
        private int ID_PARAMETRO;
        private int ID_USUARIO;
        private string PARAMETRO;
        private string VALOR;
        private DateTime FECHACRE;
        private DateTime FECHAMODIFI;
        private int Inicio;
        private int Final;

       // Creacion de los metodos get set 
        public int ID_PARAMETRO1 { get => ID_PARAMETRO; set => ID_PARAMETRO = value; }
        public int ID_USUARIO1 { get => ID_USUARIO; set => ID_USUARIO = value; }
        public string PARAMETRO1 { get => PARAMETRO; set => PARAMETRO = value; }
        public string VALOR1 { get => VALOR; set => VALOR = value; }
        public DateTime FECHACRE1 { get => FECHACRE; set => FECHACRE = value; }
        public DateTime FECHAMODIFI1 { get => FECHAMODIFI; set => FECHAMODIFI = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }


        public DataSet PaginacionParametro()//creacionn de la funcion paginacionParametro 
        {
            //coneccion  a la BD
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagParametros", conn);//Llamamos al procedimineto almacenado creado en la BD
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
