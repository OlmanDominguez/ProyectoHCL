using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class TipoHabitacion
    {
        private int ID_TIPOHABITACION;
        private string TIPO;
        private int CAPACIDAD;
        private Decimal PRECIO;
        private int Inicio;
        private int Final;

        public int ID_TIPOHABITACION1 { get => ID_TIPOHABITACION; set => ID_TIPOHABITACION = value; }
        public string TIPO1 { get => TIPO; set => TIPO = value; }
        public int CAPACIDAD1 { get => CAPACIDAD; set => CAPACIDAD = value; }
        public decimal PRECIO1 { get => PRECIO; set => PRECIO = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionTipoHab()
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagTipHab", conn);
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
