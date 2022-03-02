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
    public partial class StartMonitor : Form
    {
        ModbusClient modbusClient;
        public StartMonitor()
        {
            InitializeComponent();
        }

        private void StartMonitor_Load(object sender, EventArgs e)
        {
            modbusClient = new ModbusClient("127.0.0.1", 502);                 //Ip-Address and Port of Modbus-TCP-Server
            
            try
            {
                modbusClient.Connect();                                                     //Connect to Server

                int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 50);      //Read 10 Holding Registers from Server, starting with Address 1

                //Console Output
                for (int i = 0; i < readHoldingRegisters.Length; i++)
                    Console.WriteLine("Value of HoldingRegister " + (i + 1) + " " + readHoldingRegisters[i].ToString());

                



            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void ReadRegisters()
        {
            int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 50);      //Read 10 Holding Registers from Server, starting with Address 1
        }

        /*
                txtReg1.Text = readHoldingRegisters[0].ToString();
                txtReg2.Text = readHoldingRegisters[1].ToString();
                txtReg3.Text = readHoldingRegisters[2].ToString();
                txtReg4.Text = readHoldingRegisters[3].ToString();
                txtReg5.Text = readHoldingRegisters[4].ToString();
                txtReg6.Text = readHoldingRegisters[5].ToString();
                txtReg7.Text = readHoldingRegisters[6].ToString();
                txtReg8.Text = readHoldingRegisters[7].ToString();
                txtReg9.Text = readHoldingRegisters[8].ToString();
                txtReg10.Text = readHoldingRegisters[9].ToString();
                txtReg11.Text = readHoldingRegisters[10].ToString();
                txtReg12.Text = readHoldingRegisters[11].ToString();
                txtReg13.Text = readHoldingRegisters[0].ToString();
                txtReg14.Text = readHoldingRegisters[1].ToString();
                txtReg15.Text = readHoldingRegisters[2].ToString();
                txtReg16.Text = readHoldingRegisters[3].ToString();
                txtReg17.Text = readHoldingRegisters[4].ToString();
                txtReg18.Text = readHoldingRegisters[5].ToString();
                txtReg19.Text = readHoldingRegisters[6].ToString();
                txtReg20.Text = readHoldingRegisters[7].ToString();
                txtReg21.Text = readHoldingRegisters[8].ToString();
                txtReg22.Text = readHoldingRegisters[9].ToString();
                txtReg23.Text = readHoldingRegisters[10].ToString();
                txtReg24.Text = readHoldingRegisters[11].ToString();
                txtReg25.Text = readHoldingRegisters[0].ToString();
                txtReg26.Text = readHoldingRegisters[1].ToString();
                txtReg27.Text = readHoldingRegisters[2].ToString();
                txtReg28.Text = readHoldingRegisters[3].ToString();
                txtReg29.Text = readHoldingRegisters[4].ToString();
                txtReg30.Text = readHoldingRegisters[5].ToString();
                txtReg31.Text = readHoldingRegisters[6].ToString();
                txtReg32.Text = readHoldingRegisters[7].ToString();
                txtReg33.Text = readHoldingRegisters[8].ToString();
                txtReg34.Text = readHoldingRegisters[9].ToString();
                txtReg35.Text = readHoldingRegisters[10].ToString();
                txtReg36.Text = readHoldingRegisters[11].ToString();
                txtReg37.Text = readHoldingRegisters[0].ToString();
                txtReg38.Text = readHoldingRegisters[1].ToString();
                txtReg39.Text = readHoldingRegisters[2].ToString();
                txtReg40.Text = readHoldingRegisters[3].ToString();
                txtReg41.Text = readHoldingRegisters[4].ToString();
                txtReg42.Text = readHoldingRegisters[5].ToString();
                txtReg43.Text = readHoldingRegisters[6].ToString();
                txtReg44.Text = readHoldingRegisters[7].ToString();
                txtReg45.Text = readHoldingRegisters[8].ToString();
                txtReg46.Text = readHoldingRegisters[9].ToString();
                txtReg47.Text = readHoldingRegisters[10].ToString();*/
    }
}
