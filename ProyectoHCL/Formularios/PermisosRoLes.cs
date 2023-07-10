using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProyectoHCL.Properties;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;//estas librerias se instalaron para imprimir un documento pdf
using Microsoft.VisualBasic.ApplicationServices;

namespace ProyectoHCL.Formularios
{

    public partial class PermisosRoLes : Form
    {
        Roles user = new Roles();
        DataSet ds = new DataSet();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal;

        public PermisosRoLes()
        {

            InitializeComponent();
            pagFinal = numFilas;
            RellenarGrid();
            panel1.BackColor = Color.FromArgb(125, Color.DeepSkyBlue); //colocar transaparente el panel izquierdo al ejecutar
            panel2.BackColor = Color.FromArgb(120, Color.DimGray);//colocar transaparente el panel superior al ejecutar


        }

        private void CargarDTR()
        {
            user.Inicio1 = pagInicio;
            user.Final1 = pagFinal;
            ds = user.PaginacionRoles();
            Roles_Permisos_DG.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPaginacion.Text = cantidad.ToString();

            crPaginacion.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                crPaginacion.Items.Add(x.ToString());

            crPaginacion.SelectedIndex = indice;
        }

        RgtRoles rgtRoles = new RgtRoles(); //crear objeto Rgtroles para acceder a sus metodos
        Roles roles = new Roles();//crear objetos roles para acceder a sus parametros 

        private void PermisosRoLes_Load(object sender, EventArgs e)
        {
            RellenarGrid(); //se muestran roles registrados en el dataGrid

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

        private void Roles_Permisos_DG_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.Roles_Permisos_DG.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.Roles_Permisos_DG.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.Roles_Permisos_DG.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.Roles_Permisos_DG.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.Roles_Permisos_DG.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.Roles_Permisos_DG.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.Roles_Permisos_DG.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.Roles_Permisos_DG.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
          
         }
     
        private void Roles_Permisos_DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Roles_Permisos_DG.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = rgtRoles.EliminarRoles(Roles_Permisos_DG.CurrentRow.Cells["ID_ROL"].Value.ToString()); //EL metodo eliminar recibe como string el id del DataGrid

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar este Rol?",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (elimino)
                    {
                        MessageBox.Show("Rol eliminado");
                        RellenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Rol no eliminado");
                    }

                }
                else /*if (dialogResult == DialogResult.No)*/
                {

                }
            }
            if (this.Roles_Permisos_DG.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarRoles editarRoles = new EditarRoles(); //Crear objeto del form Editarroles

                //  editarRoles.ID_rol= Roles_Permisos_DG.CurrentRow.Cells["ID"].Value.ToString();
                editarRoles.txtNombre.Text = Roles_Permisos_DG.CurrentRow.Cells["NOMBRE_ROL"].Value.ToString();
                editarRoles.txtEstadoRol.Text = Roles_Permisos_DG.CurrentRow.Cells["ESTADO_ROL"].Value.ToString();
                editarRoles.txtFechaC.Text = Roles_Permisos_DG.CurrentRow.Cells["FECHA_CREACION"].Value.ToString();
                editarRoles.txtFechaActualizacion.Text = Roles_Permisos_DG.CurrentRow.Cells["FECHA_ACTUALIZACION"].Value.ToString();
                editarRoles.ShowDialog(); //Se oculta el form principal y solo muestra el form editarRol
                RellenarGrid(); //Se llama el metodo Mostrar Roles para actualizar el DataGrid al editar 
            }
        }
        public void BuscarRoles(string buscarR) //Recibe string para buscar usuarios
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarrol", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreR", MySqlDbType.VarChar, 30).Value = buscarR; //recibe el parametro nombreR definido en el parametro almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                Roles_Permisos_DG.DataSource = dt; //se define la tabla en la que se devuelven los registros
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En que formato desea Imprimir los permisos");
        }

        private void Excel_Click(object sender, EventArgs e)
        {

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

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                BuscarRoles(textBuscar.Text);
            }
            else
            {
                RellenarGrid();
            }
        }

        private void textPaginacion_TextChanged(object sender, EventArgs e)
        {

            int pagina = Convert.ToInt32(crPaginacion.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDTR();
        }
        private void crPaginacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // numFilas = int.Parse(mostrarR.Text);
            // pagFinal = numFilas;

            indice = mostrarR.SelectedIndex;
            switch (indice)
            {
                case 0:
                    numFilas = 2;
                    break;
                case 1:
                    numFilas = 3;
                    break;
                case 2:
                    numFilas = 4;
                    break;
                case 3:
                    numFilas = 5;
                    break;
                case 4:
                    numFilas = 6;
                    break;
            }
            pagFinal = numFilas;
            CargarDTR();
        }
        private void mostrarR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        
     }
}






