using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHCL.Formularios
{
    public partial class ServicioHab : Form
    {
        public ServicioHab()
        {
            InitializeComponent();
            CargarHabitaciones();
        }

        private const string connection = "server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;";

        private void CargarHabitaciones()
        {
            listViewR.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();

                string query = "SELECT NUMEROHABITACION, TBL_TIPOHABITACION.TIPO, ESTADOHABITACION " +
                    "FROM TBL_HABITACION INNER JOIN TBL_TIPOHABITACION ON TBL_HABITACION.ID_TIPOHABITACION =" +
                    " TBL_TIPOHABITACION.ID_TIPOHABITACION WHERE ESTADOHABITACION = 'RESERVADO'";
                MySqlCommand command = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["NUMEROHABITACION"].ToString());
                        item.SubItems.Add(reader["TIPO"].ToString());
                        item.SubItems.Add(reader["ESTADOHABITACION"].ToString());

                        listViewR.Items.Add(item);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (listViewR.SelectedItems.Count > 0)
            {
                string habitacion = listViewR.SelectedItems[0].Text;
                string sql = $"SELECT NUMEROHABITACION, CONCAT(TBL_CLIENTE.NOMBRE, ' ', TBL_CLIENTE.APELLIDO) AS NOMBRE," +
                    $" INGRESO, SALIDA\r\nFROM TBL_SOLICITUDRESERVA\r\nINNER JOIN TBL_CLIENTE ON " +
                    $"TBL_SOLICITUDRESERVA.COD_CLIENTE = \r\nTBL_CLIENTE.CODIGO\r\nWHERE NUMEROHABITACION = '{habitacion}' " +
                    $"AND ID_ESTADORESERVA = 1";

                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        conn.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                clases.CDatos.numeroHab = Convert.ToInt32(reader["NUMEROHABITACION"].ToString());
                                clases.CDatos.cliente = reader["NOMBRE"].ToString();
                                clases.CDatos.entrada = Convert.ToDateTime(reader["INGRESO"].ToString());
                                clases.CDatos.salida = Convert.ToDateTime(reader["SALIDA"].ToString());                             
                            }
                        }
                        conn.Close();
                    }
                }
            }

            this.Close();
        }

    

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
