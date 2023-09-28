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

Programa:         Pantalla de roles .
Fecha:             26-sept-2023
Programador:       Olman
descripcion:       Pantalla donde se encuentra los metodos get y set  y donde se encuentra la funcion paginacion 

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







using iText.Kernel.Pdf;//libreria para trabajar con documentos  pdf 
using iTextSharp.text.pdf;//libreria para manipular el texto de pdf 
using MySql.Data.MySqlClient;//libreria para realizar la conecxion a la BD
using System;//Libreria para identificar los bloques de codigo 
using System.Collections.Generic;//Libreria de lectura 
using System.Data;//Libreria que se utiliza para administrar datos de diferentes fuentes 
using System.Linq;//Libreria para las clases he interfaces
using System.Text;//libreria para manipular informacion dentro de la apliacion 
using System.Threading.Tasks;//Libreria para ejecutar tareas simultaneas ala mismo tiempo
using System.Windows.Forms.Design;//libreria para operaciones unicas que no devuelven ningun valor 
//estas librerias se instalaron para imprimir un documento pdf
using PdfWriter = iTextSharp.text.pdf.PdfWriter;//Libreria que nos permite agregar contenido a pdf 

namespace ProyectoHCL.clases
{
    public class Roles
    {
        public int ID_ROL;
        public string NOMBRE_ROL;
        public string DESCRIPCION;
        public string ESTADO_ROL;
        public DateTime FECHA_CREACION;
        public DateTime FECHA_ACTUALIZACION;
        private int Inicio;
        private int Final;

        //creacion de los metodo get y set que se utilizan para la entrada y salida de datos 
        public int ID_ROL1 { get => ID_ROL; set => ID_ROL = value; }

        public string NOMBRE_ROL1 { get => NOMBRE_ROL; set => NOMBRE_ROL = value; }

        public string DESCRIPCION1 { get => DESCRIPCION; set => DESCRIPCION = value; }
        public string ESTADO_ROL1 { get => ESTADO_ROL; set => ESTADO_ROL = value; }
       
        public DateTime FECHA_CREACION1 { get => FECHA_CREACION; set => FECHA_CREACION = value; }

        public DateTime FECHA_ACTUALIZACION1 { get => FECHA_ACTUALIZACION; set => FECHA_ACTUALIZACION= value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionRoles()//creando la funcion de paginacion
        {
            //para la conecxion a la base de datos 
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            //Llamando al procedimiento almacenado 
            cmd = new MySqlCommand("PagRoles", conn);
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
        
 




