using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
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
    public partial class PreguntasRecuContra : Form
    {
        public PreguntasRecuContra()
        {
            InitializeComponent();
        }



        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreguntasRecuContra_Load(object sender, EventArgs e)
        {
            if (clasecompartida.estado == 3)
            {

                label1.Text = "Responde al menos 2(dos) preguntas de seguridad para restablecer tu contraseña en un futuro.";
                try
                {
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //Consulta
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("select PREGUNTA FROM TBL_PREGUNTA WHERE ID_ESTADO = 1");

                        MySqlDataReader leer = comando.ExecuteReader();

                        COBPREG.Items.Add("--Seleccione--");
                        COBPREG.SelectedIndex = 0;
                        //Validación de la data obtenida
                        while (leer.Read())
                        {
                            COBPREG.Items.Add(leer["PREGUNTA"].ToString());
                        }
                        comando.Connection.Close();
                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }
            }
            else if (clasecompartida.estado == 2)
            {
                label1.Text = "Responde a una de tus preguntas de seguridad para restablecer tu contraseña.";
                try
                {
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //Consulta
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("select TBL_PREGUNTA.PREGUNTA, TBL_PREGUNTAUSUARIO.RESPUESTA, TBL_USUARIO.NOMBRE_USUARIO FROM TBL_PREGUNTA\r\nINNER JOIN TBL_PREGUNTAUSUARIO ON TBL_PREGUNTA.ID_PREGUNTA = TBL_PREGUNTAUSUARIO.ID_PREGUNTA\r\nINNER JOIN TBL_USUARIO ON TBL_PREGUNTAUSUARIO.ID_USUARIO = TBL_USUARIO.ID_USUARIO\r\nWHERE TBL_USUARIO.USUARIO = '" + clasecompartida.user + "'");

                        MySqlDataReader leer = comando.ExecuteReader();

                        COBPREG.Items.Add("--Seleccione--");
                        COBPREG.SelectedIndex = 0;
                        //Validación de la data obtenida
                        while (leer.Read())
                        {
                            COBPREG.Items.Add(leer["Pregunta"].ToString());
                        }
                        comando.Connection.Close();
                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }
            }
            else if (clasecompartida.estado == 1)
            {
                label1.Text = "Actualiza tus preguntas de seguridad para restablecer tu contraseña en un futuro.";
                try
                {
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //Consulta
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("select PREGUNTA FROM TBL_PREGUNTA WHERE ID_ESTADO = 1");

                        MySqlDataReader leer = comando.ExecuteReader();

                        COBPREG.Items.Add("--Seleccione--");
                        COBPREG.SelectedIndex = 0;
                        //Validación de la data obtenida
                        while (leer.Read())
                        {
                            COBPREG.Items.Add(leer["PREGUNTA"].ToString());
                        }
                        comando.Connection.Close();
                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }

            }


        }

        private void COBPREG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if (TXT_Respuesta.Text != "" & COBPREG.SelectedItem != "0")
            {
                errorProvider1.SetError(TXT_Respuesta, "");
                errorProvider1.SetError(COBPREG, "");
                string pregunta = COBPREG.SelectedItem.ToString();
                string respuesta = TXT_Respuesta.Text;

                if (clasecompartida.estado == 3)
                {
                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("select ID_PREGUNTA FROM TBL_PREGUNTA WHERE PREGUNTA = '" + pregunta + "'");

                            MySqlDataReader leer = comando.ExecuteReader();

                            if (leer.Read())
                            {
                                int resp = (int)leer["ID_PREGUNTA"];
                                comando.Connection.Close();

                                comando.Connection = BaseDatosHCL.ObtenerConexion();
                                comando.CommandText = ("SELECT * FROM TBL_PREGUNTAUSUARIO WHERE ID_USUARIO = '" +
                                    clasecompartida.iduser + "' AND ID_PREGUNTA = '" + resp + "'");

                                MySqlDataReader leer0 = comando.ExecuteReader();

                                if (leer0.Read())
                                {
                                    comando.Connection.Close();

                                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                                    comando.CommandText = ("UPDATE TBL_PREGUNTAUSUARIO SET RESPUESTA = '" + respuesta + "' " +
                                        "WHERE ID_PREGUNTA = '" + resp + "' AND ID_USUARIO = '" + clasecompartida.iduser + "'");

                                    comando.ExecuteNonQuery();

                                    comando.Connection.Close();
                                }
                                else
                                {
                                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                                    comando.CommandText = ("INSERT INTO TBL_PREGUNTAUSUARIO(ID_PREGUNTA, ID_USUARIO, RESPUESTA) VALUES ('" +
                                        resp + "', '" + clasecompartida.iduser + "', '" + respuesta + "')");

                                    comando.ExecuteNonQuery();
                                    comando.Connection.Close();
                                }

                                comando.Connection.Close();
                            }

                            comando.Connection.Close();

                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("SELECT COUNT(*) FROM TBL_PREGUNTAUSUARIO WHERE ID_USUARIO = '" +
                                clasecompartida.iduser + "'");

                            MySqlDataReader leer1 = comando.ExecuteReader();

                            if (leer1.Read())
                            {
                                long cant = Convert.ToInt64(leer1["COUNT(*)"]);
                                if (cant == 2 || cant > 2)
                                {
                                    MessageBox.Show("Gracias por responder");
                                    comando.Connection.Close();

                                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                                    comando.CommandText = ("update TBL_USUARIO SET ID_ESTADO = 1 WHERE ID_USUARIO = '" +
                                        clasecompartida.iduser + "'");

                                    comando.ExecuteNonQuery();
                                    comando.Connection.Close();

                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Favor contesta otra pregunta");
                                    TXT_Respuesta.Text = "";
                                }

                            }
                            comando.Connection.Close();
                        }
                    }
                    catch (Exception a)
                    {

                        MessageBox.Show(a.Message + a.StackTrace);
                    }
                }
                else if (clasecompartida.estado == 1)
                {
                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("select ID_PREGUNTA FROM TBL_PREGUNTA WHERE PREGUNTA = '" + pregunta + "'");

                            MySqlDataReader leer = comando.ExecuteReader();

                            if (leer.Read())
                            {
                                int resp = (int)leer["ID_PREGUNTA"];
                                comando.Connection.Close();

                                comando.Connection = BaseDatosHCL.ObtenerConexion();
                                comando.CommandText = ("SELECT * FROM TBL_PREGUNTAUSUARIO WHERE ID_USUARIO = '" +
                                    clasecompartida.iduser + "' AND ID_PREGUNTA = '" + resp + "'");

                                MySqlDataReader leer0 = comando.ExecuteReader();

                                if (leer0.Read())
                                {
                                    comando.Connection.Close();

                                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                                    comando.CommandText = ("UPDATE TBL_PREGUNTAUSUARIO SET RESPUESTA = '" + respuesta + "' " +
                                        "WHERE ID_PREGUNTA = '" + resp + "' AND ID_USUARIO = '" + clasecompartida.iduser + "'");

                                    comando.ExecuteNonQuery();

                                    comando.Connection.Close();
                                }
                                else
                                {
                                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                                    comando.CommandText = ("INSERT INTO TBL_PREGUNTAUSUARIO(ID_PREGUNTA, ID_USUARIO, RESPUESTA) VALUES ('" +
                                        resp + "', '" + clasecompartida.iduser + "', '" + respuesta + "')");

                                    comando.ExecuteNonQuery();
                                    comando.Connection.Close();
                                }

                                comando.Connection.Close();
                            }

                            comando.Connection.Close();

                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("SELECT COUNT(*) FROM TBL_PREGUNTAUSUARIO WHERE ID_USUARIO = '" +
                                clasecompartida.iduser + "'");

                            MySqlDataReader leer1 = comando.ExecuteReader();

                            if (leer1.Read())
                            {
                                long cant = Convert.ToInt64(leer1["COUNT(*)"]);
                                if (cant == 2 || cant > 2)
                                {
                                    MessageBox.Show("Gracias por responder");
                                    comando.Connection.Close();

                                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                                    comando.CommandText = ("update TBL_USUARIO SET ID_ESTADO = 1 WHERE ID_USUARIO = '" +
                                        clasecompartida.iduser + "'");

                                    comando.ExecuteNonQuery();
                                    comando.Connection.Close();

                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Favor contesta otra pregunta");
                                    TXT_Respuesta.Text = "";
                                }

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
                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("select TBL_PREGUNTA.PREGUNTA, TBL_PREGUNTAUSUARIO.RESPUESTA, TBL_USUARIO.NOMBRE_USUARIO FROM TBL_PREGUNTA\r\nINNER JOIN TBL_PREGUNTAUSUARIO ON TBL_PREGUNTA.ID_PREGUNTA = TBL_PREGUNTAUSUARIO.ID_PREGUNTA\r\nINNER JOIN TBL_USUARIO ON TBL_PREGUNTAUSUARIO.ID_USUARIO = TBL_USUARIO.ID_USUARIO\r\nWHERE TBL_USUARIO.USUARIO = '" + clasecompartida.user + "' AND TBL_PREGUNTA.PREGUNTA = '" + pregunta + "'");

                            MySqlDataReader leer = comando.ExecuteReader();

                            if (leer.Read())
                            {
                                string resp = (string)leer["RESPUESTA"];

                                if (resp == respuesta)
                                {
                                    comando.Connection.Close();
                                    Form formulario = new Formularios.RestaContra();
                                    formulario.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Respuesta Incorrecta.");
                                }

                            }

                            comando.Connection.Close();
                        }
                    }
                    catch (Exception a)
                    {

                        MessageBox.Show(a.Message + a.StackTrace);
                    }
                }


            }
            else if (COBPREG.SelectedIndex.Equals(0) & TXT_Respuesta.Text == "")
            {
                errorProvider1.SetError(COBPREG, "Elija una pregunta");
                errorProvider1.SetError(TXT_Respuesta, "Ingrese su respuesta");
            }
            else
            {
                errorProvider1.SetError(COBPREG, "");
                errorProvider1.SetError(TXT_Respuesta, "Ingrese su respuesta");
            }

        }

        private void TXT_Respuesta_TextChanged(object sender, EventArgs e)
        {
            TXT_Respuesta.CharacterCasing = CharacterCasing.Upper; //Bloquea minusculas
            errorProvider1.SetError(TXT_Respuesta, "");
        }
    }
}
