using MySql.Data.MySqlClient;
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
    public partial class EditarHabitacion : Form
    {
        public string idH = null;

        public EditarHabitacion()
        {
            InitializeComponent();
            cargarTipos();
        }

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

                MessageBox.Show("Se produjo un error " + e.Message);
            }
            finally { conn.Close(); }

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private bool VCamposVacios()
        {
            bool ok = true;

            if (cmbTipo.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(cmbTipo, "Seleccione un tipo de habitación");
            }
            else
            {
                errorT.Clear();
            }

            if (txtNumero.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtNumero, "Introduzca un número de habitación");
            }
            else
            {
                errorT.Clear();
            }

            if (cmbEstado.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(cmbEstado, "Seleccione un estado");
            }
            else
            {
                errorT.Clear();
            }

            return ok;

        }

        public void limpiarCampos()
        {
            cmbTipo.Text = "";
            txtNumero.Clear();
            cmbEstado.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Control control = new Control();

            if (VCamposVacios() == false)
            {
                MessageBox.Show("Por favor llene todos los campos", "Aviso",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    control.editarHab(idH, cmbTipo.Text, txtNumero.Text, cmbEstado.Text);

                    MessageBox.Show("Habitación modificada");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        //private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) **Validar campos letras o numeros
        //{
        //    ValidarTxt.TxtLetras(e);
        //}
    }
}
