using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i != 8)
            {
                if (i < 0)
                    i++;

                Introducao();
                Instrucoes(i);
                if (LerTecla())
                    i--;
                else
                    i++;
            }

            Bolo();
        }
        /// <summary>
        /// Limpa a tela e apresenta a introduçaõ.
        /// </summary>
        public static void Introducao()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("        Receita de bolo simples!");
            Console.WriteLine("----------------------------------------");
        }
        /// <summary>
        /// Apresenta uma mensagem sobre continuidade e espera pelo usuário apertar uma tecla.
        /// </summary>
        /// <returns>Retorna verdadeiro caso o usuário aperte backspace</returns>
        public static bool LerTecla()
        {
            Console.WriteLine("\r\n\r\n Pressione backspace para voltar ou qualquer outra tecla para continuar...");
            return Console.ReadKey().KeyChar.ToString() == "\b";
        }
        /// <summary>
        /// Contém as instruções da receita.
        /// </summary>
        /// <param name="n">Índice que define que parte da receita será mostrado.</param>
        public static void Instrucoes(int n)
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine("\r\n Ingredientes:");
                    Console.WriteLine("\r\n- 2 xícaras (chá) de açúcar");
                    Console.WriteLine("- 3 xícaras (chá) de farinha de trigo");
                    Console.WriteLine("- 4 colheres (sopa) de margarina");
                    Console.WriteLine("- 3 ovos");
                    Console.WriteLine("- 1 e 1/2 xícara (chá) de leite");
                    Console.WriteLine("- 1 colher (sopa) bem cheia de fermento em pó");
                    break;
                case 1:
                    Console.WriteLine("\r\n Passo 1:");
                    Console.WriteLine("\r\n Bata as claras em neve e reserve.");
                    break;
                case 2:
                    Console.WriteLine("\r\n Passo 2:");
                    Console.WriteLine("\r\n Misture as gemas, a margarina e o açúcar até obter uma massa homogênea.");
                    break;
                case 3:
                    Console.WriteLine("\r\n Passo 3:");
                    Console.WriteLine("\r\n Acrescente o leite e a farinha de trigo aos poucos, sem parar de bater.");
                    break;
                case 4:
                    Console.WriteLine("\r\n Passo 4:");
                    Console.WriteLine("\r\n Por último, adicione as claras em neve e o fermento.");
                    break;
                case 5:
                    Console.WriteLine("\r\n Passo 5:");
                    Console.WriteLine("\r\n Despeje a massa em uma forma grande de furo central untada e enfarinhada.");
                    break;
                case 6:
                    Console.WriteLine("\r\n Passo 6:");
                    Console.WriteLine("\r\n Asse em forno médio 180 °C, preaquecido, por aproximadamente 40 minutos");
                    Console.WriteLine(" ou ao furar o bolo com um garfo, este saia limpo.");
                    break;
                case 7:
                    Console.WriteLine("\r\n Fim da receita!");
                    Console.WriteLine("\r\n Você pode usar essa receita como base para várias outras.");
                    break;
            }
        }
        public static void Bolo()
        {
            Console.Clear();
            Console.WriteLine("          *                                             *");
            Console.WriteLine("                                               *");
            Console.WriteLine("                    *");
            Console.WriteLine("                                                            *");
            Console.WriteLine("         *");
            Console.WriteLine("             *");
            Console.WriteLine("                           *             *");
            Console.WriteLine("                                                     *");
            Console.WriteLine("      *                                                               *");
            Console.WriteLine("               *");
            Console.WriteLine("                               (             )");
            Console.WriteLine("                       )      (*)           (*)      (");
            Console.WriteLine("              *       (*)      |             |      (*)");
            Console.WriteLine("                       |      |~|           |~|      |          *");
            Console.WriteLine("                      |~|     | |           | |     |~|");
            Console.WriteLine("                      | |     | |           | |     | |");
            Console.WriteLine("                     ,| |a@@@@| |@@@@@@@@@@@| |@@@@a| |.");
            Console.WriteLine("                .,a@@@| |@@@@@| |@@@@@@@@@@@| |@@@@@| |@@@@a,.");
            Console.WriteLine("              ,a@@@@@@| |@@@@@@@@@@@@.@@@@@@@@@@@@@@| |@@@@@@@a,");
            Console.WriteLine("             a@@@@@@@@@@@@@@@@@@@@@' . `@@@@@@@@@@@@@@@@@@@@@@@@a");
            Console.WriteLine("             ;`@@@@@@@@@@@@@@@@@@'   .   `@@@@@@@@@@@@@@@@@@@@@';");
            Console.WriteLine("             ;@@@`@@@@@@@@@@@@@'     .     `@@@@@@@@@@@@@@@@'@@@;");
            Console.WriteLine("             ;@@@;,.aaaaaaaaaa       .       aaaaa,,aaaaaaa,;@@@;");
            Console.WriteLine("             ;;@;;;;@@@@@@@@;@      @.@      ;@@@;;;@@@@@@;;;;@@;");
            Console.WriteLine("             ;;;;;;;@@@@;@@;;@    @@ . @@    ;;@;;;;@@;@@@;;;;;;;");
            Console.WriteLine("             ;;;;;;;;@@;;;;;;;  @@   .   @@  ;;;;;;;;;;;@@;;;;@;;");
            Console.WriteLine("             ;;;;;;;;;;;;;;;;;@@     .     @@;;;;;;;;;;;;;;;;@@@;");
            Console.WriteLine("         ,%%%;;;;;;;;@;;;;;;;;       .       ;;;;;;;;;;;;;;;;@@;;%%%,");
            Console.WriteLine("      .%%%%%%;;;;;;;@@;;;;;;;;     ,%%%,     ;;;;;;;;;;;;;;;;;;;;%%%%%%,");
            Console.WriteLine("     .%%%%%%%;;;;;;;@@;;;;;;;;   ,%%%%%%%,   ;;;;;;;;;;;;;;;;;;;;%%%%%%%,");
            Console.WriteLine("     %%%%%%%%`;;;;;;;;;;;;;;;;  %%%%%%%%%%%  ;;;;;;;;;;;;;;;;;;;'%%%%%%%%");
            Console.WriteLine("     %%%%%%%%%%%%`;;;;;;;;;;;;,%%%%%%%%%%%%%,;;;;;;;;;;;;;;;'%%%%%%%%%%%%");
            Console.WriteLine("     `%%%%%%%%%%%%%%%%%,,,,,,,%%%%%%%%%%%%%%%,,,,,,,%%%%%%%%%%%%%%%%%%%%'");
            Console.WriteLine("       `%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%'");
            Console.WriteLine("           `%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%'");
            Console.WriteLine("                  %%%%%%%%%%%%%%`,,,,,,,,,'%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("                                 `%%%%%%%'");
            Console.WriteLine("                                  `%%%%%'");
            Console.WriteLine("                                    %%%");
            Console.WriteLine("                                   %%%%%");
            Console.WriteLine("                                .,%%%%%%%,.");
            Console.WriteLine("                           ,%%%%%%%%%%%%%%%%%%%,");
            Console.ReadKey();
        }
    }
}
