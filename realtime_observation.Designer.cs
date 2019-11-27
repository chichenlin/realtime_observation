namespace realtime_observation
{
    partial class realtime_observation
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(realtime_observation));
            this.time_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.FFT_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.samplepoint = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.channal0 = new System.Windows.Forms.CheckBox();
            this.channal1 = new System.Windows.Forms.CheckBox();
            this.channal2 = new System.Windows.Forms.CheckBox();
            this.vibrationmonitor = new System.Windows.Forms.CheckBox();
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
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.MarkerStep = 10;
            series4.Name = "Series4";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series5";
            this.time_chart.Series.Add(series1);
            this.time_chart.Series.Add(series2);
            this.time_chart.Series.Add(series3);
            this.time_chart.Series.Add(series4);
            this.time_chart.Series.Add(series5);
            this.time_chart.Size = new System.Drawing.Size(667, 327);
            this.time_chart.TabIndex = 0;
            this.time_chart.Text = "chart1";
            title1.Name = "Title1";
            this.time_chart.Titles.Add(title1);
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(685, 12);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(685, 12);
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
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series2";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series3";
            this.FFT_chart.Series.Add(series6);
            this.FFT_chart.Series.Add(series7);
            this.FFT_chart.Series.Add(series8);
            this.FFT_chart.Size = new System.Drawing.Size(642, 327);
            this.FFT_chart.TabIndex = 3;
            this.FFT_chart.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "FFT";
            this.FFT_chart.Titles.Add(title2);
            // 
            // samplepoint
            // 
            this.samplepoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.samplepoint.Location = new System.Drawing.Point(660, 404);
            this.samplepoint.Name = "samplepoint";
            this.samplepoint.Size = new System.Drawing.Size(100, 22);
            this.samplepoint.TabIndex = 4;
            this.samplepoint.Text = "1280";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(660, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 15);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "samplepoint";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(660, 483);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 15);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "頻率解析度";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(660, 504);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(660, 455);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "300";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(660, 434);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 15);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "frequency range";
            // 
            // channal0
            // 
            this.channal0.AutoSize = true;
            this.channal0.Location = new System.Drawing.Point(685, 41);
            this.channal0.Name = "channal0";
            this.channal0.Size = new System.Drawing.Size(66, 16);
            this.channal0.TabIndex = 6;
            this.channal0.Text = "channal0";
            this.channal0.UseVisualStyleBackColor = true;
            // 
            // channal1
            // 
            this.channal1.AutoSize = true;
            this.channal1.Location = new System.Drawing.Point(685, 63);
            this.channal1.Name = "channal1";
            this.channal1.Size = new System.Drawing.Size(66, 16);
            this.channal1.TabIndex = 6;
            this.channal1.Text = "channal1";
            this.channal1.UseVisualStyleBackColor = true;
            // 
            // channal2
            // 
            this.channal2.AutoSize = true;
            this.channal2.Location = new System.Drawing.Point(685, 85);
            this.channal2.Name = "channal2";
            this.channal2.Size = new System.Drawing.Size(66, 16);
            this.channal2.TabIndex = 6;
            this.channal2.Text = "channal2";
            this.channal2.UseVisualStyleBackColor = true;
            // 
            // vibrationmonitor
            // 
            this.vibrationmonitor.AutoSize = true;
            this.vibrationmonitor.Location = new System.Drawing.Point(685, 108);
            this.vibrationmonitor.Name = "vibrationmonitor";
            this.vibrationmonitor.Size = new System.Drawing.Size(72, 16);
            this.vibrationmonitor.TabIndex = 7;
            this.vibrationmonitor.Text = "振動監控";
            this.vibrationmonitor.UseVisualStyleBackColor = true;
            // 
            // realtime_observation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 669);
            this.Controls.Add(this.vibrationmonitor);
            this.Controls.Add(this.channal2);
            this.Controls.Add(this.channal1);
            this.Controls.Add(this.channal0);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.samplepoint);
            this.Controls.Add(this.FFT_chart);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.time_chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "realtime_observation";
            this.Text = "realtime_observation";
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox channal0;
        private System.Windows.Forms.CheckBox channal1;
        private System.Windows.Forms.CheckBox channal2;
        private System.Windows.Forms.CheckBox vibrationmonitor;
    }
}

