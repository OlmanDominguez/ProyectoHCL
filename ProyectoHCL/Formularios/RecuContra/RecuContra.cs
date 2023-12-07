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

using System.Net.Mime;
using iText.Bouncycastlefips.Tsp;


namespace ProyectoHCL
{

    public partial class RecuContra : Form
    {
        //const string correo = "sistemahcasalomas@gmail.com";
        const string pass = "wvldqmeolycahxwd";
        private object sec;

        public RecuContra()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public static string ParametroSMTP()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR FROM TBL_PARAMETRO WHERE PARAMETRO = 'SMTPCLIENT';";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR"].ToString();
            }
            else
            {
                return null;

            }
            conn.Close();
        }

        public static string ParametroPuerto()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR FROM TBL_PARAMETRO WHERE PARAMETRO = 'PUERTO CORREO';";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR"].ToString();
            }
            else
            {
                return null;

            }
            conn.Close();
        }

        public static string ParametroCorreo()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR FROM TBL_PARAMETRO WHERE PARAMETRO = 'CORREO HOTEL';";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR"].ToString();
            }
            else
            {
                return null;

            }
            conn.Close();
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
            public static int iduser;
            public static int estado;
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
                                clasecompartida.estado = 2;
                                Form formulario = new Formularios.PreguntasRecuContra();
                                formulario.ShowDialog();
                                this.Close();
                            }
                            else if (usuario == clasecompartida.user & RBTN_Email.Checked == true)
                            {
                                string Error = "";
                                String mensaje = Properties.Resources.Contrasena.ToString();

                                string tokenf = token(10);

                                mensaje = mensaje.Replace("@CODIGO", tokenf);

                                sendemail(mensaje, DateTime.Now, ParametroCorreo(), (string)leer["EMAIL"], out Error);

                                comando.Connection.Close();


                                try
                                {
                                    using (BaseDatosHCL.ObtenerConexion())
                                    {
                                        string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                                        comando.CommandText = ("UPDATE TBL_USUARIO SET PASS = '" +
                                            tokenf + "', GENERADO = '" + ahora +
                                            "' WHERE USUARIO = '" + clasecompartida.user + "';");

                                        comando.ExecuteNonQuery();
                                        comando.Connection.Close();
                                    }

                                }
                                catch (Exception a)
                                {
                                    comando.Connection.Close();
                                    MessageBox.Show(a.Message + a.StackTrace);
                                }

                                MessageBox.Show(Error);
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

        public static void sendemail(string mensaje, DateTime fechaenvio, string de, string para, out string Error)
        {
            Error = "";
            string correo = ParametroCorreo();
            string puerto = ParametroPuerto();
            string smtpC = ParametroSMTP();

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(de);
                mail.To.Add(para);
                mail.Subject = "Recuperación Contraseña Hotel Casa Lomas";

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mensaje, Encoding.UTF8, MediaTypeNames.Text.Html);
                mail.AlternateViews.Add(htmlView);



                SmtpClient smtp = new SmtpClient(smtpC);
                smtp.Port = Convert.ToInt32(puerto);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(correo, pass);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                Error = "Se envió un correo de recuperación a tu email registrado";
            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }
        }

        private static Random random = new Random();
        public static string token(int length)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(characters, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
