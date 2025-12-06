using System;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeBcalculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        void AgregarDigito(string d)
        {
            lresultado.Text += d;
        }

        protected void b1_Click(object sender, EventArgs e) { AgregarDigito("1"); }
        protected void b2_Click(object sender, EventArgs e) { AgregarDigito("2"); }
        protected void b3_Click(object sender, EventArgs e) { AgregarDigito("3"); }

        protected void Button4_Click(object sender, EventArgs e) { AgregarDigito("4"); }
        protected void Button5_Click(object sender, EventArgs e) { AgregarDigito("5"); }
        protected void Button6_Click(object sender, EventArgs e) { AgregarDigito("6"); }

        protected void b7_Click(object sender, EventArgs e) { AgregarDigito("7"); }
        protected void b8_Click(object sender, EventArgs e) { AgregarDigito("8"); }
        protected void b9_Click(object sender, EventArgs e) { AgregarDigito("9"); }
        protected void b0_Click(object sender, EventArgs e) { AgregarDigito("0"); }

        protected void bsuma_Click(object sender, EventArgs e)
        {
            PrepararOperacionBinaria(OperacionBinaria.Suma);
        }

        protected void bresta_Click(object sender, EventArgs e)
        {
            PrepararOperacionBinaria(OperacionBinaria.Resta);
        }

        protected void bmulti_Click(object sender, EventArgs e)
        {
            PrepararOperacionBinaria(OperacionBinaria.Multiplicacion);
        }

        protected void bdivi_Click(object sender, EventArgs e)
        {
            PrepararOperacionBinaria(OperacionBinaria.Division);
        }

        void PrepararOperacionBinaria(OperacionBinaria tipo)
        {
            if (!double.TryParse(lresultado.Text.Replace(',', '.'),
                                 NumberStyles.Any,
                                 CultureInfo.InvariantCulture,
                                 out double v1))
            {
                lresultado.Text = "Error";
                return;
            }

            ClsOperacion.valor1 = v1;
            ClsOperacion.valor2 = 0;
            ClsOperacion.LimpiarBanderas();

            ClsOperacion.sumar = (tipo == OperacionBinaria.Suma);
            ClsOperacion.restar = (tipo == OperacionBinaria.Resta);
            ClsOperacion.multiplicar = (tipo == OperacionBinaria.Multiplicacion);
            ClsOperacion.dividir = (tipo == OperacionBinaria.Division);

            lresultado.Text = string.Empty;
        }

        void checkBox()
        {
            double n1 = double.Parse(tvalor1.Text, CultureInfo.InvariantCulture);
            double n2 = double.Parse(tvalor2.Text, CultureInfo.InvariantCulture);

            ClsCheckbox operacion = new ClsCheckbox(n1, n2);

            if (Csuma.Checked)
                lresultado.Text += $" [CheckBox Suma: {operacion.sumar()}]";

            if (Cresta.Checked)
                lresultado.Text += $" [CheckBox Resta: {operacion.restar()}]";
        }

        void RadioButton()
        {
            double num1 = double.Parse(tvalor1.Text, CultureInfo.InvariantCulture);
            double num2 = double.Parse(tvalor2.Text, CultureInfo.InvariantCulture);

            ClsRadionButton operacion = new ClsRadionButton();

            if (rsuma.Checked)
                lresultado.Text += $" [RadioButton Suma: {operacion.sumar(num1, num2)}]";
            else if (rresta.Checked)
                lresultado.Text += $" [RadioButton Resta: {ClsRadionButton.restar(num1, num2)}]";
        }

        void DropDown()
        {
            double n1 = double.Parse(tvalor1.Text, CultureInfo.InvariantCulture);
            double n2 = double.Parse(tvalor2.Text, CultureInfo.InvariantCulture);

            ClsDropdonwlist obj = new ClsDropdonwlist(Dlista.SelectedValue);
            double res = obj.Calcular(n1, n2);

            lresultado.Text += $" [DropDown {Dlista.SelectedValue}: {res}]";
        }

        void List()
        {
            double n1 = double.Parse(tvalor1.Text, CultureInfo.InvariantCulture);
            double n2 = double.Parse(tvalor2.Text, CultureInfo.InvariantCulture);

            ClsList obj = new ClsList(ListBox1.GetSelectedIndices(), ListBox1.Items);
            string texto = obj.CalcularTodas(n1, n2);

            lresultado.Text += " " + texto;
        }

        protected void bcalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tvalor1.Text.Replace(',', '.'),
                                 NumberStyles.Any,
                                 CultureInfo.InvariantCulture,
                                 out _) ||
                !double.TryParse(tvalor2.Text.Replace(',', '.'),
                                 NumberStyles.Any,
                                 CultureInfo.InvariantCulture,
                                 out _))
            {
                lresultado.Text = "Error: ingrese números válidos en Numero 1 y Numero 2.";
                return;
            }

            lresultado.Text = string.Empty;
            checkBox();
            RadioButton();
            DropDown();
            List();
        }

        protected void bresultado_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = 0;

                if (ClsOperacion.sumar || ClsOperacion.restar ||
                    ClsOperacion.multiplicar || ClsOperacion.dividir)
                {
                    if (!double.TryParse(lresultado.Text.Replace(',', '.'),
                                         NumberStyles.Any,
                                         CultureInfo.InvariantCulture,
                                         out double v2))
                    {
                        lresultado.Text = "Error";
                        return;
                    }

                    ClsOperacion.valor2 = v2;

                    if (ClsOperacion.sumar)
                        resultado = ClsOperacion.metodo_sumar(ClsOperacion.valor1, ClsOperacion.valor2);
                    else if (ClsOperacion.restar)
                        resultado = ClsOperacion.metodo_restar(ClsOperacion.valor1, ClsOperacion.valor2);
                    else if (ClsOperacion.multiplicar)
                        resultado = ClsOperacion.metodo_multiplicar(ClsOperacion.valor1, ClsOperacion.valor2);
                    else if (ClsOperacion.dividir)
                        resultado = ClsOperacion.metodo_dividir(ClsOperacion.valor1, ClsOperacion.valor2);

                    ClsOperacion.LimpiarBanderas();
                    lresultado.Text = resultado.ToString(CultureInfo.InvariantCulture);
                    return;
                }

                if (!double.TryParse(lresultado.Text.Replace(',', '.'),
                                     NumberStyles.Any,
                                     CultureInfo.InvariantCulture,
                                     out double v1))
                {
                    lresultado.Text = "Error";
                    return;
                }

                if (ClsOperacion.exponente2)
                    resultado = ClsOperacion.metodo_potencia2(v1);
                else if (ClsOperacion.exponente3)
                    resultado = ClsOperacion.metodo_potencia3(v1);
                else if (ClsOperacion.raiz)
                    resultado = ClsOperacion.metodo_raiz(v1);
                else if (ClsOperacion.factorial)
                {
                    var op = new ClsOperacion();
                    op.ResultadoTemporal = ClsOperacion.metodo_factorial((int)v1);
                    lresultado.Text = op.ResultadoTemporal.ToString();
                    ClsOperacion.LimpiarBanderas();
                    return;
                }
                else if (ClsOperacion.fibonacci)
                {
                    var op = new ClsOperacion();
                    op.ResultadoTemporal = ClsOperacion.metodo_fibonacci((int)v1);
                    lresultado.Text = op.ResultadoTemporal.ToString();
                    ClsOperacion.LimpiarBanderas();
                    return;
                }
                else
                {
                    return;
                }

                ClsOperacion.LimpiarBanderas();
                lresultado.Text = resultado.ToString(CultureInfo.InvariantCulture);
            }
            catch
            {
                lresultado.Text = "Error";
                ClsOperacion.LimpiarBanderas();
            }
        }

        protected void bclear_Click(object sender, EventArgs e)
        {
            lresultado.Text = string.Empty;
            ClsOperacion.valor1 = 0;
            ClsOperacion.valor2 = 0;
            ClsOperacion.LimpiarBanderas();
        }

        protected void bpot2_Click(object sender, EventArgs e)
        {
            ClsOperacion.LimpiarBanderas();
            ClsOperacion.exponente2 = true;
        }

        protected void bpot3_Click(object sender, EventArgs e)
        {
            ClsOperacion.LimpiarBanderas();
            ClsOperacion.exponente3 = true;
        }

        protected void braiz_Click(object sender, EventArgs e)
        {
            ClsOperacion.LimpiarBanderas();
            ClsOperacion.raiz = true;
        }

        protected void bfact_Click(object sender, EventArgs e)
        {
            ClsOperacion.LimpiarBanderas();
            ClsOperacion.factorial = true;
        }

        protected void bfib_Click(object sender, EventArgs e)
        {
            ClsOperacion.LimpiarBanderas();
            ClsOperacion.fibonacci = true;
        }
    }

    public enum OperacionBinaria
    {
        Suma,
        Resta,
        Multiplicacion,
        Division
    }
}
