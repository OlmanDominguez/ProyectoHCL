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

namespace ProyectoHCL.Formularios
{
    public partial class R_E_Servicio : Form
    {
        public R_E_Servicio()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = -1;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
        }

        public string idS = null;
        MsgB msgB = new MsgB();

        public void limpiarCampos()
        {
            txtServ.Clear();
            txtPrecio.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError()
        {
            errorT.SetError(txtServ, "");
            errorT.SetError(txtPrecio, "");
            errorT.SetError(cmbEstado, "");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiarCampos();
            limpiarError();
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
            limpiarCampos();
            limpiarError();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtServ_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtServ))
            {
                errorT.SetError(txtServ, "Introduzca un nombre");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtPrecio))
            {
                errorT.SetError(txtPrecio, "Introduzca un precio");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Registrar Servicio")
            {
                Modelo modelo = new Modelo();

                if (txtServ.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || cmbEstado.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();

                }
                else if (modelo.existeServicio(txtServ.Text))
                {
                    MsgB m = new MsgB("advertencia", "El servicio ya existe");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        MySqlConnection conn;
                        MySqlCommand cmd;
                        conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                        conn.Open();

                        cmd = new MySqlCommand("insertServicio", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descripcion", txtServ.Text);
                        cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
                        cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);

                        cmd.ExecuteNonQuery();
                        MsgB m = new MsgB("informacion", "Registro creado con éxito");
                        DialogResult dR = m.ShowDialog();
                        limpiarCampos();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MsgB m = new MsgB("Error: ", ex.Message);
                        DialogResult dR = m.ShowDialog();
                    }
                }
            }
            else if (lblTitulo.Text == "Editar Servicio")
            {
                Control control = new Control();

                if (txtServ.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || cmbEstado.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        control.editarServ(idS, txtServ.Text, txtPrecio.Text, cmbEstado.Text);

                        MsgB m = new MsgB("informacion", "Registro modificado");
                        DialogResult dR = m.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MsgB m = new MsgB("Error: ", ex.Message);
                        DialogResult dR = m.ShowDialog();
                    }
                }
            }
        }

        private void cmbEstado_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.cmbVacio(cmbEstado))
            {
                errorT.SetError(cmbEstado, "Seleccione un estado");
            }
            else
            {
                errorT.Clear();
            }
        }
    }
}
