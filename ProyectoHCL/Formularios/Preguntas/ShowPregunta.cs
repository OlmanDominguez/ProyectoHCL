using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoHCL.Formularios;
using DocumentFormat.OpenXml.EMMA;
using MySql.Data.MySqlClient;
using DocumentFormat.OpenXml.Vml;
using ProyectoHCL.clases;
using static ProyectoHCL.Formularios.CtrlFacturacion;

namespace ProyectoHCL.Formularios
{
    public partial class ShowPregunta : Form
    {
        public ShowPregunta()
        {
            InitializeComponent();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPregunta_Load(object sender, EventArgs e)
        {
            if (CtrlPreguntas.preg.op == 1)
            {
                txtPregunta.Text = CtrlPreguntas.preg.detalle;
            }
            if (CtrlPreguntas.preg.op == 2)
            {
                txtPregunta.Text = "";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (CtrlPreguntas.preg.op == 1)
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("UPDATE TBL_PREGUNTA SET PREGUNTA = '" + txtPregunta.Text +
                        "' WHERE ID_PREGUNTA = " + CtrlPreguntas.preg.id + ";");

                    comando.ExecuteNonQuery();
                    comando.Connection.Close();

                    MsgB mbox = new MsgB("informacion", "Registro Actualizado");
                    DialogResult dR = mbox.ShowDialog();
                    this.Close();

                }
            }
            if (CtrlPreguntas.preg.op == 2)
            {
                using (BaseDatosHCL.ObtenerConexion())
                {
                    //Consulta
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = BaseDatosHCL.ObtenerConexion();
                    comando.CommandText = ("INSERT INTO TBL_PREGUNTA (PREGUNTA, ID_ESTADO) VALUES ('" + 
                        txtPregunta.Text + "', 1);");

                    comando.ExecuteNonQuery();
                    comando.Connection.Close();

                    MsgB mbox = new MsgB("informacion", "Registro Agregado");
                    DialogResult dR = mbox.ShowDialog();
                    this.Close();

                }
            }
        }
    }
}
