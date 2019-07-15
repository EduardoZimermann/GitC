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

            //Aqui como estamos usando apenas uma referência da nossa lista colocamos ref ao passar ela no método MAIN
            CarregaInformaoesEListaElasEmTela(ref listaDeNomes);

            //Após carregar as informações e mostrar em tela ele espera um comando
            Console.ReadKey();

            //Incdicamos que o usuário precisa informar um número de identificação para pesquisar um registro.
            Console.WriteLine("Informe o ID do registro a ser pesquisado.");
            //Aqui como realizamos a pesquisa somente na chamada
            //passamos a nossa lista normalmente pois não iremos alterar e apenas pesquisar a informação
            //após a vírgula temos o console readline que espera nosso identificados único
            PesquisandoInformacoesNaNossaLista(listaDeNomes, Console.ReadLine());

            Console.ReadKey();
        }
        /// <summary>
        /// Método usado para carregar as informações iniciais da nossa coleção.
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada.</param>
        public static void CarregaInformaoesEListaElasEmTela(ref string[,] arrayBi)
        {
            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o 
            //GetLength com o parâmetro "0" para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identificador do nosso registro único
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra para deixar legal
                arrayBi[i, 1] = $"Eduardo_{i}";
            }

            //Lembrando que GetLength é um método e usamos "(parâmetro)" com parâmetro ou as vezes sem
            //para realizar a chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
            }
        }
        /// <summary>
        /// Método que realiza a pesquisa pelo identificador único de nossa coleção.
        /// </summary>
        /// <param name="arrayBi">Nossa coleção de informações.</param>
        /// <param name="pId">Nosso identificador único.</param>
        public static void PesquisandoInformacoesNaNossaLista(string[,] arrayBi,string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparação dos mesmos tipos
                if (arrayBi[i, 0] == pId)
                {//Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida: Id:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
                    //Aqui saimos da nossa lista mas retornamos vazio "return;" pois estamos em um método
                    //vazio "void" que não espera retornar algo;
                    return;
                }
            }

            //Caso ele passe por esta linha identificamos que ele não encontrou resultados compatíveis
            Console.WriteLine("Infelizmente a busca pelo Id não resultou em nenhuma informação.");
        }
    }
}
