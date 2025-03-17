using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolutionalAlgorithmsExample.Core
{
    internal class DisplayChromosomePanel : System.Windows.Forms.Panel
    {
        public Chromosome Chromosome { get; set; }
        public DisplayChromosomePanel(Chromosome c)
        {
            this.Chromosome = c;
        }


        public Panel GetDisplayPanel()
        {
            Panel panel = new Panel();

            panel.Dock = DockStyle.Fill; // Fill full space of its parent

            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.AutoScroll = true;

            Label label = new Label();
            label.Text = "Best Chromosome";
            label.Location = new Point(5, 5);
            panel.Controls.Add(label);

            Label label2 = new Label();
            label2.Text = "Fitness Score:";
            label2.Location = new Point(5, 27);
            panel.Controls.Add(label2);

            TextBox textBox = new TextBox();
            textBox.Text = Chromosome.FitnessScore.ToString("F12");
            textBox.Location = new Point(5, 50);
            textBox.Width = 100;
            textBox.ReadOnly = true;
            panel.Controls.Add(textBox);

            string[] genomes = Chromosome.GetGenomesAsString();
            double[] values = Chromosome.GetGenomesAsDouble();

            for (int i = 0; i < genomes.Length; i++)
            {
                Panel temp = new Panel();

                Label label6 = new Label();
                label6.Text = "Value:";
                label6.Location = new Point(5, 5);
                label6.Height = 18;
                temp.Controls.Add(label6);


                TextBox valTextBox = new TextBox();
                valTextBox.Text = values[i].ToString("F12");
                valTextBox.Location = new Point(5, 27);
                valTextBox.Width = 90;
                valTextBox.ReadOnly = true;
                temp.Controls.Add(valTextBox);


                Label label1 = new Label();
                label1.Text = "Genome:";
                label1.Location = new Point(5, 50);
                label1.AutoSize = true;

                temp.Controls.Add(label1);


                Panel GenomeScroolPanel = new Panel();
                GenomeScroolPanel.AutoScroll = true;
                GenomeScroolPanel.Width = 90;
                GenomeScroolPanel.Height = 40;
                GenomeScroolPanel.Location = new Point(5, 70);

                Label label5 = new Label();
                label5.Text = genomes[i];
                label5.AutoSize = true;
                label5.Location = new Point(0,0);
                GenomeScroolPanel.Controls.Add(label5);
                temp.Controls.Add(GenomeScroolPanel);


                temp.Location = new Point(5, 80 + i * 130);
                temp.BorderStyle = BorderStyle.FixedSingle;
                temp.Width = 100;
                temp.Height = 120;

                panel.Controls.Add(temp);
            }

            return panel;
        }

    }
}
