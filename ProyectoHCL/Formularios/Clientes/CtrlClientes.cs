using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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
        Clientes clien = new Clientes();
        DataSet ds = new DataSet();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal;

        public CtrlClientes()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDGCl();
            //BuscarClientes("");
        }

        AdmonClientes admonClientes = new AdmonClientes();

        private void CargarDGCl()
        {
            clien.Inicio1 = pagInicio;
            clien.Final1 = pagFinal;
            ds = clien.PaginacionClientes();
            dgvClientes.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPagCl.Text = cantidad.ToString();

            cmbPagCl.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPagCl.Items.Add(x.ToString());

            cmbPagCl.SelectedIndex = indice;


        }

        private void CtrlClientes_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnShow = new DataGridViewButtonColumn();
            btnShow.Name = "VER";
            dgvClientes.Columns.Add(btnShow);

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvClientes.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvClientes.Columns.Add(btnDelete);
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
            AgregarCliente aggCliente = new AgregarCliente();
            aggCliente.ShowDialog();
            CargarDGCl();
        }

        public static class claseCod
        {
            public static string codigo;
        }


        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "VER")
            {
                try
                {
                    claseCod.codigo = dgvClientes.CurrentRow.Cells["CODIGO"].Value.ToString();
                    //MessageBox.Show(claseCod.codigo);
                    Form formulario = new Formularios.ShowCliente();
                    formulario.ShowDialog();

                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un error");
                }
            }

            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                try
                {
                    claseCod.codigo = dgvClientes.CurrentRow.Cells["CODIGO"].Value.ToString();
                    //MessageBox.Show(claseCod.codigo);
                    Form formulario = new Formularios.EditarCliente();
                    formulario.ShowDialog();
                    CargarDGCl();

                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un error");
                }
            }

            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = admonClientes.EliminarCliente(dgvClientes.CurrentRow.Cells["CODIGO"].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el Cliente?",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (elimino)
                    {
                        MessageBox.Show("Cliente Eliminado");
                        CargarDGCl();
                    }
                    else
                    {
                        MessageBox.Show("Cliente NO eliminado");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }



        }



        private void dgvClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvClientes.Columns[e.ColumnIndex].Name == "VER" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvClientes.Rows[e.RowIndex].Cells["VER"] as DataGridViewButtonCell;
                Icon icoVer = new Icon(Environment.CurrentDirectory + "\\ver.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvClientes.Rows[e.RowIndex].Height = icoVer.Height + 8;
                this.dgvClientes.Columns[e.ColumnIndex].Width = icoVer.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvClientes.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvClientes.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoEditar = new Icon(Environment.CurrentDirectory + "\\editar.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvClientes.Rows[e.RowIndex].Height = icoEditar.Height + 8;
                this.dgvClientes.Columns[e.ColumnIndex].Width = icoEditar.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvClientes.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvClientes.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvClientes.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvClientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        private void cmbPagCl_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPagCl.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGCl();
        }

        private void cmbMostrarCl_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           numFilas = int.Parse(cmbMostrarCl.Text);
            pagFinal = numFilas;
            CargarDGCl();
        }

        private void txtBuscarCl_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCl.Text != "")
            {
                BuscarClientes(txtBuscarCl.Text);
            }
            else
            {
                CargarDGCl();
            }
        }
    }
}
