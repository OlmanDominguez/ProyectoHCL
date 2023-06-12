using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class Modelo
    {
        public int registro(Usuarios usuario)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            string sql = "INSERT INTO TBL_USUARIO(ID_ESTADO, ID_ROL, USUARIO, NOMBRE_USUARIO, CONTRASENA, PRIMERINGRESO," +
                "FECHAVENCIMIENTO, EMAIL) VALUES(@ID_ESTADO, @ID_ROL, @USUARIO, @NOMBRE_USUARIO, @CONTRASENA," +
                "@PRIMERINGRESO, @FECHAVENCIMIENTO, @EMAIL )";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@ID_ESTADO", usuario.ESTADO_USUARIO1);
            comando.Parameters.AddWithValue("@ID_ROL", usuario.ROL_USUARIO1);
            comando.Parameters.AddWithValue("@USUARIO", usuario.USUARIO1);
            comando.Parameters.AddWithValue("@NOMBRE_USUARIO", usuario.NOMBRE1);
            comando.Parameters.AddWithValue("@CONTRASENA", usuario.CONTRASEÑA1);
            comando.Parameters.AddWithValue("@PRIMERINGRESO", usuario.FECHA_CREACION1);
            comando.Parameters.AddWithValue("@FECHAVENCIMIENTO", usuario.FECHA_VENCIMIENTO1);
            comando.Parameters.AddWithValue("@EMAIL", usuario.EMAIL1);

            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_USUARIO FROM TBL_USUARIO WHERE USUARIO LIKE @USUARIO";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@USUARIO", usuario);
            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                return true;

            }
            else
            {
                return false;
            }

        }
    }
}
