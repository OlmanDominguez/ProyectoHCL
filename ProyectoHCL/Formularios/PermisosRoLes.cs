using MySql.Data.MySqlClient;
//using MySqlX.XDevAPI.Relational;
using ProyectoHCL.clases;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;//estas librerias se instalaron para imprimir un documento pdf
using System.Drawing;         //estas librerias se instalaron para imprimir un documento pdf
using DocumentFormat.OpenXml.Drawing.Charts;

namespace ProyectoHCL.Formularios
{

    public partial class PermisosRoLes : Form
    {
        public PermisosRoLes()
        {
            InitializeComponent();
          //  RellenarGrid() ;
        }

        public int RellenarGrid(Permisos permisos)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
            string sql = "INSERT INTO TBL_PERMISOS(ID_ROL, ID_OBJETO, INSERCION, ELIMINACION, ACTUALIZACION, CONSULTA" +
               "PRIMERINGRESO, FECHAVENCIMIENTO, EDITAR, ELIMINAR) VALUES(@ID_ROL, @ID_OBJETO, @INSERCION, @ELIMINACION," +
                "@PRIMERINGRESO, @FECHAVENCIMIENTO )";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@ID_ROL", permisos.ID_ROL);
            comando.Parameters.AddWithValue("@ID_OBJETO", permisos.NOMBRE1);
            comando.Parameters.AddWithValue("@INSERCION", permisos.EDITAR1);
            comando.Parameters.AddWithValue("@ELIMINACION", permisos.ELIMINAR1);
            comando.Parameters.AddWithValue("@PRIMERINGRESO", permisos.PRIMER_INGRESO1);
            comando.Parameters.AddWithValue("@FECHAVENCIMIENTO", permisos.FECHA_VENCIMIENTO1);

            int resultado = comando.ExecuteNonQuery();
            return resultado;


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form formulario = new Nuevo_Registro_Rol();
            formulario.ShowDialog(); //Bloquea el form nuevo
        }

        private void Roles_Permisos_DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En que formato desea Imprimir los permisos");
        }

        private void Excel_Click(object sender, EventArgs e)
        {
           
        }

        private void RegistroBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            //  Console.Write(codigo.GetCelValuesAsString(Codigo, 2));
            //   Console.WriteLine("  "+codigo.GetCelValuesAsString(Codigo,3));
        }

        private void PermisosRoLes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form) ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {

                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach (DataGridViewColumn col in Roles_Permisos_DG.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, Left, top);
                     left += col.Width;

                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in Roles_Permisos_DG.Rows)
                {
                    if (row.Index == Roles_Permisos_DG.RowCount - 1)
                        Left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe", 13), Brushes.Black, Left, Top + 4);
                        Left += cell.OwningColumn.Width;

                    }
                    Top += DGV_ALTO;
                }
            };
            ppd.ShowDialog();

        }
    }
}






