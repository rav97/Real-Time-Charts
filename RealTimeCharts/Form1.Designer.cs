namespace RealTimeCharts
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.AmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MeanTextBox = new System.Windows.Forms.TextBox();
            this.StdDevTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea3.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart.Legends.Add(legend3);
            this.Chart.Location = new System.Drawing.Point(12, 12);
            this.Chart.Name = "Chart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Sin(t)";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Sin(t)+Gaussian Noise";
            this.Chart.Series.Add(series5);
            this.Chart.Series.Add(series6);
            this.Chart.Size = new System.Drawing.Size(856, 374);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(877, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AmplitudeTextBox
            // 
            this.AmplitudeTextBox.Location = new System.Drawing.Point(877, 44);
            this.AmplitudeTextBox.MaxLength = 10;
            this.AmplitudeTextBox.Name = "AmplitudeTextBox";
            this.AmplitudeTextBox.Size = new System.Drawing.Size(93, 20);
            this.AmplitudeTextBox.TabIndex = 2;
            this.AmplitudeTextBox.Text = "1";
            this.AmplitudeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmplitudeTextBox.TextChanged += new System.EventHandler(this.AmplitudeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(874, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amplitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(874, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mean";
            // 
            // MeanTextBox
            // 
            this.MeanTextBox.Location = new System.Drawing.Point(880, 250);
            this.MeanTextBox.MaxLength = 10;
            this.MeanTextBox.Name = "MeanTextBox";
            this.MeanTextBox.Size = new System.Drawing.Size(90, 20);
            this.MeanTextBox.TabIndex = 5;
            this.MeanTextBox.Text = "0";
            this.MeanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MeanTextBox.TextChanged += new System.EventHandler(this.MeanTextBox_TextChanged);
            // 
            // StdDevTextBox
            // 
            this.StdDevTextBox.Location = new System.Drawing.Point(880, 299);
            this.StdDevTextBox.MaxLength = 10;
            this.StdDevTextBox.Name = "StdDevTextBox";
            this.StdDevTextBox.Size = new System.Drawing.Size(90, 20);
            this.StdDevTextBox.TabIndex = 6;
            this.StdDevTextBox.Text = "0,3";
            this.StdDevTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StdDevTextBox.TextChanged += new System.EventHandler(this.StdDevTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(874, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Standard deviation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 398);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StdDevTextBox);
            this.Controls.Add(this.MeanTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmplitudeTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sin(t) with Gaussian Noise";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AmplitudeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MeanTextBox;
        private System.Windows.Forms.TextBox StdDevTextBox;
        private System.Windows.Forms.Label label3;
    }
}

