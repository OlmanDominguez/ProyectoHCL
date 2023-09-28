using DocumentFormat.OpenXml.Office2010.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

//Programa:         Clase adminsitración Objetos
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Clase con las funciones para editar y elimnar  

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

namespace ProyectoHCL.clases
{
    public class AdmonObjetos
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public void modificarObjeto(int id, string nombreObj, string descObj, string estadoObj, int actPor) //función para editar los objetos
        {

            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("editarObjeto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //Parámetros que recibe el procedimiento almacenado
                cmd.Parameters.AddWithValue("@idObjeto", id);
                cmd.Parameters.AddWithValue("@nombreObj", nombreObj);
                cmd.Parameters.AddWithValue("@descObj", descObj);
                cmd.Parameters.AddWithValue("@estadoObj", estadoObj);
                cmd.Parameters.AddWithValue("@actPor", actPor); 

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public bool EliminarObjeto(string idObjeto) //función para eliminar los objetos
        {
            bool elimino = false;

            try
            {
                string sql = "DELETE FROM TBL_OBJETO WHERE ID_OBJETO = @ID_OBJETO;"; 

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(sql, conn); 

                cmd.Parameters.AddWithValue("@ID_OBJETO", idObjeto); 

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
