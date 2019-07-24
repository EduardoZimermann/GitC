using ListaBiManeiraSimplesComClass.Carrega;
using ListaBiManeiraSimplesComClass.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui iniciamos nosso objeto em memória
            var carregaLista = new CarregarLista();
            //Aqui chamamos o nosso método para carregar a lista
            carregaLista.CarregaInformaoesEListaElasEmTela();
            //Carregamos novamente mas agora a classe mostrar lista 
            //aonde colocamos todas os metodos que serão direcionados para mostrar
            //a listagem de informaçoes na tela do console
            var mostrarLista = new MostrarLista();
            //Aqui chamamos o método novamente
            mostrarLista.PesquisandoInformacoesNaNossaLista(carregaLista.ListaNome,"0");

            Console.ReadKey();
        }
    }
}
