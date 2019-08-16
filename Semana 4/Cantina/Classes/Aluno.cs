using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Classes
{
    class Aluno
    {
        double _saldo { get; set; }
        string _nome { get; set; }

        public Aluno(string nome)
        {
            _nome = nome;
            _saldo = 20;
        }

        public bool ComprarLanche(double valor)
        {
            if (_saldo >= valor)
            {
                _saldo -= valor;
                return true;
            }

            return false;
        }

        public double MostrarSaldo()
        {
            return _saldo;
        }
    }
}
