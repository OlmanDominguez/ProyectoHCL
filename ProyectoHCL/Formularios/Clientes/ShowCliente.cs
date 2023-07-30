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
using static ProyectoHCL.Formularios.CtrlClientes;

namespace ProyectoHCL.Formularios
{
    public partial class ShowCliente : Form
    {
        public ShowCliente()
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

        private void ShowCliente_Load(object sender, EventArgs e)
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select * from TBL_CLIENTE WHERE CODIGO = " + claseCod.codigo +
                        "");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        lb_nombres.Text = (string)leer["NOMBRE"];
                        lb_apellidos.Text = (string)leer["APELLIDO"];
                        lb_ID.Text = (string)leer["DNI_PASAPORTE"];
                        lb_email1.Text = (string)leer["EMAIL"];
                        lb_email2.Text = (string)leer["EMAIL2"];
                        lb_Empresa.Text = (string)leer["NOMBRE_RTN"];
                        lb_RTN.Text = (string)leer["RTN"];
                        lb_Tele1.Text = (string)leer["TELEFONO"];
                        lb_Tele2.Text = (string)leer["TELEFONO2"];
                    }


                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }
        }


    }
}
