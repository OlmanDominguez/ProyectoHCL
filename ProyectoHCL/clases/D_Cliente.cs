using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProyectoHCL.clases
{
    internal class D_Cliente
    {
        public DataTable Listado_cl(string cTexto)
        {
            DataTable Tabla = new DataTable();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = BaseDatosHCL.ObtenerConexion();
            try
            {
                comando.CommandText = ("select  c.NOMBRE, c.APELLIDO, c.DNI_PASAPORTE, " + 
                    "t.descripcion, c.TELEFONO from TBL_CLIENTE c " + 
                    "inner join TBL_TIPOCLIENTE t on c.ID_TIPOCLIENTE = t.ID_TIPOCLIENTE " +
                    "where c.NOMBRE like '" + cTexto + "'" +
                    "order by c.NOMBRE");
                MySqlDataReader Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
                comando.Connection.Close();

            }
            catch (Exception ex)
            {

                throw;
            }
           
        }



    }
}
