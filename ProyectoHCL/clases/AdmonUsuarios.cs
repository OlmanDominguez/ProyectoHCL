using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class AdmonUsuarios
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable MostrarUsuarios()
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

        
        public void BuscarUsuarios( string buscarU)
        {
            try
            {
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarUsuarios", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public bool EliminarUsuario(string idUsuario)
        {
            bool elimino = false;

            try
            {
                string sql = "DELETE FROM TBL_USUARIOS WHERE ID_USUARIO = @ID_USUARIO;";

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);

                cmd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception)
            {
            }

            return elimino;
        }
    }
}
