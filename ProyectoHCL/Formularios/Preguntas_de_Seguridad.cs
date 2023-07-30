using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfiles
{
    public partial class Preguntas_de_Seguridad : Form
    {
        public Preguntas_de_Seguridad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Frm_Perfiles = new Frm_Perfiles();
            Frm_Perfiles.Show();
            this.Close();
        }

        private void Preguntas_de_Seguridad_Load(object sender, EventArgs e)
        {

        }
    }
}
