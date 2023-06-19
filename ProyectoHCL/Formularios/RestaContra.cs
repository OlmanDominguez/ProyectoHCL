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
using static ProyectoHCL.RecuContra;

namespace ProyectoHCL.Formularios
{
    public partial class RestaContra : Form
    {
        public RestaContra()
        {
            InitializeComponent();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_Contra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar); //Bloquea espacio
        }

        private void TXT_Confi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar); //Bloquea espacio
        }

        private void TXT_Confi_TextChanged(object sender, EventArgs e)
        {
            if (TXT_Contra.Text.Equals(TXT_Confi.Text) == false)
            {
                errorProvider1.SetError(TXT_Confi, "Contraseña no coincide");
            }
            else
            {
                errorProvider1.SetError(TXT_Confi, "");
            }
        }

        private void OcultarBox4_Click(object sender, EventArgs e)
        {
            MostrarBox3.BringToFront();
            TXT_Contra.PasswordChar = '*';
        }

        private void MostrarBox3_Click(object sender, EventArgs e)
        {
            OcultarBox4.BringToFront();
            TXT_Contra.PasswordChar = '\0';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            TXT_Confi.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            TXT_Confi.PasswordChar = '\0';
        }

        private void RestaContra_Load(object sender, EventArgs e)
        {
            TXT_Confi.PasswordChar = '*';
            TXT_Contra.PasswordChar = '*';
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Conexion y comando
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("UPDATE TBL_USUARIO SET CONTRASENA = '"
                        + TXT_Confi.Text + "' where USUARIO = '" + clasecompartida.user + "'");

                    comando.ExecuteNonQuery();
                    comando.Connection.Close();
                    MessageBox.Show("Cambio de contraseña Exitoso");
                    comando.Connection.Close();
                    this.Close();

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }
        }
    }
}
