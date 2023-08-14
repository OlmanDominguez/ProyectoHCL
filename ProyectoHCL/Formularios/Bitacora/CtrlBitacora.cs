using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using MySql.Data.MySqlClient;
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
using ProyectoHCL.Formularios.Bitacora;
using SpreadsheetLight.Drawing;
using SpreadsheetLight;

namespace ProyectoHCL.Formularios
{
    public partial class CtrlBitacora : Form
    {
        clases.Bitacora bitacora = new clases.Bitacora();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;

        public CtrlBitacora()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDG();
        }

        private void CargarDG()
        {
            bitacora.Inicio1 = pagInicio;
            bitacora.Final1 = pagFinal;
            ds = bitacora.PaginacionBitacora();
            dgvBitacora.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++;

            txtPreg.Text = cantidad.ToString();

            cmbPreg.Items.Clear();

            for (int x = 1; x <= cantidad; x++)
                cmbPreg.Items.Add(x.ToString());

            cmbPreg.SelectedIndex = indice;

            HabilitarBotones();
        }


        public void BuscarServicio(string buscarS)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("buscarBitacora", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombreU", MySqlDbType.VarChar, 50).Value = buscarS;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBitacora.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void dgvBitacora_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvBitacora.Columns[e.ColumnIndex].Name == "VER" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvBitacora.Rows[e.RowIndex].Cells["VER"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\ver.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 29, e.CellBounds.Top + 3);

                this.dgvBitacora.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvBitacora.Columns[e.ColumnIndex].Width = icoAtomico.Width + 58;

                e.Handled = true;
            }

        }

        private void cmbPreg_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPreg.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void cmbMostrar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbIndice = cmbMostrar.SelectedIndex;
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
            CargarDG();
        }

        public static class preg
        {
            public static string id, user, submenu, pantalla, accion, fecha, descripcion;

        }

        private void dgvBitacora_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgvBitacora.Columns[e.ColumnIndex].Name == "VER")
            {
                preg.id = dgvBitacora.CurrentRow.Cells["ID"].Value.ToString();
                preg.user = dgvBitacora.CurrentRow.Cells["USUARIO"].Value.ToString();
                preg.submenu = dgvBitacora.CurrentRow.Cells["SUBMENU"].Value.ToString();
                preg.pantalla = dgvBitacora.CurrentRow.Cells["PANTALLA"].Value.ToString();
                preg.accion = dgvBitacora.CurrentRow.Cells["ACCION"].Value.ToString();
                preg.fecha = dgvBitacora.CurrentRow.Cells["FECHA"].Value.ToString();
                preg.descripcion = dgvBitacora.CurrentRow.Cells["DESCRIPCION"].Value.ToString();

                Form form = new Formularios.Bitacora.ShowBitacora();
                form.ShowDialog();

            }


        }

        private void btnAnt_Click_1(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPreg.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }

        private void btnSig_Click_1(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPreg.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDG();
        }
        private void HabilitarBotones()
        {
            if (pagInicio == 1)
            {
                btnAnt.Enabled = false;
                cmbMostrar.Enabled = true;
            }
            else
            {
                btnAnt.Enabled = true;
                cmbMostrar.Enabled = false;
            }

            if (indice == (Convert.ToInt32(txtPreg.Text) - 1))
            {
                btnSig.Enabled = false;
            }
            else
            {
                btnSig.Enabled = true;
            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarServicio(txtBuscar.Text);
            }
            else
            {
                CargarDG();
            }
        }

        private void CtrlBitacora_Load_1(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "VER";
            dgvBitacora.Columns.Add(btnUpdate);

        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            sl.SetCellValue("C2", "Reporte de Bitacora");
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "F2");

            int celdaCabecera = 6, celdaInicial = 6;

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "TBL_Bitacora");
            sl.SetCellValue("B" + celdaCabecera, "Id Bitacora");
            sl.SetCellValue("C" + celdaCabecera, "Id Usuario");
            sl.SetCellValue("D" + celdaCabecera, "Usuario");
            sl.SetCellValue("E" + celdaCabecera, "Id Modulo");
            sl.SetCellValue("F" + celdaCabecera, "Modulo");
            sl.SetCellValue("G" + celdaCabecera, "Id Objeto");
            sl.SetCellValue("H" + celdaCabecera, "Objeto");
            sl.SetCellValue("I" + celdaCabecera, "Fecha");
            sl.SetCellValue("J" + celdaCabecera, "Accion");
            sl.SetCellValue("K" + celdaCabecera, "Descripcion");

            SLStyle estiloCa = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 12;
            estiloT.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Blue, System.Drawing.Color.Blue);
            sl.SetCellStyle("B" + celdaCabecera, "K" + celdaCabecera, estiloCa);

            string sql = "SELECT b.ID_BITACORA, u.ID_USUARIO, u.USUARIO, m.ID_MODULO, m.NOMBRE_MODULO, o.ID_OBJETO, o.OBJETO, b.FECHA, b.ACCION, " +
                "b.DESCRIPCION FROM TBL_BITACORA b INNER JOIN TBL_USUARIO u ON b.ID_USUARIO = u.ID_USUARIO INNER JOIN PT_OBJETO o ON b.ID_OBJETO = o.ID_OBJETO " +
                "INNER JOIN PT_MODULO m ON o.ID_MODULO = m.ID_MODULO;";

            MySqlConnection conexionBD = BaseDatosHCL.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, reader["ID_BITACORA"].ToString());
                sl.SetCellValue("C" + celdaCabecera, reader["ID_USUARIO"].ToString());
                sl.SetCellValue("D" + celdaCabecera, reader["USUARIO"].ToString());
                sl.SetCellValue("E" + celdaCabecera, reader["ID_MODULO"].ToString());
                sl.SetCellValue("F" + celdaCabecera, reader["NOMBRE_MODULO"].ToString());
                sl.SetCellValue("G" + celdaCabecera, reader["ID_OBJETO"].ToString());
                sl.SetCellValue("H" + celdaCabecera, reader["OBJETO"].ToString());
                sl.SetCellValue("I" + celdaCabecera, reader["FECHA"].ToString());
                sl.SetCellValue("J" + celdaCabecera, reader["ACCION"].ToString());
                sl.SetCellValue("K" + celdaCabecera, reader["DESCRIPCION"].ToString());
            }

            SLStyle EstiloB = sl.CreateStyle();
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "K" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B", "K");

            SaveFileDialog sf = new SaveFileDialog();

            sf.DefaultExt = "*.xlsx";
            sf.FileName = "ExcelBitacora";
            sf.Filter = " Libro de Excel (*.xlsx) | *.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                sl.SaveAs(sf.FileName);
                MsgB mbox = new MsgB("informacion", "Archivo Excel creado con éxito");
                DialogResult dR = mbox.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            crearExcel();
        }
    }
}
