using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade: ");
            int.TryParse(Console.ReadLine(), out int idade);

            Console.Clear();

            if (idade < 18)
                Console.WriteLine($"{nome} é menor de 18 e não pode consumir bebida alcóolica...");
            else
                Console.WriteLine($"{nome} tem mais de 18 anos e já pode beber! =)");

            Console.ReadKey();
        }
    }
}