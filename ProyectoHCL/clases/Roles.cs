using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class Roles
    {
        public int ID_ROL;
        public string NOMBRE_ROL;
        public string DESCRIPCION;
        public string ESTADO_ROL;
        public DateTime FECHA_CREACION;
        public DateTime FECHA_ACTUALIZACION;
        private int Inicio;
        private int Final;

        public int ID_ROL1 { get => ID_ROL; set => ID_ROL = value; }

        public string NOMBRE_ROL1 { get => NOMBRE_ROL; set => NOMBRE_ROL = value; }

        public string ESTADO_ROL1 { get => ESTADO_ROL; set => ESTADO_ROL = value; }
        public string DESCRIPCION1 { get => DESCRIPCION; set => DESCRIPCION = value; }
        public DateTime FECHA_CREACION1 { get => FECHA_CREACION; set => FECHA_CREACION = value; }

        public DateTime FECHA_ACTUALIZACION1 { get => FECHA_ACTUALIZACION; set => FECHA_ACTUALIZACION= value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionRoles()
        {

            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagRoles", conn);
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
        
    