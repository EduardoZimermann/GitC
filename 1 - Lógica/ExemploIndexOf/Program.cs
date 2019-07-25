using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o texto desejado: ");
            var texto = Console.ReadLine();

            var pos = texto.ToLower().IndexOf("Edu".ToLower());

            Console.WriteLine($"Posição: {pos}");

            var texto2 = texto.Substring(pos, "Edu".Length);

            Console.WriteLine($"Texto de busca: {texto2}");

            if (texto.Length > 50)
            {
                var texto3 = texto.Substring(texto.IndexOf("senha:") + 6, 5);
                Console.WriteLine($"Texto de busca 2: {texto}");
            }

            var teste = texto.Split(',');

            Console.ReadKey();
        }
    }
}
