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

namespace ProyectoHCL.Formularios.Clientes
{
    public partial class UpdateCliente : Form
    {
        public UpdateCliente()
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
                        txt_nombre.Text = (string)resultado["NOMBRE"];
                        txt_apellido.Text = (string)resultado["APELLIDO"];
                        txt_identificacion.Text = (string)resultado["DNI_PASAPORTE"];
                        txt_tipo.Text = (string)resultado["DESCRIPCION"];
                        txt_empresa.Text = (string)resultado["NOMBRE_RTN"];
                        txt_rtn.Text = (string)resultado["RTN"];
                        txt_email.Text = (string)resultado["EMAIL"];
                        txt_telefono.Text = (string)resultado["TELEFONO"];
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

        private void UpdateCliente_Load(object sender, EventArgs e)
        {
            info(compartida.id);
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Conexion y comando
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("UPDATE TBL_CLIENTE SET NOMBRE = '"
                        + txt_nombre.Text + "', APELLIDO = '"+ txt_apellido.Text +
                        "', DNI_PASAPORTE = '" + txt_identificacion.Text + "', NOMBRE_RTN = '" +
                        txt_empresa.Text + "', RTN = '" + txt_rtn.Text + "', TELEFONO = '" + 
                        txt_telefono.Text + "', EMAIL = '" + txt_email.Text + "' where DNI_PASAPORTE = '" +
                        compartida.id + "'");

                    comando.ExecuteNonQuery();
                    comando.Connection.Close();
                    MessageBox.Show("Datos Actualizados");
                    comando.Connection.Close();
                    this.Close();

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }
        }
    }
}
