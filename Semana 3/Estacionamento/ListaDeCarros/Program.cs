using BibliotecaCarros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            var cadastro = new Cadastro();

            int opcao = 0;

            while (opcao < 5 || opcao > 0)
            {
                Console.Clear();

                opcao = Menu();

                switch (opcao)
                {
                    case 1:
                        cadastro.RegistrarCarro();
                        break;
                    case 2:
                        cadastro.SaidaCarro();
                        break;
                    case 3:
                        cadastro.MostrarLista();
                        Console.ReadKey();
                        break;
                    case 4:
                        cadastro.MostrarTudo();
                        Console.ReadKey();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static int Menu()
        {
            Console.WriteLine("Informe a opção desejada:\r\n");
            Console.WriteLine("1 - Registrar entrada.");
            Console.WriteLine("2 - Registrar saída.");
            Console.WriteLine("3 - Listar carros estacionados.");
            Console.WriteLine("4 - Listar todos os carros.");
            Console.WriteLine("5 - Sair do sistema.");

            return int.Parse(Console.ReadLine());
        }
    }
}
