using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System.Runtime.InteropServices;


namespace ProyectoHCL
{
    public partial class Dashboard : Form
    {
        int a;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button_menu1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(button_menu1, button_menu1.Width, 0);

        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            rjDropdownMenu1.IsMainMenu = true;
            

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("call estado_reserva(1,2,3,'RESERVADO','DISPONIBLE')");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        lbl_pendientes.Text = leer["canti1"].ToString();
                        lbl_reservadas.Text = leer["canti4"].ToString();
                        lbl_disponible.Text= leer["canti5"].ToString();
                        lbl_confirmadas.Text = leer["canti2"].ToString();
                        lbl_anuladas.Text = leer["canti3"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("error al cargar");
                    }
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }


        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
