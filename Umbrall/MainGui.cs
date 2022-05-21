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

        #region Sub-menus
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            openChildForm(new MonitorGui());

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
            openChildForm(new CalculadoraHorariaGui());

            hideSubMenu();
        }

        private void btnCalcO_Click(object sender, EventArgs e)
        {
            openChildForm(new CalculadoraOrdinariaGui());

            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);     // Agregamos el formulario a la lista de controles del panel del contenedor
            panelChildForm.Tag = childForm;             // Asociamos el fomrulario con el panel del contenedor
            childForm.BringToFront();                   // Traemos al frente el formulario
            childForm.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Monitor.StartMonitor();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Monitor.StopMonitor();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Muestra muestraObj = new Muestra(Monitor.vrmsABC.ToString(), Monitor.irmsABC.ToString(), Monitor.pActiveABC.ToString(), Monitor.cosfiABC.ToString(), Monitor.energyABC.ToString());

            int res = muestraObj.Guardar();

            switch (res)
            {
                case 0:
                    MessageBox.Show("El archivo se guardo correctamente");
                    break;
                case 1:
                    MessageBox.Show("Se cancelo la operación");
                    break;
                case 2:
                    MessageBox.Show("Error.");
                    break;

            }
        }
    }
}
