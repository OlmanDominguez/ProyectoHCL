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
            lblusuario.Text = clasecompartida.user;
            lblnombre.Text = clases.CDatos.nombre;
            lblcorreo.Text = clases.CDatos.correo;

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = BaseDatosHCL.ObtenerConexion();
            comando.CommandText = ("UPDATE TBL_USUARIO SET USUARIO = '" + txtUsuario.Text + "', NOMBRE_USUARIO = '" + txtNombre.Text + "', EMAIL = '" + txtCorreo.Text + "', PASS = '0' where USUARIO = '" + clasecompartida.user + "'");
            int cant;
            cant = comando.ExecuteNonQuery();

            MySqlDataReader leer = comando.ExecuteReader();


            if (cant > 0)
            {

                lblusuario.Text = txtUsuario.Text;
                lblnombre.Text = txtNombre.Text;
                lblcorreo.Text = txtCorreo.Text;

                MessageBox.Show("Registro Modificado");

            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("Select * From TBL_USUARIO where USUARIO = '"
                        + txtUsuario.Text + "';");
                    int cant;
                    cant = comando.ExecuteNonQuery();

                    MySqlDataReader leer = comando.ExecuteReader();


                    if (cant > 0)
                    {
                        clases.CDatos.usuario = leer["USUARIO"].ToString(); ;
                        clases.CDatos.nombre = leer["NOMBRE_USUARIO"].ToString();
                        clases.CDatos.correo = leer["EMAIL"].ToString();
                        clases.CDatos.contraseña = leer["CONTRASENA"].ToString();


                        comando.Connection.Close();
                    }

                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }

        }

        private void linkLabelContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form PerfilUsuario = new RestaContra();
            PerfilUsuario.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clasecompartida.estado = 1;
            Form PerfilUsuario = new PreguntasRecuContra();
            PerfilUsuario.ShowDialog();

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

            if (ValidarTxt.txtVacio(txtUsuario))
            {
                error1.SetError(txtUsuario, "Introduzca el usuario");
            }
            else
            {
                error1.Clear();
            }

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtNombre))
            {
                error1.SetError(txtNombre, "Introduzca un nombre");
            }
            else
            {
                error1.Clear();
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {

            if (ValidarTxt.txtVacio(txtCorreo))
            {
                error1.SetError(txtCorreo, "Introduzca un correo");
            }
            else
            {
                error1.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txtUsuario.Text = clasecompartida.user;
            txtNombre.Text = clases.CDatos.nombre;
            txtCorreo.Text = clases.CDatos.correo;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


