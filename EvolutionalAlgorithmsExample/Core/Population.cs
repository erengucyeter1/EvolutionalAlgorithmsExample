using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionalAlgorithmsExample.Core
{
    public delegate void SelectionTypeDelegate(int tournamentCount, int elitismCount);

    public class Population
    {

        private SelectionTypeDelegate selectionMethod;


        public List<Chromosome> population;
        public List<Chromosome> newPopulation;

        public List<double> BestScores;

        public List<double> AverageScores;

        public List<double> WorstScores;
        public double BestScore { get; set; }
        public double AverageScore { get; set; }

        public double WorstScore { get; set; }

        Chromosome BestChromosome;




        private double SumOfFitness;
        public Population(int populationCount, SelectionTypes SelectionType)
        {
            switch (SelectionType)
            {
                case SelectionTypes.Tournament:
                    selectionMethod = TournamentSelection;
                    break;
                case SelectionTypes.Roulette:
                    selectionMethod = RouletteSelection;
                    break;
                default:
                    throw new ArgumentException("Geçersiz seçim türü");
            }

            Init(populationCount);

        }

        private void Init(int populationCount)
        {
            population = new List<Chromosome>();
            newPopulation = new List<Chromosome>();
            BestScores = new List<double>();
            AverageScores = new List<double>();
            WorstScores = new List<double>();

            for (int i = 0; i < populationCount; i++)
            {
                population.Add(new Chromosome());
            }

            CalculateFitness();
            population.Sort(new ChromosomeComparerbyFitnessScore());
            SetScores();


        }

        private void SetScores()
        {
            BestScore = population[0].FitnessScore;

            WorstScore = population[population.Count - 1].FitnessScore;
            AverageScore = CalculateAverageScore();

            BestScores.Add(BestScore);
            AverageScores.Add(AverageScore);
            WorstScores.Add(WorstScore);
        }

        private double CalculateAverageScore()
        {
            double sum = 0;
            foreach (var chromosome in population)
            {
                sum += chromosome.FitnessScore;
            }
            return sum / population.Count;
        }


        public  void CalculateFitness()
        {
            SumOfFitness = 0;
            foreach (var chromosome in population)
            {
                SumOfFitness += chromosome.CalculateFitnessScore();

            }
        }

        public void CalculateProbability()
        {
            foreach (var chromosome in population)
            {
                chromosome.Probability = chromosome.FitnessScore / SumOfFitness;
            }
            population.Sort(new ChromosomeComparerbyProbability());
        }

        public void CalculateCumulativeProbability()
        {
            double cumulativeProbability = 0;
            foreach (var chromosome in population)
            {
                cumulativeProbability += chromosome.Probability;
                chromosome.CumulativeProbability = cumulativeProbability;
            }

        }
        private void AddElits(int ElitismCount)
        {
            population.Sort(new ChromosomeComparerbyFitnessScore());
            for (int i = 0; i < ElitismCount; i++)
            {
                newPopulation.Add(population[i].Copy());
            }
        }
        private void RouletteSelection(int TournamentCount, int ElitismCount)
        {
            newPopulation.Clear();

            if (ElitismCount > 0)
            {
                AddElits(ElitismCount);
            }

            for (int i = ElitismCount; i < TournamentCount; i++)
            {
                double randomValue = RandomGenerator.random.NextDouble();
                for (int j = 0; j < population.Count-1; j++)
                {
                    Chromosome p1 = population[j];
                    Chromosome p2 = population[j + 1];

                    if (randomValue < p1.CumulativeProbability)
                    {
                        newPopulation.Add(p1.Copy());
                        break;
                    }
                    else if (p1.CumulativeProbability < randomValue && randomValue <= p2.CumulativeProbability)
                    {
                        newPopulation.Add(p2.Copy());
                        break;
                    }
                }
            }
        }

        private void TournamentSelection(int TournamentCount, int ElitismCount)
        {
            newPopulation.Clear();

            if (ElitismCount > 0)
            {
                AddElits(ElitismCount);
            }

            for (int i = ElitismCount; i < TournamentCount; i++)
            {
                int randomIndex1= RandomGenerator.random.Next(0, population.Count);
                int randomIndex2 = RandomGenerator.random.Next(0, population.Count);

                Chromosome c1 = population[randomIndex1];
                Chromosome c2 = population[randomIndex2];

                if (c1.FitnessScore > c2.FitnessScore)
                {
                    newPopulation.Add(c1.Copy());
                }
                else
                {
                    newPopulation.Add(c2.Copy());
                }

            }
        }


        public void Select(int TournamentCount, int ElitismCount)
        {
            selectionMethod.Invoke(TournamentCount, ElitismCount);

        }


        public  void Breed(double CrossOverRate, double MutationRate)
        {
            int couplesCount = newPopulation.Count / 2;

            for (int i = 0; i <= newPopulation.Count - 2; i += 2)
            {
                Chromosome p1 = newPopulation[i];
                Chromosome p2 = newPopulation[i + 1];

                CrossOver(CrossOverRate, p1,p2);
                
                p1.Mutation(MutationRate);
                p2.Mutation(MutationRate);

                p1.CalculateFitnessScore();
                p2.CalculateFitnessScore();

                population.Add(p1);
                population.Add(p2);

             }

            population.Sort(new ChromosomeComparerbyFitnessScore());            
            population.RemoveRange(population.Count - (couplesCount*2), (couplesCount * 2));
            SetScores();


        }
        private void CrossOver(double CrossOverRate, Chromosome p1, Chromosome p2)
        {              
        p1.CrossOver(p2, CrossOverRate);
        }
        
        
    }
}
