using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeLivros = new string[1, 5];
            int indiceLivros = 0;

            string opcao = MenuInicial();

            while (true)
            {
                switch (opcao)
                {
                    case "1":
                        FormatarTitulo("MENU DE REGISTRO");
                        RegistrarLivro(ref listaDeLivros, ref indiceLivros);
                        break;
                    case "2":
                        FormatarTitulo("MENU DE REMOÇÃO");
                        RemoverLivro(ref listaDeLivros);
                        break;
                    case "3":
                        FormatarTitulo("LISTA DE LIVROS REGISTRADOS");
                        MostrarLista(ref listaDeLivros, "true");
                        break;
                    case "4":
                        FormatarTitulo("LISTA DE LIVROS REMOVIDOS");
                        MostrarLista(ref listaDeLivros);
                        break;
                    case "5":
                        return;
                }

                opcao = MenuInicial();
            }
        }
        /// <summary>
        /// Apresenta o menu inicial com as opções disponíveis para o usuário.
        /// </summary>
        /// <returns>Retorna a opção escolhida pelo usuário.</returns>
        public static string MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("             Registro De Livros");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\r\nEscolha a opção desejada:");
            Console.WriteLine("1- Registrar livro.");
            Console.WriteLine("2- Remover livro.");
            Console.WriteLine("3- Listar livros registrados.");
            Console.WriteLine("4- Listar livros removidos.");
            Console.WriteLine("5- Sair do sistema.");

            var opcaoMenu = Console.ReadLine();

            Console.Clear();

            return opcaoMenu;
        }
        /// <summary>
        /// Método responsável por fazer o registro dos livros, atribuindo informações digitadas pelo usuário à variável.
        /// </summary>
        /// <param name="ListaDeLivros">A variável que irá guardar as informações do livro.</param>
        /// <param name="Indice">Índice representa o ID de cada livro.</param>
        public static void RegistrarLivro(ref string[,] ListaDeLivros, ref int Indice)
        {
            AumentaLista(ref ListaDeLivros);

            Console.WriteLine("\r\nDigite o nome do livro:");
            var nomeLivro = Console.ReadLine();
            //Se o usuário não digitar nada, o sistema vai repetir a mensagem até receber um nome válido.
            while (string.IsNullOrEmpty(nomeLivro) || string.IsNullOrWhiteSpace(nomeLivro))
            {
                Console.WriteLine("\r\nDigite o nome do livro:");
                nomeLivro = Console.ReadLine();

            }

            Console.WriteLine("Digite o nome do autor:");
            var nomeAutor = Console.ReadLine();
            //A mesma verificação feita anteriormente
            while (string.IsNullOrEmpty(nomeAutor) || string.IsNullOrWhiteSpace(nomeAutor))
            {
                Console.WriteLine("\r\nDigite o nome do autor:");
                nomeAutor = Console.ReadLine();

            }

            for (int i = 0; i < ListaDeLivros.GetLength(0); i++)
            {
                if (ListaDeLivros[i, 0] != null)
                    continue;

                ListaDeLivros[i, 0] = (Indice++).ToString();
                ListaDeLivros[i, 1] = nomeLivro;
                ListaDeLivros[i, 2] = nomeAutor;
                ListaDeLivros[i, 3] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                ListaDeLivros[i, 4] = "true";

                break;
            }

            Console.WriteLine("\r\nLivro registrado com sucesso.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        /// <summary>
        /// Método responsável por fazer a remoção dos livros registrados, de acordo com a opção definida pelo usuário.
        /// </summary>
        /// <param name="ListaDeLivros">A variável que terá uma de suas informações removida.</param>
        public static void RemoverLivro(ref string[,] ListaDeLivros)
        {
            for (int i = 0; i < ListaDeLivros.GetLength(0); i++)
            {
                if (ListaDeLivros[i, 4] == "true")
                    Console.WriteLine($"- Id: {ListaDeLivros[i, 0]}, " +
                        $"Nome: {ListaDeLivros[i, 1]}, " +
                        $"Autor: {ListaDeLivros[i, 2]}, " +
                        $"Data de modificação: {ListaDeLivros[i, 3]}");
            }
            Console.WriteLine("\r\nSelecione pelo Id o livro que desejas remover da lista.");

            VerificaEscolha(ref ListaDeLivros, Console.ReadLine());

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        /// <summary>
        /// Este método mostra a lista todos livros registrados.
        /// </summary>
        /// <param name="ListaDeLivros">A lista que será mostrada.</param>
        public static void MostrarLista(ref string[,] ListaDeLivros, string LivroRegistrado = "false")
        {
            for (int i = 0; i < ListaDeLivros.GetLength(0); i++)
            {
                if (ListaDeLivros[i, 4] == LivroRegistrado)
                    Console.WriteLine($"- Id: {ListaDeLivros[i, 0]}, " +
                        $"Nome: {ListaDeLivros[i, 1]}, " +
                        $"Autor: {ListaDeLivros[i, 2]}, " +
                        $"Data de modificação: {ListaDeLivros[i, 3]}");
            }

            Console.WriteLine("\r\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        /// <summary>
        /// Verifica se a lista do parâmetro chegou ao limite, e então aumenta o tamanho caso necessário.
        /// </summary>
        /// <param name="ListaDeLivros">A lista a ser verificada.</param>
        public static void AumentaLista(ref string[,] ListaDeLivros)
        {
            bool limite = true;

            for (int i = 0; i < ListaDeLivros.GetLength(0); i++)
            {
                if (ListaDeLivros[i, 0] == null)
                    limite = false;
            }

            if (limite)
            {
                var listaCopia = ListaDeLivros;

                ListaDeLivros = new string[ListaDeLivros.GetLength(0) + 1, ListaDeLivros.GetLength(1)];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    ListaDeLivros[i, 0] = listaCopia[i, 0];
                    ListaDeLivros[i, 1] = listaCopia[i, 1];
                    ListaDeLivros[i, 2] = listaCopia[i, 2];
                    ListaDeLivros[i, 3] = listaCopia[i, 3];
                    ListaDeLivros[i, 4] = listaCopia[i, 4];
                }
            }
        }
        /// <summary>
        /// Verifica se a escolha da remoção de livros é válida.
        /// </summary>
        /// <param name="ListaDeLivros">Usado para comparar com a escolha do usuário.</param>
        /// <param name="escolha">Escolha definida pelo usuário.</param>
        public static void VerificaEscolha(ref string[,] ListaDeLivros, string escolha)
        {
            for (int i = 0; i < ListaDeLivros.GetLength(0); i++)
            {
                if (ListaDeLivros[i, 0] != null && ListaDeLivros[i, 4] == "true" && ListaDeLivros[i, 0] == escolha)
                {
                    ListaDeLivros[i, 3] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    ListaDeLivros[i, 4] = "false";

                    Console.WriteLine("Livro removido com sucesso!");

                    return;
                }
            }

            Console.WriteLine("Opção inválida!");
        }
        /// <summary>
        /// Padroniza a string chamada nesta função.
        /// </summary>
        /// <param name="titulo">String a ser padronizada.</param>
        public static void FormatarTitulo(string titulo)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"             {titulo}");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
