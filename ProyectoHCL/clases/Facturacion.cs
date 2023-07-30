using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    internal class Facturacion
    {

        private int NFACTURA;
        private int ID_SOLICITUDRESERVA;
        private int ID_TIPOPAGO;
        private int ID_USUARIO;
        private DateTime FECHA;
        private int N_OCEXCENTA;
        private int NCONSTANCIAEXONERADO;
        private int REGISTROSAR;
        private float SUBTOTAL;
        private float IMPOREXONERADO;
        private float IMPOREXCENTO;
        private float IMPORTEISV;
        private float IMPORTEALCOHOL;
        private float IMPORTETURISMO;
        private float IMPUESISV;
        private float IMPUESALCOHOL;
        private float IMPUESTURISMO;
        private float TOTAL;
        private int Inicio;
        private int Final;

        public int NFACTURA1 { get => NFACTURA; set => NFACTURA = value; }
        public int ID_SOLICITUDRESERVA1 { get => ID_SOLICITUDRESERVA; set => ID_SOLICITUDRESERVA = value; }
        public int ID_TIPOPAGO1 { get => ID_TIPOPAGO; set => ID_TIPOPAGO = value; }
        public int ID_USUARIO1 { get => ID_USUARIO; set => ID_USUARIO = value; }
        public DateTime FECHA1 { get => FECHA; set => FECHA = value; }
        public int N_OCEXCENTA1 { get => N_OCEXCENTA; set => N_OCEXCENTA = value; }
        public int NCONSTANCIAEXONERADO1 { get => NCONSTANCIAEXONERADO; set => NCONSTANCIAEXONERADO = value; }
        public int REGISTROSAR1 { get => REGISTROSAR; set => REGISTROSAR = value; }
        public float SUBTOTAL1 { get => SUBTOTAL; set => SUBTOTAL = value; }
        public float IMPOREXONERADO1 { get => IMPOREXONERADO; set => IMPOREXONERADO = value; }
        public float IMPOREXCENTO1 { get => IMPOREXCENTO; set => IMPOREXCENTO = value; }
        public float IMPORTEISV1 { get => IMPORTEISV; set => IMPORTEISV = value; }
        public float IMPORTEALCOHOL1 { get => IMPORTEALCOHOL; set => IMPORTEALCOHOL = value; }
        public float IMPORTETURISMO1 { get => IMPORTETURISMO; set => IMPORTETURISMO = value; }
        public float IMPUESISV1 { get => IMPUESISV; set => IMPUESISV = value; }
        public float IMPUESALCOHOL1 { get => IMPUESALCOHOL; set => IMPUESALCOHOL = value; }
        public float IMPUESTURISMO1 { get => IMPUESTURISMO; set => IMPUESTURISMO = value; }
        public float TOTAL1 { get => TOTAL; set => TOTAL = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionFacturas()
        {

            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagFacturas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inicio", Inicio1);
            cmd.Parameters.AddWithValue("@final", Final1);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            return dt;
        }

    }
}
