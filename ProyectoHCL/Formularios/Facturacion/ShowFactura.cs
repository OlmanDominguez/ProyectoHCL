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



        private void ShowFactura_Load(object sender, EventArgs e)
        {
            try
            {
                string stri = "SELECT f.NFACTURA, c.NOMBRE, c.APELLIDO, c.DNI_PASAPORTE, f.FECHA, s.INGRESO, " +
                       "s.SALIDA, s.NHUESPEDES, h.NUMEROHABITACION, th.TIPO, f.TOTAL FROM TBL_FACTURA f " +
                       "INNER JOIN TBL_SOLICITUDRESERVA s ON f.ID_SOLICITUDRESERVA = s.ID_SOLICITUDRESERVA " +
                       "INNER JOIN TBL_CLIENTE c ON s.COD_CLIENTE = c.CODIGO " +
                       "INNER JOIN TBL_DETALLERESERVA dr ON s.ID_SOLICITUDRESERVA = dr.ID_SOLICITUDRESERVA " +
                       "INNER JOIN TBL_HABITACION h on dr.ID_HABITACION = h.ID_HABITACION " +
                       "INNER JOIN TBL_TIPOHABITACION th on h.ID_TIPOHABITACION = th.ID_TIPOHABITACION " +
                       "WHERE f.NFACTURA = " + numFact.factura + ";";


                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(stri, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lb_nombres.Text = dt.Rows[0]["NOMBRE"].ToString();
                lb_apellidos.Text = dt.Rows[0]["APELLIDO"].ToString();
                lb_ID.Text = dt.Rows[0]["DNI_PASAPORTE"].ToString();
                lb_fecha.Text = numFact.fecha;
                lb_ingreso.Text = numFact.ingreso;
                lb_Salida.Text = numFact.salida;
                lb_huespedes.Text = dt.Rows[0]["NHUESPEDES"].ToString();
                int n = dt.Rows.Count;
                if (n== 1)
                {
                    lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                    lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                }
                else if (n == 2)
                {
                    lb_Habi1.Text = dt.Rows[0]["NUMEROHABITACION"].ToString();
                    lb_Tipo1.Text = dt.Rows[0]["TIPO"].ToString();
                    lb_Habi2.Text = dt.Rows[1]["NUMEROHABITACION"].ToString();
                    lb_Tipo2.Text = dt.Rows[1]["TIPO"].ToString();
                }


                //Consulta
                /* MySqlCommand comando = new MySqlCommand();
                     comando.Connection = BaseDatosHCL.ObtenerConexion();
                     comando.CommandText = ("SELECT f.NFACTURA, c.NOMBRE, c.APELLIDO, c.DNI_PASAPORTE, f.FECHA, s.INGRESO, " +
                        "s.SALIDA, s.NHUESPEDES, h.NUMEROHABITACION, th.TIPO, f.TOTAL FROM TBL_FACTURA f " +
                        "INNER JOIN TBL_SOLICITUDRESERVA s ON f.ID_SOLICITUDRESERVA = s.ID_SOLICITUDRESERVA " +
                        "INNER JOIN TBL_CLIENTE c ON s.COD_CLIENTE = c.CODIGO " +
                        "INNER JOIN TBL_DETALLERESERVA dr ON s.ID_SOLICITUDRESERVA = dr.ID_SOLICITUDRESERVA " +
                        "INNER JOIN TBL_HABITACION h on dr.ID_HABITACION = h.ID_HABITACION " +
                        "INNER JOIN TBL_TIPOHABITACION th on h.ID_TIPOHABITACION = th.ID_TIPOHABITACION " +
                        "WHERE f.NFACTURA = " + numFact.factura + ";");

                     MySqlDataReader leer = comando.ExecuteReader();
                     if (leer.Read())
                     {
                         lb_nombres.Text = (string)leer["NOMBRE"];
                         lb_apellidos.Text = (string)leer["APELLIDO"];
                         lb_ID.Text = (string)leer["DNI_PASAPORTE"];
                         lb_fecha.Text = numFact.fecha;
                         lb_ingreso.Text = numFact.ingreso;
                         lb_Salida.Text = numFact.salida;
                         lb_huespedes.Text = leer["NHUESPEDES"].ToString();

                         List<string> habi = new List<String>();

                         while (leer.Read())
                         {


                         }


                     }*/




            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }
        }


    }
}
