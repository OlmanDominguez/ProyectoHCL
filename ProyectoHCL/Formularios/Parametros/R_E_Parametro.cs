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
using static ProyectoHCL.Formularios.Parametros.CtrlParametro;
using static ProyectoHCL.RecuContra;

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
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (Char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MsgB m = new MsgB("advertencia", "Por favor, sólo ingrese letras");
                DialogResult dR = m.ShowDialog();
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
            if (parame.p == 2)
            {
                Modelo modelo = new Modelo();

                if (texPa.Text.Trim() == "" || txtValor.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();

                }
                else if (modelo.existeParametro(texPa.Text))
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
                        cmd.Parameters.AddWithValue("@parametro", texPa.Text);
                        cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                        cmd.Parameters.AddWithValue("@idusuario", clasecompartida.iduser);
                        string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        cmd.Parameters.AddWithValue("@fecha", ahora);

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        string sql = "INSERT INTO TBL_BITACORA (ID_USUARIO, ID_OBJETO, FECHA, ACCION, DESCRIPCION) VALUES " +
                        "('" + clasecompartida.iduser + "', '13', '" + ahora + "', 'CREACIÓN', 'CREACIÓN PARÁMETRO " +
                        texPa.Text /*+ " " + txtValor.Text*/ + "');";
                        conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                        conn.Open();

                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MsgB m = new MsgB("informacion", "Registro creado con éxito");
                        DialogResult dR = m.ShowDialog();
                        limpiarCampos();

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MsgB m = new MsgB("Error: ", ex.Message);
                        DialogResult dR = m.ShowDialog();
                    }
                }
            }
            else if (parame.p == 1)
            {
                string nuevoParametro = texPa.Text;
                string nuevoValor = txtValor.Text;
                Control control = new Control();
                string idRegistro = idpar;
                Modelo modelo = new Modelo();

                if (texPa.Text.Trim() == "" || txtValor.Text.Trim() == "")//|| textPar.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                /* else if (modelo.ParametroEditarBD(nuevoParametro, idRegistro))
                 {
                     MsgB m = new MsgB("advertencia", "El usuario ya está registrado");
                     DialogResult dR = m.ShowDialog();
                 }*/
                else
                {
                    try
                    {
                        MySqlConnection conn;
                        MySqlCommand cmd;
                        conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                        conn.Open();

                        cmd = new MySqlCommand("UpdateParametro", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@parametro", texPa.Text);
                        cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                        cmd.Parameters.AddWithValue("@idusuario", clasecompartida.iduser);
                        string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        cmd.Parameters.AddWithValue("@fecha", ahora);
                        cmd.Parameters.AddWithValue("@id", parame.idparametro);

                        cmd.ExecuteNonQuery();
                        conn.Close();

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

        private void R_E_Parametro_Load(object sender, EventArgs e)
        {
            if (parame.p == 1)
            {
                txtValor.Text = parame.valor;
                texPa.Text = parame.parametro;
            }
            else if (parame.p == 2)
            {
                limpiarCampos();
                limpiarError();
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
