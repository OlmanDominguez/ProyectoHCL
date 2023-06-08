
using System.Text;
using System;
using System.Windows.Forms;

namespace ProyectoHCL
{
    public partial class FORMULARIO : Form
    {
        public FORMULARIO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // BaseDatosHCL.ObtenerConexion();
            //MessageBox.Show("Conectado");
            if (UsuarioBox1.Text == String.Empty)
            {
                errorProvider1.SetError(UsuarioBox1, "Ingrese un Usuario");
                UsuarioBox1.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ContraseñaBox2.Text))
            {
                errorProvider1.SetError(ContraseñaBox2, "Ingrese una clave");
                ContraseñaBox2.Focus();
                return;
            }
            errorProvider1.Clear();
            UsuarioDatos usuarioDatos = new UsuarioDatos();
            bool usuarioValido = await usuarioDatos.ValidarUsuarioAsync(UsuarioBox1.Text, ContraseñaBox2.Text);

            if (usuarioValido == true)
            {
                PrincipalForm principalForm = new PrincipalForm();
                this.Hide();
                principalForm.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void UsuarioBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContraseñaBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarBox3_Click(object sender, EventArgs e)
        {
            OcultarBox4.BringToFront();
            ContraseñaBox2.PasswordChar = '\0';
        }

        private void OcultarBox4_Click(object sender, EventArgs e)
        {
            MostrarBox3.BringToFront();
            ContraseñaBox2.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


