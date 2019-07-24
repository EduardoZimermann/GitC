using CriacaoDeListaComClasse.BibliotecaLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaComClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaTime = new ClasseLista();

            listaTime.MostraLista();

            listaTime.LimpaLista();

            listaTime.MudaTamanho(50);

            listaTime.CarregaLista();

            listaTime.MostraLista();
        }
    }
}
