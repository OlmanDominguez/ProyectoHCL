
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
using static ProyectoHCL.RecuContra;

namespace ProyectoHCL
{
    public partial class FORMULARIO : Form
    {
        MsgB msgB = new MsgB();

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

        //LLamada de form para recuperar contrase�a
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
                        + UsuarioBox1.Text + "';");

                    MySqlDataReader leer = comando.ExecuteReader();


                    //Validaci�n de la data obtenida
                    if (UsuarioBox1.Text == String.Empty)
                    {
                        errorProvider1.SetError(UsuarioBox1, "Ingrese un Usuario");
                        UsuarioBox1.Focus();
                        return;
                    }
                    errorProvider1.Clear();
                    if (string.IsNullOrEmpty(Contrase�aBox2.Text))
                    {
                        errorProvider1.SetError(Contrase�aBox2, "Ingrese una clave");
                        Contrase�aBox2.Focus();
                        return;
                    }

                    if (leer.Read() == true)
                    {
                        

                        string usuario = (string)leer["USUARIO"];

                        string contrasena = (string)leer["CONTRASENA"];

                        string pass = (string)leer["PASS"];

                        DateTime generado = (DateTime)leer["GENERADO"];

                        string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        var tiempo = Convert.ToDateTime(ahora) - generado;

                        clasecompartida.estado = (int)leer["ID_ESTADO"];

                        if (usuario == UsuarioBox1.Text & contrasena == Contrase�aBox2.Text & clasecompartida.estado == 1)
                        {
                            clasecompartida.iduser = (int)leer["ID_USUARIO"];
                            clasecompartida.user = UsuarioBox1.Text;
                            //clases.CDatos.idUsu = (int)leer["ID_USUARIO"];
                            clases.CDatos.idRolUs = (int)leer["ID_ROL"];
                            clases.CDatos.nombre = (string)leer["NOMBRE_USUARIO"];
                            clases.CDatos.correo = (string)leer["EMAIL"];
                            Contrase�aBox2.Text = "";
                            Form formulario = new Dashboard();
                            formulario.Show();
                            this.Hide();
                        }
                        else if (usuario == UsuarioBox1.Text & contrasena == Contrase�aBox2.Text & clasecompartida.estado == 3)
                        {
                            clasecompartida.iduser = (int)leer["ID_USUARIO"];
                            clasecompartida.user = UsuarioBox1.Text;
                            //clases.CDatos.idUsu = (int)leer["ID_USUARIO"];
                            clases.CDatos.idRolUs = (int)leer["ID_ROL"];
                            Contrase�aBox2.Text = "";

                            Form contra = new RestaContra();
                            contra.ShowDialog();

                            Form formu = new PreguntasRecuContra();
                            formu.ShowDialog();
                            
                        }
                        else if (usuario == UsuarioBox1.Text & pass == Contrase�aBox2.Text & tiempo.Hours < 2)
                        {
                            clasecompartida.user = UsuarioBox1.Text;
                            Contrase�aBox2.Text = "";
                            Form formulario = new RestaContra();
                            formulario.Show();
                        }
                        else if (usuario == UsuarioBox1.Text & contrasena == Contrase�aBox2.Text & clasecompartida.estado == 2)
                        {
                            MsgB mbox = new MsgB("advertencia", "El usuario est� inactivo, por favor contacte al administrador");
                            DialogResult dR = mbox.ShowDialog();
                            UsuarioBox1.Clear();
                            Contrase�aBox2.Clear();
                        }
                        else if (usuario == UsuarioBox1.Text & contrasena == Contrase�aBox2.Text & clasecompartida.estado == 4)
                        {
                            MsgB mbox = new MsgB("advertencia", "Acceso denegado, el usuario est� bloqueado");
                            DialogResult dR = mbox.ShowDialog();
                            UsuarioBox1.Clear();
                            Contrase�aBox2.Clear();
                        }
                        else
                        {
                            // MessageBox.Show("USUARIO Y/O CONTRASE�A NO EXISTEN O NO SON VALIDOS");
                            MsgB mbox = new MsgB("advertencia", "USUARIO Y/O CONTRASE�A NO EXISTEN O NO SON VALIDOS");
                            DialogResult dR = mbox.ShowDialog();
                        }

                       

                    }
                    else
                    {
                        // MessageBox.Show("USUARIO Y/O CONTRASE�A NO EXISTEN O NO SON VALIDOS");
                        MsgB mbox = new MsgB("advertencia", "USUARIO Y/O CONTRASE�A NO EXISTEN O NO SON VALIDOS");
                        DialogResult dR = mbox.ShowDialog();
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
                // MessageBox.Show("No se permite espacios.");
                MsgB m = new MsgB("informacion", "No se permite espacios");
                DialogResult dR = m.ShowDialog();
                UsuarioBox1.Clear();
                return;  //Sale

            }

        }

        private void Contrase�aBox2_TextChanged(object sender, EventArgs e)
        {
         
            if (Contrase�aBox2.Text.Contains(" "))
            {
                //MessageBox.Show("No se permite espacios.");
                MsgB m = new MsgB("informacion", "No se permite espacios");
                DialogResult dR = m.ShowDialog();
                Contrase�aBox2.Clear();
                return;  //Salekk
            }
           
        }

        private void MostrarBox3_Click(object sender, EventArgs e)
        {
            OcultarBox4.BringToFront();
            Contrase�aBox2.PasswordChar = '\0';
        }

        private void OcultarBox4_Click(object sender, EventArgs e)
        {
            MostrarBox3.BringToFront();
            Contrase�aBox2.PasswordChar = '*';
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


