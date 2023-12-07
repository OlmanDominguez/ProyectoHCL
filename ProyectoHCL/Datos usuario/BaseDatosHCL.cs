using System;
using System.Collections.Generic;
using System.Data;
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

        /*public static MySqlConnection ObtenerConexion()
        {
            string cadenaConexion = "server=containers-us-west-29.railway.app;port=6844; database=railway; Uid=root; pwd=LpxjPRi2Ckkz7FiKNUHn;";

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            try
            {
                // No es necesario abrir la conexión aquí. Deja la responsabilidad al código que la utiliza.
                // conexion.Open();
            }
            catch (MySqlException ex)
            {
                // Lanza la excepción para que pueda ser manejada por el código que llama a ObtenerConexion.
                // También puedes agregar más información al mensaje de la excepción si es necesario.
                throw new Exception("Error al abrir la conexión.", ex);
            }

            return conexion;
        }

        public static void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (MySqlException ex)
            {
                // Manejar o lanzar la excepción según tus necesidades.
                throw new Exception("Error al cerrar la conexión.", ex);
            }
        }*/

    }
}

