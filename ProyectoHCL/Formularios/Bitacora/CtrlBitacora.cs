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
using ProyectoHCL.Formularios;

namespace ProyectoHCL.Formularios
{
    public partial class CtrlBitacora : Form
    {
        clases.Bitacora bitacora = new clases.Bitacora();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;

        public CtrlBitacora()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();
        }

        private void CargarDG()
        {
            bitacora.Inicio1 = pagInicio;
            bitacora.Final1 = pagFinal;
            ds = bitacora.PaginacionBitacora();
            dgvBitacora.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPreg.Text = cantidad.ToString();

            cmbPreg.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPreg.Items.Add(x.ToString());

            cmbPreg.SelectedIndex = indice;

            HabilitarBotones();
        }


        public void BuscarServicio(string buscarS)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarBitacora", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreU", MySqlDbType.VarChar, 50).Value = buscarS;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBitacora.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void dgvBitacora_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvBitacora.Columns[e.ColumnIndex].Name == "VER" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvBitacora.Rows[e.RowIndex].Cells["VER"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\ver.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvBitacora.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvBitacora.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }

        }

        private void cmbPreg_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPreg.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void cmbMostrar_SelectedIndexChanged_1(object sender, EventArgs e)
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

        public static class preg
        {
            public static string detalle;
            public static int op;
            public static int id;
        }

        private void dgvBitacora_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgvBitacora.Columns[e.ColumnIndex].Name == "VER")
            {
                //Agregar codigo para ver detalle de bitacora

            }


        }

        private void btnAnt_Click_1(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPreg.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSig_Click_1(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPreg.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }
        private void HabilitarBotones()
        {
            if (pagInicio == 1)
            {
                btnAnt.Enabled = false;
                cmbMostrar.Enabled = true;
            }
            else
            {
                btnAnt.Enabled = true;
                cmbMostrar.Enabled = false;
            }

            if (indice == (Convert.ToInt32(txtPreg.Text) - 1))
            {
                btnSig.Enabled = false;
            }
            else
            {
                btnSig.Enabled = true;
            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarServicio(txtBuscar.Text);
            }
            else
            {
                CargarDG();
            }
        }

        private void CtrlBitacora_Load_1(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "VER";
            dgvBitacora.Columns.Add(btnUpdate);

        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
