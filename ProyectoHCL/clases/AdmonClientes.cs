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

Programa:         Pantalla de Ingreso de admoncliente
Fecha:             27 - septiembre - 2023
Programador:      Joel
descripcion:       Pantalla que contrala las validaciones de administracion cliente

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
using System; /* directiva para identificar los bloques de codigo */
using System.Collections.Generic; /* libreria para lectura*/
using System.Data; /* Conexion a la BD*/
using System.Linq; /* libreria para clases e interfaces */
using System.Text; /* manipular informacion dentro de la aplicacion */
using System.Threading.Tasks; /* libreria para impresion */
using static ProyectoHCL.RecuContra; 

namespace ProyectoHCL.clases
{
    internal class AdmonClientes  /* clase administracion cliente */
    {
        MySqlConnection conn; /* declaracion de variables para conectar a la BD */
        MySqlCommand cmd;

        public DataTable MostrarClientes() /* tabla de datos mostrar clientes  */
        {
            DataTable mostrarClientesDT = new DataTable();

            try
            {
                string sql = "SELECT CODIGO AS CODIGO, NOMBRE AS NOMBRES, APELLIDO AS APELLIDOS, DNI_PASAPORTE " + 
                    "AS IDENTIFICACIÓN, TELEFONO FROM TBL_CLIENTE";


                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;"); /* proceso de conexion a la BD */
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader(); /* lectura para mostrar clientes */
                mostrarClientesDT.Load(reader);

            }
            catch (Exception)  /* detectar errores en ejecucion */
            {
                MessageBox.Show("Se produjo un error");
            }
            return mostrarClientesDT;

        }

        
        public void modificarCliente( string NOMBRECL, int ID_TIPOCLIENTECL, string APELLIDOCL,
             string NOMBRE_RTNCL, string RTNCL, string TELEFONOCL, string EMAILCL, int CODIGOCL, 
             string DNI_PASAPORTECL, string TELEFONO2CL, string EMAIL2CL)
        {

            try
            {
                MySqlConnection conn; 
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("EditarCliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOMBRECL", NOMBRECL);
                cmd.Parameters.AddWithValue("@ID_TIPOCLIENTECL", ID_TIPOCLIENTECL);
                cmd.Parameters.AddWithValue("@APELLIDOCL", APELLIDOCL);
                cmd.Parameters.AddWithValue("@NOMBRE_RTNCL", NOMBRE_RTNCL);
                cmd.Parameters.AddWithValue("@RTNCL", RTNCL);
                cmd.Parameters.AddWithValue("@TELEFONOCL", TELEFONOCL);
                cmd.Parameters.AddWithValue("@EMAILCL", EMAILCL);
                cmd.Parameters.AddWithValue("@CODIGOCL", CODIGOCL);
                cmd.Parameters.AddWithValue("@DNI_PASAPORTECL", DNI_PASAPORTECL);
                cmd.Parameters.AddWithValue("@TELEFONO2CL", TELEFONO2CL);
                cmd.Parameters.AddWithValue("@EMAIL2CL", EMAIL2CL);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        public bool EliminarCliente(string Codigo)
        {
            bool elimino = false;

            try
            {
                string sql = "DELETE FROM TBL_CLIENTE WHERE CODIGO = @CODIGO;"; /* declaracion de variable y borra codigo de tabla cliente */

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;"); /* proceso de conexion a la BD */
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CODIGO", Codigo); /* parametros en codigo */

                cmd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return elimino;
        }






    }
}
