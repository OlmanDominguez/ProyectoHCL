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
        AdmonRoles admonRoles = new AdmonRoles();
        AdmonObjetos admonObjeto = new AdmonObjetos();
        AdmonUsuarios admonUsuario = new AdmonUsuarios();
        AdmonClientes admonClientes = new AdmonClientes();
        AdmonTipHab admonTipHab = new AdmonTipHab();
        AdmonHabitaciones admonHabitaciones = new AdmonHabitaciones();
        AdmonServicios admonServicios = new AdmonServicios();
        AdmonDescuento admonDescuento = new AdmonDescuento();   

        public void editarUs(string id, string estado, string rol, string usuario, string nombre,
            string contraseña, string vencimiento, string email)
        {
            admonUsuario.modificarUsuario(Convert.ToInt32(id), estado, rol, usuario, nombre,
               contraseña, Convert.ToDateTime(vencimiento), email);
        }

        public void editarObj(string id, string nombreObj, string descObj, string estadoObj, string actP) 
        {
            admonObjeto.modificarObjeto(Convert.ToInt32(id), nombreObj, descObj, estadoObj, Convert.ToInt32(actP));
        }

        public void editarTipHab(string id, string tipo, string capacidad, string precio)
        {
            admonTipHab.modificarTipHab(Convert.ToInt32(id), tipo, Convert.ToInt32(capacidad), 
                Convert.ToDecimal(precio));
        }

        public void editarHab(string id, string tipo, string numero, string estado)
        {
            admonHabitaciones.modificarHabitacion(Convert.ToInt32(id), tipo, Convert.ToInt32(numero), estado);
        }

        public void editarServ(string id, string descripcion, string precio, string est)
        {
            admonServicios.modificarServicio(Convert.ToInt32(id), descripcion, Convert.ToDecimal(precio), est);
        }

        public void editarDesc(string id, string descripcion, string porcentaje, string idU)
        {
            admonDescuento.modificarDescuento(Convert.ToInt32(id), descripcion, Convert.ToDecimal(porcentaje), Convert.ToInt32(idU));
        }

        public void editarClie(string NOMBRECL, int ID_TIPOCLIENTECL, string APELLIDOCL,
             string NOMBRE_RTNCL, string RTNCL, string TELEFONOCL, string EMAILCL, int CODIGOCL,
             string DNI_PASAPORTECL, string TELEFONO2CL, string EMAIL2CL)
        {
            admonClientes.modificarCliente(NOMBRECL, ID_TIPOCLIENTECL, APELLIDOCL, NOMBRE_RTNCL,
                RTNCL, TELEFONOCL, EMAILCL, CODIGOCL, DNI_PASAPORTECL, TELEFONO2CL, EMAIL2CL);
        }

        public void editarR(string  id, string rol, string descripcion, string estado_rol)// string fecha_creacion,string fecha_actualizacion)
        {
            admonRoles.modificarRol(Convert.ToInt32(id), rol, descripcion, estado_rol); //Convert.ToDateTime(fecha_creacion), Convert.ToDateTime(fecha_actualizacion));//Convert.ToDateTime(fecha_creacion), Convert.ToDateTime(fecha_actualizacion)

        }
    }
}
