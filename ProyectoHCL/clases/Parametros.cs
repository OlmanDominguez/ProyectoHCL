using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class Parametros
    {
        private int IDP;
        private string NOMBRE_PARAMETRO;
        private string VALOR;
        private DateTime FECHA_CREACION;
        private DateTime FECHA_ACTUALIZACION;
      

       
        public int IDP1 { get => IDP; set => IDP = value; }
        public string NOMBRE_PARAMETRO1 { get => NOMBRE_PARAMETRO; set => NOMBRE_PARAMETRO = value; }
        public string VALOR1 { get => VALOR; set => VALOR = value; }
        public DateTime FECHA_CREACION1 { get => FECHA_CREACION; set => FECHA_CREACION = value; }
        public DateTime FECHA_ACTUALIZACION1 { get => FECHA_ACTUALIZACION; set => FECHA_ACTUALIZACION = value; }
    }
}
