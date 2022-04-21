using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrall
{
    public partial class CalculadoraManualOrdinara : Form
    {
        public CalculadoraManualOrdinara()
        {
            InitializeComponent();
        }

        // Variables for the database query

        string año;
        string mes;
        string tarifa;
        string div;

        // Variables locales para cargos

        double capPotencia;          // Capacidad Potencia
        double distPotencia;         // Distribución Potencia
        double scnmem;          // SCnMEM
        double trans;           // Transmición
        double cenace;          // CENACE
        double generación;      // Generación
        double suministro;      // Suministro

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            // Setting the database conection
            string servidor = "bhrpbyquwphyhrkbbpv1-mysql.services.clever-cloud.com";
            string puerto = "3306";
            string usuario = "ubzmsd8brxkjye7t";
            string password = "L9NNoTse1abuYH3NMsFe";
            string bd = "bhrpbyquwphyhrkbbpv1";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" + usuario + "; Password=" + password;
            progBarQuery.Visible = true;

            // Capacidad
            string capPotQ = dbQueryCargos.ConsultaCargoTarifa(año, mes, tarifa, "Capacidad", "Potencia", "NA", div, cadenaConexion);    
            progBarQuery.Value = 100 / 7;

            // Distribución 
            string distPotQ = dbQueryCargos.ConsultaCargoTarifa(año, mes, tarifa, "Distribución", "Potencia", "NA", div, cadenaConexion);
            progBarQuery.Value = 100 / 6;

            // SCnMEN
            string scnMemQ = dbQueryCargos.ConsultaCargoTarifa(año, mes, tarifa, "SCnMEM", "Energía", "NA", div, cadenaConexion);
            progBarQuery.Value = 100 / 5;

            // Transmisión
            string transQ = dbQueryCargos.ConsultaCargoTarifa(año, mes, tarifa, "Transmisión", "Energía", "NA", div, cadenaConexion);
            progBarQuery.Value = 100 / 4;

            // CENACE
            string cenaceQ = dbQueryCargos.ConsultaCargoTarifa(año, mes, tarifa, "CENACE", "Energía", "NA", div, cadenaConexion);
            progBarQuery.Value = 100 / 3;

            // Generación 
            string generacionQ = dbQueryCargos.ConsultaCargoTarifa(año, mes, tarifa, "Generación", "Energía", "NA", div, cadenaConexion);
            progBarQuery.Value = 100 / 2;

            // Suministro
            string suminisQ = dbQueryCargos.ConsultaCargoTarifa(año, mes, tarifa, "Suministro", "Usuarios", "NA", div, cadenaConexion);

            progBarQuery.Value = 100 / 1;
            await Task.Delay(1000);
            progBarQuery.Visible = false;
            
            // Showing
            txtCapPot.Text = capPotQ;
            txtDistPot.Text = distPotQ;
            txtScnmem.Text = scnMemQ;
            txtTrans.Text = transQ;
            txtCenace.Text = cenaceQ;
            txtGen.Text = generacionQ;
            txtSum.Text = suminisQ;

            // To double variables
            capPotencia = Convert.ToDouble(capPotQ);
            distPotencia = Convert.ToDouble(distPotQ);
            scnmem = Convert.ToDouble(scnMemQ);
            trans = Convert.ToDouble(transQ);
            generación = Convert.ToDouble(generacionQ);
            suministro = Convert.ToDouble(suminisQ);
        }

        private void cmbYearInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexYear = cmbYearInc.SelectedIndex;       // Access to the corresponding index from the comboBox
            año = cmbYearInc.Items[indexYear].ToString();
        }

        private void cmbMonthInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMes = cmbMonthInc.SelectedIndex;
            mes = cmbMonthInc.Items[indexMes].ToString();
        }

        private void cmbTarifaInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTarifa = cmbTarifaInc.SelectedIndex;
            tarifa = cmbTarifaInc.Items[indexTarifa].ToString();
        }

        private void cmbDivInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexDiv = cmbDivInc.SelectedIndex;
            div = cmbDivInc.Items[indexDiv].ToString();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            // Getting the variables
            double energiaBeg = Convert.ToDouble(txtEnergyBeg.Text);
            double energiaEnd = Convert.ToDouble(txtEnergyEnd.Text);
            DateTime fechaInicio = dateInicio.Value.Date;
            DateTime fechaFinal = dateFinal.Value.Date;

            /************************************************/  
            // Operating
            
            // Date difference
            TimeSpan tSpan = fechaFinal - fechaInicio;
            int dias = tSpan.Days; 

            // Energy difference
            double energiaResult = energiaEnd - energiaBeg;

            /************************************************/
            // Showing results
            txtEnergiaDiff.Text = energiaResult.ToString();     // Energy diff
            txtDias.Text = dias.ToString();                     // Date diff
        }

       
    }
}
