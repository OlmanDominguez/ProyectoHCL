using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class Roles
    {
        public int ID_ROL;
        public string NOMBRE_ROL;
        public string DESCRIPCION;
        public string ESTADO_ROL;
        public DateTime FECHA_CREACION;
        public DateTime FECHA_ACTUALIZACION;
     
        public int ID_ROL1 { get => ID_ROL; set => ID_ROL = value; }

        public string NOMBRE_ROL1 { get => NOMBRE_ROL; set => NOMBRE_ROL = value; }

        public string ESTADO_ROL1 { get => ESTADO_ROL; set => ESTADO_ROL = value; }
        public string DESCRIPCION1 { get => DESCRIPCION; set => DESCRIPCION = value; }
        public DateTime FECHA_CREACION1 { get => FECHA_CREACION; set => FECHA_CREACION = value; }

        public DateTime FECHA_ACTUALIZACION1 { get => FECHA_ACTUALIZACION; set => FECHA_ACTUALIZACION= value; }
   
    }
}
        
    