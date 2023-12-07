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
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

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

//Programa:         Registrar y editar tipos de habitación
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Formulario que permite registrar o editar los tipos de habitación

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
    public partial class R_E_TipHab : Form
    {
        // bool punto = false; //validación de punto

       public R_E_TipHab()
        {
            InitializeComponent();
            txtPrecio.KeyPress += txtPrecio_KeyPress; //llamar evento que valida que solo se ingresen números
         }

        public string idTH = null;
        MsgB msgB = new MsgB();

        public void limpiarCampos() //limpiar los campos del formulario
        {
            txtTipo.Clear();
            txtCapacidad.Clear();
            txtPrecio.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError() //limpiar los errorProvider del formulario
        {
            errorT.SetError(txtTipo, "");
            errorT.SetError(txtCapacidad, "");
            errorT.SetError(txtPrecio, "");
            errorT.SetError(cmbEstado, "");
        }

        private void btnMin_Click(object sender, EventArgs e) //botón para minimizar
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)  //botón para cerrar
        {
            this.Close();
            limpiarCampos();
            limpiarError();
        }

        private void btnCancelar_Click(object sender, EventArgs e) //botón para cancelar
        {
            this.Close();
            limpiarCampos();
            limpiarError();
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

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e) //validar que solo se ingresen números
        {
            ValidarTxt.TxtNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e) //validar que se ingresen sólo numeros y puntos '.'
        {
            ValidarTxt.TxtNumeros(e);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtTipo_Leave(object sender, EventArgs e) //validar campo vacío
        {
            if (ValidarTxt.txtVacio(txtTipo))
            {
                errorT.SetError(txtTipo, "Introduzca un tipo de habitación");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtCapacidad_Leave(object sender, EventArgs e) //validar campo vacío
        {
            if (ValidarTxt.txtVacio(txtCapacidad))
            {
                errorT.SetError(txtCapacidad, "Introduzca el número de capacidad");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e) //validar campo vacío
        {
            if (ValidarTxt.txtVacio(txtPrecio))
            {
                errorT.SetError(txtPrecio, "Introduzca un precio");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) //botón para guardar un nuevo registro o una modificación
        {
            if (lblTitulo.Text == "Registrar Tipo de Habitación")
            {
                Modelo modelo = new Modelo();

                if (txtTipo.Text.Trim() == "" || txtCapacidad.Text.Trim() == "" || txtPrecio.Text.Trim() == ""
                    || cmbEstado.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos"); //validar campos vacíos
                    DialogResult dR = m.ShowDialog();
                }
                else if (modelo.existeTipHab(txtTipo.Text))
                {
                    MsgB m = new MsgB("advertencia", "El tipo de habitación ya existe"); //validar si ya existe el registro
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtTipo.TextLength < 5) //validar que el campo tipo no tenga menos de 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "El campo debe tener al menos 5 letras");
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

                        cmd = new MySqlCommand("insertTipoHabitacion", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //parametros que recibe el procedimiento almacenado
                        cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                        cmd.Parameters.AddWithValue("@capacidad", txtCapacidad.Text);
                        cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
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
            else if (lblTitulo.Text == "Editar Tipo de Habitación")
            {
                Control control = new Control();
                string nuevoTipo = txtTipo.Text;
                string idRegistro = idTH;


                Modelo modelo = new Modelo();

                if (txtTipo.Text.Trim() == "" || txtCapacidad.Text.Trim() == "" || txtPrecio.Text.Trim() == "" //validar campos vacíos
                    || cmbEstado.Text.Trim() == "")
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else if (modelo.TipoHabEditarBD(nuevoTipo, idRegistro)) //Validar que el tipo de habitación ya existe
                {
                    MsgB mbox1 = new MsgB("advertencia", "El tipo de habitación ya existe");
                    DialogResult dR1 = mbox1.ShowDialog();
                }
                else if (txtTipo.TextLength < 5) //validar que el campo tipo no tenga menos de 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "El campo no debe tener menos de 5 letras");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        //llamar función para editar 
                        control.editarTipHab(idTH, txtTipo.Text, txtCapacidad.Text, txtPrecio.Text, cmbEstado.Text);

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

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e) //Validar solo ingresar letras
        {
            ValidarTxt.TxtLetras(e);
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        public class Metodos
        {
            public static bool validarcampodecimal(TextBox CajaDeTexto)
            {
                try
                {
                    int d = Convert.ToInt32(CajaDeTexto.Text);
                    return true;

                }
                catch (Exception ex)
                {
                    CajaDeTexto.Text = "0";
                    CajaDeTexto.Select(0, CajaDeTexto.Text.Length);
                    return false;

                }
            }

        }

        private void txtPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            Metodos.validarcampodecimal((TextBox)sender);
        }



        // private void txtPrecio_Click(object sender, EventArgs e)
        // {
        // if (punto == false)
        // txtPrecio.Text += ".";

        //  punto = true;
        //}
    }
}