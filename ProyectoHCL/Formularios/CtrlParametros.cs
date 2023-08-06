using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
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
using iText.Kernel.Pdf;//todas estas librerias son para imprimir un documento de aqui en adelante
using Document = iText.Layout.Document;
using iText.Kernel.Geom;
using iText.Layout.Element;
using PageSize = iText.Kernel.Geom.PageSize;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;

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

        private void button10_Click(object sender, EventArgs e)
        {
            crearPDF();
        }
        private void crearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("C:/Users/DAOdo/Desktop/SEGUNDO PERIODO 2023/Programacion he implementacion de Sistemas/ProyectoHotelCasaLomas/BackupReporte");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            //1 pulgada = 72 pt (8 1/2 x 11) (612 x 792)
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);
            // Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "id_parametro", "id_usuario", "parametro", "valor", "fecha_ ", "feecha_modifi" };

            float[] tamanios = { 2, 2, 2, 2, 4, 4, };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql = "SELECT id_parametro, id_usuario, parametro, valor,  fecha_cre , fecha_modifi FROM TBL_PARAMETRO";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();
            // conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                for (int x=1; x<100; x++) 
                {


                    tabla.AddCell(new Cell().Add(new Paragraph(reader["id_parametro"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["id_usuario"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["parametro"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["valor"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_cre "].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["fecha_modifi"].ToString()).SetFont(fontContenido)));

                }
            }

            documento.Add(tabla);
            documento.Close();

            var logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("C:/Users/DAOdo/Desktop/SEGUNDO PERIODO 2023/Programacion he implementacion de Sistemas/ProyectoHotelCasaLomas/logo.jpeg")).SetWidth(50);
            var plogo = new Paragraph("").Add(logo);

            var nombre = new Paragraph("Hotel Casa Lomas");
            nombre.SetTextAlignment(TextAlignment.CENTER);
            nombre.SetFontSize(12);

            var titulo = new Paragraph("Reporte Parametro");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd.MM.yyy");
            var dhora = DateTime.Now.ToString("hh.mm.ss");
            var fecha = new Paragraph("fecha:" + dfecha + "\nHora:" + dhora);
            fecha.SetFontSize(12);


            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter
                ("Reporte Parametro.pdf"));
            Document doc = new Document(pdfDoc);

            int numeros = pdfDoc.GetNumberOfPages();

            for (int i = 1; i <= numeros; i++)
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

    }
}
