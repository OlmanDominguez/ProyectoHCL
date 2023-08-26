using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHCL.Formularios
{
    public partial class CalendarioReservas : Form
    {
        private MySqlConnection conn;
        public CalendarioReservas()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            cargarHabitaciones();
            cmbHabitacion.SelectedIndex = -1;
        }

        private void cargarHabitaciones() //Llenar el combobox con los roles almacenados en la tabla TBL_ROL
        {
            using (MySqlCommand command = new MySqlCommand("SELECT NUMEROHABITACION FROM TBL_HABITACION", conn))
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbHabitacion.Items.Add(reader["NUMEROHABITACION"].ToString());
                }
                reader.Close();
                conn.Close();
            }
        }

        private void cmbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthCalendar.RemoveAllBoldedDates();

            monthCalendar.SelectionRange = new SelectionRange();

            string habSeleccionada = cmbHabitacion.SelectedItem.ToString();
            string query = "SELECT INGRESO, SALIDA FROM TBL_SOLICITUDRESERVA WHERE NUMEROHABITACION = @habitacion AND ID_ESTADORESERVA = 1";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@habitacion", habSeleccionada);
                DataTable reserva = new DataTable();
                conn.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(reserva);
                }
                conn.Close();

                foreach (DataRow row in reserva.Rows)
                {
                    DateTime inicio = Convert.ToDateTime(row["INGRESO"]);
                    DateTime final = Convert.ToDateTime(row["SALIDA"]);
                    monthCalendar.AddBoldedDate(inicio);
                    monthCalendar.AddBoldedDate(final);
                    monthCalendar.UpdateBoldedDates();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
