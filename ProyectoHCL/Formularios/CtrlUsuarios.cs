using DocumentFormat.OpenXml.Vml;
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
        R_E_Usuario R_E_user = new R_E_Usuario();
        AdmonUsuarios admonUsuario = new AdmonUsuarios();
        Usuarios user = new Usuarios();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;

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

            HabilitarBotones();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CtrlUsuarios_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn(); //se crea el boton en el dataGrid
            btnUpdate.Name = "EDITAR"; //Nombre del boton 
            dgvUsuarios.Columns.Add(btnUpdate); //Se especifica el nombre de dataGrid para agregar boton

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            dgvUsuarios.Columns.Add(btnDelete);
        }

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
                CargarDG(); //Si el textbox está vacio devuelve el metodo mostrar usuarios 
            }
        }

        public string ParametroDias()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR FROM TBL_PARAMETRO WHERE ID_PARAMETRO = 2;";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR"].ToString();
            }
            else
            {
                return null;

            }

            conn.Close();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            int diasV = Convert.ToInt32(ParametroDias());
            R_E_user.lblTitulo.Text = "Registrar Usuario";
            R_E_user.txtContraseña.Visible = true;
            R_E_user.lblContraseña.Visible = true;
            R_E_user.txtFechaV.Visible = true;
            R_E_user.cmbEstado.Visible = true;
            R_E_user.lblEstado.Visible = true;
            R_E_user.cmbEstado2.Visible = false;
            R_E_user.lblEstado2.Visible = false;
            R_E_user.dtpVencimiento.Visible = false;
            R_E_user.txtFechaC.Text = DateTime.Now.ToShortDateString();
            R_E_user.txtFechaV.Text = DateTime.Now.AddDays(diasV).ToShortDateString();
            R_E_user.ShowDialog();
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
                MsgB m = new MsgB("pregunta", "¿Está seguro que desea eliminar el registro?");
                DialogResult dg = m.ShowDialog();

                if (dg == DialogResult.OK)
                {
                    bool elimino = admonUsuario.EliminarUsuario(dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString());

                    if (elimino)
                    {
                        MsgB mbox = new MsgB("informacion", "Registro eliminado");
                        DialogResult dR = mbox.ShowDialog();
                        CargarDG();
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

            if (this.dgvUsuarios.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                R_E_user.lblTitulo.Text = "Editar Usuario";
                R_E_user.cmbEstado2.Visible = true;
                R_E_user.lblEstado2.Visible = true;
                R_E_user.dtpVencimiento.Visible = true;
                R_E_user.cmbEstado.Visible = false;
                R_E_user.lblEstado.Visible = false;
                R_E_user.idUs = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
                R_E_user.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["USUARIO"].Value.ToString(); //Traer los datos del dataGrid al form para editar
                R_E_user.txtNombre.Text = dgvUsuarios.CurrentRow.Cells["NOMBRE"].Value.ToString();
                R_E_user.txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["CORREO"].Value.ToString();
                R_E_user.cmbEstado2.Text = dgvUsuarios.CurrentRow.Cells["ESTADO"].Value.ToString();
                R_E_user.cmbRol.Text = dgvUsuarios.CurrentRow.Cells["ROL"].Value.ToString();
                R_E_user.txtFechaC.Text = dgvUsuarios.CurrentRow.Cells["CREACION"].Value.ToString();
                R_E_user.dtpVencimiento.Text = dgvUsuarios.CurrentRow.Cells["VENCIMIENTO"].Value.ToString();
                R_E_user.ShowDialog();
                R_E_user.limpiarCampos();
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
                    numFilas = 5;
                    break;
                case 1:
                    numFilas = 10;
                    break;
                case 2:
                    numFilas = 20;
                    break;
                case 3:
                    numFilas = 30;
                    break;
                case 4:
                    numFilas = 40;
                    break;
            }
            pagFinal = numFilas;
            CargarDG();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void HabilitarBotones()
        {
            if (pagInicio == 1)
            {
                btnAnterior.Enabled = false;
                cmbMostrar.Enabled = true;
            }
            else
            {
                btnAnterior.Enabled = true;
                cmbMostrar.Enabled = false;
            }

            if (indice == (Convert.ToInt32(txtPaginacion.Text) - 1))
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
