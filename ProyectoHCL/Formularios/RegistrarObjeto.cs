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
    public partial class RegistrarObjeto : Form
    {
        public RegistrarObjeto()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.DeepSkyBlue);
            panel2.BackColor = Color.FromArgb(120, Color.DimGray);
        }


        private void txtObjeto_Validated(object sender, EventArgs e)
        {
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxt.TxtLetras(e);
        }

        public void limpiarCampos()
        {
            txtObjeto.Clear();
            txtDescripcion.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();

            VCamposVacios();

            try
            {
                if (modelo.existeObjeto(txtObjeto.Text))
                {
                    MessageBox.Show("El objeto ya existe", "Aviso",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand("insertarObjeto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombreObj", txtObjeto.Text);
                    cmd.Parameters.AddWithValue("@descObj", txtDescripcion.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Objeto creado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtObjeto_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VCamposVacios()
        {
            bool ok = true;

            if (txtObjeto.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtObjeto, "Introduzca el nombre del objeto");
            }
            else
            {
                errorT.Clear();
            }

            if (txtDescripcion.Text.Trim() == "")
            {
                ok = false;
                errorT.SetError(txtDescripcion, "Introduzca una descripción del objeto");
            }
            else
            {
                errorT.Clear();
            }

            return ok;

        }
    }
}
