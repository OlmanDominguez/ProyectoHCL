using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Printing;//estas librerias se instalaron para imprimir un documento pdf

namespace ProyectoHCL.Formularios
{

    public partial class PermisosRoLes : Form
    {
        public PermisosRoLes()
        {
            InitializeComponent();
            // RellenarGrid() ;
            panel1.BackColor = Color.FromArgb(125, Color.DeepSkyBlue); //colocar transaparente el panel izquierdo al ejecutar
            panel2.BackColor = Color.FromArgb(120, Color.DimGray);//colocar transaparente el panel superior al ejecutar
        }
        RgtRoles rgtRoles = new RgtRoles(); //crear objeto admonUsuario para acceder a sus metodos
        Roles roles = new Roles();

        private void PermisosRoLes_Load(object sender, EventArgs e)
        {
            RellenarGrid(); //se muestran los usuarios registrados en el dataGrid

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn(); //se crea el boton en el dataGrid
            btnUpdate.Name = "EDITAR"; //Nombre del boton 
            Roles_Permisos_DG.Columns.Add(btnUpdate); //Se especifica el nombre de dataGrid para agregar boton

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            Roles_Permisos_DG.Columns.Add(btnDelete);

        }
        public void RellenarGrid()
        {
            Roles_Permisos_DG.DataSource = rgtRoles.RellenarGrid(); //Llamar metodo mostrar Roles en dataGrid
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



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

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

        private void txtBuscarRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}






