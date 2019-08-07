using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora.Views
{
    /// <summary>
    /// Interaction logic for ucCalculadora.xaml
    /// </summary>
    public partial class ucCalculadora : UserControl
    {
        public string numero1;
        public string numero2;
        public double resultado;
        public string sinal;
        public double potencia = 1;
        public bool sinalDigitado = false;
        public bool sinalDeclarado = false;
        public bool doisSinais = false;

        public ucCalculadora()
        {
            InitializeComponent();
        }

        private void TbxGo_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(numero2))
                txtResultado.Text = numero1;
            else
                Calcular();
        }

        public void Calcular()
        {
            double.TryParse(numero1, out double valor1);
            double.TryParse(numero2, out double valor2);

            switch (sinal)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    break;
                case "^":
                    if (valor2 < 0)
                    {
                        for (int i = 0; i < (valor2 * -1); i++)
                            potencia *= valor1;

                        resultado = 1 / potencia;
                    }
                    else
                    {
                        for (int i = 0; i < valor2; i++)
                            potencia *= valor1;

                        resultado = potencia;
                    }
                    break;
            }

            txtResultado.Text = resultado.ToString();
        }

        private void TbxBack_Click(object sender, RoutedEventArgs e)
        {
            numero1 = "";
            numero2 = "";
            resultado = 0;
            sinal = null;
            potencia = 1;
            txtConta.Text = "";
            txtResultado.Text = "";
            sinalDigitado = false;
            sinalDeclarado = false;
            doisSinais = false;
        }

        #region Eu não me orgulho desse codigo
        private void TbxZero_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 += "0";
            else
                numero2 += "0";

            txtConta.Text += "0";
            sinalDeclarado = false;
            doisSinais = false;
        }

        private void TbxUm_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 += "1";
            else
                numero2 += "1";

            txtConta.Text += "1";
            sinalDeclarado = false;
            doisSinais = false;
        }

        private void TbxDois_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 += "2";
            else
                numero2 += "2";

            txtConta.Text += "2";
            sinalDeclarado = false;
            doisSinais = false;
        }

        private void TbxTres_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 += "3";
            else
                numero2 += "3";

            txtConta.Text += "3";
            sinalDeclarado = false;
            doisSinais = false;
        }

        private void TbxQuatro_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 += "4";
            else
                numero2 += "4";

            txtConta.Text += "4";
            sinalDeclarado = false;
            doisSinais = false;
        }

        private void TbxCinco_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 += "5";
            else
                numero2 += "5";

            txtConta.Text += "5";
            sinalDeclarado = false;
            doisSinais = false;
        }

        private void TbxSeis_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 += "6";
            else
                numero2 += "6";

            txtConta.Text += "6";
            sinalDeclarado = false;
            doisSinais = false;
        }

        private void TbxSete_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 += "7";
            else
                numero2 += "7";

            txtConta.Text += "7";
            sinalDeclarado = false;
            doisSinais = false;
        }

        private void TbxOito_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 += "8";
            else
                numero2 += "8";

            txtConta.Text += "8";
            sinalDeclarado = false;
            doisSinais = false;
        }

        private void TbxNove_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 += "9";
            else
                numero2 += "9";

            txtConta.Text += "9";
            sinalDeclarado = false;
            doisSinais = false;
        }

        private void TbxMais_Click(object sender, RoutedEventArgs e)
        {
            if (sinalDeclarado)
            {
                if (!doisSinais)
                {
                    numero2 += "+";
                    txtConta.Text += "+";
                    doisSinais = true;
                }

                return;
            }
            else
                AumentaConta("+");
        }

        private void TbxMenos_Click(object sender, RoutedEventArgs e)
        {
            if (sinalDeclarado)
            {
                if (!doisSinais)
                {
                    numero2 += "-";
                    txtConta.Text += "-";
                    doisSinais = true;
                }

                return;
            }
            else
                AumentaConta("-");
        }

        private void TbxVezes_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDeclarado && !string.IsNullOrEmpty(numero1))
                AumentaConta("*");
        }

        private void TbxDividir_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDeclarado && !string.IsNullOrEmpty(numero1))
                AumentaConta("/");
        }

        private void TbxPotencia_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDeclarado && !string.IsNullOrEmpty(numero1))
                AumentaConta("^");
        }

        public void AumentaConta(string operation)
        {
            double.TryParse(numero1, out double value1);
            double.TryParse(numero2, out double value2);

            if (numero2 != null)
            {
                switch (sinal)
                {
                    case "+":
                        value1 += value2;
                        break;
                    case "-":
                        value1 -= value2;
                        break;
                    case "*":
                            value1 *= value2;
                        break;
                    case "/":
                        if (value2 != 0)
                            value1 /= value2;
                        break;
                    case "^":
                        if (value2 < 0)
                        {
                            for (int i = 0; i < (value2 * -1); i++)
                                potencia *= value1;

                            value1 = 1 / potencia;
                        }
                        else
                        {
                            for (int i = 0; i < value2; i++)
                                potencia *= value1;

                            value1 = potencia;
                        }
                        break;
                }

                numero1 = value1.ToString();
                numero2 = null;
            }

            sinal = operation;
            sinalDigitado = true;
            sinalDeclarado = true;
            txtConta.Text += operation;
        }

        private void TbxPonto_Click(object sender, RoutedEventArgs e)
        {
            if (sinal != "^")
            {
                if (!sinalDigitado)
                {
                    if (!string.IsNullOrEmpty(numero1))
                    {
                        if (!numero1.Contains(","))
                        {
                            numero1 += ",";
                            txtConta.Text += ".";
                            sinalDeclarado = false;
                            doisSinais = false;
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(numero2))
                    {
                        if (!numero2.Contains(","))
                        {
                            if (!sinalDeclarado)
                            {
                                numero2 += ",";
                                txtConta.Text += ".";
                                sinalDeclarado = false;
                                doisSinais = false;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        private void Grid_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
