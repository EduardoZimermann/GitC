using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeCarros = new string[1, 3];
            int indice = 0;

            Registrar(ref listaDeCarros, ref indice);

            Console.ReadKey();

            AumentaLista(ref listaDeCarros);

            Registrar(ref listaDeCarros, ref indice);

            Console.ReadKey();
        }
        public static void Registrar(ref string[,] ListaDeCarros, ref int Indice)
        {
            for (int i = 0; i < ListaDeCarros.GetLength(0); i++)
            {
                Console.Clear();
                if (!string.IsNullOrEmpty(ListaDeCarros[i, 0]))
                    continue;

                ListaDeCarros[i, 0] = (Indice++).ToString();

                Console.WriteLine("Informe o nome do carro:");
                ListaDeCarros[i, 1] = Console.ReadLine();

                Console.WriteLine("Informe o ano de fabricação:");
                ListaDeCarros[i, 2] = Console.ReadLine();

                Console.WriteLine("1 - Continuar registrando   2 - Apagar algum registro   3 - Sair");

                int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

                switch (opcao)
                {
                    case 1:
                        AumentaLista(ref ListaDeCarros);
                        break;
                    case 2:
                        ApagarRegistro(ref ListaDeCarros);
                        break;
                }

                if (opcao == 3)
                    break;
            }

            Console.WriteLine("\r\nRegistro adicionados com sucesso, segue lista de informações adicionadas:");

            MostrarLista(ref ListaDeCarros);
        }
        public static void AumentaLista(ref string[,] ListaDeCarros)
        {
             var listaCopia = ListaDeCarros;

             ListaDeCarros = new string[listaCopia.GetLength(0) + 1, 3];

             for (int i = 0; i < listaCopia.GetLength(0); i++)
             {
                 ListaDeCarros[i, 0] = listaCopia[i, 0];
                 ListaDeCarros[i, 1] = listaCopia[i, 1];
                 ListaDeCarros[i, 2] = listaCopia[i, 2];
             }
        }
        public static void ApagarRegistro(ref string[,] ListaDeCarros)
        {
            MostrarLista(ref ListaDeCarros);
            Console.WriteLine("Informe pelo número qual carro desejas apagar da lista:");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int escolha);

            (ListaDeCarros[escolha, 0]) = string.Empty;
            (ListaDeCarros[escolha, 1]) = string.Empty;
            (ListaDeCarros[escolha, 2]) = string.Empty;

            Console.Clear();

            Console.WriteLine("\r\nAtualizado com sucesso! Segue a lista de carros:");

            MostrarLista(ref ListaDeCarros);

            Console.WriteLine("1 - Continuar registrando   2 - Apagar algum registro   3 - Sair");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            switch (opcao)
            {
                case 1:
                    AumentaLista(ref ListaDeCarros);
                    break;
                case 2:
                    ApagarRegistro(ref ListaDeCarros);
                    break;
                case 3:
                    break;
            }
        }
        public static void MostrarLista(ref string[,] ListaDeCarros)
        {
            for (int i = 0; i < ListaDeCarros.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(ListaDeCarros[i, 0]))
                    Console.WriteLine(string.Format("Registro ID: {0} - Nome: {1}", ListaDeCarros[i, 0], ListaDeCarros[i, 1]));
            }
        }
    }
}
