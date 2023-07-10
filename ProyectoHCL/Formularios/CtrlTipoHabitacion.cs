using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CtrlTipoHabitacion : Form
    {
        AdmonTipHab admonTipHab = new AdmonTipHab();
        TipoHabitacion tipHab = new TipoHabitacion();
        DataSet ds = new DataSet();
        int pagInicio = 1, indice = 0, numFilas = 3, pagFinal, cmbIndice = 0;

        public CtrlTipoHabitacion()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();
        }

        private void CargarDG()
        {
            tipHab.Inicio1 = pagInicio;
            tipHab.Final1 = pagFinal;
            ds = tipHab.PaginacionTipoHab();
            dgvTH.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPagTH.Text = cantidad.ToString();

            cboxPag.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cboxPag.Items.Add(x.ToString());

            cboxPag.SelectedIndex = indice;
        }

        private void CtrlTipoHabitacion_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvTH.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvTH.Columns.Add(btnDelete);
        }

        public void BuscarTipHab(string buscarTH)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarTipHab", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreTH", MySqlDbType.VarChar, 50).Value = buscarTH;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTH.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RegistrarTipHab registrarTipHab = new RegistrarTipHab(); 
            registrarTipHab.ShowDialog();
            CargarDG();
        }

        private void dgvTH_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvTH.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvTH.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvTH.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvTH.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvTH.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvTH.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvTH.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvTH.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        private void cboxPag_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cboxPag.Text);
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
                    numFilas = 2;
                    break;
                case 1:
                    numFilas = 3;
                    break;
                case 2:
                    numFilas = 4;
                    break;
                case 3:
                    numFilas = 5;
                    break;
                case 4:
                    numFilas = 6;
                    break;
            }
            pagFinal = numFilas;
            CargarDG();
        }

        private void dgvTH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvTH.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = admonTipHab.EliminarTipHab(dgvTH.CurrentRow.Cells["ID"].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el registro?",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (elimino)
                    {
                        MessageBox.Show("Tipo de habitación eliminado");
                        CargarDG();
                    }
                    else
                    {
                        MessageBox.Show("Tipo de habitación no eliminado");
                    }

                }
                else /*if (dialogResult == DialogResult.No)*/
                {

                }
            }

            if (this.dgvTH.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarTipHab editarTipHab = new EditarTipHab();

                editarTipHab.idTH = dgvTH.CurrentRow.Cells["ID"].Value.ToString();
                editarTipHab.txtTipo.Text = dgvTH.CurrentRow.Cells["TIPO"].Value.ToString(); 
                editarTipHab.txtCapacidad.Text = dgvTH.CurrentRow.Cells["CAPACIDAD"].Value.ToString();
                editarTipHab.txtPrecio.Text = dgvTH.CurrentRow.Cells["PRECIO"].Value.ToString();
                editarTipHab.ShowDialog();  
                CargarDG();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "") 
            {
                BuscarTipHab(txtBuscar.Text); 
            }
            else
            {
                CargarDG();  
            }
        }
    }
}
