using DocumentFormat.OpenXml.Office.Word;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class AdmonParametros
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable MostrarParametro()
        {
            DataTable mostrarParametrosDT = new DataTable();

            try
            {
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("listarParametro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataReader reader = cmd.ExecuteReader();
                mostrarParametrosDT.Load(reader);

            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error");
            }
            return mostrarParametrosDT;

        }
    }
    /*public void modificarParametro(int id, string estado, string rol, string usuario, string nombre,
           DateTime vencimiento, string email)
    {

        try
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("EditarUsuarios", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idUs", id_p);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@rol", rol);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@vencimiento", vencimiento);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();
            conn.Close();

        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }

    }*/

}
