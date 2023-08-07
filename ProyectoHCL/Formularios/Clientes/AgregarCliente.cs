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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        MsgB msgB = new MsgB();

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
            Modelo modelo = new Modelo();
            if (VCamposVacios() == false)
            {
                MsgB mbox = new MsgB("advertencia", "Favor llene todos los campos");
                DialogResult dR = mbox.ShowDialog();
            }
            else
            {
                try
                {
                    if (modelo.existeCliente(txtID.Text))
                    {
                        MsgB mbox1 = new MsgB("advertencia", "El cliente ya existe");
                        DialogResult dR1 = mbox1.ShowDialog();
                    }
                    int tip = 0;
                    string nombre;
                    if (txtEmpresa.Text.Trim() == "") { txtEmpresa.Text = "N/A"; }
                    if (txtRTN.Text.Trim() == "") { txtRTN.Text = "N/A"; }
                    if (txtTele2.Text.Trim() == "") { txtTele2.Text = "N/A"; }
                    if (txtEmail2.Text.Trim() == "") { txtEmail2.Text = "N/A"; }
                    if (cbTipo.SelectedItem.ToString() == "Juridico") { tip = 2; } else { tip = 1; }

                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand("insert into TBL_CLIENTE (NOMBRE, APELLIDO, DNI_PASAPORTE, " +
                        "ID_TIPOCLIENTE, NOMBRE_RTN, RTN, TELEFONO, EMAIL, TELEFONO2, EMAIL2)" +
                        "values ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtID.Text + "', " +
                        tip + ", '" + txtEmpresa.Text + "', '" + txtRTN.Text + "', '" + txtTele1.Text + "', '" +
                        txtEmail1.Text + "', '" + txtTele2.Text + "', '" + txtEmail2.Text + "');", conn);

                    cmd.ExecuteNonQuery();
                    MsgB mbox = new MsgB("informacion", "Cliente Agregado");
                    DialogResult dR = mbox.ShowDialog();
                    conn.Close();
                    this.Close();


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

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Add("--Seleccione--");
            cbTipo.SelectedIndex = 0;
            cbTipo.Items.Add("Juridico");
            cbTipo.Items.Add("Natural");
        }
    }
}
