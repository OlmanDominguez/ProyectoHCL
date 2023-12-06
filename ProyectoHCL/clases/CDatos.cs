using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProyectoHCL.RolesPermisos;
using System.Windows.Forms;
using System.Data;
using ProyectoHCL.Formularios;

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

//Programa:         Clase datos de permisos
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Clase con las funciones para listar los objetos, guardar permisos, actualizar permisos y devolver una lista de objetos con permisos

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
     class CDatos
     {
        public static string usuario;
        public static string nombre;
        public static string correo;
        public static string contraseña;
        public static string cliente;
        public static string nombreCliente;
        public static string apellidoCliente;
        public static DateTime entrada;
        public static DateTime salida;
        public static string numHabDR;
        public static decimal descuento = 0;

        public static int idUsu; //Almacenar id Usuario
        public static int idRolUs; //ALmacenar id Rol
        public static int numeroHab;


        public DataTable listarObjetos()
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();
            MySqlCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT ID_OBJETO AS ID, OBJETO AS PANTALLA FROM TBL_OBJETO;";
                cmd = new MySqlCommand(sql, conectar);

                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MsgB m = new MsgB("error", "Error: " + ex.Message);
                DialogResult dR = m.ShowDialog();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                {
                    conectar.Close();
                }
            }

            return dt;
        }

        public void GuardarPermiso(PermisoRol permisoR)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();
            using (conectar)
            using (MySqlCommand cmd = new MySqlCommand("spInsertPermiso", conectar))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idRol", permisoR.IdRol);
                    cmd.Parameters.AddWithValue("@idPermiso", permisoR.IdPermiso);
                    cmd.Parameters.AddWithValue("@idObjeto", permisoR.IdObjeto);
                    cmd.Parameters.AddWithValue("@permitido", permisoR.Permitido);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MsgB m = new MsgB("error", "Error: " + ex.Message);
                    DialogResult dR = m.ShowDialog();
                }
                finally
                {
                    if (conectar.State == ConnectionState.Open)
                    {
                        conectar.Close();
                    }
                }
            }
        }

        public List<PermisoRol> SelectObjeto(int idR)
        {
            List<PermisoRol> objetos = new List<PermisoRol>();

            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();

            using (conectar)
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("spSelectObjeto", conectar))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idRol", idR);

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            objetos = (from row in dt.AsEnumerable()
                                       select new PermisoRol()
                                       {
                                           IdPermiso = Convert.IsDBNull(row["ID_PERMISO"]) ? 0 : Convert.ToInt32(row["ID_PERMISO"]),
                                           IdRol = row["ROL"].ToString(),
                                           ObjetoN = row["OBJETO"].ToString(),
                                           Permitido = Convert.ToBoolean(row["PERMITIDO"])
                                       }).ToList();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MsgB m = new MsgB("error", "Error: " + ex.Message);
                    DialogResult dR = m.ShowDialog();
                }
                finally
                {
                    if (conectar.State == ConnectionState.Open)
                    {
                        conectar.Close();
                    }
                }

                return objetos;
            }
        }

        public void ActualizarPermiso(PermisoRol permisoR)
        {
            MySqlConnection conectar = BaseDatosHCL.ObtenerConexion();
            using (conectar)
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("EditarPermisos", conectar))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idRol", permisoR.IdRol);
                        cmd.Parameters.AddWithValue("@idPermiso", permisoR.IdPermiso);
                        cmd.Parameters.AddWithValue("@idObjeto", permisoR.IdObjeto);
                        cmd.Parameters.AddWithValue("@permitido", permisoR.Permitido);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MsgB m = new MsgB("error", "Error: " + ex.Message);
                    DialogResult dR = m.ShowDialog();
                }
                finally
                {
                    if (conectar.State == ConnectionState.Open)
                    {
                        conectar.Close();
                    }
                }
            }
        }
    }
}
