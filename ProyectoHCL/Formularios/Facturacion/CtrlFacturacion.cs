using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using ProyectoHCL.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoHCL.Formularios;

namespace ProyectoHCL.Formularios
{
    public partial class CtrlFacturacion : Form
    {
        Facturacion user = new Facturacion();
        DataSet ds = new DataSet();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal, cmbIndice = 0;

        public CtrlFacturacion()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();

        }

        private void CargarDG()
        {
            user.Inicio1 = pagInicio;
            user.Final1 = pagFinal;
            ds = user.PaginacionFacturas();
            dgvFacturas.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPaginacion.Text = cantidad.ToString();

            cmbPaginacion.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPaginacion.Items.Add(x.ToString());

            cmbPaginacion.SelectedIndex = indice;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        AdmonUsuarios admonUsuario = new AdmonUsuarios(); //crear objeto admonUsuario para acceder a sus metodos

        private void CtrlFacturacion_Load(object sender, EventArgs e)
        {
            //MostrarUsuarios(); 

            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn(); //se crea el boton en el dataGrid
            btnVer.Name = "VER"; //Nombre del boton 
            dgvFacturas.Columns.Add(btnVer); //Se especifica el nombre de dataGrid para agregar boton

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "EDITAR";
            dgvFacturas.Columns.Add(btnDelete);
        }


        public void BuscarFacturas(string buscarF) //Recibe string para buscar usuarios
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarFacturas", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreF", MySqlDbType.VarChar, 50).Value = buscarF; //recibe el parametro nombreU definido en el parametro almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                dgvFacturas.DataSource = dt; //se define la tabla en la que se devuelven los registros
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "") //si el textbox no está vacío devuelve el metodo buscar usuarios
            {
                BuscarFacturas(txtBuscar.Text); //El metodo recibe el string desde el textbox
            }
            else
            {
                CargarDG();  /*MostrarUsuarios();*/ //Si el textbox está vacio devuelve el metodo mostrar usuarios 
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            RegistrarUsuario reglUsuarios = new RegistrarUsuario(); //Se crea un objeto del form RegistrarUsuarios
            reglUsuarios.ShowDialog();
            CargarDG();
        }

        private void dgvFacturas_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvFacturas.Columns[e.ColumnIndex].Name == "VER" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvFacturas.Rows[e.RowIndex].Cells["VER"] as DataGridViewButtonCell;
                Icon icoVer = new Icon(Environment.CurrentDirectory + "\\ver.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvFacturas.Rows[e.RowIndex].Height = icoVer.Height + 8;
                this.dgvFacturas.Columns[e.ColumnIndex].Width = icoVer.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvFacturas.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvFacturas.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvFacturas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvFacturas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        public static class numFact
        {
            public static string factura;
            public static string fecha;
            public static string ingreso;
            public static string salida;
        }


        private void dgvFacturas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvFacturas.Columns[e.ColumnIndex].Name == "VER")
            {
                try
                {
                    numFact.factura = dgvFacturas.CurrentRow.Cells["FACTURA"].Value.ToString();
                    numFact.fecha = dgvFacturas.CurrentRow.Cells["FECHA"].Value.ToString();
                    numFact.ingreso = dgvFacturas.CurrentRow.Cells["INGRESO"].Value.ToString();
                    numFact.salida = dgvFacturas.CurrentRow.Cells["SALIDA"].Value.ToString();

                    //MessageBox.Show(claseCod.codigo);
                    Form form = new Formularios.ShowFactura();
                    form.ShowDialog();

                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un error");
                }


            }

            if (this.dgvFacturas.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarUsuario editarUsuarios = new EditarUsuario(); //Crear objeto del form EditarUsuario

                editarUsuarios.idUs = dgvFacturas.CurrentRow.Cells["ID"].Value.ToString();
                editarUsuarios.txtUsuario.Text = dgvFacturas.CurrentRow.Cells["USUARIO"].Value.ToString(); //Traer los datos del dataGrid al form para editar
                editarUsuarios.txtNombre.Text = dgvFacturas.CurrentRow.Cells["NOMBRE"].Value.ToString();
                editarUsuarios.txtCorreo.Text = dgvFacturas.CurrentRow.Cells["CORREO"].Value.ToString();
                editarUsuarios.cmbEstado.Text = dgvFacturas.CurrentRow.Cells["ESTADO"].Value.ToString();
                editarUsuarios.cmbRol.Text = dgvFacturas.CurrentRow.Cells["ROL"].Value.ToString();
                editarUsuarios.txtFechaC.Text = dgvFacturas.CurrentRow.Cells["CREACION"].Value.ToString();
                editarUsuarios.dtpVencimiento.Text = dgvFacturas.CurrentRow.Cells["VENCIMIENTO"].Value.ToString();
                editarUsuarios.ShowDialog(); //Se oculta el form principal y solo muestra el form editarUsuarios 
                CargarDG(); //Se llama el metodo Mostrar usuarios para actualizar el DataGrid al editar 
            }
        }

        private void cmbPaginacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIndice = cmbMostrar.SelectedIndex;
            switch (cmbIndice)
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
            CargarDG();
        }
    }
}
