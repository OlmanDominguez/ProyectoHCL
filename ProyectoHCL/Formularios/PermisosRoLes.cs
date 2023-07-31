//using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProyectoHCL.Properties;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;
//using System.Drawing.Printing;//estas librerias se instalaron para imprimir un documento pdf
using Microsoft.VisualBasic.ApplicationServices;
using iText.Kernel.Pdf;
using System.Reflection.Metadata;
//using DocumentFormat.OpenXml.Wordprocessing;
using Document = iText.Layout.Document;
using iText.Kernel.Geom;
using iText.Layout.Element;
using PageSize = iText.Kernel.Geom.PageSize;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;

namespace ProyectoHCL.Formularios
{

    public partial class PermisosRoLes : Form
    {
        Roles user = new Roles();
        DataSet ds = new DataSet();
        int pagInicio = 1, indice = 0, numFilas = 10, pagFinal;

        public PermisosRoLes()
        {

            InitializeComponent();
            pagFinal = numFilas;
            RellenarGrid();
            // panel1.BackColor = Color.FromArgb(125, Color.DeepSkyBlue); //colocar transaparente el panel izquierdo al ejecutar
            // panel2.BackColor = Color.FromArgb(120, Color.DimGray);//colocar transaparente el panel superior al ejecutar


        }

        private void CargarDTR()
        {
            user.Inicio1 = pagInicio;
            user.Final1 = pagFinal;
            ds = user.PaginacionRoles();
            Roles_Permisos_DG.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPaginacion.Text = cantidad.ToString();

            crPaginacion.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                crPaginacion.Items.Add(x.ToString());

            crPaginacion.SelectedIndex = indice;
        }

        RgtRoles rgtRoles = new RgtRoles(); //crear objeto Rgtroles para acceder a sus metodos
        Roles roles = new Roles();//crear objetos roles para acceder a sus parametros 

        private void PermisosRoLes_Load(object sender, EventArgs e)
        {
            RellenarGrid(); //se muestran roles registrados en el dataGrid

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn(); //se crea el boton en el dataGrid
            btnUpdate.Name = "EDITAR"; //Nombre del boton 
            Roles_Permisos_DG.Columns.Add(btnUpdate); //Se especifica el nombre de dataGrid para agregar boton

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "ELIMINAR";
            Roles_Permisos_DG.Columns.Add(btnDelete);
        }
        public void RellenarGrid()
        {
            Roles_Permisos_DG.DataSource = rgtRoles.RellenarGrid(); //Llamar metodo mostrar Roles en dataGrid
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form formulario = new Nuevo_Registro_Rol();
            formulario.ShowDialog(); //Bloquea el form nuevo
        }

        private void Roles_Permisos_DG_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.Roles_Permisos_DG.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.Roles_Permisos_DG.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.Roles_Permisos_DG.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.Roles_Permisos_DG.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.Roles_Permisos_DG.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                /*
                DataGridViewButtonCell celBoton = this.Roles_Permisos_DG.Rows[e.RowIndex].Cells["ELIMINAR"] as DataGridViewButtonCell;
               Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.Roles_Permisos_DG.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.Roles_Permisos_DG.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;*/
            }

        }

        private void Roles_Permisos_DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Roles_Permisos_DG.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                bool elimino = rgtRoles.EliminarRoles(Roles_Permisos_DG.CurrentRow.Cells["ID_ROL"].Value.ToString()); //EL metodo eliminar recibe como string el id del DataGrid

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar este Rol?",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (elimino)
                    {
                        MessageBox.Show("Rol eliminado");
                        RellenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Rol no eliminado");
                    }

                }
                else /*if (dialogResult == DialogResult.No)*/
                {

                }
            }
            if (this.Roles_Permisos_DG.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                EditarRoles editarRoles = new EditarRoles(); //Crear objeto del form Editarroles

                //  editarRoles.ID_rol= Roles_Permisos_DG.CurrentRow.Cells["ID"].Value.ToString();
                editarRoles.txtNombre.Text = Roles_Permisos_DG.CurrentRow.Cells["NOMBRE_ROL"].Value.ToString();
                editarRoles.txtEstadoRol.Text = Roles_Permisos_DG.CurrentRow.Cells["ESTADO_ROL"].Value.ToString();
                editarRoles.txtFechaC.Text = Roles_Permisos_DG.CurrentRow.Cells["FECHA_CREACION"].Value.ToString();
                editarRoles.txtFechaActualizacion.Text = Roles_Permisos_DG.CurrentRow.Cells["FECHA_ACTUALIZACION"].Value.ToString();
                editarRoles.ShowDialog(); //Se oculta el form principal y solo muestra el form editarRol
                RellenarGrid(); //Se llama el metodo Mostrar Roles para actualizar el DataGrid al editar 
            }
        }
        public void BuscarRoles(string buscarR) //Recibe string para buscar usuarios
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarrol", conn); //recibe proc almacenado
                cmd.CommandType = CommandType.StoredProcedure; //se especifica que es un proc almacenado
                cmd.Parameters.Add("@nombreR", MySqlDbType.VarChar, 30).Value = buscarR; //recibe el parametro nombreR definido en el parametro almacenado

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //Se crea tabla
                da.Fill(dt); //Se devuelven los registros en la tabla
                Roles_Permisos_DG.DataSource = dt; //se define la tabla en la que se devuelven los registros
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En que formato desea Imprimir los permisos");
        }

        private void Excel_Click(object sender, EventArgs e)
        {

        }



        /* private void pictureBox4_Click(object sender, EventArgs e)
         {
             PrintDocument doc = new PrintDocument();
             doc.DefaultPageSettings.Landscape = true;
             doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

             PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
             ((Form)ppd).WindowState = FormWindowState.Maximized;

             doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
             {

                 const int DGV_ALTO = 35;
                 int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                 foreach (DataGridViewColumn col in Roles_Permisos_DG.Columns)
                 {
                     ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, Left, top);
                     left += col.Width;

                 }
                 left = ep.MarginBounds.Left;
                 ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                 top += 43;

                 foreach (DataGridViewRow row in Roles_Permisos_DG.Rows)
                 {
                     if (row.Index == Roles_Permisos_DG.RowCount - 1)
                         Left = ep.MarginBounds.Left;
                     foreach (DataGridViewCell cell in row.Cells)
                     {
                         ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe", 13), Brushes.Black, Left, Top + 4);
                         Left += cell.OwningColumn.Width;

                     }
                     Top += DGV_ALTO;
                 }
             };
             ppd.ShowDialog();

         }*/

        private void txtBuscarRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                BuscarRoles(textBuscar.Text);
            }
            else
            {
                RellenarGrid();
            }
        }

        private void textPaginacion_TextChanged(object sender, EventArgs e)
        {

            int pagina = Convert.ToInt32(crPaginacion.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDTR();
        }
        private void crPaginacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // numFilas = int.Parse(mostrarR.Text);
            // pagFinal = numFilas;

            indice = mostrarR.SelectedIndex;
            switch (indice)
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
            CargarDTR();
        }
        private void mostrarR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            crearPDF();
        }
        private void crearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("Reporte.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            //1 pulgada = 72 pt (8 1/2 x 11) (612 x 792)
            PageSize tamanioH = new PageSize (792, 612);
            Document documento = new Document(pdf, tamanioH);
            // Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "id_rol", "rol", "descripcion", "estado_rol", "fecha_creacion", "feecha_ actualizacion" };

            float[] tamanios = { 2, 2, 2, 2, 4, 4, };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
             tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql = "SELECT id_rol, rol, descripcion, estado_rol,  fecha_creacion, fecha_actualizacion FROM TBL_ROL";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
           // conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                for (int x = 1; x < 100; x++) ;
                {


                    tabla.AddCell(new Cell().Add(new Paragraph(reader["id_rol"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["rol"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["descripcion"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["estado_rol"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_creacion"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_actualizacion"].ToString()).SetFont(fontContenido)));

                }
            }
               
            documento.Add(tabla);
            documento.Close();

            var logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("C:/Users/DAOdo/Desktop/SEGUNDO PERIODO 2023/Programacion he implementacion de Sistemas/ProyectoHotelCasaLomas/logo.jpeg")).SetWidth(50);
            var plogo =new  Paragraph("").Add(logo);

            var nombre = new Paragraph("Hotel Casa Lomas");
            nombre.SetTextAlignment(TextAlignment.CENTER);
            nombre.SetFontSize(12);

            var titulo = new Paragraph("Reporte Roles");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd.MM.yyy");
            var dhora = DateTime.Now.ToString("hh.mm.ss");
            var fecha =new Paragraph("fecha:"+ dfecha + "\nHora:" + dhora);
            fecha.SetFontSize(12);


            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter
                ("ReporteRoles.pdf"));
            Document doc = new Document (pdfDoc);

            int numeros = pdfDoc.GetNumberOfPages();

            for (int i = 1; i<= numeros; i++) 
            {
            PdfPage pagina = pdfDoc.GetPage(i);
            
            float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(nombre, 110, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 396, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 700, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("pagina {0} de {1}", i, numeros)), pdfDoc.GetPage
                    (i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i,
                    TextAlignment.CENTER, VerticalAlignment.TOP, 0);
            }
            doc.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    
    }
}






