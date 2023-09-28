using MySql.Data.MySqlClient;
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

//Programa:         Clase servicios
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Clase con la función para paginar los servicios

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
    public class Servicio
    {
        private int ID_SERVICIO;
        private string DESCRIPCION;
        private decimal PRECIO;
        private int Inicio;
        private int Final;

        public int ID_SERVICIO1 { get => ID_SERVICIO; set => ID_SERVICIO = value; }
        public string DESCRIPCION1 { get => DESCRIPCION; set => DESCRIPCION = value; }
        public decimal PRECIO1 { get => PRECIO; set => PRECIO = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionServicio()
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagServicios", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inicio", Inicio1);
            cmd.Parameters.AddWithValue("@final", Final1);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            return dt;
        }
    }
}
