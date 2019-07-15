using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensão
            string[,] listaDeNomes = new string[5, 2];

            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o 
            //GetLength com o parâmetro "0" para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identificador do nosso registro único
                listaDeNomes[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra para deixar legal
                listaDeNomes[i, 1] = $"Eduardo_{i}";
            }

            //Lembrando que GetLength é um método e usamos "(parâmetro)" com parâmetro ou as vezes sem
            //para realizar a chamada do mesmo
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{listaDeNomes[i, 0]} - Nome:{listaDeNomes[i, 1]}");
            }

            Console.ReadKey();
        }
    }
}
