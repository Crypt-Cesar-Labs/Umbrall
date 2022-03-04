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
    public partial class ConfigDevice : Form
    {
        //Variables para los parámetros 
        public string ipAddressGlobal;
        public class ConectionParameters
        {
            public static string ipAddress;
            public static int port;
        }
        
        public ConfigDevice()
        {
            InitializeComponent();
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            ConectionParameters.ipAddress = txtIpAddress.Text;
            ConectionParameters.port = int.Parse(txtPort.Text);

            ipAddressGlobal = txtIpAddress.Text;

            this.Close();

            MessageBox.Show(" Parametros\n Dirección Ip = " + ConectionParameters.ipAddress + "\n" +
                "Puerto = " + ConectionParameters.port.ToString() + "\n" +
                "The new ip = " + ipAddressGlobal);
        }
    }
}
