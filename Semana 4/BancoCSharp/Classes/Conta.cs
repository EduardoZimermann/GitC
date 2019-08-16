using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp.Classes
{
    public class Conta
    {
        double saldo = 0;

        //Propriedade que contém o valor do saldo
        public double Saldo { get { return saldo; } }

        public Conta()
        {
            //Bonus de mil reais pra iniciar operação daytrade.
            saldo = 1000;
        }

        /// <summary>
        /// Método para sacar de acordo com saldo disponível.
        /// </summary>
        /// <param name="valor">Valor a ser sacado.</param>
        /// <returns>Retorna verdadeiro se o saque foi realizado.</returns>
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {//Desconta do valor em saldo na conta
                saldo -= valor;
                return true;
            }
            //Retorna false em caso de não conter saldo disponível.
            return false;
        }

        /// <summary>
        /// Método para mostrar o saldo em conta disponível.
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
