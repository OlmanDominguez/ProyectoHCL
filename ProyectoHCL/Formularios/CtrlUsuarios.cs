using Microsoft.VisualBasic;
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
    public partial class CtrlUsuarios : Form
    {
        public CtrlUsuarios()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.DeepSkyBlue);
            panel2.BackColor = Color.FromArgb(120, Color.DimGray);
            BuscarUsuarios("");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        AdmonUsuarios admonUsuario = new AdmonUsuarios();
        Usuarios usuario = new Usuarios();

        private void CtrlUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvUsuarios.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvUsuarios.Columns.Add(btnDelete);
        }

        public void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = admonUsuario.MostrarUsuarios();
        }

        public void BuscarUsuarios(string buscarU)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarUsuarios", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreU", MySqlDbType.VarChar, 50).Value = buscarU;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarUsuarios(txtBuscar.Text);
            }
            else
            {
                MostrarUsuarios();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RegistrarUsuario reglUsuarios = new RegistrarUsuario();
            this.Visible = false;
            reglUsuarios.ShowDialog();
            this.Visible = true;
        }

        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex >= 0 && this.dgvUsuarios.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvUsuarios.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvUsuarios.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvUsuarios.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvUsuarios.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvUsuarios.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }


        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgvUsuarios.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = admonUsuario.EliminarUsuario(dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el usuario?",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (elimino)
                    {
                        MessageBox.Show("Usuario eliminado");
                        MostrarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no eliminado");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            if (this.dgvUsuarios.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarUsuario editarUsuarios = new EditarUsuario();
                editarUsuarios.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["USUARIO"].Value.ToString();
                editarUsuarios.txtNombre.Text = dgvUsuarios.CurrentRow.Cells["NOMBRE"].Value.ToString();
                editarUsuarios.txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["EMAIL"].Value.ToString();
                editarUsuarios.cmbEstado.Text = dgvUsuarios.CurrentRow.Cells["ESTADO"].Value.ToString();
                editarUsuarios.cmbRol.Text = dgvUsuarios.CurrentRow.Cells["ROL"].Value.ToString();
                editarUsuarios.dtpCreacion.Text = dgvUsuarios.CurrentRow.Cells["CREACION"].Value.ToString();
                editarUsuarios.dtpVencimiento.Text = dgvUsuarios.CurrentRow.Cells["VENCIMIENTO"].Value.ToString();
                this.Visible = false;
                editarUsuarios.ShowDialog();
                this.Visible = true;
                MostrarUsuarios();

            }
        }
    }
}
