using EvolutionalAlgorithmsExample.Core;
using System;

namespace EvolutionalAlgorithmsExample.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.ElitismCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ElitismRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSelectionType = new System.Windows.Forms.ComboBox();
            this.TournamentCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.TournamentRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.GenerationCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MutationRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CrossOverRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.PopulationSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElitismCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElitismRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutationRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossOverRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationSizeNumericUpDown)).BeginInit();
            this.ChartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Population Size:";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.ElitismCountNumericUpDown);
            this.ControlPanel.Controls.Add(this.label13);
            this.ControlPanel.Controls.Add(this.label11);
            this.ControlPanel.Controls.Add(this.ElitismRateNumericUpDown);
            this.ControlPanel.Controls.Add(this.label12);
            this.ControlPanel.Controls.Add(this.label10);
            this.ControlPanel.Controls.Add(this.cbSelectionType);
            this.ControlPanel.Controls.Add(this.TournamentCountUpDown);
            this.ControlPanel.Controls.Add(this.label7);
            this.ControlPanel.Controls.Add(this.label6);
            this.ControlPanel.Controls.Add(this.btnStart);
            this.ControlPanel.Controls.Add(this.TournamentRateNumericUpDown);
            this.ControlPanel.Controls.Add(this.label5);
            this.ControlPanel.Controls.Add(this.GenerationCountNumericUpDown);
            this.ControlPanel.Controls.Add(this.MutationRateNumericUpDown);
            this.ControlPanel.Controls.Add(this.label4);
            this.ControlPanel.Controls.Add(this.label3);
            this.ControlPanel.Controls.Add(this.CrossOverRateNumericUpDown);
            this.ControlPanel.Controls.Add(this.label2);
            this.ControlPanel.Controls.Add(this.PopulationSizeNumericUpDown);
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.label8);
            this.ControlPanel.Controls.Add(this.label9);
            this.ControlPanel.Location = new System.Drawing.Point(12, 13);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(475, 574);
            this.ControlPanel.TabIndex = 1;
            // 
            // ElitismCountNumericUpDown
            // 
            this.ElitismCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ElitismCountNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ElitismCountNumericUpDown.Location = new System.Drawing.Point(240, 387);
            this.ElitismCountNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ElitismCountNumericUpDown.Name = "ElitismCountNumericUpDown";
            this.ElitismCountNumericUpDown.Size = new System.Drawing.Size(219, 35);
            this.ElitismCountNumericUpDown.TabIndex = 24;
            this.ElitismCountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ElitismCountNumericUpDown.ValueChanged += new System.EventHandler(this.ElitismCountNumericUpDown_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(74, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 29);
            this.label13.TabIndex = 23;
            this.label13.Text = "Elitism Count:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(341, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "%";
            // 
            // ElitismRateNumericUpDown
            // 
            this.ElitismRateNumericUpDown.AutoSize = true;
            this.ElitismRateNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ElitismRateNumericUpDown.Location = new System.Drawing.Point(336, 333);
            this.ElitismRateNumericUpDown.Name = "ElitismRateNumericUpDown";
            this.ElitismRateNumericUpDown.Size = new System.Drawing.Size(123, 35);
            this.ElitismRateNumericUpDown.TabIndex = 21;
            this.ElitismRateNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ElitismRateNumericUpDown.ValueChanged += new System.EventHandler(this.ElitismRateNumericUpDown_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(87, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "Elitism Rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(53, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Selection Type:";
            // 
            // cbSelectionType
            // 
            this.cbSelectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSelectionType.FormattingEnabled = true;
            this.cbSelectionType.Location = new System.Drawing.Point(240, 190);
            this.cbSelectionType.Name = "cbSelectionType";
            this.cbSelectionType.Size = new System.Drawing.Size(219, 28);
            this.cbSelectionType.TabIndex = 17;
            this.cbSelectionType.SelectedIndexChanged += new System.EventHandler(this.cbSelectionType_SelectedIndexChanged);
            // 
            // TournamentCountUpDown
            // 
            this.TournamentCountUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TournamentCountUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.TournamentCountUpDown.Location = new System.Drawing.Point(240, 284);
            this.TournamentCountUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.TournamentCountUpDown.Name = "TournamentCountUpDown";
            this.TournamentCountUpDown.Size = new System.Drawing.Size(219, 35);
            this.TournamentCountUpDown.TabIndex = 14;
            this.TournamentCountUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TournamentCountUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.TournamentCountUpDown.ValueChanged += new System.EventHandler(this.TournamentCountUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(45, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Selection Count:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(341, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "%";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(233, 526);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(219, 35);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // TournamentRateNumericUpDown
            // 
            this.TournamentRateNumericUpDown.AutoSize = true;
            this.TournamentRateNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TournamentRateNumericUpDown.Location = new System.Drawing.Point(336, 235);
            this.TournamentRateNumericUpDown.Name = "TournamentRateNumericUpDown";
            this.TournamentRateNumericUpDown.Size = new System.Drawing.Size(123, 35);
            this.TournamentRateNumericUpDown.TabIndex = 8;
            this.TournamentRateNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TournamentRateNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TournamentRateNumericUpDown.ValueChanged += new System.EventHandler(this.TournamentRateNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(58, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Selection Rate:";
            // 
            // GenerationCountNumericUpDown
            // 
            this.GenerationCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenerationCountNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.GenerationCountNumericUpDown.Location = new System.Drawing.Point(233, 469);
            this.GenerationCountNumericUpDown.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.GenerationCountNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.GenerationCountNumericUpDown.Name = "GenerationCountNumericUpDown";
            this.GenerationCountNumericUpDown.Size = new System.Drawing.Size(219, 35);
            this.GenerationCountNumericUpDown.TabIndex = 3;
            this.GenerationCountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GenerationCountNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.GenerationCountNumericUpDown.ValueChanged += new System.EventHandler(this.GenerationCountNumericUpDown_ValueChanged);
            // 
            // MutationRateNumericUpDown
            // 
            this.MutationRateNumericUpDown.DecimalPlaces = 5;
            this.MutationRateNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MutationRateNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.MutationRateNumericUpDown.Location = new System.Drawing.Point(240, 108);
            this.MutationRateNumericUpDown.Name = "MutationRateNumericUpDown";
            this.MutationRateNumericUpDown.Size = new System.Drawing.Size(219, 35);
            this.MutationRateNumericUpDown.TabIndex = 5;
            this.MutationRateNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MutationRateNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.MutationRateNumericUpDown.ValueChanged += new System.EventHandler(this.MutationRateNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Generation Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mutation Rate:";
            // 
            // CrossOverRateNumericUpDown
            // 
            this.CrossOverRateNumericUpDown.DecimalPlaces = 5;
            this.CrossOverRateNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CrossOverRateNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.CrossOverRateNumericUpDown.Location = new System.Drawing.Point(240, 61);
            this.CrossOverRateNumericUpDown.Name = "CrossOverRateNumericUpDown";
            this.CrossOverRateNumericUpDown.Size = new System.Drawing.Size(219, 35);
            this.CrossOverRateNumericUpDown.TabIndex = 3;
            this.CrossOverRateNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CrossOverRateNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.CrossOverRateNumericUpDown.ValueChanged += new System.EventHandler(this.CrossOverRateNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cross-Over Rate:";
            // 
            // PopulationSizeNumericUpDown
            // 
            this.PopulationSizeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PopulationSizeNumericUpDown.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.PopulationSizeNumericUpDown.Location = new System.Drawing.Point(240, 13);
            this.PopulationSizeNumericUpDown.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.PopulationSizeNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PopulationSizeNumericUpDown.Name = "PopulationSizeNumericUpDown";
            this.PopulationSizeNumericUpDown.Size = new System.Drawing.Size(219, 35);
            this.PopulationSizeNumericUpDown.TabIndex = 1;
            this.PopulationSizeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PopulationSizeNumericUpDown.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.PopulationSizeNumericUpDown.ValueChanged += new System.EventHandler(this.PopulationSizeNumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(28, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(440, 36);
            this.label8.TabIndex = 15;
            this.label8.Text = "_________________________";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(440, 36);
            this.label9.TabIndex = 18;
            this.label9.Text = "_________________________";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChartPanel
            // 
            this.ChartPanel.Controls.Add(this.ControlPanel);
            this.ChartPanel.Location = new System.Drawing.Point(12, 12);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(499, 599);
            this.ChartPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 623);
            this.Controls.Add(this.ChartPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElitismCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElitismRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutationRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossOverRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationSizeNumericUpDown)).EndInit();
            this.ChartPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.NumericUpDown PopulationSizeNumericUpDown;
        private System.Windows.Forms.NumericUpDown CrossOverRateNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GenerationCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown MutationRateNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown TournamentRateNumericUpDown;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown TournamentCountUpDown;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSelectionType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ElitismCountNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown ElitismRateNumericUpDown;
        private System.Windows.Forms.Label label12;
    }
}