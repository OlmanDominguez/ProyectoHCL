using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHCL
{
    public partial class RecuContra : Form
    {


        public RecuContra()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        //Boton cerrar
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
