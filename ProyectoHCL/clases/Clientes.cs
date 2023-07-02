using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class Clientes
    {
        private int ID_TIPOCLIENTE;
        private string NOMBRE;
        private string APELLIDO;
        private string NOMBRE_RTN;
        private string RTN;
        private string TELEFONO;
        private string EMAIL;
        private string DNI_PASAPORTE;
        private int CODIGO;

        public int ID_TIPOCLIENTE1 { get => ID_TIPOCLIENTE; set => ID_TIPOCLIENTE = value; }
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public string APELLIDO1 { get => APELLIDO; set => APELLIDO = value; }
        public string NOMBRE_RTN1 { get => NOMBRE_RTN; set => NOMBRE_RTN = value; }
        public string RTN1 { get => RTN; set => RTN = value; }
        public string TELEFONO1 { get => TELEFONO; set => TELEFONO = value; }
        public string EMAIL1 { get => EMAIL; set => EMAIL = value; }
        public string DNI_PASAPORTE1 { get => DNI_PASAPORTE; set => DNI_PASAPORTE = value; }
        public int CODIGO1 { get => CODIGO; set => CODIGO = value; }

    }
}
