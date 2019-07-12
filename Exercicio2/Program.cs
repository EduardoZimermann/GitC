using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Introducao();

            Console.WriteLine("\r\n Ingredientes:");
            Console.WriteLine("\r\n- 2 xícaras (chá) de açúcar");
            Console.WriteLine("- 3 xícaras (chá) de farinha de trigo");
            Console.WriteLine("- 4 colheres (sopa) de margarina");
            Console.WriteLine("- 3 ovos");
            Console.WriteLine("- 1 e 1/2 xícara (chá) de leite");
            Console.WriteLine("- 1 colher (sopa) bem cheia de fermento em pó");
            LerTecla();

            Introducao();
            Console.WriteLine("\r\nPasso 1:");
            Console.WriteLine("\r\n- 2 xícaras (chá) de açúcar");
        }

        public static void  Introducao()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("        Receita de bolo simples!");
            Console.WriteLine("----------------------------------------");
        }
        public static void LerTecla()
        {
            Console.WriteLine("\r\n\r\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
