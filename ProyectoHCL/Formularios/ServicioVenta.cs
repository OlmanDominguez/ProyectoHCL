using DocumentFormat.OpenXml.Drawing;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

using static ProyectoHCL.RecuContra;
using static ProyectoHCL.Formularios.CtrlFacturacion;
using static ProyectoHCL.Formularios.ShowFactura;
using DocumentFormat.OpenXml.ExtendedProperties;
using SpreadsheetLight;

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

//Programa:         Venta de servicios
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Pantalla para registrar los servicios de habitación

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
    public partial class ServicioVenta : Form
    {
        public ServicioVenta()
        {
            InitializeComponent();
            cargarServicios();
            cmbServicio.SelectedIndex = -1;
            //deshabilitar botones mientras no se elija una habitación
            //btnAgregar.Enabled = false;
            //btnAgregar.BackColor = Color.DarkGray;
            //btnEliminar.Enabled = false;
            //btnEliminar.BackColor = Color.DarkGray;
            //btnVenta.Enabled = false;
            //btnVenta.BackColor = Color.DarkGray;
            //cmbServicio.Enabled = false;
        }

        private void limpiarCampos() //limpiar campos de formulario
        {
            txtTotal.Clear();
            cmbServicio.SelectedIndex = -1;
            txtPrecio.Clear();
            txt_cantidad.Clear();
            lblHabitacion.Text = "";
            lblCliente.Text = "";
            lblEntrada.Text = "";
            lblSalida.Text = "";
        }

        public void limpiarError() //limpiar los errorProvider
        {
            errorT.SetError(cmbServicio, "");
            errorT.SetError(txt_cantidad, "");
        }

        private void cargarServicios() //llenar combobox con los registros de la base de datos
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            cmbServicio.DataSource = null;
            cmbServicio.Items.Clear();
            string sql = "SELECT ID_SERVICIO, DESCRIPCION FROM TBL_SERVICIO;";

            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            try
            {
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cmbServicio.ValueMember = "ID_SERVICIO";
                cmbServicio.DisplayMember = "DESCRIPCION";
                cmbServicio.DataSource = dt;

            }
            catch (MySqlException e)
            {
                MsgB m = new MsgB("Error", "Se produjo un error " + e.Message);
                DialogResult dR = m.ShowDialog();
            }
            finally { conn.Close(); }
        }

        public decimal Precio() //obtener precio del servicio seleccionado en el combobox
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = BaseDatosHCL.ObtenerConexion();
            comando.CommandText = ("SELECT PRECIO FROM TBL_SERVICIO WHERE DESCRIPCION = '"
                + cmbServicio.Text + "';");

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                return (decimal)leer["PRECIO"];
            }
            else
            {
                return 0;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e) //función para agregar un nuevo servicio 
        {
            if (cmbServicio.Text == "") //validar campo vacío
            {
                MsgB Mbox = new MsgB("advertencia", "Seleccione un servicio");
                DialogResult DR = Mbox.ShowDialog();
            }
            else if (txt_cantidad.Text == "") //validar campo vacío
            {
                MsgB Mbox = new MsgB("advertencia", "Ingrese una cantidad");
                DialogResult DR = Mbox.ShowDialog();
            }
            else
            {
                //agregar los servicios al listview
                ListViewItem lista = new ListViewItem(cmbServicio.Text);
                lista.SubItems.Add(txtPrecio.Text);
                lista.SubItems.Add(txt_cantidad.Text);
                Decimal subt = Convert.ToDecimal(txt_cantidad.Text) * Convert.ToDecimal(txtPrecio.Text);
                lista.SubItems.Add(Convert.ToString(subt));
                listView.Items.Add(lista);

                //calcular total de la suma de los servicios agregados
                decimal resultadoActual = decimal.Parse(txtTotal.Text);
                resultadoActual += subt;

                txtTotal.Text = Convert.ToString(resultadoActual);

                try
                {
                    using (BaseDatosHCL.ObtenerConexion())
                    {
                        //insertar en la tabla TBL_DETALLESERVICIO el registro de los servicios agregados
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = "SELECT * FROM TBL_SERVICIO WHERE DESCRIPCION = '" + cmbServicio.Text + "';";
                        MySqlDataReader leer = comando.ExecuteReader();

                        int id = 0;
                        if (leer.Read())
                        {
                            id = (int)leer["ID_SERVICIO"];
                        }


                        comando.Connection.Close();

                        comando.Connection = BaseDatosHCL.ObtenerConexion();
                        comando.CommandText = ("INSERT INTO TBL_DETALLESERVICIO (ID_SERVICIO, ID_SOLICITUDRESERVA, ID_DESCUENTO, CANTIDAD, " +
                            "MONTODESCUENTO) VALUES(" + id + ", " + info.reserva + ", 1, " + txt_cantidad.Text + ", 0);");

                        comando.ExecuteNonQuery();
                        comando.Connection.Close();

                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);
                }

                txt_cantidad.Text = "";
                ActualizarResultado();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e) //botón para eliminar un elemento del listview
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];

                decimal precio = decimal.Parse(item.SubItems[1].Text);
                decimal resultadoActual = decimal.Parse(txtTotal.Text);
                //restar precio del elemento eliminado
                resultadoActual -= precio;
                txtTotal.Text = resultadoActual.ToString();


                if (Convert.ToInt32(item.SubItems[2].Text) == 1)
                {
                    int id = 0;
                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            //borrar en la tabla TBL_DETALLESERVICIO el registro de los servicios eliminados
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = "SELECT * FROM TBL_SERVICIO WHERE DESCRIPCION = '" + item.SubItems[0].Text + "';";
                            MySqlDataReader leer = comando.ExecuteReader();

                            id = 0;
                            if (leer.Read())
                            {
                                id = (int)leer["ID_SERVICIO"];
                            }


                            comando.Connection.Close();

                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("DELETE FROM TBL_DETALLESERVICIO WHERE ID_SOLICITUDRESERVA = " +
                                info.reserva + " and ID_SERVICIO = " + id + " and CANTIDAD = 1;");

                            comando.ExecuteNonQuery();
                            comando.Connection.Close();


                            listView.Items.Remove(item);
                        }

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message + a.StackTrace);
                    }



                }
                else
                {
                    int id = 0;
                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = "SELECT * FROM TBL_SERVICIO WHERE DESCRIPCION = '" + item.SubItems[0].Text + "';";
                            MySqlDataReader leer = comando.ExecuteReader();

                            id = 0;
                            if (leer.Read())
                            {
                                id = (int)leer["ID_SERVICIO"];
                            }

                            comando.Connection.Close();

                        }

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message + a.StackTrace);
                    }

                    int idds = 0;

                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("SELECT ID_DETALLESERVICIO, CANTIDAD FROM TBL_DETALLESERVICIO WHERE ID_SOLICITUDRESERVA = " +
                                info.reserva + " and ID_SERVICIO = " + id + "  ORDER BY CANTIDAD ASC;");

                            MySqlDataReader leer3 = comando.ExecuteReader();
                            if (leer3.Read())
                            {
                                idds = (int)leer3["ID_DETALLESERVICIO"];
                            }


                            comando.Connection.Close();

                            listView.Items.Remove(item);

                        }

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message + a.StackTrace);
                    }

                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = ("UPDATE TBL_DETALLESERVICIO SET CANTIDAD = " + (Convert.ToInt32(item.SubItems[2].Text) - 1) + " WHERE ID_SOLICITUDRESERVA = " +
                                info.reserva + " and ID_SERVICIO = " + id + " and ID_DETALLESERVICIO = " + idds + ";");

                            comando.ExecuteNonQuery();
                            comando.Connection.Close();

                            listView.Items.Remove(item);

                        }

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message + a.StackTrace);
                    }

                    try
                    {
                        using (BaseDatosHCL.ObtenerConexion())
                        {
                            MySqlCommand comando = new MySqlCommand();

                            comando.Connection = BaseDatosHCL.ObtenerConexion();
                            comando.CommandText = "SELECT ds.CANTIDAD, s.PRECIO, s.DESCRIPCION  FROM TBL_DETALLESERVICIO ds " +
                                "INNER JOIN TBL_SERVICIO s ON ds.ID_SERVICIO = s.ID_SERVICIO " +
                                "WHERE ds.ID_SERVICIO = " + id + " AND ds.ID_SOLICITUDRESERVA = " + info.reserva + " and ID_DETALLESERVICIO = " + idds + ";";
                            MySqlDataReader leer2 = comando.ExecuteReader();

                            if (leer2.Read())
                            {
                                ListViewItem lista = new ListViewItem(leer2["DESCRIPCION"].ToString());
                                lista.SubItems.Add(leer2["PRECIO"].ToString());
                                lista.SubItems.Add(leer2["CANTIDAD"].ToString());
                                decimal subt = Convert.ToDecimal(leer2["CANTIDAD"].ToString()) * Convert.ToDecimal(leer2["PRECIO"].ToString());
                                lista.SubItems.Add(subt.ToString());
                                listView.Items.Add(lista);

                            }
                            comando.Connection.Close();
                        }

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message + a.StackTrace);
                    }



                }
            }
            else
            {
                MsgB Mbox = new MsgB("advertencia", "Seleccione un item de la lista"); //validar que se haya seleccionado un elemento de la lista
                DialogResult DR = Mbox.ShowDialog();
            }
        }

        private void btnVenta_Click(object sender, EventArgs e) //validar si el listview está vacío
        {
            if (listView.Items.Count == 0)
            {
                MsgB m = new MsgB("pregunta", "No hay items en la lista. ¿Desea continuar?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    MsgB mbox = new MsgB("informacion", "Servicios registrados exitosamente");
                    DialogResult dR = mbox.ShowDialog();
                    listView.Items.Clear(); //limpiar listview al guardar
                    limpiarCampos();
                    this.Close();
                }
                else if (dg == DialogResult.Cancel)
                {

                }
            }
            else
            {
                MsgB mbox = new MsgB("informacion", "Servicios registrados exitosamente");
                DialogResult dR = mbox.ShowDialog();
                listView.Items.Clear(); //limpiar listview al guardar
                limpiarCampos();
                this.Close();
            }
        }

        public int NumeroHabitacion(string nombre, string apellido, DateTime fechaIngreso, DateTime fechaSalida)
        {
            int numeroHabitacion = -1; // Valor por defecto si no se encuentra ninguna coincidencia

            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                // Consulta SQL para obtener el número de habitación
                string query = "SELECT s.NUMEROHABITACION FROM TBL_SOLICITUDRESERVA s " +
                               "INNER JOIN TBL_CLIENTE c ON s.COD_CLIENTE = c.CODIGO " +
                               "WHERE c.NOMBRE = @Nombre AND c.APELLIDO = @Apellido " +
                               "AND s.INGRESO <= @FechaIngreso " +
                               "AND s.SALIDA >= @FechaSalida";

                using (MySqlCommand cmd = new MySqlCommand(query, conectar))
                {
                    // Parámetros para la consulta
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@FechaIngreso", fechaIngreso);
                    cmd.Parameters.AddWithValue("@FechaSalida", fechaSalida);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            numeroHabitacion = reader.GetInt32("NUMEROHABITACION");
                        }
                    }
                }
            }

            return numeroHabitacion;
        }


        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecio.Text = Precio().ToString(); //asignar valor del precio del servicio al textbox
        }

        private void ActualizarResultado() //actualizar total
        {
            decimal resultado = 0;
            foreach (ListViewItem item in listView.Items)
            {
                resultado += decimal.Parse(item.SubItems[1].Text);
            }
            txtTotal.Text = resultado.ToString();
        }

        private void btnReservacion_Click(object sender, EventArgs e)
        {
            using (ServicioHab servHab = new ServicioHab()) //llenar los textbox al elegir la reservación
            {
                servHab.ShowDialog(this);
            }
            //txtHab.Text = clases.CDatos.numeroHab.ToString();
            //txtCliente.Text = clases.CDatos.cliente.ToString();
            //txtEntrada.Text = clases.CDatos.entrada.ToString();
            //txtSalida.Text = clases.CDatos.salida.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e) //cerrar formulario
        {
            this.Close();
            limpiarError();
        }

        private void txtHab_TextChanged(object sender, EventArgs e)
        {
            if (lblHabitacion.Text == "") //deshabilitar controles si el textbox está vacío
            {
                btnAgregar.Enabled = false;
                btnAgregar.BackColor = Color.DarkGray;
                btnEliminar.Enabled = false;
                btnEliminar.BackColor = Color.DarkGray;
                btnVenta.Enabled = false;
                btnVenta.BackColor = Color.DarkGray;
                cmbServicio.Enabled = false;
            }
            else //habilitar controles si el textbox tiene datos
            {
                btnAgregar.Enabled = true;
                btnAgregar.BackColor = Color.CadetBlue;
                btnEliminar.Enabled = true;
                btnEliminar.BackColor = Color.Red;
                btnVenta.Enabled = true;
                btnVenta.BackColor = Color.CadetBlue;
                cmbServicio.Enabled = true;
            }
        }

        private void cmbServicio_Leave(object sender, EventArgs e) //validar campo vacío
        {
            if (ValidarTxt.cmbVacio(cmbServicio))
            {
                errorT.SetError(cmbServicio, "Seleccione un servicio");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void cmbEstado_Leave(object sender, EventArgs e) //validar campo vacío
        {
            if (txt_cantidad.Text == "")
            {
                errorT.SetError(txt_cantidad, "Seleccione un estado");
            }
            else
            {
                errorT.Clear();
            }
        }

        private void ServicioVenta_Load(object sender, EventArgs e)
        {
            if (info.est == 2)
            {
                //llenar los textbox al elegir la reservación
                btnReservacion.Visible = false;
                lblHabitacion.Text = NumeroHabitacion(CDatos.nombreCliente, CDatos.apellidoCliente, Convert.ToDateTime(info.ingreso), Convert.ToDateTime(info.salida)).ToString();
                lblCliente.Text = CDatos.nombre.ToString();
                lblEntrada.Text = info.ingreso.ToString();
                lblSalida.Text = info.salida.ToString();

                DataTable st = new DataTable();

                try
                {

                    string stri = "SELECT s.DESCRIPCION, ds.CANTIDAD, s.PRECIO " +
                                  "FROM TBL_DETALLESERVICIO ds " +
                                  "INNER JOIN TBL_SERVICIO s ON ds.ID_SERVICIO = s.ID_SERVICIO " +
                                  "where ds.ID_SOLICITUDRESERVA = " + info.reserva + ";";


                    MySqlConnection conn;
                    MySqlCommand cmd;
                    conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                    conn.Open();

                    cmd = new MySqlCommand(stri, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(st);
                    conn.Close();

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + a.StackTrace);

                }

                int s = st.Rows.Count;
                int i = 0;
                decimal total = 0;

                if (s > 0)
                {
                    while (i < s)
                    {
                        ListViewItem lista = new ListViewItem(st.Rows[i]["DESCRIPCION"].ToString());
                        lista.SubItems.Add(st.Rows[i]["PRECIO"].ToString());
                        lista.SubItems.Add(st.Rows[i]["CANTIDAD"].ToString());
                        lista.SubItems.Add(Convert.ToString(Convert.ToDecimal(st.Rows[i]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[i]["PRECIO"])));
                        listView.Items.Add(lista);

                        total += Convert.ToDecimal(st.Rows[i]["CANTIDAD"]) * Convert.ToDecimal(st.Rows[i]["PRECIO"]);

                        i = i + 1;
                    }
                }

                txtTotal.Text = total.ToString();
            }
            else
            {
                btnReservacion.Visible = true;
            }
        }

        //coordenadas para arrastrar formulario
        int posY = 0;
        int posX = 0;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
