﻿using MySql.Data.MySqlClient;
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

//Programa:         Registrar y editar objetos
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Formulario que permite registrar o editar los objetos

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
    public partial class R_E_Objeto : Form
    {
        public R_E_Objeto()
        {
            InitializeComponent();
        }

        public string idObj = null;

        MsgB msgB = new MsgB();

        public int IdObjeto() //obtener el id del objeto
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = BaseDatosHCL.ObtenerConexion();
            comando.CommandText = ("SELECT ID_OBJETO FROM TBL_OBJETO WHERE OBJETO = '"
                + txtObj.Text + "';");

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                return (int)leer["ID_OBJETO"];
            }
            else
            {
                return 0;
            }
        }

        public void limpiarCampos() //limpiar los campos del formulario
        {
            txtObj.Clear();
            rTxtDesc.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError() //limpiar los errorProvider del formulario
        {
            errorT.SetError(txtObj, "");
            errorT.SetError(rTxtDesc, "");
            errorT.SetError(cmbEstado, "");
        }

        private void btnMin_Click(object sender, EventArgs e)  //botón para minimizar
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e) //botón para cerrar
        {
            this.Close();
            //limpiarCampos();
            //limpiarError();
        }

        private void btnCancelar_Click(object sender, EventArgs e) //botón para cancelar
        {
            this.Close();
            //limpiarCampos();
            //limpiarError();
        }

        //coordenadas para arrastrar formulario
        int posY = 0;
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e)  //evento del panel que permite arrastrar el formulario
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

        private void txtObj_Leave(object sender, EventArgs e) //validar campo vacío
        {
            string texto = txtObj.Text;

            if (ValidarTxt.txtVacio(txtObj))
            {
                errorT.SetError(txtObj, "Introduzca un nombre");
            }
            else if (texto.Length < 5)
            {
                errorT.SetError(txtObj, "El nombre debe contener al menos 5 letras");
                txtObj.Focus();
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

        private void btnGuardar_Click(object sender, EventArgs e) //botón para guardar un nuevo registro o una modificación
        {
            if (lblTitulo.Text == "Registrar Objeto")
            {
                Modelo modelo = new Modelo();

                if (txtObj.Text.Trim() == "" || rTxtDesc.Text.Trim() == "" || cmbEstado.Text.Trim() == "") //validar campos vacíos
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();

                }
                else if (modelo.existeObjeto(txtObj.Text))
                {
                    MsgB m = new MsgB("advertencia", "El objeto ya existe"); //validar si ya existe el registro
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtObj.TextLength < 5) //validar que el objeto no tenga menos de 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "El nombre debe contener al menos 5 letras");
                    DialogResult dR = m.ShowDialog();
                }
                else if (rTxtDesc.TextLength < 10) //validar que la descripción no tenga menos de 10 caracteres
                {
                    MsgB m = new MsgB("advertencia", "La descripción debe contener al menos 10 letras");
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
                        //parametros que recibe el procedimiento almacenado
                        cmd.Parameters.AddWithValue("@nombreObj", txtObj.Text);
                        cmd.Parameters.AddWithValue("@descObj", rTxtDesc.Text);
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
            else if (lblTitulo.Text == "Editar Objeto")
            {
                Control control = new Control();
                string nuevoObjeto = txtObj.Text;
                string idRegistro = idObj;

                Modelo modelo = new Modelo();

                if (txtObj.Text.Trim() == "" || cmbEstado.Text.Trim() == "" || rTxtDesc.Text.Trim() == "") //validar campos vacíos
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtObj.TextLength < 5) //validar que el objeto no tenga menos de 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "El nombre debe contener al menos 5 letras");
                    DialogResult dR = m.ShowDialog();
                }
                else if (rTxtDesc.TextLength < 10) //validar que la descripción no tenga menos de 10 caracteres
                {
                    MsgB m = new MsgB("advertencia", "La descripción debe contener al menos 10 letras");
                    DialogResult dR = m.ShowDialog();
                }

                else if (modelo.ObjetoEditarBD(nuevoObjeto, idRegistro)) //Validar que el objeto ya existe
                {
                    MsgB mbox1 = new MsgB("advertencia", "El objeto ya existe");
                    DialogResult dR1 = mbox1.ShowDialog();
                }
                
                else
                {
                    try
                    {
                        //llamar función para editar 
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

        private void rTxtDesc_KeyPress_1(object sender, KeyPressEventArgs e) //validar que solo se ingresen letras
        {
            ValidarTxt.TxtLetras(e);
        }

        private void rTxtDesc_Leave_1(object sender, EventArgs e)  //validar campo vacío
        {
            string texto = rTxtDesc.Text;

            if (ValidarTxt.txtVacio(rTxtDesc))
            {
                errorT.SetError(rTxtDesc, "Introduzca una descripción");
            }
            else if (texto.Length < 10)
            {
                errorT.SetError(rTxtDesc, "La descripción debe contener al menos 10 letras");
                rTxtDesc.Focus();
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtObj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de números
            }
        }

        private bool NombreExiste(string nuevoNombre, int idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            string query = "SELECT COUNT(*) FROM TBL_OBJETO WHERE OBJETO = @NuevoNombre AND ID_OBJETO != @IDRegistro";
            using (MySqlCommand cmd = new MySqlCommand(query, conectar))
            {
                cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                cmd.Parameters.AddWithValue("@IDRegistro", idRegistro);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }

        }

        private void R_E_Objeto_FormClosing(object sender, FormClosingEventArgs e)
        {
            limpiarCampos();
            limpiarError();
        }
    }
}
