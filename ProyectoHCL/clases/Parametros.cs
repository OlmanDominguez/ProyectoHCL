using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class Parametros
    {
        private int IDP;
        private string NOMBRE_PARAMETRO;
        private string VALOR;
        private DateTime FECHA_CREACION;
        private DateTime FECHA_ACTUALIZACION;
        private int Inicio;
        private int Final;


        public int IDP1 { get => IDP; set => IDP = value; }
        public string NOMBRE_PARAMETRO1 { get => NOMBRE_PARAMETRO; set => NOMBRE_PARAMETRO = value; }
        public string VALOR1 { get => VALOR; set => VALOR = value; }
        public DateTime FECHA_CREACION1 { get => FECHA_CREACION; set => FECHA_CREACION = value; }
        public DateTime FECHA_ACTUALIZACION1 { get => FECHA_ACTUALIZACION; set => FECHA_ACTUALIZACION = value; }

        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }
        public DataSet PaginacionParametro()
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagParametros", conn);
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
