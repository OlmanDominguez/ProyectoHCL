﻿using DocumentFormat.OpenXml.Office.Word;
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

        public bool existePRC(string preguntarc) //función para validar si existe la recuperacion por pregunta
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_PREGUNTA FROM TBL_PREGUNTAUSUARIO WHERE RESPUESTA LIKE @RESPUESTA";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@RESPUESTA", preguntarc);
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

        public bool existePregunta(string pregunta) //función para validar si existe la pregunta
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_PREGUNTA FROM TBL_PREGUNTA WHERE PREGUNTA LIKE @PREGUNTA";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@PREGUNTA", pregunta);
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

        public bool existeditarPBD(string parametro) //función para validar si existe al editar parametro.
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

        /*public string ObtenerParametro(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT PARAMETRO FROM TBL_PARAMETRO WHERE ID_PARAMETRO = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }*/
       /* public bool ParametroEditarBD(string nuevoParametro, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoParametro == ObtenerParametro(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_PARAMETRO WHERE PARAMETRO = @NuevoParametro", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoParametro", nuevoParametro);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }*/

        public string ObtenerValor(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT VALOR FROM TBL_PARAMETRO WHERE ID_PARAMETRO = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }
        public bool ValorEditarBD(string nuevoValor, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoValor == ObtenerValor(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_PARAMETRO WHERE VALOR = @NuevoValor", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoValor", nuevoValor);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        public bool existeContraseña(string contraseña) //función para validar si existe el contraseña
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_USUARIO FROM TBL_USUARIO WHERE CONTRASENA LIKE @CONTRASENA";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@CONTRASENA", contraseña);
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
        public bool existeditarRol(string rol) //función para validar si existe el rol
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_ROL FROM TBL_ROL WHERE ROL LIKE @ROL";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@ROL", rol);
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
        public bool existeditarDR(string descripcion) //función para validar si existe el rol en editar 
        {
            MySqlDataReader reader;
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            String sql = "SELECT ID_ROL FROM TBL_ROL WHERE DESCRIPCION LIKE @DESCRIPCION";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@DESCRIPCION", descripcion);
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

        public string ObtenerRol(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT ROL FROM TBL_ROL WHERE ID_ROL = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerDescripcion(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT DESCRIPCION FROM TBL_ROL WHERE ID_ROL = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerPregunta(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT PREGUNTA FROM TBL_PREGUNTA WHERE ID_PREGUNTA = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public bool PreguntaEditarBD(string nuevaPregunta, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevaPregunta == ObtenerPregunta(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_PREGUNTA WHERE PREGUNTA = @NuevaPregunta", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevaPregunta", nuevaPregunta);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool RolEditarBD(string nuevoRol, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoRol == ObtenerRol(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_ROL WHERE ROL = @NuevoRol", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoRol", nuevoRol);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool DescripcionEditarBD(string nuevoDescripcion, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoDescripcion == ObtenerDescripcion(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_ROL WHERE DESCRIPCION = @NuevoDescripcion", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoDescripcion", nuevoDescripcion);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
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
        public string ObtenerNombreCliente(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT NOMBRE FROM TBL_CLIENTE WHERE CODIGO = @IDActual", conectar))
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

        public string ObtenerServicio(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT DESCRIPCION FROM TBL_SERVICIO WHERE ID_SERVICIO = @IDActual", conectar))
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

        public string ObtenerTipoHabitacion(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT TIPO FROM TBL_TIPOHABITACION WHERE ID_TIPOHABITACION = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerDNI(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT DNI_PASAPORTE FROM TBL_CLIENTE WHERE CODIGO = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerEmail(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

           using (conectar)
           {
                using (MySqlCommand cmd = new MySqlCommand("SELECT EMAIL FROM TBL_CLIENTE WHERE CODIGO= @IDActual", conectar))
                {
                  cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                   return cmd.ExecuteScalar().ToString();
               }
           }
        }

        public string ObtenerEmail1(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT EMAIL2 FROM TBL_CLIENTE WHERE CODIGO= @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerObjeto(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT DESCRIPCION FROM TBL_OBJETO WHERE ID_OBJETO = @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerTelefono(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT TELEFONO FROM TBL_CLIENTE WHERE CODIGO= @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerParametro(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT PARAMETRO FROM TBL_PARAMETRO WHERE ID_PARAMETRO= @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@IDActual", idRegistro);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public string ObtenerTelefono1(string idRegistro)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT TELEFONO2 FROM TBL_CLIENTE WHERE CODIGO= @IDActual", conectar))
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

       public bool NombreClienteEditarBD(string nuevoNombre1, string idRegistroActual)
       {
          MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

           using (conectar)
           {
               if (nuevoNombre1 == ObtenerNombreCliente(idRegistroActual))
               {
                   return false;
               }

               using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_CLIENTE WHERE NOMBRE = @NuevoNombre1", conectar))
               {
                   cmd.Parameters.AddWithValue("@NuevoNombre1", nuevoNombre1);

                   int count = Convert.ToInt32(cmd.ExecuteScalar());

                   return count > 0;
                }
            }
        }

        public bool DNIEditarBD(string nuevoDNI, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoDNI == ObtenerDNI(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_CLIENTE WHERE DNI_PASAPORTE = @NuevoDNI", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoDNI", nuevoDNI);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool TelefonoEditarBD(string nuevoTelefono, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoTelefono == ObtenerTelefono(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_CLIENTE WHERE TELEFONO = @NuevoTelefono", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoTelefono", nuevoTelefono);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool TelefonoDosEditarBD(string nuevoTelefono1, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoTelefono1 == ObtenerTelefono1(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_CLIENTE WHERE TELEFONO2 = @NuevoTelefono", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoTelefono1", nuevoTelefono1);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool Email1EditarBD(string nuevoEmail1, string idRegistroActual) //Función para Editar Email1
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoEmail1 == ObtenerUsuario(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_USUARIO WHERE USUARIO = @NuevoNombre", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoEmail1", nuevoEmail1);

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

       public bool EmailEditarBD(string nuevoEmail, string idRegistroActual) //Funcion para Editar Email
        {
           MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

           if (nuevoEmail == ObtenerEmail(idRegistroActual))
           {
                return false;
            }
            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_CLIENTE WHERE EMAIL = @NuevoEmail AND CODIGO != @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoEmail", nuevoEmail);
                    cmd.Parameters.AddWithValue("@IDActual", idRegistroActual);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool EmailDosEditarBD(string nuevoEmail1, string idRegistroActual) //Funcion para Editar Email
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            if (nuevoEmail1 == ObtenerEmail1(idRegistroActual))
            {
                return false;
            }
            using (conectar)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_CLIENTE WHERE EMAIL2 = @NuevoEmail1 AND CODIGO != @IDActual", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoEmail1", nuevoEmail1);
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

        public bool TipoHabEditarBD(string nuevoTipo, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoTipo == ObtenerTipoHabitacion(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_TIPOHABITACION WHERE TIPO = @NuevoTipo", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoTipo", nuevoTipo);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

      //  public bool ClienteEditarBD(string nuevoCliente, string idRegistroActual)
       // {
           // MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

           // using (conectar)
            //{
               // if (nuevoCliente == ObtenerCliente(idRegistroActual))
               // {
                   // return false;
               // }

               // using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_CLIENTE WHERE DNI_PASAPORTE = @NuevoCliente", conectar))
               // {
                    //cmd.Parameters.AddWithValue("@NuevoCliente", nuevoCliente);

                   // int count = Convert.ToInt32(cmd.ExecuteScalar());

                    //return count > 0;
               // }
          //  }
       // }

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

        public bool ServicioEditarBD(string nuevoNombre, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoNombre == ObtenerServicio(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_SERVICIO WHERE DESCRIPCION = @NuevoNombre", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        //public bool ObjetoEditarBD(string nuevoNombre, string idRegistroActual)
        //{
        //    MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

        //    using (conectar)
        //    {
        //        if (nuevoNombre == ObtenerObjeto(idRegistroActual))
        //        {
        //            return false;
        //        }

        //        using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_OBJETO WHERE OBJETO = @NuevoNombre", conectar))
        //        {
        //            cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);

        //            int count = Convert.ToInt32(cmd.ExecuteScalar());

        //            return count > 0;
        //        }
        //    }
        //}

        public bool ParametroEditarBD(string nuevoNombre, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoNombre == ObtenerParametro(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_PARAMETRO WHERE PARAMETRO = @NuevoNombre", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool ObjetoEditarBD(string nuevoObjeto, string idRegistroActual)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                if (nuevoObjeto == ObtenerObjeto(idRegistroActual))
                {
                    return false;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM TBL_OBJETO WHERE OBJETO = @NuevoObjeto", conectar))
                {
                    cmd.Parameters.AddWithValue("@NuevoObjeto", nuevoObjeto);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }
    }
}
