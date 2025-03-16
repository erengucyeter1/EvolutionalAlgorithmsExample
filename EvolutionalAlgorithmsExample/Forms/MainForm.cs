using EvolutionalAlgorithmsExample.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EvolutionalAlgorithmsExample.Forms
{
    public partial class MainForm : Form
    {
        public int PopulationSize
        {
            get => (int)PopulationSizeNumericUpDown.Value;
            set => PopulationSizeNumericUpDown.Value = value;
        }
        public double CrossOverRate
        {
            get => (double)CrossOverRateNumericUpDown.Value;
            set => CrossOverRateNumericUpDown.Value = (decimal)value;
        }
        public double MutationRate
        {
            get => (double)MutationRateNumericUpDown.Value;
            set => MutationRateNumericUpDown.Value = (decimal)value;
        }
        
        public int GenerationCount
        {
            get => (int)GenerationCountNumericUpDown.Value;
            set => GenerationCountNumericUpDown.Value = value;
        }
        public int TournamentCount
        {
            get => (int)TournamentCountUpDown.Value;
            set => TournamentCountUpDown.Value = value;
        }

        public double TournamentRate
        {
            get => (double)TournamentRateNumericUpDown.Value;
            set
            {
                    TournamentRateNumericUpDown.Value = (decimal)value;
            }
        }
        public int ElitismCount
        {
            get => (int)ElitismCountNumericUpDown.Value;
            set
            {
                if (value <= TournamentCount)
                    ElitismCountNumericUpDown.Value = value;

            }
        }

        public double ElitismRate
        {
            get => (int)ElitismRateNumericUpDown.Value;

            set
                {
                if (value <= 100)
                    ElitismRateNumericUpDown.Value = (decimal)value;
                 } 
        }

        private SelectionTypes SelectionType { get; set; }

        GeneticAlgorithm geneticAlgorithm;
        public MainForm()
        {
            InitializeComponent();

            InitComboBox();


        }

        private void InitComboBox()
        {
            this.cbSelectionType.DataSource = Enum.GetValues(typeof(SelectionTypes));
            this.cbSelectionType.SelectedIndex = 0;
        }

        

        private void DisableControls()
        {
            ControlPanel.Enabled = false;
        }

        private void EnableControls() { ControlPanel.Enabled = true; }

        private async void RunAlgorithm()
        {
            geneticAlgorithm = new GeneticAlgorithm(PopulationSize, SelectionType);
            Population p = await geneticAlgorithm.Run(GenerationCount: GenerationCount, CrossOverRate: CrossOverRate, MutationRate: MutationRate, TournamentCount: TournamentCount, ElitismCount : ElitismCount);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                DisableControls();
                RunAlgorithm();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                EnableControls();

            }
        }



        private void PopulationSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            PopulationSize = (int)PopulationSizeNumericUpDown.Value;

            if(TournamentCount > PopulationSize)
            {
                TournamentCount = PopulationSize;
            }
            

            if (TournamentCountUpDown.Maximum < PopulationSize)
            {
                TournamentCountUpDown.Maximum = PopulationSize;

                TournamentCountUpDown.ValueChanged -= TournamentCountUpDown_ValueChanged;
                TournamentCount = (int)(TournamentRate * (PopulationSize / 100));
                TournamentCountUpDown.ValueChanged += TournamentCountUpDown_ValueChanged;

            }


            if (ElitismCount > TournamentCount)
            {
                ElitismCount = TournamentCount;
            }
            if (ElitismCountNumericUpDown.Maximum < TournamentCount)
            {

                ElitismCountNumericUpDown.ValueChanged -= ElitismCountNumericUpDown_ValueChanged;
                ElitismCountNumericUpDown.Maximum = TournamentCount;
                ElitismCount = (int)((ElitismRate * TournamentCount) / 100);
                ElitismCountNumericUpDown.ValueChanged += ElitismCountNumericUpDown_ValueChanged;
            }



        }

        private void CrossOverRateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CrossOverRate = (double)CrossOverRateNumericUpDown.Value;

        }

        private void MutationRateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MutationRate = (double)MutationRateNumericUpDown.Value;

        }

        private void TournamentRateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TournamentRate = (double)TournamentRateNumericUpDown.Value;

            

            TournamentCountUpDown.ValueChanged -= TournamentCountUpDown_ValueChanged;
            TournamentCount =  (int)(TournamentRate *PopulationSize) / 100 ;

            TournamentCountUpDown.ValueChanged += TournamentCountUpDown_ValueChanged;


            ElitismCountNumericUpDown.ValueChanged -= ElitismCountNumericUpDown_ValueChanged;
            ElitismCount = (int)((ElitismRate * TournamentCount) / 100);
            ElitismCountNumericUpDown.ValueChanged += ElitismCountNumericUpDown_ValueChanged;

        }

        private void GenerationCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            GenerationCount = (int)GenerationCountNumericUpDown.Value;

        }

        private void TournamentCountTextBox_TextChanged(object sender, EventArgs e)
        {
            TournamentRate = (double)TournamentCount / PopulationSize;
        }

        private void TournamentCountUpDown_ValueChanged(object sender, EventArgs e)
        {

            

            TournamentRateNumericUpDown.ValueChanged -= TournamentRateNumericUpDown_ValueChanged;

            TournamentRate = (double)((TournamentCount * 100) / PopulationSize);
            TournamentRateNumericUpDown.ValueChanged += TournamentRateNumericUpDown_ValueChanged;

            ElitismCountNumericUpDown.ValueChanged -= ElitismCountNumericUpDown_ValueChanged;
            ElitismCount = (int)((ElitismRate * TournamentCount) / 100);
            ElitismCountNumericUpDown.ValueChanged += ElitismCountNumericUpDown_ValueChanged;



        }

        private void cbSelectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
           SelectionType = (SelectionTypes)cbSelectionType.SelectedIndex;
        }

        private void ElitismRateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ElitismRate = (double)ElitismRateNumericUpDown.Value;
            ElitismCountNumericUpDown.ValueChanged -= ElitismCountNumericUpDown_ValueChanged;
            ElitismCount = (int)((ElitismRate * TournamentCount) / 100);
            ElitismCountNumericUpDown.ValueChanged += ElitismCountNumericUpDown_ValueChanged;
        }

        private void ElitismCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ElitismCount > TournamentCount)
            {
                ElitismCount = TournamentCount;
            }
            ElitismRateNumericUpDown.ValueChanged -= ElitismRateNumericUpDown_ValueChanged;
            ElitismRate = (double)((ElitismCount * 100) / TournamentCount);
            ElitismRateNumericUpDown.ValueChanged += ElitismRateNumericUpDown_ValueChanged;
        }
    }
}
