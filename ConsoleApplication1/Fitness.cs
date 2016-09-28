using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticLibrary
{
    class Fitness
    {
        private bool evaluated;
        private double value;

        public bool GetEvaluated()
        {
            return evaluated;
        }

        public double GetValue()
        {
            return value;
        }

        public void Evaluate(double newValue)
        {
            value = newValue;
            evaluated = true;
        }

        public Fitness()
        {
            evaluated = false;
            value = 0;
        }
    }
}
