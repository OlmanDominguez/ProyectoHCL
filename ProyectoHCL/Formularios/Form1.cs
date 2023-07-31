
using System.Text;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoHCL.clases;
using MySql.Data.MySqlClient;
using static ProyectoHCL.RecuContra;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using ProyectoHCL.Formularios;
using DocumentFormat.OpenXml.Bibliography;

namespace ProyectoHCL
{
    public partial class FORMULARIO : Form
    {

        public FORMULARIO()
        {
            InitializeComponent();

            //Borrado de barra
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        //LLamada de form para recuperar contraseña
        private void label3_Click(object sender, EventArgs e)
        {
            Form formulario = new RecuContra();
            formulario.ShowDialog(); //Bloquea el form nuevo
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            try

            {

                using (BaseDatosHCL.ObtenerConexion())

                {
                    //Consulta

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("Select * From TBL_USUARIO where USUARIO = '"
                        + UsuarioBox1.Text + "' AND CONTRASENA = '" + ContraseñaBox2.Text + "' ");

                    MySqlDataReader leer = comando.ExecuteReader();


                    //Validación de la data obtenida
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
                    if (leer.Read() == true)
                    {
                        

                        string usuario = (string)leer["USUARIO"];

                        string contrasena = (string)leer["CONTRASENA"];

                        

                        if (usuario == UsuarioBox1.Text & contrasena == ContraseñaBox2.Text)
                        {

                            Form formulario = new Dashboard();
                            formulario.Show();
                        }

                       

                    }
                    else
                    {
                        MessageBox.Show("USUARIO NO EXISTE");
                    }
                    
                  
                
                    comando.Connection.Close();
                }

               
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }

        }


        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void UsuarioBox1_TextChanged(object sender, EventArgs e)
        {
            if (UsuarioBox1.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Sale

            }

        }

        private void ContraseñaBox2_TextChanged(object sender, EventArgs e)
        {
         
            if (ContraseñaBox2.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
                return;  //Salekk
            }
           
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

        //Drag Form y botenes de cerrar y minimizar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}


