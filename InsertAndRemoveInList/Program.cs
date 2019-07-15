using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRemoveInList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criamos a nossa base de dados inicial
            string[,] baseDeDados = new string[2, 3];
            //Indicador dos registros realizados em nosso sistema
            int IndiceBaseDados = 0;
            //Apresentação inicil do nosso sistema
            Console.WriteLine("Iniciando sistema de lista de nome e idade:");
            //Criamos a variável fora para não ser criada novamente
            var escolhaInicial = ApresentaMenuInicial();
            //Loop infinito até que de uma treta
            while (true)
            {
                //Iniciando a escolha do nosso menu
                switch (escolhaInicial)
                {
                    //1- Insere as informações
                    case "1": { InserirValoresNaLista(ref baseDeDados, ref IndiceBaseDados); } break;
                    //2- Remove informações da nossa lista
                    case "2": { RemoverInformacoes(ref baseDeDados); } break;
                    //3- Lista as informações da lista
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                    //4- Sai do nosso sistema
                    case "4": {
                            //Return dentro do nosso caso de escolha ele sai do nosso método principal ou
                            //método que estamos dentro de contexto
                            return;
                        }
                }
                //Alimento a escolha novamente
                escolhaInicial = ApresentaMenuInicial();
            }
        }
        /// <summary>
        /// Apresenta as informações do menu inicial.
        /// </summary>
        /// <returns>Retorna o menu escolhido.</returns>
        public static string ApresentaMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir um novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada:");
            //Retorna diretamente o menu escolhido.
            return Console.ReadLine();
        }
        /// <summary>
        /// Método que insere informações dentro da nossa base de dados.
        /// </summary>
        /// <param name="BaseDeDados">Base de dados como ref para alterar para todos os métodos</param>
        /// <param name="indiceBase">Índice da nossa base como red para alterar para todos os métodos.</param>
        public static void InserirValoresNaLista(ref string[,] BaseDeDados, ref int indiceBase)
        {
            Console.WriteLine("---------Inserindo valores na lista---------");

            Console.WriteLine("Informe um nome:");
            //Pegamos a informação digitada pelo usuário, aqui neste elemento esperamos o nome da pessoa
            var nome = Console.ReadLine();

            Console.WriteLine("Infome a idade");
            //Aqui pegamos a idade da pessoa digitada pelo usuário do sistema
            var idade = Console.ReadLine();
            //Aumenta o tamanho da nossa lista quando chegou no limite.
            AumentaTamanhoLista(ref BaseDeDados);

            //Iniciamos o laço de repetição para varrer nossa base de dados
            for (int i = 0; i < BaseDeDados.GetLength(0); i++)
            {
                if (BaseDeDados[i, 0] != null)
                    continue;
                //Identificamos de maneira única nosso registro "(" e ")" garante que ele incremente primeiro
                //antes de fazer a conversão para string
                BaseDeDados[i, 0] = (indiceBase++).ToString();
                //Carregamos na segunda coluna o valor do nome
                BaseDeDados[i, 1] = nome;
                //Carregamos na terceira coluna o valor da idade
                BaseDeDados[i, 2] = idade;
                //Finalizamos aqui para apenas inserir um registro por vez
                break;
            }
            //Informamos para o usuário que finalizou o registro e agora o mesmo irá voltar para o menu inicial
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Mostra as informações dentro da nossa lista de dados "base de dados"
        /// </summary>
        /// <param name="BaseDeDados">Base de dados para a leitura e mostrar pro úsuário.</param>
        public static void MostrarInformacoes(string[,] BaseDeDados)
        {
            Console.WriteLine("Apresentação das informações dentro da base de dados.");

            for (int i = 0; i < BaseDeDados.GetLength(0); i++)
                Console.WriteLine($"- ID: {BaseDeDados[i, 0]} " +
                    $"- Nome: {BaseDeDados[i, 1]} " +
                    $"- Idade: {BaseDeDados[i, 2]}");

            //Finalizamos a operação e indicamos que não existe mais operações a serem realizadas em
            //nosso método.
            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Método utilizado para remover um registro pelo id dentro do sistema
        /// </summary>
        /// <param name="baseDeDados">Base de dados em que ele irá remover o registro pelo id</param>
        public static void RemoverInformacoes(ref string[,] BaseDeDados)
        {
            Console.WriteLine("Área de remoção de registro do sistema.");

            for (int i = 0; i < BaseDeDados.GetLength(0); i++)
                Console.WriteLine($"-ID: {BaseDeDados[i,0]} " +
                    $"- Nome: {BaseDeDados[i, 1]} " +
                    $"- Idade: {BaseDeDados[i, 2]}");
            //Indicamos para o usuário informar um id dentro do nosso sistema para remover
            Console.WriteLine("Informe o id do registro a ser removido:");
            var id = Console.ReadLine();
            //Outro laço agora para remover o registro caso o mesmo exista
            for (int i = 0; i < BaseDeDados.GetLength(0); i++)
            {   //Aqui comparamos os registros para validar o id
                //Colocamos um "&&" pois a comparação de um valor string com um valor null
                //pode gerar erro.
                if (BaseDeDados[i, 0] == id)
                {   //Nesta parte limpamos o registro de nossa base de dados
                    BaseDeDados[i, 0] = null;
                    BaseDeDados[i, 1] = null;
                    BaseDeDados[i, 2] = null;
                }
            }

            //Finalizamos as operações desta tela
            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Método que aumenta as informações dispoíveis para cadastro dentro da nossa lista.
        /// </summary>
        /// <param name="BaseDeDados">Retorna nossa base de dados.</param>
        public static void AumentaTamanhoLista(ref string[,] BaseDeDados)
        {
            //Verifica se precisa criar uma lista maior
            var limiteDaLista = true;
            //Laço que verifica se existe registro disponível
            for (int i = 0; i < BaseDeDados.GetLength(0); i++)
            {
                //Caso ainda existir registro disponível ele seta nossa variável "limiteDaLista" para false
                if (BaseDeDados[i, 0] == null)
                    limiteDaLista = false;
            }

            //Caso não tenha mais registro nossa variável ficou como true então indica que precisamos aumentar nossa lsita
            if (limiteDaLista)
            {
                //Criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = BaseDeDados;
                //Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaços
                BaseDeDados = new string[BaseDeDados.GetLength(0) + 5, 3];
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador único
                    BaseDeDados[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    BaseDeDados[i, 1] = listaCopia[i, 1];
                }
                //Indicamos que neste ponto a lista foi atualizada em seu tamanho.
                Console.WriteLine("O tamanho da lista foi aumentado!");
            }
        }
    }
}
