using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimClasse
{
    class Boletim
    {
        public double CalcularMedia(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public int CalcularFrequencia(int aulas, int faltas)
        {
            return ((aulas - faltas) * 100) / aulas;
        }

        public void MostrarInformacoes(double media, int frequencia)
        {
            Console.Clear();
            Console.WriteLine($"Média: {string.Format("{0:0.00}", media)}");
            Console.WriteLine($"Frequência: {frequencia}%");
            Console.ReadKey();
        }
    }
}
