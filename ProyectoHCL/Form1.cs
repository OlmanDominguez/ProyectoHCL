
using System.Text;
using System;

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

        //LLamada de form para recuperar contraseña
        private void label3_Click(object sender, EventArgs e)
        {
            Form formulario = new RecuContra();
            formulario.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseDatosHCL.ObtenerConexion();
            MessageBox.Show("Conectado");
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

        //Cambio de color para label de olvide contrasena
        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
            label3.BackColor = Color.Black;
        }
    }
}


