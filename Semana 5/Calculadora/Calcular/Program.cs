using Calculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();

            double.TryParse(Console.ReadLine(), out double valor1);
            double.TryParse(Console.ReadLine(), out double valor2);

            Console.WriteLine(calc.Divisao(valor1,valor2));

            /*
            Console.WriteLine("Informe dois número e obtenha o resultado de cada operação:");

            int.TryParse(Console.ReadLine(), out int valor1);
            int.TryParse(Console.ReadLine(), out int valor2);

            Console.WriteLine($"\r\nAdição: {calc.Adicao(valor1, valor2)}");

            Console.WriteLine($"\r\nSubtração: {calc.Subtracao(valor1, valor2)}");

            Console.WriteLine($"\r\nMultiplicação: {calc.Multiplicacao(valor1, valor2)}");

            Console.WriteLine($"\r\nDivisão: {calc.Divisao(valor1, valor2)}");*/

            Console.ReadKey();
        }
    }
}
