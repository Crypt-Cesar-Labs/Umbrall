using EasyModbus;
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
    public partial class mbTcpTest : Form
    {
        public mbTcpTest()
        {
            InitializeComponent();
        }

        private void btnMbTcpTestConnect_Click(object sender, EventArgs e)
        {
            ModbusClient mbClient = new ModbusClient("10.10.100.254", 8899); //Ip-address and Port
            mbClient.Connect();

            int[] readHoldingRegisters = mbClient.ReadHoldingRegisters(0, 10); //Read 10 holding registers from server, starting with address 1

            for (int i = 0; i < readHoldingRegisters.Length; i++)
                Console.WriteLine("Value of HoldingRegister " + (i + 1) + " " + readHoldingRegisters[1].ToString());
            mbClient.Disconnect();
            Console.Write("Press any key to continue ...");
            Console.ReadKey(true);
        }
    }
}
