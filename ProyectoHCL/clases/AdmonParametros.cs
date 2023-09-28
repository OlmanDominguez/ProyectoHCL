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

Programa:         Pantalla de AdmonParametro .
Fecha:             26-sept-2023
Programador:       Olman
descripcion:       Aqui se encuentra las funciones de modificarparametro y motrar parametro

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



using DocumentFormat.OpenXml.Office.Word;//Libreria que nos permite trabajar con documentos en word 
using DocumentFormat.OpenXml.Office2010.Excel;//Libreria que nos permite trabajar con documentos excel
using MySql.Data.MySqlClient;//Libreria que nos permite la conexion a la BD
using System;//Libreri aque nosnpermite identificar los bloques de codigo 
using System.Collections.Generic;//Libreria de lectura 
using System.Data;//Libreria que nos permite administrar datos de diferentes fuentes 
using System.Linq;//Libreria para clases he interfaces 
using System.Text;//Libreria para manipular informacion dentro de la aplicacion 
using System.Threading.Tasks;//Libreria para la impresion 

namespace ProyectoHCL.clases
{
    public class AdmonParametros//creacion de la clase paramentro 
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable MostrarParametros()//creacion de la funcion MostrarParametro
        {
            DataTable mostrarParametroDT= new DataTable();

            try
            {
                //Realizando la conecxion a la base de datos 
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("listarParametros", conn);//Llamamos al procedimiento almacenado en la BD 
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataReader reader = cmd.ExecuteReader();
                mostrarParametroDT.Load(reader);

            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error");//Mensaje de Error 
            }
            return mostrarParametroDT;

        }

        //Creacion de la modificacion de Paramentro 
        public void   ModificarParametro (int idP, string parametro, string valor, DateTime fechacreacion, DateTime fechaactualizacion)
        {
            try
            {
                //Realizamos la coneccion ala base de BD
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("EditarParametro", conn);//Llamamos al procedimiento almacenado 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idP",idP);
                cmd.Parameters.AddWithValue("@parametro", parametro);
                cmd.Parameters.AddWithValue("@valor",valor );
                cmd.Parameters.AddWithValue("@fechacreacion", fechacreacion );
                cmd.Parameters.AddWithValue("@fechaactualizacion", fechaactualizacion);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }

}
