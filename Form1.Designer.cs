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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.time_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.FFT_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.samplepoint = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.time_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFT_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // time_chart
            // 
            chartArea13.AxisX.Title = "Time";
            chartArea13.Name = "ChartArea1";
            this.time_chart.ChartAreas.Add(chartArea13);
            legend13.Enabled = false;
            legend13.Name = "Legend1";
            this.time_chart.Legends.Add(legend13);
            this.time_chart.Location = new System.Drawing.Point(12, 12);
            this.time_chart.Name = "time_chart";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.time_chart.Series.Add(series13);
            this.time_chart.Size = new System.Drawing.Size(618, 327);
            this.time_chart.TabIndex = 0;
            this.time_chart.Text = "chart1";
            title13.Name = "Title1";
            title13.Text = "time";
            this.time_chart.Titles.Add(title13);
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
            chartArea14.AxisX.Title = "Frequency";
            chartArea14.Name = "ChartArea1";
            this.FFT_chart.ChartAreas.Add(chartArea14);
            legend14.Enabled = false;
            legend14.Name = "Legend1";
            this.FFT_chart.Legends.Add(legend14);
            this.FFT_chart.Location = new System.Drawing.Point(12, 345);
            this.FFT_chart.Name = "FFT_chart";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.FFT_chart.Series.Add(series14);
            this.FFT_chart.Size = new System.Drawing.Size(618, 327);
            this.FFT_chart.TabIndex = 3;
            this.FFT_chart.Text = "chart2";
            title14.Name = "Title1";
            title14.Text = "FFT";
            this.FFT_chart.Titles.Add(title14);
            // 
            // samplepoint
            // 
            this.samplepoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.samplepoint.Location = new System.Drawing.Point(636, 70);
            this.samplepoint.Name = "samplepoint";
            this.samplepoint.Size = new System.Drawing.Size(100, 22);
            this.samplepoint.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(636, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 15);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "samplepoint";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(636, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 15);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "頻率解析度";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(636, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 15);
            this.textBox3.TabIndex = 4;
            // 
            // plotfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 669);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.samplepoint);
            this.Controls.Add(this.FFT_chart);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.time_chart);
            this.Name = "plotfigure";
            this.Text = "figure";
            ((System.ComponentModel.ISupportInitialize)(this.time_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFT_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart time_chart;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart FFT_chart;
        private System.Windows.Forms.TextBox samplepoint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

