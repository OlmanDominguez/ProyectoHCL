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
    public partial class CtrlHabitaciones : Form
    {
        AdmonHabitaciones admonHab = new AdmonHabitaciones();
        Habitaciones habitacion = new Habitaciones();
        DataSet ds = new DataSet();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;

        public CtrlHabitaciones()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();
        }

        private void CargarDG()
        {
            habitacion.Inicio1 = pagInicio;
            habitacion.Final1 = pagFinal;
            ds = habitacion.PaginacionHabitacion();
            dgvHab.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPagH.Text = cantidad.ToString();

            cmbPagH.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPagH.Items.Add(x.ToString());

            cmbPagH.SelectedIndex = indice;
        }

        private void CtrlHabitaciones_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvHab.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvHab.Columns.Add(btnDelete);
        }

        public void BuscarHabitacion(string buscarH)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarHabitacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@numeroH", MySqlDbType.VarChar, 50).Value = buscarH;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHab.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RegistrarHabitacion registrarHab = new RegistrarHabitacion();
            registrarHab.ShowDialog();
            CargarDG();
        }

        private void dgvHab_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvHab.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvHab.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvHab.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvHab.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvHab.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvHab.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvHab.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvHab.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        private void cmbPagH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagH.Text);
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

        private void dgvHab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvHab.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = admonHab.EliminarHabitacion(dgvHab.CurrentRow.Cells["ID"].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el registro?",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (elimino)
                    {
                        MessageBox.Show("Habitación eliminada");
                        CargarDG();
                    }
                    else
                    {
                        MessageBox.Show("Habitación no eliminada");
                    }

                }
                else /*if (dialogResult == DialogResult.No)*/
                {

                }
            }

            if (this.dgvHab.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarHabitacion editarHab = new EditarHabitacion();

                editarHab.idH = dgvHab.CurrentRow.Cells["ID"].Value.ToString();
                editarHab.cmbTipo.Text = dgvHab.CurrentRow.Cells["TIPO"].Value.ToString();
                editarHab.txtNumero.Text = dgvHab.CurrentRow.Cells["NUMERO"].Value.ToString();
                editarHab.cmbEstado.Text = dgvHab.CurrentRow.Cells["ESTADO"].Value.ToString();
                editarHab.ShowDialog();
                CargarDG();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarHabitacion(txtBuscar.Text);
            }
            else
            {
                CargarDG();
            }
        }
    }
}
