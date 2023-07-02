using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHCL.Formularios
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        public string idUs = null;
        AdmonUsuarios admonUsuario = new AdmonUsuarios();
        CtrlUsuarios ctrlUsuario = new CtrlUsuarios();
        Control control = new Control();

        private void EditarUsuario_Load(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            VCamposVacios();

            if (CorreoValido(txtCorreo.Text) == false)
            {
                MessageBox.Show("Dirección de correo no válida", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    control.editarUs(idUs, cmbEstado.Text, cmbRol.Text, txtUsuario.Text, txtNombre.Text,
                        dtpVencimiento.Text, txtCorreo.Text);

                    MessageBox.Show("Usuario modificado");
                    this.Close();
                    admonUsuario.MostrarUsuarios();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool VCamposVacios()
        {
            bool ok = true;

            if (txtNombre.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtNombre, "Introduzca un nombre");
            }
            else
            {
                errorT.Clear();
            }

            if (txtUsuario.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtUsuario, "Introduzca un usuario");
            }
            else
            {
                errorT.Clear();
            }

            if (cmbRol.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(cmbRol, "Seleccione un rol");
            }
            else
            {
                errorT.Clear();
            }

            if (txtCorreo.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtCorreo, "Introduzca un correo");
            }
            else
            {
                errorT.Clear();
            }

            if (cmbEstado.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(cmbEstado, "Seleccione un estado");
            }
            else
            {
                errorT.Clear();
            }

            //if (dtpVencimiento.Text.Trim() == "")  *VALIDAR FECHA
            //{
            //    ok = false;
            //    errorT.SetError(dtpVencimiento, "Seleccione una fecha");
            //}
            //else
            //{
            //    errorT.Clear();
            //}
            return ok;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int posY = 0;
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
