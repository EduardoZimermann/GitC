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

            try
            {
                calc.Resultado(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("\r\nAlgo deu errado!!! =( =( =(");
            }
            
            Console.ReadKey();
        }
    }
}
