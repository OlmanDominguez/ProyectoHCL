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
            hideSubMenu();
        }

        private void hideSubMenu()
        {

            panelmanteSubMenu.Visible = false;
            paneladminSubMenu.Visible = false;
        }
        private void hideSubMenu2()
        {
            if (panelmanteSubMenu.Visible == true)
                panelmanteSubMenu.Visible = false;
            if (paneladminSubMenu.Visible == true)
                paneladminSubMenu.Visible = false;
        }
        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void Dashboard_Load(object sender, EventArgs e)
        {
            panelChildForm.Visible = false;


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
                        lbl_disponible.Text = leer["canti5"].ToString();
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

        private void Ibtn_administracion_Click(object sender, EventArgs e)
        {
            showSubMenu(paneladminSubMenu);
        }

        private void Ibtn_habitaciones_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            hideSubMenu2();
        }

        private void Ibtn_servicios_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            hideSubMenu2();
        }

        private void Ibtn_descuentos_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            hideSubMenu2();
        }

        private void Ibtn_usuarios_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            hideSubMenu2();
        }

        private void Ibtn_mantenimiento_Click(object sender, EventArgs e)
        {
            showSubMenu(panelmanteSubMenu);
        }

        private void Ibtn_mantenimiento_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelmanteSubMenu);
        }

        private void Ibtn_clientes_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            hideSubMenu2();
        }

        private void Ibtn_roles_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            hideSubMenu2();
        }

        private void Ibtn_objetos_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            hideSubMenu2();
        }

        private void Ibtn_permisos_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            hideSubMenu2();
        }

        private void Ibtn_parametros_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            hideSubMenu2();
        }

        private void Ibtn_reservacion_Click_1(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new Reservaciones());


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panelChildForm.Visible = false;
        }
    }
}
