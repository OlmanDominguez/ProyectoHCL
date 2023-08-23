using DocumentFormat.OpenXml.Drawing;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ProyectoHCL.Formularios
{
    public partial class ServicioVenta : Form
    {
        public ServicioVenta()
        {
            InitializeComponent();
            cargarServicios();
            cmbServicio.SelectedIndex = -1;
            btnAgregar.Enabled = false;
            btnAgregar.BackColor = Color.DarkGray;
            btnEliminar.Enabled = false;
            btnEliminar.BackColor = Color.DarkGray;
            btnVenta.Enabled = false;
            btnVenta.BackColor = Color.DarkGray;
            cmbEstado.Enabled = false;
            cmbServicio.Enabled = false;
        }

        private void limpiarCampos()
        {
            txtTotal.Clear();
            cmbServicio.SelectedIndex = -1;
            txtPrecio.Clear();
            cmbEstado.SelectedIndex = -1;
            txtHab.Clear();
            txtCliente.Clear();
            txtEntrada.Clear();
            txtSalida.Clear();
        }

        public void limpiarError()
        {
            errorT.SetError(cmbServicio, "");
            errorT.SetError(cmbEstado, "");
        }

        private void cargarServicios()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            cmbServicio.DataSource = null;
            cmbServicio.Items.Clear();
            string sql = "SELECT ID_SERVICIO, DESCRIPCION FROM TBL_SERVICIO;";

            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            try
            {
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cmbServicio.ValueMember = "ID_SERVICIO";
                cmbServicio.DisplayMember = "DESCRIPCION";
                cmbServicio.DataSource = dt;

            }
            catch (MySqlException e)
            {
                MsgB m = new MsgB("Error", "Se produjo un error " + e.Message);
                DialogResult dR = m.ShowDialog();
            }
            finally { conn.Close(); }
        }

        public decimal Precio()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = BaseDatosHCL.ObtenerConexion();
            comando.CommandText = ("SELECT PRECIO FROM TBL_SERVICIO WHERE DESCRIPCION = '"
                + cmbServicio.Text + "';");

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                return (decimal)leer["PRECIO"];
            }
            else
            {
                return 0;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbServicio.Text == "")
            {
                MsgB Mbox = new MsgB("advertencia", "Seleccione un servicio");
                DialogResult DR = Mbox.ShowDialog();
            }
            else if (cmbEstado.Text == "")
            {
                MsgB Mbox = new MsgB("advertencia", "Seleccione un estado");
                DialogResult DR = Mbox.ShowDialog();
            }
            else
            {
                ListViewItem lista = new ListViewItem(cmbServicio.Text);
                lista.SubItems.Add(txtPrecio.Text);
                lista.SubItems.Add(txtPrecio.Text);
                lista.SubItems.Add(cmbEstado.Text);
                listView.Items.Add(lista);

                ActualizarResultado();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];

                if (item.SubItems[3].Text == "Pendiente")
                {
                    decimal precio = decimal.Parse(item.SubItems[1].Text);
                    decimal resultadoActual = decimal.Parse(txtTotal.Text);
                    resultadoActual -= precio;
                    txtTotal.Text = resultadoActual.ToString();
                }

                listView.Items.Remove(item);
            }
            else
            {
                MsgB Mbox = new MsgB("advertencia", "Seleccione un item de la lista");
                DialogResult DR = Mbox.ShowDialog();
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count == 0)
            {
                MsgB Mbox = new MsgB("advertencia", "No se guardó, no hay items en la lista");
                DialogResult DR = Mbox.ShowDialog();
            }
            else
            {
                listView.Items.Clear();
                limpiarCampos();
            }
        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecio.Text = Precio().ToString();
        }

        private void ActualizarResultado()
        {
            decimal resultado = 0;
            foreach (ListViewItem item in listView.Items)
            {
                if (item.SubItems[3].Text == "Pendiente")
                {
                    resultado += decimal.Parse(item.SubItems[1].Text);
                }
            }
            txtTotal.Text = resultado.ToString();
        }

        private void btnReservacion_Click(object sender, EventArgs e)
        {
            using (ServicioHab servHab = new ServicioHab())
            {
                servHab.ShowDialog(this);
            }
            txtHab.Text = clases.CDatos.numeroHab.ToString();
            txtCliente.Text = clases.CDatos.cliente.ToString();
            txtEntrada.Text = clases.CDatos.entrada.ToString();
            txtSalida.Text = clases.CDatos.salida.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiarError();
        }

        private void txtHab_TextChanged(object sender, EventArgs e)
        {
            if (txtHab.Text == "")
            {
                btnAgregar.Enabled = false;
                btnAgregar.BackColor = Color.DarkGray;
                btnEliminar.Enabled = false;
                btnEliminar.BackColor = Color.DarkGray;
                btnVenta.Enabled = false;
                btnVenta.BackColor = Color.DarkGray;
                cmbEstado.Enabled = false;
                cmbServicio.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
                btnAgregar.BackColor = Color.CadetBlue;
                btnEliminar.Enabled = true;
                btnEliminar.BackColor = Color.Red;
                btnVenta.Enabled = true;
                btnVenta.BackColor = Color.CadetBlue;
                cmbEstado.Enabled = true;
                cmbServicio.Enabled = true;
            }
        }

        private void cmbServicio_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.cmbVacio(cmbServicio))
            {
                errorT.SetError(cmbServicio, "Seleccione un servicio");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void cmbEstado_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.cmbVacio(cmbEstado))
            {
                errorT.SetError(cmbEstado, "Seleccione un estado");
            }
            else
            {
                errorT.Clear();
            }
        }
    }
}
