using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using SpreadsheetLight.Drawing;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHCL
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void crearExcel()
        {
            SLDocument sl = new SLDocument();

            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(Properties.Resources.logo);
            Byte[] ba;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                bm.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Close();
                ba = ms.ToArray();
            }
            SLPicture pic = new SLPicture(ba, DocumentFormat.OpenXml.Packaging.ImagePartType.Jpeg);
            pic.SetPosition(0, 0);
            pic.ResizeInPixels(80, 80);
            sl.InsertPicture(pic);

            sl.SetCellValue("C2", "Reporte de Facturas");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_FACTURA");
            sl.SetCellValue("B" + celdaCabecera, "Factura");
            sl.SetCellValue("C" + celdaCabecera, "Id Soli. Reserva");
            sl.SetCellValue("D" + celdaCabecera, "Nombre");
            sl.SetCellValue("E" + celdaCabecera, "Apellido");
            sl.SetCellValue("F" + celdaCabecera, "Identificacion");
            sl.SetCellValue("G" + celdaCabecera, "Fecha");
            sl.SetCellValue("H" + celdaCabecera, "Ingreso");
            sl.SetCellValue("I" + celdaCabecera, "Salida");
            sl.SetCellValue("J" + celdaCabecera, "Total");

            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "J" + celdaCabecera, estiloCa);

            try
            {
                string sql = "SELECT NFACTURA, s.ID_SOLICITUDRESERVA, c.NOMBRE, c.APELLIDO, c.DNI_PASAPORTE, f.FECHA, s.INGRESO, s.SALIDA, f.TOTAL FROM TBL_FACTURA f INNER JOIN TBL_SOLICITUDRESERVA s ON f.ID_SOLICITUDRESERVA = s.ID_SOLICITUDRESERVA INNER JOIN TBL_CLIENTE c ON s.COD_CLIENTE = c.CODIGO";

                // Agregar condiciones de fecha a la consulta SQL
                sql += " WHERE f.FECHA BETWEEN @FechaInicio AND @FechaFin";

                using (MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion())
                using (MySqlCommand comando = new MySqlCommand(sql, conexionBD))
                {
                    comando.Parameters.AddWithValue("@FechaInicio", dateTimePicker_Desde.Value);
                    comando.Parameters.AddWithValue("@FechaFin", dateTimePicker_Hasta.Value);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            celdaCabecera++;
                            sl.SetCellValue("B" + celdaCabecera, reader["NFACTURA"].ToString());
                            sl.SetCellValue("C" + celdaCabecera, reader["ID_SOLICITUDRESERVA"].ToString());
                            sl.SetCellValue("D" + celdaCabecera, reader["NOMBRE"].ToString());
                            sl.SetCellValue("E" + celdaCabecera, reader["APELLIDO"].ToString());
                            sl.SetCellValue("F" + celdaCabecera, reader["DNI_PASAPORTE"].ToString());
                            sl.SetCellValue("G" + celdaCabecera, reader["FECHA"].ToString());
                            sl.SetCellValue("H" + celdaCabecera, reader["INGRESO"].ToString());
                            sl.SetCellValue("I" + celdaCabecera, reader["SALIDA"].ToString());
                            sl.SetCellValue("J" + celdaCabecera, reader["TOTAL"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí
                MsgB mbox = new MsgB("error", "Error:" + ex.Message);
                DialogResult dR = mbox.ShowDialog();
            }

            SLStyle EstiloB = sl.CreateStyle();
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "J" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B", "J");

            SaveFileDialog sf = new SaveFileDialog();

            sf.DefaultExt = "*.xlsx";
            sf.FileName = "FacturasRegistradas";
            sf.Filter = " Libro de Excel (*.xlsx) | *.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                sl.SaveAs(sf.FileName);
                MsgB mbox = new MsgB("informacion", "Archivo Excel creado con éxito");
                DialogResult dR = mbox.ShowDialog();
                this.Close();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (dateTimePicker_Desde.Value > dateTimePicker_Hasta.Value)
            {
                MsgB mbox = new MsgB("advertencia", "La fecha inicial no puede ser mayor que la fecha final");
                DialogResult dR = mbox.ShowDialog();
            }
            else if (dateTimePicker_Desde.Value > DateTime.Now)
            {
                MsgB mbox = new MsgB("advertencia", "La fecha de inicio no puede ser mayor a la actual");
                DialogResult dR = mbox.ShowDialog();
            }
            else if (dateTimePicker_Hasta.Value < dateTimePicker_Desde.Value)
            {
                MsgB mbox = new MsgB("advertencia", "La fecha final no puede ser menor que la fecha inicial");
                DialogResult dR = mbox.ShowDialog();
            }
            else if (dateTimePicker_Hasta.Value > DateTime.Now)
            {
                MsgB mbox = new MsgB("advertencia", "La fecha final no puede ser mayor a la actual");
                DialogResult dR = mbox.ShowDialog();
            }
            else
            {
                crearExcel();
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
