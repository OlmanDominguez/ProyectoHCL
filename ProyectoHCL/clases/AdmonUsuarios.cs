using DocumentFormat.OpenXml.Presentation;
using MySql.Data.MySqlClient;
using ProyectoHCL.Formularios;
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

//Programa:         Clase adminsitración usuarios
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Clase con las funcion para editar y listar usuarios

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
    public class AdmonUsuarios
    {
        MySqlConnection conn; 
        MySqlCommand cmd; 

        public DataTable MostrarUsuarios() //función para listar usuarios
        {
            DataTable mostrarUsuariosDT = new DataTable();

            try
            {
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("listarUsuarios", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataReader reader = cmd.ExecuteReader();
                mostrarUsuariosDT.Load(reader);

            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error");
            }
            return mostrarUsuariosDT;

        }

        public void modificarUsuario(int id, string estado, string rol, string usuario, string nombre,
            string contraseña, DateTime vencimiento, string email) //función para editar usuarios
        {

            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("EditarUsuarios", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros que recibe el procedimiento almacenado
                cmd.Parameters.AddWithValue("@idUsuario", id);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@vencimiento", vencimiento);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();
                conn.Close();

            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
