using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class AdmonObjetos
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable MostrarObjetos()
        {
            DataTable mostrarObjetosDT = new DataTable();

            try
            {
                string sql = "SELECT ID_OBJETO AS ID, OBJETO AS NOMBRE, DESCRIPCION, ESTADO_OBJETO AS ESTADO, " +
                    "FECHA_CREACION AS CREACIÓN, FECHA_ACTUALIZACION AS ACTUALIZACIÓN FROM TBL_OBJETO;";


                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                mostrarObjetosDT.Load(reader);

            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error");
            }
            return mostrarObjetosDT;

        }

        public void modificarObjeto(int id, string nombreObj, string descObj, string estadoObj)
        {

            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("editarObjeto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idObjeto", id);
                cmd.Parameters.AddWithValue("@nombreObj", nombreObj);
                cmd.Parameters.AddWithValue("@descObj", descObj);
                cmd.Parameters.AddWithValue("@estadoObj", estadoObj);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        //public bool EditarObjeto(Objetos objeto)
        //{
        //    bool edito = false;

        //    try
        //    {
        //        string sql = "UPDATE TBL_OBJETO SET OBJETO = @OBJETO, DESCRIPCION = @DESCRIPCION, ESTADO_OBJETO = @ESTADO_OBJETO" +
        //             " WHERE OBJETO = @OBJETO;"; 

        //        conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
        //        conn.Open();

        //        cmd = new MySqlCommand(sql, conn); 

        //        cmd.Parameters.AddWithValue("@OBJETO", objeto.NOMBRE_OBJETO1); 
        //        cmd.Parameters.AddWithValue("@DESCRIPCION", objeto.DESCRIPCION1);
        //        cmd.Parameters.AddWithValue("@ESTADO_OBJETO", objeto.ESTADO_OBJETO1);

        //        cmd.ExecuteNonQuery();
        //        edito = true;
        //        conn.Close();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return edito;
        //}

        public bool EliminarObjeto(string idObjeto) 
        {
            bool elimino = false;

            try
            {
                string sql = "DELETE FROM TBL_OBJETO WHERE ID_OBJETO = @ID_OBJETO;"; 

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(sql, conn); 

                cmd.Parameters.AddWithValue("@ID_OBJETO", idObjeto); 

                cmd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return elimino;
        }
    }
}
