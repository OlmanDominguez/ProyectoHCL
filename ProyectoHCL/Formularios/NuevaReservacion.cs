using DocumentFormat.OpenXml.Spreadsheet;
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
using System.Windows.Forms;

namespace ProyectoHCL
{
    public partial class NuevaReservacion : Form
    {
        public NuevaReservacion()
        {
            InitializeComponent();
        }

        private void combo_metodo()
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select DESCRIPCION from TBL_METODORESERVA;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //combobox tipo habitacion
                    cb_metodo.DataSource = dt;
                    cb_metodo.DisplayMember = "TBL_METODORESERVA";
                    cb_metodo.ValueMember = "DESCRIPCION";




                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void combo_tipo()
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select TIPO from TBL_TIPOHABITACION;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //combobox tipo habitacion
                    cb_tipo.DataSource = dt;
                    cb_tipo.DisplayMember = "TBL_TIPOHABITACION";
                    cb_tipo.ValueMember = "TIPO";




                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void combo_habitacion()
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select NUMEROHABITACION from TBL_HABITACION where ESTADOHABITACION='DISPONIBLE';");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //combobox tipo habitacion
                    cb_numero.DataSource = dt;
                    cb_numero.DisplayMember = "TBL_HABITACION";
                    cb_numero.ValueMember = "NUMEROHABITACION";




                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }


        private void combo_estado()
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select DESCRIPCION from TBL_ESTADORESERVA;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //combobox estado reserva
                    cb_estado.DataSource = dt;
                    cb_estado.DisplayMember = "TBL_ESTADORESERVA";
                    cb_estado.ValueMember = "DESCRIPCION";




                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void combo_cliente()
        {

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select NOMBRE,APELLIDO from TBL_CLIENTE;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    //combobox estado reserva
                    cb_cliente.DataSource = dt;
                    cb_cliente.DisplayMember = "TBL_CLIENTE";
                    cb_cliente.ValueMember = "NOMBRE";




                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = cb_cliente.SelectedIndex;
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select ID_ESTADORESERVA from TBL_ESTADORESERVA where DESCRIPCION=" + id + ";");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //combobox estado reserva
                    cb_cliente.DataSource = dt;
                    cb_cliente.DisplayMember = "TBL_CLIENTE";
                    cb_cliente.ValueMember = "NOMBRE";




                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void cb_cliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String nombre = cb_cliente.SelectedValue.ToString();
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select CODIGO from TBL_CLIENTE where NOMBRE='" + nombre + "';");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        txt_cod_cliente.Text = leer["CODIGO"].ToString();

                    }
                    else
                    {

                    }
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void NuevaReservacion_Load(object sender, EventArgs e)
        {
            combo_metodo();
            combo_tipo();
            combo_estado();
            combo_habitacion();
            combo_cliente();

        }

        private void cb_metodo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

