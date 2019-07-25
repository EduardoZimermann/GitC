using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnlineNasaUltraPower3000
{
    class Program
    {
        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 3)
            {
                if (opcaoMenu == 1)
                    AlocarUmLivro();

                if (opcaoMenu == 2)
                    DesalocarUmLivro();

                opcaoMenu = MenuPrincipal();
            }

            if (opcaoMenu == 1)
                AlocarUmLivro();

            Console.ReadKey();
        }

        /// <summary>
        /// Método que mostra o conteúdo contendo a introdução ao programa.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("         Sistema de alocação de livros.");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("   Desenvolvido pelas indústrias EneEseAaaaa!");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");
        }
        /// <summary>
        /// Método que mostra o conteúdo do menu e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("\r\nMenu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Devolver um livro.");
            Console.WriteLine("3 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Método que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno","Sim!"},
                {"O grande","Não!"}
            };
        }
        /// <summary>
        /// Método que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado.</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver disponível.</returns>
        public static bool? PesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeLivro, baseDeLivros[i, 0]))
                {
                    Console.WriteLine($"O livro '{nomeLivro}' pode ser alocado? {baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "Sim!";
                }
            }

            Console.WriteLine("Nenhum livro encontrado! Deseja realizar a busca novamente?");
            Console.WriteLine("Digite o número da opção desejada: 1 - sim   2 - não");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out var opcao);

            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome do livro a ser pesquisado:");
                nomeLivro = Console.ReadLine();

                return PesquisaLivroParaAlocacao(nomeLivro);
            }

            return null;
        }
        /// <summary>
        /// Método que aloca o livro de acordo com o parâmetro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>
        /// <param name="alocar">Valor booleano que decide se o livro está ou não disponível.</param>
        public static void AlocarLivro(string nomeLivro, bool alocar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeLivro, baseDeLivros[i, 0]))
                {
                    baseDeLivros[i, 1] = alocar ? "Não!" : "Sim!";
                }
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Livro atualizado com sucesso!");
        }
        /// <summary>
        /// Método que carrega o conteúdo inicial da aplicação.
        /// </summary>
        public static void AlocarUmLivro()
        {
            MostrarMenuInicialLivros("Alocar um livro:");

            var nomeDoLivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(nomeDoLivro);

            if (resultadoPesquisa != null && resultadoPesquisa == false)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o livro?   1 - sim    2 - não");

                AlocarLivro(nomeDoLivro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeLivros();

                Console.ReadKey();

            }
        }
        /// <summary>
        /// Método que mostra a lista de livros atualizada.
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            Console.WriteLine("Listagem de livros:");

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeLivros[i, 0]}. Disponível: {baseDeLivros[i, 1]}");
            }
        }
        public static void DesalocarUmLivro()
        {
            MostrarMenuInicialLivros("Desalocar um livro:");

            MostrarListaDeLivros();

            var nomeDoLivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(nomeDoLivro);

            if (resultadoPesquisa != null && resultadoPesquisa == false)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o livro?   1 - sim    2 - não");

                AlocarLivro(nomeDoLivro, Console.ReadKey().KeyChar.ToString() == "2");

                MostrarListaDeLivros();

                Console.ReadKey();
            }
        }
        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do livro para realizar a operação:");
        }
        /// <summary>
        /// Método que compara duas string deixando em caixa baixa e removendo espaços vazio dentro da mesma.
        /// </summary>
        /// <param name="primeiro">Primeira string a ser comparada.</param>
        /// <param name="segundo">Segunda string a ser comparada</param>
        /// <returns>Retorna o resultado desta comparação.</returns>
        public static bool CompararNomes(string primeiro, string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "") == segundo.ToLower().Replace(" ", ""))
                return true;

            return false;
        }
    }
}
