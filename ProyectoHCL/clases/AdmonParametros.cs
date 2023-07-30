using DocumentFormat.OpenXml.Office.Word;
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
    public class AdmonParametros
    {
        MySqlConnection conn;
        MySqlCommand cmd;

       /* public DataTable ModificarParametro (int idP, string nombreparametro, string valor)
        {
            try
            {
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("EditarHabitacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idP",idP);
                cmd.Parameters.AddWithValue("@nombreparametro", nombreparametro);
                cmd.Parameters.AddWithValue("@valor",valor );
                //cmd.Parameters.AddWithValue("@fechacreacion", fechacreacion);
                //cmd.Parameters.AddWithValue("@fechaactualizacion", fechaactualizacion);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }*/
    }

}
