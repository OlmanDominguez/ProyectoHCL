using System;
using DocumentFormat.OpenXml.Vml;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
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
        AdminReserva adminReserva = new AdminReserva();
        NuevaReservacion reservacion = new NuevaReservacion();
        public Reservaciones()
        {
            InitializeComponent();
        }
        public void BuscarReserva(string buscarU) //Recibe string para buscar usuarios
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarReserva", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreU", MySqlDbType.VarChar, 50).Value = buscarU; //recibe el parametro nombreU definido en el parametro almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                dgv_reservaciones.DataSource = dt; //se define la tabla en la que se devuelven los registros
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CargarReservas()
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select TBL_SOLICITUDRESERVA.ID_SOLICITUDRESERVA AS ID,TBL_SOLICITUDRESERVA.FECHACOTI AS FECHA, TBL_SOLICITUDRESERVA.INGRESO, TBL_SOLICITUDRESERVA.SALIDA, TBL_SOLICITUDRESERVA.NHUESPEDES AS HUESPEDES ,concat(TBL_CLIENTE.NOMBRE,\", \",TBL_CLIENTE.APELLIDO) AS NOMBRE, TBL_ESTADORESERVA.DESCRIPCION AS ESTADO,\r\nTBL_SOLICITUDRESERVA.NUMEROHABITACION AS HABITACION\r\nFROM TBL_CLIENTE INNER JOIN TBL_SOLICITUDRESERVA ON TBL_CLIENTE.CODIGO=TBL_SOLICITUDRESERVA.COD_CLIENTE\r\nINNER JOIN TBL_ESTADORESERVA ON TBL_SOLICITUDRESERVA.ID_ESTADORESERVA=TBL_ESTADORESERVA.ID_ESTADORESERVA\r\nINNER JOIN TBL_DETALLERESERVA ON TBL_ESTADORESERVA.ID_ESTADORESERVA=TBL_DETALLERESERVA.ID_DETALLERESERVA\r\nINNER JOIN TBL_HABITACION ON TBL_DETALLERESERVA.ID_HABITACION=TBL_HABITACION.ID_HABITACION ");

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_reservaciones.DataSource = dt;


                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }



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



            CargarReservas();
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn(); //se crea el boton en el dataGrid
            btnUpdate.Name = "EDITAR";//Nombre del boton 
            dgv_reservaciones.Columns.Add(btnUpdate); //Se especifica el nombre de dataGrid para agregar boton

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgv_reservaciones.Columns.Add(btnDelete);

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



        private void dgv_reservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_reservaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgv_reservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_reservaciones.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    bool elimino = adminReserva.EliminarReserva(dgv_reservaciones.CurrentRow.Cells["ID"].Value.ToString());

                    if (elimino)
                    {
                        MsgB mbox = new MsgB("informacion", "Registro eliminado");
                        DialogResult dR = mbox.ShowDialog();
                        CargarReservas();

                    }
                    else
                    {
                        MsgB mbox = new MsgB("informacion", "Registro no eliminado");
                        DialogResult dR = mbox.ShowDialog();
                    }

                }
                else if (dg == DialogResult.Cancel)
                {

                }
            }
            if (this.dgv_reservaciones.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                reservacion.lbl_titulo.Text = "Editar Reservacion";
                reservacion.txt_id_solicitud.Text = dgv_reservaciones.CurrentRow.Cells["ID"].Value.ToString();
                reservacion.ShowDialog();



                //CargarReservas(); //Se llama el metodo Mostrar usuarios para actualizar el DataGrid al editar 
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar_reservas.Text != "") //si el textbox no está vacío devuelve el metodo buscar usuarios
            {
                BuscarReserva(txtBuscar_reservas.Text); //El metodo recibe el string desde el textbox
            }
            else
            {
                CargarReservas(); //Si el textbox está vacio devuelve el metodo mostrar usuarios 
            }
        }

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
