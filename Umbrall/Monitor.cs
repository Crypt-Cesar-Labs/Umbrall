using EasyModbus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//using System.Threading;

namespace Umbrall
{
    internal class Monitor
    {
        // Variables for ModbusClient
        static ModbusClient modbusClient;
        public static string ipAddress;
        public static int port;
        public static bool statusMonitor = false;
        public static Thread monitorThread;
        
        #region ModbusVarSeneca
        //Modbus variables for SENECA
        public static float vrmsA;
        public static float vrmsB;
        public static float vrmsC;
        public static float vrmsABC;
        public static float pActiveA;
        public static float pActiveB;
        public static float pActiveC;
        public static float pActiveABC;
        public static float qA;
        public static float qB;
        public static float qC;
        public static float qABC;
        public static float sA;
        public static float sB;
        public static float sC;
        public static float sABC;
        public static float cosfiA;
        public static float cosfiB;
        public static float cosfiC;
        public static float cosfiABC;
        public static float frequency;
        public static float energyA;
        public static float energyB;
        public static float energyC;
        public static float energyABC;
        public static float reactEnergyA;
        public static float reactEnergyB;
        public static float reactEnergyC;
        public static float reactEnergyABC;
        public static float irmsA;
        public static float irmsB;
        public static float irmsC;
        public static float irmsABC;
        public static float demandaMax;
        #endregion

        public static void StartMonitor()
        {
            ipAddress = GlobalParameters.ipAddressGlobal;
            port = GlobalParameters.portGlobal;
            modbusClient = new ModbusClient(ipAddress, port);                 //Ip-Address and Port of Modbus-TCP-Server

            try
            {
                modbusClient.Connect();
                Console.WriteLine("Concexion con ip: " + ipAddress.ToString() + " y puerto: " + port.ToString() + " exitosa.");
                //int[] readVrmsA = modbusClient.ReadHoldingRegisters(134, 2);

                statusMonitor = true;
                monitorThread = new Thread(new ThreadStart(MonitorProc));
                monitorThread.Start();
                Thread.Sleep(1000);


                /*
                Timer readModbusTimer = new Timer();

                readModbusTimer.Interval = 5000;
                readModbusTimer.Enabled = true;
                readModbusTimer.Tick += ReadModbusTimer_Tick;*/

                MessageBox.Show("Monitoreo Iniciado");
            }
            catch
            {
                MessageBox.Show("Advertencia conexión no lograda desde la clase global.");
                statusMonitor = false;
            }
            
        }

        private static void MonitorProc()
        {
            while (true)
            {
                ReadRegister();
                Console.WriteLine("Reading registers from Thread {0}", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(500);
            }
            

        }

        private static void ReadRegister()
        {
            try
            {
                int sleepRead = 200;
                //------------------------ VARIABLES FOR READING -------------------------------//                
                int[] readVrmsA = modbusClient.ReadHoldingRegisters(134, 2);
                Thread.Sleep(sleepRead);
                int[] readVrmsB = modbusClient.ReadHoldingRegisters(136, 2);
                Thread.Sleep(sleepRead);
                int[] readVrmsC = modbusClient.ReadHoldingRegisters(138, 2);
                Thread.Sleep(sleepRead);
                int[] readVrmsABC = modbusClient.ReadHoldingRegisters(140, 2);
                Thread.Sleep(sleepRead);
                int[] readIrmsA = modbusClient.ReadHoldingRegisters(142, 2);
                Thread.Sleep(sleepRead);
                int[] readIrmsB = modbusClient.ReadHoldingRegisters(144, 2);
                Thread.Sleep(sleepRead);
                int[] readIrmsC = modbusClient.ReadHoldingRegisters(146, 2);
                Thread.Sleep(sleepRead);
                int[] readIrmsABC = modbusClient.ReadHoldingRegisters(148, 2);
                Thread.Sleep(sleepRead);
                int[] readPActiveA = modbusClient.ReadHoldingRegisters(150, 2);
                Thread.Sleep(sleepRead);
                int[] readPActiveB = modbusClient.ReadHoldingRegisters(152, 2);
                Thread.Sleep(sleepRead);
                int[] readPActiveC = modbusClient.ReadHoldingRegisters(154, 2);
                Thread.Sleep(sleepRead);
                int[] readPActiveABC = modbusClient.ReadHoldingRegisters(156, 2);
                Thread.Sleep(sleepRead);
                int[] readQA = modbusClient.ReadHoldingRegisters(158, 2);
                Thread.Sleep(sleepRead);
                int[] readQB = modbusClient.ReadHoldingRegisters(160, 2);
                Thread.Sleep(sleepRead);
                int[] readQC = modbusClient.ReadHoldingRegisters(162, 2);
                Thread.Sleep(sleepRead);
                int[] readQABC = modbusClient.ReadHoldingRegisters(164, 2);
                Thread.Sleep(sleepRead);
                int[] readSA = modbusClient.ReadHoldingRegisters(166, 2);
                Thread.Sleep(sleepRead);
                int[] readSB = modbusClient.ReadHoldingRegisters(168, 2);
                Thread.Sleep(sleepRead);
                int[] readSC = modbusClient.ReadHoldingRegisters(170, 2);
                Thread.Sleep(sleepRead);
                int[] readSABC = modbusClient.ReadHoldingRegisters(172, 2);
                Thread.Sleep(sleepRead);
                int[] readCosfiA = modbusClient.ReadHoldingRegisters(174, 2);
                Thread.Sleep(sleepRead);
                int[] readCosfiB = modbusClient.ReadHoldingRegisters(176, 2);
                Thread.Sleep(sleepRead);
                int[] readCosfiC = modbusClient.ReadHoldingRegisters(178, 2);
                Thread.Sleep(sleepRead);
                int[] readCosfiABC = modbusClient.ReadHoldingRegisters(180, 2);
                Thread.Sleep(sleepRead);
                int[] readFrequency = modbusClient.ReadHoldingRegisters(182, 2);
                Thread.Sleep(sleepRead);
                int[] readEnergyA = modbusClient.ReadHoldingRegisters(184, 2);
                Thread.Sleep(sleepRead);
                int[] readEnergyB = modbusClient.ReadHoldingRegisters(186, 2);
                Thread.Sleep(sleepRead);
                int[] readEnergyC = modbusClient.ReadHoldingRegisters(188, 2);
                Thread.Sleep(sleepRead);
                int[] readEnergyABC = modbusClient.ReadHoldingRegisters(190, 2);
                Thread.Sleep(sleepRead);
                int[] readREnergyA = modbusClient.ReadHoldingRegisters(224, 2);
                Thread.Sleep(sleepRead);
                int[] readREnergyB = modbusClient.ReadHoldingRegisters(226, 2);
                Thread.Sleep(sleepRead);
                int[] readREnergyC = modbusClient.ReadHoldingRegisters(228, 2);
                Thread.Sleep(sleepRead);
                int[] readREnergyABC = modbusClient.ReadHoldingRegisters(230, 2);
                Thread.Sleep(sleepRead);
                int[] readDemandaMax = modbusClient.ReadHoldingRegisters(1021, 2);
                Thread.Sleep(sleepRead);

                int sleepConvert = 100;

                //------------------------ SHOWING PARAMETERS ----------------------------------//
                string vrmsAString = (readVrmsA[1] + (readVrmsA[0] * 65536)).ToString("X");
                vrmsA = ConvertToFloat(vrmsAString);
                Thread.Sleep(sleepConvert);

                string vrmsBString = (readVrmsB[1] + (readVrmsB[0] * 65536)).ToString("X");
                vrmsB = ConvertToFloat(vrmsBString);
                Thread.Sleep(sleepConvert);

                string vrmsCString = (readVrmsC[1] + (readVrmsC[0] * 65536)).ToString("X");
                vrmsC = ConvertToFloat(vrmsCString);
                Thread.Sleep(sleepConvert);

                string vrmsABCString = (readVrmsABC[1] + (readVrmsABC[0] * 65536)).ToString("X");
                vrmsABC = ConvertToFloat(vrmsABCString);
                Thread.Sleep(sleepConvert);

                string pActiveAString = (readPActiveA[1] + (readPActiveA[0] * 65536)).ToString("X");
                pActiveA = ConvertToFloat(pActiveAString);
                Thread.Sleep(sleepConvert);

                string pActiveBString = (readPActiveB[1] + (readPActiveB[0] * 65536)).ToString("X");
                pActiveB = ConvertToFloat(pActiveBString);
                Thread.Sleep(sleepConvert);

                string pActiveCString = (readPActiveC[1] + (readPActiveC[0] * 65536)).ToString("X");
                pActiveC = ConvertToFloat(pActiveCString);
                Thread.Sleep(sleepConvert);

                string pActiveABCString = (readPActiveABC[1] + (readPActiveABC[0] * 65536)).ToString("X");
                pActiveABC = ConvertToFloat(pActiveABCString);
                Thread.Sleep(sleepConvert);

                string qAString = (readQA[1] + (readQA[0] * 65536)).ToString("X");
                qA = ConvertToFloat(qAString);
                Thread.Sleep(sleepConvert);

                string qBString = (readQB[1] + (readQB[0] * 65536)).ToString("X");
                qB = ConvertToFloat(qBString);
                Thread.Sleep(sleepConvert);

                string qCString = (readQC[1] + (readQC[0] * 65536)).ToString("X");
                qC = ConvertToFloat(qCString);
                Thread.Sleep(sleepConvert);

                string qABCString = (readQABC[1] + (readQABC[0] * 65536)).ToString("X");
                qABC = ConvertToFloat(qABCString);
                Thread.Sleep(sleepConvert);

                string sAString = (readSA[1] + (readSA[0] * 65536)).ToString("X");
                sA = ConvertToFloat(sAString);
                Thread.Sleep(sleepConvert);

                string sBString = (readSB[1] + (readSB[0] * 65536)).ToString("X");
                sB = ConvertToFloat(sBString);
                Thread.Sleep(sleepConvert);

                string sCString = (readSC[1] + (readSC[0] * 65536)).ToString("X");
                sC = ConvertToFloat(sCString);
                Thread.Sleep(sleepConvert);

                string sABCString = (readSABC[1] + (readSABC[0] * 65536)).ToString("X");
                sABC = ConvertToFloat(sABCString);
                Thread.Sleep(sleepConvert);

                string cosfiAString = (readCosfiA[1] + (readCosfiA[0] * 65536)).ToString("X");
                cosfiA = ConvertToFloat(cosfiAString);
                Thread.Sleep(sleepConvert);

                string cosfiBString = (readCosfiB[1] + (readCosfiB[0] * 65536)).ToString("X");
                cosfiB = ConvertToFloat(cosfiBString);
                Thread.Sleep(sleepConvert);

                string cosfiCString = (readCosfiC[1] + (readCosfiC[0] * 65536)).ToString("X");
                cosfiC = ConvertToFloat(cosfiCString);
                Thread.Sleep(sleepConvert);

                string cosfiABCString = (readCosfiABC[1] + (readCosfiABC[0] * 65536)).ToString("X");
                cosfiABC = ConvertToFloat(cosfiABCString);
                Thread.Sleep(sleepConvert);

                string frequencyString = (readFrequency[1] + (readFrequency[0] * 65536)).ToString("X");
                frequency = ConvertToFloat(frequencyString);
                Thread.Sleep(sleepConvert);

                string energyAString = (readEnergyA[1] + (readEnergyA[0] * 65536)).ToString("X");
                energyA = ConvertToFloat(energyAString);
                Thread.Sleep(sleepConvert);

                string energyBString = (readEnergyB[1] + (readEnergyB[0] * 65536)).ToString("X");
                energyB = ConvertToFloat(energyBString);
                Thread.Sleep(sleepConvert);

                string energyCString = (readEnergyC[1] + (readEnergyC[0] * 65536)).ToString("X");
                energyC = ConvertToFloat(energyCString);
                Thread.Sleep(sleepConvert);

                string energyABCString = (readEnergyABC[1] + (readEnergyABC[0] * 65536)).ToString("X");
                energyABC = ConvertToFloat(energyABCString);
                Thread.Sleep(sleepConvert);

                string energyRAString = (readREnergyA[1] + (readREnergyA[0] * 65536)).ToString("X");
                reactEnergyA = ConvertToFloat(energyRAString);
                Thread.Sleep(sleepConvert);

                string energyRBString = (readREnergyB[1] + (readREnergyB[0] * 65536)).ToString("X");
                reactEnergyB = ConvertToFloat(energyRBString);
                Thread.Sleep(sleepConvert);

                string energyRCString = (readREnergyC[1] + (readREnergyC[0] * 655536)).ToString("X");
                reactEnergyC = ConvertToFloat(energyRCString);
                Thread.Sleep(sleepConvert);

                string energyRABCString = (readREnergyABC[1] + (readREnergyABC[0] * 65536)).ToString("X");
                reactEnergyABC = ConvertToFloat(energyRABCString);
                Thread.Sleep(sleepConvert);

                string irmsAString = (readIrmsA[1] + (readIrmsA[0] * 65536)).ToString("X");
                irmsA = (ConvertToFloat(irmsAString)/1000);
                Thread.Sleep(sleepConvert);

                string irmsBString = (readIrmsB[1] + (readIrmsB[0] * 65536)).ToString("X");
                irmsB = (ConvertToFloat(irmsBString)/1000);
                Thread.Sleep(sleepConvert);

                string irmsCString = (readIrmsC[1] + (readIrmsC[0] * 65536)).ToString("X");
                irmsC = (ConvertToFloat(irmsCString)/1000);
                Thread.Sleep(sleepConvert);

                string irmsABCString = (readIrmsABC[1] + (readIrmsABC[0] * 65536)).ToString("X");
                irmsABC = (ConvertToFloat(irmsABCString)/1000);
                Thread.Sleep(sleepConvert);

                string demandaMaxString = (readDemandaMax[1] + (readDemandaMax[0] * 65536)).ToString("X");
                demandaMax = (ConvertToFloat(demandaMaxString) / 1000);
                Thread.Sleep(sleepConvert);
            }
            catch (Exception ex)
            {
                // what
                var msg = "Error:" + ex.Message;
                
                // info
                if (ex.InnerException != null)
                {
                    msg = msg + "Inner exception: " + ex.InnerException.Message;
                }

                // where
                msg = msg + " Stack trace " + ex.StackTrace;
                Console.WriteLine(msg);
                
                statusMonitor = false;
            }
            
        }

        public static void ReadModbusTimer_Tick(object sender, EventArgs e)
        {
            ReadRegister();
        }

        //Function to convert the Hex value trough Float32
        public static float ConvertToFloat(string value)
        {
            uint num = uint.Parse(value, System.Globalization.NumberStyles.AllowHexSpecifier);      //Parse to unsigned int
            byte[] floatValues = BitConverter.GetBytes(num);                                        //Returns a byte array
            float valueFloat = BitConverter.ToSingle(floatValues, 0);                               //Return a float32 value                
            return valueFloat;
        }

        public static void StopMonitor()
        {
            try
            {
                modbusClient.Disconnect();                
                MessageBox.Show("Comunicación finalizada");
                statusMonitor = false;
                monitorThread.Abort();
                Console.WriteLine("Stop Reading registers & kill Thread {0}", monitorThread.ManagedThreadId);
            }
            catch
            {
                MessageBox.Show("Error al desconectar");
            }
            
        }

        public static void VrmsChartConfig(Chart chart)
        {
            // Make the object for Series and Areas
            SeriesCollection chartVrmsSeries = chart.Series;
            ChartAreaCollection chartVrmsAreas = chart.ChartAreas;
            chartVrmsSeries.Add("Vrms");                            // Se agrega serie de Vrms

            ChartArea chartVrmsArea = chartVrmsAreas[0];            // Se selecciona la primera Area
            Series chartVrmsSerie = chartVrmsSeries[0];             // Se selecciona la primera serie

            chartVrmsArea.BackColor = Color.Black;                  // Setting black background for the Area

            chartVrmsSerie.ChartType = SeriesChartType.FastLine;    // Setting FastLine style for the chart
            chartVrmsSerie.Color = Color.Red;                       // Red color for the serie

            // Points for the chart
            chartVrmsSerie.Points.AddXY(1, 32);
            chartVrmsSerie.Points.AddXY(2, 12);
            chartVrmsSerie.Points.AddXY(3, 56);
            chartVrmsSerie.Points.AddXY(4, 78);

        }

    }
}
