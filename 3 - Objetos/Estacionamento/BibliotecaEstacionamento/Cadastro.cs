using System;

namespace BibliotecaEstacionamento
{
    public class Cadastro
    {
        private string[,] carro = new string[2, 5];

        public void RegistrarCarro()
        {
            for (int i = 0; i < carro.GetLength(0); i++)
            {
                carro[i, 0] = i.ToString();

                Console.WriteLine("Informe o modelo do carro:");
                carro[i, 1] = Console.ReadLine();

                Console.WriteLine("Informe a placa do carro:");
                carro[i, 2] = Console.ReadLine();

                carro[i, 3] = DateTime.Now.ToString("HH:mm:ss");
            }
        }

        public void MostrarLista()
        {
            for (int i = 0; i < carro.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(carro[i, 0]) && !string.IsNullOrWhiteSpace(carro[i, 0]))
                {
                    Console.WriteLine($"Id: {carro[i, 0]}");
                    Console.WriteLine($"Modelo: {carro[i, 1]}");
                    Console.WriteLine($"Placa: {carro[i, 2]}");
                    Console.WriteLine($"Hora Entrada: {carro[i, 3]}");
                    Console.WriteLine($"Hora Saída: {carro[i, 4]}");
                }
            }
        }
    }
}
