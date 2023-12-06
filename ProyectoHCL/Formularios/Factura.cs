using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.ExtendedProperties;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoHCL.Formularios.CtrlFacturacion;
using static ProyectoHCL.RecuContra;
using Image = System.Drawing.Image;

namespace ProyectoHCL.Formularios
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        CDatos cDatos = new CDatos();

        private void Permisos()
        {
            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs);

            foreach (var obj in LsObj)
            {
                switch (obj.IdPermiso)   /* realiza las respectivas validaciones de permisos */
                {
                    case 2:
                        if (obj.ObjetoN == "FACTURACION" && !obj.Permitido) //Validar pantalla y el permiso
                        {
                            btnFacturar.Visible = false; //Deshabilitar botón para crear
                            btnCancelar.Visible = false;
                        }
                        break;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Variables para fechas, y totales y subtotales
        DateTime today = DateTime.Today;
        Decimal st1, st2, st3, sth = 0;
        Decimal St1, St2, St3, StS = 0;
        Decimal isv, it, subt, total, desc, subtD, iEx;

        ServicioVenta sv = new ServicioVenta();

        int posY = 0;
        int posX = 0;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)   /* condicional IF */
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void limpiarControles()
        {
            lblSubt.Text = "";
            lblDesc.Text = "";
            lblSubtD.Text = "";
            lblSV.Text = "";
            lblTur.Text = "";
            lblExonerado.Text = "";
            lblTotal.Text = "";
            this.dgvDetalleFact.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnCancelar.Text == "Anular")
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand();

                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("UPDATE TBL_FACTURA SET ESTADO = 'ANULADA' " +
                            "WHERE NFACTURA = " + info.factura + ";");

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();

                        MsgB Mbox = new MsgB("informacion", "Factura anulada");
                        DialogResult DR = Mbox.ShowDialog();
                        this.Close();

                    }
                }
                catch (Exception ex)
                {
                    MsgB Mbox = new MsgB("error", "Error: " + ex.Message);
                    DialogResult DR = Mbox.ShowDialog();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nuevo = new ServicioVenta();
            nuevo.ShowDialog();

            limpiarControles();
            CargarDGV();
            this.Show();
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            Form nuevo = new DescuentoFact();
            nuevo.ShowDialog();

            limpiarControles();
            CargarDGV();
        }

        private void Factura_FormClosing(object sender, FormClosingEventArgs e)
        {
            clases.CDatos.descuento = 0;
        }

        //Procedimiento para generar consulta de info para la vista de factura
        private DataTable consulta(string param, int op)
        {
            DataTable dt = new DataTable();
            if (op == 1) //Consulta la info de la reserva de forma general
            {
                try
                {
                    string stri = "select c.NOMBRE, c.APELLIDO, c.DNI_PASAPORTE, s.FECHACOTI, s.INGRESO, " +
                                  "s.SALIDA, s.NHUESPEDES FROM TBL_SOLICITUDRESERVA s " +
                                  "INNER JOIN TBL_CLIENTE c ON s.COD_CLIENTE = c.CODIGO " +
                                  "WHERE s.ID_SOLICITUDRESERVA = " + param + ";";

                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand(stri, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    conn.Close();
                    return dt;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                    return dt;
                }
            }
            else if (op == 2) //Consulta las habitaciones reservadas
            {
                try
                {
                    string stri = "SELECT NUMEROHABITACION, " +
                        "(SELECT TIPO FROM TBL_TIPOHABITACION WHERE ID_TIPOHABITACION = (SELECT ID_TIPOHABITACION FROM TBL_HABITACION WHERE NUMEROHABITACION = ds.NUMEROHABITACION)) AS TIPO, " +
                        "(SELECT PRECIO FROM TBL_TIPOHABITACION WHERE ID_TIPOHABITACION = (SELECT ID_TIPOHABITACION FROM TBL_HABITACION WHERE NUMEROHABITACION = ds.NUMEROHABITACION)) AS PRECIO " +
                        "FROM TBL_SOLICITUDRESERVA ds " +
                        "WHERE ds.ID_SOLICITUDRESERVA = " + param + ";";

                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand(stri, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    conn.Close();
                    return dt;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                    return dt;
                }
            }
            else if (op == 3) //Consulta los servicios de la reserva
            {
                try
                {
                    string stri = "SELECT s.DESCRIPCION, ds.CANTIDAD, s.PRECIO " +
                                  "FROM TBL_DETALLESERVICIO ds " +
                                  "INNER JOIN TBL_SERVICIO s ON ds.ID_SERVICIO = s.ID_SERVICIO " +
                                  "where ds.ID_SOLICITUDRESERVA = " + param + ";";

                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand(stri, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    conn.Close();
                    return dt;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                    return dt;
                }
            }
            else if (op == 4) //INFO DE FACTURA
            {
                try
                {
                    string stri = "SELECT N_OCEXCENTA, NCONSTANCIAEXONERADO, NREGISTROSAR, DESCUENTO " +
                                  "FROM TBL_FACTURA " +
                                  "where ID_SOLICITUDRESERVA = " + param + ";";

                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand(stri, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    conn.Close();
                    return dt;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                    return dt;
                }
            }
            else if (op == 5) //DETALLE HABITACIONES FACTURADAS
            {
                try
                {
                    string stri = "SELECT * FROM TBL_DETALLEFACTURA WHERE ID_SOLICITUDRESERVA = " +
                        param + ";";


                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand(stri, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    conn.Close();
                    return dt;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                    return dt;
                }
            }
            else if (op == 6) //DETALLE SERVICIOS FACTURADOS
            {
                try
                {
                    string stri = "SELECT * FROM TBL_DETALLEFACTURASERVI WHERE ID_SOLICITUDRESERVA = " +
                        param + ";";

                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand(stri, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    conn.Close();
                    return dt;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                    return dt;
                }
            }

            return dt;
        }

        int h, s;
        DataTable ht = new DataTable();
        DataTable st = new DataTable();
        //string query1 = "", query0 = "";
        string habitacion = "";
        decimal precio = 0;
        decimal tot = 0;
        int cantidad = 0;
        string descrip = "";
        decimal precio1 = 0, tot1 = 0, vHab = 0, vServ = 0, descuento = 0;

        private void CargarDGV()
        {
            string hoy = today.ToString("dd/MM/yyyy");
            var noches = Convert.ToDateTime(info.salida) - Convert.ToDateTime(info.ingreso);

            //Vista de la reserva en formato factura, aun sin facturar
            if (info.reserva != "0" & info.factura == "0")
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = consulta(info.reserva, 1);

                    int n = dt.Rows.Count;

                    if (n != 0)
                    {
                        //Carga de datos generales en la vista
                        lblNombre.Text = dt.Rows[0]["NOMBRE"].ToString() + " " + dt.Rows[0]["APELLIDO"].ToString();
                        CDatos.nombre = dt.Rows[0]["NOMBRE"].ToString() + " " + dt.Rows[0]["APELLIDO"].ToString();
                        lblId.Text = dt.Rows[0]["DNI_PASAPORTE"].ToString();
                        CDatos.nombreCliente = dt.Rows[0]["NOMBRE"].ToString();
                        CDatos.apellidoCliente = dt.Rows[0]["APELLIDO"].ToString();
                        lblFecha.Text = hoy;
                        lblIngreso.Text = info.ingreso;
                        lblSalida.Text = info.salida;
                        lblHuesp.Text = dt.Rows[0]["NHUESPEDES"].ToString();
                        lblNoches.Text = Convert.ToString(noches.Days);

                        ht = consulta(info.reserva, 2);
                        h = ht.Rows.Count;
                        //DetalleHabitaciones

                        int i = 0;
                        int j = 0;
                        sth = 0;
                        StS = 0;

                        if (h > 0)
                        {
                            //listView1.Items.Clear();

                            while (i < h)
                            {

                                dgvDetalleFact.Rows.Add("1", ("Habit. #" + ht.Rows[i]["NUMEROHABITACION"].ToString() + " " + ht.Rows[i]["TIPO"].ToString()),
                                    ht.Rows[i]["PRECIO"].ToString(), Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"])));

                                if (i == (h - 1))
                                {
                                    string habitacion = "Habit. # " + ht.Rows[i]["NUMEROHABITACION"].ToString() + " " + ht.Rows[i]["TIPO"].ToString();
                                    decimal precio = Convert.ToDecimal(ht.Rows[i]["PRECIO"]);
                                    decimal tot = Convert.ToDecimal(noches.Days) * precio;
                                }
                                else
                                {
                                    string habitacion = "Habit. # " + ht.Rows[i]["NUMEROHABITACION"].ToString() + " " + ht.Rows[i]["TIPO"].ToString();
                                    decimal precio = Convert.ToDecimal(ht.Rows[i]["PRECIO"]);
                                    decimal tot = Convert.ToDecimal(noches.Days) * precio;
                                }
                                sth = sth + Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"]);
                                vHab = sth;
                                i++;
                            }
                        }

                        st = consulta(info.reserva, 3);
                        s = st.Rows.Count;

                        if (s > 0)
                        {
                            while (j < s)
                            {
                                dgvDetalleFact.Rows.Add(st.Rows[j]["CANTIDAD"].ToString(), st.Rows[j]["DESCRIPCION"].ToString(),
                                    st.Rows[j]["PRECIO"].ToString(), Convert.ToString(Convert.ToDecimal(st.Rows[j]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[j]["PRECIO"])));

                                if (j == (s - 1))
                                {
                                    int cantidad = Convert.ToInt32(st.Rows[j]["CANTIDAD"]);
                                    string descrip = st.Rows[j]["DESCRIPCION"].ToString();
                                    decimal precio1 = Convert.ToDecimal(st.Rows[j]["PRECIO"]);
                                    decimal tot1 = cantidad * precio1;
                                }
                                else
                                {
                                    int cantidad = Convert.ToInt32(st.Rows[j]["CANTIDAD"]);
                                    string descrip = st.Rows[j]["DESCRIPCION"].ToString();
                                    decimal precio1 = Convert.ToDecimal(st.Rows[j]["PRECIO"]);
                                    decimal tot1 = cantidad * precio1;
                                }

                                StS += Convert.ToInt32(st.Rows[j]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[j]["PRECIO"]);
                                vServ = StS;
                                j++;
                            }
                        }

                        //Datos de impuestos y totales

                        isv = 0;
                        it = 0;
                        subt = 0;
                        total = 0;
                        desc = 0;
                        subtD = 0;
                        iEx = 0;

                        //Datos de impuestos y totales
                        //if (sth != 0.00m & StS != 0.00m)
                        //{

                        //if (!string.IsNullOrEmpty(txtConstEx.Text))
                        //{
                        //    decimal valorHab15 = Decimal.Round((sth / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvHab = Decimal.Round(sth - valorHab15, 2);

                        //    decimal valorHab4 = Decimal.Round((valorHab15 / 1.04m), 2); // Valor antes del impuesto del 4%
                        //    it = Decimal.Round(valorHab15 - valorHab4, 2);

                        //    decimal valorServ = Decimal.Round((StS / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvServ = Decimal.Round((StS - valorServ), 2);

                        //    isv = 0;
                        //    subt = Decimal.Round(valorHab15 + valorServ, 2);
                        //    desc = Decimal.Round(clases.CDatos.descuento * subt, 2);
                        //    subtD = Decimal.Round(subt - desc, 2);
                        //    total = Decimal.Round(isv + it + subtD, 2);
                        //    iEx = Decimal.Round(isvHab + isvServ);

                        //    lblSubt.Text = subt.ToString();
                        //    lblDesc.Text = desc.ToString();
                        //    lblSubtD.Text = subtD.ToString();
                        //    lblSV.Text = isv.ToString();
                        //    lblTur.Text = it.ToString();
                        //    lblExonerado.Text = iEx.ToString();
                        //    lblTotal.Text = total.ToString();
                        //}
                        //else
                        //{
                        ActualizarLabels();
                        // }
                        //decimal valorHab15 = Decimal.Round((sth / 1.15m), 2); // Valor antes del impuesto del 15%
                        //decimal isvHab = Decimal.Round(sth - valorHab15, 2);

                        //decimal valorHab4 = Decimal.Round((valorHab15 / 1.04m), 2); // Valor antes del impuesto del 4%
                        //it = Decimal.Round(valorHab15 - valorHab4, 2);

                        //decimal valorServ = Decimal.Round((StS / 1.15m), 2); // Valor antes del impuesto del 15%
                        //decimal isvServ = Decimal.Round((StS - valorServ), 2);

                        //isv = Decimal.Round(isvHab + isvServ, 2);
                        //subt = Decimal.Round(valorHab4 + valorServ, 2);
                        //desc = Decimal.Round(clases.CDatos.descuento * subt, 2);
                        //subtD = Decimal.Round(subt - desc, 2);
                        //total = Decimal.Round(isv + it + subtD, 2);
                        //}
                        //else if (sth != 0.00m & StS == 0)
                        //{
                        //    decimal valorHab15 = Decimal.Round((sth / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvHab = Decimal.Round(sth - valorHab15, 2);

                        //    decimal valorHab4 = Decimal.Round((valorHab15 / 1.04m), 2); // Valor antes del impuesto del 4%
                        //    it = Decimal.Round(valorHab15 - valorHab4, 2);

                        //    decimal valorServ = Decimal.Round((StS / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvServ = Decimal.Round((StS - valorServ), 2);

                        //    isv = Decimal.Round(isvHab + isvServ, 2);
                        //    subt = Decimal.Round(valorHab4 + valorServ, 2);
                        //    desc = Decimal.Round(clases.CDatos.descuento * subt, 2);
                        //    subtD = Decimal.Round(subt - desc, 2);
                        //    total = Decimal.Round(isv + it + subtD, 2);
                        //}
                        //else if (sth == 0 & StS != 0)
                        //{
                        //    decimal valorHab15 = Decimal.Round((sth / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvHab = Decimal.Round(sth - valorHab15, 2);

                        //    decimal valorHab4 = Decimal.Round((valorHab15 / 1.04m), 2); // Valor antes del impuesto del 4%
                        //    it = Decimal.Round(valorHab15 - valorHab4, 2);

                        //    decimal valorServ = Decimal.Round((StS / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvServ = Decimal.Round((StS - valorServ), 2);

                        //    isv = Decimal.Round(isvHab + isvServ, 2);
                        //    subt = Decimal.Round(valorHab4 + valorServ, 2);
                        //    desc = Decimal.Round(clases.CDatos.descuento * subt, 2);
                        //    subtD = Decimal.Round(subt - desc, 2);
                        //    total = Decimal.Round(isv + it + subtD, 2);
                        //}

                        //lblSubt.Text = subt.ToString();
                        //lblDesc.Text = desc.ToString();
                        //lblSubtD.Text = subtD.ToString();
                        //lblSV.Text = isv.ToString();
                        //lblTur.Text = it.ToString();
                        //lblTotal.Text = total.ToString();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }
            }
            else if (info.reserva != "0" & info.factura != "0") //Factura solo para modificar metodo de pago
            {
                sth = 0;
                StS = 0;
                DataTable dt = new DataTable();
                try //Carga de combobox para tipo de pago
                {
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //Consulta
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("SELECT ID_TIPOPAGO FROM TBL_FACTURA " +
                            "WHERE ID_SOLICITUDRESERVA = " + info.reserva + ";");

                        MySqlDataReader leer = comando.ExecuteReader();

                        while (leer.Read())
                        {
                            cmbPago.SelectedIndex = Convert.ToInt32(leer["ID_TIPOPAGO"]);
                        }

                        comando.Connection.Close();
                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }

                dt = consulta(info.reserva, 4);
                txtOC.Text = dt.Rows[0]["N_OCEXCENTA"].ToString();
                txtConstEx.Text = dt.Rows[0]["NCONSTANCIAEXONERADO"].ToString();
                txtSar.Text = dt.Rows[0]["NREGISTROSAR"].ToString();
                lblDesc.Text = Convert.ToString(dt.Rows[0]["DESCUENTO"]);

                try
                {
                    dt = consulta(info.reserva, 1);

                    int n = dt.Rows.Count;

                    if (n != 0)
                    {
                        lblNombre.Text = dt.Rows[0]["NOMBRE"].ToString() + " " + dt.Rows[0]["APELLIDO"].ToString();
                        lblId.Text = dt.Rows[0]["DNI_PASAPORTE"].ToString();
                        lblFecha.Text = hoy;
                        lblIngreso.Text = info.ingreso;
                        lblSalida.Text = info.salida;
                        lblHuesp.Text = dt.Rows[0]["NHUESPEDES"].ToString();
                        lblNoches.Text = Convert.ToString(noches.Days);
                        lblEstado.Text = info.estado;

                        ht = consulta(info.reserva, 5);
                        h = ht.Rows.Count;

                        //DetalleHabitaciones
                        int i = 0;
                        int j = 0;
                        dgvDetalleFact.Rows.Clear();

                        if (h > 0)
                        {
                            while (i < h)
                            {
                                dgvDetalleFact.Rows.Add("1", ht.Rows[i]["DESCRIPCION"].ToString(),
                                    ht.Rows[i]["PRECIO"].ToString(), Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"])));

                                sth = sth + Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"]);
                                vHab = sth;
                                i = i + 1;
                            }
                        }

                        st = consulta(info.reserva, 6);
                        s = st.Rows.Count;

                        if (s > 0)
                        {
                            while (j < s)
                            {
                                dgvDetalleFact.Rows.Add(st.Rows[j]["CANTIDAD"].ToString(), st.Rows[j]["DESCRIPCION"].ToString(),
                                    st.Rows[j]["PRECIO"].ToString(), Convert.ToString(Convert.ToDecimal(st.Rows[j]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[j]["PRECIO"])));

                                StS = StS + Convert.ToDecimal(st.Rows[j]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[j]["PRECIO"]);
                                vServ = StS;
                                j = j + 1;
                            }
                        }

                        //Datos de impuestos y totales
                        ActualizarLabels2();
                        //if (sth != 0.00m & StS != 0.00m)
                        //{
                        //    decimal valorHab15 = Decimal.Round((sth / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvHab = Decimal.Round(sth - valorHab15, 2);

                        //    decimal valorHab4 = Decimal.Round((valorHab15 / 1.04m), 2); // Valor antes del impuesto del 4%
                        //    it = Decimal.Round(valorHab15 - valorHab4, 2);

                        //    decimal valorServ = Decimal.Round((StS / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvServ = Decimal.Round((StS - valorServ), 2);

                        //    if (decimal.TryParse(lblDesc.Text, out descuento))
                        //    {
                        //        isv = Decimal.Round(isvHab + isvServ, 2);
                        //        subt = Decimal.Round(valorHab4 + valorServ, 2);
                        //        desc = descuento;
                        //        subtD = Decimal.Round(subt - desc, 2);
                        //        total = Decimal.Round(isv + it + subtD, 2);
                        //    }
                        //}
                        //else if (sth != 0.00m & StS == 0)
                        //{
                        //    decimal valorHab15 = Decimal.Round((sth / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvHab = Decimal.Round(sth - valorHab15, 2);

                        //    decimal valorHab4 = Decimal.Round((valorHab15 / 1.04m), 2); // Valor antes del impuesto del 4%
                        //    it = Decimal.Round(valorHab15 - valorHab4, 2);

                        //    decimal valorServ = Decimal.Round((StS / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvServ = Decimal.Round((StS - valorServ), 2);

                        //    if (decimal.TryParse(lblDesc.Text, out descuento))
                        //    {
                        //        isv = Decimal.Round(isvHab + isvServ, 2);
                        //        subt = Decimal.Round(valorHab4 + valorServ, 2);
                        //        desc = descuento;
                        //        subtD = Decimal.Round(subt - desc, 2);
                        //        total = Decimal.Round(isv + it + subtD, 2);
                        //    }
                        //}
                        //else if (sth == 0 & StS != 0)
                        //{
                        //    decimal valorHab15 = Decimal.Round((sth / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvHab = Decimal.Round(sth - valorHab15, 2);

                        //    decimal valorHab4 = Decimal.Round((valorHab15 / 1.04m), 2); // Valor antes del impuesto del 4%
                        //    it = Decimal.Round(valorHab15 - valorHab4, 2);

                        //    decimal valorServ = Decimal.Round((StS / 1.15m), 2); // Valor antes del impuesto del 15%
                        //    decimal isvServ = Decimal.Round((StS - valorServ), 2);

                        //    if (decimal.TryParse(lblDesc.Text, out descuento))
                        //    {
                        //        isv = Decimal.Round(isvHab + isvServ, 2);
                        //        subt = Decimal.Round(valorHab4 + valorServ, 2);
                        //        desc = descuento;
                        //        subtD = Decimal.Round(subt - desc, 2);
                        //        total = Decimal.Round(isv + it + subtD, 2);
                        //    }
                        //}

                        //lblSubt.Text = subt.ToString();
                        ////lblDesc.Text = desc.ToString();
                        //lblSubtD.Text = subtD.ToString();
                        //lblSV.Text = isv.ToString();
                        //lblTur.Text = it.ToString();
                        //lblTotal.Text = total.ToString();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }

            }
        }

        private void InsertarDatos()
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection();
                conectar = BaseDatosHCL.ObtenerConexion();

                using (conectar)
                {
                    // Insertar la primera fila en una tabla
                    DataGridViewRow primeraFila = dgvDetalleFact.Rows[0];
                    string valorColumna1 = primeraFila.Cells["Cant."].Value.ToString();
                    string valorColumna2 = primeraFila.Cells["Descripción"].Value.ToString();
                    string valorColumna3 = primeraFila.Cells["P. Unitario"].Value.ToString();
                    string valorColumna4 = primeraFila.Cells["Total"].Value.ToString();

                    string query = "INSERT INTO TBL_DETALLEFACTURA (DIAS, DESCRIPCION, PRECIO, TOTAL, ID_SOLICITUDRESERVA) " +
                                                   "VALUES (@valorColumna1, @valorColumna2, @valorColumna3, @valorColumna4, @IdSolicitudReserva)";

                    using (MySqlCommand comandoPrimeraTabla = new MySqlCommand(query, conectar))
                    {
                        comandoPrimeraTabla.Parameters.AddWithValue("@valorColumna1", valorColumna1);
                        comandoPrimeraTabla.Parameters.AddWithValue("@valorColumna2", valorColumna2);
                        comandoPrimeraTabla.Parameters.AddWithValue("@valorColumna3", valorColumna3);
                        comandoPrimeraTabla.Parameters.AddWithValue("@valorColumna4", valorColumna4);
                        comandoPrimeraTabla.Parameters.AddWithValue("@IdSolicitudReserva", info.reserva);

                        comandoPrimeraTabla.ExecuteNonQuery();
                    }

                    // Insertar el resto de filas en otra tabla
                    for (int i = 1; i < dgvDetalleFact.Rows.Count; i++)
                    {
                        DataGridViewRow fila = dgvDetalleFact.Rows[i];
                        string valorCol1 = fila.Cells["Cant."].Value.ToString();
                        string valorCol2 = fila.Cells["Descripción"].Value.ToString();
                        string valorCol3 = fila.Cells["P. Unitario"].Value.ToString();
                        string valorCol4 = fila.Cells["Total"].Value.ToString();

                        string query1 = "INSERT INTO TBL_DETALLEFACTURASERVI (CANTIDAD, DESCRIPCION, PRECIO, TOTAL, ID_SOLICITUDRESERVA) " +
                                                  "VALUES (@valorCol1, @valorCol2, @valorCol3, @valorCol4, @IdSolicitudReserva)";

                        using (MySqlCommand comandoOtraTabla = new MySqlCommand(query1, conectar))
                        {
                            comandoOtraTabla.Parameters.AddWithValue("@valorCol1", valorCol1);
                            comandoOtraTabla.Parameters.AddWithValue("@valorCol2", valorCol2);
                            comandoOtraTabla.Parameters.AddWithValue("@valorCol3", valorCol3);
                            comandoOtraTabla.Parameters.AddWithValue("@valorCol4", valorCol4);
                            comandoOtraTabla.Parameters.AddWithValue("@IdSolicitudReserva", info.reserva);

                            comandoOtraTabla.ExecuteNonQuery();
                        }
                    }
                    // Cerrar la conexión
                    conectar.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            Permisos();

            dgvDetalleFact.Columns.Add("cant.", "Cant.");
            dgvDetalleFact.Columns.Add("descripción", "Descripción");
            dgvDetalleFact.Columns.Add("p. unitario", "P. Unitario");
            dgvDetalleFact.Columns.Add("total", "Total");
            dgvDetalleFact.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleFact.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewImageColumn btnEliminar = new DataGridViewImageColumn();
            btnEliminar.Name = "Eliminar";
            dgvDetalleFact.Columns.Add(btnEliminar);

            txtConstEx.TextChanged += txtConstEx_TextChanged;

            try
            {
                //Carga del combobox de tipo de pago
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("SELECT * FROM TBL_TIPOPAGO");

                    MySqlDataReader leer = comando.ExecuteReader();

                    cmbPago.Items.Add("--Seleccione--");
                    cmbPago.SelectedIndex = 0;
                    //Validación de la data obtenida
                    while (leer.Read())
                    {
                        cmbPago.Items.Add(leer["DESCRIPCION"].ToString());
                    }
                    comando.Connection.Close();
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }

            if (info.est == 1)
            {
                txtConstEx.Enabled = false;
                txtOC.Enabled = false;
                txtSar.Enabled = false;
                cmbPago.Enabled = false;
                btnFacturar.Visible = true;
                btnDescuento.Visible = false;
                btnServicio.Visible = false;
                dgvDetalleFact.Columns["Eliminar"].Visible = false;
                label3.Visible = true;
                lblEstado.Visible = true;

                var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs);

                foreach (var obj in LsObj)
                {
                    switch (obj.IdPermiso)   /* realiza las respectivas validaciones de permisos */
                    {
                        case 2:
                            if (obj.ObjetoN == "FACTURACION" && !obj.Permitido) //Validar pantalla y el permiso
                            {
                                btnFacturar.Visible = false; //Deshabilitar botón para crear
                                btnCancelar.Visible = false;
                            }
                            break;
                    }
                }

                if (info.estado == "ANULADA")
                {
                    btnFacturar.Visible = false;
                    btnCancelar.Visible = false;
                }
                else
                {
                    btnFacturar.Text = "Generar";
                    btnCancelar.Text = "Anular";
                }
            }
            else if (info.est == 2)
            {
                txtConstEx.Enabled = true;
                txtOC.Enabled = true;
                txtSar.Enabled = true;
                cmbPago.Enabled = true;
                btnFacturar.Visible = true;
                btnDescuento.Visible = true;
                btnServicio.Visible = true;
                btnFacturar.Text = "Facturar";
            }

            limpiarControles();
            CargarDGV();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (cmbPago.Text == "--Seleccione--") //validar campo vacío
            {
                MsgB Mbox = new MsgB("advertencia", "Seleccione un método de pago");
                DialogResult DR = Mbox.ShowDialog();
            }
            if (!string.IsNullOrEmpty(txtConstEx.Text) && string.IsNullOrEmpty(txtOC.Text))
            {
                MsgB m = new MsgB("advertencia", "Por favor llene todos los campos requeridos"); //validar campos vacíos
                DialogResult dR = m.ShowDialog();
            }
            if (!string.IsNullOrEmpty(txtConstEx.Text) && string.IsNullOrEmpty(txtSar.Text))
            {
                MsgB m = new MsgB("advertencia", "Por favor llene todos los campos requeridos"); //validar campos vacíos
                DialogResult dR = m.ShowDialog();
            }
            else if (info.est == 2)
            {
                try
                {
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //Consulta
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();

                        //string txtOCValue = string.IsNullOrEmpty(txtOC.Text) ? "---" : txtOC.Text;
                        //string txtConstExValue = string.IsNullOrEmpty(txtConstEx.Text) ? "---" : txtConstEx.Text;
                        //string txtSarValue = string.IsNullOrEmpty(txtSar.Text) ? "---" : txtSar.Text;

                        comando.CommandText = (
                            "INSERT INTO TBL_FACTURA(ID_SOLICITUDRESERVA, ID_TIPOPAGO, " +
                            "ID_USUARIO, FECHA, N_OCEXCENTA, NCONSTANCIAEXONERADO, NREGISTROSAR, SUBTOTAL, " +
                            "IMPOREXONERADO, IMPOREXCENTO, IMPORTEISV, IMPORTEALCOHOL, IMPORTETURISMO, " +
                            "IMPUESISV, IMPUESALCOHOL, IMPUESTURIMOS, TOTAL, ESTADO, DESCUENTO) VALUES (" +
                            info.reserva + ", " +
                            cmbPago.SelectedIndex + ", " +
                            clasecompartida.iduser + ", '" +
                            today.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            "'" + txtOC.Text + "', " +
                            "'" + txtConstEx.Text + "', " +
                            "'" + txtSar.Text + "', " +
                            subt + ", " + iEx + ", 0, " +
                            subt + ", 0, " +
                            sth + ", " +
                            isv + ", 0, " +
                            it + ", " +
                            total + ", 'VIGENTE', " + desc + ")"
                        );

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();

                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("UPDATE TBL_SOLICITUDRESERVA SET ID_ESTADORESERVA = 4 " +
                            "WHERE ID_SOLICITUDRESERVA = " + info.reserva + ";");

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();

                        InsertarDatos();

                        MsgB mbox = new MsgB("informacion", "Registro Agregado");
                        DialogResult dR = mbox.ShowDialog();
                        this.Close();

                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Error: " + a.Message + a.StackTrace);

                }

            }
            else if (info.est == 1)
            {
                crearPDF();
                MsgB mbox = new MsgB("informacion", "Archivo PDF creado con éxito");
                DialogResult dR = mbox.ShowDialog();
            }
        }

        private void crearPDF()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyy") + ".pdf";

            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

            string paginahtml_texto = Properties.Resources.Plantilla.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@DIRECCION", ParametroDireccionH());
            paginahtml_texto = paginahtml_texto.Replace("@TELEFONOS", ParametroTelefonoH());
            paginahtml_texto = paginahtml_texto.Replace("@CUENTAH", ParametroCtaH());
            paginahtml_texto = paginahtml_texto.Replace("@RTN", ParametroRTNH());
            paginahtml_texto = paginahtml_texto.Replace("@CORREOF", ParametroCorreoF());

            paginahtml_texto = paginahtml_texto.Replace("@FECHA1", today.ToString("yyyy-MM-dd"));
            paginahtml_texto = paginahtml_texto.Replace("@CLIENTE", lblNombre.Text);
            paginahtml_texto = paginahtml_texto.Replace("@ID", lblId.Text);
            paginahtml_texto = paginahtml_texto.Replace("@FACTURA", info.factura);
            paginahtml_texto = paginahtml_texto.Replace("@INGRESO", lblIngreso.Text);
            paginahtml_texto = paginahtml_texto.Replace("@SALIDA", lblSalida.Text);
            paginahtml_texto = paginahtml_texto.Replace("@NOCHES", lblNoches.Text);

            string filas = string.Empty;

            int i = 0;
            int j = 0;
            var noches = Convert.ToDateTime(info.salida) - Convert.ToDateTime(info.ingreso);

            while (i < h)
            {
                filas += "<tr>";
                filas += "<td>1</td>";
                filas += "<td>" + ht.Rows[i]["DESCRIPCION"].ToString() + "</td>";
                filas += "<td style='text-align: right;'>" + ht.Rows[i]["PRECIO"].ToString() + "</td>";
                filas += "<td style='text-align: right;'>" + Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"])) + "</td>";
                filas += "</tr>";
                i = i + 1;
            }

            while (j < s)
            {
                filas += "<tr>";
                filas += "<td>" + st.Rows[j]["CANTIDAD"].ToString() + "</td>";
                filas += "<td>" + st.Rows[j]["DESCRIPCION"].ToString() + "</td>";
                filas += "<td style='text-align: right;'>" + st.Rows[j]["PRECIO"].ToString() + "</td>";
                filas += "<td style='text-align: right;'>" + Convert.ToString(Convert.ToDecimal(st.Rows[j]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[j]["PRECIO"])) + "</td>";
                filas += "</tr>";
                j = j + 1;
            }

            paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);

            paginahtml_texto = paginahtml_texto.Replace("@SUBTOTAL", Convert.ToString(subt));
            paginahtml_texto = paginahtml_texto.Replace("@DESCUENTO", Convert.ToString(desc));
            paginahtml_texto = paginahtml_texto.Replace("@STMD", Convert.ToString(subtD));
            paginahtml_texto = paginahtml_texto.Replace("@IMPEX", Convert.ToString(iEx));
            paginahtml_texto = paginahtml_texto.Replace("@ISV", Convert.ToString(isv));
            paginahtml_texto = paginahtml_texto.Replace("@IST", Convert.ToString(it));
            //paginahtml_texto = paginahtml_texto.Replace("@TOIM", Convert.ToString(isv + it));
            paginahtml_texto = paginahtml_texto.Replace("@TOTAL", Convert.ToString(total));

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                string filePath = guardar.FileName;

                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    //Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();

                    MostrarVistaPrevia(filePath);
                }
            }
        }

        private void MostrarVistaPrevia(string filePath)
        {
            Form previewForm = new Form();
            previewForm.Text = "Factura";
            previewForm.Size = new Size(800, 600);

            // Crear un control WebBrowser para mostrar el PDF
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            previewForm.Controls.Add(webBrowser);

            // Navegar al archivo PDF
            webBrowser.Navigate(filePath);

            // Mostrar el formulario de vista previa
            previewForm.ShowDialog();
        }

        private void cmbPago_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.cmbVacio(cmbPago))
            {
                errorT.SetError(cmbPago, "Seleccione un método de pago");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void dgvDetalleFact_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvDetalleFact.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Image imagen = Properties.Resources.eliminar;

                dgvDetalleFact.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvDetalleFact.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
        }

        AdmonServicios aServ = new AdmonServicios();
        private void dgvDetalleFact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDetalleFact.Columns[e.ColumnIndex].Name == "Eliminar") //si se dio click en el botón eliminar hacer lo siguiente
            {
                bool elimino = aServ.EliminarServicioHab(sv.idServicio(dgvDetalleFact.CurrentRow.Cells["Descripción"].Value.ToString()), info.reserva);

                this.dgvDetalleFact.Rows.Clear();
                CargarDGV();
            }
        }

        private void dgvDetalleFact_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index == 0)
            {
                e.Cancel = true; // Evitar la eliminación de la primera fila
            }
        }

        public static string ParametroDireccionH()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR FROM TBL_PARAMETRO WHERE PARAMETRO = 'DIRECCION HOTEL';";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR"].ToString();
            }
            else
            {
                return null;

            }
            conn.Close();
        }

        public static string ParametroTelefonoH()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR FROM TBL_PARAMETRO WHERE PARAMETRO = 'TELEFONOS';";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR"].ToString();
            }
            else
            {
                return null;

            }
            conn.Close();
        }

        public static string ParametroCtaH()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR FROM TBL_PARAMETRO WHERE PARAMETRO = 'CTA CHEQUE FACT';";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR"].ToString();
            }
            else
            {
                return null;

            }
            conn.Close();
        }

        public static string ParametroRTNH()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR FROM TBL_PARAMETRO WHERE PARAMETRO = 'RTN FACT';";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR"].ToString();
            }
            else
            {
                return null;

            }
            conn.Close();
        }

        public static string ParametroCorreoF()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR FROM TBL_PARAMETRO WHERE PARAMETRO = 'CORREO FACT';";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR"].ToString();
            }
            else
            {
                return null;

            }
            conn.Close();
        }

        private void txtConstEx_TextChanged(object sender, EventArgs e)
        {
            ActualizarLabels();
        }

        private void ActualizarLabels()
        {
            if (!string.IsNullOrEmpty(txtConstEx.Text))
            {
                decimal valorHab15 = Decimal.Round((vHab / 1.15m), 2); // Valor antes del impuesto del 15%
                decimal isvHab = Decimal.Round(vHab - valorHab15, 2);

                decimal valorHab4 = Decimal.Round((valorHab15 / 1.04m), 2); // Valor antes del impuesto del 4%
                it = Decimal.Round(valorHab15 - valorHab4, 2);

                decimal valorServ = Decimal.Round((vServ / 1.15m), 2); // Valor antes del impuesto del 15%
                decimal isvServ = Decimal.Round((vServ - valorServ), 2);

                isv = 0;
                subt = Decimal.Round(valorHab15 + valorServ, 2);
                desc = Decimal.Round(clases.CDatos.descuento * subt, 2);
                subtD = Decimal.Round(subt - desc, 2);
                total = Decimal.Round(isv + it + subtD, 2);
                iEx = Decimal.Round(isvHab + isvServ, 2);

                lblSubt.Text = subt.ToString();
                lblDesc.Text = desc.ToString();
                lblSubtD.Text = subtD.ToString();
                lblSV.Text = "0.00";
                lblTur.Text = it.ToString();
                lblExonerado.Text = iEx.ToString();
                lblTotal.Text = total.ToString();
            }
            else
            {
                decimal valorHab15 = Decimal.Round((sth / 1.15m), 2); // Valor antes del impuesto del 15%
                decimal isvHab = Decimal.Round(sth - valorHab15, 2);

                decimal valorHab4 = Decimal.Round((valorHab15 / 1.04m), 2); // Valor antes del impuesto del 4%
                it = Decimal.Round(valorHab15 - valorHab4, 2);

                decimal valorServ = Decimal.Round((StS / 1.15m), 2); // Valor antes del impuesto del 15%
                decimal isvServ = Decimal.Round((StS - valorServ), 2);

                isv = Decimal.Round(isvHab + isvServ, 2);
                subt = Decimal.Round(valorHab4 + valorServ, 2);
                desc = Decimal.Round(clases.CDatos.descuento * subt, 2);
                subtD = Decimal.Round(subt - desc, 2);
                total = Decimal.Round(isv + it + subtD, 2);

                lblSubt.Text = subt.ToString();
                lblDesc.Text = desc.ToString();
                lblSubtD.Text = subtD.ToString();
                lblSV.Text = isv.ToString();
                lblTur.Text = it.ToString();
                lblExonerado.Text = "0.00";
                lblTotal.Text = total.ToString();
            }
        }

        private void ActualizarLabels2()
        {

            if (!string.IsNullOrEmpty(txtConstEx.Text))
            {
                decimal valorHab15 = Decimal.Round((vHab / 1.15m), 2); // Valor antes del impuesto del 15%
                decimal isvHab = Decimal.Round(vHab - valorHab15, 2);

                decimal valorHab4 = Decimal.Round((valorHab15 / 1.04m), 2); // Valor antes del impuesto del 4%
                it = Decimal.Round(valorHab15 - valorHab4, 2);

                decimal valorServ = Decimal.Round((vServ / 1.15m), 2); // Valor antes del impuesto del 15%
                decimal isvServ = Decimal.Round((vServ - valorServ), 2);

                if (decimal.TryParse(lblDesc.Text, out descuento))
                {
                    isv = 0;
                    subt = Decimal.Round(valorHab15 + valorServ, 2);
                    desc = descuento;
                    subtD = Decimal.Round(subt - desc, 2);
                    total = Decimal.Round(isv + it + subtD, 2);
                    iEx = Decimal.Round(isvHab + isvServ, 2);
                }
                lblSubt.Text = subt.ToString();
                lblDesc.Text = desc.ToString();
                lblSubtD.Text = subtD.ToString();
                lblSV.Text = "0.00";
                lblTur.Text = it.ToString();
                lblExonerado.Text = iEx.ToString();
                lblTotal.Text = total.ToString();
            }
            else
            {
                decimal valorHab15 = Decimal.Round((sth / 1.15m), 2); // Valor antes del impuesto del 15%
                decimal isvHab = Decimal.Round(sth - valorHab15, 2);

                decimal valorHab4 = Decimal.Round((valorHab15 / 1.04m), 2); // Valor antes del impuesto del 4%
                it = Decimal.Round(valorHab15 - valorHab4, 2);

                decimal valorServ = Decimal.Round((StS / 1.15m), 2); // Valor antes del impuesto del 15%
                decimal isvServ = Decimal.Round((StS - valorServ), 2);

                if (decimal.TryParse(lblDesc.Text, out descuento))
                {
                    isv = Decimal.Round(isvHab + isvServ, 2);
                    subt = Decimal.Round(valorHab4 + valorServ, 2);
                    desc = descuento;
                    subtD = Decimal.Round(subt - desc, 2);
                    total = Decimal.Round(isv + it + subtD, 2);
                }

                lblSubt.Text = subt.ToString();
                lblDesc.Text = desc.ToString();
                lblSubtD.Text = subtD.ToString();
                lblSV.Text = isv.ToString();
                lblTur.Text = it.ToString();
                lblExonerado.Text = "0.00";
                lblTotal.Text = total.ToString();
            }
        }

        private void txtConstEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSar_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConstEx.Text) && ValidarTxt.txtVacio(txtSar))
            {
                errorT.SetError(txtSar, "El campo no puede quedar vacío");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtOC_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConstEx.Text) && ValidarTxt.txtVacio(txtOC))
            {
                errorT.SetError(txtOC, "El campo no puede quedar vacío");
            }
            else
            {
                errorT.Clear();
            }
        }
    }
}