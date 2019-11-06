namespace test
{
    partial class plotfigure
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.time_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.FFT_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.time_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFT_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // time_chart
            // 
            chartArea1.AxisX.Title = "Time";
            chartArea1.Name = "ChartArea1";
            this.time_chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.time_chart.Legends.Add(legend1);
            this.time_chart.Location = new System.Drawing.Point(12, 12);
            this.time_chart.Name = "time_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.time_chart.Series.Add(series1);
            this.time_chart.Size = new System.Drawing.Size(618, 327);
            this.time_chart.TabIndex = 0;
            this.time_chart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "time";
            this.time_chart.Titles.Add(title1);
            this.time_chart.Click += new System.EventHandler(this.time_chart_Click);
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(658, 12);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(658, 12);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(75, 23);
            this.stopbutton.TabIndex = 2;
            this.stopbutton.Text = "stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // FFT_chart
            // 
            chartArea2.AxisX.Title = "Frequency";
            chartArea2.Name = "ChartArea1";
            this.FFT_chart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.FFT_chart.Legends.Add(legend2);
            this.FFT_chart.Location = new System.Drawing.Point(12, 345);
            this.FFT_chart.Name = "FFT_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.FFT_chart.Series.Add(series2);
            this.FFT_chart.Size = new System.Drawing.Size(618, 327);
            this.FFT_chart.TabIndex = 3;
            this.FFT_chart.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "FFT";
            this.FFT_chart.Titles.Add(title2);
            // 
            // plotfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 669);
            this.Controls.Add(this.FFT_chart);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.time_chart);
            this.Name = "plotfigure";
            this.Text = "figure";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.time_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFT_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart time_chart;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart FFT_chart;
    }
}

