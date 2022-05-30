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

namespace Umbrall
{
    public partial class MonitorGui : Form
    {
        public MonitorGui()
        {
            InitializeComponent();
        }

        

        private void MonitorGui_Load(object sender, EventArgs e)
        {
           
            Timer showParameters = new Timer();
            showParameters.Interval = 1000;
            showParameters.Enabled = true;
            showParameters.Tick += ShowingParameters;

            Monitor.VrmsChart(chart1);

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
        
        private void VrmsChart(Chart chart, float vrmsABC, float freq)
        {
            // Make the object for Series and Areas
            SeriesCollection chartVrmsSeries = chart.Series;
            ChartAreaCollection chartVrmsAreas = chart.ChartAreas;
            chartVrmsSeries.Add("Vrms");                            // Se agrega serie de Vrms

            ChartArea chartVrmsArea = chartVrmsAreas[0];
            Series chartVrmsSerie = chartVrmsSeries[0];            // Se selecciona la primer serie 

        }
    }
}
