using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                MsgB m = new MsgB("advertencia", "Por favor, sólo ingrese letras");
                DialogResult dR = m.ShowDialog();
            }
        }

        public static void TxtNumeros(KeyPressEventArgs e)
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

        public static bool CorreoValido(String correo)
        {
            return correo != null && Regex.IsMatch(correo, "\\w+([-+.’]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
        }

        public static bool txtVacio(TextBox txt)
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

        public static bool cmbVacio(ComboBox cmb)
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
