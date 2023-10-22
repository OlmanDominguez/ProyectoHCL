using System;
using System.IO;
using MySql.Data.MySqlClient;
using IWshRuntimeLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DocumentFormat.OpenXml.Wordprocessing;

namespace ProyectoHCL.Formularios
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Backup_Load(object sender, EventArgs e)
        {

        }


        private void Generar_Backup_Click(object sender, EventArgs e)
        {

            SaveFileDialog selecciona = new SaveFileDialog();
            selecciona.Filter = "Archivo SQL (*.sql)|*.sql";
            selecciona.InitialDirectory = @"C:\Users\DAOdo\Desktop\SEGUNDO PERIODO 2023\Programacion he implementacion de Sistemas\ProyectoHotelCasaLomas\Backup\HotelCl.sql";
            selecciona.Title = "Seleccionar archivo de respaldo";

            if (selecciona.ShowDialog() == DialogResult.OK)

            {
                string ruta = selecciona.FileName;

                string cadena = "server=containers-us-west-29.railway.app;port=6844; user=root; database = railway; ; pwd = LpxjPRi2Ckkz7FiKNUHn;";
                cadena += "charset=utf8; convertzerodatetime=true";

                // string ruta = @"C:\Users\DAOdo\Desktop\SEGUNDO PERIODO 2023\Programacion he implementacion de Sistemas\ProyectoHotelCasaLomas\Backup\HotelCl.sql";
                MySqlConnection conexion = new MySqlConnection(cadena);
                MySqlCommand comando = new MySqlCommand();
                MySqlBackup bk = new MySqlBackup(comando);

                comando.Connection = conexion;
                conexion.Open();
                bk.ExportToFile(ruta);
                conexion.Close();

                MessageBox.Show("Respaldo Generado");
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

