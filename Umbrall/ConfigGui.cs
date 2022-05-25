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
    public partial class ConfigGui : Form
    {
        public ConfigGui()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ( String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtPort.Text))
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                GlobalParameters.ipAddressGlobal = txtAddress.Text;
                GlobalParameters.portGlobal = int.Parse(txtPort.Text);
                ModbusClient modbusClientConfig;
                modbusClientConfig = new ModbusClient(GlobalParameters.ipAddressGlobal, GlobalParameters.portGlobal);                 //Ip-Address and Port of Modbus-TCP-Server
                try
                {

                    modbusClientConfig.Connect();

                    MessageBox.Show("Conexión exitosa.");

                }
                catch
                {
                    MessageBox.Show("Conexión no lograda.");
                }
                finally
                {
                    modbusClientConfig.Disconnect();
                }

                this.Close();
            }
            
        }
    }
}
