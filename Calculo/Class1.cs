using System;

namespace Calculo
{
    public class Calculadora
    {
        public void Resultado(int n1, int n2)
        {
            Console.WriteLine($"\r\nAdição: {n1 + n2}");
            Console.WriteLine($"\r\nSubtração: {n1 - n2}");
            Console.WriteLine($"\r\nMultiplicação: {n1 * n2}");
            Console.WriteLine($"\r\nDivisão: {n1 / n2}");
        }
    }
}
