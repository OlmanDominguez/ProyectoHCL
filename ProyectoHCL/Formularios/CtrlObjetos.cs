using DocumentFormat.OpenXml.Office2013.Excel;
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
        Objetos obj = new Objetos();
        DataSet ds = new DataSet();
        int pagInicio = 1, indice = 0, numFilas = 3, pagFinal, cmbIndice = 0;


        public CtrlObjetos()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();
            //BuscarObjetos("");
        }

        AdmonObjetos admonObjeto = new AdmonObjetos();

        private void CargarDG()
        {
            obj.Inicio1 = pagInicio;
            obj.Final1 = pagFinal;
            ds = obj.PaginacionObjetos();
            dgvObjetos.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPag.Text = cantidad.ToString();

            cmbPag.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPag.Items.Add(x.ToString());

            cmbPag.SelectedIndex = indice;
        }

        private void CtrlObjetos_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvObjetos.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvObjetos.Columns.Add(btnDelete);
        }

        //public void MostrarObjetos()
        //{
        //    dgvObjetos.DataSource = admonObjeto.MostrarObjetos();
        //}

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
            CargarDG();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarObjetos(txtBuscar.Text);
            }
            else
            {
                CargarDG();
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
                editarObjeto.ShowDialog();
                CargarDG();
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
                        CargarDG();
                    }
                    else
                    {
                        MessageBox.Show("Objeto no eliminado");
                    }

                }
                else /*(dialogResult == DialogResult.No)*/
                {
                    //
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

        private void cmbPag_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPag.Text);
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
    }
}
