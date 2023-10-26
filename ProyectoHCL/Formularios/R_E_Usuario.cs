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

//-----------------------------------------------------------------------
//    Universidad Nacional Autonoma de Honduras (UNAH)
//		Facultad de Ciencias Economicas
//	Departamento de Informatica administrativa
//         Analisis, Programacion y Evaluacion de Sistemas
//                    Tercer Periodo 2023


//Equipo:
//GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

//HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

//NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

//JOEL ENRIQUE GODOY BONILLA---------(joel.bonilla@unah.hn)

//OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

//Catedratico analisis y diseño:             Lic.Giancarlo Martini Scalici Aguilar 
//catedratico programacion e implementacion: Lic.Karla Melisa Garcia Pineda 
//catedratico evaluacion de sistemas:        Lic.Karla Melisa Garcia Pineda 


//---------------------------------------------------------------------

//Programa:         Registrar y editar usuarios
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Formulario que permite registrar o editar los usuarios

//-----------------------------------------------------------------------

//                Historial de Cambio

//-----------------------------------------------------------------------

//Programador               Fecha                      Descripcion
//GABRIELA  MANCIA  

//HILDEGARD  MONTALVAN   

//NELSON SALGADO  

//JOEL  GODOY 

//OLMAN  DOMÍNGUEZ 

//-----------------------------------------------------------------------

namespace ProyectoHCL.Formularios
{
    public partial class R_E_Usuario : Form
    {
        public R_E_Usuario()
        {
            InitializeComponent();
            cargarEstado(); //lenar combobox con los estados
            cmbRol.SelectedIndex = -1; //inicializar combobox sin opción seleccionada
            cmbEstado.SelectedIndex = -1; //inicializar combobox sin opción seleccionada
        }

        public string idUs = null;
        MsgB msgB = new MsgB();

        public void cargarRolesR() //cargar combobox con los registros de los roles en la base de datos
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();
            MySqlCommand cmd;

            cmbRol.DataSource = null;
            cmbRol.Items.Clear();

            using (conectar)
            {
                string sql = "SELECT ROL FROM TBL_ROL WHERE ESTADO_ROL = 'ACTIVO';";
                try
                {
                    cmd = new MySqlCommand(sql, conectar);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreRol = reader["ROL"].ToString();
                            cmbRol.Items.Add(nombreRol);
                        }
                    }
                }
                catch (MySqlException e)
                {
                    MsgB m = new MsgB("Error", "Se produjo un error " + e.Message);
                    DialogResult dR = m.ShowDialog();
                }
                finally { conectar.Close(); }
            }
        }

        public void cargarRolesE() //cargar combobox con los registros de los roles en la base de datos
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();
            MySqlCommand cmd;

            cmbRol.DataSource = null;
            cmbRol.Items.Clear();

            using (conectar)
            {
                string sql = "SELECT ROL FROM TBL_ROL;";
                try
                {
                    cmd = new MySqlCommand(sql, conectar);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreRol = reader["ROL"].ToString();
                            cmbRol.Items.Add(nombreRol);
                        }
                    }
                }
                catch (MySqlException e)
                {
                    MsgB m = new MsgB("Error", "Se produjo un error " + e.Message);
                    DialogResult dR = m.ShowDialog();
                }
                finally { conectar.Close(); }
            }
        }

        private bool ContrasenaRobusta(string password) //validar contraseña robusta
        {
            return password.Length >= 5 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Any(c => !char.IsLetterOrDigit(c));
        }

        public string Pass() //obtener la contraseña del usuario
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

        private void cargarEstado() //cargar combobox con los registros de los estados en la base de datos
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            cmbEstado.DataSource = null;
            cmbEstado.Items.Clear();

            using (conectar)
            {
                string sql = "SELECT ID_ESTADO, DESCRIPCION FROM TBL_ESTADO;";
                using (MySqlCommand cmd = new MySqlCommand(sql, conectar))
                {
                    try
                    {
                        MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        data.Fill(dt);

                        cmbEstado.ValueMember = "ID_ESTADO";
                        cmbEstado.DisplayMember = "DESCRIPCION";
                        cmbEstado.DataSource = dt;

                    }
                    catch (MySqlException e)
                    {
                        MsgB m = new MsgB("Error", "Se produjo un error " + e.Message);
                        DialogResult dR = m.ShowDialog();
                    }
                    finally { conectar.Close(); }

                }
            }
        }

        public void limpiarCampos() //limpiar los campos del formulario
        {
            txtNombre.Clear();
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtCorreo.Clear();
            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError() //limpiar los errorProvider del formulario
        {
            errorT.SetError(txtNombre, "");
            errorT.SetError(txtContraseña, "");
            errorT.SetError(txtUsuario, "");
            errorT.SetError(txtCorreo, "");
            errorT.SetError(cmbRol, "");
            errorT.SetError(cmbEstado, "");
            errorT.SetError(dtpVencimiento, "");
        }

        private void btnMin_Click(object sender, EventArgs e) //botón para minimizar
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e) //botón para cerrar
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) //botón para cancelar
        {
            this.Close();
        }

        //coordenadas para arrastrar formulario
        int posY = 0;
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e) //evento del panel que permite arrastrar el formulario
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) //validar que se ingresen solo letras
        {
            ValidarTxt.TxtLetras(e);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e) //validar que no se ingresen espacios
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MsgB m = new MsgB("advertencia", "No se permiten espacios");
                DialogResult dR = m.ShowDialog();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) //botón para guardar un nuevo registro o una modificación
        {
            if (lblTitulo.Text == "Registrar Usuario")
            {
                Modelo modelo = new Modelo();

                if (txtNombre.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || txtContraseña.Text.Trim() == "" ||
                    cmbRol.Text.Trim() == "" || txtCorreo.Text.Trim() == "") //validar campos vacíos
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else if (modelo.existeUsuario(txtUsuario.Text)) //validar si ya existe el usuario
                {
                    MsgB m = new MsgB("advertencia", "El usuario ya existe");
                    DialogResult dR = m.ShowDialog();
                }
                else if (modelo.existeNombre(txtNombre.Text)) //validar si ya existe el nombre de usuario
                {
                    MsgB m = new MsgB("advertencia", "El nombre de usuario ya existe");
                    DialogResult dR = m.ShowDialog();
                }
                else if (modelo.existeCorreo(txtCorreo.Text)) //validar si ya existe el correo
                {
                    MsgB m = new MsgB("advertencia", "El correo proporcionado ya está registrado");
                    DialogResult dR = m.ShowDialog();
                }
                else if (DateTime.Today > dtpVencimiento.Value) //validar la fecha de vencimiento
                {
                    MsgB m = new MsgB("advertencia", "La fecha de vencimiento seleccionada no es válida");
                    DialogResult dR = m.ShowDialog();
                }
                else if (!ValidarTxt.CorreoValido(txtCorreo.Text)) //validar correo
                {
                    MsgB m = new MsgB("advertencia", "Dirección de correo no válida");
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtContraseña.TextLength < 5) //validar que la contraseña no tenga menos de 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "La contraseña es muy corta");
                    DialogResult dR = m.ShowDialog();
                }
                else if (!ContrasenaRobusta(txtContraseña.Text))
                {
                    MsgB m = new MsgB("advertencia", "La contraseña debe contener al menos una letra minúscula, una mayúscula, " +
                    "un número y un caracter especial");
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtNombre.TextLength < 5) //validar que el nombre no tenga menos de 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "El nombre debe contener al menos 5 letras");
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtUsuario.TextLength < 5) //validar que el usuario no tenga menos de 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "El usuario debe contener al menos 5 letras");
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
                        //parametros que recibe el procedimiento almacenado
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
                        //registrar acción (crear) en bitácora
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
                    txtCorreo.Text.Trim() == "" || cmbEstado.Text.Trim() == "") //validar campos vacíos
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else if (DateTime.Today > dtpVencimiento.Value) //validar la fecha de vencimiento
                {
                    MsgB m = new MsgB("advertencia", "La fecha de vencimiento seleccionada no es válida");
                    DialogResult dR = m.ShowDialog();
                }
                else if (!ValidarTxt.CorreoValido(txtCorreo.Text)) //validar correo
                {
                    MsgB m = new MsgB("advertencia", "Dirección de correo no válida");
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtContraseña.TextLength < 5 && txtContraseña.Text != "") //validar contraseña que no sea menor a 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "La contraseña es muy corta");
                    DialogResult dR = m.ShowDialog();
                }
                else if (!ContrasenaRobusta(txtContraseña.Text) && txtContraseña.Text != "")
                {
                    MsgB m = new MsgB("advertencia", "La contraseña debe contener al menos una letra minúscula, una mayúscula, " +
                    "un número y un caracter especial");
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtNombre.TextLength < 5) //validar que el nombre no tenga menos de 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "El nombre debe contener al menos 5 letras");
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtUsuario.TextLength < 5) //validar que el usuario no tenga menos de 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "El usuario debe contener al menos 5 letras");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        if (txtContraseña.Text == "")
                        {
                            //llamar función para editar 
                            control.editarUs(idUs, cmbEstado.Text, cmbRol.Text, txtUsuario.Text, txtNombre.Text,
                            Pass(), dtpVencimiento.Text, txtCorreo.Text);
                        }
                        else
                        {
                            control.editarUs(idUs, cmbEstado.Text, cmbRol.Text, txtUsuario.Text, txtNombre.Text,
                            txtContraseña.Text, dtpVencimiento.Text, txtCorreo.Text);
                        }
                        string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        MySqlConnection conn;
                        MySqlCommand cmd;

                        //registrar acción(editar) en bitacóra
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

        private void txtCorreo_Leave(object sender, EventArgs e) //validar campo vacío
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

        private void txtContraseña_Leave(object sender, EventArgs e) //validar campo vacío
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

        private void txtUsuario_Leave(object sender, EventArgs e) //validar campo vacío
        {
            string texto = txtUsuario.Text;

            if (ValidarTxt.txtVacio(txtUsuario))
            {
                errorT.SetError(txtUsuario, "Introduzca un usuario");
            }
            else if (texto.Length < 5)
            {
                errorT.SetError(txtUsuario, "El usuario debe contener al menos 5 letras");
                txtUsuario.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e) //validar campo vacío
        {
            string texto = txtNombre.Text;

            if (ValidarTxt.txtVacio(txtNombre))
            {
                errorT.SetError(txtNombre, "Introduzca un nombre");
            }
            else if (texto.Length < 5)
            {
                errorT.SetError(txtNombre, "El nombre debe contener al menos 5 letras");
                txtNombre.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void cmbEstado2_Leave(object sender, EventArgs e)
        {
        }

        private void cmbRol_Leave(object sender, EventArgs e) //validar campo vacío
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

        private void cmbEstado_Leave(object sender, EventArgs e) //validar campo vacío
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

        private void OcultarBox4_Click(object sender, EventArgs e) //ocultar contraseña
        {
            MostrarBox3.BringToFront();
            txtContraseña.PasswordChar = '*';
        }

        private void MostrarBox3_Click(object sender, EventArgs e) //mostrar contraseña
        {
            OcultarBox4.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void dtpVencimiento_Leave(object sender, EventArgs e) //validar una fecha mayor a la actual
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

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e) //validar que no hayan espacios en el campo de usuario
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MsgB m = new MsgB("advertencia", "No se permiten espacios");
                DialogResult dR = m.ShowDialog();
            }
            else if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            string contra = txtContraseña.Text;
            bool valida = ContrasenaRobusta(contra);

            if (!valida)
            {
                errorT.SetError(txtContraseña, "La contraseña debe contener al menos una letra minúscula, una mayúscula, " +
                    "un número y un caracter especial");
                txtContraseña.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void R_E_Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            limpiarCampos();
            limpiarError();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
