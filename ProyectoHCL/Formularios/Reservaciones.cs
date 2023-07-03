using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;

namespace ProyectoHCL
{
    public partial class Reservaciones : Form
    {
        public Reservaciones()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void Reservaciones_Load(object sender, EventArgs e)
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select * from TBL_SOLICITUDRESERVA");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_reservaciones.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form formulario = new NuevaReservacion();

            formulario.Show();
        }
    }
}
