﻿using MySql.Data.MySqlClient;
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
using System;
using DocumentFormat.OpenXml.Vml;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight.Drawing;
using SpreadsheetLight;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout.Properties;
using iText.Kernel.Pdf;
using Document = iText.Layout.Document;
using iText.Kernel.Geom;
using iText.Layout.Element;
using Image = System.Drawing.Image;

namespace ProyectoHCL
{
    public partial class Buscar : Form
    {
        NuevaReservacion reservacion = new NuevaReservacion();
        public Buscar()
        {
            InitializeComponent();
        }
        public void CargarClientes()
        {
            try
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("select CODIGO as ID ,concat(NOMBRE,\", \",APELLIDO) AS NOMBRE, NOMBRE_RTN as EMPRESA, DNI_PASAPORTE as DNI, RTN, concat(TELEFONO,\"--\",TELEFONO2) as TELEFONOS, EMAIL from TBL_CLIENTE;");
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_clientes.DataSource = dt;


                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }



        }
        public void BuscarCliente(string buscarU) //Recibe string para buscar usuarios
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarC", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreC", MySqlDbType.VarChar, 50).Value = buscarU; //recibe el parametro nombreU definido en el parametro almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                dgv_clientes.DataSource = dt; //se define la tabla en la que se devuelven los registros
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            CargarClientes();
            DataGridViewImageColumn btnFacturar = new DataGridViewImageColumn(); //se crea el boton en el dataGrid
            btnFacturar.Name = "VER"; //Nombre del boton 
            dgv_clientes.Columns.Add(btnFacturar); //Se especifica el nombre de dataGrid para agregar boton
        }

        private void txtBuscar_reservas_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar_Por_Nombre.Text != "") //si el textbox no está vacío devuelve el metodo buscar usuarios
            {
                BuscarCliente(txtBuscar_Por_Nombre.Text); //El metodo recibe el string desde el textbox
            }
            else
            {
                // CargarClientes();
                //CargarReservas(); //Si el textbox está vacio devuelve el metodo mostrar usuarios 
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_clientes.Columns[e.ColumnIndex].Name == "VER")
            {
                reservacion.lbl_1c.Visible = true;
                reservacion.lbl_cliente.Visible = true;
                reservacion.lbl_correonum.Visible = true;
                reservacion.lbl_telefononum.Visible = true;
                reservacion.lbl_correo.Visible = true;
                reservacion.lbl_telefono.Visible = true;
                reservacion.lbl_cliente.Text = dgv_clientes.CurrentRow.Cells["NOMBRE"].Value.ToString();
                reservacion.txt_cod_cliente.Text = dgv_clientes.CurrentRow.Cells["ID"].Value.ToString();
                reservacion.lbl_correonum.Text = dgv_clientes.CurrentRow.Cells["EMAIL"].Value.ToString();
                reservacion.lbl_telefononum.Text = dgv_clientes.CurrentRow.Cells["TELEFONOS"].Value.ToString();
                reservacion.ShowDialog();
                Buscar.ActiveForm.Close();
                NuevaReservacion.ActiveForm.Close();

                //CargarClientes();

                //CargarReservas(); //Se llama el metodo Mostrar usuarios para actualizar el DataGrid al editar 
            }

        }

        private void dgv_clientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgv_clientes.Columns[e.ColumnIndex].Name == "VER")
            {
                Image imagen = Properties.Resources.caja;

                dgv_clientes.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgv_clientes.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
        }
    }
}
