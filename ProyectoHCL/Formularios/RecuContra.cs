using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;

namespace ProyectoHCL
{
    public partial class RecuContra : Form
    {
        const string correo = "sistemahcasalomas@gmail.com";
        const string pass = "wvldqmeolycahxwd";
        private object sec;

        public RecuContra()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        //Boton cerrar

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBTN_Pregu_CheckedChanged(object sender, EventArgs e)
        {

        }

        public static class clasecompartida
        {
            public static string user;
        }

        private async void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if (TXT_Usuario.Text != "")
            {
                errorProvider1.SetError(TXT_Usuario, "");
                clasecompartida.user = TXT_Usuario.Text;

                try
                {

                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //Consulta
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("Select * From TBL_USUARIO where USUARIO = '"
                            + clasecompartida.user + "' ");

                        MySqlDataReader leer = comando.ExecuteReader();

                        //Validación de la data obtenida
                        if (leer.Read() == true)
                        {
                            string usuario = (string)leer["USUARIO"];
                            if (usuario == clasecompartida.user & RBTN_Pregu.Checked == true)
                            {
                                Form formulario = new Formularios.PreguntasRecuContra();
                                formulario.ShowDialog();
                                this.Close();
                            }
                            else if (usuario == clasecompartida.user & RBTN_Email.Checked == true)
                            {
                                string Error = "";
                                String mensaje = "Hola "+ clasecompartida.user + "\n\nTu contraseña es " + (string)leer["CONTRASENA"] + "\n\n";
                                StringBuilder mensajebuilder = new StringBuilder();
                                mensajebuilder.Append(mensaje);
                                sendemail(mensajebuilder, DateTime.Now, "sistemahcasalomas@gmail.com", (string)leer["EMAIL"], out Error);
                                this.Close();
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
            else
            {
                errorProvider1.SetError(TXT_Usuario, "Ingrese un nombre de Usuario");
            }
        }

        private void TXT_Usuario_TextChanged(object sender, EventArgs e)
        {
            TXT_Usuario.CharacterCasing = CharacterCasing.Upper; //Bloquea minusculas
        }

        private void TXT_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar); //Bloquea espacio
        }

        public static void sendemail(StringBuilder mensaje, DateTime fechaenvio, string de, string para, out string Error)
        {
            Error = "";
            try
            {
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format("Este correo ha sido enviado el día {0:dd/MM/yyyy} a las {0:H:mm:ss} Hrs: \n\n", fechaenvio));
                mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(de);
                mail.To.Add(para);
                mail.Subject = "Recuperación Contraseña Hotel Casa Lomas: Usuario " + clasecompartida.user;
                mail.Body = mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(correo, pass);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                Error = "Se envio un correo de recuperación a tu email registrado";
                MessageBox.Show(Error);


            }
            catch (Exception ex)
            { 
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }
        }

    }
}
