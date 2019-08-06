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
        public int numero1;
        public int numero2;
        public string sinal;
        public bool sinalDigitado = false;

        public ucCalculadora()
        {
            InitializeComponent();
        }

        private void TbxGo_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = Calcular(numero1, sinal, numero2).ToString();
        }

        public int Calcular(int n1, string sign, int n2)
        {
            int result = 0;

            if (sign == "+")
            {
                result = numero1 + numero2;
            }
            else if (sign == "-")
            {
                result = numero1 - numero2;
            }
            else if (sign == "*")
            {
                result = numero1 * numero2;
            }
            else if (sign == "/")
            {
                result = numero1 / numero2;
            }

            return result;
        }

        private void TbxSete_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 = 7;
            else
                numero2 = 7;
        }

        private void TbxOito_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 = 8;
            else
                numero2 = 8;
        }

        private void TbxNove_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 = 9;
            else
                numero2 = 9;
        }

        private void TbxQuatro_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 = 4;
            else
                numero2 = 4;
        }

        private void TbxCinco_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 = 5;
            else
                numero2 = 5;
        }

        private void TbxSeis_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 = 6;
            else
                numero2 = 6;
        }

        private void TbxUm_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 = 1;
            else
                numero2 = 1;
        }

        private void TbxDois_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 = 2;
            else
                numero2 = 2;
        }

        private void TbxTres_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 = 3;
            else
                numero2 = 3;
        }

        private void TbxZero_Click(object sender, RoutedEventArgs e)
        {
            if (!sinalDigitado)
                numero1 = 0;
            else
                numero2 = 0;
        }

        private void TbxMais_Click(object sender, RoutedEventArgs e)
        {
            sinal = "+";
            sinalDigitado = true;
        }

        private void TbxMenos_Click(object sender, RoutedEventArgs e)
        {
            sinal = "-";
            sinalDigitado = true;
        }

        private void TbxVezes_Click(object sender, RoutedEventArgs e)
        {
            sinal = "*";
            sinalDigitado = true;
        }

        private void TbxDividir_Click(object sender, RoutedEventArgs e)
        {
            sinal = "/";
            sinalDigitado = true;
        }

        private void TbxPotencia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TbxBack_Click(object sender, RoutedEventArgs e)
        {
            sinalDigitado = false;
        }
    }
}
