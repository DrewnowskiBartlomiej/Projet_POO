namespace POOwithFrame
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartPRICE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRAF = new System.Windows.Forms.Button();
            this.buttonCONSOM = new System.Windows.Forms.Button();
            this.buttonPRODUC = new System.Windows.Forms.Button();
            this.labelEnsoleillement = new System.Windows.Forms.Label();
            this.labelVent = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPRICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPRICE
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPRICE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPRICE.Legends.Add(legend1);
            this.chartPRICE.Location = new System.Drawing.Point(367, 337);
            this.chartPRICE.Name = "chartPRICE";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "test";
            this.chartPRICE.Series.Add(series1);
            this.chartPRICE.Size = new System.Drawing.Size(276, 300);
            this.chartPRICE.TabIndex = 0;
            this.chartPRICE.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Frais de consommation";
            this.chartPRICE.Titles.Add(title1);
            this.chartPRICE.Click += new System.EventHandler(this.chartPRICE_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(367, 12);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Uranium";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Gas";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Carbon";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Foreign Energy";
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(784, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Market";
            this.chart2.Titles.Add(title2);
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(649, 337);
            this.chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Energy";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(502, 300);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            title3.Name = "Title1";
            title3.Text = "Energy management";
            this.chart3.Titles.Add(title3);
            // 
            // buttonRAF
            // 
            this.buttonRAF.Location = new System.Drawing.Point(26, 268);
            this.buttonRAF.Name = "buttonRAF";
            this.buttonRAF.Size = new System.Drawing.Size(146, 44);
            this.buttonRAF.TabIndex = 3;
            this.buttonRAF.Text = "Rafraichir";
            this.buttonRAF.UseVisualStyleBackColor = true;
            this.buttonRAF.Click += new System.EventHandler(this.buttonRAF_Click);
            // 
            // buttonCONSOM
            // 
            this.buttonCONSOM.Location = new System.Drawing.Point(26, 402);
            this.buttonCONSOM.Name = "buttonCONSOM";
            this.buttonCONSOM.Size = new System.Drawing.Size(146, 44);
            this.buttonCONSOM.TabIndex = 4;
            this.buttonCONSOM.Text = "Consomation Electrique";
            this.buttonCONSOM.UseVisualStyleBackColor = true;
            this.buttonCONSOM.Click += new System.EventHandler(this.buttonCONSOM_Click);
            // 
            // buttonPRODUC
            // 
            this.buttonPRODUC.Location = new System.Drawing.Point(26, 337);
            this.buttonPRODUC.Name = "buttonPRODUC";
            this.buttonPRODUC.Size = new System.Drawing.Size(146, 44);
            this.buttonPRODUC.TabIndex = 6;
            this.buttonPRODUC.Text = "Production Electrique";
            this.buttonPRODUC.UseVisualStyleBackColor = true;
            this.buttonPRODUC.Click += new System.EventHandler(this.buttonPRODUC_Click);
            // 
            // labelEnsoleillement
            // 
            this.labelEnsoleillement.AutoSize = true;
            this.labelEnsoleillement.Location = new System.Drawing.Point(24, 496);
            this.labelEnsoleillement.Name = "labelEnsoleillement";
            this.labelEnsoleillement.Size = new System.Drawing.Size(0, 13);
            this.labelEnsoleillement.TabIndex = 7;
            this.labelEnsoleillement.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelVent
            // 
            this.labelVent.AutoSize = true;
            this.labelVent.Location = new System.Drawing.Point(23, 509);
            this.labelVent.Name = "labelVent";
            this.labelVent.Size = new System.Drawing.Size(0, 13);
            this.labelVent.TabIndex = 8;
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(24, 525);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(0, 13);
            this.labelTemperature.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 649);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelVent);
            this.Controls.Add(this.labelEnsoleillement);
            this.Controls.Add(this.buttonPRODUC);
            this.Controls.Add(this.buttonCONSOM);
            this.Controls.Add(this.buttonRAF);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chartPRICE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPRICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPRICE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button buttonRAF;
        private System.Windows.Forms.Button buttonCONSOM;
        private System.Windows.Forms.Button buttonPRODUC;
        private System.Windows.Forms.Label labelEnsoleillement;
        private System.Windows.Forms.Label labelVent;
        private System.Windows.Forms.Label labelTemperature;
    }
}

