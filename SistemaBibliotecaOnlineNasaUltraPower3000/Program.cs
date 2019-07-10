﻿using System;
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

            MostrarSejaBemVindo();

            if(MenuInicial() == 1)
            {
                Console.Clear();

                MostrarSejaBemVindo();

                Console.WriteLine("Menu - Alocação de livros");
                Console.WriteLine("Digite o nome do livro a ser alocado:");

                var nomeDoLivro = Console.ReadLine();
                if (PesquisaLivroParaAlocacao(nomeDoLivro))
                {
                    Console.Clear();
                    Console.WriteLine("Você deseja alocar o livro?   1 - sim    2 - não");

                    if (Console.ReadKey().KeyChar.ToString() == "1")
                    {
                        AlocarLivro(nomeDoLivro);
                        Console.Clear();
                        Console.WriteLine("Livro alocado com sucesso!");
                    }
                    else
                        Console.Clear();

                    Console.WriteLine("Listagem de livros:");

                    for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                    {
                        Console.WriteLine($"Nome: {baseDeLivros[i,0]}. Disponível: {baseDeLivros[i,1]}");
                    }
                }
            }

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
        public static int MenuInicial()
        {
            Console.WriteLine("\r\nMenu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Sair do sistema.");
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
        /// Método que retorno se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado.</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver disponível.</returns>
        public static bool PesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    Console.WriteLine($"O livro '{nomeLivro}' pode ser alocado? {baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "Sim!";
                }
            }

            return false;
        }
        /// <summary>
        /// Método que aloca o livro de acordo com o parâmetro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>
        public static void AlocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = "Não!";
            }
        }
    }
}
