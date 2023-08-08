using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Point = System.Drawing.Point;
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

        R_E_Parametro R_E_pmo = new R_E_Parametro();
        AdmonParametros admonParametro = new AdmonParametros();
        Parametros pmo = new Parametros();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;

        public CtrlParametros()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDGP();

        }

        private void CargarDGP()
        {
            pmo.Inicio1 = pagInicio;
            pmo.Final1 = pagFinal;
            ds = pmo.PaginacionParametro();
            dgvParametro.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPag.Text = cantidad.ToString();

            cmbPag.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPag.Items.Add(x.ToString());

            cmbPag.SelectedIndex = indice;

            HabilitarBotones();
        }

        private void CtrlParametros_Load(object sender, EventArgs e)
        {
            // RellenarGrid();
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "EDITAR";
            dgvParametro.Columns.Add(btnUpdate);

        }

        public void BuscarParametro(string buscarP)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarParametro", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreP", MySqlDbType.VarChar, 100).Value = buscarP;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvParametro.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnnuevoP_Click(object sender, EventArgs e)
        {
           // R_E_pmo.lbPar.Text = "Registrar Parametro";
            R_E_pmo.Size = new System.Drawing.Size(800, 431);
            R_E_pmo.btnGuardar.Location = new Point(256, 282);
            R_E_pmo.btnCancelar.Location = new Point(466, 282);
          //  R_E_pmo.label2.Location = new Point(243, 34);
           // R_E_pmo.texPa.Location = new Point(243, 65);
            //R_E_pmo.label6.Visible = false;
            R_E_pmo.txtValor.Visible = false;
            //R_E_pmo.label6.Location = new Point(243, 107);
            //R_E_pmo.texPar.Location = new Point(243, 138);
            R_E_pmo.ShowDialog();
            CargarDGP();
        }

        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarP.Text != "")
            {
                BuscarParametro(txtBuscarP.Text);
            }
            else
            {
                CargarDGP();
            }
        }

        private void dgvParametro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvParametro.Columns[e.ColumnIndex].Name == "EDITAR")
            {
               /* R_E_Parametro.lbPar.Text = "Editar Objeto";
                R_E_Parametro.Size = new System.Drawing.Size(800, 371);
                R_E_Parametro.btnGuardar.Location = new Point(256, 213);
                R_E_Parametro.btnCancelar.Location = new Point(466, 213);
                R_E_Parametro.label2.Location = new Point(59, 34);
                R_E_Parametro.txtObj.Location = new Point(59, 67);
                R_E_Parametro.label1.Location = new Point(59, 115);
                R_E_Parametro.cmbEstado.Location = new Point(59, 146);
                R_E_Parametro.label1.Visible = true;
                R_E_Parametro.cmbEstado.Visible = true;
                R_E_Parametro.label6.Location = new Point(421, 34);
                R_E_Parametro.rTxtDesc.Location = new Point(421, 65);
                R_E_Parametro.idpar = dgvParametro.CurrentRow.Cells["ID"].Value.ToString();
                R_E_Parametro.txtObj.Text = dgvParametro.CurrentRow.Cells["NOMBRE"].Value.ToString();
                R_E_Parametro.rTxtDesc.Text = dgvParametro.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                R_E_Parametro.cmbEstado.Text = dgvParametro.CurrentRow.Cells["ESTADO"].Value.ToString();
                R_E_Parametro.ShowDialog();
                R_E_Parametro.limpiarCampos();
                CargarDGP();*/
            }
        }
        private void dgvParametro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex >= 0 && this.dgvParametro.Columns[e.ColumnIndex].Name == "EDITAR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvParametro.Rows[e.RowIndex].Cells["EDITAR"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\editar.ico"); //Se define la carpeta en la que está guardado el ícono del boton
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvParametro.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvParametro.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }
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


        private void cmbPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPag.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGP();
        }

        private void pmtMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIndice = pmtMostrar.SelectedIndex;
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
            CargarDGP();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPag.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGP();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPag.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGP();
        }

        private void HabilitarBotones()
        {
            if (pagInicio == 1)
            {
                btnAnterior.Enabled = false;
                pmtMostrar.Enabled = true;
            }
            else
            {
                btnAnterior.Enabled = true;
                pmtMostrar.Enabled = false;
            }

            if (indice == (Convert.ToInt32(txtPag.Text) - 1))
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }
        }


        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
