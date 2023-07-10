using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProyectoHCL.RecuContra;

namespace ProyectoHCL.clases
{
    internal class AdmonClientes
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable MostrarClientes()
        {
            DataTable mostrarClientesDT = new DataTable();

            try
            {
                string sql = "SELECT CODIGO AS CODIGO, NOMBRE AS NOMBRES, APELLIDO AS APELLIDOS, DNI_PASAPORTE " + 
                    "AS IDENTIFICACIÓN, TELEFONO FROM TBL_CLIENTE";


                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                mostrarClientesDT.Load(reader);

            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error");
            }
            return mostrarClientesDT;

        }

        
        public void modificarCliente( string NOMBRECL, int ID_TIPOCLIENTECL, string APELLIDOCL,
             string NOMBRE_RTNCL, string RTNCL, string TELEFONOCL, string EMAILCL, int CODIGOCL, 
             string DNI_PASAPORTECL, string TELEFONO2CL, string EMAIL2CL)
        {

            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("EditarCliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOMBRECL", NOMBRECL);
                cmd.Parameters.AddWithValue("@ID_TIPOCLIENTECL", ID_TIPOCLIENTECL);
                cmd.Parameters.AddWithValue("@APELLIDOCL", APELLIDOCL);
                cmd.Parameters.AddWithValue("@NOMBRE_RTNCL", NOMBRE_RTNCL);
                cmd.Parameters.AddWithValue("@RTNCL", RTNCL);
                cmd.Parameters.AddWithValue("@TELEFONOCL", TELEFONOCL);
                cmd.Parameters.AddWithValue("@EMAILCL", EMAILCL);
                cmd.Parameters.AddWithValue("@CODIGOCL", CODIGOCL);
                cmd.Parameters.AddWithValue("@DNI_PASAPORTECL", DNI_PASAPORTECL);
                cmd.Parameters.AddWithValue("@TELEFONO2CL", TELEFONO2CL);
                cmd.Parameters.AddWithValue("@EMAIL2CL", EMAIL2CL);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        public bool EliminarCliente(string Codigo)
        {
            bool elimino = false;

            try
            {
                string sql = "DELETE FROM TBL_CLIENTE WHERE CODIGO = @CODIGO;";

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CODIGO", Codigo);

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
