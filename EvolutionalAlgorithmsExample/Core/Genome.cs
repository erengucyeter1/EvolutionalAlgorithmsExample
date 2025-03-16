using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EvolutionalAlgorithmsExample.Core
{
    public class Genome
    {
        public bool[] nucleotides;

        public double Value
        {
            get
            {
                return TestFunction.Min + ((this.ToInt() * TestFunction.Range) / (Math.Pow(2, TestFunction.BitCount) - 1));
            }
        }

        public Genome()
        {
            Randomize();
        }


        public void Mutate(double probability)
        {
            for (int i = 0; i < TestFunction.BitCount; i++)
            {
                if (RandomGenerator.random.NextDouble()  < probability)
                {
                    nucleotides[i] = !nucleotides[i];
                }
            }
        }

        private void Randomize()
        {
            nucleotides = new bool[TestFunction.BitCount];
            for (int i = 0; i < TestFunction.BitCount; i++)
            {
                nucleotides[i] = RandomGenerator.random.Next(0, 2) == 1;
            }
        }


       
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < TestFunction.BitCount; i++)
            {
                sb.Append(nucleotides[i] ? "1" : "0");
            }
            return sb.ToString();
        }

        private int ToInt()
        {
            int result = 0;
            for (int i = 0; i < TestFunction.BitCount; i++)
            {
                if (nucleotides[i])
                {
                    result += (int)Math.Pow(2, i);
                }
            }
            return result;
        }
    }
}
