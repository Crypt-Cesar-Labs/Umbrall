using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Threading;

namespace Umbrall
{
    public partial class MonitorGui : Form
    {
        public MonitorGui()
        {
            InitializeComponent();
        }

        private Thread chart1Thread;
        public static System.Windows.Forms.Timer showParameters;
        private double[] vrmsArray = new double[30];

        private void MonitorGui_Load(object sender, EventArgs e)
        {

            showParameters = new System.Windows.Forms.Timer();
            showParameters.Interval = 1000;
            showParameters.Enabled = true;
            showParameters.Tick += ShowingParameters;
            
            chart1Thread = new Thread(new ThreadStart(this.getVrmsCounters));
            chart1Thread.IsBackground = true;
            chart1Thread.Start();

        }

        private void getVrmsCounters()
        {
            var vrmsValue = Monitor.vrmsABC;

            while (true)
            {
                vrmsArray[vrmsArray.Length - 1] = Math.Round(vrmsValue, 0);

                Array.Copy(vrmsArray, 1, vrmsArray, 0, vrmsArray.Length - 1);

                if (chart1.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateVrmsChart(); });
                }
                else
                {
                    //.....
                }
            }
        }

        private void UpdateVrmsChart()
        {
            chart1.Series["Series1"].Points.Clear();

            for (int i = 0; i < vrmsArray.Length - 1; i++)
            {
                chart1.Series["Series"].Points.AddXY(vrmsArray[i]);
            }
        }

        private void ShowingParameters(object sender, EventArgs e)
        {
            // Showing monitor parameters
            txtVrmsA.Text = Monitor.vrmsA.ToString();
            txtVrmsB.Text = Monitor.vrmsB.ToString();
            txtVrmsC.Text = Monitor.vrmsC.ToString();
            txtVrmsABC.Text = Monitor.vrmsABC.ToString();
            txtIrmsA.Text = Monitor.irmsA.ToString();
            txtIrmsB.Text = Monitor.irmsB.ToString();
            txtIrmsC.Text = Monitor.irmsC.ToString();
            txtIrmsABC.Text = Monitor.irmsABC.ToString();
            txtFreq.Text = Monitor.frequency.ToString();
            txtPActiveA.Text = Monitor.pActiveA.ToString();
            txtPActiveB.Text = Monitor.pActiveB.ToString();
            txtPActiveC.Text = Monitor.pActiveC.ToString();
            txtPActiveABC.Text = Monitor.pActiveABC.ToString();
            txtQA.Text = Monitor.qA.ToString();
            txtQB.Text = Monitor.qB.ToString();
            txtQC.Text = Monitor.qC.ToString();
            txtQABC.Text = Monitor.qABC.ToString();
            txtSA.Text = Monitor.sA.ToString();
            txtSB.Text = Monitor.sB.ToString();
            txtSC.Text = Monitor.sC.ToString();
            txtSABC.Text = Monitor.sABC.ToString();
            txtCosfiA.Text = Monitor.cosfiA.ToString();
            txtCosfiB.Text = Monitor.cosfiB.ToString();
            txtCosfiC.Text = Monitor.cosfiC.ToString();
            txtCosfiABC.Text = Monitor.cosfiABC.ToString();
            txtEnergyA.Text = Monitor.energyA.ToString();
            txtEnergyB.Text = Monitor.energyB.ToString();
            txtEnergyC.Text = Monitor.energyC.ToString();
            txtEnergyABC.Text = Monitor.energyABC.ToString();
            txtReactiveA.Text = Monitor.reactEnergyA.ToString();
            txtReactiveB.Text = Monitor.reactEnergyB.ToString();
            txtReactiveC.Text = Monitor.reactEnergyC.ToString();
            txtReactiveABC.Text = Monitor.reactEnergyABC.ToString();
   
        }

        private void MonitorGui_FormClosed(object sender, FormClosedEventArgs e)
        {
            showParameters.Stop();
            showParameters.Enabled = false;
        }
    }
}
