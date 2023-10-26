using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoHCL.RecuContra;

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

//Programa:         MessageBox 
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      MessageBox diseñado para mostrar mensajes de advertencia, información, error o pregunta

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

namespace ProyectoHCL
{
    public partial class MsgB : Form
    {
        public MsgB()
        {
            InitializeComponent();
        }

        public MsgB(string pTipo, string pMensaje)
        {
            InitializeComponent();
            lblMsg.Text = pMensaje; //Mostrar mensaje en label dependiendo si es error, advertencia, información o pregunta

            switch (pTipo)
            {
                case "pregunta": //Si es pregunta, se muestra la imagen correspondiente y los botones de aceptar o cancelar
                    lblTitulo.Text = "Pregunta";
                    lblTitulo.ForeColor = Color.FromArgb(33, 150, 243);
                    panel1.BackColor = Color.FromArgb(33, 150, 243);
                    pbPregunta.Visible = true;
                    btnOk.Visible = true;
                    btnCancelar.Visible = true;
                    break;
                case "informacion": //Si es información, se muestra la imagen correspondiente y el boton de aceptar
                    lblTitulo.Text = "Información";
                    lblTitulo.ForeColor = Color.FromArgb(33, 150, 243);
                    panel1.BackColor = Color.FromArgb(33, 150, 243);
                    pbInfo.Visible = true;
                    btnAOk.Visible = true;
                    break;
                case "advertencia": //Si es advertencia, se muestra la imagen correspondiente y el boton de aceptar
                    lblTitulo.Text = "Advertencia";
                    lblTitulo.ForeColor = Color.FromArgb(255, 193, 7);
                    panel1.BackColor = Color.FromArgb(255, 193, 7);
                    pbAdvertencia.Visible = true;
                    btnAOk.Visible = true;
                    break;
                case "error": //Si es error, se muestra la imagen correspondiente y el boton de aceptar
                    lblTitulo.Text = "Error";
                    lblTitulo.ForeColor = Color.FromArgb(244, 67, 54);
                    panel1.BackColor = Color.FromArgb(244, 67, 54);
                    pbError.Visible = true;
                    btnAOk.Visible = true;
                    break;
                case "bienvenida": //Si es error, se muestra la imagen correspondiente y el boton de aceptar
                    lblTitulo.Text = "Bienvenido(a), " + clasecompartida.user;
                    lblTitulo.ForeColor = Color.FromArgb(33, 150, 243);
                    panel1.BackColor = Color.FromArgb(33, 150, 243);
                    pbBienvenido.Visible = true; 
                    btnAOk.Visible = true;
                    break;
                default: //si no es ninguno de los anteriores se muestra el mensaje "Error al seleccionar"
                    lblTitulo.Text = "Error al seleccionar";
                    break;
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; //botón aceptar
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //botón cancelar
        }

        //Coordenadas para mover el formulario messageBox
        int posY = 0;
        int posX = 0;

        private void panel3_MouseMove(object sender, MouseEventArgs e) //evento del panel que permite mover el formulario messageBox
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar formulario
        }

        private void btnAOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; //botón aceptar
        }
    }
}
