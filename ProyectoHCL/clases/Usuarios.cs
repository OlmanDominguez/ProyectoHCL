﻿using MySql.Data.MySqlClient;
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

//Programa:         Clase usuarios
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Clase con la función para paginar los usuarios

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
    public class Usuarios
    {
        private int ID_USUARIO;
        private string USUARIO;
        private string NOMBRE_USUARIO;
        private string CONTRASEÑA;
        private string ROL_USUARIO;
        private string EMAIL;
        private DateTime FECHA_CREACION;
        private DateTime FECHA_VENCIMIENTO;
        private string ESTADO_USUARIO;
        private DateTime FECHA_ULT_CONEX;
        private int PREGUNTAS_CONTESTADAS;
        private int Inicio;
        private int Final;


        public int ID_USUARIO1 { get => ID_USUARIO; set => ID_USUARIO = value; }
        public string USUARIO1 { get => USUARIO; set => USUARIO = value; }
        public string NOMBRE1 { get => NOMBRE_USUARIO; set => NOMBRE_USUARIO = value; }
        public string CONTRASEÑA1 { get => CONTRASEÑA; set => CONTRASEÑA = value; }
        public DateTime FECHA_ULT_CONEX1 { get => FECHA_ULT_CONEX; set => FECHA_ULT_CONEX = value; }
        public int PREGUNTAS_CONTESTADAS1 { get => PREGUNTAS_CONTESTADAS; set => PREGUNTAS_CONTESTADAS = value; }
        public DateTime FECHA_VENCIMIENTO1 { get => FECHA_VENCIMIENTO; set => FECHA_VENCIMIENTO = value; }
        public string EMAIL1 { get => EMAIL; set => EMAIL = value; }
        public string ROL_USUARIO1 { get => ROL_USUARIO; set => ROL_USUARIO = value; }
        public DateTime FECHA_CREACION1 { get => FECHA_CREACION; set => FECHA_CREACION = value; }
        public string ESTADO_USUARIO1 { get => ESTADO_USUARIO; set => ESTADO_USUARIO = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionUsuarios()
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagUsuarios", conn);
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
