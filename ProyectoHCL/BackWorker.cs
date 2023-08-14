using ProyectoHCL.clases;
using ProyectoHCL.Formularios;
using ProyectoHCL.RolesPermisos;
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
    public partial class BackWorker : Form
    {
        public BackWorker()
        {
            InitializeComponent();
        }

        private void BackWorker_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pgB.Value += 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgB.Value += 10;
            if (pgB.Value == 200)
                pgB.Value = 0;
        }
    }


}

