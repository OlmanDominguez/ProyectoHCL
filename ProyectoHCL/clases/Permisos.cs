using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class Permisos
    {
        public int ID_ROL;
        public string NOMBRE;
        public string ESTADO_ROL;
        public DateTime PRIMER_INGRESO;
        public DateTime FECHA_VENCIMIENTO;
        //public string EDITAR;
        //public string ELIMINAR;

        public int ID_ROL1 { get => ID_ROL; set => ID_ROL = value; }
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
      public string ESTADO_ROL1 { get => ESTADO_ROL; set => ESTADO_ROL = value; }
        public DateTime PRIMER_INGRESO1 { get => PRIMER_INGRESO; set => PRIMER_INGRESO = value; }
        public DateTime FECHA_VENCIMIENTO1 { get => FECHA_VENCIMIENTO; set => FECHA_VENCIMIENTO = value; }
       // public string EDITAR1 { get => EDITAR; set => EDITAR = value; }
        //public string ELIMINAR1 { get => ELIMINAR; set => ELIMINAR = value; }
    }
}
        
    