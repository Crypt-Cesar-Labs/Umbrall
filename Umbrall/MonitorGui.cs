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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonitorGui_Load(object sender, EventArgs e)
        {
            // Creating the dataGridViewMonitor Columns
            dataGridViewMonitor.ColumnCount = 9;
            dataGridViewMonitor.Columns[0].Name = "Linea";
            dataGridViewMonitor.Columns[1].Name = "Vrms";
            dataGridViewMonitor.Columns[2].Name = "Irms";
            dataGridViewMonitor.Columns[3].Name = "Potencia";
            dataGridViewMonitor.Columns[4].Name = "Q";
            dataGridViewMonitor.Columns[5].Name = "S";
            dataGridViewMonitor.Columns[6].Name = "Cosfi";
            dataGridViewMonitor.Columns[7].Name = "Energy";
            dataGridViewMonitor.Columns[8].Name = "Reactive";

            // Creating the dtaGridViewMonitor Rows from monitor object
            string[] row = new string[] { "Linea A", Monitor.vrmsA.ToString(), Monitor.irmsA.ToString(), Monitor.pActiveA.ToString(), Monitor.qA.ToString(), Monitor.sA.ToString(), Monitor.cosfiA.ToString(), Monitor.energyA.ToString(), Monitor.reactEnergyA.ToString() };
            dataGridViewMonitor.Rows.Add(row);
            row = new string[] { "Linea B", Monitor.vrmsB.ToString(), Monitor.irmsB.ToString(), Monitor.pActiveB.ToString(), Monitor.qB.ToString(), Monitor.sB.ToString(), Monitor.cosfiB.ToString(), Monitor.energyB.ToString(), Monitor.reactEnergyB.ToString() };
            dataGridViewMonitor.Rows.Add(row);
            row = new string[] { "Linea C", Monitor.vrmsC.ToString(), Monitor.irmsC.ToString(), Monitor.pActiveC.ToString(), Monitor.qC.ToString(), Monitor.sC.ToString(), Monitor.cosfiC.ToString(), Monitor.energyC.ToString(), Monitor.reactEnergyC.ToString() };
            dataGridViewMonitor.Rows.Add(row);
            row = new string[] { "ABC", Monitor.vrmsABC.ToString(), Monitor.irmsABC.ToString(), Monitor.pActiveABC.ToString(), Monitor.qABC.ToString(), Monitor.sABC.ToString(), Monitor.cosfiABC.ToString(), Monitor.energyABC.ToString(), Monitor.reactEnergyABC.ToString() };
            dataGridViewMonitor.Rows.Add(row);
        }
    }
}
