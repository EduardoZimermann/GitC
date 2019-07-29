using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static List<Lanche> minhaLista = new List<Lanche>();

        static void Main(string[] args)
        {
            AdicionarElementosNaMinhaListaDeLanches();

            Console.Clear();

            MostrarLista();

            Console.ReadKey();
        }

        static void AdicionarElementosNaMinhaListaDeLanches()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();

                minhaLista.Add(new Lanche
                {
                    Nome = RetornaValores("Nome"),
                    Quantidade = int.Parse(RetornaValores("Quantidade")),
                    Valor = double.Parse(RetornaValores("Valor"))
                });

                Console.WriteLine("\r\nItem adicionado com sucesso");
                Console.ReadKey();
            }
        }

        public static string RetornaValores(string nomeCampo)
        {
            Console.WriteLine($"Informe o valor para o campo: {nomeCampo}");
            return Console.ReadLine();
        }

        static void MostrarLista()
        {
            foreach (Lanche item in minhaLista)
                Console.WriteLine(string.Format("Nome: {0,15} | " +
                    "Quantidade: {1,3} | " +
                    "Valor: R${2,5:N2}", item.Nome, item.Quantidade, item.Valor));
        }
    }
}
