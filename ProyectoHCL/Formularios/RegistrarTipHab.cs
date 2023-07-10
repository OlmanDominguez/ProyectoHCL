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

namespace ProyectoHCL.Formularios
{
    public partial class RegistrarTipHab : Form
    {
        public RegistrarTipHab()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private bool VCamposVacios()
        {
            bool ok = true;

            if (txtTipo.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtTipo, "Introduzca un tipo de habitación");
            }
            else
            {
                errorT.Clear();
            }

            if (txtCapacidad.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtCapacidad, "Introduzca una capacidad");
            }
            else
            {
                errorT.Clear();
            }

            if (txtPrecio.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtPrecio, "Introduzca un precio");
            }
            else
            {
                errorT.Clear();
            }

            return ok;

        }

        public void limpiarCampos()
        {
            txtTipo.Clear();
            txtCapacidad.Clear();
            txtPrecio.Clear();
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
                    if (modelo.existeTipHab(txtTipo.Text))
                    {
                        MessageBox.Show("El tipo de habitación ya existe", "Aviso",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MySqlConnection conn;
                        MySqlCommand cmd;
                        conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                        conn.Open();

                        cmd = new MySqlCommand("insertTipoHabitacion", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                        cmd.Parameters.AddWithValue("@capacidad", txtCapacidad.Text);
                        cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tipo de habitación creado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
