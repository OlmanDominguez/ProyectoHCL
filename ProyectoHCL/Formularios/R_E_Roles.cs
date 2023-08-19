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
    public partial class R_E_Roles : Form
    {
        public R_E_Roles()
        {
            InitializeComponent();
        }

        public string idRol = null;

        MsgB msgB = new MsgB();

        public void limpiarCampos()
        {
            txtRol.Clear();
            txtNumero.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError()
        {
            error1.SetError(txtRol, "");
            error1.SetError(txtNumero, "");
            error1.SetError(cmbEstado, "");
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtEmail2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ID_Rol_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
            limpiarCampos();
            limpiarError();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiarCampos();
            limpiarError();
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

        private void cmbEstado_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.cmbVacio(cmbEstado))
            {
                error1.SetError(cmbEstado, "Seleccione un estado");
            }
            else
            {
                error1.Clear();
            }
        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRol_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtRol))
            {
                error1.SetError(txtRol, "Introduzca un nombre");
            }
            else
            {
                error1.Clear();
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtNumero))
            {
                error1.SetError(txtNumero, "Introduzca una descripción");
            }
            else
            {
                error1.Clear();
            }
        }
    }
}
