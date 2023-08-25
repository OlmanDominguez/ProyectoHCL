
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
        public void modificarRol(int id, string nombrerol, string descrol, string estado_rol)
        {

            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("EditarRoles", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_rol", id);
                cmd.Parameters.AddWithValue("@rol", nombrerol);
                cmd.Parameters.AddWithValue("@descripcion", descrol);
                cmd.Parameters.AddWithValue("@estado_Rol", estado_rol);
               
                //cmd.Parameters.AddWithValue("@fechacreacion",fecha_creacion);
                //cmd.Parameters.AddWithValue("@actualizar", fecha_actualizacion);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public bool EliminarRoles(string idrol) //Recibe un string (el id del Rol)
        {
            bool elimino = false;

            try
            {
                string sql = "DELETE FROM TBL_ROL WHERE ID_ROL = @ID_ROL;"; //sentencia sql para eliminar EL Rol 

                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand(sql, conn); //comando que recibe la sentencia sql y la conexion

                cmd.Parameters.AddWithValue("@ID_ROL", idrol); //obtener valor del parametro id del ROL 

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
