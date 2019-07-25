using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimClasse
{
    class Boletim
    {
        /// <summary>
        /// Calcula a média de um aluno.
        /// </summary>
        /// <param name="nota1">Primeira nota.</param>
        /// <param name="nota2">Segunda nota.</param>
        /// <param name="nota3">Terceira nota.</param>
        /// <returns>Retorna a média do aluno.</returns>
        public double CalcularMedia(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        /// <summary>
        /// Calcula a frequência do aluno.
        /// </summary>
        /// <param name="aulas">Quantidade total de aulas.</param>
        /// <param name="faltas">Quantidade de faltas do aluno.</param>
        /// <returns>Retorna a porcentagem de frequência do aluno.</returns>
        public int CalcularFrequencia(int aulas, int faltas)
        {
            return ((aulas - faltas) * 100) / aulas;
        }

        public string RetornaSituacao(string media, string frequencia)
        {
            if (double.Parse(media) >= 7 && int.Parse(frequencia) >= 75)
                return "Aprovado!";

            return "Reprovado!";
        }
    }
}
