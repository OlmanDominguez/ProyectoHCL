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

using static ProyectoHCL.RecuContra;
using static ProyectoHCL.Formularios.CtrlFacturacion;
using static ProyectoHCL.Formularios.ShowFactura;
using DocumentFormat.OpenXml.ExtendedProperties;
using SpreadsheetLight;

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
            cmbServicio.Enabled = false;
        }

        private void limpiarCampos()
        {
            txtTotal.Clear();
            cmbServicio.SelectedIndex = -1;
            txtPrecio.Clear();
            txt_cantidad.Clear();
            txtHab.Clear();
            txtCliente.Clear();
            txtEntrada.Clear();
            txtSalida.Clear();
        }

        public void limpiarError()
        {
            errorT.SetError(cmbServicio, "");
            errorT.SetError(txt_cantidad, "");
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
            else if (txt_cantidad.Text == "")
            {
                MsgB Mbox = new MsgB("advertencia", "Indique cantidad");
                DialogResult DR = Mbox.ShowDialog();
            }
            else
            {
                ListViewItem lista = new ListViewItem(cmbServicio.Text);
                lista.SubItems.Add(txtPrecio.Text);
                lista.SubItems.Add(txt_cantidad.Text);
                Decimal subt = Convert.ToDecimal(txt_cantidad.Text) * Convert.ToDecimal(txtPrecio.Text);
                lista.SubItems.Add(Convert.ToString(subt));
                listView.Items.Add(lista);


                decimal resultadoActual = decimal.Parse(txtTotal.Text);
                resultadoActual += subt;

                txtTotal.Text = Convert.ToString(resultadoActual);

                try
                {
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = "SELECT * FROM TBL_SERVICIO WHERE DESCRIPCION = '" + cmbServicio.Text + "';";
                        MySqlDataReader leer = comando.ExecuteReader();

                        int id = 0;
                        if (leer.Read())
                        {
                            id = (int)leer["ID_SERVICIO"];
                        }


                        comando.Connection.Close();

                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("INSERT INTO TBL_DETALLESERVICIO (ID_SERVICIO, ID_SOLICITUDRESERVA, ID_DESCUENTO, CANTIDAD, " +
                            "MONTODESCUENTO) VALUES(" + id + ", " + info.reserva + ", 1, " + txt_cantidad.Text + ", 0);");

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();

                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }




                ActualizarResultado();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];


                decimal precio = decimal.Parse(item.SubItems[1].Text);
                decimal resultadoActual = decimal.Parse(txtTotal.Text);
                resultadoActual -= precio;
                txtTotal.Text = resultadoActual.ToString();


                if (Convert.ToInt32(item.SubItems[2].Text) == 1)
                {
                    int id = 0;
                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = "SELECT * FROM TBL_SERVICIO WHERE DESCRIPCION = '" + item.SubItems[0].Text + "';";
                            MySqlDataReader leer = comando.ExecuteReader();

                            id = 0;
                            if (leer.Read())
                            {
                                id = (int)leer["ID_SERVICIO"];
                            }


                            comando.Connection.Close();

                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("DELETE FROM TBL_DETALLESERVICIO WHERE ID_SOLICITUDRESERVA = " +
                                info.reserva + " and ID_SERVICIO = " + id + " and CANTIDAD = 1;");

                            comando.ExecuteNonQuery();
                            comando.Connection.Close();


                            listView.Items.Remove(item);
                        }

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message + a.StackTrace);
                    }

                                     
                    
                }
                else
                {
                    int id = 0;
                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = "SELECT * FROM TBL_SERVICIO WHERE DESCRIPCION = '" + item.SubItems[0].Text + "';";
                            MySqlDataReader leer = comando.ExecuteReader();

                            id = 0;
                            if (leer.Read())
                            {
                                id = (int)leer["ID_SERVICIO"];
                            }

                            comando.Connection.Close();

                        }

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message + a.StackTrace);
                    }

                    int idds = 0;

                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("SELECT ID_DETALLESERVICIO, CANTIDAD FROM TBL_DETALLESERVICIO WHERE ID_SOLICITUDRESERVA = " +
                                info.reserva + " and ID_SERVICIO = " + id + "  ORDER BY CANTIDAD ASC;");

                            MySqlDataReader leer3 = comando.ExecuteReader();
                            if (leer3.Read())
                            {
                                idds = (int)leer3["ID_DETALLESERVICIO"];
                            }


                            comando.Connection.Close();

                            listView.Items.Remove(item);

                        }

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message + a.StackTrace);
                    }

                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("UPDATE TBL_DETALLESERVICIO SET CANTIDAD = " + (Convert.ToInt32(item.SubItems[2].Text) - 1) + " WHERE ID_SOLICITUDRESERVA = " +
                                info.reserva + " and ID_SERVICIO = " + id + " and ID_DETALLESERVICIO = " + idds + ";");

                            comando.ExecuteNonQuery();
                            comando.Connection.Close();

                            listView.Items.Remove(item);

                        }

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message + a.StackTrace);
                    }

                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();

                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = "SELECT ds.CANTIDAD, s.PRECIO, s.DESCRIPCION  FROM TBL_DETALLESERVICIO ds " +
                                "INNER JOIN TBL_SERVICIO s ON ds.ID_SERVICIO = s.ID_SERVICIO " +
                                "WHERE ds.ID_SERVICIO = " + id + " AND ds.ID_SOLICITUDRESERVA = " + info.reserva + " and ID_DETALLESERVICIO = " + idds + ";";
                            MySqlDataReader leer2 = comando.ExecuteReader();

                            if (leer2.Read())
                            {
                                ListViewItem lista = new ListViewItem(leer2["DESCRIPCION"].ToString());
                                lista.SubItems.Add(leer2["PRECIO"].ToString());
                                lista.SubItems.Add(leer2["CANTIDAD"].ToString());
                                decimal subt = Convert.ToDecimal(leer2["CANTIDAD"].ToString()) * Convert.ToDecimal(leer2["PRECIO"].ToString());
                                lista.SubItems.Add(subt.ToString());
                                listView.Items.Add(lista);

                            }
                            comando.Connection.Close();
                        }

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message + a.StackTrace);
                    }



                }




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
                this.Close();
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


                resultado += decimal.Parse(item.SubItems[1].Text);

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
            if (txt_cantidad.Text == "")
            {
                errorT.SetError(txt_cantidad, "Seleccione un estado");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void ServicioVenta_Load(object sender, EventArgs e)
        {
            if (info.est == 2)
            {
                btnReservacion.Visible = false;
                txtHab.Text = clases.CDatos.numeroHab.ToString();
                txtCliente.Text = CDatos.nombre.ToString();
                txtEntrada.Text = info.ingreso.ToString();
                txtSalida.Text = info.salida.ToString();


                DataTable st = new DataTable();

                try
                {


                    string stri = "SELECT s.DESCRIPCION, ds.CANTIDAD, s.PRECIO " +
                                  "FROM TBL_DETALLESERVICIO ds " +
                                  "INNER JOIN TBL_SERVICIO s ON ds.ID_SERVICIO = s.ID_SERVICIO " +
                                  "where ds.ID_SOLICITUDRESERVA = " + info.reserva + ";";


                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand(stri, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(st);
                    conn.Close();

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);

                }

                int s = st.Rows.Count;
                int i = 0;
                decimal total = 0;

                if (s > 0)
                {
                    while (i < s)
                    {


                        ListViewItem lista = new ListViewItem(st.Rows[i]["DESCRIPCION"].ToString());
                        lista.SubItems.Add(st.Rows[i]["PRECIO"].ToString());
                        lista.SubItems.Add(st.Rows[i]["CANTIDAD"].ToString());
                        lista.SubItems.Add(Convert.ToString(Convert.ToDecimal(st.Rows[i]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[i]["PRECIO"])));
                        listView.Items.Add(lista);

                        total += Convert.ToDecimal(st.Rows[i]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[i]["PRECIO"]);

                        i = i + 1;
                    }
                }

                txtTotal.Text = total.ToString();

            }
            else
            {
                btnReservacion.Visible = true;
            }
        }
    }
}
