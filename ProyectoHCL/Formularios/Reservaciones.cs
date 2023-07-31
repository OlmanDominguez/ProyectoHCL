using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;

namespace ProyectoHCL
{
    public partial class Reservaciones : Form
    {
        public Reservaciones()
        {
            InitializeComponent();
        }

        private void openChildFormInPanel(Form childForm)
        {
            /*if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;*/
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void Reservaciones_Load(object sender, EventArgs e)
        {


            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select TBL_SOLICITUDRESERVA.FECHACOTI AS FECHA, TBL_SOLICITUDRESERVA.INGRESO, TBL_SOLICITUDRESERVA.SALIDA, TBL_SOLICITUDRESERVA.NHUESPEDES AS HUESPEDES ,concat(TBL_CLIENTE.NOMBRE,\", \",TBL_CLIENTE.APELLIDO) AS NOMBRE, TBL_ESTADORESERVA.DESCRIPCION AS ESTADO,\r\nTBL_SOLICITUDRESERVA.NUMEROHABITACION AS HABITACION\r\nFROM TBL_CLIENTE INNER JOIN TBL_SOLICITUDRESERVA ON TBL_CLIENTE.CODIGO=TBL_SOLICITUDRESERVA.COD_CLIENTE\r\nINNER JOIN TBL_ESTADORESERVA ON TBL_SOLICITUDRESERVA.ID_ESTADORESERVA=TBL_ESTADORESERVA.ID_ESTADORESERVA\r\nINNER JOIN TBL_DETALLERESERVA ON TBL_ESTADORESERVA.ID_ESTADORESERVA=TBL_DETALLERESERVA.ID_DETALLERESERVA\r\nINNER JOIN TBL_HABITACION ON TBL_DETALLERESERVA.ID_HABITACION=TBL_HABITACION.ID_HABITACION ");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_reservaciones.DataSource = dt;
                    DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn(); //se crea el boton en el dataGrid
                    btnUpdate.Name = "EDITAR";//Nombre del boton 
                    dgv_reservaciones.Columns.Add(btnUpdate); //Se especifica el nombre de dataGrid para agregar boton

                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                    btnDelete.Name = "ELIMINAR";
                    dgv_reservaciones.Columns.Add(btnDelete);

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form formulario = new NuevaReservacion();

            formulario.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnNuevo_Click_2(object sender, EventArgs e)
        {
            Form nuevo = new NuevaReservacion();
            nuevo.Show();

        }

        private void dgv_reservaciones_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgv_reservaciones.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgv_reservaciones.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgv_reservaciones.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgv_reservaciones.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgv_reservaciones.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgv_reservaciones.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgv_reservaciones.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgv_reservaciones.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        private void dgv_reservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
