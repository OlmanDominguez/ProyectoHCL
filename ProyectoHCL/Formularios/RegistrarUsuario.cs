using MySql.Data.MySqlClient;
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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
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

        public void limpiarCampos()
        {
            txtNombre.Clear();
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtCorreo.Clear();
            cmbRol.Text = string.Empty;
            cmbEstado.Text = string.Empty;
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
            Modelo modelo = new Modelo();

            VCamposVacios();

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
                    if (modelo.existeUsuario(txtUsuario.Text))
                    {
                        MessageBox.Show("El usuario ya existe", "Aviso",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MySqlConnection conn;
                        MySqlCommand cmd;
                        conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                        conn.Open();

                        cmd = new MySqlCommand("InsertarUsuarios", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);
                        cmd.Parameters.AddWithValue("@rol", cmbRol.Text);
                        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtContraseña.Text);
                        cmd.Parameters.AddWithValue("@primerIngreso", Convert.ToDateTime(txtFechaC.Text));
                        cmd.Parameters.AddWithValue("@vencimiento", Convert.ToDateTime(txtFechaV.Text));
                        cmd.Parameters.AddWithValue("@email", txtCorreo.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario creado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                        conn.Close();
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

            if (txtContraseña.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtContraseña, "Introduzca una contraseña");
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

            return ok;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten espacios", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
