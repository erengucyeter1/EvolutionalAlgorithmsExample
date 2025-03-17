
using System.Collections.Generic;
using System;
using System.Text;

namespace EvolutionalAlgorithmsExample.Core
{
    public class Chromosome
    {
        Genome[] Genomes;

        public double FitnessScore { get; set; }

        public double Probability { get; set; }
        public double CumulativeProbability { get; set; }

        public int Lenght { get { return Genomes.Length; } }
        public Chromosome()
        {
            Genomes = new Genome[TestFunction.VariableCount];
            for (int i = 0; i < Genomes.Length; i++)
            {
                Genomes[i] = new Genome();
            }

        }


        public void CrossOver(Chromosome other, int genomeIndex, int nucleotideIndex)
        {
           

            bool[] temp = new bool[nucleotideIndex];

            for (int i = 0; i < nucleotideIndex; i++)
            {
                temp[i] = Genomes[genomeIndex].nucleotides[i];
                Genomes[genomeIndex].nucleotides[i] = other.Genomes[genomeIndex].nucleotides[i];
                other.Genomes[genomeIndex].nucleotides[i] = temp[i];
            }
        }

        public void Mutation(double probability)
        {
            for (int i = 0; i < Genomes.Length; i++)
            {
                Genomes[i].Mutate(probability);
            }
        }


        public Chromosome Copy()
        {
            Chromosome newChromosome = new Chromosome();
            for (int i = 0; i < Genomes.Length; i++)
            {
                newChromosome.Genomes[i] = Genomes[i].Copy();
            }
           
            return newChromosome;
        }
        public double CalculateFitnessScore()
        {
            FitnessScore = TestFunction.Eval(Genomes[0].Value, Genomes[1].Value);
            return FitnessScore;
        }


        public string[] GetGenomesAsString()
        {
            string[] strGenomes = new String[Lenght];

            for (int i = 0; i < Genomes.Length; i++)
            {
                strGenomes[i] = Genomes[i].ToString();
                
               
            }

            return strGenomes;
        }

        public double[] GetGenomesAsDouble()
        {
            double[] doubleGenomes = new double[Lenght];
            for (int i = 0; i < Genomes.Length; i++)
            {
                doubleGenomes[i] = Genomes[i].Value;
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

