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
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(realtime_observation));
            this.time_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.channal0 = new System.Windows.Forms.CheckBox();
            this.channal1 = new System.Windows.Forms.CheckBox();
            this.channal2 = new System.Windows.Forms.CheckBox();
            this.vibrationmonitor = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alarmtext = new System.Windows.Forms.TextBox();
            this.greenlight = new System.Windows.Forms.PictureBox();
            this.yellowlight = new System.Windows.Forms.PictureBox();
            this.redlight = new System.Windows.Forms.PictureBox();
            this.savedata_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.time_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redlight)).BeginInit();
            this.SuspendLayout();
            // 
            // time_chart
            // 
            this.time_chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 18;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.Format = "n1";
            chartArea1.AxisX.Title = "Time(sec)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 18;
            chartArea1.AxisY.Title = "Vibration(g)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.time_chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend2";
            this.time_chart.Legends.Add(legend1);
            this.time_chart.Legends.Add(legend2);
            this.time_chart.Location = new System.Drawing.Point(12, 12);
            this.time_chart.Name = "time_chart";
            this.time_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.Green;
            series4.Legend = "Legend1";
            series4.Name = "RMS";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series5.Legend = "Legend2";
            series5.MarkerColor = System.Drawing.Color.Red;
            series5.Name = "Alarm";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series6.Legend = "Legend2";
            series6.MarkerColor = System.Drawing.Color.Gold;
            series6.Name = "Warning";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series7.Legend = "Legend2";
            series7.Name = "Max";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Legend = "Legend1";
            series8.Name = "mse";
            this.time_chart.Series.Add(series1);
            this.time_chart.Series.Add(series2);
            this.time_chart.Series.Add(series3);
            this.time_chart.Series.Add(series4);
            this.time_chart.Series.Add(series5);
            this.time_chart.Series.Add(series6);
            this.time_chart.Series.Add(series7);
            this.time_chart.Series.Add(series8);
            this.time_chart.Size = new System.Drawing.Size(1200, 840);
            this.time_chart.TabIndex = 0;
            this.time_chart.Text = "chart1";
            title1.Name = "Title1";
            this.time_chart.Titles.Add(title1);
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startbutton.Location = new System.Drawing.Point(1247, 651);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(113, 107);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stopbutton.Location = new System.Drawing.Point(1247, 651);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(113, 107);
            this.stopbutton.TabIndex = 2;
            this.stopbutton.Text = "stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // channal0
            // 
            this.channal0.AutoSize = true;
            this.channal0.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.channal0.Location = new System.Drawing.Point(1247, 504);
            this.channal0.Name = "channal0";
            this.channal0.Size = new System.Drawing.Size(123, 31);
            this.channal0.TabIndex = 6;
            this.channal0.Text = "channal0";
            this.channal0.UseVisualStyleBackColor = true;
            // 
            // channal1
            // 
            this.channal1.AutoSize = true;
            this.channal1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.channal1.Location = new System.Drawing.Point(1247, 540);
            this.channal1.Name = "channal1";
            this.channal1.Size = new System.Drawing.Size(123, 31);
            this.channal1.TabIndex = 6;
            this.channal1.Text = "channal1";
            this.channal1.UseVisualStyleBackColor = true;
            // 
            // channal2
            // 
            this.channal2.AutoSize = true;
            this.channal2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.channal2.Location = new System.Drawing.Point(1247, 577);
            this.channal2.Name = "channal2";
            this.channal2.Size = new System.Drawing.Size(123, 31);
            this.channal2.TabIndex = 6;
            this.channal2.Text = "channal2";
            this.channal2.UseVisualStyleBackColor = true;
            // 
            // vibrationmonitor
            // 
            this.vibrationmonitor.AutoSize = true;
            this.vibrationmonitor.Checked = true;
            this.vibrationmonitor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vibrationmonitor.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.vibrationmonitor.Location = new System.Drawing.Point(1247, 614);
            this.vibrationmonitor.Name = "vibrationmonitor";
            this.vibrationmonitor.Size = new System.Drawing.Size(139, 31);
            this.vibrationmonitor.TabIndex = 7;
            this.vibrationmonitor.Text = "振動監控";
            this.vibrationmonitor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(1242, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alarm";
            // 
            // alarmtext
            // 
            this.alarmtext.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.alarmtext.Location = new System.Drawing.Point(1247, 455);
            this.alarmtext.Name = "alarmtext";
            this.alarmtext.Size = new System.Drawing.Size(113, 40);
            this.alarmtext.TabIndex = 9;
            this.alarmtext.Text = "4";
            // 
            // greenlight
            // 
            this.greenlight.Image = global::realtime_observation.Properties.Resources.image_green;
            this.greenlight.Location = new System.Drawing.Point(1006, 531);
            this.greenlight.Name = "greenlight";
            this.greenlight.Size = new System.Drawing.Size(200, 200);
            this.greenlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenlight.TabIndex = 10;
            this.greenlight.TabStop = false;
            // 
            // yellowlight
            // 
            this.yellowlight.Image = global::realtime_observation.Properties.Resources.image_yellowlight;
            this.yellowlight.Location = new System.Drawing.Point(1006, 531);
            this.yellowlight.Name = "yellowlight";
            this.yellowlight.Size = new System.Drawing.Size(200, 200);
            this.yellowlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowlight.TabIndex = 11;
            this.yellowlight.TabStop = false;
            // 
            // redlight
            // 
            this.redlight.Image = global::realtime_observation.Properties.Resources.image_red;
            this.redlight.Location = new System.Drawing.Point(1006, 531);
            this.redlight.Name = "redlight";
            this.redlight.Size = new System.Drawing.Size(200, 200);
            this.redlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redlight.TabIndex = 12;
            this.redlight.TabStop = false;
            // 
            // savedata_checkBox
            // 
            this.savedata_checkBox.AutoSize = true;
            this.savedata_checkBox.Font = new System.Drawing.Font("新細明體", 20.25F);
            this.savedata_checkBox.Location = new System.Drawing.Point(1247, 764);
            this.savedata_checkBox.Name = "savedata_checkBox";
            this.savedata_checkBox.Size = new System.Drawing.Size(118, 31);
            this.savedata_checkBox.TabIndex = 14;
            this.savedata_checkBox.Text = "savedata";
            this.savedata_checkBox.UseVisualStyleBackColor = true;
            // 
            // realtime_observation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.savedata_checkBox);
            this.Controls.Add(this.redlight);
            this.Controls.Add(this.yellowlight);
            this.Controls.Add(this.greenlight);
            this.Controls.Add(this.alarmtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vibrationmonitor);
            this.Controls.Add(this.channal2);
            this.Controls.Add(this.channal1);
            this.Controls.Add(this.channal0);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.time_chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "realtime_observation";
            this.Text = "realtime_observation";
            ((System.ComponentModel.ISupportInitialize)(this.time_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart time_chart;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.CheckBox channal0;
        private System.Windows.Forms.CheckBox channal1;
        private System.Windows.Forms.CheckBox channal2;
        private System.Windows.Forms.CheckBox vibrationmonitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alarmtext;
        private System.Windows.Forms.PictureBox greenlight;
        private System.Windows.Forms.PictureBox yellowlight;
        private System.Windows.Forms.PictureBox redlight;
        private System.Windows.Forms.CheckBox savedata_checkBox;
    }
}

