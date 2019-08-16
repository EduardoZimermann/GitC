using Cantina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    class Program
    {
        static Aluno aluno = new Aluno("Eduardo");

        static string[,] lanches = new string[6, 2]
        {
            {"Esfiha", "4.50"},
            {"Misto-quente", "2.50"},
            {"Pastel", "3.50"},
            {"Coxinha", "3.50"},
            {"Mini pizza", "3.00"},
            {"X-Tudo","16.00"}
        };

        static void Main(string[] args)
        {
            string opcaoContinuar = "valor padrao";
            int opcaoLanche = 0;

            while (opcaoContinuar != "2")
            {
                opcaoLanche = Menu();

                if (opcaoLanche >= lanches.GetLength(0) || opcaoLanche < 0)
                    continue;

                opcaoContinuar = VerificaCompra(double.Parse(lanches[opcaoLanche, 1]) / 100);
            }
        }

        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Informe o lanche que desejas comprar:");
            for (int i = 0; i < lanches.GetLength(0); i++)
                Console.WriteLine(string.Format("{0,3} {1,15}    R${2,5}", i, lanches[i, 0], lanches[i, 1]));

            int.TryParse(Console.ReadLine(), out int escolhaLanche);

            return escolhaLanche;
        }

        static string VerificaCompra(double valor)
        {
            if (aluno.ComprarLanche(valor))
                Console.WriteLine("Lanche comprado com sucesso!");
            else
                Console.WriteLine("Não há saldo suficiente para realizar esta compra!");

            Console.WriteLine($"Saldo disponível: R$ {aluno.MostrarSaldo():N2}");

            Console.WriteLine("\r\nDesejas realizar outra compra? 1 - Sim   2 - Não");

            return Console.ReadLine();
        }
    }
}
