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

Programa:         Pantalla AdmonRoles.
Fecha:             26-sept-2023
Programador:       Olman
descripcion:       Pantalla donde se encuentra las funciones para  modificar  y eliminar  los roles 

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
using ProyectoHCL.Formularios;//Libreria que nos permite utilzar funciones de los formularios 
using System;//Directiva para identificar los bloques de codigo
using System.Collections.Generic;//Libreria de lectura
using System.Data;//Lobreria que nos permite administrar datos de diferentes fuentes
using System.Linq;//libreria para clases he interfaces
using System.Text;//Libreria para manipular informacion dentro de la palicacion 
using System.Threading.Tasks;//Libreria para impresion
using ProyectoHCL.clases;//Libreria para utilizar las funciones de las clases creadas 

namespace ProyectoHCL.clases
{
    public  class AdmonRoles//Creando la clase de admonRoles.
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        public void modificarRol(int id, string nombrerol, string descrol, string estado_rol)//Creando la funcion de modificar 
        {

            try
            {
                //realizando conecxion a la BD
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();//

                //editando los datos en la base de datos mediante la consulta editarRoles
                cmd = new MySqlCommand("EditarRoles", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idrol", id);
                cmd.Parameters.AddWithValue("@nombrerol", nombrerol);
                cmd.Parameters.AddWithValue("@descripcion", descrol);
                cmd.Parameters.AddWithValue("@estadorol", estado_rol);
               
                //cmd.Parameters.AddWithValue("@fechacreacion",fecha_creacion);
                //cmd.Parameters.AddWithValue("@actualizar", fecha_actualizacion);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);//Mnesaje de exito 
            }

        }

        public bool EliminarRoles(string idrol) //Recibe un string (el id del Rol)
        {
            bool elimino = false;

            try
            {
                //eliminando mediante la consulta realizada en la base de datos 
                string sql = "DELETE FROM TBL_ROL WHERE ID_ROL = @ID_ROL;"; //sentencia sql para eliminar EL Rol 
                //conecxion a la base de datos 
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(sql, conn); //comando que recibe la sentencia sql y la conexion

                cmd.Parameters.AddWithValue("@ID_ROL", idrol); //obtener valor del parametro id del ROL 

                cmd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);//mensaje de exito 
            }

            return elimino;
        }
    }
}
