using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Presentation;
using MySql.Data.MySqlClient;
using ProyectoHCL.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    internal class AdminReserva
    {
       
        MySqlConnection conn;
        MySqlCommand cmd;
        private int Inicio;
        private int Final;
        private int ID_SOLICITUDRESERVA;
        private DateTime FECHACOTI;
        private DateTime INGRESO;
        private DateTime SALIDA;
        private int NHUESPEDES;
        private string NOMBRE;
        private string ESTADO;
        private int NUMEROHABITACION;

        public int ID_SOLICITUDRESERVA1 { get => ID_SOLICITUDRESERVA; set => ID_SOLICITUDRESERVA = value; }
        public DateTime FECHACOTI1 { get => FECHACOTI; set => FECHACOTI = value; }
        public DateTime INGRESO1 { get => INGRESO; set => INGRESO = value; }
        public DateTime SALIDA1 { get => SALIDA; set => SALIDA = value; }
        public int NHUESPEDES1 { get => NHUESPEDES; set => NHUESPEDES = value; }
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public string ESTADO1 { get => ESTADO; set => ESTADO = value; }
        public int NUMEROHABITACION1 { get => NUMEROHABITACION; set => NUMEROHABITACION = value; }

        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public bool EliminarReserva(string idSolicitud) //Recibe un string (el id del usuario)
        {
            bool elimino = false;

            try
            {
                string sql = "DELETE FROM TBL_SOLICITUDRESERVA WHERE ID_SOLICITUDRESERVA = @ID_SOLICITUDRESERVA;"; //sentencia sql para eliminar el usuario

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(sql, conn); //comando que recibe la sentencia sql y la conexion

                cmd.Parameters.AddWithValue("@ID_SOLICITUDRESERVA", idSolicitud); //obtener valor del parametro id del usuario

                cmd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return elimino;
        }
        public void modificarReserva(int id_solicitud, int id_estado, int id_metodo, int id_usuaio, DateTime fecha_coti, DateTime fecha_ingreso,
            DateTime fecha_salida, int n_huespedes,int vehiculo, int monto, int cod_cliente, int num_habitacion)
        {

            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("UpdateReserva", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_solicitud", id_solicitud);
                cmd.Parameters.AddWithValue("@id_estado", id_estado);
                cmd.Parameters.AddWithValue("@id_metodo", id_metodo);
                cmd.Parameters.AddWithValue("@id_usuaio", id_usuaio);
                cmd.Parameters.AddWithValue("@fecha_coti", Convert.ToDateTime(fecha_coti));
                cmd.Parameters.AddWithValue("@fecha_ingreso", Convert.ToDateTime(fecha_ingreso));
                cmd.Parameters.AddWithValue("@fecha_salida", Convert.ToDateTime(fecha_salida));
                cmd.Parameters.AddWithValue("@n_huespedes", n_huespedes);
                cmd.Parameters.AddWithValue("@vehiculo", vehiculo);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.Parameters.AddWithValue("@cod_cliente", cod_cliente);
                cmd.Parameters.AddWithValue("@num_habitacion", num_habitacion);


                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public DataSet PaginacionReserva()
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagReservas", conn);
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
