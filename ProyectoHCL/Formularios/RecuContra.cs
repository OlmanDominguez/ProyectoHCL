using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                        this.Close();
                        Form formulario = new Formularios.PreguntasRecuContra();
                        formulario.ShowDialog();

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
                MessageBox.Show(a.Message+a.StackTrace);
            }
            


        }
    }
}
