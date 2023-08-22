using DocumentFormat.OpenXml.Office.Word;
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
using static ProyectoHCL.RecuContra;

namespace ProyectoHCL.Formularios
{
    public partial class R_E_Descuento : Form
    {
        public R_E_Descuento()
        {
            InitializeComponent();
            txtPorcentaje.KeyPress += txtPorcentaje_KeyPress;
        }

        public string idDesc = null;
        MsgB msgB = new MsgB();

        public void limpiarCampos()
        {
            txtPorcentaje.Clear();
            txtDesc.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError()
        {
            errorT.SetError(txtPorcentaje, "");
            errorT.SetError(txtDesc, "");
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

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtDesc))
            {
                errorT.SetError(txtDesc, "Introduzca un nombre");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtPorcentaje_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtPorcentaje))
            {
                errorT.SetError(txtPorcentaje, "Introduzca un porcentaje");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Registrar Descuento")
            {
                Modelo modelo = new Modelo();

                if (txtDesc.Text.Trim() == "" || txtPorcentaje.Text.Trim() == "" || cmbEstado.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();

                }
                else if (modelo.existeDescuento(txtDesc.Text))
                {
                    MsgB m = new MsgB("advertencia", "El descuento ya existe");
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

                        cmd = new MySqlCommand("insertDescuento", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descripcion", txtDesc.Text);
                        cmd.Parameters.AddWithValue("@porcentaje", txtPorcentaje.Text);
                        cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);
                        cmd.Parameters.AddWithValue("@creadoPor", clasecompartida.iduser);
                        cmd.Parameters.AddWithValue("@actualizadoPor", clasecompartida.iduser);

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
            else if (lblTitulo.Text == "Editar Descuento")
            {
                Control control = new Control();

                if (txtDesc.Text.Trim() == "" || txtPorcentaje.Text.Trim() == "" || cmbEstado.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        control.editarDesc(idDesc, txtDesc.Text, txtPorcentaje.Text, cmbEstado.Text, clasecompartida.iduser.ToString());

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
