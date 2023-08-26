using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using ProyectoHCL.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoHCL.Formularios.CtrlClientes;
using System.Windows.Media.TextFormatting;
using static ProyectoHCL.RecuContra;
using DocumentFormat.OpenXml.Bibliography;

namespace ProyectoHCL.Formularios
{
    public partial class PerfilUsuario : Form
    {
        public PerfilUsuario()
        {
            InitializeComponent();
        }

        private void PerfilUsuario_Load(object sender, EventArgs e)
        {
            //Clase que trae la información del usuario que ingresa al login
            txtusuario.Text = clasecompartida.user;
            txtnombre.Text = clases.CDatos.nombre;
            txtcorreo.Text = clases.CDatos.correo;
            lblnombre.Text = clases.CDatos.nombre;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select * from TBL_USUARIO WHERE USUARIO");

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }
        }


        //Botón Minimizar
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        //Enlace que redirige para cambiar la contraseña
        private void linkLabelContraseña_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form PerfilUsuario = new RestaContra();
            PerfilUsuario.Show();
        }

        //Enlace que redirige para cambiar preguntas de seguridad
        private void linkLabelPreguntas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form PerfilUsuario = new PreguntasRecuContra();
            PerfilUsuario.Show();
        }

        //Botón Cerrar
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


