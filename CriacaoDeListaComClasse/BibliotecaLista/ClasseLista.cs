using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaComClasse.BibliotecaLista
{
    public class ClasseLista
    {
        string[] lista;
        /// <summary>
        /// Carrega a lista com informações ao ser instanciada.
        /// </summary>
        public ClasseLista()
        {
            lista = new string[10];

            CarregaLista();
        }
        /// <summary>
        /// Atribui informações à lista criada.
        /// </summary>
        public void CarregaLista()
        {
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
            }
        }
        /// <summary>
        /// Mostra a lista na tela do usuário.
        /// </summary>
        public void MostraLista()
        {
            foreach (var item in lista)
                Console.WriteLine(item);

            Console.ReadKey();
        }
        /// <summary>
        /// Limpa todos os campos da lista, tornando-os vazios.
        /// </summary>
        public void LimpaLista()
        {
            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;
        }

        public void MudaTamanho(int tamanho)
        {
            lista = new string[tamanho];
        }
    }
}
