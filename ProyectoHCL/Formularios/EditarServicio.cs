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
    public partial class EditarServicio : Form
    {
        public EditarServicio()
        {
            InitializeComponent();
        }

        public string idS = null;

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

            if (txtDesc.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtDesc, "Introduzca una descripción");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Control control = new Control();

            if (VCamposVacios() == false)
            {
                MessageBox.Show("Por favor llene todos los campos", "Aviso",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    control.editarServ(idS, txtDesc.Text, txtPrecio.Text);

                    MessageBox.Show("Servicio modificado");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
