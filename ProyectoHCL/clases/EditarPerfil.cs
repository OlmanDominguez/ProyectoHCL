using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    internal class EditarPerfil
    {
        
        private string NOMBRE;
        private string EMAIL;
        private string CIUDAD;
        private string DESCRIPCIONN;
        private string IMAGEN;
        private string APELLIDO;
        private int CODIGO;
        private string PAIS;


        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public string EMAIL1 { get => EMAIL; set => EMAIL = value; }
        public string CIUDAD1 { get => CIUDAD; set => CIUDAD = value; }
        public string IMAGEN1 { get => IMAGEN; set => IMAGEN = value; }
        public string APELLIDO1 { get => APELLIDO; set => APELLIDO = value; }
        public int CODIGO1 { get => CODIGO; set => CODIGO = value; }
       
        public string PAIS1 { get => PAIS; set => PAIS = value; }
    }
}
