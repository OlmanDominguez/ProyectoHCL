using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using ProyectoHCL.Properties;
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
    public partial class CtrlClientes : Form
    {
        public CtrlClientes()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.DeepSkyBlue);
            BuscarClientes("");
        }

        AdmonClientes admonClientes = new AdmonClientes();

        private void CtrlClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();

            DataGridViewImageColumn btnShow = new DataGridViewImageColumn();
            btnShow.Name = "VER";
            btnShow.Image = Resources.ver;
            btnShow.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvClientes.Columns.Add(btnShow);

            DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
            btnUpdate.Name = "EDITAR";
            btnUpdate.Image = Resources.editar;
            btnUpdate.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvClientes.Columns.Add(btnUpdate);

            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
            btnDelete.Name = "Eliminar";
            btnDelete.Image = Resources.eliminar;
            btnDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvClientes.Columns.Add(btnDelete);
        }

        public void MostrarClientes()
        {
            dgvClientes.DataSource = admonClientes.MostrarClientes();
        }

        public void BuscarClientes(string buscarCl)
        {
            try
            {

                MySqlConnection conn;
                MySqlCommand cmd;

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarClientes", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreC", MySqlDbType.VarChar, 50).Value = buscarCl;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvClientes.DataSource = dt;

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
            MostrarClientes();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarClientes(txtBuscar.Text);
            }
            else
            {
                MostrarClientes();
            }
        }

        private void dgvObjetos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "VER")
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("Select * From TBL_CLIENTE WHERE CODIGO = " + codigo + ";");

                    MySqlDataReader leer = comando.ExecuteReader();
                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un error");
                }
            }

            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarObjeto editarObjeto = new EditarObjeto();
                editarObjeto.idObj = dgvClientes.CurrentRow.Cells["ID"].Value.ToString();
                editarObjeto.txtObjeto.Text = dgvClientes.CurrentRow.Cells["NOMBRE"].Value.ToString();
                editarObjeto.txtDescripcion.Text = dgvClientes.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                editarObjeto.cmbEstado.Text = dgvClientes.CurrentRow.Cells["ESTADO"].Value.ToString();
                this.Visible = false;
                editarObjeto.ShowDialog();
                this.Visible = true;
                MostrarClientes();
            }

            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = admonClientes.EliminarObjeto(dgvClientes.CurrentRow.Cells["ID"].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el objeto?",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (elimino)
                    {
                        MessageBox.Show("Objeto eliminado");
                        MostrarClientes();
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

    }
}
