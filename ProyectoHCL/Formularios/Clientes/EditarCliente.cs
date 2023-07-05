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
using ProyectoHCL.Formularios;

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
                        string tipoCl = (string)leer["DESCRIPCION"];
                        txtEmpresa.Text = (string)leer["NOMBRE_RTN"];
                        txtRTN.Text = (string)leer["RTN"];
                        comando.Connection.Close();

                        cbTipo.Items.Add(tipoCl);
                        cbTipo.SelectedIndex = 0;
                        if (tipoCl == "Natural")
                        {
                            cbTipo.Items.Add("Juridico");
                        }
                        else
                        {
                            cbTipo.Items.Add("Natural");
                        }


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

        private void cbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedItem.ToString() == "Natural")
            {
                gb_juridico.Visible = false;
            }
            else if (cbTipo.SelectedItem.ToString() == "Juridico")
            {
                gb_juridico.Visible = true;
            }
        }

        Control control = new Control();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VCamposVacios() == false)
            {
                MessageBox.Show("Por favor llene todos los campos", "Aviso",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int tip = 0;
                    string nombre;
                    if (txtEmpresa.Text.Trim() == "") { txtEmpresa.Text = "N/A"; }
                    if (txtRTN.Text.Trim() == "") { txtRTN.Text = "N/A"; }
                    if (txtTele2.Text.Trim() == "") { txtTele2.Text = "N/A"; }
                    if (txtEmail2.Text.Trim() == "") { txtEmail2.Text = "N/A"; }
                    if (cbTipo.SelectedItem.ToString() == "Juridico"){ tip = 2; } else { tip = 1; }
                    control.editarClie(txtNombre.Text, tip, txtApellido.Text, txtEmpresa.Text,
                        txtRTN.Text, txtTele1.Text, txtEmail1.Text, Convert.ToInt32(claseCod.codigo),
                        txtID.Text, txtTele2.Text, txtEmail2.Text);
                    MessageBox.Show("Cliente modificado");
                    this.Close();
                    //admonObjeto.MostrarObjetos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private bool VCamposVacios()
        {
            bool ok = true;

            if (txtNombre.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtNombre, "Introduzca el nombre del cliente");
            }
            else
            {
                errorT.Clear();
            }

            if (txtApellido.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtApellido, "Introduzca el apellido del cliente");
            }
            else
            {
                errorT.Clear();
            }

            if (txtID.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtID, "Indroduzca el numero de identificación");
            }
            else
            {
                errorT.Clear();
            }
            if (txtEmail1.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtEmail1, "Indroduzca correo electronico");
            }
            else
            {
                errorT.Clear();
            }
            if (txtTele1.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtTele1, "Indroduzca numero telefonico");
            }
            else
            {
                errorT.Clear();
            }
            if (cbTipo.SelectedItem.ToString() == "Juridico")
            {
                if (txtRTN.Text.Trim() == "")
                {
                    ok = false;
                    errorT.SetError(txtRTN, "Indroduzca RTN");
                }
                else
                {
                    errorT.Clear();
                }
                if (txtEmpresa.Text.Trim() == "")
                {
                    ok = false;
                    errorT.SetError(txtEmpresa, "Indroduzca el nombre de la empresa");
                }
                else
                {
                    errorT.Clear();
                }

            }

            return ok;

        }


    }
}
