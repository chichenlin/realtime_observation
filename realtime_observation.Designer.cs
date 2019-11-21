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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            ((System.ComponentModel.ISupportInitialize)(this.time_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFT_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // time_chart
            // 
            chartArea5.AxisX.Title = "Time";
            chartArea5.Name = "ChartArea1";
            this.time_chart.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.time_chart.Legends.Add(legend5);
            this.time_chart.Location = new System.Drawing.Point(12, 12);
            this.time_chart.Name = "time_chart";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Series2";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Series3";
            this.time_chart.Series.Add(series13);
            this.time_chart.Series.Add(series14);
            this.time_chart.Series.Add(series15);
            this.time_chart.Size = new System.Drawing.Size(618, 327);
            this.time_chart.TabIndex = 0;
            this.time_chart.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "time";
            this.time_chart.Titles.Add(title5);
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
            chartArea6.AxisX.Title = "Frequency";
            chartArea6.Name = "ChartArea1";
            this.FFT_chart.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.FFT_chart.Legends.Add(legend6);
            this.FFT_chart.Location = new System.Drawing.Point(12, 345);
            this.FFT_chart.Name = "FFT_chart";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Series2";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series3";
            this.FFT_chart.Series.Add(series16);
            this.FFT_chart.Series.Add(series17);
            this.FFT_chart.Series.Add(series18);
            this.FFT_chart.Size = new System.Drawing.Size(618, 327);
            this.FFT_chart.TabIndex = 3;
            this.FFT_chart.Text = "chart2";
            title6.Name = "Title1";
            title6.Text = "FFT";
            this.FFT_chart.Titles.Add(title6);
            // 
            // samplepoint
            // 
            this.samplepoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.samplepoint.Location = new System.Drawing.Point(636, 70);
            this.samplepoint.Name = "samplepoint";
            this.samplepoint.Size = new System.Drawing.Size(100, 22);
            this.samplepoint.TabIndex = 4;
            this.samplepoint.Text = "1280";
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
            this.textBox2.Location = new System.Drawing.Point(636, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 15);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "頻率解析度";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(636, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(636, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "300";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(636, 98);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 15);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "frequency range";
            // 
            // channal0
            // 
            this.channal0.AutoSize = true;
            this.channal0.Checked = true;
            this.channal0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.channal0.Location = new System.Drawing.Point(636, 196);
            this.channal0.Name = "channal0";
            this.channal0.Size = new System.Drawing.Size(66, 16);
            this.channal0.TabIndex = 6;
            this.channal0.Text = "channal0";
            this.channal0.UseVisualStyleBackColor = true;
            // 
            // channal1
            // 
            this.channal1.AutoSize = true;
            this.channal1.Checked = true;
            this.channal1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.channal1.Location = new System.Drawing.Point(636, 218);
            this.channal1.Name = "channal1";
            this.channal1.Size = new System.Drawing.Size(66, 16);
            this.channal1.TabIndex = 6;
            this.channal1.Text = "channal1";
            this.channal1.UseVisualStyleBackColor = true;
            // 
            // channal2
            // 
            this.channal2.AutoSize = true;
            this.channal2.Checked = true;
            this.channal2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.channal2.Location = new System.Drawing.Point(636, 240);
            this.channal2.Name = "channal2";
            this.channal2.Size = new System.Drawing.Size(66, 16);
            this.channal2.TabIndex = 6;
            this.channal2.Text = "channal2";
            this.channal2.UseVisualStyleBackColor = true;
            // 
            // realtime_observation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 669);
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
    }
}

