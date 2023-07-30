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
    public class Clientes
    {
        private int ID_TIPOCLIENTE;
        private string NOMBRE;
        private string APELLIDO;
        private string NOMBRE_RTN;
        private string RTN;
        private string TELEFONO;
        private string EMAIL;
        private string DNI_PASAPORTE;
        private int CODIGO;
        private int Inicio;
        private int Final;

        public int ID_TIPOCLIENTE1 { get => ID_TIPOCLIENTE; set => ID_TIPOCLIENTE = value; }
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public string APELLIDO1 { get => APELLIDO; set => APELLIDO = value; }
        public string NOMBRE_RTN1 { get => NOMBRE_RTN; set => NOMBRE_RTN = value; }
        public string RTN1 { get => RTN; set => RTN = value; }
        public string TELEFONO1 { get => TELEFONO; set => TELEFONO = value; }
        public string EMAIL1 { get => EMAIL; set => EMAIL = value; }
        public string DNI_PASAPORTE1 { get => DNI_PASAPORTE; set => DNI_PASAPORTE = value; }
        public int CODIGO1 { get => CODIGO; set => CODIGO = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionClientes()
        {

            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagClientes", conn);
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
