
namespace Rating_Application.Menu_Forms
{
    partial class Chart_Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBarGraph = new System.Windows.Forms.Label();
            this.lblCriterias = new System.Windows.Forms.Label();
            this.lblExcellent = new System.Windows.Forms.Label();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblDissatisfied = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.SuspendLayout();
            // 
            // barChart
            // 
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(39, 93);
            this.barChart.Name = "barChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Mean Value";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.barChart.Series.Add(series1);
            this.barChart.Size = new System.Drawing.Size(1105, 333);
            this.barChart.TabIndex = 0;
            this.barChart.Text = "chart1";
            // 
            // lblBarGraph
            // 
            this.lblBarGraph.AutoSize = true;
            this.lblBarGraph.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarGraph.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBarGraph.Location = new System.Drawing.Point(35, 51);
            this.lblBarGraph.Name = "lblBarGraph";
            this.lblBarGraph.Size = new System.Drawing.Size(171, 22);
            this.lblBarGraph.TabIndex = 1;
            this.lblBarGraph.Text = "Rating Bar Graph";
            // 
            // lblCriterias
            // 
            this.lblCriterias.AutoSize = true;
            this.lblCriterias.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterias.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCriterias.Location = new System.Drawing.Point(557, 440);
            this.lblCriterias.Name = "lblCriterias";
            this.lblCriterias.Size = new System.Drawing.Size(82, 22);
            this.lblCriterias.TabIndex = 2;
            this.lblCriterias.Text = "Criterias";
            // 
            // lblExcellent
            // 
            this.lblExcellent.AutoSize = true;
            this.lblExcellent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcellent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblExcellent.Location = new System.Drawing.Point(735, 56);
            this.lblExcellent.Name = "lblExcellent";
            this.lblExcellent.Size = new System.Drawing.Size(87, 17);
            this.lblExcellent.TabIndex = 3;
            this.lblExcellent.Text = "Excellent = 4";
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGood.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGood.Location = new System.Drawing.Point(841, 56);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(69, 17);
            this.lblGood.TabIndex = 4;
            this.lblGood.Text = "Good = 3";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAverage.Location = new System.Drawing.Point(948, 56);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(86, 17);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Average = 2";
            // 
            // lblDissatisfied
            // 
            this.lblDissatisfied.AutoSize = true;
            this.lblDissatisfied.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDissatisfied.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDissatisfied.Location = new System.Drawing.Point(1052, 56);
            this.lblDissatisfied.Name = "lblDissatisfied";
            this.lblDissatisfied.Size = new System.Drawing.Size(100, 17);
            this.lblDissatisfied.TabIndex = 6;
            this.lblDissatisfied.Text = "Dissatisfied = 1";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPoint.Location = new System.Drawing.Point(642, 56);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(95, 17);
            this.lblPoint.TabIndex = 7;
            this.lblPoint.Text = "Rating Point:-";
            // 
            // Chart_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1207, 483);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblDissatisfied);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblGood);
            this.Controls.Add(this.lblExcellent);
            this.Controls.Add(this.lblCriterias);
            this.Controls.Add(this.lblBarGraph);
            this.Controls.Add(this.barChart);
            this.Name = "Chart_Report";
            this.Text = "Chart_Report";
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.Label lblBarGraph;
        private System.Windows.Forms.Label lblCriterias;
        private System.Windows.Forms.Label lblExcellent;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblDissatisfied;
        private System.Windows.Forms.Label lblPoint;
    }
}