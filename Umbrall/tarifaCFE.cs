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
    public partial class tarifaCFE : Form
    {
        public tarifaCFE()
        {
            InitializeComponent();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceYear = cmbYear.SelectedIndex;

            string dbSearchYear = cmbYear.Items[indiceYear].ToString();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceMonth = cmbMonth.SelectedIndex;

            string dbSearchMonth = cmbMonth.Items[indiceMonth].ToString();
        }


        private void cmbDiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceDiv = cmbDiv.SelectedIndex;

            string dbSearchDiv = cmbDiv.Items[indiceDiv].ToString();
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceCat = cmbCat.SelectedIndex;

            string dbSearchCat = cmbCat.Items[indiceCat].ToString();
        }
    }
}
