﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
    public class AquiMostraJoinha
    {
        /// <summary>
        /// Será que hoje é sexta?
        /// </summary>
        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui iniciamos o nosso joinha!");

            Console.ReadKey();
        }

        /// <summary>
        /// Aqui ainda não bebe mais que eu!!!
        /// </summary>
        /// <param name="eQuinta">2.0 ainda faz 3 por 1</param>
        public void MetodoDoisPontoZero(bool eQuinta)
        {
            if (eQuinta)
                Console.WriteLine("Seila");
            else
                Console.WriteLine("Numsei");

            Console.ReadKey();
        }
    }
}
