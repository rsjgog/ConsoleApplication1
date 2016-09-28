using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticLibrary
{
    class BinaryChromosome : IChromosome
    {
        private int[] data; //horribly not type safe to use int[] here. Try update to more elegant solution 
        private Fitness fitness;


        public ChromosomeType GetCType()
        {
            return ChromosomeType.Binary;
        }

        public int GetLength()
        {
            return data.Length;
        }

        public Fitness GetFitness()
        {
            return fitness;
        }

        public int getLoc(int i)
        {
            return data[i];
        }

        public BinaryChromosome(int length)
        {
            Random rng = new Random();
            data = new int[length];
            for(int i = 0; i < length; i++)
            {
                data[i] = rng.Next(2);
            }
            fitness = new Fitness();
        }

        public BinaryChromosome(int[] inputData)
        {
            data = inputData;
            fitness = new Fitness();
        }
    }
}
