using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Carrega
{
    class CarregarLista
    {
        string[,] listaDeNomes;

        /// <summary>
        /// Retorna a lista de nomes apenas como leitura
        /// </summary>
        public string[,] ListaNome { get { return listaDeNomes; } }

        /// <summary>
        /// Nosso Método construtor que sempre recebe o nome da classe
        /// </summary>
        /// <param name="arrayBi"Array que já deve estar assinada></param>
        public CarregarLista()
        {
            //Asinamos nossa lista no método construtor
            //com isso já deixamos a lista pronta para uso nos demais métodos
            //sem precisar de um parâmetro para isso
            listaDeNomes = new string[10, 2];
        }

        /// <summary>
        /// Método usado para carregar as informações iniciais da nossa coleção.
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada.</param>
        public void CarregaInformaoesEListaElasEmTela()
        {
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
        }
    }
}
