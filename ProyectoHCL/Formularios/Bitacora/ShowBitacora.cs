using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoHCL.Formularios.CtrlBitacora;

namespace ProyectoHCL.Formularios.Bitacora
{
    public partial class ShowBitacora : Form
    {
        public ShowBitacora()
        {
            InitializeComponent();
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

        private void ShowBitacora_Load(object sender, EventArgs e)
        {
            lb_idBitacora.Text = preg.id;
            lb_user.Text = preg.user;
            lb_modulo.Text = preg.submenu;
            lb_pantalla.Text = preg.pantalla;
            lb_accion.Text = preg.accion;
            lb_fecha.Text = preg.fecha;
            lb_descripcion.Text = preg.descripcion;
        }
    }
}
