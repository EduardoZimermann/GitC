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
            Boletim aluno = new Boletim();

            Console.WriteLine("Informe as 3 notas do aluno:");

            var media = aluno.CalcularMedia(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Console.WriteLine("Informe o total de aulas e o número de faltas do aluno:");

            var frequencia = aluno.CalcularFrequencia(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            aluno.MostrarInformacoes(media, frequencia);
        }
    }
}
