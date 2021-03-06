﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class Vaidacion
    {
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public static bool validarTxtBox(Panel panel)
        {
            bool dev = false;
            foreach (Control oControls in panel.Controls)
            {
                if (oControls is TextBox & oControls.Text == String.Empty)
                {
                    dev = true;
                }
            }

            return dev;
        }

        public static void NumerosDecimales(KeyPressEventArgs pE, object sender)
        {
            if (Char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsPunctuation(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }

            if ((pE.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                pE.Handled = true;
            }

            if ((pE.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                pE.Handled = true;
            }

            if (pE.KeyChar == '-')
            {
                pE.Handled = true;
            }
        }
    }
}
