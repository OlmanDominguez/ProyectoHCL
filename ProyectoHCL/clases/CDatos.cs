using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProyectoHCL.RolesPermisos;
using System.Windows.Forms;
using System.Data;

namespace ProyectoHCL.clases
{
     class CDatos
    {
       public int GuardarRol(RolUsuario rolUsuario)
       {
			try
			{
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                int ultimoRegistro = 0;
                cmd = new MySqlCommand("spInsertRol", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter IdRol = new MySqlParameter("@IdRol", MySqlDbType.Int32);
                IdRol.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(IdRol);

                cmd.Parameters.Add(new MySqlParameter("@rol", rolUsuario.Rol));
                cmd.ExecuteNonQuery();

                if (IdRol.Value != DBNull.Value)
                {
                    ultimoRegistro = Convert.ToInt32(IdRol.Value);
                }

                return ultimoRegistro;
            }
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
                return 0;
			}
        }

       public void GuardarPermiso(PermisoRol permisoR)
        {
            try
            {
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
                conn.Open();

                cmd = new MySqlCommand("spInsertPermiso", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("@idRol", permisoR.IdRol));
                cmd.Parameters.Add(new MySqlParameter("@idPermiso", permisoR.IdPermiso));
                cmd.Parameters.Add(new MySqlParameter("@idObjeto", permisoR.IdObjeto));
                cmd.Parameters.Add(new MySqlParameter("@permitido", permisoR.Permitido));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
