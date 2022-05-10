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
        public static bool statusCom = false; 

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

                statusCom = true; 

                Timer readModbusTimer = new Timer();

                readModbusTimer.Interval = 5000;
                readModbusTimer.Enabled = true;
                readModbusTimer.Tick += ReadModbusTimer_Tick;

            }
            catch
            {
                MessageBox.Show("Advertencia conexión no lograda desde la clase global.");
            }
            
        }

        public static void ReadRegister()
        {
            try
            {
                //------------------------ VARIABLES FOR READING -------------------------------//
                int[] readVrmsA = modbusClient.ReadHoldingRegisters(134, 2);
                int[] readVrmsB = modbusClient.ReadHoldingRegisters(136, 2);
                int[] readVrmsC = modbusClient.ReadHoldingRegisters(138, 2);
                int[] readVrmsABC = modbusClient.ReadHoldingRegisters(140, 2);
                int[] readPActiveA = modbusClient.ReadHoldingRegisters(150, 2);
                int[] readPActiveB = modbusClient.ReadHoldingRegisters(152, 2);
                int[] readPActiveC = modbusClient.ReadHoldingRegisters(154, 2);
                int[] readPActiveABC = modbusClient.ReadHoldingRegisters(156, 2);
                int[] readQA = modbusClient.ReadHoldingRegisters(158, 2);
                int[] readQB = modbusClient.ReadHoldingRegisters(160, 2);
                int[] readQC = modbusClient.ReadHoldingRegisters(162, 2);
                int[] readQABC = modbusClient.ReadHoldingRegisters(164, 2);
                int[] readSA = modbusClient.ReadHoldingRegisters(166, 2);
                int[] readSB = modbusClient.ReadHoldingRegisters(168, 2);
                int[] readSC = modbusClient.ReadHoldingRegisters(170, 2);
                int[] readSABC = modbusClient.ReadHoldingRegisters(172, 2);
                int[] readCosfiA = modbusClient.ReadHoldingRegisters(174, 2);
                int[] readCosfiB = modbusClient.ReadHoldingRegisters(176, 2);
                int[] readCosfiC = modbusClient.ReadHoldingRegisters(178, 2);
                int[] readCosfiABC = modbusClient.ReadHoldingRegisters(180, 2);
                int[] readFrequency = modbusClient.ReadHoldingRegisters(182, 2);
                int[] readEnergyA = modbusClient.ReadHoldingRegisters(184, 2);
                int[] readEnergyB = modbusClient.ReadHoldingRegisters(186, 2);
                int[] readEnergyC = modbusClient.ReadHoldingRegisters(188, 2);
                int[] readEnergyABC = modbusClient.ReadHoldingRegisters(190, 2);
                int[] readREnergyA = modbusClient.ReadHoldingRegisters(224, 2);
                int[] readREnergyB = modbusClient.ReadHoldingRegisters(226, 2);
                int[] readREnergyC = modbusClient.ReadHoldingRegisters(228, 2);
                int[] readREnergyABC = modbusClient.ReadHoldingRegisters(230, 2);
                int[] readIrmsA = modbusClient.ReadHoldingRegisters(142, 2);
                int[] readIrmsB = modbusClient.ReadHoldingRegisters(144, 2);
                int[] readIrmsC = modbusClient.ReadHoldingRegisters(146, 2);
                int[] readIrmsABC = modbusClient.ReadHoldingRegisters(148, 2);


                //------------------------ SHOWING PARAMETERS ----------------------------------//
                string vrmsAString = (readVrmsA[1] + (readVrmsA[0] * 65536)).ToString("X");
                //txtVrmsA.Text = ConvertToFloat(vrmsAString).ToString();
                vrmsA = ConvertToFloat(vrmsAString);

                string vrmsBString = (readVrmsB[1] + (readVrmsB[0] * 65536)).ToString("X");
                //txtVrmsB.Text = ConvertToFloat(vrmsBString).ToString();
                vrmsB = ConvertToFloat(vrmsBString);

                string vrmsCString = (readVrmsC[1] + (readVrmsC[0] * 65536)).ToString("X");
                //txtVrmsC.Text = ConvertToFloat(vrmsCString).ToString();
                vrmsC = ConvertToFloat(vrmsCString);

                string vrmsABCString = (readVrmsABC[1] + (readVrmsABC[0] * 65536)).ToString("X");
                //txtVrmsABC.Text = ConvertToFloat(vrmsABCString).ToString();
                vrmsABC = ConvertToFloat(vrmsABCString);

                string pActiveAString = (readPActiveA[1] + (readPActiveA[0] * 65536)).ToString("X");
                //txtPActiveA.Text = ConvertToFloat(pActiveAString).ToString();
                pActiveA = ConvertToFloat(pActiveAString);

                string pActiveBString = (readPActiveB[1] + (readPActiveB[0] * 65536)).ToString("X");
                //txtPActiveB.Text = ConvertToFloat(pActiveBString).ToString();
                pActiveB = ConvertToFloat(pActiveBString);

                string pActiveCString = (readPActiveC[1] + (readPActiveC[0] * 65536)).ToString("X");
                //txtPActiveC.Text = ConvertToFloat(pActiveCString).ToString();
                pActiveC = ConvertToFloat(pActiveCString);

                string pActiveABCString = (readPActiveABC[1] + (readPActiveABC[0] * 65536)).ToString("X");
                //txtPActiveAbc.Text = ConvertToFloat(pActiveABCString).ToString();
                pActiveABC = ConvertToFloat(pActiveABCString);

                string qAString = (readQA[1] + (readQA[0] * 65536)).ToString("X");
                //txtQA.Text = ConvertToFloat(qAString).ToString();
                qA = ConvertToFloat(qAString);

                string qBString = (readQB[1] + (readQB[0] * 65536)).ToString("X");
                //txtQB.Text = ConvertToFloat(qBString).ToString();
                qB = ConvertToFloat(qBString);

                string qCString = (readQC[1] + (readQC[0] * 65536)).ToString("X");
                //txtQC.Text = ConvertToFloat(qCString).ToString();
                qC = ConvertToFloat(qCString);

                string qABCString = (readQABC[1] + (readQABC[0] * 65536)).ToString("X");
                //txtQAbc.Text = ConvertToFloat(qABCString).ToString();
                qABC = ConvertToFloat(qABCString);

                string sAString = (readSA[1] + (readSA[0] * 65536)).ToString("X");
                //txtSA.Text = ConvertToFloat(sAString).ToString();
                sA = ConvertToFloat(sAString);

                string sBString = (readSB[1] + (readSB[0] * 65536)).ToString("X");
                //txtSB.Text = ConvertToFloat(sBString).ToString();
                sB = ConvertToFloat(sBString);

                string sCString = (readSC[1] + (readSC[0] * 65536)).ToString("X");
                //txtSC.Text = ConvertToFloat(sCString).ToString();
                sC = ConvertToFloat(sCString);

                string sABCString = (readSABC[1] + (readSABC[0] * 65536)).ToString("X");
                //txtSAbc.Text = ConvertToFloat(sABCString).ToString();
                sABC = ConvertToFloat(sABCString);

                string cosfiAString = (readCosfiA[1] + (readCosfiA[0] * 65536)).ToString("X");
                //txtCosFiA.Text = ConvertToFloat(cosfiA).ToString();
                cosfiA = ConvertToFloat(cosfiAString);

                string cosfiBString = (readCosfiB[1] + (readCosfiB[0] * 65536)).ToString("X");
                //txtCosFiB.Text = ConvertToFloat(cosfiB).ToString();
                cosfiB = ConvertToFloat(cosfiBString);

                string cosfiCString = (readCosfiC[1] + (readCosfiC[0] * 65536)).ToString("X");
                //txtCosFiC.Text = ConvertToFloat(cosfiC).ToString();
                cosfiC = ConvertToFloat(cosfiCString);

                string cosfiABCString = (readCosfiABC[1] + (readCosfiABC[0] * 65536)).ToString("X");
                //txtCosFiABC.Text = ConvertToFloat(cosfiABC).ToString();
                cosfiABC = ConvertToFloat(cosfiABCString);

                string frequencyString = (readFrequency[1] + (readFrequency[0] * 65536)).ToString("X");
                //txtFreq.Text = ConvertToFloat(frequency).ToString();
                frequency = ConvertToFloat(frequencyString);

                string energyAString = (readEnergyA[1] + (readEnergyA[0] * 65536)).ToString("X");
                //txtEnergyA.Text = ConvertToFloat(energyA).ToString();
                energyA = ConvertToFloat(energyAString);

                string energyBString = (readEnergyB[1] + (readEnergyB[0] * 65536)).ToString("X");
                //txtEnergyB.Text = ConvertToFloat(energyB).ToString();
                energyB = ConvertToFloat(energyBString);

                string energyCString = (readEnergyC[1] + (readEnergyC[0] * 65536)).ToString("X");
                //txtEnergyC.Text = ConvertToFloat(energyC).ToString();
                energyC = ConvertToFloat(energyCString);

                string energyABCString = (readEnergyABC[1] + (readEnergyABC[0] * 65536)).ToString("X");
                //txtEnergyABC.Text = ConvertToFloat(energyABC).ToString();
                energyABC = ConvertToFloat(energyABCString);

                string energyRAString = (readREnergyA[1] + (readREnergyA[0] * 65536)).ToString("X");
                //txtReactEnergyA.Text = ConvertToFloat(energyRA).ToString();
                reactEnergyA = ConvertToFloat(energyRAString);

                string energyRBString = (readREnergyB[1] + (readREnergyB[0] * 65536)).ToString("X");
                //txtReactEnergyB.Text = ConvertToFloat(energyRB).ToString();
                reactEnergyB = ConvertToFloat(energyRBString);

                string energyRCString = (readREnergyC[1] + (readREnergyC[0] * 655536)).ToString("X");
                //txtReactEnergyC.Text = ConvertToFloat(energyRC).ToString();
                reactEnergyC = ConvertToFloat(energyRCString);

                string energyRABCString = (readREnergyABC[1] + (readREnergyABC[0] * 65536)).ToString("X");
                //txtReactEnergyABC.Text = ConvertToFloat(energyRABC).ToString();
                reactEnergyABC = ConvertToFloat(energyRABCString);

                string irmsAString = (readIrmsA[1] + (readIrmsA[0] * 65536)).ToString("X");
                //txtIrmsA.Text = ConvertToFloat(irmsA).ToString();
                irmsA = (ConvertToFloat(irmsAString)/1000);

                string irmsBString = (readIrmsB[1] + (readIrmsB[0] * 65536)).ToString("X");
                //txtIrmsB.Text = ConvertToFloat(irmsB).ToString();
                irmsB = (ConvertToFloat(irmsBString)/1000);

                string irmsCString = (readIrmsC[1] + (readIrmsC[0] * 65536)).ToString("X");
                //txtIrmsC.Text = ConvertToFloat(irmsC).ToString();
                irmsC = (ConvertToFloat(irmsCString)/1000);

                string irmsABCString = (readIrmsABC[1] + (readIrmsABC[0] * 65536)).ToString("X");
                //txtIrmsABC.Text = ConvertToFloat(irmsABC).ToString();
                irmsABC = (ConvertToFloat(irmsABCString)/1000);
            }
            catch
            {
                //MessageBox.Show("Error en la conexión.");
                Console.WriteLine("Error:");
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
                statusCom = false; 
                MessageBox.Show("Comunicación finalizada");
            }
            catch
            {
                MessageBox.Show("Error al desconectar");
            }
            
        }

        public static void ModbusScreenshot()
        {

        }

    }
}
