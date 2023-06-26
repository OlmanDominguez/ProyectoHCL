using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {

                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("DELETE FROM TBL_CLIENTE WHERE DNI_PASAPORTE = '" + 
                        compartida.id + "'");

                    comando.ExecuteNonQuery();
                    comando.Connection.Close();
                    MessageBox.Show("Datos Eliminados");
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
