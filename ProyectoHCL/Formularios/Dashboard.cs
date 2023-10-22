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

        public Dashboard()
        {
            InitializeComponent();
            hideSubMenu();
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
                            Ibtn_habitaciones.Visible = false;
                        }
                        break;
                    case "DESCUENTOS":
                        if (obj.IdPermiso == 1 && !obj.Permitido)
                        {
                            Ibtn_descuentos.Visible = false;
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
                            Ibtn_servicios.Visible = false;
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
                            iconButton1.Visible = false;
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
                            Ibtn_usuarios.Visible = false;
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
            //panelChildForm.Visible = false;


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

        //codigo de cada uno de los botones para el acceso a los modulos del sistema 

        private void Ibtn_administracion_Click(object sender, EventArgs e)
        {
            showSubMenu(paneladminSubMenu);
        }

        private void Ibtn_habitaciones_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlHabitaciones());
            hideSubMenu2();
        }

        private void Ibtn_servicios_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlServicios());
            hideSubMenu2();
        }

        private void Ibtn_descuentos_Click(object sender, EventArgs e)
        {
            //codigo para el formilario
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlDescuentos());
            hideSubMenu2();
        }

        private void Ibtn_usuarios_Click(object sender, EventArgs e)
        {
            //codigo para el formilario 
            panelChildForm.Visible = true;
            openChildFormInPanel(new CtrlClientes());
            hideSubMenu2();
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

        private void pictureBox1_Click(object sender, EventArgs e)//
        {
            {
                Application.Exit();
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
     
                Application.Exit();

        }
    }
}
