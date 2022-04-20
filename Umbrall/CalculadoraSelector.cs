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
    public partial class CalculadoraSelector : Form
    {
        public CalculadoraSelector()
        {
            InitializeComponent();
        }

        private void btnHoraria_Click(object sender, EventArgs e)
        {
            CalculadoraManualHoraria calculadoraHoraria = new CalculadoraManualHoraria();

            calculadoraHoraria.Show();

            this.Close();
        }

        private void btnOrdinara_Click(object sender, EventArgs e)
        {
            CalculadoraManualOrdinara calculadoraOrdinaria = new CalculadoraManualOrdinara();

            calculadoraOrdinaria.Show();

            this.Close();
        }
    }
}
