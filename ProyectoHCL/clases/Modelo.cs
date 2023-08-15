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
    public class Modelo
    {

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


        public bool existeObjeto(string objeto)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_OBJETO FROM TBL_OBJETO WHERE OBJETO LIKE @OBJETO";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@OBJETO", objeto);
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

        public bool existeTipHab(string tipo)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_TIPOHABITACION FROM TBL_TIPOHABITACION WHERE TIPO LIKE @TIPO";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@TIPO", tipo);
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

        public bool existeHabitacion(string hab)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_HABITACION FROM TBL_HABITACION WHERE NUMEROHABITACION LIKE @NUMEROHABITACION";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@NUMEROHABITACION", hab);
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

        public bool existeServicio(string desc)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_SERVICIO FROM TBL_SERVICIO WHERE DESCRIPCION LIKE @DESCRIPCION";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@DESCRIPCION", desc);
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

        public bool existeDescuento(string descuento)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_DESCUENTO FROM TBL_DESCUENTO WHERE DESCRIPCION LIKE @DESCRIPCION";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@DESCRIPCION", descuento);
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

        public bool existeCliente(string identi)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT CODIGO FROM TBL_CLIENTE WHERE DNI_PASAPORTE LIKE @ID";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@ID", identi);
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

        public bool existePermiso(string rol)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_ROL FROM TBL_PERMISO_ROL WHERE ID_ROL LIKE @ID_ROL"; //INNER JOIN
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@ID_ROL", rol);
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




        public bool existeParametro(string rol)
        {


            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_ROL FROM TBL_ROL WHERE ID_ROL LIKE @ID_ROL";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@ID_ROL", rol);
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
