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
            tarifaCFE tarifasWindow = new tarifaCFE();

            //Se establece la instancia padre
            tarifasWindow.MdiParent = this;

            //Se manda a llamar
            tarifasWindow.Show();
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
    }
}
