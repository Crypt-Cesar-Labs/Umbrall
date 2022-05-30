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

            SeriesCollection chart1Series = chart1.Series;              // Se hace una instancia para la manipulación de Series
            SeriesCollection chart2Series = chart2.Series;          

            ChartAreaCollection chart1Areas = chart1.ChartAreas;        // Se hace una instancia para la manipulación de Areas
            ChartAreaCollection chart2Areas = chart2.ChartAreas;        // Se hace una instancia para la manipulación de Areas

            chart1Series.Add("Serie1 Left");                                // Se crea una serie ya que por defecto ho se generan
            chart2Series.Add("Serie2 Right");

            
            ChartArea chart1Area1 = chart1Areas[0];                     // Se crea un objeto que representa ChartAreas[0]
            Series chart1Serie1 = chart1Series[0];                      // Se crea un objeto que representa Series[0]
            ChartArea chart2Area1 = chart2Areas[0];                    // Se crea un objeto que representa ChartAreas[0]
            Series chart2Serie1 = chart2Series[0];                      // Se crea un objeto que representa Series[0]

            chart1Areas.Add("nueva area");
            ChartArea chart1Area2 = chart1Areas[1];
            chart1Area2.BackColor = Color.Yellow;

            // Modificando el Area1
            chart1Area1.BackColor = Color.Black;
            chart2Area1.BackColor = Color.Black;

            // Modificando la Serie1
            chart1Serie1.ChartType = SeriesChartType.FastLine;
            chart1Serie1.Color = Color.Red;

            // Puntos de la gráfica
            chart1Serie1.Points.AddXY(0, 10);
            chart1Serie1.Points.AddXY(1, 15);
            chart1Serie1.Points.AddXY(2, 10);
            chart1Serie1.Points.AddXY(3, 12);
            chart1Serie1.Points.AddXY(4, 6);

            // Modificando la Serie1
            chart2Serie1.ChartType = SeriesChartType.FastLine;
            chart2Serie1.Color = Color.Blue;

            // Puntos de la gráfica
            chart2Serie1.Points.AddXY(1, 11);
            chart2Serie1.Points.AddXY(2, 13);
            chart2Serie1.Points.AddXY(3, 18);
            chart2Serie1.Points.AddXY(4, 6);


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
