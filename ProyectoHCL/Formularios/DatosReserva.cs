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

            //txtHab.Text = "hola";
            //txtCliente.Text = "hola";
            //txtEntrada.Text = static_dia;
            //txtSalida.Text = "hola";
        }



        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatosReserva_Load(object sender, EventArgs e)
        {
            fecha = CalendarioReservas.static_mes + "/" + UserControlDias.static_dia + "/" + CalendarioReservas.static_anio;

            //SELECT habitacion.numero_habitacion, cliente.nombre, reserva.fecha_inicio, reserva.fecha_final
            //FROM reserva
            //JOIN habitacion ON reserva.id_habitacion = habitacion.id
            //JOIN cliente ON reserva.id_cliente = cliente.id
            //WHERE '2023-10-01' BETWEEN reserva.fecha_inicio AND reserva.fecha_final;
            string habitacion = calendario.cmbHabitacion.Text;
            txtHab.Text = habitacion; //****Crear variable para guaardar valor*************************************************************************

            //string sql = $"SELECT NUMEROHABITACION, CONCAT(TBL_CLIENTE.NOMBRE, ' ', TBL_CLIENTE.APELLIDO) AS NOMBRE," +
            //       $" INGRESO, SALIDA\r\nFROM TBL_SOLICITUDRESERVA\r\nINNER JOIN TBL_CLIENTE ON " +
            //       $"TBL_SOLICITUDRESERVA.COD_CLIENTE = \r\nTBL_CLIENTE.CODIGO\r\nWHERE NUMEROHABITACION = @habitacion " +
            //       $"AND @fechaC BETWEEN INGRESO AND SALIDA";
            //MySqlCommand cmd = new MySqlCommand(sql, connection);
            //cmd.Parameters.AddWithValue("@fechaC", fecha);

            //using (MySqlConnection conn = new MySqlConnection(connection))
            //{
            //    using (MySqlCommand command = new MySqlCommand(sql, conn))
            //    {
            //        conn.Open();
            //        using (MySqlDataReader reader = command.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                clases.CDatos.numeroHab = Convert.ToInt32(reader["NUMEROHABITACION"].ToString());
            //                clases.CDatos.cliente = reader["NOMBRE"].ToString();
            //                clases.CDatos.entrada = Convert.ToDateTime(reader["INGRESO"].ToString());
            //                clases.CDatos.salida = Convert.ToDateTime(reader["SALIDA"].ToString());
            //            }
            //        }
            //        conn.Close();
            //    }
            //}

        }
    }
}
