using iTextSharp.text;
using MySql.Data.MySqlClient;
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
using static iText.Kernel.Pdf.Colorspace.PdfDeviceCs;

namespace ProyectoHCL.Formularios
{
    public partial class R_R_RolesPermisos : Form
    {
        public R_R_RolesPermisos()
        {
            InitializeComponent();
            cargarRoles();
        }

        RolUsuario rolUs = new RolUsuario();
        PermisoRol permiso = new PermisoRol();
        CDatos cDatos = new CDatos();
        Objetos obj = new Objetos();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        Modelo modelo = new Modelo();
        int IdRol;

        private void ListarObjetos()
        {
            dgvRolPermiso.DataSource = cDatos.listarObjetos();
        }

        private void cargarRoles()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            cmbRol.DataSource = null;
            cmbRol.Items.Clear();
            string sql = "SELECT ID_ROL, ROL FROM TBL_ROL;";

            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            try
            {
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cmbRol.ValueMember = "ID_ROL";
                cmbRol.DisplayMember = "ROL";
                cmbRol.DataSource = dt;

            }
            catch (MySqlException e)
            {
                MsgB m = new MsgB("Error", "Se produjo un error " + e.Message);
                DialogResult dR = m.ShowDialog();
            }
            finally { conn.Close(); }

        }

        private void CargarDG()
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

        public void limpiarCampos()
        {
            cmbRol.SelectedIndex = -1;

            foreach (DataGridViewRow row in dgvRolPermiso.Rows)
            {
                if (Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    row.Cells["VER"].Value = false;
                }
                if (Convert.ToBoolean(row.Cells["CREAR"].Value))
                {
                    row.Cells["CREAR"].Value = false;
                }
                if (Convert.ToBoolean(row.Cells["EDITAR"].Value))
                {
                    row.Cells["EDITAR"].Value = false;
                }
                if (Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                {
                    row.Cells["ELIMINAR"].Value = false;
                }
            }
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

        private void btnAntR_Click(object sender, EventArgs e)
        {
        }

        private void btnSigR_Click(object sender, EventArgs e)
        {
        }

        private void cmbPagR_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void RolesPermisos_Load(object sender, EventArgs e)
        {
            ListarObjetos();
            cmbRol.SelectedIndex = -1;
            CargarDG();
            //pictureBox1.Image = Image.FromFile(@"C:\Users\jmont\OneDrive\Documentos\HM\reloj-de-arena.gif");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void GuardarPermisoRol()
        {
            panel6.Visible = true;

            foreach (DataGridViewRow row in dgvRolPermiso.Rows)
            {
                permiso.IdRol = cmbRol.Text;
                permiso.IdObjeto = row.Cells["PANTALLA"].Value.ToString();

                if (Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["VER"].Tag);
                    permiso.Permitido = true;
                    cDatos.GuardarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["VER"].Tag);
                    permiso.Permitido = false;
                    cDatos.GuardarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["CREAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["CREAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.GuardarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["CREAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["CREAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.GuardarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["EDITAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["EDITAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.GuardarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["EDITAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["EDITAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.GuardarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["ELIMINAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.GuardarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["ELIMINAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.GuardarPermiso(permiso);
                }
            }

            panel6.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Registrar Permisos")
            {
                if (cmbRol.Text == "")
                {
                    MsgB Mbox = new MsgB("advertencia", "Seleccione un rol");
                    DialogResult DR = Mbox.ShowDialog();
                }
                else
                {
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    GuardarPermisoRol();
                    MsgB Mbox = new MsgB("informacion", "Permisos registrados");
                    DialogResult DR = Mbox.ShowDialog();
                    limpiarCampos();
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                }
            }
            else if (lblTitulo.Text == "Editar Permisos")
            {
                if (cmbRol.Text == "")
                {
                    MsgB Mbox = new MsgB("advertencia", "Seleccione un rol");
                    DialogResult DR = Mbox.ShowDialog();
                }
                else
                {
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    ActualizarPermisoRol();
                    MsgB Mbox = new MsgB("informacion", "Permisos actualizados");
                    DialogResult DR = Mbox.ShowDialog();
                    limpiarCampos();
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                }
            }

        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Editar Permisos";
            btnEditar.Visible = false;
            btnNuevo.Visible = true;
            cargarPermisos();

        }

        private void cargarPermisos()
        {
            MySqlCommand cmd;
            MySqlConnection conn = new MySqlConnection();
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");

            conn.Open();

            string sql = "SELECT PERMITIDO FROM TBL_PERMISO_ROL WHERE ID_ROL = 3";
            cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                foreach (DataGridViewRow rows in dgvRolPermiso.Rows)
                {
                    rows.Cells["VER"].Value = row["PERMITIDO"];
                    rows.Cells["CREAR"].Value = row["PERMITIDO"];
                    rows.Cells["EDITAR"].Value = row["PERMITIDO"];
                    rows.Cells["ELIMINAR"].Value = row["PERMITIDO"];
                }
            }
        }

        private void ActualizarPermisoRol()
        {
            label1.Text = "Actualizando permisos";
            panel6.Visible = true;

            foreach (DataGridViewRow row in dgvRolPermiso.Rows)
            {
                permiso.IdRol = cmbRol.Text;
                permiso.IdObjetoAct = int.Parse(row.Cells["ID"].Value.ToString());

                if (Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["VER"].Tag);
                    permiso.Permitido = true;
                    cDatos.ActualizarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["VER"].Tag);
                    permiso.Permitido = false;
                    cDatos.ActualizarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["CREAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["CREAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.ActualizarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["CREAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["CREAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.ActualizarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["EDITAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["EDITAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.ActualizarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["EDITAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["EDITAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.ActualizarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["ELIMINAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.ActualizarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["ELIMINAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.ActualizarPermiso(permiso);
                }
            }

            panel6.Visible = false;
        }

        private void cmbRol_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Registrar Permisos" && modelo.existePermiso(ExisteRol()) && !String.IsNullOrEmpty(cmbRol.Text))
            {
                MsgB m = new MsgB("error", "El rol seleccionado ya tiene permisos asignados");
                DialogResult dR = m.ShowDialog();
                limpiarCampos();
            }
            else if (lblTitulo.Text == "Editar Permisos" && !modelo.existePermiso(ExisteRol()) && !String.IsNullOrEmpty(cmbRol.Text))
            {
                MsgB m = new MsgB("error", "El rol seleccionado no puede editarse, no tiene permisos asignados");
                DialogResult dR = m.ShowDialog();
                limpiarCampos();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Registrar Permisos";
            btnEditar.Visible = true;
            btnNuevo.Visible = false;
        }

        public int ExisteRol()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = BaseDatosHCL.ObtenerConexion();
            comando.CommandText = ("SELECT ID_ROL FROM TBL_ROL WHERE ROL = '"
                + cmbRol.Text + "';");

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                return (int)leer["ID_ROL"];
            }
            else
            {
                return 0;
            }
        }
    }
}
