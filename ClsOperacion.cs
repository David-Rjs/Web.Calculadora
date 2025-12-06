using System;

namespace WeBcalculadora
{
    public class ClsOperacion
    {
        public static double valor1 { get; set; }
        public static double valor2 { get; set; }
        public static double UltimoResultado { get; set; }

        public static bool sumar = false;
        public static bool restar = false;
        public static bool multiplicar = false;
        public static bool dividir = false;
        public static bool factorial = false;
        public static bool exponente2 = false;
        public static bool exponente3 = false;
        public static bool raiz = false;
        public static bool fibonacci = false;

        public long ResultadoTemporal { get; set; }

        public ClsOperacion() { }

        public ClsOperacion(long resultadoInicial)
        {
            ResultadoTemporal = resultadoInicial;
        }

        public static double metodo_sumar(double v1, double v2)
        {
            double res = v1 + v2;
            UltimoResultado = res;
            return res;
        }

        public static double metodo_restar(double v1, double v2)
        {
            double res = v1 - v2;
            UltimoResultado = res;
            return res;
        }

        public static double metodo_multiplicar(double v1, double v2)
        {
            double res = v1 * v2;
            UltimoResultado = res;
            return res;
        }

        public static double metodo_dividir(double v1, double v2)
        {
            if (v2 == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");

            double res = v1 / v2;
            UltimoResultado = res;
            return res;
        }

        public static double metodo_potencia2(double v1)
        {
            double res = v1 * v1;
            UltimoResultado = res;
            return res;
        }

        public static double metodo_potencia3(double v1)
        {
            double res = v1 * v1 * v1;
            UltimoResultado = res;
            return res;
        }

        public static double metodo_raiz(double v1)
        {
            if (v1 < 0)
                throw new ArgumentException("No se puede sacar raíz cuadrada de un número negativo.");

            double res = Math.Sqrt(v1);
            UltimoResultado = res;
            return res;
        }

        public static long metodo_factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("El factorial solo está definido para enteros >= 0.");

            long r = 1;
            for (int i = 2; i <= n; i++)
                r *= i;

            return r;
        }

        public static long metodo_fibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentException("Fibonacci solo está definido para enteros >= 0.");

            if (n == 0) return 0;
            if (n == 1) return 1;

            long a = 0;
            long b = 1;
            for (int i = 2; i <= n; i++)
            {
                long t = a + b;
                a = b;
                b = t;
            }

            return b;
        }

        public static void LimpiarBanderas()
        {
            sumar = false;
            restar = false;
            multiplicar = false;
            dividir = false;
            factorial = false;
            exponente2 = false;
            exponente3 = false;
            raiz = false;
            fibonacci = false;
        }
    }
}
