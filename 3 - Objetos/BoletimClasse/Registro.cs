﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimClasse
{
    class Registro
    {
        private string[,] aluno = new string[1,5];

        private Boletim boletim = new Boletim();

        private int indice = 0;

        /// <summary>
        /// Realiza o registro de nome, notas e frequência do aluno.
        /// </summary>
        public void RegistrarAluno()
        {
            Console.Clear();

            AumentaRegistro();

            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                if (aluno[i,0] == null)
                {
                    aluno[i, 0] = indice.ToString();

                    indice++;

                    Console.WriteLine($"Informe o nome do aluno: ");
                    aluno[i, 1] = Console.ReadLine();

                    Console.WriteLine($"Informe as 3 notas do aluno:");

                    aluno[i, 2] = boletim.CalcularMedia(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())).ToString();

                    Console.WriteLine($"Informe o total de aulas e o número de faltas do aluno:");

                    aluno[i, 3] = boletim.CalcularFrequencia(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())).ToString();

                    break;
                }
            }
        }

        /// <summary>
        /// Aumenta o tamanho da lista de alunos caso necessário.
        /// </summary>
        public void AumentaRegistro()
        {
            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                if (aluno[i, 0] == null)
                    return;
            }

            var listaCopia = aluno;

            aluno = new string[aluno.GetLength(0) + 1, 5];

            for (int i = 0; i < listaCopia.GetLength(0); i++)
            {
                aluno[i, 0] = listaCopia[i, 0];
                aluno[i, 1] = listaCopia[i, 1];
                aluno[i, 2] = listaCopia[i, 2];
                aluno[i, 3] = listaCopia[i, 3];
                aluno[i, 4] = listaCopia[i, 4];
            }
        }

        /// <summary>
        /// Mostra a lista de alunos na tela do usuário.
        /// </summary>
        public void MostrarInformacoes()
        {
            Console.Clear();

            Console.WriteLine("\r\n   ID |         Aluno |   Média |    Frequência |        Situação");

            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(aluno[i, 0]) && !string.IsNullOrWhiteSpace(aluno[i,0]))
                {
                    aluno[i,4] = boletim.RetornaSituacao(aluno[i, 2], aluno[i, 3]);

                    Console.WriteLine(string.Format("{0,5} | {1,13} | {2,7} | {3,12}% | {4,15}", aluno[i, 0], aluno[i, 1], string.Format("{0:0.00}", double.Parse(aluno[i, 2])), aluno[i, 3], aluno[i, 4]));
                }
            }
        }

        /// <summary>
        /// Realiza a exclusão de um registro que o usuário escolher.
        /// </summary>
        public void ExcluirRegistro()
        {
            MostrarInformacoes();

            Console.WriteLine("\r\nInforme o Id do registro que desejas excluir:");
            int.TryParse(Console.ReadLine(), out int opcaoExcluir);

            try
            {
                aluno[opcaoExcluir, 0] = null;
                aluno[opcaoExcluir, 1] = null;
                aluno[opcaoExcluir, 2] = null;
                aluno[opcaoExcluir, 3] = null;
                Console.WriteLine("Registro excluido com sucesso!");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Aluno não encontrado!");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Realiza a modificação de algum registro que o usuário escolher.
        /// </summary>
        public void AlterarRegistro()
        {
            MostrarInformacoes();

            Console.WriteLine("\r\nInforme o Id do registro que desejas alterar:");
            int.TryParse(Console.ReadLine(), out int opcaoAlterar);

            Console.WriteLine("Informe o nome deste aluno:");
            aluno[opcaoAlterar, 1] = Console.ReadLine();

            Console.WriteLine("Informe as 3 notas do aluno escolhido:");
            aluno[opcaoAlterar, 2] = boletim.CalcularMedia(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())).ToString();

            Console.WriteLine("Informe a quantidade de aulas e faltas do aluno escolhido:");
            aluno[opcaoAlterar, 3] = boletim.CalcularFrequencia(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())).ToString();
        }
    }
}
