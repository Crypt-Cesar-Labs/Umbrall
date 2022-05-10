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
    public partial class Form1 : Form
    {   
        
        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SCALINI\nwww.indscalini.com\nContacto:ventas@indscalini.com");
        }

        private void tarifasCFEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*tarifaCFE tarifasWindow = new tarifaCFE();

            //Se establece la instancia padre
            tarifasWindow.MdiParent = this;

            //Se manda a llamar
            tarifasWindow.Show();*/

            // Showing the window for select the type of instalation 

            ConsultaTarifaForm1 consultaTarifaForm1 = new ConsultaTarifaForm1();

            consultaTarifaForm1.MdiParent = this;

            consultaTarifaForm1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //For testing a TCP communication
        private void tCPIPTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcpTest tcpTestWindow = new tcpTest();

            //Parent object
            tcpTestWindow.MdiParent = this;

            //calling
            tcpTestWindow.Show();
        }

        //For testing a Modbus RTU comunication
        private void modbusRTUTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mbRtuTest mbRtuWindow = new mbRtuTest();

            //Parent object
            mbRtuWindow.MdiParent = this;

            //calling
            mbRtuWindow.Show();
        }

        //For testing a Modbus RTU over TCP communication
        private void modbusRTUOverTCPTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mbRtuTcpTest mbRtuTcpWindow = new mbRtuTcpTest();

            //Parent object
            mbRtuTcpWindow.MdiParent = this;

            //calling
            mbRtuTcpWindow.Show();
        }

        private void clientTCPTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientTcpTest tcpTestWindow = new clientTcpTest();

            //Parent object
            tcpTestWindow.MdiParent = this;

            //calling
            tcpTestWindow.Show();
        }

        private void modbusTCPTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mbTcpTest mbTcpTestWindow = new mbTcpTest();

            //Parent object
            mbTcpTestWindow.MdiParent = this;

            //calling
            mbTcpTestWindow.Show();
        }

        private void clientSocketTCPTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientTcpSocketTest clientSocketTcpTestWindow = new ClientTcpSocketTest();

            clientSocketTcpTestWindow.MdiParent = this;

            clientSocketTcpTestWindow.Show();
        }

        private void iniciarMonitoreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monitor.StartMonitor();

            StartMonitor startMonitorWindow = new StartMonitor();

            startMonitorWindow.MdiParent = this;

            startMonitorWindow.Show();

        }

        

        private void conectarDispositivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigDevice configDevice = new ConfigDevice();

            configDevice.MdiParent = this;

            configDevice.Show();
        }

        private void detenerMonitoreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monitor.StopMonitor();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculadoraSelector selector = new CalculadoraSelector();

            selector.MdiParent = this;

            selector.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartMonitor startMonitorWindow = new StartMonitor();

            startMonitorWindow.MdiParent = this;

            startMonitorWindow.Show();
        }
    }
}
