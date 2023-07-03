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

namespace ProyectoHCL.Formularios
{
    public partial class CtrlUsuarios : Form
    {
        Usuarios user = new Usuarios();
        DataSet ds = new DataSet();
        int pagInicio = 1, indice = 0, numFilas = 3, pagFinal, cmbIndice = 0;

        public CtrlUsuarios()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();

        }

        private void CargarDG()
        {
            user.Inicio1 = pagInicio;
            user.Final1 = pagFinal;
            ds = user.PaginacionUsuarios();
            dgvUsuarios.DataSource = ds.Tables[1];

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
        Usuarios usuario = new Usuarios(); //crear objeto Usuario para acceder a sus parametros

        private void CtrlUsuarios_Load(object sender, EventArgs e)
        {
            //MostrarUsuarios(); 

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn(); //se crea el boton en el dataGrid
            btnUpdate.Name = "EDITAR"; //Nombre del boton 
            dgvUsuarios.Columns.Add(btnUpdate); //Se especifica el nombre de dataGrid para agregar boton

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvUsuarios.Columns.Add(btnDelete);
        }

        //public void MostrarUsuarios()
        //{
        //    dgvUsuarios.DataSource = admonUsuario.MostrarUsuarios(); //Llamar metodo mostrar usuarios en dataGrid
        //}

        public void BuscarUsuarios(string buscarU) //Recibe string para buscar usuarios
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarUsuarios", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreU", MySqlDbType.VarChar, 50).Value = buscarU; //recibe el parametro nombreU definido en el parametro almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                dgvUsuarios.DataSource = dt; //se define la tabla en la que se devuelven los registros
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
                BuscarUsuarios(txtBuscar.Text); //El metodo recibe el string desde el textbox
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

        private void dgvUsuarios_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvUsuarios.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvUsuarios.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvUsuarios.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvUsuarios.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvUsuarios.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvUsuarios.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvUsuarios.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = admonUsuario.EliminarUsuario(dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString()); //EL metodo eliminar recibe como string el id del DataGrid

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el usuario?",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (elimino)
                    {
                        MessageBox.Show("Usuario eliminado");
                        CargarDG();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no eliminado");
                    }

                }
                else /*if (dialogResult == DialogResult.No)*/
                {

                }
            }

            if (this.dgvUsuarios.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarUsuario editarUsuarios = new EditarUsuario(); //Crear objeto del form EditarUsuario

                editarUsuarios.idUs = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
                editarUsuarios.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["USUARIO"].Value.ToString(); //Traer los datos del dataGrid al form para editar
                editarUsuarios.txtNombre.Text = dgvUsuarios.CurrentRow.Cells["NOMBRE"].Value.ToString();
                editarUsuarios.txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["CORREO"].Value.ToString();
                editarUsuarios.cmbEstado.Text = dgvUsuarios.CurrentRow.Cells["ESTADO"].Value.ToString();
                editarUsuarios.cmbRol.Text = dgvUsuarios.CurrentRow.Cells["ROL"].Value.ToString();
                editarUsuarios.txtFechaC.Text = dgvUsuarios.CurrentRow.Cells["CREACION"].Value.ToString();
                editarUsuarios.dtpVencimiento.Text = dgvUsuarios.CurrentRow.Cells["VENCIMIENTO"].Value.ToString();
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
