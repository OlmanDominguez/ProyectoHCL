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
        public bool existeUsuario(string usuario)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            using (conectar)
            {
                string consultaUsuario = "SELECT COUNT(*) FROM TBL_USUARIO WHERE USUARIO = @usuario";
                using (MySqlCommand cmdUsuario = new MySqlCommand(consultaUsuario, conectar))
                {
                    cmdUsuario.Parameters.AddWithValue("@usuario", usuario);
                    int countUsuario = Convert.ToInt32(cmdUsuario.ExecuteScalar());
                    if (countUsuario > 0)
                    {
                        // El usuario ya está en uso
                        return true;
                    }
                }

                return false; 
            }
        }

        public bool existeNombre(string nombreUsuario) //función para validar si existe el usuario
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            // Verificar si el nombre de usuario ya existe
            string consultaNombre = "SELECT COUNT(*) FROM TBL_USUARIO WHERE NOMBRE_USUARIO = @nombreUsuario";
            using (MySqlCommand cmdNombre = new MySqlCommand(consultaNombre, conectar))
            {
                cmdNombre.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                int countNombre = Convert.ToInt32(cmdNombre.ExecuteScalar());
                if (countNombre > 0)
                {
                    // El nombre de usuario ya está en uso
                    return true;
                }
            }

            return false;
        }

        public bool existeCorreo(string correo) //función para validar si existe el usuario
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
            // Verificar si el correo electrónico ya existe
            string consultaCorreo = "SELECT COUNT(*) FROM TBL_USUARIO WHERE EMAIL = @correo";
            using (MySqlCommand cmdCorreo = new MySqlCommand(consultaCorreo, conectar))
            {
                cmdCorreo.Parameters.AddWithValue("@correo", correo);
                int countCorreo = Convert.ToInt32(cmdCorreo.ExecuteScalar());
                if (countCorreo > 0)
                {
                    // El correo electrónico ya está en uso
                    return true;
                }
            }

            return false;
        }

        public bool existeEmail(string correo) //función para validar si existe el correo en pantalla cliente
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
            // Verificar si el correo electrónico ya existe
            string consultaCorreo = "SELECT COUNT(*) FROM TBL_CLIENTE WHERE EMAIL = @correo";
            using (MySqlCommand cmdCorreo = new MySqlCommand(consultaCorreo, conectar))
            {
                cmdCorreo.Parameters.AddWithValue("@correo", correo);
                int countCorreo = Convert.ToInt32(cmdCorreo.ExecuteScalar());
                if (countCorreo > 0)
                {
                    // El correo electrónico ya está en uso
                    return true;
                }
            }

            return false;
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

        public string ObtenerUsuario(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT USUARIO FROM TBL_USUARIO WHERE ID_USUARIO = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerNombreUsuario(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT NOMBRE_USUARIO FROM TBL_USUARIO WHERE ID_USUARIO = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerCorreo(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT EMAIL FROM TBL_USUARIO WHERE ID_USUARIO = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerDescuento(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT DESCRIPCION FROM TBL_DESCUENTO WHERE ID_DESCUENTO = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerNumHabitacion(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT NUMEROHABITACION FROM TBL_HABITACION WHERE ID_HABITACION = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public bool UsuarioEditarBD(string nuevoNombre, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoNombre == ObtenerUsuario(idRegistroActual))
                {
                    return false; 
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_USUARIO WHERE USUARIO = @NuevoNombre", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool NombreUsEditarBD(string nuevoNombre, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoNombre == ObtenerNombreUsuario(idRegistroActual))
                {
                    return false;
                }
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_USUARIO WHERE NOMBRE_USUARIO = @NuevoNombre AND ID_USUARIO != @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                    cmd.Parameters.AddWithValue("@IDActual", idRegistroActual);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool CorreoEditarBD(string nuevoCorreo, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (nuevoCorreo == ObtenerCorreo(idRegistroActual))
            {
                return false;
            }
            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_USUARIO WHERE EMAIL = @NuevoCorreo AND ID_USUARIO != @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoCorreo", nuevoCorreo);
                    cmd.Parameters.AddWithValue("@IDActual", idRegistroActual);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool DescuentoEditarBD(string nuevoNombre, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoNombre == ObtenerDescuento(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_DESCUENTO WHERE DESCRIPCION = @NuevoNombre", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool HabitacionEditarBD(string nuevoNumero, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoNumero == ObtenerNumHabitacion(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_HABITACION WHERE NUMEROHABITACION = @NuevoNumero", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoNumero", nuevoNumero);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

    }
}
