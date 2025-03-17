using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionalAlgorithmsExample.Core
{

    public class GenomeSchema
    {
        public string VariableName { get; private set; }
        public double Max { get; private set; }
        public double Min { get; private set; }
        public int BitCount { 
            get
            {
              return  (int)Math.Ceiling(Math.Log((double)(Max - Min) * TestFunction.Sensivity, 2));
            }

        }

        public GenomeSchema(string variableName, double min, double max)
        {
            this.VariableName = variableName;
            this.Min = min;
            this.Max = max;
        }

        public Nucleotide CreateNewNucleotide()
        {
            return new Nucleotide(Min, Max, BitCount, VariableName);
        }
    }
    public class Nucleotide 
    {
        public bool[] bits;

        public string VariableName { get; private set; }
        public double Max { get; private set; }
        public double Min { get; private set; }
        public int BitCount { get; private set; }
        public double Value
        {
            get
            {
                return Min + ((this.ToInt() * (Max - Min)) / (Math.Pow(2, BitCount) - 1));
            }
        }


        public Nucleotide(double min, double max, int bitCount, string variableName)
        {
            this.Min = min;
            this.Max = max;
            this.BitCount = bitCount;
            this.VariableName = variableName;
            bits = new bool[BitCount];
            Randomize();
        }

        private Nucleotide(Nucleotide src)
        {   
            this.VariableName = src.VariableName;
            this.Min = src.Min;
            this.Max = src.Max;
            this.BitCount = src.BitCount;

            this.bits = new bool[BitCount];

            for (int i = 0; i < BitCount; i++)
            {
                this.bits[i] = src.bits[i];
            }
        }


        private void Randomize()
        {
            for (int i = 0; i < BitCount; i++)
            {
                bits[i] = RandomGenerator.random.Next(0, 2) == 1;
            }
        }

        public void Mutate(double probability)
        {
            for (int i = 0; i < BitCount; i++)
            {
                if (RandomGenerator.random.NextDouble() < probability)
                {
                    bits[i] = !bits[i];
                }
            }
        }
        
        public Nucleotide Copy()
        {
            Nucleotide newNucleotide = new Nucleotide(this);
            
            return newNucleotide;
        }

        public int ToInt()
        {
            int result = 0;

            for (int i = 0; i < BitCount; i++)
            {
                if (bits[i])
                {
                    result += (int)Math.Pow(2, i);
                }
            }

            return result;
        }

        public override string ToString()
        {
                StringBuilder sb = new StringBuilder();

                sb.Append($"{VariableName}: ");
                foreach (bool bit in bits)
                {
                    sb.Append(bit ? "1" : "0");
                }

                return sb.ToString();
        }
    }
}
