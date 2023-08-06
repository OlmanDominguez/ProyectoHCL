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

        public void editarObj(string id, string nombreObj, string descObj, string estadoObj)
        {
            admonObjeto.modificarObjeto(Convert.ToInt32(id), nombreObj, descObj, estadoObj);
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

        public void editarServ(string id, string descripcion, string precio)
        {
            admonServicios.modificarServicio(Convert.ToInt32(id), descripcion, Convert.ToDecimal(precio));
        }

        public void editarDesc(string id, string descripcion, string porcentaje)
        {
            admonDescuento.modificarDescuento(Convert.ToInt32(id), descripcion, Convert.ToDecimal(porcentaje));
        }

        public void editarClie(string NOMBRECL, int ID_TIPOCLIENTECL, string APELLIDOCL,
             string NOMBRE_RTNCL, string RTNCL, string TELEFONOCL, string EMAILCL, int CODIGOCL,
             string DNI_PASAPORTECL, string TELEFONO2CL, string EMAIL2CL)
        {
            admonClientes.modificarCliente(NOMBRECL, ID_TIPOCLIENTECL, APELLIDOCL, NOMBRE_RTNCL,
                RTNCL, TELEFONOCL, EMAILCL, CODIGOCL, DNI_PASAPORTECL, TELEFONO2CL, EMAIL2CL);
        }
    }
}
