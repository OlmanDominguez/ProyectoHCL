using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHCL.Formularios
{
    public partial class GestionUsuario : Form
    {
        public GestionUsuario()
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(125, Color.DeepSkyBlue);
            panel2.BackColor = Color.FromArgb(120, Color.DimGray);
            panel3.BackColor = Color.FromArgb(120, Color.Black);
            txtFechaC.Text = DateTime.Now.ToShortDateString();
            txtFechaV.Text = DateTime.Now.AddDays(360).ToShortDateString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private static bool CorreoValido(String correo)
        {
            String expresion;
            expresion = "\\w+([-+.’]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, expresion))
            {
                if (Regex.Replace(correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Usuarios usuario = new Usuarios();
            usuario.USUARIO1 = txtUsuario.Text;
            usuario.NOMBRE1 = txtNombre.Text;
            usuario.CONTRASEÑA1 = txtContraseña.Text;
            //usuario.ROL_USUARIO1 = cmbRol.Text;
            usuario.EMAIL1 = txtCorreo.Text;
            usuario.FECHA_CREACION1 = Convert.ToDateTime(txtFechaC.Text);
            usuario.FECHA_VENCIMIENTO1 = Convert.ToDateTime(txtFechaV.Text);
            //usuario.ESTADO_USUARIO1 = cmbEstado.Text;


            if (CorreoValido(txtCorreo.Text) == false)
            {
                MessageBox.Show("Dirección de correo no válida", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtContraseña.TextLength < 5)
            {
                MessageBox.Show("La contraseña es muy corta", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    Control control = new Control();
                    string res = control.ctrlRegistro(usuario);

                    if (res.Length > 0)
                    {
                        MessageBox.Show(res, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Usuario creado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                errorT.SetError(txtNombre, "Introduzca un nombre");
                txtNombre.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                errorT.SetError(txtUsuario, "Introduzca un usuario");
                txtUsuario.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtContraseña_Validated(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == "")
            {
                errorT.SetError(txtContraseña, "Introduzca una contraseña");
                txtContraseña.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void cmbRol_Validated(object sender, EventArgs e)
        {
            if (cmbRol.Text.Trim() == "")
            {
                errorT.SetError(cmbRol, "Seleccione un rol");
                cmbRol.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {
                errorT.SetError(txtCorreo, "Introduzca un correo");
                txtCorreo.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void cmbEstado_Validated(object sender, EventArgs e)
        {
            if (cmbEstado.Text.Trim() == "")
            {
                errorT.SetError(cmbEstado, "Seleccione un estado");
                cmbEstado.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }
    }
}
