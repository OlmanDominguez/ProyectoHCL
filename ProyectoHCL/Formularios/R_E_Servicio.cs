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

//Programa:         Registrar y editar servicios
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Formulario que permite registrar o editar los servicios

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
    public partial class R_E_Servicio : Form
    {
        public R_E_Servicio()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = -1;
            txtPrecio.KeyPress += txtPrecio_KeyPress; //llamar evento que valida que solo se ingresen números
        }

        public string idS = null;
        MsgB msgB = new MsgB();

        public void limpiarCampos() //limpiar los campos del formulario
        {
            txtServ.Clear();
            txtPrecio.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError() //limpiar los errorProvider del formulario
        {
            errorT.SetError(txtServ, "");
            errorT.SetError(txtPrecio, "");
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

        private void btnCancelar_Click(object sender, EventArgs e) //botón para cancelar
        {
            this.Close();
            //limpiarCampos();
            //limpiarError();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e) //validar que se ingresen sólo numeros y puntos '.'
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtServ_Leave(object sender, EventArgs e) //validar campo vacío
        {
            string texto = txtServ.Text;

            if (ValidarTxt.txtVacio(txtServ))
            {
                errorT.SetError(txtServ, "Introduzca un nombre");
            }
            else if (texto.Length < 5)
            {
                errorT.SetError(txtServ, "El nombre del servicio debe contener al menos 5 letras");
                txtServ.Focus();
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
            Modelo modelo = new Modelo();

            if (lblTitulo.Text == "Registrar Servicio")
            {
                if (txtServ.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || cmbEstado.Text.Trim() == "")  //validar campos vacíos
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();

                }
                else if (txtServ.TextLength < 5) //validar que el nombre no tenga menos de 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "El nombre del servicio debe contener al menos 5 letras");
                    DialogResult dR = m.ShowDialog();
                }
                else if (modelo.existeServicio(txtServ.Text)) //validar si ya existe el registro
                {
                    MsgB m = new MsgB("advertencia", "El servicio ya existe");
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

                        cmd = new MySqlCommand("insertServicio", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //parametros que recibe el procedimiento almacenado
                        cmd.Parameters.AddWithValue("@descripcion", txtServ.Text);
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
            else if (lblTitulo.Text == "Editar Servicio")
            {
                Control control = new Control();
                string nuevoServicio = txtServ.Text;
                string idRegistro = idS;

                if (txtServ.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || cmbEstado.Text.Trim() == "") //validar campos vacíos
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else if (txtServ.TextLength < 5) //validar que el nombre no tenga menos de 5 caracteres
                {
                    MsgB m = new MsgB("advertencia", "El nombre del servicio debe contener al menos 5 letras");
                    DialogResult dR = m.ShowDialog();
                }
                else if (modelo.ServicioEditarBD(nuevoServicio, idRegistro))
                {
                    MsgB m = new MsgB("advertencia", "El servicio ya está registrado");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        //llamar función para editar 
                        control.editarServ(idS, txtServ.Text, txtPrecio.Text, cmbEstado.Text);

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

        private void R_E_Servicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            limpiarCampos();
            limpiarError();
        }
    }
}
