using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class ValidarTxt
    {
        public static void TxtLetras(KeyPressEventArgs e)
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
                MessageBox.Show("Por favor, sólo ingrese letras");
            }
        }
    }
}
