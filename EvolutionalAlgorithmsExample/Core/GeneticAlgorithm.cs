using EvolutionalAlgorithmsExample.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EvolutionalAlgorithmsExample.Core
{
    internal class GeneticAlgorithm
    {
        private Population population;
        private ChartHelper chartHelper;

        public GeneticAlgorithm(int populationCount, SelectionTypes selectionType)
        {
            population = new Population(populationCount, selectionType);
        }

        public async Task<Population> Run(int GenerationCount, double CrossOverRate, double MutationRate, int TournamentCount, int ElitismCount)
        {
            chartHelper = new ChartHelper();
            chartHelper.Display();

            Application.DoEvents();

            await RunGenerationsAsync(GenerationCount, CrossOverRate, MutationRate, TournamentCount, ElitismCount: ElitismCount);

            return population;
        }

        private async Task RunGenerationsAsync(int GenerationCount, double CrossOverRate, double MutationRate, int TournamentCount, int ElitismCount)
        {
            for (int i = 0; i <= GenerationCount; i++)
            {
                population.CalculateFitness();
                population.CalculateProbability();
                population.CalculateCumulativeProbability();
                population.Select(TournamentCount, ElitismCount);
                population.Breed(CrossOverRate, MutationRate);
                await Task.Run(() =>
                {
                    chartHelper.UpdateChart(i, population);
                });
                await Task.Yield();
            }
        }
    }



    
}
