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
using static ProyectoHCL.Formularios.Cliente;

namespace ProyectoHCL.Formularios
{
    public partial class InfoCliente : Form
    {
        public InfoCliente()
        {
            InitializeComponent();
        }

        private void info(string id)
        {
            try
            {

                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select  c.NOMBRE, c.APELLIDO, c.DNI_PASAPORTE, " +
                        "t.descripcion, c.TELEFONO, c.EMAIL, c.NOMBRE_RTN, c.RTN from TBL_CLIENTE c " +
                        "inner join TBL_TIPOCLIENTE t on c.ID_TIPOCLIENTE = t.ID_TIPOCLIENTE " +
                        "where c.DNI_PASAPORTE = " + id);

                    MySqlDataReader resultado = comando.ExecuteReader();

                    //Validación de la data obtenida
                    if (resultado.Read() == true)
                    {
                        l_nombre.Text = (string)resultado["NOMBRE"] + " " + (string)resultado["APELLIDO"];
                        l_identificacion.Text = (string)resultado["DNI_PASAPORTE"];
                        l_tipo.Text = (string)resultado["DESCRIPCION"];
                        l_empresa.Text = (string)resultado["NOMBRE_RTN"];
                        l_rtn.Text = (string)resultado["RTN"];
                        l_email.Text = (string)resultado["EMAIL"];
                        l_telefono.Text = (string)resultado["TELEFONO"];
                    }
                    else
                    {
                        MessageBox.Show("No se encuentran datos");
                    }
                    comando.Connection.Close();
                }

            }

            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void InfoCliente_Load(object sender, EventArgs e)
        {
            info(compartida.id);
        }
    }
}
