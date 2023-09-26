using DocumentFormat.OpenXml.Bibliography;
using iText.Commons.Actions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private DateTime mesAnio;
        private string habitacion;

        public CalendarioReservas()
        {
            InitializeComponent();
            cargarHabitaciones();
        }

        private void cargarHabitaciones() //Llenar el combobox con los roles almacenados en la tabla TBL_ROL
        {
            string connectionString = "server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT NUMEROHABITACION FROM TBL_HABITACION";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbHabitacion.Items.Add(reader["NUMEROHABITACION"].ToString());
                }
                reader.Close();
                conn.Close();
            }
        }

        public class Reserva
        {
            public DateTime FechaIngreso { get; set; }
            public DateTime FechaSalida { get; set; }
        }


        public List<Reserva> ObtenerReservas(DateTime fechaActual, string habitacionS)
        {
            List<Reserva> reservas = new List<Reserva>();

            string connectionString = "server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT INGRESO, SALIDA FROM TBL_SOLICITUDRESERVA WHERE NUMEROHABITACION = @habitacion AND ID_ESTADORESERVA = 1 AND MONTH(INGRESO) = @mes AND YEAR(INGRESO) = @anio";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mes", fechaActual.Month);
                cmd.Parameters.AddWithValue("@anio", fechaActual.Year);
                cmd.Parameters.AddWithValue("@habitacion", habitacionS);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reserva reserva = new Reserva
                        {
                            FechaIngreso = reader.GetDateTime("INGRESO"),
                            FechaSalida = reader.GetDateTime("SALIDA")
                        };
                        reservas.Add(reserva);
                    }
                }
            }

            return reservas;
        }

        int mes, año;

        void MostrarDias()
        {
            DateTime mesAño = new DateTime(año, mes, 1);
            LBLMES.Text = mesAño.ToString("MMMM").ToUpper() + " | " + año;

            mesAnio = mesAño;

            string hab = habitacion;

            int dias = DateTime.DaysInMonth(año, mes);

            int diaSemana = ((int)mesAño.DayOfWeek + 1);

            if (diaSemana >= 8)
            {
                diaSemana -= 8;
            }

            for (int i = 1; i < diaSemana; i++)
            {
                UserControlCalendario calendario = new UserControlCalendario();
                ContenedorDias.Controls.Add(calendario);
            }

            for (int i = 1; i <= dias; i++)
            {
                UserControlDias semanaDia = new UserControlDias();
                semanaDia.Dias(i);
                ContenedorDias.Controls.Add(semanaDia);
            }

            LlenarCalendario(mesAño, hab);
        }

        private void CalendarioReservas_Load(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;
            mes = ahora.Month;
            año = ahora.Year;
            MostrarDias();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            mes++;

            if (mes == 13)
            {
                año++;
                mes = 1;
            }

            ContenedorDias.Controls.Clear();

            MostrarDias();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            mes--;

            if (mes == 0)
            {
                año--;
                mes = 12;
            }

            ContenedorDias.Controls.Clear();

            MostrarDias();
        }

        public void LlenarCalendario(DateTime fechaActual, string habitacionS)
        {
            List<Reserva> reservas = ObtenerReservas(fechaActual, habitacionS);

            foreach (var control in ContenedorDias.Controls)
            {
                if (control is UserControl userControl)
                {
                    if (userControl.Controls.Find("lblDias", true).FirstOrDefault() is Label lblDias)
                    {
                        int dia = int.Parse(lblDias.Text);

                        bool reservaEnEsteDia = reservas.Any(r => dia >= r.FechaIngreso.Day && dia <= r.FechaSalida.Day);

                        if (reservaEnEsteDia)
                        {
                            if (userControl.Controls.Find("pboxReservado", true).FirstOrDefault() is PictureBox pboxReservado)
                            {
                                pboxReservado.Visible = true;
                            }
                        }
                        else
                        {
                            if (userControl.Controls.Find("pboxReservado", false).FirstOrDefault() is PictureBox pboxReservado)
                            {
                                pboxReservado.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private void cmbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string habSeleccionada = cmbHabitacion.SelectedItem.ToString();
            habitacion = habSeleccionada;
            DateTime fecha = mesAnio;
            LlenarCalendario(fecha, habSeleccionada);
        }
    }
}
