using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoLista
{
    class Cadastro
    {
        private string[,] carro = new string[1, 6];

        private int indice = 0;

        public void RegistrarCarro()
        {
            Console.Clear();

            AumentaLista();

            for (int i = 0; i < carro.GetLength(0); i++)
            {
                if (carro[i, 0] == null)
                {
                    carro[i, 0] = indice.ToString();

                    indice++;

                    Console.WriteLine("Informe a placa do carro:");
                    var placa = Console.ReadLine();

                    for (int j = 0; j < carro.GetLength(0); j++)
                    {
                        if (carro[i,2] == placa)
                        {
                            Console.WriteLine("Placa já registrada!");
                            Console.ReadKey();
                            return;
                        }
                    }

                    carro[i, 2] = placa;

                    Console.WriteLine("Informe o modelo do carro:");
                    carro[i, 1] = Console.ReadLine();

                    carro[i, 3] = DateTime.Now.ToString("HH:mm:ss");

                    carro[i, 5] = "true";

                    Console.WriteLine("\r\nCarro registrado com sucesso!");
                    Console.ReadKey();

                    break;
                }
            }
        }

        public void AumentaLista()
        {
            for (int i = 0; i < carro.GetLength(0); i++)
            {
                if (string.IsNullOrEmpty(carro[i, 0]) || string.IsNullOrWhiteSpace(carro[i, 0]))
                    return;
            }

            var listaCopia = carro;

            carro = new string[carro.GetLength(0) + 1, 6];

            for (int i = 0; i < listaCopia.GetLength(0); i++)
            {
                carro[i, 0] = listaCopia[i, 0];
                carro[i, 1] = listaCopia[i, 1];
                carro[i, 2] = listaCopia[i, 2];
                carro[i, 3] = listaCopia[i, 3];
                carro[i, 4] = listaCopia[i, 4];
                carro[i, 5] = listaCopia[i, 5];
            }
        }

        public void SaidaCarro()
        {
            MostrarLista();

            Console.WriteLine("\r\nInforme a placa do carro para realizar a saída:");
            var placa = Console.ReadLine();

            for (int i = 0; i < carro.GetLength(0); i++)
            {
                if (carro[i, 2] == placa && carro[i, 5] == "true")
                {
                    carro[i, 4] = DateTime.Now.ToString("HH:mm:ss");

                    carro[i, 5] = "false";

                    Console.WriteLine("\r\nSaída realizada com sucesso!");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("Placa não encontrada!");
            Console.ReadKey();
        }

        public void MostrarLista()
        {
            Console.Clear();

            Console.WriteLine("\r\n Id |        Modelo |      Placa | Hora Entrada | Hora Saída");

            for (int i = 0; i < carro.GetLength(0); i++)
            {
                if (carro[i, 0] != null && carro[i, 5] == "true")
                {
                    Console.WriteLine(string.Format("{0,3} | {1,13} | {2,10} | {3,12} | {4,10}", 
                        carro[i, 0], carro[i, 1], carro[i, 2], carro[i, 3], carro[i, 4]));
                }
            }
        }

        public void MostrarTudo()
        {
            Console.Clear();

            Console.WriteLine("\r\n Id |        Modelo |      Placa | Hora Entrada | Hora Saída");

            for (int i = 0; i < carro.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(carro[i, 0]) && !string.IsNullOrWhiteSpace(carro[i, 0]))
                {
                    Console.WriteLine(string.Format("{0,3} | {1,13} | {2,10} | {3,12} | {4,10}",
                        carro[i, 0], carro[i, 1], carro[i, 2], carro[i, 3], carro[i, 4]));
                }
            }
        }
    }
}
