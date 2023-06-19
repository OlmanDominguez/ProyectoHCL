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

            if (a == 0)
            {
                pbx_1.Visible = true;
                pbx_2.Visible = true;
                pbx_3.Visible = true;
                pbx_4.Visible = true;
                pictureBox_menu.Visible = true; pictureBox_menu.Show();
                a = a + 1;
            }
            else
            {
                pbx_1.Visible = false;
                pbx_2.Visible = false;
                pbx_3.Visible = false;
                pbx_4.Visible = false;
                pictureBox_menu.Visible = false;
                a = a - 1;
            }
        }

        private void pbx_1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(pbx_1, pbx_1.Width, 0);
        }

        private void pbx_2_Click(object sender, EventArgs e)
        {
            rjDropdownMenu2.Show(pbx_2, pbx_2.Width, 0);
        }

        private void pbx_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("listo 3");
        }

        private void pbx_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("listo 4");
        }

        private void pictureBox_menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("listo 5");
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            rjDropdownMenu1.IsMainMenu = true;
            rjDropdownMenu2.IsMainMenu = true;
/*
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("Select * From TBL_USUARIO where USUARIO = ");

                    MySqlDataReader leer = comando.ExecuteReader();
                }

            }
            catch
            {

            }
*/

        }
    }
}
