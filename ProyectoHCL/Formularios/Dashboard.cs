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

Programa:         Pantalla Dasboard
Fecha:             25-09-2023
Programador:       Nelson Salgado
descripcion:       Pantalla en la que estan todos los accesos a cada una de las modulos del proyecto

-----------------------------------------------------------------------

 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System.Runtime.InteropServices;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.VisualBasic.ApplicationServices;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using ProyectoHCL.Formularios;
using ProyectoHCL.Formularios.Parametros;
using iText.Layout.Element;

namespace ProyectoHCL
{
    public partial class Dashboard : Form
    {
        int a;
        private MySqlConnection conn;
        private DateTime mesAnio;
        private string habitacion;
        public static int static_anio, static_mes;

        public class Reserva
        {
            public DateTime FechaIngreso { get; set; } //propiedad de la clase reserva para almacenar fecha de ingreso de la reservación
            public DateTime FechaSalida { get; set; } //propiedad de la clase reserva para almacenar fecha de salida de la reservación
        }

        public Dashboard()
        {
            InitializeComponent();
            panel2.BackColor = System.Drawing.Color.FromArgb(100, panel2.BackColor);
            hideSubMenu();
            cargarHabitaciones();
        }

        /*
         * Codigo donde vaida los permisos de cada usuario 
         */
        private void Permisos()
        {
            CDatos cDatos = new CDatos();

            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs);

            foreach (var obj in LsObj)
            {
                switch (obj.ObjetoN)
                {
                    case "HABITACIONES":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_usuarios.Visible = false;
                        }
                        break;
                    case "DESCUENTOS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            iconButton1.Visible = false;
                        }
                        break;
                    case "USUARIOS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_clientes.Visible = false;
                        }
                        break;
                    case "SERVICIOS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_habitaciones.Visible = false;
                        }
                        break;
                    case "OBJETOS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_objetos.Visible = false;
                        }
                        break;
                    case "TIPO HABITACION":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            lbtn_descuentos.Visible = false;
                        }
                        break;
                    case "FACTURACION":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_facturacion.Visible = false;
                        }
                        break;
                    case "RESERVACION":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_reservacion.Visible = false;
                        }
                        break;
                    case "ROLES":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_roles.Visible = false;
                        }
                        break;
                    case "PERMISOS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_permisos.Visible = false;
                        }
                        break;
                    case "PARAMETROS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_parametros.Visible = false;
                        }
                        break;
                    case "CLIENTES":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_servicios.Visible = false;
                        }
                        break;
                    case "BITACORA":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            iconButton3.Visible = false;
                        }
                        break;
                    case "PREGUNTAS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            iconButton2.Visible = false;
                        }
                        break;
                    case "BACKUP":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            iconButton4.Visible = false;
                        }
                        break;
                    case "RESTORE":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            iconButton5.Visible = false;
                        }
                        break;
                }

            }

        }

        private void cargarHabitaciones() //Llenar el combobox con los roles almacenados en la tabla TBL_ROL
        {
            string connectionString = "server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT NUMEROHABITACION FROM TBL_HABITACION";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbHabitacion.Items.Add(reader["NUMEROHABITACION"].ToString()); //Cargar combobox con los números de las habitaciones
                }
                reader.Close();
                conn.Close();
            }
        }

        public List<Reserva> ObtenerReservas(DateTime fechaActual, string habitacionS) //obtener lista de las reservas recibiendo el valor de la fecha actual y la habitación seleccionada
        {
            List<Reserva> reservas = new List<Reserva>(); //crear objeto de lista reserva

            string connectionString = "server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT INGRESO, SALIDA FROM TBL_SOLICITUDRESERVA WHERE NUMEROHABITACION = @habitacion " +
                    "AND (ID_ESTADORESERVA = 1 OR ID_ESTADORESERVA = 2 " +
                    "AND MONTH(INGRESO) = @mes AND YEAR(INGRESO) = @anio";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                //parámetros que recibe la consulta select
                cmd.Parameters.AddWithValue("@mes", fechaActual.Month);
                cmd.Parameters.AddWithValue("@anio", fechaActual.Year);
                cmd.Parameters.AddWithValue("@habitacion", habitacionS);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reserva reserva = new Reserva //objeto de la clase Reserva
                        {
                            //fechas de ingreso y salida obtenidas de la consulta select
                            FechaIngreso = reader.GetDateTime("INGRESO"),
                            FechaSalida = reader.GetDateTime("SALIDA")
                        };
                        reservas.Add(reserva); //se agrega la reserva a la lista
                    }
                }
            }

            return reservas; //se devuelve la lista de reservas
        }

        int mes, año;

        void MostrarDias()
        {
            DateTime mesAño = new DateTime(año, mes, 1); //año, mes y el primer día del mes seleccionado en el calendario
            LBLMES.Text = mesAño.ToString("MMMM").ToUpper() + " | " + año; //label para mostrar el nombre del mes y el año

            mesAnio = mesAño;

            static_mes = mes;
            static_anio = año;

            string hab = habitacion;

            int dias = DateTime.DaysInMonth(año, mes);

            int diaSemana = ((int)mesAño.DayOfWeek + 1); //Lunes = 1, Domingo = 8

            //verificar si diaSemana es igual o mayor que 8, y si lo es,
            //restar 8 al valor actual. 
            if (diaSemana >= 8)
            {
                diaSemana -= 8;
            }

            for (int i = 1; i < diaSemana; i++)
            {
                UserControlCalendario calendario = new UserControlCalendario(); //objeto del tipo UserControlCalendario
                ContenedorDias.Controls.Add(calendario); //Mostrar en el FlowLayOutPanel(Contenedor días) los días en el calendario,
                                                         //llenandolo con controles UserControlCalendario
            }

            for (int i = 1; i <= dias; i++)
            {
                UserControlDias semanaDia = new UserControlDias(); //objeto del tipo UserControlDias
                //Mostrar en el FlowLayOutPanel(Contenedor días) los días de la semana del mes seleccionado,
                //llenandolo con controles UserControlDias
                semanaDia.Dias(i);
                ContenedorDias.Controls.Add(semanaDia);
            }

            LlenarCalendario(mesAño, hab); //Se llama función para mostrar las reservas, recibiendo la fecha actual y la habitación seleccionada del combobox
        }

        public void LlenarCalendario(DateTime fechaActual, string habitacionS)
        {
            List<Reserva> reservas = ObtenerReservas(fechaActual, habitacionS);

            foreach (var control in ContenedorDias.Controls)
            {
                if (control is UserControl userControl)
                {
                    if (userControl.Controls.Find("lblDias", true).FirstOrDefault() is Label lblDias)
                    {
                        int dia = int.Parse(lblDias.Text);

                        bool reservaEnEsteDia = false;

                        foreach (var reserva in reservas)
                        {
                            if (reserva.FechaIngreso <= fechaActual.AddDays(dia - 1) && reserva.FechaSalida >= fechaActual.AddDays(dia - 1))
                            {
                                reservaEnEsteDia = true;
                                break;
                            }
                        }

                        if (reservaEnEsteDia)
                        {
                            if (userControl.Controls.Find("pboxReservado", true).FirstOrDefault() is PictureBox pboxReservado)
                            {
                                pboxReservado.Visible = true;
                            }
                        }
                        else
                        {
                            if (userControl.Controls.Find("pboxReservado", false).FirstOrDefault() is PictureBox pboxReservado)
                            {
                                pboxReservado.Visible = false;
                            }
                        }
                    }
                }
            }
        }



        //codigo de los submenu del dashboard
        private void hideSubMenu()
        {

            panelmanteSubMenu.Visible = false;
            paneladminSubMenu.Visible = false;
        }

        private void hideSubMenu2()
        {
            if (panelmanteSubMenu.Visible == true)
                panelmanteSubMenu.Visible = false;
            if (paneladminSubMenu.Visible == true)
                paneladminSubMenu.Visible = false;
        }
        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void Dashboard_Load(object sender, EventArgs e)
        {
            Permisos();
            MsgB mbox = new MsgB("bienvenida", "Inicio de sesión exitoso");
            DialogResult dR = mbox.ShowDialog();
            DateTime ahora = DateTime.Now;
            mes = ahora.Month;
            año = ahora.Year;
            MostrarDias();


            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("call estado_reserva(1,2,3,4,'ACTIVO','INACTIVO')");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        lbl_pendientes.Text = leer["pendientes"].ToString();
                        lbl_activas.Text = leer["activas"].ToString();
                        lbl_inactivas.Text = leer["inactivas"].ToString();
                        lbl_confirmadas.Text = leer["confirmadas"].ToString();
                        lbl_anuladas.Text = leer["anuladas"].ToString();
                        lbl_facturadas.Text = leer["facturadas"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("error al cargar");
                    }
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }


        }

        //codigo de cada uno de los botones para el acceso a los modulos del sistema 

        private void Ibtn_administracion_Click(object sender, EventArgs e)
        {
            showSubMenu(paneladminSubMenu);
        }

        private void Ibtn_mantenimiento_Click_2(object sender, EventArgs e)
        {
            showSubMenu(panelmanteSubMenu);
        }

        private void Ibtn_mantenimiento_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelmanteSubMenu);
        }

        private void Ibtn_roles_Click_1(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlRoles());
            hideSubMenu2();
        }

        private void Ibtn_objetos_Click_1(object sender, EventArgs e)
        {
            //codigo para el formilario
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlObjetos());
            hideSubMenu2();
        }

        private void Ibtn_permisos_Click_1(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new R_R_RolesPermisos());
            hideSubMenu2();
        }

        private void Ibtn_parametros_Click_1(object sender, EventArgs e)
        {
            //codigo para el formilario
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlParametro());
            hideSubMenu2();
        }

        private void Ibtn_reservacion_Click_1(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new Reservaciones());


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panelChildForm.Visible = false;
        }

        private void pbx_habitaciones_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
        private void Ibtn_clientes_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlUsuarios());
            //hideSubMenu2();
        }

        private void Ibtn_facturacion_Click_1(object sender, EventArgs e)
        {
            //codigo para el formilario
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlFacturacion());
            //hideSubMenu2();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlTipoHabitacion());
            hideSubMenu2();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlPreguntas());
            hideSubMenu2();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlBitacora());
            hideSubMenu2();
        }


        private void Ibtn_reservacion_Click(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new Reservaciones());
        }

        private void Ibtn_perfil_Click(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new PerfilUsuario());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new Backup());
            hideSubMenu2();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new Restore());
            hideSubMenu2();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            //codigo para el formilario
            panelChildForm.Visible = true;
            openChildFormInPanel(new CalendarioReservas());
            hideSubMenu2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new CalendarioReservas());
        }



        private void iconButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            mes--;

            if (mes == 0)
            {
                año--;
                mes = 12;
            }

            ContenedorDias.Controls.Clear();

            MostrarDias();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            mes++;

            if (mes == 13)
            {
                año++;
                mes = 1;
            }

            ContenedorDias.Controls.Clear(); //Limpiar los controles en el contenedorDias

            MostrarDias();
        }

        private void cmbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Asignar valor a habSeleccionada con el valor seleccionado en combobox
            string habSeleccionada = cmbHabitacion.SelectedItem.ToString();
            habitacion = habSeleccionada;
            clases.CDatos.numHabDR = habSeleccionada;
            DateTime fecha = mesAnio;
            LlenarCalendario(fecha, habSeleccionada);
        }

        private void iconButton6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ibtn_usuarios_Click_1(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlClientes());
            hideSubMenu2();
        }

        private void Ibtn_habitaciones_Click_1(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlHabitaciones());
            hideSubMenu2();
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlTipoHabitacion());
            hideSubMenu2();
        }

        private void Ibtn_servicios_Click_1(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlServicios());
            hideSubMenu2();
        }

        private void lbtn_descuentos_Click(object sender, EventArgs e)
        {
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlDescuentos());
            hideSubMenu2();
        }
    }
}
