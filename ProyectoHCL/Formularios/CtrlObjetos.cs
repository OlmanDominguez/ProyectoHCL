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
    public partial class CtrlObjetos : Form
    {
        public CtrlObjetos()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.DeepSkyBlue);
            BuscarObjetos("");
        }

        AdmonObjetos admonObjeto = new AdmonObjetos();

        private void CtrlObjetos_Load(object sender, EventArgs e)
        {
            MostrarObjetos();

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvObjetos.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvObjetos.Columns.Add(btnDelete);
        }

        public void MostrarObjetos()
        {
            dgvObjetos.DataSource = admonObjeto.MostrarObjetos();
        }

        public void BuscarObjetos(string buscarOb)
        {
            try
            {

                MySqlConnection conn;
                MySqlCommand cmd;

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarObjetos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreO", MySqlDbType.VarChar, 50).Value = buscarOb;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvObjetos.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            RegistrarObjeto regObjeto = new RegistrarObjeto();
            regObjeto.ShowDialog();
            MostrarObjetos();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarObjetos(txtBuscar.Text);
            }
            else
            {
                MostrarObjetos();
            }
        }

        private void dgvObjetos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvObjetos.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarObjeto editarObjeto = new EditarObjeto();
                editarObjeto.idObj = dgvObjetos.CurrentRow.Cells["ID"].Value.ToString();
                editarObjeto.txtObjeto.Text = dgvObjetos.CurrentRow.Cells["NOMBRE"].Value.ToString();
                editarObjeto.txtDescripcion.Text = dgvObjetos.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                editarObjeto.cmbEstado.Text = dgvObjetos.CurrentRow.Cells["ESTADO"].Value.ToString();
                this.Visible = false;
                editarObjeto.ShowDialog();
                this.Visible = true;
                MostrarObjetos();
            }

            if (this.dgvObjetos.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = admonObjeto.EliminarObjeto(dgvObjetos.CurrentRow.Cells["ID"].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el objeto?",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (elimino)
                    {
                        MessageBox.Show("Objeto eliminado");
                        MostrarObjetos();
                    }
                    else
                    {
                        MessageBox.Show("Objeto no eliminado");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void dgvObjetos_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvObjetos.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvObjetos.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvObjetos.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvObjetos.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvObjetos.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvObjetos.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvObjetos.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvObjetos.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }
    }
}
