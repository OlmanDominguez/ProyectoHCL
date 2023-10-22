using DocumentFormat.OpenXml.Office.Word;
using MySql.Data.MySqlClient;
using ProyectoHCL.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------------------------------------------------------
//    Universidad Nacional Autonoma de Honduras (UNAH)
//		Facultad de Ciencias Economicas
//	Departamento de Informatica administrativa
//         Analisis, Programacion y Evaluacion de Sistemas
//                    Tercer Periodo 2023


//Equipo:
//GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

//HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

//NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

//JOEL ENRIQUE GODOY BONILLA---------(joel.bonilla@unah.hn)

//OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

//Catedratico analisis y diseño:             Lic.Giancarlo Martini Scalici Aguilar 
//catedratico programacion e implementacion: Lic.Karla Melisa Garcia Pineda 
//catedratico evaluacion de sistemas:        Lic.Karla Melisa Garcia Pineda 


//---------------------------------------------------------------------

//Programa:         Clase modelo
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván, Olman Domínguez, Andrés Osorto
//descripcion:      Clase con las funciones para validar la existencia de un registro

//-----------------------------------------------------------------------

//                Historial de Cambio

//-----------------------------------------------------------------------

//Programador               Fecha                      Descripcion
//GABRIELA  MANCIA  

//HILDEGARD  MONTALVAN   

//NELSON SALGADO  

//JOEL  GODOY 

//OLMAN  DOMÍNGUEZ 

//-----------------------------------------------------------------------

namespace ProyectoHCL.clases
{
    public class Modelo
    {

        public bool existeUsuario(string usuario) //función para validar si existe el usuario
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


        public bool existeObjeto(string objeto) //función para validar si existe el objeto
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

        public bool existeTipHab(string tipo) //función para validar si existe el tipo de habitación
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

        public bool existeHabitacion(string hab) //función para validar si existe la habitación
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

        public bool existeServicio(string desc) //función para validar si existe el servicio
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

        public bool existeDescuento(string descuento) //función para validar si existe el descuento
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

        public bool existeCliente(string identi) //función para validar si existe el cliente
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

        public bool existePermiso(int rol) //función para validar si existe el permiso
        {
            MySqlCommand cmd;
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            cmd = new MySqlCommand("existePermiso", conectar);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idRol", rol);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public bool existeParametro(string parametro) //función para validar si existe el parámetro
        {


            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_PARAMETRO FROM TBL_PARAMETRO WHERE PARAMETRO LIKE @PARAMETRO";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@PARAMETRO", parametro);
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

        public bool existeRol(string tipo) //función para validar si existe el rol
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_ROL FROM TBL_ROL WHERE ROL LIKE @ROL";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@ROL", tipo);
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
