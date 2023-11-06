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
using static ProyectoHCL.Formularios.CtrlBitacora;

namespace ProyectoHCL.Formularios.Bitacora
{
    public partial class ShowBitacora : Form
    {
        public ShowBitacora()
        {
            InitializeComponent();
        }

        public string ObtenerValorAnterior()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR_ANTERIOR FROM TBL_BITACORA WHERE ID_BITACORA = " + preg.id + ";";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR_ANTERIOR"].ToString();
            }
            else
            {
                return null;

            }

            conn.Close();
        }

        public string ObtenerValorNuevo()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT VALOR_NUEVO FROM TBL_BITACORA WHERE ID_BITACORA = " + preg.id + ";";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["VALOR_NUEVO"].ToString();
            }
            else
            {
                return null;

            }

            conn.Close();
        }

        public string ObtenerRegistro()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            string sql = "SELECT REGISTRO FROM TBL_BITACORA WHERE ID_BITACORA = " + preg.id + ";";
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                return read["REGISTRO"].ToString();
            }
            else
            {
                return null;

            }

            conn.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int posY = 0;
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void ShowBitacora_Load(object sender, EventArgs e)
        {
            if (preg.accion == "EDICIÓN")
            {
                lblRegistro.Visible = true;
                label10.Visible = true;
                lblVA.Visible = true;
                label1.Visible = true;
                lblVN.Visible = true;
                label8.Visible = true;
                lblVA.Text = ObtenerValorAnterior();
                lblVN.Text = ObtenerValorNuevo();
                lblRegistro.Text = ObtenerRegistro();
            }
            else if (preg.accion == "ELIMINACIÓN")
            {
                lblRegistro.Visible = true;
                label10.Visible = true;
                lblRegistro.Text = ObtenerRegistro();
            }

            lb_idBitacora.Text = preg.id;
            lb_user.Text = preg.user;
            lb_pantalla.Text = preg.pantalla;
            lb_accion.Text = preg.accion;
            lb_fecha.Text = preg.fecha;
            lb_descripcion.Text = preg.descripcion;
        }
    }
}
