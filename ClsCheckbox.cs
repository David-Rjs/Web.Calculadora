using System;

namespace WeBcalculadora
{
    public class ClsCheckbox
    {
        double num1;
        double num2;

        public ClsCheckbox(double n1, double n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double sumar()
        {
            return num1 + num2;
        }

        public double restar()
        {
            return num1 - num2;
        }
    }
}
