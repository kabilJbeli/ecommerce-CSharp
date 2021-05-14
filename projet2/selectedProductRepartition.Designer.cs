
namespace ecommerce
{
    partial class selectedProductRepartition
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
            this.productChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).BeginInit();
            this.SuspendLayout();
            // 
            // productChart
            // 
            chartArea1.Name = "ChartArea1";
            this.productChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.productChart.Legends.Add(legend1);
            this.productChart.Location = new System.Drawing.Point(232, 70);
            this.productChart.Name = "productChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Repartition";
            this.productChart.Series.Add(series1);
            this.productChart.Size = new System.Drawing.Size(885, 412);
            this.productChart.TabIndex = 2;
            this.productChart.Text = "chart1";
            this.productChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // selectedProductRepartition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1316, 559);
            this.Controls.Add(this.productChart);
            this.Name = "selectedProductRepartition";
            this.Load += new System.EventHandler(this.selectedProductRepartition_Load);
            this.Controls.SetChildIndex(this.productChart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart productChart;
    }
}
