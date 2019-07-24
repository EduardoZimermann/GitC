using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta.BibliotecaListaBi
{
    class ListaBi
    {
        string[,] listaBi;

        /// <summary>
        /// Iniciamos nossa lista bi, agora quando iniciamos uma instância dela ela já
        /// vem com a lista carregada.
        /// </summary>
        public ListaBi()
        {
            listaBi = new string[5, 2];
            //Ao chamar este método no contrutor nossa lista já vai estar carregada
            //ao iniciar a instância "jogar para memória"
            CarregaListaBi();
        }
        /// <summary>
        /// Aqui já carregamos a lista quando chamado este método.
        /// </summary>
        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 1] = $"Eduardo_{i}";
                //Ao adicionar o registro na lista já mostramos na tela
                Console.WriteLine($"Id:{i} Nome:Eduardo_{i}");
            }
        }
        /// <summary>
        /// Aqui temos o metodo que realiza a pesquisa das informações em nossa 
        /// lista 
        /// </summary>
        /// <param name="idPesquisa">Aqui vai o ID da nossa informação</param>
        public void PesquisaLista(string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                if (listaBi[i, 0] == idPesquisa)
                {
                    Console.WriteLine("Resultado encontrado com sucesso!");
                    Console.WriteLine($"Você pesquisou pelo registro:{listaBi[i, 1]}");
                    //Saio do método porque não preciso mais dele
                    //ele é um void "Vazio, sem tipo"
                    return;
                }
            }

            Console.WriteLine("Nenhum registro encontrado com esse Id");
        }
    }
}
