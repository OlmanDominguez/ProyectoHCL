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
    public partial class CtrlParametros : Form
    {

        Parametros Paramt = new Parametros();
        DataSet ds = new DataSet();

        public CtrlParametros()
        {
            InitializeComponent();
            // pagFinal = numFilas;
            //CargarDGCl();

        }

        AdmonParametros admonParametros = new AdmonParametros();
        private void CtrlParametros_Load(object sender, EventArgs e)
        {
           // RellenarGrid();
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvParametro.Columns.Add(btnUpdate);

        }

        private void dgvParametro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvParametro.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvParametro.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvParametro.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvParametro.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
        }

        private void dgvParametro_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgvParametro.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarParametro editarPart = new EditarParametro();

               // editarPart.id = dgvParametro.CurrentRow.Cells["ID"].Value.ToString();
                editarPart.cmbParametro.Text = dgvParametro.CurrentRow.Cells["NOMBRE_PARAMETRO"].Value.ToString();
                editarPart.txtValor.Text = dgvParametro.CurrentRow.Cells["VALOR"].Value.ToString();
              //  editarPart. = dgvParametro.CurrentRow.Cells["FECHA_CREACION"].Value.ToString();
                //editarPart. = dgvParametro.CurrentRow.Cells["FECHA_MODIFICACION"].Value.ToString();
                editarPart.ShowDialog();
                //  CargarDG();
            }
        }
       /* public void MostrarParametro()
        {
           dgvParametro.DataSource = AdmonParametros.MostrarParametro(); //Llamar metodo mostrar Roles en dataGrid
        }*/

        private void btnAgregarParametro_Click(object sender, EventArgs e)
        {
            EditarParametro regParametro = new EditarParametro(); //Se crea un objeto del form RegistrarUsuarios
            regParametro.ShowDialog();
          //  CargarDG();
        }
    }
}
