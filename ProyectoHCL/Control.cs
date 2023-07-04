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

        AdmonObjetos admonObjeto = new AdmonObjetos();
        AdmonUsuarios admonUsuario = new AdmonUsuarios();
        AdmonClientes admonClientes = new AdmonClientes();

        public void editarUs(string id, string estado, string rol, string usuario, string nombre,
            string vencimiento, string email)
        {
            admonUsuario.modificarUsuario(Convert.ToInt32(id), estado, rol, usuario, nombre,
                Convert.ToDateTime(vencimiento), email);
        }

        public void editarObj(string id, string nombreObj, string descObj, string estadoObj)
        {
            admonObjeto.modificarObjeto(Convert.ToInt32(id), nombreObj, descObj, estadoObj);
        }

        public void editarClie(string id, string nombreObj, string descObj, string estadoObj)
        {
            admonClientes.modificarCliente(Convert.ToInt32(id), nombreObj, descObj, estadoObj);
        }
    }
}
