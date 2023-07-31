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
            combo_metodo();
            combo_estado();
            combo_cliente();
            combo_tipo();


        }

        private void combo_metodo()
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select ID_METODORESERVA, DESCRIPCION from TBL_METODORESERVA;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //combobox tipo habitacion
                    DataRow fila = dt.NewRow();
                    fila["DESCRIPCION"] = "Seleccione un metodo";
                    dt.Rows.InsertAt(fila, 0);

                    cb_metodo.ValueMember = "ID_METODORESERVA";
                    cb_metodo.DisplayMember = "DESCRIPCION";
                    cb_metodo.DataSource = dt;




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
                    comando.CommandText = ("select ID_TIPOHABITACION, TIPO from TBL_TIPOHABITACION;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow fila = dt.NewRow();
                    fila["TIPO"] = "Seleccione un tipo";
                    dt.Rows.InsertAt(fila, 0);

                    cb_tipo.ValueMember = "ID_TIPOHABITACION";
                    cb_tipo.DisplayMember = "TIPO";
                    cb_tipo.DataSource = dt;

                    /*//combobox tipo habitacion
                    cb_tipo.DataSource = dt;
                    cb_tipo.DisplayMember = "TBL_TIPOHABITACION";
                    cb_tipo.ValueMember = "TIPO";
                    */



                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void combo_habitacion(string ID_TIPOHABITACION)
        {


            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select ID_TIPOHABITACION, NUMEROHABITACION from TBL_HABITACION where ESTADOHABITACION='DISPONIBLE' AND ID_TIPOHABITACION=@ID_TIPOHABITACION;");
                    comando.Parameters.AddWithValue("ID_TIPOHABITACION", ID_TIPOHABITACION);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow fila = dt.NewRow();
                    fila["NUMEROHABITACION"] = 0;
                    dt.Rows.InsertAt(fila, 0);

                    cb_numero.ValueMember = "ID_TIPOHABITACION";
                    cb_numero.DisplayMember = "NUMEROHABITACION";
                    cb_numero.DataSource = dt;


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

                    DataRow fila = dt.NewRow();
                    fila["DESCRIPCION"] = "Seleccione un estado";
                    dt.Rows.InsertAt(fila, 0);

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

                    DataRow fila = dt.NewRow();
                    fila["NOMBRE"] = "Seleccione un cliente";
                    dt.Rows.InsertAt(fila, 0);

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

        }

        private void cb_metodo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string nombre = cb_metodo.SelectedValue.ToString();
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select ID_METODORESERVA from TBL_METODORESERVA where ID_METODORESERVA='" + nombre + "'");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        txt_metodo_reserva.Text = leer["ID_METODORESERVA"].ToString();

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

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipo.SelectedValue.ToString() != null)
            {
                string ID_TIPOHABITACION = cb_tipo.SelectedValue.ToString();
                combo_habitacion(ID_TIPOHABITACION);
            }

            String nombre = cb_tipo.SelectedValue.ToString();
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select ID_TIPOHABITACION from TBL_TIPOHABITACION where ID_TIPOHABITACION='" + nombre + "';");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        txt_tipo_habitacion.Text = leer["ID_TIPOHABITACION"].ToString();

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

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nombre = cb_estado.SelectedValue.ToString();
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select ID_ESTADORESERVA from TBL_ESTADORESERVA where DESCRIPCION='" + nombre + "';");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        txt_estado.Text = leer["ID_ESTADORESERVA"].ToString();

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int codigoU = int.Parse(txt_codigo.Text);
            int codigoC = int.Parse(txt_cod_cliente.Text);
            int metodo = int.Parse(txt_metodo_reserva.Text);
            int estado = int.Parse(txt_estado.Text);
            int huespedes = int.Parse(txt_huespedes.Text);
            double monto = double.Parse(txt_monto.Text);
            string fecha_coti = txt_fecha_coti.Text;
            string fecha_entrada = txt_fecha_entrada.Text;
            string fecha_salida = txt_fecha_salida.Text;
            int habitacion = int.Parse(txt_tipo_habitacion.Text);
            int numhanitacion = cb_numero.SelectedIndex;
            int vehiculo = int.Parse(txt_vehiculo.Text);

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("insert into TBL_SOLICITUDRESERVA (ID_ESTADORESERVA, ID_METODORESERVA, ID_USUARIO, FECHACOTI, INGRESO, SALIDA, NHUESPEDES,VEHICULO, MONTORESERVAR,COD_CLIENTE, NUMEROHABITACION) " +
                        "values ('" + estado + "', '" + metodo + "', '" + codigoU + "', '" + fecha_coti + "', '" + fecha_entrada + "', '" + fecha_salida + "','" + huespedes + "', '" + vehiculo + "', '" + monto + "','" + codigoC + "','" + numhanitacion + "');");

                    comando.ExecuteReader();
                    MessageBox.Show("Reservacion ingresada con exito");

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void cb_numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* String nombre = cb_numero.SelectedValue.ToString();
             try
             {
                 using (BaseDatosHCL.ObtenerConexion())
                 {
                     MySqlCommand comando = new MySqlCommand();
                     comando.Connection = BaseDatosHCL.ObtenerConexion();
                     comando.CommandText = ("SELECT ID_HABITACION FROM TBL_HABITACION where NUMEROHABITACION='" + nombre + "';");

                     MySqlDataReader leer = comando.ExecuteReader();
                     if (leer.Read() == true)
                     {
                        txt_id.Text = leer["ID_HABITACION"].ToString();

                     }
                     else
                     {

                     }
                 }
             }
             catch (Exception a)
             {
                 MessageBox.Show(a.Message);
             }*/
        }
    }
}

