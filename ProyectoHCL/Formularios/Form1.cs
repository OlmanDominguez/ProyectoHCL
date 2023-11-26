
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
        AdmonUsuarios adU = new AdmonUsuarios();
        int intentosFallidos = 0;
        int maxIntentosFallidos = 3;


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
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("Select * From TBL_USUARIO where USUARIO = '"
                        + UsuarioBox1.Text + "';");

                    MySqlDataReader leer = comando.ExecuteReader();

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
                        string pass = (string)leer["PASS"];
                        DateTime generado = (DateTime)leer["GENERADO"];
                        string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        var tiempo = Convert.ToDateTime(ahora) - generado;
                        clasecompartida.estado = (int)leer["ID_ESTADO"];

                        if (usuario == UsuarioBox1.Text && contrasena == ContraseñaBox2.Text)
                        {
                            if (clasecompartida.estado == 1)
                            {
                                this.Hide();
                                clasecompartida.iduser = (int)leer["ID_USUARIO"];
                                clasecompartida.user = UsuarioBox1.Text;
                                clases.CDatos.idRolUs = (int)leer["ID_ROL"];
                                clases.CDatos.nombre = (string)leer["NOMBRE_USUARIO"];
                                clases.CDatos.correo = (string)leer["EMAIL"];
                                ContraseñaBox2.Text = "";
                                Form formulario = new Dashboard();
                                formulario.Show();
                            }
                            else if (clasecompartida.estado == 3)
                            {
                                clasecompartida.iduser = (int)leer["ID_USUARIO"];
                                clasecompartida.user = UsuarioBox1.Text;
                                clases.CDatos.idRolUs = (int)leer["ID_ROL"];
                                ContraseñaBox2.Text = "";

                                Form contra = new RestaContra();
                                contra.ShowDialog();

                                Form formu = new PreguntasRecuContra();
                                formu.ShowDialog();
                            }
                            else if (clasecompartida.estado == 2)
                            {
                                MsgB mbox = new MsgB("advertencia", "El usuario está inactivo, por favor contacte al administrador");
                                DialogResult dR = mbox.ShowDialog();
                                UsuarioBox1.Clear();
                                ContraseñaBox2.Clear();
                            }
                            else if (clasecompartida.estado == 4)
                            {
                                MsgB mbox = new MsgB("advertencia", "Acceso denegado, el usuario está bloqueado");
                                DialogResult dR = mbox.ShowDialog();
                                UsuarioBox1.Clear();
                                ContraseñaBox2.Clear();
                            }
                            else
                            {
                                MsgB mbox = new MsgB("advertencia", "USUARIO Y/O CONTRASEÑA NO EXISTEN O NO SON VÁLIDOS");
                                DialogResult dR = mbox.ShowDialog();
                            }
                        }
                        else if (usuario == UsuarioBox1.Text && pass == ContraseñaBox2.Text && tiempo.Hours < 2)
                        {
                            clasecompartida.user = UsuarioBox1.Text;
                            ContraseñaBox2.Text = "";
                            Form formulario = new RestaContra();
                            formulario.Show();
                        }
                        else
                        {
                            intentosFallidos++;

                            // Mostrar mensaje de intento fallido
                            MsgB mbox = new MsgB("advertencia", "USUARIO Y/O CONTRASEÑA NO EXISTEN O NO SON VÁLIDOS");
                            DialogResult dR = mbox.ShowDialog();

                            // Bloquear acceso si se exceden los intentos fallidos permitidos
                            if (intentosFallidos >= maxIntentosFallidos)
                            {
                                MsgB mboxBloqueo = new MsgB("advertencia", "Demasiados intentos fallidos para este usuario. Acceso bloqueado.");
                                DialogResult dRBloqueo = mboxBloqueo.ShowDialog();
                                adU.UpdateUsuario(UsuarioBox1.Text);
                                UsuarioBox1.Clear();
                                ContraseñaBox2.Clear();
                            }
                        }
                    }
                    else
                    {
                        MsgB mbox = new MsgB("advertencia", "USUARIO Y/O CONTRASEÑA NO EXISTEN O NO SON VÁLIDOS");
                        DialogResult dR = mbox.ShowDialog();
                    }
                    comando.Connection.Close();
                }
            }
            catch (Exception a)
            {
                MsgB mbox = new MsgB("error", "Error:" + a.Message + a.StackTrace);
                DialogResult dR = mbox.ShowDialog();
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

        private void ContraseñaBox2_TextChanged(object sender, EventArgs e)
        {

            if (ContraseñaBox2.Text.Contains(" "))
            {
                //MessageBox.Show("No se permite espacios.");
                MsgB m = new MsgB("informacion", "No se permite espacios");
                DialogResult dR = m.ShowDialog();
                ContraseñaBox2.Clear();
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

        private void UsuarioBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (Char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MsgB m = new MsgB("advertencia", "Por favor, sólo ingrese letras");
                DialogResult dR = m.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FORMULARIO_FormClosing(object sender, FormClosingEventArgs e)
        {
            //GuardarIntentosFallidosEnArchivo();
        }

        //private void CargarIntentosFallidosDesdeArchivo()
        //{
        //    if (File.Exists(rutaArchivo))
        //    {
        //        string[] lineas = File.ReadAllLines(rutaArchivo);

        //        foreach (string linea in lineas)
        //        {
        //            string[] partes = linea.Split(',');
        //            if (partes.Length == 2)
        //            {
        //                string usuario = partes[0];
        //                int intentosFallidosU = int.Parse(partes[1]);

        //                intentosFallidos[usuario] = intentosFallidosU;
        //            }
        //        }
        //    }
        //}

        //private void GuardarIntentosFallidosEnArchivo()
        //{
        //    List<string> lineas = new List<string>();

        //    foreach (var par in intentosFallidos)
        //    {
        //        lineas.Add($"{par.Key},{par.Value}");
        //    }

        //    File.WriteAllLines(rutaArchivo, lineas.ToArray());
        //}
    }
}


