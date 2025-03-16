using EvolutionalAlgorithmsExample.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EvolutionalAlgorithmsExample.Utils
{

    public delegate void DrawLinesDelegate(int index, Population population);

    internal class ChartHelper
    {
        public Chart ProgressChart { get; set; }

        DrawLinesDelegate DrawLines;
        public ChartHelper()
        {
            ProgressChart = DrawChart();

        }


        private void ScaleY()
        {
            double maxY = 0;
            for (int i = 0; i < ProgressChart.Series.Count; i++)
            {
                if (ProgressChart.Series[i].Enabled && ProgressChart.Series[i].Points.Count > 0)
                {
                    double tempMax = ProgressChart.Series[i].Points.Max(x => x.YValues[0]);
                    if (tempMax > maxY)
                    {
                        maxY = tempMax;
                    }
                }
            }

            ProgressChart.ChartAreas[0].AxisY.Maximum = maxY * 1.1;

        }

        public void Display()
        {
            // chart label
            Label mainLabel = new Label();
            mainLabel.Size = new Size(800, 600);
            mainLabel.Location = new Point(0, 0);
            mainLabel.Controls.Add(ProgressChart);

            // label for display settings
            Label settingsLabel = new Label();
            settingsLabel.Size = new Size(80, 600);
            settingsLabel.Location = new Point(810, 0);

            // Checkboxes for display settings

            CheckBox bestScoreCheckBox = new CheckBox();
            bestScoreCheckBox.Text = "Best Score";
            bestScoreCheckBox.Location = new Point(0, 20); // Relative to settingsLabel

            bestScoreCheckBox.CheckedChanged += (object sender, EventArgs e) =>
            {
                if (bestScoreCheckBox.Checked)
                {
                    DrawLines += (int i, Population population) => ProgressChart.Series[0].Points.AddXY(i, population.BestScore);
                    ProgressChart.Series[0].Enabled = true;
                }
                else
                {
                    DrawLines -= (int i, Population population) => ProgressChart.Series[0].Points.AddXY(i, population.BestScore);
                    ProgressChart.Series[0].Enabled = false;

                }
            };
            bestScoreCheckBox.Checked = true;
            bestScoreCheckBox.CheckedChanged += (object sender, EventArgs e) => { ScaleY();  };


            CheckBox averageScoreCheckBox = new CheckBox();
            averageScoreCheckBox.Text = "Average Score";
            averageScoreCheckBox.Location = new Point(0, 40); // Relative to settingsLabel
            averageScoreCheckBox.CheckedChanged += (object sender, EventArgs e) =>
            {
                if (averageScoreCheckBox.Checked)
                {
                    DrawLines += (int i, Population population) => ProgressChart.Series[1].Points.AddXY(i, population.AverageScore);
                    ProgressChart.Series[1].Enabled = true;

                }
                else
                {
                    DrawLines -= (int i, Population population) => ProgressChart.Series[1].Points.AddXY(i, population.AverageScore);
                    ProgressChart.Series[1].Enabled = false;

                }
            };

            averageScoreCheckBox.Checked = true;
            averageScoreCheckBox.CheckedChanged += (object sender, EventArgs e) => { ScaleY(); };


            CheckBox worstScoreCheckBox = new CheckBox();
            worstScoreCheckBox.Text = "Worst Score";
            worstScoreCheckBox.Location = new Point(0, 60); // Relative to settingsLabel
            worstScoreCheckBox.CheckedChanged += (object sender, EventArgs e) =>
            {
                if (worstScoreCheckBox.Checked)
                {
                    DrawLines += (int i, Population population) => ProgressChart.Series[2].Points.AddXY(i, population.WorstScore);
                    ProgressChart.Series[2].Enabled = true;

                }
                else
                {
                    DrawLines -= (int i, Population population) => ProgressChart.Series[2].Points.AddXY(i, population.WorstScore);
                    ProgressChart.Series[2].Enabled = false;

                }
            };
            worstScoreCheckBox.Checked = true;
            worstScoreCheckBox.CheckedChanged += (object sender, EventArgs e) => { ScaleY(); };




            CheckBox ScrollXAxis = new CheckBox();
            ScrollXAxis.Text = "Scroll X Axis";
            ScrollXAxis.Location = new Point(0, 80); // Relative to settingsLabel
            ScrollXAxis.CheckedChanged += (object sender, EventArgs e) =>
            {
                if (ScrollXAxis.Checked)
                {
                    MakeChartScrollable();

                    ProgressChart.MouseWheel += mwZoomXAxis;
                }
                else
                {
                    ProgressChart.MouseWheel -= mwZoomXAxis;

                    ProgressChart.ChartAreas[0].AxisX.ScrollBar.Enabled = false; // Enable scroll bar

                    ProgressChart.ChartAreas[0].AxisX.ScaleView.ZoomReset(); // Reset zoom


                }
            };
            ScrollXAxis.Checked = false;



            settingsLabel.Controls.Add(bestScoreCheckBox);
            settingsLabel.Controls.Add(averageScoreCheckBox);
            settingsLabel.Controls.Add(worstScoreCheckBox);
            settingsLabel.Controls.Add(ScrollXAxis);

            // form
            Form form = new Form();
            form.Controls.Add(mainLabel);
            form.Controls.Add(settingsLabel);
            form.Size = new Size(950, 630);
            form.Show();
        }


        
        private Chart DrawChart()
        {

            ProgressChart = new Chart();
            ProgressChart.Dock = DockStyle.Fill;
            ProgressChart.ChartAreas.Add(new ChartArea());
            ProgressChart.Series.Add(new Series());
            ProgressChart.Series[0].ChartType = SeriesChartType.Line;

            //


            // Chart kontrolünü ayarla
            ProgressChart.Series.Clear();  // Önceki verileri temizle
            ProgressChart.ChartAreas.Clear();
            ProgressChart.Legends.Clear();

            ChartArea chartArea = new ChartArea();
            ProgressChart.ChartAreas.Add(chartArea);

            // Legend (Açıklamalar) ekleyelim
            Legend legend = new Legend
            {
                Docking = Docking.Top,  // Sağ üst köşe
                Alignment = StringAlignment.Far
            };
            ProgressChart.Legends.Add(legend);

            // 3 farklı seri ekleyelim
            AddSeries("Best Score", Color.Red, ProgressChart);
            AddSeries("Average Score", Color.Blue, ProgressChart);
            AddSeries("Worst Score", Color.Green, ProgressChart);

            return ProgressChart;
        }

        public void AddSeries(string seriesName, Color color, Chart ProgressChart)
        {
            ProgressChart.ChartAreas[0].AxisX.Title = "Generation";
            ProgressChart.ChartAreas[0].AxisY.Title = "Fitness";

            Series series = new Series
            {
                Name = seriesName,
                Color = color,
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };

            ProgressChart.Series.Add(series);
            ProgressChart.Series[seriesName].LegendText = seriesName;
        }


        private void mwZoomXAxis(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                ZoomXAxis(1.1);
            }
            else
            {
                ZoomXAxis(0.9);
            }
        }
        public void ZoomXAxis(double zoomFactor)
        {
            ProgressChart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false; // Scroll bar outside
            ProgressChart.ChartAreas[0].AxisX.ScrollBar.Enabled = true; // Enable scroll bar

            double oldSize = ProgressChart.ChartAreas[0].AxisX.ScaleView.Size;
            double newSize = oldSize * zoomFactor;


            if (ProgressChart.Series[0].Points.Count > newSize)
            {
                ProgressChart.ChartAreas[0].AxisX.ScaleView.Scroll(ProgressChart.Series[0].Points.Count - newSize);
            }

            ProgressChart.ChartAreas[0].AxisX.ScaleView.Size = (int)(newSize+1);
        }

        public void MakeChartScrollable(int viewSize = 10)
        {
            ProgressChart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false; // Scroll bar outside
            ProgressChart.ChartAreas[0].AxisX.ScrollBar.Enabled = true; // Enable scroll bar

            if (ProgressChart.Series[0].Points.Count > viewSize)
            {
                ProgressChart.ChartAreas[0].AxisX.ScaleView.Size = viewSize;
                ProgressChart.ChartAreas[0].AxisX.ScaleView.Scroll(ProgressChart.Series[0].Points.Count - viewSize);
            }
        }


        /*public void UpdateChart(int i, Population population)
        {
            DrawLines?.Invoke(i, population);
            ProgressChart.Invalidate();
            ProgressChart.Update();
        }*/

        public void UpdateChart(int i, Population population)
        {
            if (ProgressChart.InvokeRequired)
            {
                ProgressChart.Invoke(new Action(() => UpdateChart(i, population)));
            }
            else
            {
                DrawLines?.Invoke(i, population);
                ProgressChart.Invalidate();
                ProgressChart.Update();
            }
        }

    }
}
