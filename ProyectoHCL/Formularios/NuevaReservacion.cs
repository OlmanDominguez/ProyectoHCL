using DocumentFormat.OpenXml.Office2010.Excel;
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
using System.Windows.Markup;

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

        public void updatenumero()
        {
            string num1 = cb_numero.Text;
            string num2 = txt_habi_vieja.Text;
            if (num1 == num2)
            {
                //MessageBox.Show("numeros iguales"+num1);
            }
            else
            {
                try
                {
                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand("UpdateH2", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num_habitacion_vieja", txt_habi_vieja.Text);

                    cmd.ExecuteNonQuery();

                    /*MsgB m = new MsgB("informacion", "Reserva agregada con exito");
                    DialogResult dR = m.ShowDialog();
                    limpiarCampos();*/
                    conn.Close();
                }
                catch (Exception ex)
                {/*
                MsgB m = new MsgB("Error: ", ex.Message);
                DialogResult dR = m.ShowDialog();*/
                }
            }
        }
        public void inserdetalle()
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("InsertDetalle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_habitacion", txt_id.Text);
                cmd.Parameters.AddWithValue("@id_estado", txt_estado.Text);

                cmd.ExecuteNonQuery();

                /*MsgB m = new MsgB("informacion", "Reserva agregada con exito");
                DialogResult dR = m.ShowDialog();
                limpiarCampos();*/
                conn.Close();
            }
            catch (Exception ex)
            {/*
                MsgB m = new MsgB("Error: ", ex.Message);
                DialogResult dR = m.ShowDialog();*/
            }

        }
        public void updatedetalle()
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("UpdateDetalle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_solicitud", txt_id_solicitud.Text);
                cmd.Parameters.AddWithValue("@id_habitacion", txt_id.Text);
                cmd.Parameters.AddWithValue("@id_estado", txt_estado.Text);

                cmd.ExecuteNonQuery();

                /*MsgB m = new MsgB("informacion", "Reserva agregada con exito");
                DialogResult dR = m.ShowDialog();
                limpiarCampos();*/
                conn.Close();
            }
            catch (Exception ex)
            {/*
                MsgB m = new MsgB("Error: ", ex.Message);
                DialogResult dR = m.ShowDialog();*/
            }

        }
        public void updatehabitacion()
        {
            String ESTADO = cb_estado.SelectedValue.ToString();
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("UpdateH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_habitacion", txt_id.Text);
                cmd.Parameters.AddWithValue("@estado", ESTADO);

                cmd.ExecuteNonQuery();

                /*MsgB m = new MsgB("informacion", "Reserva agregada con exito");
                DialogResult dR = m.ShowDialog();
                limpiarCampos();*/
                conn.Close();
            }
            catch (Exception ex)
            {/*
                MsgB m = new MsgB("Error: ", ex.Message);
                DialogResult dR = m.ShowDialog();*/
            }


        }

        public void limpiarCampos()
        {
            txt_codigo.Clear();
            txt_cod_cliente.Clear();
            txt_estado.Clear();
            txt_huespedes.Clear();
            txt_id.Clear();
            txt_metodo_reserva.Clear();
            txt_monto.Clear();
            txt_tipo_habitacion.Clear();
            txt_vehiculo.Clear();
            cb_metodo.SelectedIndex = 0;
            cb_numero.SelectedIndex = 0;
            cb_tipo.SelectedIndex = 0;
            cb_cliente.SelectedIndex = 0;
            cb_estado.SelectedIndex = 0;


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

                    cb_metodo.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb_metodo.AutoCompleteSource = AutoCompleteSource.ListItems;




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

                    cb_tipo.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb_tipo.AutoCompleteSource = AutoCompleteSource.ListItems;

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

                    cb_numero.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb_numero.AutoCompleteSource = AutoCompleteSource.ListItems;

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

                    cb_estado.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb_estado.AutoCompleteSource = AutoCompleteSource.ListItems;



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

                    cb_cliente.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb_cliente.AutoCompleteSource = AutoCompleteSource.ListItems;


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
            if (txt_id_solicitud.Text != "")
            {
                btn_guardar2.Visible = true;
                string id = txt_id_solicitud.Text;
                try
                {
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("select * from TBL_SOLICITUDRESERVA where ID_SOLICITUDRESERVA='" + id + "';");

                        MySqlDataReader leer = comando.ExecuteReader();
                        if (leer.Read() == true)
                        {
                            txt_codigo.Text = leer["ID_USUARIO"].ToString();
                            txt_cod_cliente.Text = leer["COD_CLIENTE"].ToString();
                            txt_estado.Text = leer["ID_ESTADORESERVA"].ToString();
                            txt_metodo_reserva.Text = leer["ID_METODORESERVA"].ToString();
                            txt_monto.Text = leer["MONTORESERVAR"].ToString();
                            txt_vehiculo.Text = leer["VEHICULO"].ToString();
                            txt_huespedes.Text = leer["NHUESPEDES"].ToString();
                            txt_habi_vieja.Text = leer["NUMEROHABITACION"].ToString();
                            cb_numero.Text = leer["NUMEROHABITACION"].ToString();
                            dt_fecha_coti.Value = Convert.ToDateTime(leer["FECHACOTI"].ToString());
                            dt_fecha_entrada.Value = Convert.ToDateTime(leer["INGRESO"].ToString());
                            dt_fecha_salida.Value = Convert.ToDateTime(leer["SALIDA"].ToString());


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
            else
            {
                btnGuardar.Visible = true;

            }
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

            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("InsertarReserva", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estado", txt_estado.Text);
                cmd.Parameters.AddWithValue("@id_metodo", txt_metodo_reserva.Text);
                cmd.Parameters.AddWithValue("@id_usuaio", txt_codigo.Text);
                cmd.Parameters.AddWithValue("@fecha_coti", Convert.ToDateTime(dt_fecha_coti.Text));
                cmd.Parameters.AddWithValue("@fecha_ingreso", Convert.ToDateTime(dt_fecha_entrada.Text));
                cmd.Parameters.AddWithValue("@fecha_salida", Convert.ToDateTime(dt_fecha_salida.Text));
                cmd.Parameters.AddWithValue("@n_huespedes", txt_huespedes.Text);
                cmd.Parameters.AddWithValue("@vehiculo", txt_vehiculo.Text);
                cmd.Parameters.AddWithValue("@monto", txt_monto.Text);
                cmd.Parameters.AddWithValue("@cod_cliente", txt_cod_cliente.Text);
                cmd.Parameters.AddWithValue("@num_habitacion", cb_numero.Text);


                cmd.ExecuteNonQuery();
                inserdetalle();
                updatehabitacion();
                MsgB m = new MsgB("informacion", "Reserva agregada con exito");
                DialogResult dR = m.ShowDialog();
                limpiarCampos();
                conn.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                MsgB m = new MsgB("Error: ", "Validar los datos Ingresados");
                DialogResult dR = m.ShowDialog();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            object adb = cb_numero.SelectedItem;
            object b = cb_numero.GetItemText(adb);


            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("SELECT ID_HABITACION FROM TBL_HABITACION where NUMEROHABITACION='" + b + "';");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        txt_id.Text = leer["ID_HABITACION"].ToString();
                        //txt_habi_vieja.Text = leer["ID_HABITACION"].ToString();
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

        private void btn_guardar2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("UpdateReserva", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_solicitud", txt_id_solicitud.Text);
                cmd.Parameters.AddWithValue("@id_estado", txt_estado.Text);
                cmd.Parameters.AddWithValue("@id_metodo", txt_metodo_reserva.Text);
                cmd.Parameters.AddWithValue("@id_usuaio", txt_codigo.Text);
                cmd.Parameters.AddWithValue("@fecha_coti", Convert.ToDateTime(dt_fecha_coti.Text));
                cmd.Parameters.AddWithValue("@fecha_ingreso", Convert.ToDateTime(dt_fecha_entrada.Text));
                cmd.Parameters.AddWithValue("@fecha_salida", Convert.ToDateTime(dt_fecha_salida.Text));
                cmd.Parameters.AddWithValue("@n_huespedes", txt_huespedes.Text);
                cmd.Parameters.AddWithValue("@vehiculo", txt_vehiculo.Text);
                cmd.Parameters.AddWithValue("@monto", txt_monto.Text);
                cmd.Parameters.AddWithValue("@cod_cliente", txt_cod_cliente.Text);
                cmd.Parameters.AddWithValue("@num_habitacion", cb_numero.Text);


                cmd.ExecuteNonQuery();
                updatedetalle();
                updatehabitacion();
                updatenumero();

                MsgB m = new MsgB("informacion", "Reserva actualizada con exito");
                DialogResult dR = m.ShowDialog();
                //limpiarCampos();

                conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MsgB m = new MsgB("Error: ", "Validar los datos Ingresados");
                DialogResult dR = m.ShowDialog();
            }
        }


    }
}

