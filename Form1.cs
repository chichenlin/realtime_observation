using System;
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

namespace test
{
    public partial class plotfigure : Form
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
        //public StreamWriter SW_RMSData;
        //public StreamWriter SW_State;
        //public StreamWriter SW_RawDataX;
        //public StreamWriter SW_FFTDataX;

        public plotfigure()
        {
            InitializeComponent();
            startbutton.Visible = true;
            stopbutton.Visible = false;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            
            Refresh();
            startbutton.Visible = false;
            stopbutton.Visible = true;
            time_chart.Series[0].Points.Clear();
            StartDAQ(6000);
            
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            StopDAQ();
            startbutton.Visible = true;
            stopbutton.Visible = false;
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
            //SW_RMSData = new StreamWriter(System.Environment.CurrentDirectory + "\\logData\\RMSData.txt");
            //SW_State = new StreamWriter(System.Environment.CurrentDirectory + "\\logData\\State.txt");
            //SW_RawDataX = new StreamWriter(System.Environment.CurrentDirectory + "\\logData\\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "_" + a + "_" + "RawDataX.txt");
            //SW_FFTDataX = new StreamWriter(System.Environment.CurrentDirectory + "\\logData\\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "_" + a + "_" + "FFTDataX.txt");


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
                SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, Convert.ToInt32(samplepoint.Text));

            myTask.Control(TaskAction.Verify);

            runningTask = myTask;
            analogInReader = new AnalogMultiChannelReader(myTask.Stream);
            analogCallback = new AsyncCallback(AnalogInCallback);



            analogInReader.SynchronizeCallbacks = true;
            analogInReader.BeginReadWaveform(Convert.ToInt32(samplepoint.Text), analogCallback, myTask);

        }

        public void StopDAQ()
        {
            // Dispose of the task
            //SW_RMSData.Dispose();
            //SW_State.Dispose();
            //SW_RawDataX.Dispose();
            //SW_FFTDataX.Dispose();

            runningTask = null;
            myTask.Dispose();

            indexP = 0;
            iii = 0;
        }
        private void AnalogInCallback(IAsyncResult ar)
        {
            if (runningTask != null && runningTask == ar.AsyncState)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                // Read the available data from the channels
                data = analogInReader.EndReadWaveform(ar);

                sw.Stop();
                TimeSpan ts2 = sw.Elapsed;
                Console.WriteLine(ts2);


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
                time_chart.Series[0].Points.Clear();
                time_chart.Series[1].Points.Clear();
                time_chart.Series[2].Points.Clear();
                
                for (int i = 0; i < d00.Length; i++)
                {
                    if(channal1.Checked == true)
                    {
                        time_chart.Series[0].Points.AddXY(vecTime[i] - vecTime[0], d00[i]);
                    }
                    if (channal2.Checked == true)
                    {
                        time_chart.Series[1].Points.AddXY(vecTime[i] - vecTime[0], d10[i]);
                    }
                    if (channal3.Checked == true)
                    {
                        time_chart.Series[2].Points.AddXY(vecTime[i] - vecTime[0], d20[i]);
                    }
                }

               

                //save rawdata
                //for (int i = 0; i < d00.Length; i++)
                //{
                //    SW_RawDataX.Write(vecTime[i]);
                //    SW_RawDataX.Write(",");
                //    SW_RawDataX.WriteLine(d00[i]);
                //}
                //

                //double rms = rootMeanSquare(d00);
                //Console.WriteLine(rms);


                //


                double[] d0 = new double[d00.Length];
                double[] d1 = new double[d10.Length];
                //Console.WriteLine(d00.Length);
                for (int i = 0; i < d0.Length; i++)
                {
                    d0[i] = (d00[i] - d00.Average()) * 10;
                    d1[i] = (d10[i] - d10.Average()) * 10;
                }

             
                double varFs = 1 / ((vecTime[data[0].SampleCount - 1] - vecTime[0]) / data[0].SampleCount);

                //int indexMaterial = CUTeffiForm.indexMaterial;

                double rms_xdata = rootMeanSquare(d0) * 10;
                double rms_ydata = rootMeanSquare(d1) * 10;
                double rms_vibration = Math.Sqrt(Math.Pow(rms_xdata, 2) + Math.Pow(rms_ydata, 2));


                ////////////////////////////FFT////////////////////////////////////////
                double datalength = d0.Length * 2;
                double[] d0Copy = new double[d0.Length*2];//*10 d0.Length*5 12800                 

                for (int i = 0; i < d0.Length; i++)
                {
                    d0Copy[i] = d0[i];
                }

                double[] realdata = d0Copy;
                double[] imagdata = new double[d0Copy.Length];

                int numFFT = Convert.ToInt16(Math.Floor(Convert.ToDecimal(d0Copy.Length / 2)));
                double[] vecFFT = new double[numFFT];
                double[] vecFqtmp = new double[numFFT];

                for (int i = 1; i < numFFT; i++)
                {
                    vecFqtmp[i] = vecFqtmp[i - 1] + (varFs / d0Copy.Length);
                }

                MathNet.Numerics.IntegralTransforms.Fourier.Forward(realdata, imagdata, MathNet.Numerics.IntegralTransforms.FourierOptions.Matlab);

                for (int i = 0; i < numFFT; i++)
                {
                    vecFFT[i] = Math.Sqrt(Math.Pow(realdata[i], 2) + Math.Pow(imagdata[i], 2));
                }

                FFT_chart.Series[0].Points.Clear();
                double freq = 12800 / datalength;
                textBox3.Text = Convert.ToString(freq);
                int frequency_range =Convert.ToInt32( textBox4.Text);

                for (int j = 0; j * freq < frequency_range; j++)//vecFFT.Length
                {
                    FFT_chart.Series[0].Points.AddXY(j*freq, vecFFT[j]);
                }
                //save FFT data

                //for (int j = 0; j * freq < 300; j++)
                //{
                //    SW_FFTDataX.Write(j * freq);
                //    SW_FFTDataX.Write(",");
                //    SW_FFTDataX.WriteLine(vecFFT[j]);
                //}
                ////
                analogInReader.BeginMemoryOptimizedReadWaveform(Convert.ToInt32(samplepoint.Text), analogCallback, myTask, data);

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
