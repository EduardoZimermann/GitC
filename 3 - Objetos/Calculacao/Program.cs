using CalculadoraHB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculacao
{
    class Program
    {
        static Class1 calc = new Class1();
        static void Main(string[] args)
        {
            var poderDeLutaDoKakarotto = "MAIS DE OITO MILLLL!!!!!";

            while (poderDeLutaDoKakarotto == "MAIS DE OITO MILLLL!!!!!")
            {
                Calculos(Menu());
            }
        }

        /// <summary>
        /// Apresenta o menu inicial e pede para o usuário informar sua escolha.
        /// </summary>
        /// <returns>Retorna a escolha do usuário.</returns>
        public static int Menu()
        {
            Console.Clear();

            Console.WriteLine("Informe a opcao desejada:\r\n");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Área retângulo");
            Console.WriteLine("6- Área triângulo equilátero");
            Console.WriteLine("7- Raio de círculo");
            Console.WriteLine("8- Sair do sistema");

            int.TryParse(Console.ReadLine(), out int escolha);

            return escolha;
        }

        /// <summary>
        /// Realiza todo o processo burocrático da comunicação com a classe.
        /// </summary>
        /// <param name="op">A opção definida pelo usuário no menu.</param>
        public static void Calculos(int op)
        {
            Console.Clear();

            switch (op)
            {
                case 1:
                    Console.WriteLine("Digite 2 número para realizar a soma:");

                    int.TryParse(Console.ReadLine(), out int adicao1);
                    int.TryParse(Console.ReadLine(), out int adicao2);

                    Console.WriteLine("Resultado: " + calc.CalculoAdicao(adicao1, adicao2));

                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Digite 2 número para realizar a subtração:");

                    int.TryParse(Console.ReadLine(), out int subtracao1);
                    int.TryParse(Console.ReadLine(), out int subtracao2);

                    Console.WriteLine("Resultado: " + calc.CalculoSubtracao(subtracao1, subtracao2));

                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Digite 2 número para realizar a multiplicação:");

                    int.TryParse(Console.ReadLine(), out int multiplicacao1);
                    int.TryParse(Console.ReadLine(), out int multiplicacao2);

                    Console.WriteLine("Resultado: " + calc.CalculoMultiplicacao(multiplicacao1, multiplicacao2));

                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Digite 2 número para realizar a divisão:");

                    int.TryParse(Console.ReadLine(), out int divisao1);
                    int.TryParse(Console.ReadLine(), out int divisao2);

                    Console.WriteLine("Resultado: " + calc.CalculoDivisao(divisao1, divisao2));

                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Informe a base e a altura do retângulo para calcular sua área:");

                    int.TryParse(Console.ReadLine(), out int bbase);
                    int.TryParse(Console.ReadLine(), out int altura);

                    Console.WriteLine("Resultado: " + calc.AreaRetangulo(bbase, altura));

                    Console.ReadKey();
                    break;

                case 6:
                    Console.WriteLine("Informe o lado(????) do triângulo para obter sua área:");

                    double.TryParse(Console.ReadLine(), out double ladoTriangulo);

                    Console.WriteLine("Resultado: " + calc.AreaTriangulo(ladoTriangulo));

                    Console.ReadKey();
                    break;

                case 7:
                    Console.WriteLine("Informe a área do círculo para calcular seu raio:");

                    double.TryParse(Console.ReadLine(), out double areaCirculo);

                    Console.WriteLine("Resultado: " + calc.RaioCirculo(areaCirculo));

                    Console.ReadKey();
                    break;

                case 8:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
