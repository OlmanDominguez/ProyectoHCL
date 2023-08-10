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
