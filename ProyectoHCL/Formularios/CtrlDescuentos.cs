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
    public partial class CtrlDescuentos : Form
    {
        AdmonDescuento admonDesc = new AdmonDescuento();
        Descuentos descuento = new Descuentos();
        DataSet ds = new DataSet();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;

        public CtrlDescuentos()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();
        }

        private void CargarDG()
        {
            descuento.Inicio1 = pagInicio;
            descuento.Final1 = pagFinal;
            ds = descuento.PaginacionDescuento();
            dgvDesc.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtDesc.Text = cantidad.ToString();

            cmbDesc.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbDesc.Items.Add(x.ToString());

            cmbDesc.SelectedIndex = indice;
        }

        private void CtrlDescuentos_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvDesc.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvDesc.Columns.Add(btnDelete);
        }

        public void BuscarDescuento(string buscarD)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarDescuento", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreD", MySqlDbType.VarChar, 200).Value = buscarD;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDesc.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //RegistrarServicio registrarServ = new RegistrarServicio();
            //registrarServ.ShowDialog();
            CargarDG();
        }

        private void dgvDesc_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvDesc.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvDesc.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvDesc.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvDesc.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvDesc.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvDesc.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvDesc.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvDesc.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        private void cmbDesc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbDesc.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIndice = cmbMostrar.SelectedIndex;
            switch (cmbIndice)
            {
                case 0:
                    numFilas = 5;
                    break;
                case 1:
                    numFilas = 10;
                    break;
                case 2:
                    numFilas = 20;
                    break;
                case 3:
                    numFilas = 30;
                    break;
                case 4:
                    numFilas = 40;
                    break;
            }
            pagFinal = numFilas;
            CargarDG();
        }

        private void dgvDesc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDesc.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = admonDesc.EliminarDescuento(dgvDesc.CurrentRow.Cells["ID"].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el registro?",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (elimino)
                    {
                        MessageBox.Show("Descuento eliminado");
                        CargarDG();
                    }
                    else
                    {
                        MessageBox.Show("Descuento no eliminado");
                    }

                }
                else /*if (dialogResult == DialogResult.No)*/
                {

                }
            }

            if (this.dgvDesc.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarDescuento editarDesc = new EditarDescuento();

                editarDesc.idDesc = dgvDesc.CurrentRow.Cells["ID"].Value.ToString();
                editarDesc.txtDesc.Text = dgvDesc.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                editarDesc.txtPorcentaje.Text = dgvDesc.CurrentRow.Cells["PORCENTAJE"].Value.ToString();
                editarDesc.ShowDialog();
                CargarDG();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarDescuento(txtBuscar.Text);
            }
            else
            {
                CargarDG();
            }
        }
    }
}
