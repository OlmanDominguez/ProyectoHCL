using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
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
    public partial class R_E_Objeto : Form
    {
        public R_E_Objeto()
        {
            InitializeComponent();
        }

        public string idObj = null;

        MsgB msgB = new MsgB();

        public void limpiarCampos()
        {
            txtObj.Clear();
            rTxtDesc.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError()
        {
            errorT.SetError(txtObj, "");
            errorT.SetError(rTxtDesc, "");
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

        private void txtObj_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtObj))
            {
                errorT.SetError(txtObj, "Introduzca un nombre");
            }
            else
            {
                errorT.Clear();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Registrar Objeto")
            {
                Modelo modelo = new Modelo();

                if (txtObj.Text.Trim() == "" || rTxtDesc.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();

                }
                else if (modelo.existeObjeto(txtObj.Text))
                {
                    MsgB m = new MsgB("advertencia", "El objeto ya existe");
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

                        cmd = new MySqlCommand("insertarObjeto", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombreObj", txtObj.Text);
                        cmd.Parameters.AddWithValue("@descObj", rTxtDesc.Text);
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
            else if (lblTitulo.Text == "Editar Objeto")
            {
                Control control = new Control();

                if (txtObj.Text.Trim() == "" || cmbEstado.Text.Trim() == "" || rTxtDesc.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        control.editarObj(idObj, txtObj.Text, rTxtDesc.Text, cmbEstado.Text, clasecompartida.iduser.ToString());

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

        private void rTxtDesc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void rTxtDesc_Leave_1(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(rTxtDesc))
            {
                errorT.SetError(rTxtDesc, "Introduzca una descripción");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtObj_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rTxtDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
