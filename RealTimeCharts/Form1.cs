using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MathNet.Numerics.Distributions;

namespace RealTimeCharts
{
    public partial class Form1 : Form
    {
        private Thread computingThread;
        private bool isRunning = false;
        private double A = 1;
        private Normal normalDis;
        public Form1()
        {
            InitializeComponent();
            Chart.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            normalDis = new Normal(GetMean(), GetStdDev());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                Chart.Series[0].Points.Clear();
                Chart.Series[1].Points.Clear();
                isRunning = true;
                button1.Text = "Stop!";
                computingThread = new Thread(new ThreadStart(RealTimeCharts));
                computingThread.IsBackground = true;
                computingThread.Start();
            }
            else
            {
                isRunning = false;
                computingThread.Abort();
                button1.Text = "Start!";
            }
        }
        private void RealTimeCharts()
        {
            double[] sinArray = new double[150];
            double[] gaussArray = new double[sinArray.Length];
            DateTime initialTime = DateTime.Now;

            while (isRunning)
            {
                TimeSpan time = DateTime.Now - initialTime;
                double sinus = Math.Sin(time.TotalSeconds);
                double value = A * sinus;

                sinArray[sinArray.Length - 1] = value;
                Array.Copy(sinArray, 1, sinArray, 0, sinArray.Length - 1);

                double gaussValue = value + normalDis.Sample();
                gaussArray[gaussArray.Length - 1] = gaussValue;
                Array.Copy(gaussArray, 1, gaussArray, 0, gaussArray.Length - 1);

                if (Chart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateChart(sinArray, gaussArray); });
                }
                Thread.Sleep(100);
            }
        }
        private void UpdateChart(double[] array1, double[] array2)
        {
            Chart.Series[0].Points.Clear();
            Chart.Series[1].Points.Clear();
            for (int i = 0; i < array1.Length - 1; i++)
            {
                Chart.Series[0].Points.AddY(array1[i]);
                Chart.Series[1].Points.AddY(array2[i]);
            }
        }
        private double GetStdDev()
        {
            if (StdDevTextBox.Text != "")
                try {
                    return Convert.ToDouble(StdDevTextBox.Text);
                }
                catch(Exception e)
                {
                    MessageBox.Show("Invalid format!");
                    StdDevTextBox.Text = "0,5";
                    return 1d;
                }
            else
            {
                return 1d;
            }
        }
        private double GetMean()
        {
            if (MeanTextBox.Text != "")
                try
                {
                    return Convert.ToDouble(MeanTextBox.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Invalid format!");
                    MeanTextBox.Text = "0,0";
                    return 0d;
                }
            else
            {
                return 0d;
            }
        }

        private void MeanTextBox_TextChanged(object sender, EventArgs e)
        {
            normalDis = new Normal(GetMean(), GetStdDev());
        }

        private void StdDevTextBox_TextChanged(object sender, EventArgs e)
        {
            normalDis = new Normal(GetMean(), GetStdDev());
        }

        private void AmplitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AmplitudeTextBox.Text != "")
            {
                try
                {
                    A = Convert.ToDouble(AmplitudeTextBox.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Invalid format!");
                    AmplitudeTextBox.Text = "1,0";
                    A = 1;
                    Console.WriteLine(exception);
                }
            }
        }
    }
}
