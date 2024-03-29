﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.DAQmx;
using NationalInstruments;
using MathNet.Numerics;
using System.IO;
using System.Diagnostics;

namespace realtime_observation
{
    public partial class realtime_observation : Form
    {
        private AnalogMultiChannelReader analogInReader;
        private AIExcitationSource excitationSource;
        private AIAccelerometerSensitivityUnits sensitivityUnits;
        private AITerminalConfiguration terminalConfiguration;
        private AnalogEdgeStartTriggerSlope triggerSlope;
        private AICoupling inputCoupling;

        private NationalInstruments.DAQmx.Task myTask;
        private NationalInstruments.DAQmx.Task runningTask;
        private AsyncCallback analogCallback;
        private AnalogWaveform<double>[] data;

        int indexP;
        double SPmax;
        int iii;
        double[] maxrms = new double[2] { 0, 0 };
        double[] allrms0 = new double[1280];//
        double[] plotrms = new double[1280] ;
        double[] MSE = new double[1280];
        double allrms1;
        int indexplot,scale = 1 ;
        double[] time = new double[100];
        double starttime,warning,alarm;



        public StreamWriter SW_RMSData;
        public StreamWriter SW_RawData;
        public StreamWriter SW_entropy;

        public realtime_observation()
        {
            InitializeComponent();
            startbutton.Visible = true;
            stopbutton.Visible = false;
            greenlight.Visible = true;
            yellowlight.Visible = false;
            redlight.Visible = false;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {

            Refresh();
            starttime = DateTime.Now.TimeOfDay.TotalSeconds;
            startbutton.Visible = false;
            stopbutton.Visible = true;
            alarmtext.Enabled = false;
            savedata_checkBox.Enabled = false;
            StartDAQ(6000);
            
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            StopDAQ();
            startbutton.Visible = true;
            stopbutton.Visible = false;
            alarmtext.Enabled = true;
            savedata_checkBox.Enabled = true;
            Refresh();
        }

        public void StartDAQ(double a)
        {

            triggerSlope = AnalogEdgeStartTriggerSlope.Rising;
            sensitivityUnits = AIAccelerometerSensitivityUnits.MillivoltsPerG;
            terminalConfiguration = (AITerminalConfiguration)(-1);
            excitationSource = AIExcitationSource.Internal;
            inputCoupling = AICoupling.AC;

            myTask = new NationalInstruments.DAQmx.Task();
            AIChannel aiChannel;

            SPmax = a;
            double Vmin = -5;
            double Vmax = 5;
            double sen = 100;
            double EVN = 0.004;
            double[] chan = new double[4] { 1, 1, 1, 0 };
            if (savedata_checkBox.Checked == true)
            {
                SW_RMSData = new StreamWriter(System.Environment.CurrentDirectory + "\\logData\\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "_" + "RMSData.txt");
                SW_RawData = new StreamWriter(System.Environment.CurrentDirectory + "\\logData\\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "_" + "RawData.txt");
                SW_entropy = new StreamWriter(System.Environment.CurrentDirectory + "\\logData\\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "_" + "Entropy.txt");
                
            }



            for (int i = 0; i < chan.Length; i++)
            {
                if (chan[i] == 1)
                {
                    //擷取卡的名稱要改
                    aiChannel = myTask.AIChannels.CreateAccelerometerChannel("cDAQ1Mod1/ai" + Convert.ToString(i), "",
                        terminalConfiguration, Vmin, Vmax, sen, sensitivityUnits, excitationSource,
                        EVN, AIAccelerationUnits.G);
                    aiChannel.Coupling = inputCoupling;
                }

            }

            myTask.Timing.ConfigureSampleClock("", Convert.ToDouble(12800),
                SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, Convert.ToInt32(1280));

            myTask.Control(TaskAction.Verify);

            runningTask = myTask;
            analogInReader = new AnalogMultiChannelReader(myTask.Stream);
            analogCallback = new AsyncCallback(AnalogInCallback);



            analogInReader.SynchronizeCallbacks = true;
            analogInReader.BeginReadWaveform(Convert.ToInt32(1280), analogCallback, myTask);

        }

        public void StopDAQ()
        {
            // Dispose of the task
            if (savedata_checkBox.Checked == true)
            {
                SW_RMSData.Dispose();
                SW_RawData.Dispose();
                SW_entropy.Dispose();
            }


            runningTask = null;
            myTask.Dispose();
            maxrms[0] = 0;
            plotrms = new double[plotrms.Length];
            MSE = new double[MSE.Length];
            indexP = 0;
            indexplot = 0;
        }
        private void AnalogInCallback(IAsyncResult ar)
        {
            if (runningTask != null && runningTask == ar.AsyncState)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                // Read the available data from the channels
                
                data = analogInReader.EndReadWaveform(ar);

                


                double[] vecTime = new double[data[0].SampleCount];
                
                double[] d00 = data[0].GetRawData();
                double[] d10 = data[1].GetRawData();
                double[] d20 = data[2].GetRawData();
                PrecisionDateTime[] T = data[0].GetPrecisionTimeStamps();

                for (int i = 0; i < data[0].SampleCount; i++)
                {
                    vecTime[i] = T[i].TimeOfDay.TotalSeconds;
                }

                ////
                //Console.WriteLine("擷取時間");
                //Console.WriteLine(vecTime[vecTime.Length - 1]);//vecTime.Length - 1
                //Console.WriteLine("系統時間");
                //Console.WriteLine(DateTime.Now.TimeOfDay.TotalSeconds);
                //Console.WriteLine("時間相差");
                //Console.WriteLine(DateTime.Now.TimeOfDay.TotalSeconds - vecTime[vecTime.Length - 1]);
                ////
                ////////////////////////
                ///振動監控  
                allrms0 = new double[d00.Length];
                for (int i = 0; i < d00.Length; i++)
                {
                   allrms0[i] = Math.Sqrt(Math.Pow(d00[i], 2) + Math.Pow(d10[i], 2) + Math.Pow(d20[i], 2));
                }
                allrms1 = rootMeanSquare(allrms0);
                double[] allentropy = new double[scale];
                allentropy = MultiScale_Entropy.MultiScaleEn3(allrms0, scale);
                
                ///監控示波器
                if (indexplot > time.Length)
                {
                    for (int i = 0; i < time.Length-1; i++)
                    {
                        time[i] = time[i + 1];
                        plotrms[i] = plotrms[i + 1];
                        MSE[i] = MSE[i + 1];
                        
                    }
                    time[time.Length - 1] = time[time.Length - 1] + Convert.ToDouble(1280) / 12800;
                    plotrms[time.Length - 1] = allrms1;
                    MSE[time.Length - 1] = allentropy[0];
                }
                else
                {
                    time[0] = starttime;
                    for (int i = 1; i < time.Length; i++)//time.Length
                    {
                        time[i] = starttime + Convert.ToDouble(1280) / 12800 * i;
                    }
                    plotrms[indexplot] = allrms1;
                    MSE[indexplot] = allentropy[0];
                }
                ///
                indexplot++;
                maxrms[1] = allrms1;
                if (maxrms[0] < maxrms[1])
                {
                    maxrms[0] = maxrms[1];
                }
                alarm = Convert.ToDouble(alarmtext.Text);
                warning = 0.5 * alarm;

                
                if (savedata_checkBox.Checked ==true)
                {
                    for (int i = 0; i < d00.Length; i++)
                    {
                        SW_RawData.Write(d00[i]);
                        SW_RawData.Write(",");
                        SW_RawData.Write(d10[i]);
                        SW_RawData.Write(",");
                        SW_RawData.WriteLine(d20[i]);
                    }
                    SW_RMSData.Write(vecTime[0]);
                    SW_RMSData.Write(",");
                    SW_RMSData.WriteLine(allrms1);
                    SW_entropy.Write(vecTime[0]);
                    SW_entropy.Write(",");
                    SW_entropy.WriteLine(allentropy[0]);
                }
                
                
                ///
                ////////////////
                time_chart.Series[0].Points.Clear();
                time_chart.Series[1].Points.Clear();
                time_chart.Series[2].Points.Clear();
                time_chart.Series[3].Points.Clear();
                time_chart.Series[4].Points.Clear();
                time_chart.Series[5].Points.Clear();
                time_chart.Series[6].Points.Clear();
                time_chart.Series[7].Points.Clear();

                for (int i = 0; i < d00.Length; i++)
                {
                    if (channal0.Checked == true)
                    {
                        time_chart.Series[0].Enabled = true;
                        time_chart.Series[0].Points.AddXY(vecTime[i] , d00[i]);
                    }
                    else 
                    {
                        time_chart.Series[0].Enabled = false;
                    }
                    if (channal1.Checked == true)
                    {
                        time_chart.Series[1].Enabled = true;
                        time_chart.Series[1].Points.AddXY(vecTime[i] , d10[i]);
                    }
                    else
                    {
                        time_chart.Series[1].Enabled = false;
                    }
                    if (channal2.Checked == true)
                    {
                        time_chart.Series[2].Enabled = true;
                        time_chart.Series[2].Points.AddXY(vecTime[i] , d20[i]);
                    }
                    else
                    {
                        time_chart.Series[2].Enabled = false;
                    }
                }
                if (maxrms[0] >=5)
                {
                    maxrms[0] = 5;
                }
                //紅綠燈 可變
                if (allrms1 >= alarm)//maxrms[0] >= alarm  allrms1
                {
                    redlight.Visible = true;
                    greenlight.Visible = false;
                    yellowlight.Visible = false;
                }
                else if (allrms1 >= warning && allrms1 < alarm)//maxrms[0] >= warning && maxrms[0] < alarm
                {
                    redlight.Visible = false;
                    greenlight.Visible = false;
                    yellowlight.Visible = true;
                }
                else
                {
                    redlight.Visible = false;
                    greenlight.Visible = true;
                    yellowlight.Visible = false;
                }
                //
                for (int i = 0; i < time.Length; i++)
                {
                    if (vibrationmonitor.Checked == true)
                    {
                        time_chart.Series[3].Enabled = true;
                        time_chart.Series[4].Enabled = true;
                        time_chart.Series[5].Enabled = true;
                        time_chart.Series[6].Enabled = true;
                        time_chart.Series[3].Points.AddXY(Math.Round((time[i] - starttime),2), plotrms[i]);
                        time_chart.Series[4].Points.AddXY(Math.Round((time[i] - starttime), 2), alarm);
                        time_chart.Series[5].Points.AddXY(Math.Round((time[i] - starttime), 2), warning);
                        time_chart.Series[6].Points.AddXY(Math.Round((time[i] - starttime), 2), maxrms[0]);
                        time_chart.Series[7].Points.AddXY(Math.Round((time[i] - starttime), 2), MSE[i]);
                        time_chart.ChartAreas[0].AxisY.Minimum = 0;
                        time_chart.ChartAreas[0].AxisY.Maximum = 5;
                    }
                    else
                    {
                        redlight.Visible = false;
                        greenlight.Visible = false;
                        yellowlight.Visible = false;
                        time_chart.Series[3].Enabled = false;
                        time_chart.Series[4].Enabled = false;
                        time_chart.Series[5].Enabled = false;
                        time_chart.Series[6].Enabled = false;
                        time_chart.ChartAreas[0].AxisY.Minimum = double.NaN;
                        time_chart.ChartAreas[0].AxisY.Maximum = double.NaN;
                    }
                }




                //save rawdata
                
                    
              


                //double rms = rootMeanSquare(d00);
                //Console.WriteLine(rms);


                //


                //////////double[] d0 = new double[d00.Length];
                //////////double[] d1 = new double[d10.Length];
                //////////double[] d2 = new double[d20.Length];
                //////////////Console.WriteLine(d00.Length);
                //////////for (int i = 0; i < d0.Length; i++)
                //////////{
                //////////    d0[i] = (d00[i] - d00.Average()) * 10;
                //////////    d1[i] = (d10[i] - d10.Average()) * 10;
                //////////    d2[i] = (d20[i] - d20.Average()) * 10;
                //////////}
                


                //////////double varFs = 1 / ((vecTime[data[0].SampleCount - 1] - vecTime[0]) / data[0].SampleCount);

                //////////////int indexMaterial = CUTeffiForm.indexMaterial;

                ////////////double rms_xdata = rootMeanSquare(d0) * 10;
                ////////////double rms_ydata = rootMeanSquare(d1) * 10;
                ////////////double rms_vibration = Math.Sqrt(Math.Pow(rms_xdata, 2) + Math.Pow(rms_ydata, 2));


                //////////////////////////////////////FFT////////////////////////////////////////
                //////////double datalength = d0.Length * 2;
                //////////double[] d0Copy = new double[d0.Length * 2];//*10 d0.Length*5 12800                 
                //////////double[] d1Copy = new double[d1.Length * 2];
                //////////double[] d2Copy = new double[d2.Length * 2];
                //////////for (int i = 0; i < d0.Length; i++)
                //////////{
                //////////    d0Copy[i] = d0[i];
                //////////    d1Copy[i] = d1[i];
                //////////    d2Copy[i] = d2[i];
                //////////}

                //////////double[] realdata0 = d0Copy;
                //////////double[] imagdata0 = new double[d0Copy.Length];
                //////////double[] realdata1 = d1Copy;
                //////////double[] imagdata1 = new double[d1Copy.Length];
                //////////double[] realdata2 = d2Copy;
                //////////double[] imagdata2 = new double[d2Copy.Length];

                //////////int numFFT = Convert.ToInt16(Math.Floor(Convert.ToDecimal(d0Copy.Length / 2)));
                //////////double[] vecFFT0 = new double[numFFT];
                //////////double[] vecFFT1 = new double[numFFT];
                //////////double[] vecFFT2 = new double[numFFT];
                //////////double[] vecFqtmp = new double[numFFT];

                //////////for (int i = 1; i < numFFT; i++)
                //////////{
                //////////    vecFqtmp[i] = vecFqtmp[i - 1] + (varFs / d0Copy.Length);
                //////////}

                //////////MathNet.Numerics.IntegralTransforms.Fourier.Forward(realdata0, imagdata0, MathNet.Numerics.IntegralTransforms.FourierOptions.Matlab);
                //////////MathNet.Numerics.IntegralTransforms.Fourier.Forward(realdata1, imagdata1, MathNet.Numerics.IntegralTransforms.FourierOptions.Matlab);
                //////////MathNet.Numerics.IntegralTransforms.Fourier.Forward(realdata2, imagdata2, MathNet.Numerics.IntegralTransforms.FourierOptions.Matlab);

                //////////for (int i = 0; i < numFFT; i++)
                //////////{
                //////////    vecFFT0[i] = Math.Sqrt(Math.Pow(realdata0[i], 2) + Math.Pow(imagdata0[i], 2));
                //////////    vecFFT1[i] = Math.Sqrt(Math.Pow(realdata1[i], 2) + Math.Pow(imagdata1[i], 2));
                //////////    vecFFT2[i] = Math.Sqrt(Math.Pow(realdata2[i], 2) + Math.Pow(imagdata2[i], 2));
                //////////}


                //////////FFT_chart.Series[0].Points.Clear();
                //////////FFT_chart.Series[1].Points.Clear();
                //////////FFT_chart.Series[2].Points.Clear();
                //////////double freq = 12800 / datalength;
                //////////textBox3.Text = Convert.ToString(freq);
                //////////int frequency_range =Convert.ToInt32( textBox4.Text);

                //////////for (int j = 0; j * freq < frequency_range; j++)//vecFFT.Length
                //////////{
                //////////    if (channal0.Checked == true)
                //////////    {
                //////////        FFT_chart.Series[0].Points.AddXY(j * freq, vecFFT0[j]);
                //////////    }
                //////////    if (channal1.Checked == true)
                //////////    {
                //////////        FFT_chart.Series[1].Points.AddXY(j * freq, vecFFT0[j]);
                //////////    }
                //////////    if (channal2.Checked == true)
                //////////    {
                //////////        FFT_chart.Series[2].Points.AddXY(j * freq, vecFFT0[j]);
                //////////    }
                //////////}
                //save FFT data

                //for (int j = 0; j * freq < 300; j++)
                //{
                //    SW_FFTDataX.Write(j * freq);
                //    SW_FFTDataX.Write(",");
                //    SW_FFTDataX.WriteLine(vecFFT[j]);
                //}
                ////
                analogInReader.BeginMemoryOptimizedReadWaveform(Convert.ToInt32(1280), analogCallback, myTask, data);
                sw.Stop();
                TimeSpan ts2 = sw.Elapsed;
                Console.WriteLine(ts2);
            }
        }

        private static double rootMeanSquare(double[] x)
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += (x[i] * x[i]);
            }
            return Math.Sqrt(sum / x.Length);
        }


    }
}
