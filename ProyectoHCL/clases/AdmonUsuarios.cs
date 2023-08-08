using DocumentFormat.OpenXml.Presentation;
using MySql.Data.MySqlClient;
using ProyectoHCL.Formularios;
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

        public void modificarUsuario(int id, string estado, string rol, string usuario, string nombre,
            string contraseña, DateTime vencimiento, string email)
        {

            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("EditarUsuarios", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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

        //public bool EliminarUsuario(string idUsuario) //Recibe un string (el id del usuario)
        //{
        //    bool elimino = false;   

        //    try
        //    {
        //        string sql = "DELETE FROM TBL_USUARIO WHERE ID_USUARIO = @ID_USUARIO;"; //sentencia sql para eliminar el usuario

        //        conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
        //        conn.Open();

        //        cmd = new MySqlCommand(sql, conn); //comando que recibe la sentencia sql y la conexion

        //        cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario); //obtener valor del parametro id del usuario

        //        cmd.ExecuteNonQuery();
        //        elimino = true;
        //        conn.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }

        //    return elimino;
        //}
    }
}
