using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office.Word;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;
using static ProyectoHCL.Formularios.CtrlFacturacion;

using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;


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

        private DataTable consulta(string param, int op)
        {
            DataTable dt = new DataTable();
            if (op == 1)
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
            else if (op == 2)
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
            else if (op == 3)
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
            else if (op == 4)
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

            return dt;

        }

        private void ShowFactura_Load(object sender, EventArgs e)
        {
            try
            {
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

            string hoy = today.ToString("dd/MM/yyyy");

            //Factura desde reserva
            if (info.reserva != "0" & info.factura == "0") 
            {


                try
                {
                    DataTable dt = new DataTable();
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
                        var noches = Convert.ToDateTime(info.salida) - Convert.ToDateTime(info.ingreso);
                        lb_noches.Text = Convert.ToString(noches.Days);


                        dt = consulta(info.reserva, 2);
                        n = dt.Rows.Count;
                        //DetalleHabitaciones

                        if (n == 0)
                        {
                            lb_Habi1.Text = "N/A";
                            lb_Tipo1.Text = "N/A";
                            lb_pre1.Text = "N/A";
                            lb_sbt1.Text = "N/A";
                            lb_Habi2.Text = "N/A";
                            lb_Tipo2.Text = "N/A";
                            lb_pre2.Text = "N/A";
                            lb_sbt2.Text = "N/A";
                            lb_Habi3.Text = "N/A";
                            lb_Tipo3.Text = "N/A";
                            lb_pre3.Text = "N/A";
                            lb_sbt3.Text = "N/A";
                            lb_StH.Text = "0.00";
                        }
                        else if (n == 1)
                        {
                            lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                            lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                            lb_pre1.Text = dt.Rows[0]["PRECIO"].ToString();
                            lb_sbt1.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]));
                            lb_Habi2.Text = "N/A";
                            lb_Tipo2.Text = "N/A";
                            lb_pre2.Text = "N/A";
                            lb_sbt2.Text = "N/A";
                            lb_Habi3.Text = "N/A";
                            lb_Tipo3.Text = "N/A";
                            lb_pre3.Text = "N/A";
                            lb_sbt3.Text = "N/A";
                            sth = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_StH.Text = Convert.ToString(sth);
                        }
                        else if (n == 2)
                        {
                            lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                            lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                            lb_pre1.Text = dt.Rows[0]["PRECIO"].ToString();
                            st1 = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_sbt1.Text = Convert.ToString(st1);
                            lb_Habi2.Text = dt.Rows[1]["NUMEROHABITACION"].ToString();
                            lb_Tipo2.Text = dt.Rows[1]["TIPO"].ToString();
                            lb_pre2.Text = dt.Rows[1]["PRECIO"].ToString();
                            st2 = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]);
                            lb_sbt2.Text = Convert.ToString(st2);
                            lb_Habi3.Text = "N/A";
                            lb_Tipo3.Text = "N/A";
                            lb_pre3.Text = "N/A";
                            lb_sbt3.Text = "N/A";
                            sth = st1 + st2;
                            lb_StH.Text = Convert.ToString(sth);
                        }
                        else if (n == 3)
                        {
                            lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                            lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                            lb_pre1.Text = dt.Rows[0]["PRECIO"].ToString();
                            st1 = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_sbt1.Text = Convert.ToString(st1);
                            lb_Habi2.Text = dt.Rows[1]["NUMEROHABITACION"].ToString();
                            lb_Tipo2.Text = dt.Rows[1]["TIPO"].ToString();
                            lb_pre2.Text = dt.Rows[1]["PRECIO"].ToString();
                            st2 = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]);
                            lb_sbt2.Text = Convert.ToString(st2);
                            lb_Habi3.Text = dt.Rows[2]["NUMEROHABITACION"].ToString();
                            lb_Tipo3.Text = dt.Rows[2]["TIPO"].ToString();
                            lb_pre3.Text = dt.Rows[2]["PRECIO"].ToString();
                            st3 = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[2]["PRECIO"]);
                            lb_sbt3.Text = Convert.ToString(st3);
                            sth = st1 + st2 + st3;
                            lb_StH.Text = Convert.ToString(sth);
                        }

                        //DetalleServicios

                        dt = consulta(info.reserva, 3);
                        n = dt.Rows.Count;
                        if (n == 0)
                        {
                            lb_Ser1.Text = "N/A";
                            lb_Ca1.Text = "N/A";
                            lb_Pr1.Text = "N/A";
                            lb_St1.Text = "N/A";
                            lb_Ser2.Text = "N/A";
                            lb_Ca2.Text = "N/A";
                            lb_Pr2.Text = "N/A";
                            lb_St2.Text = "N/A";
                            lb_Ser3.Text = "N/A";
                            lb_Ca3.Text = "N/A";
                            lb_Pr3.Text = "N/A";
                            lb_St3.Text = "N/A";
                            lb_StS.Text = "0.00";
                        }
                        else if (n == 1)
                        {
                            lb_Ser1.Text = dt.Rows[0]["DESCRIPCION"].ToString();
                            lb_Ca1.Text = dt.Rows[0]["CANTIDAD"].ToString();
                            lb_Pr1.Text = dt.Rows[0]["PRECIO"].ToString();
                            St1 = Convert.ToDecimal(dt.Rows[0]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_St1.Text = Convert.ToString(St1);
                            lb_Ser2.Text = "N/A";
                            lb_Ca2.Text = "N/A";
                            lb_Pr2.Text = "N/A";
                            lb_St2.Text = "N/A";
                            lb_Ser3.Text = "N/A";
                            lb_Ca3.Text = "N/A";
                            lb_Pr3.Text = "N/A";
                            lb_St3.Text = "N/A";
                            StS = St1;
                            lb_StS.Text = Convert.ToString(StS);
                        }
                        else if (n == 2)
                        {
                            lb_Ser1.Text = dt.Rows[0]["DESCRIPCION"].ToString();
                            lb_Ca1.Text = dt.Rows[0]["CANTIDAD"].ToString();
                            lb_Pr1.Text = dt.Rows[0]["PRECIO"].ToString();
                            St1 = Convert.ToDecimal(dt.Rows[0]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_St1.Text = Convert.ToString(St1);
                            lb_Ser2.Text = dt.Rows[1]["DESCRIPCION"].ToString();
                            lb_Ca2.Text = dt.Rows[1]["CANTIDAD"].ToString();
                            lb_Pr2.Text = dt.Rows[1]["PRECIO"].ToString();
                            St2 = Convert.ToDecimal(dt.Rows[1]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]);
                            lb_St2.Text = Convert.ToString(St2);
                            lb_Ser3.Text = "N/A";
                            lb_Ca3.Text = "N/A";
                            lb_Pr3.Text = "N/A";
                            lb_St3.Text = "N/A";
                            StS = St1 + St2;
                            lb_StS.Text = Convert.ToString(StS);
                        }
                        else if (n == 3)
                        {
                            lb_Ser1.Text = dt.Rows[0]["DESCRIPCION"].ToString();
                            lb_Ca1.Text = dt.Rows[0]["CANTIDAD"].ToString();
                            lb_Pr1.Text = dt.Rows[0]["PRECIO"].ToString();
                            St1 = Convert.ToDecimal(dt.Rows[0]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_St1.Text = Convert.ToString(St1);
                            lb_Ser2.Text = dt.Rows[1]["DESCRIPCION"].ToString();
                            lb_Ca2.Text = dt.Rows[1]["CANTIDAD"].ToString();
                            lb_Pr2.Text = dt.Rows[1]["PRECIO"].ToString();
                            St2 = Convert.ToDecimal(dt.Rows[1]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]);
                            lb_St2.Text = Convert.ToString(St2);
                            lb_Ser3.Text = dt.Rows[2]["DESCRIPCION"].ToString();
                            lb_Ca3.Text = dt.Rows[2]["CANTIDAD"].ToString();
                            lb_Pr3.Text = dt.Rows[2]["PRECIO"].ToString();
                            St3 = Convert.ToDecimal(dt.Rows[2]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[2]["PRECIO"]);
                            lb_St3.Text = Convert.ToString(St3);
                            StS = St1 + St2 + St3;
                            lb_StS.Text = Convert.ToString(StS);
                        }

                        //Datos de impuestos y totales

                        if (sth != 0.00m & StS != 0.00m)
                        {
                            isv = Decimal.Round(((sth / 1.19m) * 0.15m) + ((StS / 1.15m) * 0.15m), 2);
                            it = Decimal.Round((sth / 1.19m) * 0.04m, 2);
                            subt = Decimal.Round((sth / 1.19m) + (StS / 1.15m), 2);
                            total = Decimal.Round(isv + it + subt, 2);
                            lb_isv.Text = Convert.ToString(isv);
                            lb_it.Text = Convert.ToString(it);
                            lb_Stotal.Text = Convert.ToString(subt);
                            lb_Total.Text = Convert.ToString(total);
                        }
                        else if (sth != 0.00m & StS == 0)
                        {
                            isv = Decimal.Round((sth / 1.19m) * 0.15m);
                            it = Decimal.Round((sth / 1.19m) * 0.04m, 2);
                            subt = Decimal.Round((sth / 1.19m) + (StS / 1.15m), 2);
                            total = Decimal.Round(isv + it + subt, 2);
                            lb_isv.Text = Convert.ToString(isv);
                            lb_it.Text = Convert.ToString(it);
                            lb_Stotal.Text = Convert.ToString(subt);
                            lb_Total.Text = Convert.ToString(total);
                        }
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }

            }
            else if (info.reserva != "0" & info.factura != "0") //Factura solo para modificar metodo de pago
            {
                DataTable dt = new DataTable();
                try
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
                

                if ( info.est == 1)
                {
                    txt_ConsExone.Enabled = false;
                    txt_OCExenta.Enabled = false;
                    txt_RegSar.Enabled = false;
                    cb_MPago.Enabled = false;
                    btnFacturar.Visible = true;
                    btnFacturar.Text = "Generar";
                }
                else if (info.est == 0)
                {
                    txt_ConsExone.Enabled = true;
                    txt_OCExenta.Enabled = true;
                    txt_RegSar.Enabled = true;
                    cb_MPago.Enabled = true;
                    btnFacturar.Visible = true;
                    btnFacturar.Text = "Guardar";

                }
                else if (info.est == 2)
                {
                    txt_ConsExone.Enabled = true;
                    txt_OCExenta.Enabled = true;
                    txt_RegSar.Enabled = true;
                    cb_MPago.Enabled = true;
                    btnFacturar.Visible = true;
                    btnFacturar.Text = "Facturar";
                }

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
                        var noches = Convert.ToDateTime(info.salida) - Convert.ToDateTime(info.ingreso);
                        lb_noches.Text = Convert.ToString(noches.Days);

                        

                        dt = consulta(info.reserva, 2);
                        n = dt.Rows.Count;
                        //DetalleHabitaciones

                        if (n == 0)
                        {
                            lb_Habi1.Text = "N/A";
                            lb_Tipo1.Text = "N/A";
                            lb_pre1.Text = "N/A";
                            lb_sbt1.Text = "N/A";
                            lb_Habi2.Text = "N/A";
                            lb_Tipo2.Text = "N/A";
                            lb_pre2.Text = "N/A";
                            lb_sbt2.Text = "N/A";
                            lb_Habi3.Text = "N/A";
                            lb_Tipo3.Text = "N/A";
                            lb_pre3.Text = "N/A";
                            lb_sbt3.Text = "N/A";
                            lb_StH.Text = "0.00";
                        }
                        else if (n == 1)
                        {
                            lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                            lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                            lb_pre1.Text = dt.Rows[0]["PRECIO"].ToString();
                            lb_sbt1.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]));
                            lb_Habi2.Text = "N/A";
                            lb_Tipo2.Text = "N/A";
                            lb_pre2.Text = "N/A";
                            lb_sbt2.Text = "N/A";
                            lb_Habi3.Text = "N/A";
                            lb_Tipo3.Text = "N/A";
                            lb_pre3.Text = "N/A";
                            lb_sbt3.Text = "N/A";
                            sth = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_StH.Text = Convert.ToString(sth);
                        }
                        else if (n == 2)
                        {
                            lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                            lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                            lb_pre1.Text = dt.Rows[0]["PRECIO"].ToString();
                            st1 = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_sbt1.Text = Convert.ToString(st1);
                            lb_Habi2.Text = dt.Rows[1]["NUMEROHABITACION"].ToString();
                            lb_Tipo2.Text = dt.Rows[1]["TIPO"].ToString();
                            lb_pre2.Text = dt.Rows[1]["PRECIO"].ToString();
                            st2 = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]);
                            lb_sbt2.Text = Convert.ToString(st2);
                            lb_Habi3.Text = "N/A";
                            lb_Tipo3.Text = "N/A";
                            lb_pre3.Text = "N/A";
                            lb_sbt3.Text = "N/A";
                            sth = st1 + st2;
                            lb_StH.Text = Convert.ToString(sth);
                        }
                        else if (n == 3)
                        {
                            lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                            lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                            lb_pre1.Text = dt.Rows[0]["PRECIO"].ToString();
                            st1 = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_sbt1.Text = Convert.ToString(st1);
                            lb_Habi2.Text = dt.Rows[1]["NUMEROHABITACION"].ToString();
                            lb_Tipo2.Text = dt.Rows[1]["TIPO"].ToString();
                            lb_pre2.Text = dt.Rows[1]["PRECIO"].ToString();
                            st2 = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]);
                            lb_sbt2.Text = Convert.ToString(st2);
                            lb_Habi3.Text = dt.Rows[2]["NUMEROHABITACION"].ToString();
                            lb_Tipo3.Text = dt.Rows[2]["TIPO"].ToString();
                            lb_pre3.Text = dt.Rows[2]["PRECIO"].ToString();
                            st3 = Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[2]["PRECIO"]);
                            lb_sbt3.Text = Convert.ToString(st3);
                            sth = st1 + st2 + st3;
                            lb_StH.Text = Convert.ToString(sth);
                        }

                        //DetalleServicios

                        dt = consulta(info.reserva, 3);
                        n = dt.Rows.Count;
                        if (n == 0)
                        {
                            lb_Ser1.Text = "N/A";
                            lb_Ca1.Text = "N/A";
                            lb_Pr1.Text = "N/A";
                            lb_St1.Text = "N/A";
                            lb_Ser2.Text = "N/A";
                            lb_Ca2.Text = "N/A";
                            lb_Pr2.Text = "N/A";
                            lb_St2.Text = "N/A";
                            lb_Ser3.Text = "N/A";
                            lb_Ca3.Text = "N/A";
                            lb_Pr3.Text = "N/A";
                            lb_St3.Text = "N/A";
                            lb_StS.Text = "0.00";
                        }
                        else if (n == 1)
                        {
                            lb_Ser1.Text = dt.Rows[0]["DESCRIPCION"].ToString();
                            lb_Ca1.Text = dt.Rows[0]["CANTIDAD"].ToString();
                            lb_Pr1.Text = dt.Rows[0]["PRECIO"].ToString();
                            St1 = Convert.ToDecimal(dt.Rows[0]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_St1.Text = Convert.ToString(St1);
                            lb_Ser2.Text = "N/A";
                            lb_Ca2.Text = "N/A";
                            lb_Pr2.Text = "N/A";
                            lb_St2.Text = "N/A";
                            lb_Ser3.Text = "N/A";
                            lb_Ca3.Text = "N/A";
                            lb_Pr3.Text = "N/A";
                            lb_St3.Text = "N/A";
                            StS = St1;
                            lb_StS.Text = Convert.ToString(StS);
                        }
                        else if (n == 2)
                        {
                            lb_Ser1.Text = dt.Rows[0]["DESCRIPCION"].ToString();
                            lb_Ca1.Text = dt.Rows[0]["CANTIDAD"].ToString();
                            lb_Pr1.Text = dt.Rows[0]["PRECIO"].ToString();
                            St1 = Convert.ToDecimal(dt.Rows[0]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_St1.Text = Convert.ToString(St1);
                            lb_Ser2.Text = dt.Rows[1]["DESCRIPCION"].ToString();
                            lb_Ca2.Text = dt.Rows[1]["CANTIDAD"].ToString();
                            lb_Pr2.Text = dt.Rows[1]["PRECIO"].ToString();
                            St2 = Convert.ToDecimal(dt.Rows[1]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]);
                            lb_St2.Text = Convert.ToString(St2);
                            lb_Ser3.Text = "N/A";
                            lb_Ca3.Text = "N/A";
                            lb_Pr3.Text = "N/A";
                            lb_St3.Text = "N/A";
                            StS = St1 + St2;
                            lb_StS.Text = Convert.ToString(StS);
                        }
                        else if (n == 3)
                        {
                            lb_Ser1.Text = dt.Rows[0]["DESCRIPCION"].ToString();
                            lb_Ca1.Text = dt.Rows[0]["CANTIDAD"].ToString();
                            lb_Pr1.Text = dt.Rows[0]["PRECIO"].ToString();
                            St1 = Convert.ToDecimal(dt.Rows[0]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]);
                            lb_St1.Text = Convert.ToString(St1);
                            lb_Ser2.Text = dt.Rows[1]["DESCRIPCION"].ToString();
                            lb_Ca2.Text = dt.Rows[1]["CANTIDAD"].ToString();
                            lb_Pr2.Text = dt.Rows[1]["PRECIO"].ToString();
                            St2 = Convert.ToDecimal(dt.Rows[1]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]);
                            lb_St2.Text = Convert.ToString(St2);
                            lb_Ser3.Text = dt.Rows[2]["DESCRIPCION"].ToString();
                            lb_Ca3.Text = dt.Rows[2]["CANTIDAD"].ToString();
                            lb_Pr3.Text = dt.Rows[2]["PRECIO"].ToString();
                            St3 = Convert.ToDecimal(dt.Rows[2]["CANTIDAD"]) * Convert.ToDecimal(dt.Rows[2]["PRECIO"]);
                            lb_St3.Text = Convert.ToString(St3);
                            StS = St1 + St2 + St3;
                            lb_StS.Text = Convert.ToString(StS);
                        }

                        //Datos de impuestos y totales

                        if (sth != 0.00m & StS != 0.00m)
                        {
                            isv = Decimal.Round(((sth / 1.19m) * 0.15m) + ((StS / 1.15m) * 0.15m), 2);
                            it = Decimal.Round((sth / 1.19m) * 0.04m, 2);
                            subt = Decimal.Round((sth / 1.19m) + (StS / 1.15m), 2);
                            total = Decimal.Round(isv + it + subt, 2);
                            lb_isv.Text = Convert.ToString(isv);
                            lb_it.Text = Convert.ToString(it);
                            lb_Stotal.Text = Convert.ToString(subt);
                            lb_Total.Text = Convert.ToString(total);
                        }
                        else if (sth != 0.00m & StS == 0)
                        {
                            isv = Decimal.Round((sth / 1.19m) * 0.15m);
                            it = Decimal.Round((sth / 1.19m) * 0.04m, 2);
                            subt = Decimal.Round((sth / 1.19m) + (StS / 1.15m), 2);
                            total = Decimal.Round(isv + it + subt, 2);
                            lb_isv.Text = Convert.ToString(isv);
                            lb_it.Text = Convert.ToString(it);
                            lb_Stotal.Text = Convert.ToString(subt);
                            lb_Total.Text = Convert.ToString(total);
                        }
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }

            }
            else if (info.factura == "0" & info.reserva == "0") //Factura nueva de 0
            {

            }

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (info.est == 2) {

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
                            cb_MPago.SelectedIndex + ", 1, '" + today.ToString("yyyy-MM-dd HH:mm:ss") + "', " + txt_OCExenta.Text + ", " +
                            txt_ConsExone.Text + ", " + txt_RegSar.Text + ", " + subt + ", 0, 0, " +
                            subt + ", 0, " + sth + ", " + isv + ", 0, " + it + ", " + total + ")");

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();

                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("UPDATE TBL_SOLICITUDRESERVA SET ID_ESTADORESERVA = 4 " +
                            "WHERE ID_SOLICITUDRESERVA = " + info.reserva + ";");

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();
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
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = "Factura.pdf";


                //string paginahtml_texto = Properties.Resources.Plantilla.ToString();
                

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25,25,25,25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();

                        pdfDoc.Add(new Phrase(""));



                        /*using (StringReader sr = new StringReader(Properties.Resources.Plantilla.ToString())){
                            
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }*/

                        pdfDoc.Close();

                        stream.Close();

                    }
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
    }
}
