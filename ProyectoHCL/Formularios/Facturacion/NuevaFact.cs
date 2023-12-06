/* -----------------------------------------------------------------------
    Universidad Nacional Autonoma de Honduras (UNAH)
		Facultad de Ciencias Economicas
	Departamento de Informatica administrativa
         Analisis, Programacion y Evaluacion de Sistemas
                    Tercer Periodo 2013


Equipo:
GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

JOEL ENRIQUE GODOY BONILLA---------(joel.godoy@unah.hn)

OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

Catedratico analisis y diseño:             Lic.Giancarlo Martini Scalici Aguilar 
catedratico programacion e implementacion: Lic.Karla Melisa Garcia Pineda 
catedratico evaluacion de sistemas:        Lic.Karla Melisa Garcia Pineda 


---------------------------------------------------------------------

Programa:         Pantalla de Ingreso de nueva Factura
Fecha:             27- septiembre - 2023
Programador: Joel
descripcion:       Pantalla que contrala las validaciones de nueva Factura

-----------------------------------------------------------------------

                Historial de Cambio

-----------------------------------------------------------------------

Programador               Fecha                      Descripcion
GABRIELA  MANCIA  

HILDEGARD  MONTALVAN   

NELSON SALGADO  

JOEL  GODOY 

OLMAN  DOMÍNGUEZ 

----------------------------------------------------------------------- */

/* librerias utilizadas para facilitar el proceso */
using DocumentFormat.OpenXml.Bibliography;
using MySql.Data.MySqlClient; /* libreria para conectar a la BD */
using ProyectoHCL.clases;/* hacer uso de las clases dentro del proyecto */
using System; /* directiva para identificar los bloques de codigo */
using System.Collections.Generic; /* libreria para lectura*/
using System.ComponentModel;/* jerarguia de los componentes funcionales */
using System.Data; /* Conexion a la BD*/
using System.Drawing; /* impresion de archivos en excel */
using System.Linq; /* libreria para clases e interfaces */
using System.Text; /* manipular informacion dentro de la aplicacion */
using System.Threading.Tasks; /* libreria para impresion */
using System.Windows.Forms;
using static ProyectoHCL.Formularios.CtrlFacturacion;

namespace ProyectoHCL.Formularios
{
    public partial class NuevaFact : Form
    {
        public NuevaFact()
        {
            InitializeComponent();
            pagFinal = numFilas;
            CargarDGFact();
        }

        private void btnCerrar_Click(object sender, EventArgs e) // Botón cerrar
        {
            this.Close();
        }

        Facturacion user = new Facturacion(); /* declaracion de variables y valores */
        DataSet ds = new DataSet();
        int pagInicio = 1, indice = 0, numFilas = 5, pagFinal, cmbIndice = 0;
        int posY = 0;
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e) //Mover por escritorio
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void CargarDGFact() //Cargar datagridview
        {
            user.Inicio1 = pagInicio;
            user.Final1 = pagFinal;
            ds = user.PaginacionFact();
            dgvReservas.DataSource = ds.Tables[1];

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) / numFilas;   /* declaracion de variable y conversion de valores  */

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) % numFilas > 0) cantidad++; /* condicional IF */

            txtPaginacion.Text = cantidad.ToString();

            cmbPaginacion.Items.Clear();

            for (int x = 1; x <= cantidad; x++)   /* Ciclo For para verificar las instrucciones correspondientes en valor de variable cantidad */
                cmbPaginacion.Items.Add(x.ToString());

            cmbPaginacion.SelectedIndex = indice;

            HabilitarBotones();
        }


        private void NuevaFact_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn btnFacturar = new DataGridViewImageColumn(); //se crea el boton en el dataGrid
            btnFacturar.Name = "FACTURAR"; //Nombre del boton 
            dgvReservas.Columns.Add(btnFacturar); //Se especifica el nombre de dataGrid para agregar boton
        }

        private void buscarReserva(string buscarF)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database=railway; Uid=root; pwd=LpxjPRi2Ckkz7FiKNUHn;"))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("buscarReserva1", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@nombreR", MySqlDbType.VarChar, 50).Value = buscarF;

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvReservas.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsgB mbox = new MsgB("error", "Error: " + ex.Message);
                DialogResult dR = mbox.ShowDialog();
            }
        }


        private void txtBuscarRe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtBuscarRe.Text != "")
                {
                    buscarReserva(txtBuscarRe.Text);
                }
                else
                {
                    CargarDGFact();
                }
            }
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvReservas.Columns[e.ColumnIndex].Name == "FACTURAR")
            {
                try
                {
                    this.Hide();
                    info.factura = "0";
                    info.reserva = dgvReservas.CurrentRow.Cells["CODIGO"].Value.ToString();
                    DateTime ingreso = Convert.ToDateTime(dgvReservas.CurrentRow.Cells["INGRESO"].Value.ToString());
                    string ingreso1 = ingreso.ToString("dd/MM/yyyy");
                    info.ingreso = ingreso1;
                    DateTime salida = Convert.ToDateTime(dgvReservas.CurrentRow.Cells["SALIDA"].Value.ToString());
                    string salida1 = salida.ToString("dd/MM/yyyy");
                    info.salida = salida1;
                    //this.Hide();
                    Form formulario = new Formularios.Factura();
                    info.est = 2;
                    info.estFact = dgvReservas.CurrentRow.Cells["ESTADO"].Value.ToString(); ;
                    formulario.ShowDialog();
                    CargarDGFact();
                }
                catch (Exception ex)
                {
                    MsgB Mbox = new MsgB("error", "Se produjo un error" + ex.Message);
                    DialogResult DR = Mbox.ShowDialog();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nuevo = new NuevaReservacion();
            nuevo.ShowDialog();
        }

        private void dgvReservas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvReservas.Columns[e.ColumnIndex].Name == "FACTURAR")
            {
                Image imagen = Properties.Resources.caja;

                dgvReservas.Rows[e.RowIndex].Height = imagen.Height + 8;
                dgvReservas.Columns[e.ColumnIndex].Width = imagen.Width + 58;

                e.Value = imagen;
            }
        }

        private void cmbPaginacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text);
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGFact();
        }

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIndice = cmbMostrar.SelectedIndex;
            switch (cmbIndice) /* realizar las respectivas validaciones valor por valor */
            {
                case 0:
                    numFilas = 10;
                    break;
                case 1:
                    numFilas = 20;
                    break;
                case 2:
                    numFilas = 30;
                    break;
                case 3:
                    numFilas = 40;
                    break;
                case 4:
                    numFilas = 50;
                    break;
            }
            pagFinal = numFilas;
            CargarDGFact();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text) - 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGFact();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbPaginacion.Text) + 1;
            indice = pagina - 1;
            pagInicio = (pagina - 1) * numFilas + 1;
            pagFinal = pagina * numFilas;
            CargarDGFact();
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

            if (indice == (Convert.ToInt32(txtPaginacion.Text) - 1))
            {
                btnSig.Enabled = false;
            }
            else
            {
                btnSig.Enabled = true;
            }
        }

        private void txtBuscarRe_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarRe.Text != "")
            {
                buscarReserva(txtBuscarRe.Text);
            }
            else
            {
                CargarDGFact();
            }
        }
    }
}
