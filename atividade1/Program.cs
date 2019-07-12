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
            var idade = int.Parse(Console.ReadLine());

            if (idade < 18)
                Console.WriteLine($"{nome} não pode consumir bebida alcóolica...");
            else
                Console.WriteLine($"{nome} já pode beber! =)");

            Console.ReadKey();
        }
    }
}