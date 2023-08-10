using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    internal class Bitacora
    {
        private int ID_BITACORA;
        private int ID_USUARIO;
        private int ID_OBJETO;
        private DateTime FECHA;
        private string ACCION;
        private string DESCRIPCION;
        private int Inicio;
        private int Final;


        public int ID_BITACORA1 { get => ID_BITACORA; set => ID_BITACORA = value; }
        public int ID_USUARIO1 { get => ID_USUARIO; set => ID_USUARIO = value; }
        public int ID_OBJETO1 { get => ID_OBJETO; set => ID_OBJETO = value; }
        public DateTime FECHA1 { get => FECHA; set => FECHA = value; }
        public string ACCION1 { get => ACCION; set => ACCION = value; }
        public string DESCRIPCION1 { get => DESCRIPCION; set => DESCRIPCION = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionBitacora()
        {

            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagBitacora", conn);
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
