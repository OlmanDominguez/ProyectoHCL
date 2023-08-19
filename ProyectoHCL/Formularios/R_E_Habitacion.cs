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
    public partial class R_E_Habitacion : Form
    {
        public R_E_Habitacion()
        {
            InitializeComponent();
            cargarTipos();
            cmbTipo.SelectedIndex = -1;
        }

        public string idH = null;
        MsgB msgB = new MsgB();

        private void cargarTipos()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            cmbTipo.DataSource = null;
            cmbTipo.Items.Clear();
            string sql = "SELECT ID_TIPOHABITACION, TIPO FROM TBL_TIPOHABITACION;";

            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            try
            {
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cmbTipo.ValueMember = "ID_TIPOHABITACION";
                cmbTipo.DisplayMember = "TIPO";
                cmbTipo.DataSource = dt;

            }
            catch (MySqlException e)
            {
                MsgB m = new MsgB("Error", "Se produjo un error " + e.Message);
                DialogResult dR = m.ShowDialog();
            }
            finally { conn.Close(); }

        }

        public void limpiarCampos()
        {
            cmbTipo.SelectedIndex = -1;
            txtNumero.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError()
        {
            errorT.SetError(cmbTipo, "");
            errorT.SetError(txtNumero, "");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Registrar Habitación")
            {
                Modelo modelo = new Modelo();

                if (cmbTipo.Text.Trim() == "" || txtNumero.Text.Trim() == "" || cmbEstado.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else if (modelo.existeHabitacion(txtNumero.Text))
                {
                    MsgB m = new MsgB("advertencia", "El número de habitación ya existe");
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

                        cmd = new MySqlCommand("insertHabitacion", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tipo", cmbTipo.Text);
                        cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
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
            else if (lblTitulo.Text == "Editar Habitación")
            {
                Control control = new Control();

                if (cmbTipo.Text.Trim() == "" || txtNumero.Text.Trim() == "" || cmbEstado.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        control.editarHab(idH, cmbTipo.Text, txtNumero.Text, cmbEstado.Text);

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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtNumeros(e);
        }

        private void cmbTipo_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.cmbVacio(cmbTipo))
            {
                errorT.SetError(cmbTipo, "Seleccione un tipo de habitación");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtNumero))
            {
                errorT.SetError(txtNumero, "Introduzca un número de habitación");
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
