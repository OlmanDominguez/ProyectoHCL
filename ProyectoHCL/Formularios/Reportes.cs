using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHCL
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string cadenaSQL = "SELECT * FROM TBL_FACTURA WHERE FECHA BETWEEN @FechaDesde AND @FechaHasta";

            using (MySqlConnection conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database=railway; Uid=root; pwd=LpxjPRi2Ckkz7FiKNUHn;"))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(cadenaSQL, conn))
                {
                    cmd.Parameters.AddWithValue("@FechaDesde", dateTimePicker_Desde.Value);
                    cmd.Parameters.AddWithValue("@FechaHasta", dateTimePicker_Hasta.Value);

                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        dgvReportes.DataSource = read;

                        if (read.Read())
                        {
                            // Realizar acciones si se encontraron resultados
                        }
                    }
                }
            }
        }

    }
}
