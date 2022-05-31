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

        public bool printHor = false;
        private void customizeDesing()
        {
            panelSubMenu.Visible = false;
            panelSubReports.Visible = false;
            panelSubCalculator.Visible = false;
            btnPrint.Visible = false;
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

            btnPrint.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            this.Close();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            btnPrint.Visible = false;
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCalcH_Click(object sender, EventArgs e)
        {
            openChildForm(new CalculadoraHorariaGui());

            hideSubMenu();

            btnPrint.Visible = true;

            printHor = true;

        }

        private void btnCalcO_Click(object sender, EventArgs e)
        {
            openChildForm(new CalculadoraOrdinariaGui());

            hideSubMenu();

            btnPrint.Visible = true;

            printHor = false;

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

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ConfigGui"] != null)
            {
                Application.OpenForms["ConfigGui"].Activate();
            }

            else
            {
                ConfigGui configGui = new ConfigGui();
                configGui.Show();
            }
                
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(printHor == true)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                string nameFile = DateTime.Now.ToString("ddMMyyyyHHmmss") + "H" + ".pdf";

                string facturaName = SaveFacturaFile.FacturaName(saveFileDialog, nameFile);

                string paginahtml_texto = SaveFacturaFile.HtmlTemplateH();


                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@YEAR", CalculadoraHorariaGui.year);
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@MES", CalculadoraHorariaGui.month);
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@TARIFA", CalculadoraHorariaGui.tarifa);
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@DIVISION", CalculadoraHorariaGui.div);
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@SUMINISTRO", CalculadoraHorariaGui.suminisResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@DISTRIB", CalculadoraHorariaGui.distribResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@TRANS", CalculadoraHorariaGui.transResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@CENACE", CalculadoraHorariaGui.cenaceResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@ENERGIA", CalculadoraHorariaGui.energyResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@GENBASE", CalculadoraHorariaGui.genBaseResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@GENINTER", CalculadoraHorariaGui.genInterResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@GENPUNTA", CalculadoraHorariaGui.genPuntaResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@CAPACIDAD", CalculadoraHorariaGui.capResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@SNCNMEM", CalculadoraHorariaGui.sncnmemResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@SUBTOTAL", CalculadoraHorariaGui.subTotal.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@CARGOFIJO", CalculadoraHorariaGui.cargoFijoResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@SUMENER", CalculadoraHorariaGui.energyResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@BAJATENS", CalculadoraHorariaGui.dosPercentResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@FACTORPOT", CalculadoraHorariaGui.factorPotResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@TOTAL", CalculadoraHorariaGui.total.ToString());
                paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@PREMED", CalculadoraHorariaGui.precioMedio.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@RELCOST", CalculadoraHorariaGui.relacionCostos.ToString());


                SaveFacturaFile.CreateFacturaFile(saveFileDialog, paginahtml_texto);

                MessageBox.Show("Factura guardada\n correctamente con el nombre:\n" + facturaName);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                string nameFile = DateTime.Now.ToString("ddMMyyyyHHmmss") + "O" + ".pdf";
                string facturaName = SaveFacturaFile.FacturaName(saveFileDialog, nameFile);
                string paginahtml_texto = SaveFacturaFile.HtmlTemplateOrdin();                          // Escogiendo la plantilla Ordinaria

                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@YEAR", CalculadoraOrdinariaGui.year);
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@MES", CalculadoraOrdinariaGui.month);
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@TARIFA", CalculadoraOrdinariaGui.tarifa);
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@DIVISION", CalculadoraOrdinariaGui.div);
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@SUMINISTRO", CalculadoraOrdinariaGui.suministroResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@DISTRIB", CalculadoraOrdinariaGui.distribResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@TRANS", CalculadoraOrdinariaGui.transResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@CENACE", CalculadoraOrdinariaGui.cenaceResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@ENERGIA", CalculadoraOrdinariaGui.energiaResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@CAPACIDAD", CalculadoraOrdinariaGui.capacidadResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@SNCNMEM", CalculadoraOrdinariaGui.sncnmemResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@SUBTOTAL", CalculadoraOrdinariaGui.subTotal.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@CARGOFIJO", CalculadoraOrdinariaGui.suministroResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@SUMENER", CalculadoraOrdinariaGui.energiaResult.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@BAJATENS", CalculadoraOrdinariaGui.dosPorcentBT.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@DERECHO", CalculadoraOrdinariaGui.derecho.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@TOTAL", CalculadoraOrdinariaGui.total.ToString());
                paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));                 // Stay same
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@PREMED", CalculadoraOrdinariaGui.precioMedio.ToString());
                paginahtml_texto = SaveFacturaFile.PassAttribute2Doc(paginahtml_texto, "@RELCOST", CalculadoraOrdinariaGui.relCostos.ToString());


                SaveFacturaFile.CreateFacturaFile(saveFileDialog, paginahtml_texto);

                MessageBox.Show("Factura guardada\n correctamente con el nombre:\n" + facturaName);
            }
        }
    }
}
