using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class Program
    {
        static string[,] listaAlunos;
        static void Main(string[] args)
        {
            CarregarLista();

            for (int i = 0; i < listaAlunos.GetLength(0); i++)
                Console.WriteLine($"\r\nNome: {listaAlunos[i, 0]}, idade: {listaAlunos[i, 1]}, sexo: {listaAlunos[i, 2]}.");

            Console.ReadKey();
        }
        /// <summary>
        /// Atribui valores à lista de alunos.
        /// </summary>
        public static void CarregarLista()
        {
            listaAlunos = new string[20, 3]
            {
                {"Adriana","16","Feminino"},
                {"Alice","15","Feminino"},
                {"Arnaldo","15","Masculino"},
                {"Arthur","15","Masculino"},
                {"Beatriz","16","Feminino"},
                {"Cesar","15","Masculino"},
                {"Guilherme","15","Masculino"},
                {"Gustavo","16","Masculino"},
                {"Jair","16","Masculino"},
                {"Júlia","16","Feminino"},
                {"Juliana","15","Feminino"},
                {"Larissa","17","Feminino"},
                {"Laura","15","Feminino"},
                {"Lucas","16","Masculino"},
                {"Maria","15","Feminino"},
                {"Miguel","16","Masculino"},
                {"Rafael","16","Masculino"},
                {"Sandra","16","Feminino"},
                {"Sofia","15","Feminino"},
                {"Willian","17","Masculino"},
            };
        }
    }
}
