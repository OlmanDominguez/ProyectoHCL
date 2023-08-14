using DocumentFormat.OpenXml.Office2010.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class AdmonObjetos
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public void modificarObjeto(int id, string nombreObj, string descObj, string estadoObj, int actPor)
        {

            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("editarObjeto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public bool EliminarObjeto(string idObjeto) 
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
