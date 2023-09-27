using ProyectoHCL.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//-----------------------------------------------------------------------
//    Universidad Nacional Autonoma de Honduras (UNAH)
//		Facultad de Ciencias Economicas
//	Departamento de Informatica administrativa
//         Analisis, Programacion y Evaluacion de Sistemas
//                    Tercer Periodo 2023


//Equipo:
//GABRIELA YISSELE MANCIA------------(gabriela.mancia@unah.hn)

//HILDEGARD BETSUA MONTALVAN SUAZO---(hildegard.montalvan@unah.hn)

//NELSON NOE SALGADO ALVARENGA-------(nelson.salgado@unah.hn)

//JOEL ENRIQUE GODOY BONILLA---------(joel.bonilla@unah.hn)

//OLMAN ARIEL DOMÍNGUEZ--------------(olman.dominguez@unah.hn)

//Catedratico analisis y diseño:             Lic.Giancarlo Martini Scalici Aguilar 
//catedratico programacion e implementacion: Lic.Karla Melisa Garcia Pineda 
//catedratico evaluacion de sistemas:        Lic.Karla Melisa Garcia Pineda 


//---------------------------------------------------------------------

//Programa:         Clase control
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván, Olman Domínguez, Andrés Osorto
//descripcion:      Clase con las funciones para editar los registros definiendo los parámetros a recibir

//-----------------------------------------------------------------------

//                Historial de Cambio

//-----------------------------------------------------------------------

//Programador               Fecha                      Descripcion
//GABRIELA  MANCIA  

//HILDEGARD  MONTALVAN   

//NELSON SALGADO  

//JOEL  GODOY 

//OLMAN  DOMÍNGUEZ 

//-----------------------------------------------------------------------


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

        public void editarUs(string id, string estado, string rol, string usuario, string nombre, //editar usuarios
            string contraseña, string vencimiento, string email)
        {
            admonUsuario.modificarUsuario(Convert.ToInt32(id), estado, rol, usuario, nombre,
               contraseña, Convert.ToDateTime(vencimiento), email);
        }

        public void editarObj(string id, string nombreObj, string descObj, string estadoObj, string actP) //editar objetos
        {
            admonObjeto.modificarObjeto(Convert.ToInt32(id), nombreObj, descObj, estadoObj, Convert.ToInt32(actP));
        }

        public void editarTipHab(string id, string tipo, string capacidad, string precio, string est) //editar tipo de habitación
        {
            admonTipHab.modificarTipHab(Convert.ToInt32(id), tipo, Convert.ToInt32(capacidad), 
                Convert.ToDecimal(precio), est);
        }

        public void editarHab(string id, string tipo, string numero, string estado) //editar habitación
        {
            admonHabitaciones.modificarHabitacion(Convert.ToInt32(id), tipo, Convert.ToInt32(numero), estado);
        }

        public void editarServ(string id, string descripcion, string precio, string est) //editar servicio
        {
            admonServicios.modificarServicio(Convert.ToInt32(id), descripcion, Convert.ToDecimal(precio), est);
        }

        public void editarDesc(string id, string descripcion, string porcentaje, string est, string idU) //editar descuento
        {
            admonDescuento.modificarDescuento(Convert.ToInt32(id), descripcion, Convert.ToDecimal(porcentaje), est, Convert.ToInt32(idU));
        }

        public void editarClie(string NOMBRECL, int ID_TIPOCLIENTECL, string APELLIDOCL, //editar cliente
             string NOMBRE_RTNCL, string RTNCL, string TELEFONOCL, string EMAILCL, int CODIGOCL,
             string DNI_PASAPORTECL, string TELEFONO2CL, string EMAIL2CL)
        {
            admonClientes.modificarCliente(NOMBRECL, ID_TIPOCLIENTECL, APELLIDOCL, NOMBRE_RTNCL,
                RTNCL, TELEFONOCL, EMAILCL, CODIGOCL, DNI_PASAPORTECL, TELEFONO2CL, EMAIL2CL);
        }

        public void editarR(string  id, string nombrerol, string descripcion, string estado_rol)// string fecha_creacion,string fecha_actualizacion)
        {
            admonRoles.modificarRol(Convert.ToInt32(id), nombrerol, descripcion, estado_rol); //Convert.ToDateTime(fecha_creacion), Convert.ToDateTime(fecha_actualizacion));//Convert.ToDateTime(fecha_creacion), Convert.ToDateTime(fecha_actualizacion)
            //editar rol
        }
    }
}
