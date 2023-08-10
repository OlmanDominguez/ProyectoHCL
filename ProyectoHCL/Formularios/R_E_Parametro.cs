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
    public partial class R_E_Parametro : Form
    {
        public R_E_Parametro()
        {
            InitializeComponent();
        }

        public string idpar = null;
        MsgB msgB = new MsgB();

        public void limpiarCampos()
        {
            texPa.Clear();
            txtValor.Clear();
        }

        public void limpiarError()
        {
            errorp.SetError(texPa, "");
            errorp.SetError(txtValor, "");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiarCampos();
            limpiarError();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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


        private void texPar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarTxt.txtVacio(texPa))
            {
                errorp.SetError(texPa, "Introduzca un Parametro");
            }
            else
            {
                errorp.Clear();
            }
        }



        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtValor))
            {
                errorp.SetError(txtValor, "Introduzca un valor");
            }
            else
            {
                errorp.Clear();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lbPar.Text == "Registrar Roles")
            {
                Modelo modelo = new Modelo();

                if (texPa.Text.Trim() == "" || txtValor.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();

                }
                else if (modelo.existeObjeto(texPa.Text))
                {
                    MsgB m = new MsgB("advertencia", "El parametro ya existe");
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

                        cmd = new MySqlCommand("insertarParametro", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", texPa.Text);
                        cmd.Parameters.AddWithValue("@Valor", txtValor.Text);

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
            else if (lbPar.Text == "Editar Parametro")
            {
                Control control = new Control();

                if (texPa.Text.Trim() == "" || txtValor.Text.Trim() == "")//|| textPar.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        //control.editar(idpar, texPa.Text, txtValor.Text); //id,Fechamodificacion.Text

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
    }
}
