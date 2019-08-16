using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var aluno = new Registro();

            var opcao = 0;

            while(opcao < 5 || opcao > 0)
            {
                Console.Clear();

                opcao = Menu();

                switch (opcao)
                {
                    case 1:
                        aluno.RegistrarAluno();
                        break;
                    case 2:
                        aluno.AlterarRegistro();
                        break;
                    case 3:
                        aluno.ExcluirRegistro();
                        break;
                    case 4:
                        aluno.MostrarInformacoes();
                        Console.ReadKey();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        /// <summary>
        /// Mostra o menu principal na tela do usuário.
        /// </summary>
        /// <returns>Retorna a opção escolhida pelo usuário.</returns>
        public static int Menu()
        {
            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("\r\n1 - Registrar aluno:");
            Console.WriteLine("2 - Alterar registro:");
            Console.WriteLine("3 - Excluir registro:");
            Console.WriteLine("4 - Listar informações:");
            Console.WriteLine("5 - Sair do sistema:");

            return int.Parse(Console.ReadLine());
        }
    }
}
