using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHCL
{
    public partial class MsgB : Form
    {
        public MsgB()
        {
            InitializeComponent();
        }

        public MsgB(string pTipo, string pMensaje)
        {
            InitializeComponent();
            lblMsg.Text = pMensaje;

            switch (pTipo)
            {
                case "pregunta":
                    lblTitulo.Text = "Pregunta";
                    lblTitulo.ForeColor = Color.FromArgb(33, 150, 243);
                    panel1.BackColor = Color.FromArgb(33, 150, 243);
                    pbPregunta.Visible = true;
                    btnOk.Visible = true;
                    btnCancelar.Visible = true;
                    break;
                case "informacion":
                    lblTitulo.Text = "Información";
                    lblTitulo.ForeColor = Color.FromArgb(33, 150, 243);
                    panel1.BackColor = Color.FromArgb(33, 150, 243);
                    pbInfo.Visible = true;
                    btnAOk.Visible = true;
                    break;
                case "advertencia":
                    lblTitulo.Text = "Advertencia";
                    lblTitulo.ForeColor = Color.FromArgb(255, 193, 7);
                    panel1.BackColor = Color.FromArgb(255, 193, 7);
                    pbAdvertencia.Visible = true;
                    btnAOk.Visible = true;
                    break;
                case "error":
                    lblTitulo.Text = "Error";
                    lblTitulo.ForeColor = Color.FromArgb(244, 67, 54);
                    panel1.BackColor = Color.FromArgb(244, 67, 54);
                    pbError.Visible = true;
                    btnAOk.Visible = true;
                    break;
                default:
                    lblTitulo.Text = "Error al seleccionar";
                    break;
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        int posY = 0;
        int posX = 0;

        private void panel3_MouseMove(object sender, MouseEventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
