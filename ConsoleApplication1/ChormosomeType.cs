using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticLibrary
{
    class ChromosomeType
    {
        public static ChromosomeType Binary = new ChromosomeType("Binary");
        public static ChromosomeType Double = new ChromosomeType("Double");

        private string Type;

        private ChromosomeType(string type)
        {
            Type = type;
        }
    }
}
