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
        public string ipAddressParam;
        public int portParam;
        
        public ConfigDevice()
        {
            InitializeComponent();
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {

            // Get the value parameters from the interface
            ipAddressParam = txtIpAddress.Text;
            portParam = int.Parse(txtPort.Text);

            // Passing the parameters to Global class (GlobalParameters)
            GlobalParameters.ipAddressGlobal = ipAddressParam;
            GlobalParameters.portGlobal = portParam;

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
