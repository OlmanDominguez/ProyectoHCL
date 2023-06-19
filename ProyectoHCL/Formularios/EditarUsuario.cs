using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHCL.Formularios
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.DeepSkyBlue);
            panel2.BackColor = Color.FromArgb(120, Color.DimGray);
            panel3.BackColor = Color.FromArgb(120, Color.Black);
        }

        AdmonUsuarios admonUsuario = new AdmonUsuarios();
        Usuarios usuario = new Usuarios();
        CtrlUsuarios ctrlUsuario = new CtrlUsuarios();
        RegistrarUsuario regUsuario = new RegistrarUsuario();
        private void EditarUsuario_Load(object sender, EventArgs e)
        {

        }

        public void limpiarCampos()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtCorreo.Clear();
            dtpCreacion.Text = string.Empty;
            dtpVencimiento.Text = string.Empty;
            cmbRol.Text = string.Empty;
            cmbEstado.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuario.USUARIO1 = txtUsuario.Text;
            usuario.NOMBRE1 = txtNombre.Text;
            //usuario.ROL_USUARIO1 = cmbRol.Text;
            usuario.EMAIL1 = txtCorreo.Text;
            usuario.FECHA_CREACION1 = Convert.ToDateTime(dtpCreacion.Text);
            usuario.FECHA_VENCIMIENTO1 = Convert.ToDateTime(dtpVencimiento.Text);
            //usuario.ESTADO_USUARIO1 = cmbEstado.Text;


            bool edito = admonUsuario.EditarUsuario(usuario);

            if (edito)
            {
                MessageBox.Show("Usuario modificado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario no modificado");
            }
        }
    }
}
