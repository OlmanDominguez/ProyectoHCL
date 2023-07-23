using DocumentFormat.OpenXml.Bibliography;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoHCL.Formularios.CtrlFacturacion;

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


            return dt;



        }

        private void ShowFactura_Load(object sender, EventArgs e)
        {
            if (info.factura == "0") //Factura nueva desde reserva
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = consulta(info.reserva, 1);

                    int n = dt.Rows.Count;


                    if (n != 0)
                    {
                        lb_nombres.Text = dt.Rows[0]["NOMBRE"].ToString();
                        lb_apellidos.Text = dt.Rows[0]["APELLIDO"].ToString();
                        lb_ID.Text = dt.Rows[0]["DNI_PASAPORTE"].ToString();
                        DateTime hoy = DateTime.Today;
                        lb_fecha.Text = Convert.ToString(hoy.Date);
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
                        }
                        else if (n == 2)
                        {
                            lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                            lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                            lb_pre1.Text = dt.Rows[0]["PRECIO"].ToString();
                            lb_sbt1.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]));
                            lb_Habi2.Text = dt.Rows[1]["NUMEROHABITACION"].ToString();
                            lb_Tipo2.Text = dt.Rows[1]["TIPO"].ToString();
                            lb_pre2.Text = dt.Rows[1]["PRECIO"].ToString();
                            lb_sbt2.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]));
                            lb_Habi3.Text = "N/A";
                            lb_Tipo3.Text = "N/A";
                            lb_pre3.Text = "N/A";
                            lb_sbt3.Text = "N/A";
                        }
                        else if (n == 3)
                        {
                            lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                            lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                            lb_pre1.Text = dt.Rows[0]["PRECIO"].ToString();
                            lb_sbt1.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]));
                            lb_Habi2.Text = dt.Rows[1]["NUMEROHABITACION"].ToString();
                            lb_Tipo2.Text = dt.Rows[1]["TIPO"].ToString();
                            lb_pre2.Text = dt.Rows[1]["PRECIO"].ToString();
                            lb_sbt2.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]));
                            lb_Habi3.Text = dt.Rows[2]["NUMEROHABITACION"].ToString();
                            lb_Tipo3.Text = dt.Rows[2]["TIPO"].ToString();
                            lb_pre3.Text = dt.Rows[2]["PRECIO"].ToString();
                            lb_sbt3.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[2]["PRECIO"]));
                        }

                        //DetalleServicios
                       /* dt = consulta(info.reserva, 3);
                        n = dt.Rows.Count;
                        if (n == 0)
                        {
                            lb_Ser1.Text = "N/A";
                            lb_Tipo1.Text = "N/A";
                            lb_pre1.Text = "N/A";
                            lb_sbt1.Text = "N/A";
                            lb_Ser2.Text = "N/A";
                            lb_Tipo2.Text = "N/A";
                            lb_pre2.Text = "N/A";
                            lb_sbt2.Text = "N/A";
                            lb_Habi3.Text = "N/A";
                            lb_Tipo3.Text = "N/A";
                            lb_pre3.Text = "N/A";
                            lb_sbt3.Text = "N/A";
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
                        }
                        else if (n == 2)
                        {
                            lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                            lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                            lb_pre1.Text = dt.Rows[0]["PRECIO"].ToString();
                            lb_sbt1.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]));
                            lb_Habi2.Text = dt.Rows[1]["NUMEROHABITACION"].ToString();
                            lb_Tipo2.Text = dt.Rows[1]["TIPO"].ToString();
                            lb_pre2.Text = dt.Rows[1]["PRECIO"].ToString();
                            lb_sbt2.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]));
                            lb_Habi3.Text = "N/A";
                            lb_Tipo3.Text = "N/A";
                            lb_pre3.Text = "N/A";
                            lb_sbt3.Text = "N/A";
                        }
                        else if (n == 3)
                        {
                            lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                            lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                            lb_pre1.Text = dt.Rows[0]["PRECIO"].ToString();
                            lb_sbt1.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[0]["PRECIO"]));
                            lb_Habi2.Text = dt.Rows[1]["NUMEROHABITACION"].ToString();
                            lb_Tipo2.Text = dt.Rows[1]["TIPO"].ToString();
                            lb_pre2.Text = dt.Rows[1]["PRECIO"].ToString();
                            lb_sbt2.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[1]["PRECIO"]));
                            lb_Habi3.Text = dt.Rows[2]["NUMEROHABITACION"].ToString();
                            lb_Tipo3.Text = dt.Rows[2]["TIPO"].ToString();
                            lb_pre3.Text = dt.Rows[2]["PRECIO"].ToString();
                            lb_sbt3.Text = Convert.ToString(Convert.ToDecimal(noches.Days) * Convert.ToDecimal(dt.Rows[2]["PRECIO"]));
                        }
                       */


                    }





                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }

            }
            else if (info.reserva == "0") //Factura solo para modificar metodo de pago
            {

            }
            else if (info.factura == "0" & info.reserva == "0") //Factura nueva de 0
            {

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
