using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
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

namespace ProyectoHCL.Formularios
{

    public partial class Cliente : Form
    {
        public string cTexto;

        public static class compartida
        {
            public static string id;
        }

        public Cliente()
        {
            InitializeComponent();
        }

        #region "Mis Metodos
        private void Formato_cl()
        {
            dgvClientes.Columns[0].Width = 200;
            dgvClientes.Columns[0].HeaderText = "NOMBRES";
            dgvClientes.Columns[1].Width = 200;
            dgvClientes.Columns[1].HeaderText = "APELLIDOS";
            dgvClientes.Columns[2].Width = 150;
            dgvClientes.Columns[2].HeaderText = "IDENTIFICACION";
            dgvClientes.Columns[3].Width = 90;
            dgvClientes.Columns[3].HeaderText = "TIPO";
            dgvClientes.Columns[4].Width = 100;
            dgvClientes.Columns[4].HeaderText = "TELEFONO";

            DataGridViewImageColumn btn_ver = new DataGridViewImageColumn();
            btn_ver.Name = "";
            dgvClientes.Columns.Add(btn_ver);
            dgvClientes.Columns[5].Width = 50;
            btn_ver.Image = Resources.ver;
            btn_ver.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn btn_editar = new DataGridViewImageColumn();
            btn_editar.Name = "";
            dgvClientes.Columns.Add(btn_editar);
            dgvClientes.Columns[6].Width = 50;
            btn_editar.Image = Resources.editar;
            btn_editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn btn_eliminar = new DataGridViewImageColumn();
            btn_eliminar.Name = "";
            dgvClientes.Columns.Add(btn_eliminar);
            dgvClientes.Columns[7].Width = 50;
            btn_eliminar.Image = Resources.eliminar;
            btn_eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;


        }
        private void Listado_cl(string cTexto)
        {
            D_Cliente Datos = new D_Cliente();
            dgvClientes.DataSource = Datos.Listado_cl(cTexto);
            this.Formato_cl();
        }


        #endregion

        private void Cliente_Load(object sender, EventArgs e)
        {
            this.Listado_cl("%");

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            cTexto = "%" + txt_buscar.Text + "%";
            Listado_cl(cTexto);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                compartida.id = (string)dgvClientes.CurrentRow.Cells[2].Value;
                Form formulario = new Formularios.InfoCliente();
                formulario.ShowDialog();
            }
            if (e.ColumnIndex == 6)
            {
                compartida.id = (string)dgvClientes.CurrentRow.Cells[2].Value;
                Form formulario = new Formularios.Clientes.UpdateCliente();
                formulario.ShowDialog();
            }
            if (e.ColumnIndex == 7)
            {
                compartida.id = (string)dgvClientes.CurrentRow.Cells[2].Value;
                Form formulario = new Formularios.Clientes.EliminarCliente();
                formulario.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Listado_cl("%");
        }
    }
}
