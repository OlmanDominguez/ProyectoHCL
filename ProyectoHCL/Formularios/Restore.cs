using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHCL.Formularios
{
    public partial class Restore : Form
    {
        public Restore()
        {
            InitializeComponent();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            string ruta = "";

            OpenFileDialog selecciona = new OpenFileDialog();
            selecciona.Filter = "Archivos SQL (*.sql)|*.sql";
            selecciona.Title = " Seleccionar Respaldo "; // Título de la ventana
            selecciona.InitialDirectory = @" C:\Users\DAOdo\Desktop\SEGUNDO PERIODO 2023\Programacion he implementacion de Sistemas\ProyectoHotelCasaLomas\Backup\HotelCl.sql"; //Url de archivo

            if (selecciona.ShowDialog() == DialogResult.OK)
            {
                ruta = selecciona.FileName;
                txtRuta.Text = ruta;

                //Crear cadena de conexion

                string cadena = "server=containers-us-west-29.railway.app;port=6844; user = root; database = railway; pwd = LpxjPRi2Ckkz7FiKNUHn;";

                MySqlConnection conexion = new MySqlConnection(cadena);
                MySqlCommand comando = new MySqlCommand();
                MySqlBackup respaldo = new MySqlBackup(comando);

                comando.Connection = conexion;
                conexion.Open();

                respaldo.ImportFromFile(ruta);
                conexion.Close();

                MessageBox.Show("El respaldo se importó correctamente");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
