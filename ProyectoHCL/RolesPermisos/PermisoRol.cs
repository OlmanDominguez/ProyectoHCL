using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.RolesPermisos
{
    public class PermisoRol
    {
        public int IdPermisoRol { get; set; }

        public int IdRol { get; set; }

        public int IdPermiso { get; set; }

        public int IdObjeto { get; set; }

        public bool Permitido { get; set; }
    }
}
