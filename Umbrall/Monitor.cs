using EasyModbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrall
{
    internal class Monitor
    {
        // Variables for ModbusClient
        static ModbusClient modbusClient;
        public static string ipAddress;
        public static int port;

        public static void StartMonitor()
        {
            ipAddress = GlobalParameters.ipAddressGlobal;
            port = GlobalParameters.portGlobal;
            modbusClient = new ModbusClient(ipAddress, port);                 //Ip-Address and Port of Modbus-TCP-Server

            try
            {
                modbusClient.Connect();

                Timer readModbusTimer = new Timer();

            }
            catch
            {
                MessageBox.Show("Advertencia conexión no lograda desde la clase global.");
            }
            
        }

        public static void StopMonitor()
        {
            try
            {
                modbusClient.Disconnect();
                MessageBox.Show("Comunicación finalizada");
            }
            catch
            {
                MessageBox.Show("Error al desconectar");
            }
            
        }


    }
}
