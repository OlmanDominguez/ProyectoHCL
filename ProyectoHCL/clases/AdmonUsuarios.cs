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

        public bool EditarUsuario(Usuarios usuario)
        {
            bool edito = false;

            try
            {
                string sql = "UPDATE TBL_USUARIO SET ID_ESTADO = @ID_ESTADO, ID_ROL = @ID_ROL, USUARIO = @USUARIO, " +
                    "NOMBRE_USUARIO = @NOMBRE_USUARIO, PRIMERINGRESO = @PRIMERINGRESO, " +
                    "FECHAVENCIMIENTO = @FECHAVENCIMIENTO, EMAIL = @EMAIL WHERE USUARIO = @USUARIO;";

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID_ESTADO", usuario.ESTADO_USUARIO1);
                cmd.Parameters.AddWithValue("@ID_ROL", usuario.ROL_USUARIO1);
                cmd.Parameters.AddWithValue("@USUARIO", usuario.USUARIO1);
                cmd.Parameters.AddWithValue("@NOMBRE_USUARIO", usuario.NOMBRE1);
                cmd.Parameters.AddWithValue("@PRIMERINGRESO", usuario.FECHA_CREACION1);
                cmd.Parameters.AddWithValue("@FECHAVENCIMIENTO", usuario.FECHA_VENCIMIENTO1);
                cmd.Parameters.AddWithValue("@EMAIL", usuario.EMAIL1);

                cmd.ExecuteNonQuery();
                edito = true;
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return edito;
        }

        public bool EliminarUsuario(string idUsuario)
        {
            bool elimino = false;   

            try
            {
                string sql = "DELETE FROM TBL_USUARIO WHERE ID_USUARIO = @ID_USUARIO;";

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
                throw;
            }

            return elimino;
        }
    }
}
