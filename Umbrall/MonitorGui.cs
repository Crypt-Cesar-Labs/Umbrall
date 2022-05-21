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

        public void AlternarColorenDataGridView(DataGridView dgv)
        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.LightCyan;
        }
        private void MonitorGui_Load(object sender, EventArgs e)
        {
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
            dataGridViewMonitor.Rows.Add(row);
        }

        
    }
}
