/* -----------------------------------------------------------------------
    Universidad Nacional Autonoma de Honduras (UNAH)
		Facultad de Ciencias Economicas
	Departamento de Informatica administrativa
         Analisis, Programacion y Evaluacion de Sistemas
                    Tercer Periodo 2013


Equipo:
GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

JOEL ENRIQUE GODOY BONILLA---------(joel.godoy@unah.hn)

OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

Catedratico analisis y diseño:             Lic.Giancarlo Martini Scalici Aguilar 
catedratico programacion e implementacion: Lic.Karla Melisa Garcia Pineda 
catedratico evaluacion de sistemas:        Lic.Karla Melisa Garcia Pineda 


---------------------------------------------------------------------

Programa:         Pantalla de Ingreso de mostrar Factura
Fecha:             26 - septiembre - 2023
Programador: Joel
descripcion:       Pantalla que contrala las validaciones de mostrar Factura

-----------------------------------------------------------------------

                Historial de Cambio

-----------------------------------------------------------------------

Programador               Fecha                      Descripcion
GABRIELA  MANCIA  

HILDEGARD  MONTALVAN   

NELSON SALGADO  

JOEL  GODOY 

OLMAN  DOMÍNGUEZ 

----------------------------------------------------------------------- */

/* Librerias utilizadas para facilitar el proceso */
using MySql.Data.MySqlClient;  /* libreria para conectar la BD */
using ProyectoHCL.clases; /*hacer uso de las clases dentro del proyecto */
using System;/* identificar los bloques de codigo */
using System.Collections.Generic; /* libreria para lectura */
using System.ComponentModel; /* jerarguia de componentes funcionales */
using System.ComponentModel.Design;
using System.Data; /*conexion a la BD */
using System.Drawing;/* impresion de archivos en excel */
using System.Globalization; 
using System.Linq;/* clases e interfaces */
using System.Runtime.CompilerServices; 
using System.Text;/* manipular informacion dentro de la aplicacion */
using System.Threading.Tasks;/* libreria para impresion */
using System.Windows.Controls; 
using System.Windows.Forms;
using System.Xml.Linq;
using static ProyectoHCL.RecuContra;
using static ProyectoHCL.Formularios.CtrlFacturacion;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace ProyectoHCL.Formularios
{

    public partial class ShowFactura : Form
    {

        public ShowFactura()
        {
            InitializeComponent();
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Variables para fechas, y totales y subtotales
        DateTime today = DateTime.Today;
        Decimal st1, st2, st3, sth = 0;
        Decimal St1, St2, St3, StS = 0;
        Decimal isv, it, subt, total;

        int posY = 0;
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
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
                    string stri = "SELECT h.NUMEROHABITACION, th.TIPO, th.PRECIO " +
                          "FROM TBL_DETALLERESERVA ds " +
                          "INNER JOIN TBL_HABITACION h ON ds.ID_HABITACION = h.ID_HABITACION " +
                          "INNER JOIN TBL_TIPOHABITACION th ON h.ID_TIPOHABITACION = th.ID_TIPOHABITACION " +
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
                    string stri = "SELECT N_OCEXCENTA, NCONSTANCIAEXONERADO, NREGISTROSAR " +
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
        string query0 = "", query1 = "";

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
                        lb_nombres.Text = dt.Rows[0]["NOMBRE"].ToString() + " " + dt.Rows[0]["APELLIDO"].ToString();
                        CDatos.nombre = dt.Rows[0]["NOMBRE"].ToString() + " " + dt.Rows[0]["APELLIDO"].ToString();
                        lb_ID.Text = dt.Rows[0]["DNI_PASAPORTE"].ToString();
                        lb_fecha.Text = hoy;
                        lb_ingreso.Text = info.ingreso;
                        lb_Salida.Text = info.salida;
                        lb_huespedes.Text = dt.Rows[0]["NHUESPEDES"].ToString();
                        lb_noches.Text = Convert.ToString(noches.Days);


                        ht = consulta(info.reserva, 2);
                        h = ht.Rows.Count;
                        //DetalleHabitaciones



                        int i = 0;
                        int j = 0;
                        sth = 0;
                        StS = 0;

                        if (h > 0)
                        {
                            while (i < h)
                            {
                                dgvDetalleFact.Rows.Add("1", ("Habit. #" + ht.Rows[i]["NUMEROHABITACION"].ToString() + " " + ht.Rows[i]["TIPO"].ToString()),
                                    ht.Rows[i]["PRECIO"].ToString(), Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"])));

                                if (i == (h - 1))
                                {
                                    query0 = query0 + "(1,'Habit. #" + ht.Rows[i]["NUMEROHABITACION"].ToString() + " " + ht.Rows[i]["TIPO"].ToString() +
                                    "'," + ht.Rows[i]["PRECIO"].ToString() + "," + Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"])) +
                                    ", " + info.reserva + ");";

                                }
                                else
                                {
                                    query0 = query0 + "(1,'Habit. #" + ht.Rows[i]["NUMEROHABITACION"].ToString() + " " + ht.Rows[i]["TIPO"].ToString() +
                                    "'," + ht.Rows[i]["PRECIO"].ToString() + "," + Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"])) +
                                    ", " + info.reserva + "), ";

                                }
                                sth = sth + Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"]);

                                i = i + 1;
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
                                    query1 = query1 + "(" + st.Rows[j]["CANTIDAD"].ToString() + ",'" + st.Rows[j]["DESCRIPCION"].ToString() + "'," +
                                        st.Rows[j]["PRECIO"].ToString() + "," + Convert.ToString(Convert.ToDecimal(st.Rows[j]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[j]["PRECIO"])) +
                                        ", " + info.reserva + ");";

                                }
                                else
                                {
                                    query1 = query1 + "(" + st.Rows[j]["CANTIDAD"].ToString() + ",'" + st.Rows[j]["DESCRIPCION"].ToString() + "'," +
                                         st.Rows[j]["PRECIO"].ToString() + "," + Convert.ToString(Convert.ToDecimal(st.Rows[j]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[j]["PRECIO"])) +
                                         ", " + info.reserva + "), ";

                                }
                                StS = StS + Convert.ToDecimal(st.Rows[j]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[j]["PRECIO"]);
                                j = j + 1;
                            }
                        }

                        //Datos de impuestos y totales

                        isv = 0;
                        it = 0;
                        subt = 0;
                        total = 0;

                        if (sth != 0.00m & StS != 0.00m)
                        {
                            isv = Decimal.Round(((sth / 1.19m) * 0.15m) + ((StS / 1.15m) * 0.15m), 2);
                            it = Decimal.Round((sth / 1.19m) * 0.04m, 2);
                            subt = Decimal.Round((sth / 1.19m) + (StS / 1.15m), 2);
                            total = Decimal.Round(isv + it + subt, 2);

                        }
                        else if (sth != 0.00m & StS == 0)
                        {
                            isv = Decimal.Round((sth / 1.19m) * 0.15m, 2);
                            it = Decimal.Round((sth / 1.19m) * 0.04m, 2);
                            subt = Decimal.Round((sth / 1.19m) + (StS / 1.15m), 2);
                            total = Decimal.Round(isv + it + subt, 2);

                        }
                        else if (sth == 0 & StS != 0)
                        {
                            isv = Decimal.Round((StS / 1.15m) * 0.15m, 2);
                            it = 0;
                            subt = Decimal.Round((StS / 1.15m), 2);
                            total = Decimal.Round(isv + it + subt, 2);
                        }

                        dgvMontos.Rows.Add("SubTotal", subt);
                        dgvMontos.Rows.Add("Descuento", 0);
                        dgvMontos.Rows.Add("SubTotal menos Descuento", subt - 0);
                        dgvMontos.Rows.Add("Impuesto S/Venta", isv);
                        dgvMontos.Rows.Add("Impuesto Turismo", it);
                        dgvMontos.Rows.Add("Total Impuesto", isv + it);
                        dgvMontos.Rows.Add("Total", subt + isv + it);

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
                            cb_MPago.SelectedIndex = Convert.ToInt32(leer["ID_TIPOPAGO"]);
                        }

                        comando.Connection.Close();
                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }



                dt = consulta(info.reserva, 4);
                txt_OCExenta.Text = dt.Rows[0]["N_OCEXCENTA"].ToString();
                txt_ConsExone.Text = dt.Rows[0]["NCONSTANCIAEXONERADO"].ToString();
                txt_RegSar.Text = dt.Rows[0]["NREGISTROSAR"].ToString();




                try
                {

                    dt = consulta(info.reserva, 1);

                    int n = dt.Rows.Count;


                    if (n != 0)
                    {
                        lb_nombres.Text = dt.Rows[0]["NOMBRE"].ToString() + " " + dt.Rows[0]["APELLIDO"].ToString();
                        lb_ID.Text = dt.Rows[0]["DNI_PASAPORTE"].ToString();
                        lb_fecha.Text = hoy;
                        lb_ingreso.Text = info.ingreso;
                        lb_Salida.Text = info.salida;
                        lb_huespedes.Text = dt.Rows[0]["NHUESPEDES"].ToString();

                        lb_noches.Text = Convert.ToString(noches.Days);



                        ht = consulta(info.reserva, 5);
                        h = ht.Rows.Count;
                        //DetalleHabitaciones


                        int i = 0;
                        int j = 0;

                        if (h > 0)
                        {
                            while (i < h)
                            {
                                dgvDetalleFact.Rows.Add("1", ht.Rows[i]["DESCRIPCION"].ToString(),
                                    ht.Rows[i]["PRECIO"].ToString(), Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"])));

                                sth = sth + Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"]);

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
                                j = j + 1;
                            }
                        }

                        //Datos de impuestos y totales

                        if (sth != 0.00m & StS != 0.00m)
                        {
                            isv = Decimal.Round(((sth / 1.19m) * 0.15m) + ((StS / 1.15m) * 0.15m), 2);
                            it = Decimal.Round((sth / 1.19m) * 0.04m, 2);
                            subt = Decimal.Round((sth / 1.19m) + (StS / 1.15m), 2);
                            total = Decimal.Round(isv + it + subt, 2);

                        }
                        else if (sth != 0.00m & StS == 0)
                        {
                            isv = Decimal.Round((sth / 1.19m) * 0.15m, 2);
                            it = Decimal.Round((sth / 1.19m) * 0.04m, 2);
                            subt = Decimal.Round((sth / 1.19m) + (StS / 1.15m), 2);
                            total = Decimal.Round(isv + it + subt, 2);

                        }
                        else if (sth == 0 & StS != 0)
                        {
                            isv = Decimal.Round((StS / 1.15m) * 0.15m, 2);
                            it = 0;
                            subt = Decimal.Round((StS / 1.15m), 2);
                            total = Decimal.Round(isv + it + subt, 2);
                        }

                        dgvMontos.Rows.Add("SubTotal", subt);
                        dgvMontos.Rows.Add("Descuento", 0);
                        dgvMontos.Rows.Add("SubTotal menos Descuento", subt - 0);
                        dgvMontos.Rows.Add("Impuesto S/Venta", isv);
                        dgvMontos.Rows.Add("Impuesto Turismo", it);
                        dgvMontos.Rows.Add("Total Impuesto", isv + it);
                        dgvMontos.Rows.Add("Total", subt + isv + it);
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }

            }
        }


        private void ShowFactura_Load(object sender, EventArgs e)
        {

            dgvDetalleFact.Columns.Add("cant.", "Cant.");
            dgvDetalleFact.Columns.Add("descripción", "Descripción");
            dgvDetalleFact.Columns.Add("p. unitario", "P. Unitario");
            dgvDetalleFact.Columns.Add("importe", "Importe");
            dgvDetalleFact.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleFact.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvMontos.Columns.Add("descripcion", "Descripcion");
            dgvMontos.Columns.Add("importe", "Importe");
            dgvMontos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvMontos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


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

                    cb_MPago.Items.Add("--Seleccione--");
                    cb_MPago.SelectedIndex = 0;
                    //Validación de la data obtenida
                    while (leer.Read())
                    {
                        cb_MPago.Items.Add(leer["DESCRIPCION"].ToString());
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
                txt_ConsExone.Enabled = false;
                txt_OCExenta.Enabled = false;
                txt_RegSar.Enabled = false;
                cb_MPago.Enabled = false;
                btnFacturar.Visible = true;
                lbl_Descuento.Visible = false;
                lbl_servicios.Visible = false;
                btnFacturar.Text = "Generar";
            }
            else if (info.est == 0)
            {
                txt_ConsExone.Enabled = true;
                txt_OCExenta.Enabled = true;
                txt_RegSar.Enabled = true;
                cb_MPago.Enabled = true;
                btnFacturar.Visible = true;
                lbl_Descuento.Visible = false;
                lbl_servicios.Visible = false;
                btnFacturar.Text = "Guardar";

            }
            else if (info.est == 2)
            {
                txt_ConsExone.Enabled = true;
                txt_OCExenta.Enabled = true;
                txt_RegSar.Enabled = true;
                cb_MPago.Enabled = true;
                btnFacturar.Visible = true;
                lbl_Descuento.Visible = true;
                lbl_servicios.Visible = true;
                btnFacturar.Text = "Facturar";
            }


            this.dgvDetalleFact.Rows.Clear();
            this.dgvMontos.Rows.Clear();
            CargarDGV();

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (info.est == 2)
            {

                try
                {
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //Consulta
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("insert into TBL_FACTURA(ID_SOLICITUDRESERVA, ID_TIPOPAGO, " +
                            "ID_USUARIO, FECHA, N_OCEXCENTA, NCONSTANCIAEXONERADO, NREGISTROSAR, SUBTOTAL, " +
                            "IMPOREXONERADO, IMPOREXCENTO, IMPORTEISV, IMPORTEALCOHOL, IMPORTETURISMO, " +
                            "IMPUESISV, IMPUESALCOHOL, IMPUESTURIMOS, TOTAL) VALUES (" + info.reserva + ", " +
                            cb_MPago.SelectedIndex + ", " + clasecompartida.iduser + ", '" + today.ToString("yyyy-MM-dd HH:mm:ss") + "', " + txt_OCExenta.Text + ", " +
                            txt_ConsExone.Text + ", " + txt_RegSar.Text + ", " + subt + ", 0, 0, " +
                            subt + ", 0, " + sth + ", " + isv + ", 0, " + it + ", " + total + ")");

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();

                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("UPDATE TBL_SOLICITUDRESERVA SET ID_ESTADORESERVA = 4 " +
                            "WHERE ID_SOLICITUDRESERVA = " + info.reserva + ";");

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();


                        if (query0 != "")
                        {
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("INSERT INTO TBL_DETALLEFACTURA (DIAS, DESCRIPCION, PRECIO, TOTAL, ID_SOLICITUDRESERVA) VALUES" +
                                query0);
                            comando.ExecuteNonQuery();
                            comando.Connection.Close();
                        }


                        if (query1 != "")
                        {
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("INSERT INTO TBL_DETALLEFACTURASERVI (CANTIDAD, DESCRIPCION, PRECIO, TOTAL, ID_SOLICITUDRESERVA) VALUES" +
                                query1);
                            comando.ExecuteNonQuery();
                            comando.Connection.Close();
                        }



                        MsgB mbox = new MsgB("informacion", "Registro Agregado");
                        DialogResult dR = mbox.ShowDialog();
                        this.Close();

                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }

            }
            else if (info.est == 1)
            {
                crearPDF();


            }
            else if (info.est == 0)
            {
                try
                {
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("UPDATE TBL_FACTURA SET ID_TIPOPAGO = " + cb_MPago.SelectedIndex +
                            " WHERE ID_SOLICITUDRESERVA = " + info.reserva + ";");

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();


                        MsgB mbox = new MsgB("informacion", "Registro Modificado");
                        DialogResult dR = mbox.ShowDialog();
                        this.Close();

                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }


            }

        }


        private void crearPDF()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyy") + ".pdf";

            string paginahtml_texto = Properties.Resources.Plantilla.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@FECHA1", info.fecha);
            paginahtml_texto = paginahtml_texto.Replace("@CLIENTE", lb_nombres.Text);
            paginahtml_texto = paginahtml_texto.Replace("@ID", lb_ID.Text);
            paginahtml_texto = paginahtml_texto.Replace("@FACTURA", info.factura);
            paginahtml_texto = paginahtml_texto.Replace("@INGRESO", lb_ingreso.Text);
            paginahtml_texto = paginahtml_texto.Replace("@SALIDA", lb_Salida.Text);
            paginahtml_texto = paginahtml_texto.Replace("@NOCHES", lb_noches.Text);

            string filas = string.Empty;

            int i = 0;
            int j = 0;
            var noches = Convert.ToDateTime(info.salida) - Convert.ToDateTime(info.ingreso);

            while (i < h)
            {
                filas += "<tr>";
                filas += "<td>1</td>";
                filas += "<td>" + ht.Rows[i]["DESCRIPCION"].ToString()+ "</td>";
                filas += "<td>" + ht.Rows[i]["PRECIO"].ToString() + "</td>";
                filas += "<td>" + Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(ht.Rows[i]["PRECIO"])) + "</td>";
                filas += "</tr>";
                i = i + 1;
            }

            while (j < s)
            {
                filas += "<tr>";
                filas += "<td>" + st.Rows[j]["CANTIDAD"].ToString() + "</td>";
                filas += "<td>" + st.Rows[j]["DESCRIPCION"].ToString() + "</td>";
                filas += "<td>" + st.Rows[j]["PRECIO"].ToString() + "</td>";
                filas += "<td>" + Convert.ToString(Convert.ToDecimal(st.Rows[j]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[j]["PRECIO"])) + "</td>";
                filas += "</tr>";
                j = j + 1;
            }

            paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);

            paginahtml_texto = paginahtml_texto.Replace("@SUBTOTAL", Convert.ToString(subt));
            paginahtml_texto = paginahtml_texto.Replace("@DESCUENTO", Convert.ToString(0));
            paginahtml_texto = paginahtml_texto.Replace("@STMD", Convert.ToString(subt));
            paginahtml_texto = paginahtml_texto.Replace("@ISV", Convert.ToString(isv));
            paginahtml_texto = paginahtml_texto.Replace("@IST", Convert.ToString(it));
            paginahtml_texto = paginahtml_texto.Replace("@TOIM", Convert.ToString(isv + it));
            paginahtml_texto = paginahtml_texto.Replace("@TOTAL", Convert.ToString(total));

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

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
                }



            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_servicios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form nuevo = new ServicioVenta();
            nuevo.ShowDialog();

            this.dgvDetalleFact.Rows.Clear();
            this.dgvMontos.Rows.Clear();
            CargarDGV();

        }
    }
}
