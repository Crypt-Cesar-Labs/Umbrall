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
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelSubMenu.Visible = false;
            panelSubReports.Visible = false;
            panelSubCalculator.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
            if (panelSubReports.Visible == true)
                panelSubReports.Visible = false;
            if (panelSubCalculator.Visible == true)
                panelSubCalculator.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubReports);
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubCalculator);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCalcH_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCalcO_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}
