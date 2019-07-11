using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SistemaAlocacaoDeCarro
{
    class Program
    {
        static string[,] ListaDeCarros;
        static void Main(string[] args)
        {
            CarregaListaDeCarros();

            var opcaoMenu = MenuInicial();

            while (opcaoMenu != 3)
            {
                MetodoPrincipal(opcaoMenu);

                if (opcaoMenu == 1)
                {
                    MostrarLista();

                    Console.WriteLine("Pressione 's' para sair ou outra tecla para continuar:");

                    if (Console.ReadKey().KeyChar.ToString() != "s")
                    {
                        opcaoMenu = MenuInicial();
                    }
                    else
                        FinalizarSistema();
                }
            }

            FinalizarSistema();
        }

        /// <summary>
        /// Carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaListaDeCarros()
        {
            ListaDeCarros = new string[5, 3]
            {
                { "Porsche", "2013", "Sim" },
                { "Lamborghini", "2009", "Não" },
                { "Ferrari", "2015", "Sim" },
                { "Mercedes", "2016", "Sim" },
                {"Camaro", "2013", "Não"}
            };
        }
        /// <summary>
        /// Limpa a tela e apresenta o menu de introdução.
        /// </summary>
        public static void Introducao()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("       SISTEMA DE ALOCAÇÃO DE CARROS");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("             SEJA BEM-VINDO!!!");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("");
        }
        /// <summary>
        /// Apresenta o menu inicial e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor escolhido pelo usuário em um inteiro.</returns>
        public static int MenuInicial()
        {
            Introducao();

            Console.WriteLine("");
            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine("1 - Alocar um carro");
            Console.WriteLine("2 - SUPER ANIMAÇÃO AUTOMOBILISTICA!!!");
            Console.WriteLine("3 - Sair do sistema");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            return opcao;
        }
        /// <summary>
        /// Verifica se o carro digitado pelo usuário se encontra no sistema.
        /// </summary>
        /// <param name="nomeCarro">Nome do carro a ser pesquisado.</param>
        /// <returns>Retorna um inteiro representando a situação do carro.</returns>
        public static int PesquisarCarro(string nomeCarro)
        {
            for (int i = 0; i < ListaDeCarros.GetLength(0); i++)
            {
                if (nomeCarro.ToUpper() == ListaDeCarros[i, 0].ToUpper())
                {
                    if (ListaDeCarros[i, 2] == "Sim")
                        return 1;
                    else
                        return 2;
                }
            }

            return 3;
        }
        /// <summary>
        /// Método responsável para atualizar a lista de carros sempre que o usuário realiza uma alocação.
        /// </summary>
        /// <param name="carro">Nome do carro a ser alocado.</param>
        public static void AtualizaLista(string carro)
        {
            for (int i = 0; i < ListaDeCarros.GetLength(0); i++)
            {
                if (carro == ListaDeCarros[i, 0])
                {
                    ListaDeCarros[i, 2] = "Não";
                }
            }
        }
        /// <summary>
        /// Método que mostra a lista de carros com nomes, anos e disponibilidades;
        /// </summary>
        public static void MostrarLista()
        {
            Console.WriteLine($"\r\nLista de carros:");

            for (int i = 0; i < ListaDeCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {ListaDeCarros[i, 0]}, ano: {ListaDeCarros[i, 1]}, disponível: {ListaDeCarros[i, 2]}.");
            }
        }
        /// <summary>
        /// Método principal que realiza as escolhas do usuário.
        /// </summary>
        /// <param name="opcaoMenu">Opção escolhida pelo usuário.</param>
        public static void MetodoPrincipal(int opcaoMenu)
        {
            while (opcaoMenu != 1 && opcaoMenu != 2 && opcaoMenu != 3)
            {
                Introducao();
                Console.WriteLine("Opção inválida! Tente novamente.");
                opcaoMenu = MenuInicial();
            }
            if (opcaoMenu == 1)
            {
                Introducao();

                Console.WriteLine("Digite o nome do carro desejado: ");

                var nomeDoCarro = Console.ReadLine();

                if (PesquisarCarro(nomeDoCarro) == 1)
                {
                    Introducao();

                    Console.WriteLine($"Você deseja alocar o carro? 1 - sim   2 - não");

                    var opcaoAlocacao = Console.ReadKey().KeyChar.ToString();

                    while (opcaoAlocacao != "1" && opcaoAlocacao != "2")
                    {
                        Introducao();
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        Console.WriteLine($"Você deseja alocar o carro? 1 - sim   2 - não");
                        opcaoAlocacao = Console.ReadKey().KeyChar.ToString();
                    }
                    if (opcaoAlocacao == "1")
                    {
                        AtualizaLista(nomeDoCarro);
                        Introducao();
                        Console.WriteLine($"{UppercaseFirst(nomeDoCarro)} alocado com sucesso!");
                    }
                    else
                    {
                        Introducao();
                        Console.WriteLine($"{nomeDoCarro} não alocado.");
                    }
                }
                else if (PesquisarCarro(nomeDoCarro) == 2)
                {
                    Introducao();

                    Console.WriteLine($"O carro {nomeDoCarro} não está disponível para alocação!");
                }
                else
                {
                    Introducao();

                    Console.WriteLine($"O carro {nomeDoCarro} não foi encontrado no sistema!");
                }
            }
            else if (opcaoMenu == 2)
            {
                Animacao();
            }
        }
        /// <summary>
        /// MÉTODO SUPER AVANÇADO INDESCRITIVELMENTE INDESCRITÍVEL!!!
        /// </summary>
        public static void Animacao()
        {
            var n = 0;
            while (n != 666)
            {
                Console.WriteLine("");
                Console.WriteLine("   _-_-  ______");
                Console.WriteLine("_-_-__  /|_|||_ |_");
                Console.WriteLine("   _-_-(   _    _ _)");
                Console.WriteLine("_ -__  =`-(_)--(_)-'");
                Thread.Sleep(10);
                Console.Clear();


                Console.WriteLine("");
                Console.WriteLine("  _-_-   ______");
                Console.WriteLine("-_-___  /|_|||_ |_");
                Console.WriteLine("  _-_- (   _    _ _)");
                Console.WriteLine(" -__   =`-(_)--(_)-'");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine(" _-_-    ______");
                Console.WriteLine("_-___-  /|_|||_ |_");
                Console.WriteLine(" _-_-  (   _    _ _)");
                Console.WriteLine("-__    =`-(_)--(_)-'");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("_-_-     ______");
                Console.WriteLine("-___-_  /|_|||_ |_");
                Console.WriteLine("_-_-   (   _    _ _)");
                Console.WriteLine("__   - =`-(_)--(_)-'");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("-_-  _   ______");
                Console.WriteLine("___-_-  /|_|||_ |_");
                Console.WriteLine("-_-  _ (   _    _ _)");
                Console.WriteLine("_   -_ =`-(_)--(_)-'");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("_-  _-   ______");
                Console.WriteLine("__-_-_  /|_|||_ |_");
                Console.WriteLine("_-  _- (   _    _ _)");
                Console.WriteLine("   -__ =`-(_)--(_)-'");
                Thread.Sleep(10);
                Console.Clear();
            }
        }
        public static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            char[] a = s.ToCharArray();

            foreach (var letra in a)
                char.ToLower(letra);

            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
        public static void FinalizarSistema()
        {
            Console.Clear();

            Console.WriteLine("Finalizando o sistema...");
            Thread.Sleep(1200);
            Environment.Exit(0);
        }
    }
}
