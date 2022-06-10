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
        private Thread showParamsThread;
        private void MonitorGui_Load(object sender, EventArgs e)
        {

            /*showParameters = new System.Windows.Forms.Timer();
            showParameters.Interval = 3000;
            showParameters.Enabled = true;
            showParameters.Tick += ShowingParameters;*/
            
            chart1Thread = new Thread(new ThreadStart(this.getVrmsCounters));
            chart1Thread.IsBackground = true;
            chart1Thread.Start();

            showParamsThread = new Thread(new ThreadStart(this.showParamsLoop));
            showParamsThread.IsBackground = true;
            showParamsThread.Start();

        }

        private void getVrmsCounters()
        {
            var vrmsValue = Monitor.vrmsABC;

            while (true)
            {
                Thread.Sleep(2000);
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

        private void showParamsLoop()
        {
            while (true)
            {
                Thread.Sleep(2000);
                ShowingParameters();
            }
        }

        private void UpdateVrmsChart()
        {
            chart1.Series["Series1"].Points.Clear();

            for (int i = 0; i < vrmsArray.Length - 1; i++)
            {
                chart1.Series["Series1"].Points.AddY(vrmsArray[i]);
            }
        }

        private void ShowingParameters()
        {
            Thread.Sleep(500);
            txtVrmsA.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtVrmsA, Monitor.vrmsA.ToString());  });
            Thread.Sleep(500);
            //txtVrmsB.Text = Monitor.vrmsB.ToString();
            txtVrmsB.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtVrmsB, Monitor.vrmsB.ToString()); });
            Thread.Sleep(500);
            //txtVrmsC.Text = Monitor.vrmsC.ToString();
            txtVrmsC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtVrmsC, Monitor.vrmsC.ToString()); });
            Thread.Sleep(500);
            //txtVrmsABC.Text = Monitor.vrmsABC.ToString();
            txtVrmsABC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtVrmsABC, Monitor.vrmsABC.ToString()); });
            Thread.Sleep(500);
            //txtIrmsA.Text = Monitor.irmsA.ToString();
            txtIrmsA.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtIrmsA, Monitor.irmsA.ToString()); });
            Thread.Sleep(500);
            //txtIrmsB.Text = Monitor.irmsB.ToString();
            txtIrmsB.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtIrmsB, Monitor.irmsB.ToString()); });
            Thread.Sleep(500);
            //txtIrmsC.Text = Monitor.irmsC.ToString();
            txtIrmsC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtIrmsC, Monitor.irmsC.ToString()); });
            Thread.Sleep(500);
            //txtIrmsABC.Text = Monitor.irmsABC.ToString();
            txtIrmsABC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtIrmsABC, Monitor.irmsABC.ToString()); });
            Thread.Sleep(500);
            //txtFreq.Text = Monitor.frequency.ToString();
            txtFreq.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtFreq, Monitor.frequency.ToString()); });
            Thread.Sleep(500);
            //txtPActiveA.Text = Monitor.pActiveA.ToString();
            txtPActiveA.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtPActiveA, Monitor.pActiveA.ToString()); });
            Thread.Sleep(500);
            //txtPActiveB.Text = Monitor.pActiveB.ToString();
            txtPActiveB.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtPActiveB, Monitor.pActiveB.ToString()); });
            Thread.Sleep(500);
            //txtPActiveC.Text = Monitor.pActiveC.ToString();
            txtPActiveC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtPActiveC, Monitor.pActiveC.ToString()); });
            Thread.Sleep(500);
            //txtPActiveABC.Text = Monitor.pActiveABC.ToString();
            txtPActiveABC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtPActiveABC, Monitor.pActiveABC.ToString()); });
            Thread.Sleep(500);
            //txtQA.Text = Monitor.qA.ToString();
            txtQA.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtQA, Monitor.qA.ToString()); });
            Thread.Sleep(500);
            //txtQB.Text = Monitor.qB.ToString();
            txtQB.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtQB, Monitor.qB.ToString()); });
            Thread.Sleep(500);
            //txtQC.Text = Monitor.qC.ToString();
            txtQC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtQC, Monitor.qC.ToString()); });
            Thread.Sleep(500);
            //txtQABC.Text = Monitor.qABC.ToString();
            txtQABC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtQABC, Monitor.qABC.ToString()); });
            Thread.Sleep(500);
            //txtSA.Text = Monitor.sA.ToString();
            txtSA.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtSA, Monitor.sA.ToString()); });
            Thread.Sleep(500);
            //txtSB.Text = Monitor.sB.ToString();
            txtSB.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtSB, Monitor.sB.ToString()); });
            Thread.Sleep(500);
            //txtSC.Text = Monitor.sC.ToString();
            txtSC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtSC, Monitor.sC.ToString()); });
            Thread.Sleep(500);
            //txtSABC.Text = Monitor.sABC.ToString();
            txtSABC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtSABC, Monitor.sABC.ToString()); });
            Thread.Sleep(500);
            //txtCosfiA.Text = Monitor.cosfiA.ToString();
            txtCosfiA.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtCosfiA, Monitor.cosfiA.ToString()); });
            Thread.Sleep(500);
            //txtCosfiB.Text = Monitor.cosfiB.ToString();
            txtCosfiB.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtCosfiB, Monitor.cosfiB.ToString()); });
            Thread.Sleep(500);
            //txtCosfiC.Text = Monitor.cosfiC.ToString();
            txtCosfiC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtCosfiC, Monitor.cosfiC.ToString()); });
            Thread.Sleep(500);
            //txtCosfiABC.Text = Monitor.cosfiABC.ToString();
            txtCosfiABC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtCosfiABC, Monitor.cosfiABC.ToString()); });
            Thread.Sleep(500);
            //txtEnergyA.Text = Monitor.energyA.ToString();
            txtEnergyA.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtEnergyA, Monitor.energyA.ToString()); });
            Thread.Sleep(500);
            //txtEnergyB.Text = Monitor.energyB.ToString();
            txtEnergyB.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtEnergyB, Monitor.energyB.ToString()); });
            Thread.Sleep(500);
            //txtEnergyC.Text = Monitor.energyC.ToString();
            txtEnergyC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtEnergyC, Monitor.energyC.ToString()); });
            Thread.Sleep(500);
            //txtEnergyABC.Text = Monitor.energyABC.ToString();
            txtEnergyABC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtEnergyABC, Monitor.energyABC.ToString()); });
            Thread.Sleep(500);
            //txtReactiveA.Text = Monitor.reactEnergyA.ToString();
            txtReactiveA.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtReactiveA, Monitor.reactEnergyA.ToString()); });
            Thread.Sleep(500);
            //txtReactiveB.Text = Monitor.reactEnergyB.ToString();
            txtReactiveB.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtReactiveB, Monitor.reactEnergyB.ToString()); });
            Thread.Sleep(500);
            //txtReactiveC.Text = Monitor.reactEnergyC.ToString();
            txtReactiveC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtReactiveC, Monitor.reactEnergyC.ToString()); });
            Thread.Sleep(500);
            //txtReactiveABC.Text = Monitor.reactEnergyABC.ToString();
            txtReactiveABC.Invoke((MethodInvoker)delegate { UpdateValueTxt(txtReactiveABC, Monitor.reactEnergyABC.ToString()); });
            Thread.Sleep(500);

        }

        private void UpdateValueTxt(TextBox txtObj, string value)
        {
            txtObj.Text = value;
        }

        #region ShowingParams
        /*private void ShowingParameters(object sender, EventArgs e)
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
   
        }*/
        #endregion

        private void MonitorGui_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*showParameters.Stop();
            showParameters.Enabled = false;*/
            chart1Thread.Abort();
            showParamsThread.Abort();
        }
    }
}
