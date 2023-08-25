using DocumentFormat.OpenXml.Drawing.Diagrams;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static ProyectoHCL.RecuContra; //Para uso del user y IDUser iniciado

namespace ProyectoHCL.Formularios
{
    public partial class R_E_Usuario : Form
    {
        public R_E_Usuario()
        {
            InitializeComponent();
            cargarEstado();
            cargarRoles();
            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }

        public string idUs = null;
        MsgB msgB = new MsgB();

        private void cargarRoles()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            cmbRol.DataSource = null;
            cmbRol.Items.Clear();
            string sql = "SELECT ID_ROL, ROL FROM TBL_ROL;";

            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            try
            {
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cmbRol.ValueMember = "ID_ROL";
                cmbRol.DisplayMember = "ROL";
                cmbRol.DataSource = dt;

            }
            catch (MySqlException e)
            {
                MsgB m = new MsgB("Error", "Se produjo un error " + e.Message);
                DialogResult dR = m.ShowDialog();
            }
            finally { conn.Close(); }

        }

        public string Pass()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = BaseDatosHCL.ObtenerConexion();
            comando.CommandText = ("SELECT CONTRASENA FROM TBL_USUARIO WHERE USUARIO = '"
                + txtUsuario.Text + "';");

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                return (string)leer["CONTRASENA"];
            }
            else
            {
                return null;
            }
        }

        private void cargarEstado()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmbEstado.DataSource = null;
            cmbEstado.Items.Clear();
            string sql = "SELECT DESCRIPCION FROM TBL_ESTADO;";

            try
            {
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string nombreEstado = dr["DESCRIPCION"].ToString();

                    if (nombreEstado != "NUEVO")
                    {
                        cmbEstado.Items.Add(nombreEstado);
                    }
                }

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
            txtNombre.Clear();
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtCorreo.Clear();
            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError()
        {
            errorT.SetError(txtNombre, "");
            errorT.SetError(txtContraseña, "");
            errorT.SetError(txtUsuario, "");
            errorT.SetError(txtCorreo, "");
            errorT.SetError(cmbRol, "");
            errorT.SetError(cmbEstado, "");
            errorT.SetError(dtpVencimiento, "");
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
            ValidarTxt.TxtLetras(e);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MsgB m = new MsgB("advertencia", "No se permiten espacios");
                DialogResult dR = m.ShowDialog();
            }
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Registrar Usuario")
            {
                Modelo modelo = new Modelo();

                if (txtNombre.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || txtContraseña.Text.Trim() == "" ||
                    cmbRol.Text.Trim() == "" || txtCorreo.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else if (modelo.existeUsuario(txtUsuario.Text))
                {
                    MsgB m = new MsgB("advertencia", "El usuario ya existe");
                    DialogResult dR = m.ShowDialog();
                }
                else if (DateTime.Today > dtpVencimiento.Value)
                {
                    MsgB m = new MsgB("advertencia", "La fecha de vencimiento seleccionada no es válida");
                    DialogResult dR = m.ShowDialog();
                }
                else if (!ValidarTxt.CorreoValido(txtCorreo.Text))
                {
                    MsgB m = new MsgB("advertencia", "Dirección de correo no válida");
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtContraseña.TextLength < 5)
                {
                    MsgB m = new MsgB("advertencia", "La contraseña es muy corta");
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

                        cmd = new MySqlCommand("InsertarUsuarios", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@estado", "NUEVO");
                        cmd.Parameters.AddWithValue("@rol", cmbRol.Text);
                        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtContraseña.Text);
                        cmd.Parameters.AddWithValue("@primerIngreso", Convert.ToDateTime(txtFechaC.Text));
                        cmd.Parameters.AddWithValue("@vencimiento", Convert.ToDateTime(dtpVencimiento.Text));
                        cmd.Parameters.AddWithValue("@email", txtCorreo.Text);

                        cmd.ExecuteNonQuery();

                        string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        conn.Close();
                        string sql = "INSERT INTO TBL_BITACORA (ID_USUARIO, ID_OBJETO, FECHA, ACCION, DESCRIPCION) VALUES " +
                            "('" + clasecompartida.iduser + "', '4', '" + ahora + "', 'CREACION', 'CREACION USUARIO " +
                            txtUsuario.Text + "');";
                        conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                        conn.Open();

                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

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
            else if (lblTitulo.Text == "Editar Usuario")
            {
                Control control = new Control();

                if (txtNombre.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || cmbRol.Text.Trim() == "" ||
                    txtCorreo.Text.Trim() == "" || cmbEstado.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else if (DateTime.Today > dtpVencimiento.Value)
                {
                    MsgB m = new MsgB("advertencia", "La fecha de vencimiento seleccionada no es válida");
                    DialogResult dR = m.ShowDialog();
                }
                else if (!ValidarTxt.CorreoValido(txtCorreo.Text))
                {
                    MsgB m = new MsgB("advertencia", "Dirección de correo no válida");
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtContraseña.TextLength < 5 && txtContraseña.Text != "")
                {
                    MsgB m = new MsgB("advertencia", "La contraseña es muy corta");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        if (txtContraseña.Text == "")
                        {
                            control.editarUs(idUs, cmbEstado.Text, cmbRol.Text, txtUsuario.Text, txtNombre.Text,
                            Pass(), dtpVencimiento.Text, txtCorreo.Text);
                        }
                        else{

                           control.editarUs(idUs, cmbEstado.Text, cmbRol.Text, txtUsuario.Text, txtNombre.Text,
                           txtContraseña.Text, dtpVencimiento.Text, txtCorreo.Text);
                        }
                        string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        MySqlConnection conn;
                        MySqlCommand cmd;

                        string sql = "INSERT INTO TBL_BITACORA (ID_USUARIO, ID_OBJETO, FECHA, ACCION, DESCRIPCION) VALUES " +
                            "('" + clasecompartida.iduser + "', '4', '" + ahora + "', 'EDICION', 'EDICION USUARIO " +
                            idUs + " " + txtUsuario.Text + "');";
                        conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                        conn.Open();

                        cmd = new MySqlCommand(sql, conn);
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

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (!ValidarTxt.CorreoValido(txtCorreo.Text))
            {
                errorT.SetError(txtCorreo, "Dirección de correo no válida");
                dtpVencimiento.Focus();
            }
            else
            {
                errorT.Clear();

            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.TextLength < 5)
            {
                errorT.SetError(txtContraseña, "La contraseña es muy corta");
                txtContraseña.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtUsuario))
            {
                errorT.SetError(txtUsuario, "Introduzca un usuario");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.txtVacio(txtNombre))
            {
                errorT.SetError(txtNombre, "Introduzca un nombre");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void cmbEstado2_Leave(object sender, EventArgs e)
        {
        }

        private void cmbRol_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.cmbVacio(cmbRol))
            {
                errorT.SetError(cmbRol, "Seleccione un rol");
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

        private void OcultarBox4_Click(object sender, EventArgs e)
        {
            MostrarBox3.BringToFront();
            txtContraseña.PasswordChar = '*';
        }

        private void MostrarBox3_Click(object sender, EventArgs e)
        {
            OcultarBox4.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void dtpVencimiento_Leave(object sender, EventArgs e)
        {
            if (DateTime.Today > dtpVencimiento.Value)
            {
                errorT.SetError(dtpVencimiento, "Fecha no válida, seleccione una fecha futura");
                dtpVencimiento.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MsgB m = new MsgB("advertencia", "No se permiten espacios");
                DialogResult dR = m.ShowDialog();
            }
        }
    }
}
