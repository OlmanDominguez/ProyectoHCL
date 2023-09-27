/* -----------------------------------------------------------------------
    Universidad Nacional Autonoma de Honduras (UNAH)
		Facultad de Ciencias Economicas
	Departamento de Informatica administrativa
         Analisis, Programacion y Evaluacion de Sistemas
                    Tercer Periodo 2013


Equipo:
GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

JOEL ENRIQUE GODOY BONILLA---------(joel.godoy@unah.hn)

OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

Catedratico analisis y diseño:             Lic.Giancarlo Martini Scalici Aguilar 
catedratico programacion e implementacion: Lic.Karla Melisa Garcia Pineda 
catedratico evaluacion de sistemas:        Lic.Karla Melisa Garcia Pineda 


---------------------------------------------------------------------

Programa:         Pantalla de Ingreso de Facturacion
Fecha:             26 - septiembre - 2023
Programador: Joel
descripcion:       Pantalla que contrala las validaciones de Facturacion

-----------------------------------------------------------------------

                Historial de Cambio

-----------------------------------------------------------------------

Programador               Fecha                      Descripcion
GABRIELA  MANCIA  

HILDEGARD  MONTALVAN   

NELSON SALGADO  

JOEL  GODOY 

OLMAN  DOMÍNGUEZ 

----------------------------------------------------------------------- */

/* librerias utilizadas para facilitar el proceso */
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Wordprocessing; 
using MySql.Data.MySqlClient; /* libreria para conectar a la BD */
using System; /* directiva para identificar los bloques de codigo */
using System.Collections.Generic; /* libreria para lectura*/
using System.Data; /* Conexion a la BD*/
using System.Linq; /* libreria para clases e interfaces */
using System.Numerics; 
using System.Text; /* manipular informacion dentro de la aplicacion */
using System.Threading.Tasks; /* libreria para impresion */

namespace ProyectoHCL.clases
{
    internal class Facturacion /* clase facturacion */
    {

        private int NFACTURA;                    /* declaracion de variables */
        private int ID_SOLICITUDRESERVA;
        private int ID_TIPOPAGO;
        private int ID_USUARIO;
        private DateTime FECHA;
        private int N_OCEXCENTA;
        private int NCONSTANCIAEXONERADO;
        private int REGISTROSAR;
        private float SUBTOTAL;
        private float IMPOREXONERADO;
        private float IMPOREXCENTO;
        private float IMPORTEISV;
        private float IMPORTEALCOHOL;
        private float IMPORTETURISMO;
        private float IMPUESISV;
        private float IMPUESALCOHOL;
        private float IMPUESTURISMO;
        private float TOTAL;
        private int Inicio;
        private int Final;

        public int NFACTURA1 { get => NFACTURA; set => NFACTURA = value; }   /* obtencion y colocacion de valores */ 
        public int ID_SOLICITUDRESERVA1 { get => ID_SOLICITUDRESERVA; set => ID_SOLICITUDRESERVA = value; }
        public int ID_TIPOPAGO1 { get => ID_TIPOPAGO; set => ID_TIPOPAGO = value; }
        public int ID_USUARIO1 { get => ID_USUARIO; set => ID_USUARIO = value; }
        public DateTime FECHA1 { get => FECHA; set => FECHA = value; }
        public int N_OCEXCENTA1 { get => N_OCEXCENTA; set => N_OCEXCENTA = value; }
        public int NCONSTANCIAEXONERADO1 { get => NCONSTANCIAEXONERADO; set => NCONSTANCIAEXONERADO = value; }
        public int REGISTROSAR1 { get => REGISTROSAR; set => REGISTROSAR = value; }
        public float SUBTOTAL1 { get => SUBTOTAL; set => SUBTOTAL = value; }
        public float IMPOREXONERADO1 { get => IMPOREXONERADO; set => IMPOREXONERADO = value; }
        public float IMPOREXCENTO1 { get => IMPOREXCENTO; set => IMPOREXCENTO = value; }
        public float IMPORTEISV1 { get => IMPORTEISV; set => IMPORTEISV = value; }
        public float IMPORTEALCOHOL1 { get => IMPORTEALCOHOL; set => IMPORTEALCOHOL = value; }
        public float IMPORTETURISMO1 { get => IMPORTETURISMO; set => IMPORTETURISMO = value; }
        public float IMPUESISV1 { get => IMPUESISV; set => IMPUESISV = value; }
        public float IMPUESALCOHOL1 { get => IMPUESALCOHOL; set => IMPUESALCOHOL = value; }
        public float IMPUESTURISMO1 { get => IMPUESTURISMO; set => IMPUESTURISMO = value; }
        public float TOTAL1 { get => TOTAL; set => TOTAL = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionFacturas()
        {

            MySqlConnection conn;  /* declaracion de variable para conectar con BD */
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;"); /* proceso para conectar con BD */
            conn.Open();

            cmd = new MySqlCommand("PagFacturas", conn);
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
