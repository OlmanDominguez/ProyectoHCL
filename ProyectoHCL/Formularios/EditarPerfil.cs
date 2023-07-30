using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHCL.Formularios.Clientes
{
    public partial class EditarPerfil : Form
    {
        public EditarPerfil()
        {
            InitializeComponent();
        }

        public string idUs = null;
        EditarPerfil editarPerfil = new EditarPerfil();
        Control control = new Control();
        private static bool CorreoValido(String correo)
        {
            String expresion;
            expresion = "\\w+([-+.’]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, expresion))
            {
                if (Regex.Replace(correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void EditarPerfil_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Form Frm_Perfiles = new Frm_Perfiles();
            Frm_Perfiles.Show();
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            //VCamposVacios();

            if (CorreoValido(txt_dir_correo.Text) == false)
            {
                MessageBox.Show("Dirección de correo no válida", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    /*control.EditarPerfil(txt_nombre, txt_dir_correo, txt_ciudad, txt_descripcion, txt_imagen,
                        txt_apellido, txt_cod, txt_pais);

                    MessageBox.Show("Perfil Editado");
                    this.Close();
                    admonUsuario.MostrarUsuarios();*/

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /*private bool VCamposVacios()
        {
            bool ok = true;

            if (txt_nombre.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txt_nombre, "Introduzca un nombre");
            }
            else
            {
                errorT.Clear();
            }

            if (txt_dir_correo.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txt_dir_correo, "Introduzca una direccion de correo");
            }
            else
            {
                errorT.Clear();
            }

            if (txt_ciudad.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError( "Ingrese la Ciudad");
            }
            else
            {
                errorT.Clear();
            }

            if (txt_descripcion.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError( "Detalle en la descripcion");
            }
            else
            {
                errorT.Clear();
            }

            if (txt_imagen.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError( "Seleccione una imagen");
            }
            if (txt_apellido.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError("Ingrese un apellido");
            }
            if (txt_cod.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError("Ingrese el código");
            }
            if (txt_pais.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError("Ingrese país de origen");
            }
            else
            {
                errorT.Clear();
            }
        }*/
    }
}
