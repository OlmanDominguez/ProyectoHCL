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

namespace ProyectoHCL.clases
{
     class CDatos
     {
        public static string usuario;
        public static string nombre;
        public static string correo;
        public static string contraseña;


        public static int idUsu; //Almacenar id Usuario
        public static int idRolUs; //ALmacenar id Rol

        public DataTable listarObjetos()
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

        public void GuardarPermiso(PermisoRol permisoR)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("spInsertPermiso", conn);
                cmd.CommandType = CommandType.StoredProcedure;

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

        public List<PermisoRol> SelectObjeto(int idR)
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
                cmd.Parameters.Add(new MySqlParameter("@idRol", idR));
                da.SelectCommand = cmd;
                da.Fill(dt);

                List<PermisoRol> Objeto =
                    (from row in dt.AsEnumerable()
                     select new PermisoRol()
                     {
                         IdPermiso = int.Parse(row["ID_PERMISO"].ToString()),
                         IdRol = row["ROL"].ToString(),
                         IdObjeto = row["OBJETO"].ToString(),
                         Permitido = Convert.ToBoolean(row["PERMITIDO"])

                     }).ToList();

                return Objeto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void ActualizarPermiso(PermisoRol permisoR)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("EditarPermisos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

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
