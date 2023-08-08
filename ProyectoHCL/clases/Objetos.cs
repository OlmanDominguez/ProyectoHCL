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
    public class Objetos
    {
        private int ID_OBJETO;
        private string NOMBRE_OBJETO;
        private string DESCRIPCION;
        private int ACTUALIZADO_POR;
        private int CREADO_POR;
        private DateTime F_CREACION;
        private DateTime F_ACTUALIZACION;
        private string ESTADO_OBJETO;
        private int Inicio;
        private int Final;

        public int ID_OBJETO1 { get => ID_OBJETO; set => ID_OBJETO = value; }
        public string NOMBRE_OBJETO1 { get => NOMBRE_OBJETO; set => NOMBRE_OBJETO = value; }
        public string DESCRIPCION1 { get => DESCRIPCION; set => DESCRIPCION = value; }
        public int ACTUALIZADO_POR1 { get => ACTUALIZADO_POR; set => ACTUALIZADO_POR = value; }
        public int CREADO_POR1 { get => CREADO_POR; set => CREADO_POR = value; }
        public DateTime F_CREACION1 { get => F_CREACION; set => F_CREACION = value; }
        public DateTime F_ACTUALIZACION1 { get => F_ACTUALIZACION; set => F_ACTUALIZACION = value; }
        public string ESTADO_OBJETO1 { get => ESTADO_OBJETO; set => ESTADO_OBJETO = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionObjetos()
        {

            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagObjetos", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inicio", Inicio1);
            cmd.Parameters.AddWithValue("@final", Final1);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            return dt;
        }

      /*  public DataSet PaginacionObjetos2()
        {

            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagObjetos2", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inicio", Inicio1);
            cmd.Parameters.AddWithValue("@final", Final1);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            return dt;
        }*/
    }
}
