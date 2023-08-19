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

        public Dashboard()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void Permisos()
        {
            CDatos cDatos = new CDatos();

            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs);

            foreach (var obj in LsObj)
            {
                switch (obj.IdObjeto)
                {
                    case "HABITACIONES":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_habitaciones.Enabled = false;
                        }
                        break;
                    case "DESCUENTOS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_descuentos.Enabled = false;
                        }
                        break;
                    case "USUARIOS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_clientes.Enabled = false;
                        }
                        break;
                    case "SERVICIOS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_servicios.Enabled = false;
                        }
                        break;
                    case "OBJETOS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_objetos.Enabled = false;
                        }
                        break;
                    case "TIPO HABITACION":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            iconButton1.Enabled = false;
                        }
                        break;
                    case "FACTURACION":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_facturacion.Enabled = false;
                        }
                        break;
                    case "RESERVACION":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_reservacion.Enabled = false;
                        }
                        break;
                    case "ROLES":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_roles.Enabled = false;
                        }
                        break;
                    case "PERMISOS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_permisos.Enabled = false;
                        }
                        break;
                    case "PARAMETROS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_parametros.Enabled = false;
                        }
                        break;
                    case "CLIENTES":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_usuarios.Enabled = false;
                        }
                        break;
                    case "BITACORA":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            iconButton3.Enabled = false;
                        }
                        break;
                    case "PREGUNTAS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_usuarios.Enabled = false;
                        }
                        break;
                }

            }

        }

        private void hideSubMenu()
        {

            panelmanteSubMenu.Visible = false;
            paneladminSubMenu.Visible = false;
        }
        private void mostrarhabitaciones()
        {
            //panelChildForm.Visible = false;
            dgv_habitacion.Visible = false;
            lbl_fechas.Visible = false;
            lbl_cerrar.Visible = false;
            pbt_fechas.Visible = false;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("call habitaciones_disponibles('1','2','3','4','5','6','7','8','9','10','11','12','13','14','15','20');");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        lbl_1.Text = leer["h1"].ToString();
                        lbl_2.Text = leer["h2"].ToString();
                        lbl_3.Text = leer["h3"].ToString();
                        lbl_4.Text = leer["h4"].ToString();
                        lbl_5.Text = leer["h5"].ToString();
                        lbl_6.Text = leer["h6"].ToString();
                        lbl_7.Text = leer["h7"].ToString();
                        lbl_8.Text = leer["h8"].ToString();
                        lbl_9.Text = leer["h9"].ToString();
                        lbl_10.Text = leer["h10"].ToString();
                        lbl_11.Text = leer["h11"].ToString();
                        lbl_12.Text = leer["h12"].ToString();
                        lbl_13.Text = leer["h13"].ToString();
                        lbl_14.Text = leer["h14"].ToString();
                        lbl_15.Text = leer["h15"].ToString();
                        lbl_16.Text = leer["h16"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("error al cargar");
                    }
                    //1
                    if (lbl_1.Text == "RESERVADO")
                    {
                        pbt_h1.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_1.Text == "DISPONIBLE")
                    {
                        pbt_h1.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h1.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //2
                    if (lbl_2.Text == "RESERVADO")
                    {
                        pbt_h2.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_2.Text == "DISPONIBLE")
                    {
                        pbt_h2.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h2.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //3
                    if (lbl_3.Text == "RESERVADO")
                    {
                        pbt_h3.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_3.Text == "DISPONIBLE")
                    {
                        pbt_h3.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h3.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //4
                    if (lbl_4.Text == "RESERVADO")
                    {
                        pbt_h4.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_4.Text == "DISPONIBLE")
                    {
                        pbt_h4.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h4.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //5
                    if (lbl_5.Text == "RESERVADO")
                    {
                        pbt_h5.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_5.Text == "DISPONIBLE")
                    {
                        pbt_h5.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h5.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //6
                    if (lbl_6.Text == "RESERVADO")
                    {
                        pbt_h6.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_6.Text == "DISPONIBLE")
                    {
                        pbt_h6.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h6.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //7
                    if (lbl_7.Text == "RESERVADO")
                    {
                        pbt_h7.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_7.Text == "DISPONIBLE")
                    {
                        pbt_h7.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h7.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //8
                    if (lbl_8.Text == "RESERVADO")
                    {
                        pbt_h8.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_8.Text == "DISPONIBLE")
                    {
                        pbt_h8.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h8.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //9
                    if (lbl_9.Text == "RESERVADO")
                    {
                        pbt_h9.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_9.Text == "DISPONIBLE")
                    {
                        pbt_h9.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h9.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //10
                    if (lbl_10.Text == "RESERVADO")
                    {
                        pbt_h10.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_10.Text == "DISPONIBLE")
                    {
                        pbt_h10.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h10.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //11
                    if (lbl_11.Text == "RESERVADO")
                    {
                        pbt_h11.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_11.Text == "DISPONIBLE")
                    {
                        pbt_h11.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h11.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //12
                    if (lbl_12.Text == "RESERVADO")
                    {
                        pbt_h12.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_12.Text == "DISPONIBLE")
                    {
                        pbt_h12.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h12.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //13
                    if (lbl_13.Text == "RESERVADO")
                    {
                        pbt_h13.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_13.Text == "DISPONIBLE")
                    {
                        pbt_h13.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h13.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //14
                    if (lbl_14.Text == "RESERVADO")
                    {
                        pbt_h14.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_14.Text == "DISPONIBLE")
                    {
                        pbt_h14.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h14.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //15
                    if (lbl_15.Text == "RESERVADO")
                    {
                        pbt_h15.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_15.Text == "DISPONIBLE")
                    {
                        pbt_h15.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h15.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }
                    //16
                    if (lbl_16.Text == "RESERVADO")
                    {
                        pbt_h16.BackgroundImage = ProyectoHCL.Properties.Resources.Reservada_;
                    }
                    else if (lbl_16.Text == "DISPONIBLE")
                    {
                        pbt_h16.BackgroundImage = ProyectoHCL.Properties.Resources.disponible_;
                    }
                    else
                    {
                        pbt_h16.BackgroundImage = ProyectoHCL.Properties.Resources.ocupado_;
                    }


                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }


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
            mostrarhabitaciones();
            //panelChildForm.Visible = false;
            dgv_habitacion.Visible = false;
            lbl_fechas.Visible = false;
            lbl_cerrar.Visible = false;
            pbt_fechas.Visible = false;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("call estado_reserva(1,2,3,'RESERVADO','DISPONIBLE')");

                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        lbl_pendientes.Text = leer["pendientes"].ToString();
                        lbl_reservadas.Text = leer["reservadas"].ToString();
                        lbl_disponible.Text = leer["disponibles"].ToString();
                        lbl_confirmadas.Text = leer["confirmadas"].ToString();
                        lbl_anuladas.Text = leer["anuladas"].ToString();

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

        private void Ibtn_administracion_Click(object sender, EventArgs e)
        {
            showSubMenu(paneladminSubMenu);
        }

        private void Ibtn_habitaciones_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlHabitaciones());
            //hideSubMenu2();
        }

        private void Ibtn_servicios_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlServicios());
            //hideSubMenu2();
        }

        private void Ibtn_descuentos_Click(object sender, EventArgs e)
        {
            //codigo para el formilario
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlDescuentos());
            //hideSubMenu2();
        }

        private void Ibtn_usuarios_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlClientes());
            //hideSubMenu2();
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
            //hideSubMenu2();
        }

        private void Ibtn_objetos_Click_1(object sender, EventArgs e)
        {
            //codigo para el formilario
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlObjetos());
            //hideSubMenu2();
        }

        private void Ibtn_permisos_Click_1(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new R_R_RolesPermisos());
            //hideSubMenu2();
        }

        private void Ibtn_parametros_Click_1(object sender, EventArgs e)
        {
            //codigo para el formilario
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlParametro());
            //hideSubMenu2();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pbt_h1_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=1;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=2;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=3;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=4;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=8;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=7;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=6;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=5;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=12;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=11;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=10;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=9;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=20;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=15;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=14;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = true;
            lbl_fechas.Visible = true;
            lbl_cerrar.Visible = true;
            pbt_fechas.Visible = true;

            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select INGRESO, SALIDA from TBL_SOLICITUDRESERVA where NUMEROHABITACION=13;");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_habitacion.DataSource = dt;

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void lbl_13_Click(object sender, EventArgs e)
        {
        }

        private void lbl_14_Click(object sender, EventArgs e)
        {
        }

        private void lbl_15_Click(object sender, EventArgs e)
        {
        }

        private void lbl_16_Click(object sender, EventArgs e)
        {
        }

        private void lbl_9_Click(object sender, EventArgs e)
        {
        }

        private void lbl_10_Click(object sender, EventArgs e)
        {
        }

        private void lbl_11_Click(object sender, EventArgs e)
        {
        }

        private void lbl_12_Click(object sender, EventArgs e)
        {
        }

        private void Ibtn_clientes_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlUsuarios());
            //hideSubMenu2();
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            dgv_habitacion.Visible = false;
            lbl_fechas.Visible = false;
            lbl_cerrar.Visible = false;
            pbt_fechas.Visible = false;

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
    }
}
