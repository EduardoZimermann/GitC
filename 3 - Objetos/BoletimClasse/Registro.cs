using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimClasse
{
    class Registro
    {
        private string[,] aluno = new string[1,4];

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

            aluno = new string[aluno.GetLength(0) + 1, 4];

            for (int i = 0; i < listaCopia.GetLength(0); i++)
            {
                aluno[i, 0] = listaCopia[i, 0];
                aluno[i, 1] = listaCopia[i, 1];
                aluno[i, 2] = listaCopia[i, 2];
                aluno[i, 3] = listaCopia[i, 3];
            }
        }

        /// <summary>
        /// Mostra a lista de alunos na tela do usuário.
        /// </summary>
        public void MostrarInformacoes()
        {
            Console.Clear();

            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(aluno[i, 0]) && !string.IsNullOrWhiteSpace(aluno[i,0]))
                {
                    string situacao;

                    if (double.Parse(aluno[i, 2]) >= 7 && int.Parse(aluno[i, 3]) >= 75)
                        situacao = "Aprovado. Parabéns!!! =) =)";
                    else
                        situacao = "Reprovado. =(";

                    Console.WriteLine($"Id: {aluno[i, 0]}");
                    Console.WriteLine($"Aluno: {aluno[i, 1]}");
                    Console.WriteLine($"Média: {string.Format("{0:0.00}", double.Parse(aluno[i, 2]))}");
                    Console.WriteLine($"Frequência: {aluno[i, 3]}%");
                    Console.WriteLine($"{situacao}\r\n");
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Realiza a exclusão de um registro que o usuário escolher.
        /// </summary>
        public void ExcluirRegistro()
        {
            Console.Clear();

            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(aluno[i, 0]) || !string.IsNullOrWhiteSpace(aluno[i, 0]))
                {
                    Console.WriteLine($"Id: {aluno[i, 0]}");
                    Console.WriteLine($"Aluno: {aluno[i, 1]}");
                    Console.WriteLine($"Média: {string.Format("{0:0.00}", aluno[i, 2])}");
                    Console.WriteLine($"Frequência: {aluno[i, 3]}%\r\n");
                }
            }

            Console.WriteLine("Informe o Id do registro que desejas excluir:");
            int.TryParse(Console.ReadLine(), out int opcaoExcluir);

            aluno[opcaoExcluir, 0] = null;
            aluno[opcaoExcluir, 1] = null;
            aluno[opcaoExcluir, 2] = null;
            aluno[opcaoExcluir, 3] = null;
        }

        /// <summary>
        /// Realiza a modificação de algum registro que o usuário escolher.
        /// </summary>
        public void AlterarRegistro()
        {
            Console.Clear();

            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(aluno[i, 0]) && !string.IsNullOrWhiteSpace(aluno[i, 0]))
                {
                    Console.WriteLine($"Id: {aluno[i, 0]}");
                    Console.WriteLine($"Aluno: {aluno[i, 1]}");
                    Console.WriteLine($"Média: {string.Format("{0:0.00}", aluno[i, 2])}");
                    Console.WriteLine($"Frequência: {aluno[i, 3]}%\r\n");
                }
            }

            Console.WriteLine("Informe o Id do registro que desejas alterar:");
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
