using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL
{
    public class Control
    {
        public string ctrlRegistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string mensaje = "";
           
                if (modelo.existeUsuario(usuario.USUARIO1))
                {
                    mensaje = "El usuario ya existe";
                }
                else
                {
                    modelo.registro(usuario);
                }
            
            return mensaje;
        }
    }
}
