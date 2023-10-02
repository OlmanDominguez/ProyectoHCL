using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2013.Word;
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

//-----------------------------------------------------------------------
//    Universidad Nacional Autonoma de Honduras (UNAH)
//		Facultad de Ciencias Economicas
//	Departamento de Informatica administrativa
//         Analisis, Programacion y Evaluacion de Sistemas
//                    Tercer Periodo 2023


//Equipo:
//GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

//HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

//NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

//JOEL ENRIQUE GODOY BONILLA---------(joel.bonilla@unah.hn)

//OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

//Catedratico analisis y diseño:             Lic.Giancarlo Martini Scalici Aguilar 
//catedratico programacion e implementacion: Lic.Karla Melisa Garcia Pineda 
//catedratico evaluacion de sistemas:        Lic.Karla Melisa Garcia Pineda 


//---------------------------------------------------------------------

//Programa:         Pantalla de Calendario de las reservas programadas
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Pantalla que muestra en el calendario las reservas programadas de una habitación 

//-----------------------------------------------------------------------

//                Historial de Cambio

//-----------------------------------------------------------------------

//Programador               Fecha                      Descripcion
//GABRIELA  MANCIA  

//HILDEGARD  MONTALVAN   

//NELSON SALGADO  

//JOEL  GODOY 

//OLMAN  DOMÍNGUEZ 

//-----------------------------------------------------------------------

namespace ProyectoHCL.Formularios
{
    public partial class CalendarioReservas : Form
    {
        private MySqlConnection conn;
        private DateTime mesAnio;
        private string habitacion;
        public static int static_anio, static_mes;

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
                    cmbHabitacion.Items.Add(reader["NUMEROHABITACION"].ToString()); //Cargar combobox con los números de las habitaciones
                }
                reader.Close();
                conn.Close();
            }
        }

        public class Reserva
        {
            public DateTime FechaIngreso { get; set; } //propiedad de la clase reserva para almacenar fecha de ingreso de la reservación
            public DateTime FechaSalida { get; set; } //propiedad de la clase reserva para almacenar fecha de salida de la reservación
        }


        public List<Reserva> ObtenerReservas(DateTime fechaActual, string habitacionS) //obtener lista de las reservas recibiendo el valor de la fecha actual y la habitación seleccionada
        {
            List<Reserva> reservas = new List<Reserva>(); //crear objeto de lista reserva

            string connectionString = "server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT INGRESO, SALIDA FROM TBL_SOLICITUDRESERVA WHERE NUMEROHABITACION = @habitacion AND ID_ESTADORESERVA = 1 AND MONTH(INGRESO) = @mes AND YEAR(INGRESO) = @anio";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //parámetros que recibe la consulta select
                cmd.Parameters.AddWithValue("@mes", fechaActual.Month);
                cmd.Parameters.AddWithValue("@anio", fechaActual.Year);
                cmd.Parameters.AddWithValue("@habitacion", habitacionS);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reserva reserva = new Reserva //objeto de la clase Reserva
                        {
                            //fechas de ingreso y salida obtenidas de la consulta select
                            FechaIngreso = reader.GetDateTime("INGRESO"),
                            FechaSalida = reader.GetDateTime("SALIDA")
                        };
                        reservas.Add(reserva); //se agrega la reserva a la lista
                    }
                }
            }

            return reservas; //se devuelve la lista de reservas
        }

        int mes, año;

        void MostrarDias()
        {
            DateTime mesAño = new DateTime(año, mes, 1); //año, mes y el primer día del mes seleccionado en el calendario
            LBLMES.Text = mesAño.ToString("MMMM").ToUpper() + " | " + año; //label para mostrar el nombre del mes y el año

            mesAnio = mesAño;

            static_mes = mes;
            static_anio = año;

            string hab = habitacion;

            int dias = DateTime.DaysInMonth(año, mes);

            int diaSemana = ((int)mesAño.DayOfWeek + 1); //Lunes = 1, Domingo = 8

            //verificar si diaSemana es igual o mayor que 8, y si lo es,
            //restar 8 al valor actual. 
            if (diaSemana >= 8)
            {
                diaSemana -= 8;
            }

            for (int i = 1; i < diaSemana; i++)
            {
                UserControlCalendario calendario = new UserControlCalendario(); //objeto del tipo UserControlCalendario
                ContenedorDias.Controls.Add(calendario); //Mostrar en el FlowLayOutPanel(Contenedor días) los días en el calendario,
                                                         //llenandolo con controles UserControlCalendario
            }

            for (int i = 1; i <= dias; i++)
            {
                UserControlDias semanaDia = new UserControlDias(); //objeto del tipo UserControlDias
                //Mostrar en el FlowLayOutPanel(Contenedor días) los días de la semana del mes seleccionado,
                //llenandolo con controles UserControlDias
                semanaDia.Dias(i);
                ContenedorDias.Controls.Add(semanaDia);
            }

            LlenarCalendario(mesAño, hab); //Se llama función para mostrar las reservas, recibiendo la fecha actual y la habitación seleccionada del combobox
        }

        private void CalendarioReservas_Load(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;
            mes = ahora.Month;
            año = ahora.Year;
            MostrarDias(); //Se llama la función para mostrar los días en el calendario al cargar el formulario
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrar el formulario 
        }

        private void btnSig_Click(object sender, EventArgs e) //botón para mostrar el siguiente mes
        {
            mes++;

            if (mes == 13)
            {
                año++;
                mes = 1;
            }

            ContenedorDias.Controls.Clear(); //Limpiar los controles en el contenedorDias

            MostrarDias();
        }

        private void btnAnt_Click(object sender, EventArgs e) //botón para mostrar el mes anterior
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

        public void LlenarCalendario(DateTime fechaActual, string habitacionS) //función para llenar el calendario con las reservas programadas
        {
            List<Reserva> reservas = ObtenerReservas(fechaActual, habitacionS); //Llamar lista de reservas obtenidas

            foreach (var control in ContenedorDias.Controls) //recorrer los controles en el contenedorDias
            {
                if (control is UserControl userControl)
                {
                    if (userControl.Controls.Find("lblDias", true).FirstOrDefault() is Label lblDias)
                    {
                        int dia = int.Parse(lblDias.Text);

                        bool reservaEnEsteDia = reservas.Any(r => dia >= r.FechaIngreso.Day && dia <= r.FechaSalida.Day); //validar las reservas en el rango de fecha ingreso y fecha salida en la lista

                        if (reservaEnEsteDia)
                        {
                            //si hay reservas, se muestra el picturebox en el userControlDias
                            if (userControl.Controls.Find("pboxReservado", true).FirstOrDefault() is PictureBox pboxReservado)
                            {
                                pboxReservado.Visible = true;
                            }
                        }
                        else
                        {
                            //si no hay reservas, se oculta el picturebox en el userControlDias
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
            //Asignar valor a habSeleccionada con el valor seleccionado en combobox
            string habSeleccionada = cmbHabitacion.SelectedItem.ToString();
            habitacion = habSeleccionada;
            DateTime fecha = mesAnio;
            LlenarCalendario(fecha, habSeleccionada);
        }
    }
}
