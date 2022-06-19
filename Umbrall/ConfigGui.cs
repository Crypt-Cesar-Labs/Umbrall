using EasyModbus;
using MySql.Data.MySqlClient;
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
                // Passing the data from the form to GobalParameters class for Modbus Connection
                GlobalParameters.ipAddressGlobal = txtAddress.Text;
                GlobalParameters.portGlobal = int.Parse(txtPort.Text);
                ModbusClient modbusClientConfig;
                modbusClientConfig = new ModbusClient(GlobalParameters.ipAddressGlobal, GlobalParameters.portGlobal);                 //Ip-Address and Port of Modbus-TCP-Server

                // Passing the data from the form to DataBaseHeader class
                DataBaseHeader.host = txtHost.Text;
                DataBaseHeader.user = txtUser.Text;
                DataBaseHeader.password = txtPassword.Text;
                DataBaseHeader.port = int.Parse(txtPortDB.Text);
                DataBaseHeader.dataBase = txtDataBase.Text;

                MessageBox.Show("Configuración guardada");
               
                this.Close();
            }
            
        }

        private void btnDBTest_Click(object sender, EventArgs e)
        {
            // Query Test's construct
            var builder = new MySqlConnectionStringBuilder
            {
                Server = txtHost.Text,
                UserID = txtUser.Text,
                Password = txtPassword.Text,
                Database = txtDataBase.Text,
                Port = uint.Parse(txtPortDB.Text)

            };

            var connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                
                connection.Open();

                MessageBox.Show("Conexión exitosa con la base de datos");
            }
            catch
            {
                MessageBox.Show("Error: Conexión no lograda\ncon la base de datos");
            }
            finally
            {
                connection.Close();
            }

        }

        private void btnModbusTest_Click(object sender, EventArgs e)
        {
            ModbusClient modbusClientConfig;
            modbusClientConfig = new ModbusClient(txtAddress.Text, int.Parse(txtPort.Text));    //Ip-Address and Port of Modbus-TCP-Server

            try
            {
                modbusClientConfig.Connect();
                MessageBox.Show("Conexión exitosa con\nel dispositivo Modbus");
            }
            catch
            {
                MessageBox.Show("Error: Conexión modbus\nno lograda");
            }
            finally
            {
                modbusClientConfig.Disconnect();
            }
        }
    }
}
