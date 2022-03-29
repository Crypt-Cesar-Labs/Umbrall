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
    public partial class ConsultaTarifaForm1 : Form
    {
        public ConsultaTarifaForm1()
        {
            InitializeComponent();
        }

        private void btnDomestic_Click(object sender, EventArgs e)
        {
            ConsultaTarifaDomestica consultaTarifaDomestica = new ConsultaTarifaDomestica();

            consultaTarifaDomestica.Show();

            this.Close();
        }

        private void btnEnterprise_Click(object sender, EventArgs e)
        {
            ConsultaTarifaEmpresa consultaTarifaEmpresa = new ConsultaTarifaEmpresa();

            consultaTarifaEmpresa.Show();

            this.Close();
        }
    }
}
