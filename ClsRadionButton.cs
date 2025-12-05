using System;

namespace WeBcalculadora
{
    public class ClsRadionButton
    {
        public string UltimaOperacion { get; set; }

        public ClsRadionButton()
        {
            UltimaOperacion = "";
        }

        public double sumar(double n1, double n2)
        {
            UltimaOperacion = "Suma";
            return n1 + n2;
        }

        public static double restar(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}
