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
    public partial class CtrlPreguntas : Form
    {
        clases.Preguntas servicio = new clases.Preguntas();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;

        public CtrlPreguntas()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();
        }

        private void CargarDG()
        {
            servicio.Inicio1 = pagInicio;
            servicio.Final1 = pagFinal;
            ds = servicio.PaginacionPreguntas();
            dgvPreguntas.DataSource = ds.Tables[1];

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

                cmd = new MySqlCommand("buscarPregunta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreP", MySqlDbType.VarChar, 50).Value = buscarS;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPreguntas.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void dgvPreguntas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPreguntas.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPreguntas.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvPreguntas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvPreguntas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvPreguntas.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPreguntas.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvPreguntas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvPreguntas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

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

        private void dgvPreguntas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvPreguntas.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    preg.detalle = dgvPreguntas.CurrentRow.Cells["PREGUNTA"].Value.ToString();
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //Consulta
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("UPDATE TBL_PREGUNTA SET ID_ESTADO = 2 WHERE PREGUNTA lIKE '%" +
                            preg.detalle + "%';");

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();
                        MsgB mbox = new MsgB("informacion", "Registro eliminado");
                        DialogResult dR = mbox.ShowDialog();
                        CargarDG();
                    }

                }
                else if (dg == DialogResult.Cancel)
                {

                }
            }

            if (this.dgvPreguntas.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                preg.detalle = dgvPreguntas.CurrentRow.Cells["PREGUNTA"].Value.ToString();
                preg.op = 1;
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("SELECT * FROM TBL_PREGUNTA WHERE PREGUNTA LIKE  '%" +
                        preg.detalle + "%';");
                    MySqlDataReader leer = comando.ExecuteReader();
                    while (leer.Read())
                    {
                        preg.id = Convert.ToInt32(leer["ID_PREGUNTA"]);
                    }

                    comando.Connection.Close();

                }
                Form formulario = new Formularios.ShowPregunta();
                formulario.ShowDialog();
                CargarDG();
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

        private void CtrlPreguntas_Load_1(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvPreguntas.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvPreguntas.Columns.Add(btnDelete);
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            preg.op = 2;
            Form formulario = new Formularios.ShowPregunta();
            formulario.ShowDialog();
            CargarDG();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
