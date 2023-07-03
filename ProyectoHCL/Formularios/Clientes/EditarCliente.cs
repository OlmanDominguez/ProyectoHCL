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
    public partial class EditarCliente : Form
    {
        public EditarCliente()
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

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("SELECT C.NOMBRE, C.APELLIDO, C.DNI_PASAPORTE, C.TELEFONO," +
                        " C.TELEFONO2, C.EMAIL, C.EMAIL2, C.RTN, C.NOMBRE_RTN, T.DESCRIPCION " +
                        "FROM TBL_CLIENTE C INNER JOIN TBL_TIPOCLIENTE T ON C.ID_TIPOCLIENTE = " +
                        "T.ID_TIPOCLIENTE WHERE C.CODIGO = " + claseCod.codigo);

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        txtNombre.Text = (string)leer["NOMBRE"];
                        txtApellido.Text = (string)leer["APELLIDO"];
                        txtID.Text = (string)leer["DNI_PASAPORTE"];
                        txtEmail1.Text = (string)leer["EMAIL"];
                        txtEmail2.Text = (string)leer["EMAIL2"];
                        txtTele1.Text = (string)leer["TELEFONO"];
                        txtTele2.Text = (string)leer["TELEFONO2"];
                        cbTipo.Text = (string)leer["DESCRIPCION"];
                        //txtEmpresa.Text = (string)leer["NOMBRE_RTN"];
                        //lb_RTN.Text = (string)leer["RTN"];
                    }


                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
