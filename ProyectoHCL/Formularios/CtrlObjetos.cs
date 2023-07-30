using DocumentFormat.OpenXml.Office2013.Excel;
using DocumentFormat.OpenXml.Vml;
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
        R_E_Objeto R_E_obj = new R_E_Objeto();
        AdmonObjetos admonObjeto = new AdmonObjetos();
        Objetos obj = new Objetos();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;


        public CtrlObjetos()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();
        }

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

            HabilitarBotones();
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
            R_E_obj.lblTitulo.Text = "Registrar Objeto";
            R_E_obj.Size = new System.Drawing.Size(800, 431);
            R_E_obj.btnGuardar.Location = new Point(256, 282);
            R_E_obj.btnCancelar.Location = new Point(466, 282);
            R_E_obj.label2.Location = new Point(243, 34);
            R_E_obj.txtObj.Location = new Point(243, 65);
            R_E_obj.label1.Visible = false;
            R_E_obj.cmbEstado.Visible = false;
            R_E_obj.label6.Location = new Point(243, 107);
            R_E_obj.rTxtDesc.Location = new Point(243, 138);
            R_E_obj.ShowDialog();
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
                R_E_obj.lblTitulo.Text = "Editar Objeto";
                R_E_obj.Size = new System.Drawing.Size(800, 371);
                R_E_obj.btnGuardar.Location = new Point(256, 213);
                R_E_obj.btnCancelar.Location = new Point(466, 213);
                R_E_obj.label2.Location = new Point(59, 34);
                R_E_obj.txtObj.Location = new Point(59, 67);
                R_E_obj.label1.Location = new Point(59, 115);
                R_E_obj.cmbEstado.Location = new Point(59, 146);
                R_E_obj.label1.Visible = true;
                R_E_obj.cmbEstado.Visible = true;
                R_E_obj.label6.Location = new Point(421, 34);
                R_E_obj.rTxtDesc.Location = new Point(421, 65);
                R_E_obj.idObj = dgvObjetos.CurrentRow.Cells["ID"].Value.ToString();
                R_E_obj.txtObj.Text = dgvObjetos.CurrentRow.Cells["NOMBRE"].Value.ToString();
                R_E_obj.rTxtDesc.Text = dgvObjetos.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                R_E_obj.cmbEstado.Text = dgvObjetos.CurrentRow.Cells["ESTADO"].Value.ToString();
                R_E_obj.ShowDialog();
                R_E_obj.limpiarCampos();
                CargarDG();
            }

            if (this.dgvObjetos.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    bool elimino = admonObjeto.EliminarObjeto(dgvObjetos.CurrentRow.Cells["ID"].Value.ToString());

                    if (elimino)
                    {
                        MsgB mbox = new MsgB("informacion", "Registro eliminado");
                        DialogResult dR = mbox.ShowDialog();
                        CargarDG();
                    }
                    else
                    {
                        MsgB mbox = new MsgB("informacion", "Registro no eliminado");
                        DialogResult dR = mbox.ShowDialog();
                    }

                }
                else if (dg == DialogResult.Cancel)
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

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPag.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPag.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
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

            if (indice == (Convert.ToInt32(txtPag.Text) - 1))
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
