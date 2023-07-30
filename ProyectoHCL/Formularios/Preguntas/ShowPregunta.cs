using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoHCL.Formularios;
using DocumentFormat.OpenXml.EMMA;


namespace ProyectoHCL.Formularios
{
    public partial class ShowPregunta : Form
    {
        public ShowPregunta()
        {
            InitializeComponent();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPregunta_Load(object sender, EventArgs e)
        {
            if (CtrlPreguntas.preg.op == 1)
            {

            }
        }
    }
}
