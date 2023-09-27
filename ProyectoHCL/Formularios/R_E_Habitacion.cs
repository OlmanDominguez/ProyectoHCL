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

//Programa:         Registrar y editar habitaciones
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Formulario que permite registrar o editar las habitaciones

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
    public partial class R_E_Habitacion : Form
    {
        public R_E_Habitacion()
        {
            InitializeComponent();
            cargarTipos(); //llenar combobox 
            cmbTipo.SelectedIndex = -1; //inicializar combobox vacío
        }

        public string idH = null;
        MsgB msgB = new MsgB();

        private void cargarTipos() //cargar combobox con los registros de la base de datos
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            cmbTipo.DataSource = null;
            cmbTipo.Items.Clear(); //limpiar combobox
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

        public void limpiarCampos() //limpiar los campos del formulario
        {
            cmbTipo.SelectedIndex = -1;
            txtNumero.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        public void limpiarError() //limpiar los errorProvider del formulario
        {
            errorT.SetError(cmbTipo, "");
            errorT.SetError(txtNumero, "");
            errorT.SetError(cmbEstado, "");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //botón para minimizar
        }

        private void btnCerrar_Click(object sender, EventArgs e) //botón para cerrar
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

        private void btnGuardar_Click(object sender, EventArgs e) //botón para guardar un nuevo registro o una modificación
        {
            if (lblTitulo.Text == "Registrar Habitación")
            {
                Modelo modelo = new Modelo();

                if (cmbTipo.Text.Trim() == "" || txtNumero.Text.Trim() == "" || cmbEstado.Text.Trim() == "") //validar campos vacíos
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else if (modelo.existeHabitacion(txtNumero.Text))
                {
                    MsgB m = new MsgB("advertencia", "El número de habitación ya existe"); //validar si ya existe el registro
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
                        //parametros que recibe el procedimiento almacenado
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

                if (cmbTipo.Text.Trim() == "" || txtNumero.Text.Trim() == "" || cmbEstado.Text.Trim() == "") //validar campos vacíos
                {
                    MsgB m = new MsgB("advertencia", "Por favor llene todos los campos");
                    DialogResult dR = m.ShowDialog();
                }
                else
                {
                    try
                    {
                        //llamar función para editar 
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e) //validar que solo se ingresen números
        {
            ValidarTxt.TxtNumeros(e);
        }

        private void cmbTipo_Leave(object sender, EventArgs e) //validar campo vacío
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

        private void txtNumero_Leave(object sender, EventArgs e) //validar campo vacío
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
