using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            #region DataGrid
            /*
            // Se modifican los estilos de el dataGridView
            AlternarColorenDataGridView(dataGridViewMonitor);

            int sizeColumn1 = 123;
            int sizeColumn2 = 114;
            // Creating the dataGridViewMonitor Columns
            dataGridViewMonitor.ColumnCount = 9;
            dataGridViewMonitor.Columns[0].Name = "Linea";
            dataGridViewMonitor.Columns[0].Width = sizeColumn1;     //
            dataGridViewMonitor.Columns[1].Name = "Vrms";
            dataGridViewMonitor.Columns[1].Width = sizeColumn2;     //
            dataGridViewMonitor.Columns[2].Name = "Irms";
            dataGridViewMonitor.Columns[2].Width = sizeColumn2;     //
            dataGridViewMonitor.Columns[3].Name = "Potencia";
            dataGridViewMonitor.Columns[3].Width = sizeColumn2;     //
            dataGridViewMonitor.Columns[4].Name = "Q";
            dataGridViewMonitor.Columns[4].Width = sizeColumn2;     //
            dataGridViewMonitor.Columns[5].Name = "S";
            dataGridViewMonitor.Columns[5].Width = sizeColumn2;     //
            dataGridViewMonitor.Columns[6].Name = "Cosfi";
            dataGridViewMonitor.Columns[6].Width = sizeColumn2;     //
            dataGridViewMonitor.Columns[7].Name = "Energy";
            dataGridViewMonitor.Columns[7].Width = sizeColumn2;     //
            dataGridViewMonitor.Columns[8].Name = "Reactive";
            dataGridViewMonitor.Columns[8].Width = sizeColumn2;     //

            // Creating the dtaGridViewMonitor Rows from monitor object
            string[] row = new string[] { "Linea A", Monitor.vrmsA.ToString(), Monitor.irmsA.ToString(), Monitor.pActiveA.ToString(), Monitor.qA.ToString(), Monitor.sA.ToString(), Monitor.cosfiA.ToString(), Monitor.energyA.ToString(), Monitor.reactEnergyA.ToString() };
            dataGridViewMonitor.Rows.Add(row);
            row = new string[] { "Linea B", Monitor.vrmsB.ToString(), Monitor.irmsB.ToString(), Monitor.pActiveB.ToString(), Monitor.qB.ToString(), Monitor.sB.ToString(), Monitor.cosfiB.ToString(), Monitor.energyB.ToString(), Monitor.reactEnergyB.ToString() };
            dataGridViewMonitor.Rows.Add(row);
            row = new string[] { "Linea C", Monitor.vrmsC.ToString(), Monitor.irmsC.ToString(), Monitor.pActiveC.ToString(), Monitor.qC.ToString(), Monitor.sC.ToString(), Monitor.cosfiC.ToString(), Monitor.energyC.ToString(), Monitor.reactEnergyC.ToString() };
            dataGridViewMonitor.Rows.Add(row);
            row = new string[] { "ABC", Monitor.vrmsABC.ToString(), Monitor.irmsABC.ToString(), Monitor.pActiveABC.ToString(), Monitor.qABC.ToString(), Monitor.sABC.ToString(), Monitor.cosfiABC.ToString(), Monitor.energyABC.ToString(), Monitor.reactEnergyABC.ToString() };
            dataGridViewMonitor.Rows.Add(row); */
            #endregion
            Timer showParameters = new Timer();
            showParameters.Interval = 1000;
            showParameters.Enabled = true;
            showParameters.Tick += ShowingParameters;

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
        #region DataGridColors
        /*
        public void AlternarColorenDataGridView(DataGridView dgv)
        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.LightCyan;
        }*/
        #endregion
    }
}
