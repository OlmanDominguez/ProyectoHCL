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
    public partial class EditarObjeto : Form
    {
        public EditarObjeto()
        {
            InitializeComponent();
        }

        public string idObj = null;
        CtrlObjetos ctrlUsuario = new CtrlObjetos();
        Control control = new Control();
        AdmonObjetos admonObjeto = new AdmonObjetos();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                control.editarObj(idObj, txtObjeto.Text, txtDescripcion.Text, cmbEstado.Text);

                MessageBox.Show("Objeto modificado");
                this.Close();
                admonObjeto.MostrarObjetos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            //objeto.NOMBRE_OBJETO1 = txtObjeto.Text;
            //objeto.DESCRIPCION1 = txtDescripcion.Text;
            //objeto.ESTADO_OBJETO1 = cmbEstado.Text;



            //bool edito = admonObjeto.EditarObjeto(objeto);

            //if (edito)
            //{
            //    MessageBox.Show("Objeto modificado");
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Objeto no modificado");
            //}
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
