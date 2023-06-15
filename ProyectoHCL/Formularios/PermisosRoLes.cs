using MySqlX.XDevAPI.Relational;
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

    public partial class PermisosRoLes : Form
    {
        public PermisosRoLes()
        {
            InitializeComponent();
            RellenarGrid();
        }

        private void RellenarGrid()
        {
            List<Permisos> permisos = new List<Permisos>();
           //* Permisos.Add(new Permisos("uno", "Administrador", "Activo", "01/02/2023", "01/02/2024", "Editar", "Eliminar"));

            foreach (Permisos p in permisos)
            {
               /* int rowIndex = Roles_Permisos_DG.Rows.Add();
                DataGridViewRow row = Roles_Permisos_DG.Rows[rowIndex];
                Row.Cells[0].Value = p.ID_ROL;
                Row.Cells[1].Value = p.NOMBRE;
                Row.Cells[2].Value = p.ESTADO_ROL;
                Row.Cells[3].Value = p.PRIMER_INGRESO1;
                Row.Cells[4].Value = p.FECHA_VENCIMIENTO1;
                Row.Cells[5].Value = p.EDITAR;
                Row.Cells[6].Value = p.ELIMINAR;*/





            }
        }
    }

}





