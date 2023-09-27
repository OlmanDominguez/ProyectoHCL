using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

//Programa:         Clase validar los textbox
//Fecha:            25 - 09 - 2023
//Programador:      Hildegard Montalván
//descripcion:      Clase con las funciones para validar los textbox, para ingresar solo números, letras, etc.

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

namespace ProyectoHCL.clases
{
    public class ValidarTxt
    {
        public static void TxtLetras(KeyPressEventArgs e) //validación para ingresar sólo letras
        {
            if (Char.IsLetter(e.KeyChar)){

                e.Handled = false;

            } else if (Char.IsSeparator(e.KeyChar)){

                e.Handled = false;

            }else if (Char.IsControl(e.KeyChar)) {  

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MsgB m = new MsgB("advertencia", "Por favor, sólo ingrese letras");
                DialogResult dR = m.ShowDialog();
            }
        }

        public static void TxtNumeros(KeyPressEventArgs e) //validación para ingresar sólo números
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MsgB m = new MsgB("advertencia", "Por favor, sólo ingrese números");
                DialogResult dR = m.ShowDialog();
            }
        }

        public static bool CorreoValido(String correo) //validar la dirección de correo
        {
            return correo != null && Regex.IsMatch(correo, "\\w+([-+.’]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
        }

        public static bool txtVacio(TextBox txt) //validar textbox vacío
        {
            if (txt.Text == string.Empty)
            {
                txt.Focus();
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static bool cmbVacio(ComboBox cmb) //validar combobox vacío
        {
            if (cmb.Text == string.Empty)
            {
                cmb.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
