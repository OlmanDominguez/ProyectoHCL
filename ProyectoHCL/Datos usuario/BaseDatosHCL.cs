using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoHCL.clases
{
    public class BaseDatosHCL
    {

        public static MySqlConnection ObtenerConexion()
        {

            MySqlConnection conectar = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");

            try
            {
                conectar.Open();
            }
            catch (MySqlException ex)
            {
                MsgB mbox = new MsgB("error", "Error: " + ex.ToString());
                DialogResult dR = mbox.ShowDialog();
            }

            return conectar;
        }
    }
}

