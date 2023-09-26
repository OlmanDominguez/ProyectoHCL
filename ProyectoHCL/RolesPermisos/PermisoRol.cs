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

        public string IdRol { get; set; }

        public int IdPermiso { get; set; }

        public int IdObjeto { get; set; }

        public string ObjetoN { get; set; }

        public bool Permitido { get; set; }
    }
}
