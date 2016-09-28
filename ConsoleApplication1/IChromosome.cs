using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticLibrary
{
    interface IChromosome
    {
        ChromosomeType GetCType();
        int GetLength();
        Fitness GetFitness();
    }

}
