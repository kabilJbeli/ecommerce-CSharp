
namespace ecommerce
{
    partial class selectedClientRepartition
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
            this.clientChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.clientChart)).BeginInit();
            this.SuspendLayout();
            // 
            // clientChart
            // 
            chartArea1.Name = "ChartArea1";
            this.clientChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.clientChart.Legends.Add(legend1);
            this.clientChart.Location = new System.Drawing.Point(239, 71);
            this.clientChart.Name = "clientChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Repartition";
            this.clientChart.Series.Add(series1);
            this.clientChart.Size = new System.Drawing.Size(837, 415);
            this.clientChart.TabIndex = 2;
            this.clientChart.Text = "chart1";
            // 
            // selectedClientRepartition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1316, 559);
            this.Controls.Add(this.clientChart);
            this.Name = "selectedClientRepartition";
            this.Load += new System.EventHandler(this.selectedClientRepartition_Load);
            this.Controls.SetChildIndex(this.clientChart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.clientChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart clientChart;
    }
}
