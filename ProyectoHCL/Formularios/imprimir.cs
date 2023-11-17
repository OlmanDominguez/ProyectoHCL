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

namespace ProyectoHCL
{
    public partial class imprimir : Form
    {
        public imprimir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
