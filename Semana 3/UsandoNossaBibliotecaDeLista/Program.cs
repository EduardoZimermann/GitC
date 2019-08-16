using CriacaoDeListaComClasse.BibliotecaLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoNossaBibliotecaDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            var listView = new ClasseLista();

            listView.MostraLista();

            listView.LimpaLista();

            listView.MudaTamanho(50);

            listView.CarregaLista();

            listView.MostraLista();
        }
    }
}
