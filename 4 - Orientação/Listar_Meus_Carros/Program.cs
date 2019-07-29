using Listar_Meus_Carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_Meus_Carros
{
    class Program
    {
        static List<Carro> carro = new List<Carro>();
        static void Main(string[] args)
        {
            var palmeirasNaoTemMundial = true;

            while (palmeirasNaoTemMundial)
            {
                switch (Menu())
                {
                    case 1:
                        MostrarLista();
                        break;
                    case 2:
                        AdicionarCarro();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static int Menu()
        {
            Console.Clear();

            Console.WriteLine("Informe a opção desejada:" +
                "\r\n1 - Listar Carros" +
                "\r\n2 - Adicionar Veículos" +
                "\r\n3 - Sair do Sistema\r\n");

            return int.Parse(Console.ReadLine());
        }

        static void MostrarLista()
        {
            foreach (Carro item in carro)
                Console.WriteLine(string.Format("Modelo: {0,12} | Ano: {1,5} | Placa: {2,8} | Cavalos: {3,4}", item.Modelo, item.Ano, item.Placa, item.Cavalos));

            Console.ReadKey();
        }

        static void AdicionarCarro()
        {
            carro.Add(new Carro
            {
                Modelo = RetornaValores("Modelo"),
                Ano = int.Parse(RetornaValores("Ano")),
                Placa = RetornaValores("Placa"),
                Cavalos = int.Parse(RetornaValores("Cavalos"))
            });

            Console.WriteLine("Adicionado com sucesso!");
            Console.ReadKey();
        }

        static string RetornaValores(string nomeCampo)
        {
            Console.WriteLine($"\r\nInforme um valor para o campo: {nomeCampo}");
            return Console.ReadLine();
        }
    }
}
