using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
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
    public partial class DescuentoFact : Form
    {
        public DescuentoFact()
        {
            InitializeComponent();
            cargarLV();
        }


        public void cargarLV()
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (var command = new MySqlCommand("SELECT DESCRIPCION, PORCENTAJE FROM TBL_DESCUENTO", conectar))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader["DESCRIPCION"].ToString();
                            string porcentaje = reader["PORCENTAJE"].ToString();

                            ListViewItem item = new ListViewItem(new[] { nombre, porcentaje });
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Obtener el porcentaje del descuento seleccionado
                string porcentajeStr = listView1.SelectedItems[0].SubItems[1].Text;
                if (decimal.TryParse(porcentajeStr, out decimal porcentaje))
                {
                    // Almacenar el porcentaje 
                    clases.CDatos.descuento = porcentaje / 100;
                }

                this.Close();
            }
            else
            {
                MsgB Mbox = new MsgB("advertencia", "Seleccione un descuento de la lista"); //validar que se haya seleccionado un elemento de la lista
                DialogResult DR = Mbox.ShowDialog();
            }
        }

        int posY = 0;     /* declaracion de variables */
        int posX = 0;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
    }
}
