using System;

namespace WeBcalculadora
{
    public class ClsDropdonwlist
    {
        public string Opcion { get; set; }

        public ClsDropdonwlist(string opcion)
        {
            Opcion = opcion;
        }

        public double Calcular(double n1, double n2)
        {
            switch (Opcion)
            {
                case "Suma":
                    return n1 + n2;
                case "Resta":
                    return n1 - n2;
                case "Multiplicacion":
                    return n1 * n2;
                case "Division":
                    return (n2 != 0) ? n1 / n2 : 0;
                default:
                    return 0;
            }
        }
    }
}
