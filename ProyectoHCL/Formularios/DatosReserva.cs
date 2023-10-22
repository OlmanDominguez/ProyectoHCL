using DocumentFormat.OpenXml.Office.Word;
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
using static ProyectoHCL.Formularios.CalendarioReservas;

namespace ProyectoHCL.Formularios
{
    public partial class DatosReserva : Form
    {
        string fecha;
        CalendarioReservas calendario = new CalendarioReservas();
        private const string connection = "server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;";

        public DatosReserva()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatosReserva_Load(object sender, EventArgs e)
        {
            fecha = CalendarioReservas.static_anio + "-" + CalendarioReservas.static_mes + "-" + UserControlDias.static_dia;
            lblHab.Text = clases.CDatos.numHabDR;
            ObtenerDatos();
            lblCliente.Text = clases.CDatos.cliente;
            lblEntrada.Text = clases.CDatos.entrada.ToString();
            lblSalida.Text = clases.CDatos.salida.ToString();
        }

        public void ObtenerDatos()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();

                // Consulta SQL para recuperar los datos
                string sqlQuery = "SELECT CONCAT(TBL_CLIENTE.NOMBRE, ' ', TBL_CLIENTE.APELLIDO) AS NOMBRE," +
                                  " INGRESO, SALIDA\r\nFROM TBL_SOLICITUDRESERVA\r\nINNER JOIN TBL_CLIENTE ON " +
                                  "TBL_SOLICITUDRESERVA.COD_CLIENTE = \r\nTBL_CLIENTE.CODIGO\r\n" +
                                  " WHERE NUMEROHABITACION = @numeroHabitacion " +
                                  "AND @fechaSeleccionada BETWEEN INGRESO AND SALIDA";

                using (MySqlCommand command = new MySqlCommand(sqlQuery, conn))
                {
                    // Parámetros para la consulta
                    command.Parameters.AddWithValue("@numeroHabitacion", clases.CDatos.numHabDR);
                    command.Parameters.AddWithValue("@fechaSeleccionada", fecha);

                    // Ejecutar la consulta y leer los resultados
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clases.CDatos.cliente = reader.GetString("NOMBRE");
                            clases.CDatos.entrada = (DateTime)reader["INGRESO"];
                            clases.CDatos.salida = (DateTime)reader["SALIDA"];
                        }
                    }
                    conn.Close();
                }
            }
        }

        //coordenadas para arrastrar formulario
        int posY = 0;
        int posX = 0;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
