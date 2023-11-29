/*
 * -----------------------------------------------------------------------
	Universidad Nacional Autonoma de Honduras (UNAH)
		Facultad de Ciencias Economicas
	Departamento de Informatica administrativa
         Analisis, Programacion y Evaluacion de Sistemas
                    Tercer Periodo 2023


Equipo:
GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

JOEL ENRIQUE GODOY BONILLA---------(joel.bonilla@unah.hn)

OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

Catedratico analisis y diseño:             Lic. Giancarlo Martini Scalici Aguilar 
catedratico programacion e implementacion: Lic. Karla Melisa Garcia Pineda 
catedratico evaluacion de sistemas:        Lic. Karla Melisa Garcia Pineda 


---------------------------------------------------------------------

Programa:         Pantalla para registrar nuevas reservaciones
Fecha:             25-09-2023
Programador:       Nelson Salgado
descripcion:       Pantalla en la que se registran nuenas reservaciones

-----------------------------------------------------------------------

 */

using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using iText.Layout.Renderer;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using ProyectoHCL.Formularios;
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
using static ProyectoHCL.RecuContra;

namespace ProyectoHCL
{
    public partial class NuevaReservacion : Form
    {
        public NuevaReservacion()
        {

            InitializeComponent();
            combo_tipo();


        }

        //codigo que trae el id del empleado desde el login
        public void id_empleado()
        {
            string valor = Dato.valor;
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select ID_USUARIO from TBL_USUARIO where USUARIO='" + valor + "';");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        txt_codigo.Text = leer["ID_USUARIO"].ToString();
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
            //String ESTADO = cb_estado.SelectedValue.ToString();
            object adb = cb_estado.SelectedItem;
            object b = cb_estado.GetItemText(adb);
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("UpdateH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_habitacion", txt_id.Text);
                cmd.Parameters.AddWithValue("@estado", adb);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {/*
                MsgB m = new MsgB("Error: ", ex.Message);
                DialogResult dR = m.ShowDialog();*/
            }


        }

        public void limpiarCampos()
        {/*
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
            cb_numero.SelectedIndex = 0;*/
            cb_tipo.SelectedIndex = 0;
            // cb_estado.SelectedIndex = 0;


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
        {/*
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select ID_TIPOHABITACION, TIPO from TBL_TIPOHABITACION where ESTADO='ACTIVO';");

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

                  
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }*/

            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;"))
                {
                    

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT ID_TIPOHABITACION, TIPO FROM TBL_TIPOHABITACION WHERE ESTADO='ACTIVO';";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow fila = dt.NewRow();
                    fila["ID_TIPOHABITACION"] = 0;
                    fila["TIPO"] = "Seleccione un tipo";
                    dt.Rows.InsertAt(fila, 0);

                    cb_tipo.ValueMember = "ID_TIPOHABITACION";
                    cb_tipo.DisplayMember = "TIPO";
                    cb_tipo.DataSource = dt;

                    cb_tipo.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb_tipo.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de habitación: {ex.Message}");
            }
           

        }

        private void combo_habitacion(string ID_TIPOHABITACION)
        {
            DateTime fecha1 = dt_fecha_entrada.Value;
            DateTime fecha2 = dt_fecha_salida.Value;

            try
            {
                //using (BaseDatosHCL.ObtenerConexion())
                using (MySqlConnection conexion = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;"))
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = conexion;
                    //comando.Connection = BaseDatosHCL.ObtenerConexion();
                    //comando.CommandText = ("select ID_TIPOHABITACION, NUMEROHABITACION from TBL_HABITACION where ID_TIPOHABITACION=@ID_TIPOHABITACION AND ESTADOHABITACION='ACTIVO';");
                    comando.CommandText = ("SELECT ID_TIPOHABITACION, NUMEROHABITACION FROM TBL_HABITACION WHERE ID_TIPOHABITACION = @ID_TIPOHABITACION AND ESTADOHABITACION = 'ACTIVO' AND NOT EXISTS(SELECT 1 FROM TBL_SOLICITUDRESERVA WHERE TBL_HABITACION.NUMEROHABITACION = TBL_SOLICITUDRESERVA.NUMEROHABITACION AND @fecha1 <= SALIDA AND @fecha2 >= INGRESO);");
                    comando.Parameters.AddWithValue("@fecha1", fecha1);
                    comando.Parameters.AddWithValue("@fecha2", fecha2);
                    comando.Parameters.AddWithValue("ID_TIPOHABITACION", ID_TIPOHABITACION);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow fila = dt.NewRow();
                    //fila["NUMEROHABITACION"] = 0;
                    //dt.Rows.InsertAt(fila, 0);

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


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_cliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void NuevaReservacion_Load(object sender, EventArgs e)
        {
            //id_empleado();


            txt_codigo.Text = clasecompartida.iduser.ToString();

            if (txt_id_solicitud.Text != "")
            {
                //nueva_habitacion.Visible = false;
                btn_guardar2.Visible = true;
                string id = txt_id_solicitud.Text;
                try
                {
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        //comando.CommandText = ("select * from TBL_SOLICITUDRESERVA where ID_SOLICITUDRESERVA='" + id + "';");
                        comando.CommandText = ("call prueba_datos('" + id + "')");
                        MySqlDataReader leer = comando.ExecuteReader();
                        if (leer.Read() == true)
                        {
                            //txt_codigo.Text = leer["ID_USUARIO"].ToString();
                            txt_cod_cliente.Text = leer["COD_CLIENTE"].ToString();
                            txt_estado.Text = leer["ID_ESTADORESERVA"].ToString();
                            switch (Convert.ToInt16(txt_estado.Text))
                            {
                                case 1:
                                    cb_estado.Text = "RESERVADO";
                                    break;
                                case 2:
                                    cb_estado.Text = "CONFIRMADO";
                                    break;
                                case 3:
                                    cb_estado.Text = "ANULADO";
                                    break;
                                case 4:
                                    cb_estado.Text = "FACTURADA";
                                    break;
                            }

                            txt_metodo_reserva.Text = leer["ID_METODORESERVA"].ToString();
                            switch (Convert.ToInt16(txt_metodo_reserva.Text))
                            {
                                case 1:
                                    cb_metodo.Text = "Booking";
                                    break;
                                case 2:
                                    cb_metodo.Text = "Whatsapp";
                                    break;
                                case 3:
                                    cb_metodo.Text = "Airbnb";
                                    break;
                                case 4:
                                    cb_metodo.Text = "Presencial o llamada celular";
                                    break;
                            }
                            //txt_tipo_habitacion.Text = leer[""].ToString();
                            cb_tipo.Text = leer["TIPO"].ToString();
                            cb_numero.Text = leer["NUMEROHABITACION"].ToString();
                            txt_monto.Text = leer["MONTORESERVAR"].ToString();
                            txt_vehiculo.Text = leer["VEHICULO"].ToString();
                            txt_huespedes.Text = leer["NHUESPEDES"].ToString();
                            txt_habi_vieja.Text = leer["NUMEROHABITACION"].ToString();
                            txt_motivo.Text = leer["MOTIVORESERVA"].ToString();
                            // tbl_resultado_habitacion.Visible = true;
                            //lbl_tipo_habitacion.Visible = true;
                            //tbl_resultado_habitacion.Text = leer["TIPO"].ToString();
                            lbl_correo.Visible = true;
                            lbl_telefono.Visible = true;
                            lbl_correonum.Visible = true;
                            lbl_telefononum.Visible = true;
                            lbl_correonum.Text = leer["EMAIL"].ToString();
                            lbl_telefononum.Text = leer["TELEFONO"].ToString();
                            dt_fecha_coti.Value = DateTime.Today;
                            dt_fecha_entrada.Value = Convert.ToDateTime(leer["INGRESO"].ToString());
                            dt_fecha_salida.Value = Convert.ToDateTime(leer["SALIDA"].ToString());
                            if (txt_vehiculo.Text != "0")
                            {
                                radioButton1.Checked = true;
                            }
                            else
                            {
                                radioButton2.Checked = true;
                            }



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
                //combo_cliente();
                //combo_metodo();
                //combo_estado();

            }

        }




        private void cb_metodo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            object adb = cb_metodo.SelectedItem;
            object b = cb_metodo.GetItemText(adb);

            //string nombre = cb_metodo.SelectedValue.ToString();

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select ID_METODORESERVA from TBL_METODORESERVA where DESCRIPCION='" + adb + "'");

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
            if (cb_tipo.SelectedItem != null)
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
                    comando.CommandText = ("select ID_TIPOHABITACION,CAPACIDAD from TBL_TIPOHABITACION where ID_TIPOHABITACION='" + nombre + "';");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        txt_tipo_habitacion.Text = leer["ID_TIPOHABITACION"].ToString();
                        txt_capacidad.Text = leer["CAPACIDAD"].ToString();


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
            object adb = cb_estado.SelectedItem;
            object b = cb_estado.GetItemText(adb);


            //String nombre = cb_estado.SelectedValue.ToString();
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select ID_ESTADORESERVA from TBL_ESTADORESERVA where DESCRIPCION='" + adb + "';");

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
            Int32 C = Convert.ToInt32(txt_capacidad.Text);
            Int32 H = Convert.ToInt32(txt_huespedes.Text);
            /* if (C >= H)
             {
                 MessageBox.Show("correcto");
             }
             else
             {
                 MessageBox.Show("incorrecto");
             }*/

            object adb = cb_numero.SelectedItem;
            object b = cb_numero.GetItemText(adb);

            string fecha1 = dt_fecha_entrada.Text;
            string fecha2 = dt_fecha_salida.Text;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    //comando.CommandText = ("select * from TBL_SOLICITUDRESERVA where NUMEROHABITACION='" + b + "' and INGRESO and SALIDA between '" + fecha1 + "' and '" + fecha2 + "';");
                    comando.CommandText = ("CALL Validar_disponibilidad('" + b + "','" + fecha1 + "', '" + fecha2 + "');");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        MsgB m = new MsgB("advertencia", "Ya existe una reserva para esta habitacion en el mismo rango de fechas");
                        DialogResult dR = m.ShowDialog();
                    }
                    else
                    {
                        if (dt_fecha_coti.Value.Date >= DateTime.Today)
                        {
                            if (dt_fecha_entrada.Value.Date >= DateTime.Today & dt_fecha_entrada.Value.Date < dt_fecha_salida.Value.Date)
                            {
                                if (dt_fecha_salida.Value.Date >= DateTime.Today & dt_fecha_salida.Value.Date > dt_fecha_entrada.Value.Date)
                                {
                                    if (C >= H)
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
                                            cmd.Parameters.AddWithValue("@motivo", txt_motivo.Text);

                                            cmd.ExecuteNonQuery();
                                            inserdetalle();
                                            //updatehabitacion();
                                            MsgB m = new MsgB("informacion", "Reserva agregada con exito");
                                            DialogResult dR = m.ShowDialog();
                                            //CargarDG();
                                            //limpiarCampos();
                                            conn.Close();

                                            this.Close();
                                        }
                                        catch (Exception ex)
                                        {
                                            MsgB m = new MsgB("advertencia", "Validar datos ingresados");
                                            DialogResult dR = m.ShowDialog();
                                        }
                                    }
                                    else
                                    {
                                        MsgB m = new MsgB("advertencia", "El numero de huespedes a reservar excede el numero maximo de la habitacion");
                                        DialogResult dR = m.ShowDialog();
                                    }
                                }
                                else
                                {
                                    MsgB m = new MsgB("advertencia", "Fechas de salida no puede ser menor o igual a la de entrada");
                                    DialogResult dR = m.ShowDialog();

                                }
                            }
                            else
                            {
                                MsgB m = new MsgB("advertencia", "Fechas de entrada no puede ser mayor o igual a la de salida");
                                DialogResult dR = m.ShowDialog();

                            }
                        }//cierre del if 
                        else
                        {
                            MsgB m = new MsgB("advertencia", "Fechas ingresadas invalidas");
                            DialogResult dR = m.ShowDialog();
                        }

                    }
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NuevaReservacion.ActiveForm.Close();
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
            Int32 C = Convert.ToInt32(txt_capacidad.Text);
            Int32 H = Convert.ToInt32(txt_huespedes.Text);

            if (dt_fecha_coti.Value.Date >= DateTime.Today)
            {
                if (dt_fecha_entrada.Value.Date >= DateTime.Today & dt_fecha_entrada.Value.Date < dt_fecha_salida.Value.Date)
                {
                    if (dt_fecha_salida.Value.Date >= DateTime.Today & dt_fecha_salida.Value.Date > dt_fecha_entrada.Value.Date)
                    {
                        if (C >= H)
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
                                cmd.Parameters.AddWithValue("@motivo", txt_motivo.Text);

                                cmd.ExecuteNonQuery();
                                updatedetalle();
                                //updatehabitacion();
                                //updatenumero();

                                MsgB m = new MsgB("informacion", "Reserva actualizada con exito");
                                DialogResult dR = m.ShowDialog();
                                //limpiarCampos();


                                conn.Close();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MsgB m = new MsgB("advertencia", "Validar los datos Ingresados");
                                DialogResult dR = m.ShowDialog();
                            }
                        }
                        else
                        {
                            MsgB m = new MsgB("advertencia", "El numero de huespedes a reservar excede el numero maximo de la habitacion");
                            DialogResult dR = m.ShowDialog();

                        }
                    }
                    else
                    {
                        MsgB m = new MsgB("advertencia", "Fechas de salida no puede ser menor a la de entrada");
                        DialogResult dR = m.ShowDialog();

                    }
                }
                else
                {
                    MsgB m = new MsgB("advertencia", "Fechas de entrada no puede ser mayor a la de salida");
                    DialogResult dR = m.ShowDialog();

                }
            }//cierre if 
            else
            {
                MsgB m = new MsgB("advertencia", "Fechas ingresadas invalidas");
                DialogResult dR = m.ShowDialog();

            }

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            if (txt_codigo.Text != "")
            {

            }
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MsgB m = new MsgB("advertencia", "Solo se pueden ingresar numeros ");
                DialogResult dR = m.ShowDialog();
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_huespedes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MsgB m = new MsgB("advertencia", "Solo se pueden ingresar numeros ");
                DialogResult dR = m.ShowDialog();
            }
            /*
            String nombre = cb_tipo.SelectedValue.ToString();
            string num =txt_huespedes.Text;
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    // comando.CommandText = ("select CAPACIDAD from TBL_TIPOHABITACION where TIPO='" + nombre + "';");
                    comando.CommandText = ("call capacidad('" +num + "','" + nombre + "');");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        Int32 capacidad = Convert.ToInt32( leer["resultado"].ToString());
                        
                        if (capacidad ==1)
                        {

                        }
                        else
                        {
                            MsgB m = new MsgB("advertencia", "El numero de huespedes exede la capacidad maxima de la habitacion ");
                            DialogResult dR = m.ShowDialog();
                            txt_huespedes.Clear();
                        }
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_vehiculo.Text = "1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_vehiculo.Text = "0";
        }

        private void txt_huespedes_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_monto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nuevo = new Buscar();
            nuevo.Show();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dt_fecha_entrada_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan noches = dt_fecha_salida.Value - dt_fecha_entrada.Value;
            int days = (int)noches.TotalDays;
            lbl_noches.Text = Convert.ToString(days);

        }

        private void dt_fecha_salida_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan noches = dt_fecha_salida.Value - dt_fecha_entrada.Value;
            int days = (int)noches.TotalDays;
            lbl_noches.Text = Convert.ToString(days);
        }
    }
}

