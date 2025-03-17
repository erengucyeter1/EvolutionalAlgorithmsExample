
using System.Collections.Generic;
using System;
using System.Text;

namespace EvolutionalAlgorithmsExample.Core
{
    public class Chromosome
    {
        Genome Genome;

        public double FitnessScore { get; set; }

        public double Probability { get; set; }
        public double CumulativeProbability { get; set; }

        public int Lenght { get { return Genome.nucleotides.Length; } }
        public Chromosome()
        {
            Genome = new Genome(TestFunction.genomeSchemas);

        }

        private void SwapGenes(Chromosome other, int index)
        {
            bool[] temp = new bool[Genome.nucleotides[index].bits.Length];
            
            int randPoint = RandomGenerator.random.Next(0, Genome.nucleotides[index].bits.Length);

            this.Genome.nucleotides[index].bits.CopyTo(temp, 0);

            for (int i = randPoint; i < Genome.nucleotides[index].bits.Length; i++)
            {
                this.Genome.nucleotides[index].bits[i] = other.Genome.nucleotides[index].bits[i];
                other.Genome.nucleotides[index].bits[i] = temp[i];
            }
        }

        public void CrossOver(Chromosome other, double CrossOverRate)
        {

            for (int i = 0; i < this.Genome.nucleotides.Length; i++)
            {
                if(RandomGenerator.random.NextDouble() < CrossOverRate)
                {
                    SwapGenes(other, i);
                }
            }







            /*

            bool[] temp = new bool[nucleotideIndex];

            for (int i = 0; i < Genome.nucleotides.Length; i++)
            {
                temp[i] = Genome.nucleotides[i].bits[i];
                Genome.nucleotides[genomeIndex].bits[i] = other.Genome.nucleotides[genomeIndex].bits[i];
                other.Genome.nucleotides[genomeIndex].bits[i] = temp[i];
            }*/
        }

        public void Mutation(double probability)
        {
            for (int i = 0; i < Genome.nucleotides.Length; i++)
            {
                Genome.nucleotides[i].Mutate(probability);
            }
        }


        public Chromosome Copy()
        {
            Chromosome newChromosome = new Chromosome();

            
             newChromosome.Genome = Genome.Copy();
            
           
            return newChromosome;
        }
        public double CalculateFitnessScore()
        {
            FitnessScore = TestFunction.Eval(Genome);
            return FitnessScore;
        }


        public string[] GetGenomesAsString()
        {
            string[] strGenomes = new String[Lenght];

            for (int i = 0; i < Genome.nucleotides.Length; i++)
            {
                strGenomes[i] = Genome.nucleotides[i].ToString();
                
               
            }

            return strGenomes;
        }

        public double[] GetGenomesAsDouble()
        {
            double[] doubleGenomes = new double[Lenght];
            for (int i = 0; i < Genome.nucleotides.Length; i++)
            {
                doubleGenomes[i] = Genome.nucleotides[i].Value;
            }
            return doubleGenomes;
        }
    }


    public class ChromosomeComparerbyProbability : IComparer<Chromosome>
    {
        public int Compare(Chromosome x, Chromosome y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Arguments cannot be null");
            }

            return x.Probability.CompareTo(y.Probability);
        }
    }

    public class ChromosomeComparerbyFitnessScore : IComparer<Chromosome>
    {
        public int Compare(Chromosome x, Chromosome y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Arguments cannot be null");
            }

            return x.FitnessScore.CompareTo(y.FitnessScore);
        }
    }
}

