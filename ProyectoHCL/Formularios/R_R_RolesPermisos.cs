using ProyectoHCL.clases;
using ProyectoHCL.RolesPermisos;
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
    public partial class R_R_RolesPermisos : Form
    {
        public R_R_RolesPermisos()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();
            GuardarPermisoRol();
        }

        
        RolUsuario rolUs = new RolUsuario();
        PermisoRol permiso = new PermisoRol();
        CDatos cDatos = new CDatos();
        Objetos obj = new Objetos();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;
        int IdRol;

        private void CargarDG()
        {
            obj.Inicio1 = pagInicio;
            obj.Final1 = pagFinal;
            ds = obj.PaginacionObjetos2();
            dgvRolPermiso.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPagR.Text = cantidad.ToString();

            cmbPagR.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPagR.Items.Add(x.ToString());

            cmbPagR.SelectedIndex = indice;

            HabilitarBotones();
        }

        public void limpiarCampos()
        {
            txtRol.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiarCampos();
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

        private void HabilitarBotones()
        {
            if (pagInicio == 1)
            {
                btnAnterior.Enabled = false;
            }
            else
            {
                btnAnterior.Enabled = true;
            }

            if (indice == (Convert.ToInt32(txtPagR.Text) - 1))
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }
        }

        private void btnAntR_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagR.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSigR_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagR.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void cmbPagR_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagR.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void RolesPermisos_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn chkVer = new DataGridViewCheckBoxColumn();
            chkVer.Name = "VER";
            chkVer.Tag = 1;
            dgvRolPermiso.Columns.Add(chkVer);

            DataGridViewCheckBoxColumn chkCrear = new DataGridViewCheckBoxColumn();
            chkCrear.Name = "CREAR";
            chkCrear.Tag = 2;
            dgvRolPermiso.Columns.Add(chkCrear);

            DataGridViewCheckBoxColumn chkEditar = new DataGridViewCheckBoxColumn();
            chkEditar.Name = "EDITAR";
            chkEditar.Tag = 3;
            dgvRolPermiso.Columns.Add(chkEditar);

            DataGridViewCheckBoxColumn chkEliminar = new DataGridViewCheckBoxColumn();
            chkEliminar.Name = "ELIMINAR";
            chkEliminar.Tag = 4;
            dgvRolPermiso.Columns.Add(chkEliminar);
        }

        private void GuardarRolUs()
        {
            rolUs.Rol = txtRol.Text.ToUpper().Trim();
            IdRol = cDatos.GuardarRol(rolUs);
        }

        private void GuardarPermisoRol()
        {            
            foreach (DataGridViewRow row in dgvRolPermiso.Rows)
            {
                permiso.IdRol = IdRol;
                
                if (Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    
                    
                    permiso.IdObjeto = Convert.ToInt32(dgvRolPermiso.CurrentRow.Cells["PANTALLA"].Value.ToString());
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns[2].Tag);

                }

            }
        }
    }
}
