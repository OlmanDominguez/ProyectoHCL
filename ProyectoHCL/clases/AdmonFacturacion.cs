using DocumentFormat.OpenXml.Office.Word;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoHCL.RecuContra;

namespace ProyectoHCL.clases
{
    internal class AdmonFacturacion
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable MostrarClientes()
        {
            DataTable mostrarClientesDT = new DataTable();

            try
            {
                string sql = "SELECT NFACTURA, c.NOMBRE, c.APELLIDO, c.DNI_PASAPORTE, f.FECHA, f.TOTAL" +
                              "FROM TBL_FACTURA f"+
                              "INNER JOIN TBL_SOLICITUDRESERVA s ON f.ID_SOLICITUDRESERVA = s.ID_SOLICITUDRESERVA"+
                              "INNER JOIN TBL_CLIENTE c ON s.COD_CLIENTE = c.CODIGO";


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
    }
}
