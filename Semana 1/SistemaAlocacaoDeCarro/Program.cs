﻿using System;
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

            LacoDeRepeticao();

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
            Console.WriteLine("2 - Devolver um carro");
            Console.WriteLine("3 - Atualizar lista de carros");
            Console.WriteLine("4 - SUPER ANIMAÇÃO AUTOMOBILISTICA!!!");
            Console.WriteLine("5 - Sair do sistema");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Verifica se o carro digitado pelo usuário se encontra no sistema.
        /// </summary>
        /// <param name="nomeCarro">Nome do carro a ser pesquisado.</param>
        /// <returns>Retorna um inteiro representando a situação do carro.</returns>
        public static bool? PesquisarCarro(string nomeCarro)
        {
            for (int i = 0; i < ListaDeCarros.GetLength(0); i++)
            {
                if (ComparaNomes(nomeCarro, ListaDeCarros[i, 0]))
                {
                    if (ListaDeCarros[i, 2] == "Sim")
                        return true;
                    else
                        return false;
                }
            }

            return null;
        }
        /// <summary>
        /// Método responsável para atualizar a lista de carros sempre que o usuário realiza uma alocação.
        /// </summary>
        /// <param name="carro">Nome do carro a ser alocado.</param>
        public static void AtualizaSistema(string carro, bool alocar)
        {
            carro = carro.ToUpper();

            for (int i = 0; i < ListaDeCarros.GetLength(0); i++)
            {
                if (ComparaNomes(carro,ListaDeCarros[i,0]))
                {
                    ListaDeCarros[i, 2] = alocar? "Não" : "Sim";
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
                Console.WriteLine($"{i+1} - Nome: {ListaDeCarros[i, 0]}, ano: {ListaDeCarros[i, 1]}, disponível: {ListaDeCarros[i, 2]}.");
            }
            Console.WriteLine("");
        }
        /// <summary>
        /// Ao chamar este método, o programa só continuará quando alguma tecla for pressionada;
        /// </summary>
        public static void LerTecla()
        {
            MostrarLista();

            Console.WriteLine("\r\nPressione qualquer tecla para continuar:");

            Console.ReadKey();
        }
        /// <summary>
        /// Método principal que realiza as escolhas do usuário.
        /// </summary>
        /// <param name="opcaoMenu">Opção escolhida pelo usuário.</param>
        public static void MetodoPrincipal(int opcaoMenu)
        {
            if (opcaoMenu == 1)
            {
                AlocarCarro();
            }
            else if (opcaoMenu == 2)
            {
                DesalocarCarro();
            }
            else if (opcaoMenu == 3)
            {
                AtualizarLista();
            }
            else if (opcaoMenu == 4)
            {
                Animacao();
            }
        }
        /// <summary>
        /// Realiza o método de repetição principal, na qual força o usuário a digitar a opção correta.
        /// </summary>
        public static void LacoDeRepeticao()
        {
            var opcaoMenu = 0;

            while (opcaoMenu != 5)
            {
                while (opcaoMenu > 5 || opcaoMenu < 1)
                {
                    opcaoMenu = MenuInicial();
                }

                MetodoPrincipal(opcaoMenu);

                if (opcaoMenu == 1 || opcaoMenu == 2 || opcaoMenu == 3)
                {
                    LerTecla();

                    opcaoMenu = MenuInicial();
                }
            }
        }
        /// <summary>
        /// Método que mostra as operações para alocar um carro.
        /// </summary>
        public static void AlocarCarro()
        {
            Introducao();
            MostrarLista();

            Console.WriteLine("Digite o nome do carro desejado: ");

            var nomeDoCarro = Console.ReadLine();
            var resultadoPesquisa = PesquisarCarro(nomeDoCarro);

            if (resultadoPesquisa != null && resultadoPesquisa == true)
            {
                Introducao();

                Console.WriteLine($"Deseja alocar o carro {FormatarNome(nomeDoCarro)}? 1 - sim   2 - não");

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
                    AtualizaSistema(nomeDoCarro, true);
                    Introducao();
                    Console.WriteLine($"{FormatarNome(nomeDoCarro)} alocado com sucesso!");
                }
                else
                {
                    Introducao();
                    Console.WriteLine($"{FormatarNome(nomeDoCarro)} não alocado.");
                }
            }
            else if (PesquisarCarro(nomeDoCarro) == false)
            {
                Introducao();

                Console.WriteLine($"O carro {FormatarNome(nomeDoCarro)} não está disponível para alocação!");
            }
            else
            {
                Introducao();

                Console.WriteLine($"O carro {FormatarNome(nomeDoCarro)} não foi encontrado no sistema!");
            }
        }
        /// <summary>
        /// Método que mostra as operações para devolver um carro.
        /// </summary>
        public static void DesalocarCarro()
        {
            Introducao();
            MostrarLista();

            Console.WriteLine("Digite o nome do carro a ser devolvido: ");

            var nomeDoCarro = Console.ReadLine();
            var resultadoPesquisa = PesquisarCarro(nomeDoCarro);

            if (resultadoPesquisa != null && resultadoPesquisa == false)
            {
                Introducao();

                Console.WriteLine($"Você deseja devolver o carro {FormatarNome(nomeDoCarro)}? 1 - sim   2 - não");

                var opcaoAlocacao = Console.ReadKey().KeyChar.ToString();

                while (opcaoAlocacao != "1" && opcaoAlocacao != "2")
                {
                    Introducao();
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    Console.WriteLine($"Você deseja devolver o carro {FormatarNome(nomeDoCarro)}? 1 - sim   2 - não");
                    opcaoAlocacao = Console.ReadKey().KeyChar.ToString();
                }
                if (opcaoAlocacao == "1")
                {
                    AtualizaSistema(nomeDoCarro, false);
                    Introducao();
                    Console.WriteLine($"{FormatarNome(nomeDoCarro)} devolvido com sucesso!");
                }
                else
                {
                    Introducao();
                    Console.WriteLine($"{FormatarNome(nomeDoCarro)} não devolvido.");
                }
            }
            else if (PesquisarCarro(nomeDoCarro) == true)
            {
                Introducao();

                Console.WriteLine($"O carro {FormatarNome(nomeDoCarro)} já foi devolvido!");
            }
            else
            {
                Introducao();

                Console.WriteLine($"O carro {FormatarNome(nomeDoCarro)} não foi encontrado no sistema!");
            }
        }
        /// <summary>
        /// Chamado para cuidar de todo o processo necessário para atualizar algum dado na lista de carros.
        /// </summary>
        public static void AtualizarLista()
        {
            Introducao();

            Console.WriteLine("Escolha a linha a ser modificada digitando o número correspondente:");

            MostrarLista();

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            var opcaoLinha = VerificaEscolha(opcao, 5);
            opcaoLinha = opcaoLinha - 1;

            int opcaoColuna = 0;

            while (opcaoColuna > 3 || opcaoColuna < 1)
            {
                Introducao();

                Console.WriteLine($"{opcaoLinha + 1} - Nome: {ListaDeCarros[opcaoLinha, 0]}, " +
                    $"ano: {ListaDeCarros[opcaoLinha, 1]}, " +
                    $"disponível: {ListaDeCarros[opcaoLinha, 2]}.");

                Console.WriteLine("\r\nInforme o dado que deseja modificar:");
                Console.WriteLine("1 - Nome   2 - Ano   3 - Disponibilidade");

                int.TryParse(Console.ReadKey().KeyChar.ToString(), out opcaoColuna);
            }
            
            Introducao();

            if (opcaoColuna == 1)
            {
                Console.WriteLine("Informe o nome do carro:");
                ListaDeCarros[opcaoLinha, 0] = FormatarNome(Console.ReadLine());
            }
            else if(opcaoColuna == 2)
            {
                Console.WriteLine("Informe o ano do carro:");
                ListaDeCarros[opcaoLinha, 1] = FormatarNome(Console.ReadLine());
            }
            else if (opcaoColuna == 3)
            {
                Console.WriteLine("Informe a disponibilidade do carro: 1 - sim   2 - não");

                int opcaoDisponibilidade = 666;

                while (opcaoDisponibilidade != 1 && opcaoDisponibilidade != 2)
                {
                    Introducao();

                    Console.WriteLine("\r\nInforme a disponibilidade do carro: 1 - sim   2 - não");

                    int.TryParse(Console.ReadKey().KeyChar.ToString(), out opcaoDisponibilidade);
                }

                if (opcaoDisponibilidade == 1)
                {
                    if (PesquisarCarro(ListaDeCarros[opcaoLinha, 0]) == true)
                        Console.WriteLine("\rO carro já estava disponível!");
                    else
                    {
                        Console.WriteLine("\rAlterado com sucesso!");
                        ListaDeCarros[opcaoLinha, 2] = "Sim";
                    }
                }
                else
                {
                    if (PesquisarCarro(ListaDeCarros[opcaoLinha, 0]) == false)
                        Console.WriteLine("\rO carro já estava indisponível!");
                    else
                    {
                        Console.WriteLine("\rAlterado com sucesso!");
                        ListaDeCarros[opcaoLinha, 2] = "Não";
                    }
                }
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
        /// <summary>
        /// Transforma uma palavra de modo que sua primeira letra seja maiúscula e as outras minúsculas.
        /// </summary>
        /// <param name="nome">Palavra escolhida.</param>
        /// <returns>Retorna a palavra com as modificações especificadas.</returns>
        public static string FormatarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return string.Empty;
            }

            char[] letra = nome.ToCharArray();

            for (int i = 0; i < letra.Length; i++)
                letra[i] = char.ToLower(letra[i]);

            letra[0] = char.ToUpper(letra[0]);
            return new string(letra).Replace(" ","");
        }
        /// <summary>
        /// Compara duas strings deixando-as em letras minúsculas e removendos espaços.
        /// </summary>
        /// <param name="primeiro">Primeira string a ser comparada.</param>
        /// <param name="segundo">Segunda string a ser comparada.</param>
        /// <returns>Retorna o resultado da comparação.</returns>
        public static bool ComparaNomes(string primeiro, string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "") == segundo.ToLower().Replace(" ",""))
                return true;

            return false;
        }
        /// <summary>
        /// Verifica se a escolha do usuário é válida.
        /// </summary>
        /// <param name="escolha">Escolha definida pelo usuário.</param>
        /// <param name="tamanho">Limite de escolha.</param>
        /// <returns>Retorna se a escolha é válida ou não.</returns>
        public static int VerificaEscolha(int escolha, int tamanho)
        {
            while (escolha > tamanho || escolha < 1)
            {
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out escolha);
            }

            return escolha;
        }
        /// <summary>
        /// Finaliza o programa...
        /// </summary>
        public static void FinalizarSistema()
        {
            var n = 0;
            while (n != 666)
            {
                Console.WriteLine("");
                Console.WriteLine("  ______                        |");
                Console.WriteLine(" /|_|||_ |_                     |");
                Console.WriteLine("(   _    _ _)                   |");
                Console.WriteLine("=`-(_)--(_)-'                   |");
                Console.WriteLine("\r\n                   Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("   ______                       |");
                Console.WriteLine("  /|_|||_ |_                    |");
                Console.WriteLine(" (   _    _ _)                  |");
                Console.WriteLine(" =`-(_)--(_)-'                  |");
                Console.WriteLine("\r\n                  Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("    ______                      |");
                Console.WriteLine("   /|_|||_ |_                   |");
                Console.WriteLine("  (   _    _ _)                 |");
                Console.WriteLine("  =`-(_)--(_)-'                 |");
                Console.WriteLine("\r\n                 Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("     ______                     |");
                Console.WriteLine("    /|_|||_ |_                  |");
                Console.WriteLine("   (   _    _ _)                |");
                Console.WriteLine("   =`-(_)--(_)-'                |");
                Console.WriteLine("\r\n                Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("      ______                    |");
                Console.WriteLine("     /|_|||_ |_                 |");
                Console.WriteLine("    (   _    _ _)               |");
                Console.WriteLine("    =`-(_)--(_)-'               |");
                Console.WriteLine("\r\n               Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("       ______                   |");
                Console.WriteLine("      /|_|||_ |_                |");
                Console.WriteLine("     (   _    _ _)              |");
                Console.WriteLine("     =`-(_)--(_)-'              |");
                Console.WriteLine("\r\n              Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("        ______                  |");
                Console.WriteLine("       /|_|||_ |_               |");
                Console.WriteLine("      (   _    _ _)             |");
                Console.WriteLine("      =`-(_)--(_)-'             |");
                Console.WriteLine("\r\n             Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("         ______                 |");
                Console.WriteLine("        /|_|||_ |_              |");
                Console.WriteLine("       (   _    _ _)            |");
                Console.WriteLine("       =`-(_)--(_)-'            |");
                Console.WriteLine("\r\n            Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("          ______                |");
                Console.WriteLine("         /|_|||_ |_             |");
                Console.WriteLine("        (   _    _ _)           |");
                Console.WriteLine("        =`-(_)--(_)-'           |");
                Console.WriteLine("\r\n           Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("           ______               |");
                Console.WriteLine("          /|_|||_ |_            |");
                Console.WriteLine("         (   _    _ _)          |");
                Console.WriteLine("         =`-(_)--(_)-'          |");
                Console.WriteLine("\r\n          Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("            ______              |");
                Console.WriteLine("           /|_|||_ |_           |");
                Console.WriteLine("          (   _    _ _)         |");
                Console.WriteLine("          =`-(_)--(_)-'         |");
                Console.WriteLine("\r\n         Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("             ______             |");
                Console.WriteLine("            /|_|||_ |_          |");
                Console.WriteLine("           (   _    _ _)        |");
                Console.WriteLine("           =`-(_)--(_)-'        |");
                Console.WriteLine("\r\n        Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("              ______            |");
                Console.WriteLine("             /|_|||_ |_         |");
                Console.WriteLine("            (   _    _ _)       |");
                Console.WriteLine("            =`-(_)--(_)-'       |");
                Console.WriteLine("\r\n       Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("               ______           |");
                Console.WriteLine("              /|_|||_ |_        |");
                Console.WriteLine("             (   _    _ _)      |");
                Console.WriteLine("             =`-(_)--(_)-'      |");
                Console.WriteLine("\r\n      Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("                ______          |");
                Console.WriteLine("               /|_|||_ |_       |");
                Console.WriteLine("              (   _    _ _)     |");
                Console.WriteLine("              =`-(_)--(_)-'     |");
                Console.WriteLine("\r\n     Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("                 ______         |");
                Console.WriteLine("                /|_|||_ |_      |");
                Console.WriteLine("               (   _    _ _)    |");
                Console.WriteLine("               =`-(_)--(_)-'    |");
                Console.WriteLine("\r\n    Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("                  ______        |");
                Console.WriteLine("                 /|_|||_ |_     |");
                Console.WriteLine("                (   _    _ _)   |");
                Console.WriteLine("                =`-(_)--(_)-'   |");
                Console.WriteLine("\r\n   Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("                   ______       |");
                Console.WriteLine("                  /|_|||_ |_    |");
                Console.WriteLine("                 (   _    _ _)  |");
                Console.WriteLine("                 =`-(_)--(_)-'  |");
                Console.WriteLine("\r\n  Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("                    ______      |");
                Console.WriteLine("                   /|_|||_ |_   |");
                Console.WriteLine("                  (   _    _ _) |");
                Console.WriteLine("                  =`-(_)--(_)-' |");
                Console.WriteLine("\r\n Finalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("                     ______     |");
                Console.WriteLine("                    /|_|||_ |_  |");
                Console.WriteLine("                   (   _    _ _)|");
                Console.WriteLine("                   =`-(_)--(_)-'|");
                Console.WriteLine("\r\nFinalizando o sistema...");
                Thread.Sleep(10);
                Console.Clear();

                Environment.Exit(0);
            }
        }
    }
}