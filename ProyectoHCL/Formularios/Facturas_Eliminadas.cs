using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfiles
{
    public partial class Facturas_Eliminadas : Form
    {
        public Facturas_Eliminadas()
        {
            InitializeComponent();
        }

        public object PDFWriter { get; private set; }

        private void Btn_Generarpdf_Click(object sender, EventArgs e)
        {
            /*PDFWriter = new PdfWriter("Reporte.PDF");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf);
            using.system.drawing;*/
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            /*Form Frm_Perfiles = new Frm_Perfiles();
            Frm_Perfiles.Show();
            this.Close();*/
        }
    }
}
