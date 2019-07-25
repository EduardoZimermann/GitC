using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDeUsoDoContains
{
    class Program
    {
        static string[] listaDeNome = new string[20] {"Aldon\u00e7a Lago", "Anabela Cezimbra", "Bruna Carij\u00f3",
            "Clara Gir\u00e3o", "Di\u00f3genes Zagallo", "Elias Bel\u00e9m", "Elsa Angelim", "Estanislau Falc\u00e3o",
            "Ester Fuentes", "F\u00e9lix Ribas", "Gilda Fragoso", "Gra\u00e7a Rebocho", "Higino Ruas", "Ju\u00e7ara Borja",
            "Lua Farinha", "Miru Acevedo", "N\u00e1dia L\u00f3pez", "Raimundo Acu\u00f1a", "Sancho Jesus", "Sandoval Cavalheiro"};
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a expressão que deseja encontrar na lista:");
            var expressao = Console.ReadLine();

            for (int i = 0; i < listaDeNome.Length; i++)
            {
                if (expressao.Countains(listaDeNome[i]))
                {
                    Console.WriteLine(listaDeNome[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
