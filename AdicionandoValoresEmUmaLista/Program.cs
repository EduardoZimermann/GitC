﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Manualmente
namespace AdicionandoValoresEmUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da nossa lista o.0
            string[,] listaDeNomes = new string[2, 2];
            //Aqui vamos criar uma forma externa de identificar nossos registros
            int IdParaLista = 0;
            //Chamada no nosso método para inserir registro passando por meio de referência
            //nossos dois itens, lista de nomes e nosso identificador único.
            InsereRegistro(ref listaDeNomes, ref IdParaLista);

            Console.ReadKey();
            //Aqui acionamos novamente nosso insere registros
            InsereRegistro(ref listaDeNomes, ref IdParaLista);

            Console.ReadKey();
        }
        /// <summary>
        /// Método que insere novo registro
        /// </summary>
        /// <param name="listaDeNomes">Nossa lista de nomes vazia ou não</param>
        /// <param name="IdParaLista">Nossa referência externa de ID</param>
        public static void InsereRegistro(ref string[,] listaDeNomes, ref int IdParaLista)
        {
            //Aqui estaremos em um laço para informar nossos registros
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                //Aqui definimos que o mesmo deve continuar para o próximo registro
                //pois esse registro já está ocupado
                if (listaDeNomes[i, 0] != null)
                    continue;
                //Indicamos que ele deve apenas informar o nome do nosso registro
                Console.WriteLine("\r\nInforma um nome para adicionar um registro:");
                var nome = Console.ReadLine();
                //Ciramos o nosso identificador único com um objeto externo que
                //mesmo após sairmos do nosso laço ainda poderar ser incrementado
                listaDeNomes[i, 0] = (IdParaLista++).ToString();
                //Aqui colocamos nosso nome na lista
                listaDeNomes[i, 1] = nome;

                //Identificamos se o mesmo ainda deseja inserir registros dentro da nossa lista
                Console.WriteLine("Deseja inserir um novo registro? sim(1) ou não(0)");
                //O readkey só espera uma única tecla e nos retorna a tecla que foi acionada e não o valor dela
                //Por isso usamos o KeyChar para pegar esse valor e converter ele em um string para comparação
                var continuar = Console.ReadKey().KeyChar.ToString();
                //Aqui validamos a condição se o mesmo deve ou não continuar a adicionar registro até que a nossa
                //Lista esteja completa de informações
                if (continuar == "0")
                    break; //Break é uma palavra reservada do c# que para, por isso break, todo laço de repetição
                //ou sequenciador lógico o.0.

                //Terceira camada da deepweb aqui
                AumentaTamanhoLista(ref listaDeNomes);
            }

            Console.WriteLine("Registro adicionados com sucesso, segue lista de informações adicionadas:");

            //Mas agora a coisa muda,
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
                //Utilizamos o string format, basicamente ele faz da mesmo forma que o sifrão
                //a diferença entre eles é que este é um cara que em grande quantidades
                //acaba sendo mais rápido
                Console.WriteLine(string.Format("Registro ID: {0} - Nome: {1}", listaDeNomes[i, 0], listaDeNomes[i, 1]));
        }

        public static void AumentaTamanhoLista(ref string[,] ListaDeNome)
        {
            //Verifica se precisa criar uma lista maior
            var limiteDaLista = true;
            //Laço que verifica se existe registro disponível
            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                //Caso ainda existir registro disponível ele seta nossa variável "limiteDaLista" para false
                if (ListaDeNome[i, 0] == null)
                    limiteDaLista = false;
            }

            //Caso não tenha mais registro nossa variável ficou como true então indica que precisamos aumentar nossa lsita
            if (limiteDaLista)
            {
                //Criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = ListaDeNome;
                //Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaços
                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 2];
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador único
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                }
                //Indicamos que neste ponto a lista foi atualizada em seu tamanho.
                Console.WriteLine("");
            }
        }
    }
}
