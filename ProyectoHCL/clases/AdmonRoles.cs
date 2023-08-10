
using MySql.Data.MySqlClient;
using ProyectoHCL.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoHCL.clases;

namespace ProyectoHCL.clases
{
    public  class AdmonRoles
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        public DataTable RellenarGrid()
        {
            DataTable rellenarGridDT = new DataTable();

            try
            {
                string sql = " SELECT ID_ROL, ROL, ESTADO_ROL, FECHA_CREACION, FECHA_ACTUALIZACION FROM  TBL_ROL ";
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("listaRoles", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataReader reader = cmd.ExecuteReader();
                rellenarGridDT.Load(reader);

            }
            catch (Exception)
            {
                MessageBox.Show("No hay registro");
            }
            return rellenarGridDT;

        }
        public void modificarRol(int id, string rol, string pantalla, string estado_rol,
           DateTime primerIngreso, DateTime actualizar)
        {

            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("EditarRoles", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_rol", id);
                cmd.Parameters.AddWithValue("@Rol", rol);
                cmd.Parameters.AddWithValue("@estado_Rol", estado_rol);
                cmd.Parameters.AddWithValue("@pantalla", pantalla);
                cmd.Parameters.AddWithValue("@primerIngreso", primerIngreso);
                cmd.Parameters.AddWithValue("@actualizar", actualizar);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public bool EliminarRoles(string id) //Recibe un string (el id del Rol)
        {
            bool elimino = false;

            try
            {
                string sql = "DELETE FROM TBL_ROL WHERE ID_ROL = @ID_ROL;"; //sentencia sql para eliminar EL Rol 

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(sql, conn); //comando que recibe la sentencia sql y la conexion

                cmd.Parameters.AddWithValue("@Id", id); //obtener valor del parametro id del ROL 

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
    }
}
