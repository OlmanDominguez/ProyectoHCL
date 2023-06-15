using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    internal class Permisos
    {
      
        public string ID_ROL { get; set; }
        public string NOMBRE { get; set; }
        public string ESTADO_ROL{ get; set; }
        public DateTime PRIMER_INGRESO1 { get; set; }
        public DateTime FECHA_VENCIMIENTO1 { get; set; }
        public string EDITAR{ get; set; }
        public string ELIMINAR { get; set; }

        public Permisos(string id_rol, string nombre, string estado_rol,DateTime primer_ingreso, DateTime fecha_vencimineto, string Editar, string Eliminar)
        {
            this.ID_ROL = id_rol;
            this.NOMBRE = nombre;   
            this.ESTADO_ROL = estado_rol;
            this.PRIMER_INGRESO1 = primer_ingreso;
            this.FECHA_VENCIMIENTO1 = fecha_vencimineto;    
            this.EDITAR = Editar;
            this.ELIMINAR = Eliminar;
        }
        
    }


}

