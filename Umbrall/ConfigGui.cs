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
                Monitor.ipAddress = txtAddress.Text;
                Monitor.port = int.Parse(txtPort.Text);
                ModbusClient modbusClient;
                modbusClient = new ModbusClient(Monitor.ipAddress, Monitor.port);                 //Ip-Address and Port of Modbus-TCP-Server
                try
                {

                    modbusClient.Connect();

                    MessageBox.Show("Conexión exitosa.");

                }
                catch
                {
                    MessageBox.Show("Conexión no lograda.");
                }
                finally
                {
                    modbusClient.Disconnect();
                }

                this.Close();
            }
            
        }
    }
}
