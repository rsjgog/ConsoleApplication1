using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticLibrary
{
    class BinaryCombiner : ICombiner
    {
        private double cRate = 0.7; //set to default values
        private double mRate = 0.005; //set to default value

        public ChromosomeType getCType()
        {
            return ChromosomeType.Binary;
        }

        public BinaryChromosome makeChild(BinaryChromosome m, BinaryChromosome f)
        {
            int[] data = cross(m, f);
            mutate(data);
            return new BinaryChromosome(data);
        }

        private int[] cross(BinaryChromosome m, BinaryChromosome f)//makes new "data"
        {
            int[] data = new int[m.GetLength()];
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = m.getLoc(i);
            }

            Random rng = new Random();
            if(rng.NextDouble() < cRate)
            {
                for(int i = rng.Next(data.Length); i <data.Length; i++)
                {
                    data[i] = f.getLoc(i);
                }
            }
            return data;
        }

        private void mutate(int[] data) //modifies provided array
        {
            Random rng = new Random();
            for(int i = 0; i < data.Length; i++)
            {
                if(rng.NextDouble() < mRate)
                {
                    if (data[i] != 1) data[i] = 1;
                    else data[i] = 0;    //why int is a bad data type for this!
                }
            }
        }

        public BinaryCombiner() {
        }

        public BinaryCombiner(double c, double m)
        {
            cRate = c;
            mRate = m;
        }
    }
}
