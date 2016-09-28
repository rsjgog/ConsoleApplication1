using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticLibrary
{
    interface ICombiner
    {
        ChromosomeType getCType();
        //IChromosome makeChild(IChromosome m, IChromosome f);
    }
}
