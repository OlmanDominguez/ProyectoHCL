/* -----------------------------------------------------------------------
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
using DocumentFormat.OpenXml.Office.Word;
using MySql.Data.MySqlClient;  /* libreria para conectar a la BD */
using System; /* directiva para identificar los bloques de codigo */
using System.Collections.Generic; /* libreria para lectura*/
using System.Data; /* Conexion a la BD*/
using System.Linq; /* libreria para clases e interfaces */
using System.Text; /* manipular informacion dentro de la aplicacion */
using System.Threading.Tasks; /* libreria para impresion */
using System.Windows.Forms;
using static ProyectoHCL.RecuContra;

namespace ProyectoHCL.clases
{
    internal class AdmonFacturacion /* clase administracion funciones */
    {
        MySqlConnection conn; /* declaracion de variable para conectar a la BD */
        MySqlCommand cmd;

        public DataTable MostrarClientes()   /* tabla de datos mostrar clientes */
        {
            DataTable mostrarClientesDT = new DataTable();

            try
            {
                string sql = "SELECT NFACTURA, c.NOMBRE, c.APELLIDO, c.DNI_PASAPORTE, f.FECHA, f.TOTAL" +    /* declaracion de variable y seleccion de datos de la tabla factura */
                              "FROM TBL_FACTURA f"+
                              "INNER JOIN TBL_SOLICITUDRESERVA s ON f.ID_SOLICITUDRESERVA = s.ID_SOLICITUDRESERVA"+
                              "INNER JOIN TBL_CLIENTE c ON s.COD_CLIENTE = c.CODIGO";


                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;"); /* proceso de conexion*/
                conn.Open();
                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();   /*lectura mostrar clientes */
                mostrarClientesDT.Load(reader);

            }
            catch (Exception) /* detectar errores en ejecucion */
            {
                MessageBox.Show("Se produjo un error");
            }
            return mostrarClientesDT;

        }
    }
}
