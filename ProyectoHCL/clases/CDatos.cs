using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProyectoHCL.RolesPermisos;
using System.Windows.Forms;
using System.Data;
using ProyectoHCL.Formularios;

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

//Programa:         Clase datos de permisos
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Clase con las funciones para listar los objetos, guardar permisos, actualizar permisos y devolver una lista de objetos con permisos

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
     class CDatos
     {
        public static string usuario;
        public static string nombre;
        public static string correo;
        public static string contraseña;
        public static string cliente;
        public static DateTime entrada;
        public static DateTime salida;


        public static int idUsu; //Almacenar id Usuario
        public static int idRolUs; //ALmacenar id Rol
        public static int numeroHab;


        public DataTable listarObjetos() //función para listar los objetos almacenados en la tabla TBL_OBJETO
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT ID_OBJETO AS ID, OBJETO AS PANTALLA FROM TBL_OBJETO;";               
                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        public void GuardarPermiso(PermisoRol permisoR) //función que guarda los permisos recibiendo como parametro un objeto permiso
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("spInsertPermiso", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros que recibe el procedimiento almacenado
                cmd.Parameters.Add(new MySqlParameter("@idRol", permisoR.IdRol));
                cmd.Parameters.Add(new MySqlParameter("@idPermiso", permisoR.IdPermiso));
                cmd.Parameters.Add(new MySqlParameter("@idObjeto", permisoR.IdObjeto));
                cmd.Parameters.Add(new MySqlParameter("@permitido", permisoR.Permitido));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<PermisoRol> SelectObjeto(int idR) //lista que devuelve los objetos con sus respectivos permisos al recibir como parametro el id de Rol
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");

            DataTable dt = new DataTable();

            try
            {
                cmd = new MySqlCommand("spSelectObjeto", conn);
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                //parametro que recibe el procedimiento almacenado
                cmd.Parameters.Add(new MySqlParameter("@idRol", idR));
                da.SelectCommand = cmd;
                da.Fill(dt);

                List<PermisoRol> Objeto =
                    (from row in dt.AsEnumerable()
                     select new PermisoRol()
                     {
                         //llenar lista con el id del permiso, el id del rol, el objeto y valor permitido(true or false)
                         IdPermiso = int.Parse(row["ID_PERMISO"].ToString()),
                         IdRol = row["ROL"].ToString(),
                         ObjetoN = row["OBJETO"].ToString(),
                         Permitido = Convert.ToBoolean(row["PERMITIDO"])

                     }).ToList();

                return Objeto; //retornar lista
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null; //si hubo un error no retornar nada
            }
        }

        public void ActualizarPermiso(PermisoRol permisoR) //función que actualiza los permisos recibiendo como parametro un objeto permiso
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("EditarPermisos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros que recibe el procedimiento almacenado
                cmd.Parameters.Add(new MySqlParameter("@idRol", permisoR.IdRol));
                cmd.Parameters.Add(new MySqlParameter("@idPermiso", permisoR.IdPermiso));
                cmd.Parameters.Add(new MySqlParameter("@idObjeto", permisoR.IdObjeto));
                cmd.Parameters.Add(new MySqlParameter("@permitido", permisoR.Permitido));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     }
}
