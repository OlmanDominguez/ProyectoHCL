using MySql.Data.MySqlClient;
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
using System.Runtime.InteropServices;

namespace ProyectoHCL.Formularios
{
    public partial class RegistrarObjeto : Form
    {

        public RegistrarObjeto()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void txtObjeto_Validated(object sender, EventArgs e)
        {
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        public void limpiarCampos()
        {
            txtObjeto.Clear();
            txtDescripcion.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();

            if (VCamposVacios() == false)
            {
                MessageBox.Show("Por favor llene todos los campos", "Aviso",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (modelo.existeObjeto(txtObjeto.Text))
                    {
                        MessageBox.Show("El objeto ya existe", "Aviso",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MySqlConnection conn;
                        MySqlCommand cmd;
                        conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                        conn.Open();

                        cmd = new MySqlCommand("insertarObjeto", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombreObj", txtObjeto.Text);
                        cmd.Parameters.AddWithValue("@descObj", txtDescripcion.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Objeto creado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtObjeto_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VCamposVacios()
        {
            bool ok = true;

            if (txtObjeto.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtObjeto, "Introduzca el nombre del objeto");
            }
            else
            {
                errorT.Clear();
            }

            if (txtDescripcion.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtDescripcion, "Introduzca una descripción del objeto");
            }
            else
            {
                errorT.Clear();
            }

            return ok;

        }

        private void label11_Click(object sender, EventArgs e)
        {

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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
