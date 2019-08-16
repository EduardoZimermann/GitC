using System;

namespace Calculo //Feito por MIM!!!!!!!!!!!!
{
    public class Calculadora
    {
        /// <summary>
        /// Soma
        /// </summary>
        /// <param name="n1">numero 1</param>
        /// <param name="n2">numero 2</param>
        /// <returns>retorna a soma, o que mais seria?</returns>
        public double Adicao(double n1, double n2)
        {
            return n1 + n2;
        }

        /// <summary>
        /// Conta de menos
        /// </summary>
        /// <param name="n1">numero 1</param>
        /// <param name="n2">numero 2</param>
        /// <returns>reotrna o resultado</returns>
        public double Subtracao(double n1, double n2)
        {
            return n1 - n2;
        }

        /// <summary>
        /// vezes
        /// </summary>
        /// <param name="n1">number one</param>
        /// <param name="n2">number two</param>
        /// <returns>retorna um resultado resultante de uma conta de vezes</returns>
        public double Multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        /// <summary>
        /// dividdidor 
        /// </summary>
        /// <param name="n1">uno</param>
        /// <param name="n2">dos</param>
        /// <returns>meio obvio</returns>
        public double Divisao(double n1, double n2)
        {
            try
            {
                var result = n1 / n2;
                return result;
            }
            catch 
            {
                return 666;
            }
        }

        /// <summary>
        /// Calcula a area do retangulo.
        /// </summary>
        /// <param name="bbase">base, parte de baixo se não sabe</param>
        /// <param name="altura">Altura pode ser representada como "h".</param>
        /// <returns>Retorna o que tu precisa.</returns>
        public double CalcularRetangulo(double bbase, double altura)
        {
            return bbase * altura;
        }


        /// <summary>
        /// Nome autoexplicativo.
        /// </summary>
        /// <param name="bbase">bbbbbbbbbbbase</param>
        /// <param name="altura">H</param>
        /// <returns>Retorna o retorno retornavelmente retornável.</returns>
        public double CalcularTriangulo(double bbase, double altura)
        {
            return (bbase * altura) / 2;
        }

        /// <summary>
        /// helpme
        /// </summary>
        /// <param name="area">É a área e não o diametro! A ÁREA</param>
        /// <returns>hm</returns>
        public double CalcularRaio(double area)
        {
            return Math.Sqrt(area / 3.14);
        }
    }
}
