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

            Console.WriteLine("Informe dois número e obtenha o resultado de cada operação:");

            int.TryParse(Console.ReadLine(), out int valor1);
            int.TryParse(Console.ReadLine(), out int valor2);

            Console.WriteLine($"\r\nAdição: {calc.Adicao(valor1, valor2)}");

            Console.WriteLine($"\r\nSubtração: {calc.Subtracao(valor1, valor2)}");

            Console.WriteLine($"\r\nMultiplicação: {calc.Multiplicacao(valor1, valor2)}");

            try
            {
                Console.WriteLine($"\r\nDivisão: {calc.Divisao(valor1, valor2)}");
            }
            catch
            {
                Console.WriteLine("\r\nDivisão: Num deu!");
            }
            
            Console.ReadKey();
        }
    }
}
