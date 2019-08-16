using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDeVisualizacaoDeValores.Model
{
    public class Contrac
    {
        public int Id { get; set; }
        /// <summary>
        /// Property for get and set values in contract
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Get value on date contect set
        /// </summary>
        public DateTime DatInc { get; set; }
    }
}
