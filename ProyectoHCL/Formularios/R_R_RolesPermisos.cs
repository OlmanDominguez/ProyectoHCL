using iTextSharp.text;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using ProyectoHCL.RolesPermisos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.Kernel.Pdf.Colorspace.PdfDeviceCs;


//-----------------------------------------------------------------------
//    Universidad Nacional Autonoma de Honduras (UNAH)
//		Facultad de Ciencias Economicas
//	Departamento de Informatica administrativa
//         Analisis, Programacion y Evaluacion de Sistemas
//                    Tercer Periodo 2023


//Equipo:
//GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

//HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

//NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

//JOEL ENRIQUE GODOY BONILLA---------(joel.bonilla@unah.hn)

//OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

//Catedratico analisis y diseño:             Lic.Giancarlo Martini Scalici Aguilar 
//catedratico programacion e implementacion: Lic.Karla Melisa Garcia Pineda 
//catedratico evaluacion de sistemas:        Lic.Karla Melisa Garcia Pineda 


//---------------------------------------------------------------------

//Programa:         Registrar y editar permisos
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Formulario que permite registrar o editar los permisos

//-----------------------------------------------------------------------

//                Historial de Cambio

//-----------------------------------------------------------------------

//Programador               Fecha                      Descripcion
//GABRIELA  MANCIA  

//HILDEGARD  MONTALVAN   

//NELSON SALGADO  

//JOEL  GODOY 

//OLMAN  DOMÍNGUEZ 

//-----------------------------------------------------------------------

namespace ProyectoHCL.Formularios
{
    public partial class R_R_RolesPermisos : Form
    {
        public R_R_RolesPermisos()
        {
            InitializeComponent();
            cargarRoles();
            dgvRolPermiso.CellValueChanged += dgvRolPermiso_CellValueChanged;
        }

        RolUsuario rolUs = new RolUsuario();
        PermisoRol permiso = new PermisoRol();
        CDatos cDatos = new CDatos();
        Objetos obj = new Objetos();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        Modelo modelo = new Modelo();
        int IdRol;

        private void ListarObjetos() //Mostrar los objetos y su respectivo id almacenados en la tabla TBL_OBJETOS
        {
            dgvRolPermiso.DataSource = cDatos.listarObjetos();
        }

        private void Permisos() //Asignar permisos a este form
        {
            var LsObj = cDatos.SelectObjeto(clases.CDatos.idRolUs);

            foreach (var obj in LsObj)
            {
                switch (obj.IdPermiso)
                {
                    case 2: //permiso crear
                        if (obj.ObjetoN == "PERMISOS" && !obj.Permitido) //Validar pantalla y el permiso
                        {
                            btnNuevo.Visible = false; //ocultar botón nuevo
                            btnEditar.Visible = false; //ocultar botón editar
                            lblTitulo.Text = "Editar Permisos";
                        }
                        break;
                    case 3: //permiso editar
                        if (obj.ObjetoN == "PERMISOS" && !obj.Permitido) //Validar pantalla y el permiso
                        {
                            btnEditar.Visible = false; //ocultar botón editar
                            btnNuevo.Visible = false; //ocultar botón nuevo
                        }
                        break;
                }
            }
        }

        private void cargarRoles() //Llenar el combobox con los roles almacenados en la tabla TBL_ROL
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            cmbRol.DataSource = null;
            cmbRol.Items.Clear();
            string sql = "SELECT ID_ROL, ROL FROM TBL_ROL;";

            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            try
            {
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cmbRol.ValueMember = "ID_ROL";
                cmbRol.DisplayMember = "ROL";
                cmbRol.DataSource = dt;

            }
            catch (MySqlException e)
            {
                MsgB m = new MsgB("Error", "Se produjo un error " + e.Message);
                DialogResult dR = m.ShowDialog();
            }
            finally { conn.Close(); }

        }

        private void CargarDG() //Agregar las columnas checkbox para marcar los permisos de ver, crear, editar o eliminar
        {
            DataGridViewCheckBoxColumn chkVer = new DataGridViewCheckBoxColumn();
            chkVer.Name = "VER";
            chkVer.Tag = 1; //asignar número para asociarlo al permiso al momento de almacenar en la base de datos
            dgvRolPermiso.Columns.Add(chkVer);

            DataGridViewCheckBoxColumn chkCrear = new DataGridViewCheckBoxColumn();
            chkCrear.Name = "CREAR";
            chkCrear.Tag = 2; //asignar número para asociarlo al permiso al momento de almacenar en la base de datos
            dgvRolPermiso.Columns.Add(chkCrear);

            DataGridViewCheckBoxColumn chkEditar = new DataGridViewCheckBoxColumn();
            chkEditar.Name = "EDITAR";
            chkEditar.Tag = 3; //asignar número para asociarlo al permiso al momento de almacenar en la base de datos
            dgvRolPermiso.Columns.Add(chkEditar);

            DataGridViewCheckBoxColumn chkEliminar = new DataGridViewCheckBoxColumn();
            chkEliminar.Name = "ELIMINAR";
            chkEliminar.Tag = 4; //asignar número para asociarlo al permiso al momento de almacenar en la base de datos
            dgvRolPermiso.Columns.Add(chkEliminar);
        }

        public void limpiarCampos() //limpiar las casillas marcadas en el datagrid
        {
            cmbRol.SelectedIndex = -1;
            rBtnDeshabilitar.Checked = false;
            rbtnHabilitar.Checked = false;

            foreach (DataGridViewRow row in dgvRolPermiso.Rows) //recorrer las filas del datagrid
            {
                if (Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    row.Cells["VER"].Value = false;
                }
                if (Convert.ToBoolean(row.Cells["CREAR"].Value))
                {
                    row.Cells["CREAR"].Value = false;
                }
                if (Convert.ToBoolean(row.Cells["EDITAR"].Value))
                {
                    row.Cells["EDITAR"].Value = false;
                }
                if (Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                {
                    row.Cells["ELIMINAR"].Value = false;
                }
            }
        }

        private void btnMin_Click(object sender, EventArgs e)  //botón para minimizar
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e) //botón para cerrar
        {
            this.Close();
            //limpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e) //botón para cancelar
        {
            this.Close();
            //limpiarCampos();
        }

        //coordenadas para arrastrar formulario
        int posY = 0;
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e) //evento del panel que permite arrastrar el formulario
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

        private void btnAntR_Click(object sender, EventArgs e)
        {
        }

        private void btnSigR_Click(object sender, EventArgs e)
        {
        }

        private void cmbPagR_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void RolesPermisos_Load(object sender, EventArgs e)
        {
            ListarObjetos();
            cmbRol.SelectedIndex = -1;
            CargarDG();
            Permisos();
        }

        private void GuardarPermisoRol() //función para guardar los permisos
        {

            foreach (DataGridViewRow row in dgvRolPermiso.Rows)
            {
                permiso.IdRol = cmbRol.Text;
                permiso.IdObjeto = Convert.ToInt32(row.Cells["ID"].Value);

                //int idPermiso = Convert.ToInt32(dgvRolPermiso.Columns["VER"].Tag);

                bool ver = Convert.ToBoolean(row.Cells["VER"].Value);
                bool crear = Convert.ToBoolean(row.Cells["CREAR"].Value);
                bool editar = Convert.ToBoolean(row.Cells["EDITAR"].Value);
                bool eliminar = Convert.ToBoolean(row.Cells["ELIMINAR"].Value);

                // Llamar a la función para guardar permisos 
                cDatos.GuardarPermiso(new PermisoRol
                {
                    IdRol = permiso.IdRol,
                    IdObjeto = permiso.IdObjeto,
                    IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["VER"].Tag),
                    Permitido = ver
                });

                cDatos.GuardarPermiso(new PermisoRol
                {
                    IdRol = permiso.IdRol,
                    IdObjeto = permiso.IdObjeto,
                    IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["CREAR"].Tag),
                    Permitido = crear
                });

                cDatos.GuardarPermiso(new PermisoRol
                {
                    IdRol = permiso.IdRol,
                    IdObjeto = permiso.IdObjeto,
                    IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["EDITAR"].Tag),
                    Permitido = editar
                });

                cDatos.GuardarPermiso(new PermisoRol
                {
                    IdRol = permiso.IdRol,
                    IdObjeto = permiso.IdObjeto,
                    IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["ELIMINAR"].Tag),
                    Permitido = eliminar
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) //botón para guardar un nuevo registro o una modificación
        {
            if (lblTitulo.Text == "Registrar Permisos")
            {
                if (cmbRol.Text == "") //validar campo vacío
                {
                    MsgB Mbox = new MsgB("advertencia", "Seleccione un rol");
                    DialogResult DR = Mbox.ShowDialog();
                }
                else
                {
                    GuardarPermisoRol();
                    MsgB Mbox = new MsgB("informacion", "Permisos registrados");
                    DialogResult DR = Mbox.ShowDialog();
                    limpiarCampos();
                }
            }
            else if (lblTitulo.Text == "Editar Permisos")
            {
                if (cmbRol.Text == "") //validar campo vacío
                {
                    MsgB Mbox = new MsgB("advertencia", "Seleccione un rol");
                    DialogResult DR = Mbox.ShowDialog();
                }
                else
                {
                    ActualizarPermisoRol();
                    MsgB Mbox = new MsgB("informacion", "Permisos actualizados");
                    DialogResult DR = Mbox.ShowDialog();
                    limpiarCampos();
                }
            }

        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Editar Permisos";
            btnEditar.Visible = false;
            btnNuevo.Visible = true;
            limpiarCampos();
        }

        private void cargarPermisos() //Marcar los combobox del datagridview al obtener los permisos del rol a editar
        {
            MySqlConnection conn = new MySqlConnection();
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");

            try
            {
                conn.Open();

                string sql = ("SELECT ID_OBJETO, ID_PERMISO, PERMITIDO FROM TBL_PERMISO_ROL WHERE ID_ROL = '"
                + ExisteRol() + "';");
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idObjeto = reader.GetInt32("ID_OBJETO");
                            int idPermiso = reader.GetInt32("ID_PERMISO");
                            bool permitido = reader.GetBoolean("PERMITIDO");

                            // Buscar la fila correspondiente al idObjeto en el DataGridView
                            DataGridViewRow row = dgvRolPermiso.Rows
                                .Cast<DataGridViewRow>()
                                .FirstOrDefault(r => Convert.ToInt32(r.Cells["ID"].Value) == idObjeto);

                            if (row != null)
                            {
                                switch (idPermiso)
                                {
                                    case 1:
                                        row.Cells["VER"].Value = permitido;
                                        break;
                                    case 2:
                                        row.Cells["CREAR"].Value = permitido;
                                        break;
                                    case 3:
                                        row.Cells["EDITAR"].Value = permitido;
                                        break;
                                    case 4:
                                        row.Cells["ELIMINAR"].Value = permitido;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ActualizarPermisoRol() //función para actualizar permisos 
        {
            foreach (DataGridViewRow row in dgvRolPermiso.Rows) //Recorrer el datagridview para obtener los valores de las casillas y asignar los permisos
            {
                permiso.IdRol = cmbRol.Text;
                permiso.IdObjeto = int.Parse(row.Cells["ID"].Value.ToString());

                if (Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["VER"].Tag);
                    permiso.Permitido = true;
                    cDatos.ActualizarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["VER"].Tag);
                    permiso.Permitido = false;
                    cDatos.ActualizarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["CREAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["CREAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.ActualizarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["CREAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["CREAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.ActualizarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["EDITAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["EDITAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.ActualizarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["EDITAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["EDITAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.ActualizarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["ELIMINAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.ActualizarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["ELIMINAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.ActualizarPermiso(permiso);
                }
            }
        }

        private void cmbRol_SelectedValueChanged(object sender, EventArgs e) //Validar los permisos por rol al cambiar el valor del combobox
        {
            if (lblTitulo.Text == "Registrar Permisos" && modelo.existePermiso(ExisteRol()) && !String.IsNullOrEmpty(cmbRol.Text)) //validar si el rol seleecionado ya tiene permisos asignados
            {
                MsgB m = new MsgB("error", "El rol seleccionado ya tiene permisos asignados");
                DialogResult dR = m.ShowDialog();
                limpiarCampos();
            }

            if (lblTitulo.Text == "Editar Permisos" && !modelo.existePermiso(ExisteRol()) && !String.IsNullOrEmpty(cmbRol.Text)) //validar si el rol seleccionado ya tiene permisos asignados para editar
            {
                MsgB m = new MsgB("error", "El rol seleccionado no puede editarse, no tiene permisos asignados");
                DialogResult dR = m.ShowDialog();
                limpiarCampos();
            }
            else
            {
                cargarPermisos();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Registrar Permisos";
            btnEditar.Visible = true;
            btnNuevo.Visible = false;
            limpiarCampos();
        }

        public int ExisteRol() //Validar que existe el rol obteniendo el Id de rol según el rol en el combobox
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = BaseDatosHCL.ObtenerConexion();
            comando.CommandText = ("SELECT ID_ROL FROM TBL_ROL WHERE ROL = '"
                + cmbRol.Text + "';");

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                return (int)leer["ID_ROL"];
            }
            else
            {
                return 0;
            }
        }

        private void dgvRolPermiso_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                // Marcar la columna 3 si la columna 4, 5 o 6 también está marcada
                bool check = (bool)dgvRolPermiso.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (check)
                {
                    dgvRolPermiso.Rows[e.RowIndex].Cells[2].Value = true;
                }
            }
        }

        private void rbtnHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            rBtnDeshabilitar.Checked = false;

            if (rbtnHabilitar.Checked)
            {
                foreach (DataGridViewRow row in dgvRolPermiso.Rows) //recorrer las filas del datagrid
                {
                    if (!Convert.ToBoolean(row.Cells["VER"].Value))
                    {
                        row.Cells["VER"].Value = true;
                    }
                    if (!Convert.ToBoolean(row.Cells["CREAR"].Value))
                    {
                        row.Cells["CREAR"].Value = true;
                    }
                    if (!Convert.ToBoolean(row.Cells["EDITAR"].Value))
                    {
                        row.Cells["EDITAR"].Value = true;
                    }
                    if (!Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                    {
                        row.Cells["ELIMINAR"].Value = true;
                    }
                }
            }
        }

        private void rBtnDeshabilitar_CheckedChanged(object sender, EventArgs e)
        {
            rbtnHabilitar.Checked = false;

            if (rBtnDeshabilitar.Checked)
            {
                foreach (DataGridViewRow row in dgvRolPermiso.Rows) //recorrer las filas del datagrid
                {
                    if (Convert.ToBoolean(row.Cells["VER"].Value))
                    {
                        row.Cells["VER"].Value = false;
                    }
                    if (Convert.ToBoolean(row.Cells["CREAR"].Value))
                    {
                        row.Cells["CREAR"].Value = false;
                    }
                    if (Convert.ToBoolean(row.Cells["EDITAR"].Value))
                    {
                        row.Cells["EDITAR"].Value = false;
                    }
                    if (Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                    {
                        row.Cells["ELIMINAR"].Value = false;
                    }
                }
            }
        }

        private void R_R_RolesPermisos_FormClosing(object sender, FormClosingEventArgs e)
        {
            limpiarCampos();
        }
    }
}
