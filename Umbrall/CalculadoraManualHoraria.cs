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
    public partial class CalculadoraManualHoraria : Form
    {
        public CalculadoraManualHoraria()
        {
            InitializeComponent();
        }

        // Variables for the database query

        string año;
        string mes;
        string tarifa;
        string div;

        // Local Variables for Cargos

        double capPot;          // Capacidad Potencia
        double distPot;         // Distribución Potencia
        double scnmem;          // SCnMEM
        double trans;           // Transmición
        double cenace;          // CENACE
        double generacionB;     // Generación B
        double generacionI;     // Generación I
        double generacionP;     // Generación P    
        double suministro;      // Suministro

        private void btnSearch_Click(object sender, EventArgs e)
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
            string horarioB = "B";
            string horarioI = "I";
            string horarioP = "P";

            // Generación (B, I, P)
            string generacionBQ = dbQueryCargos.ConsultaCargoTarifa(año, mes, tarifa, "Generación", "Energía", horarioB, div, cadenaConexion); // Query Special Function
            string generacionIQ = dbQueryCargos.ConsultaCargoTarifa(año, mes, tarifa, "Generación", "Energía", horarioI, div, cadenaConexion); // Query Special Function
            string generacionPQ = dbQueryCargos.ConsultaCargoTarifa(año, mes, tarifa, "Generación", "Energía", horarioP, div, cadenaConexion); // Query Special Function
            progBarQuery.Value = 100 / 2;

            // Suministro
            string suminisQ = dbQueryCargos.ConsultaCargoTarifa(año, mes, tarifa, "Suministro", "Usuarios", "NA", div, cadenaConexion);

            progBarQuery.Value = 100 / 1;
            
            progBarQuery.Visible = false;

            // Showing
            txtCapPot.Text = capPotQ;
            txtDistribPot.Text = distPotQ;
            txtScnmem.Text = scnMemQ;
            txtTransm.Text = transQ;
            txtCenace.Text = cenaceQ;
            txtGenB.Text = generacionBQ;
            txtGenI.Text = generacionIQ;
            txtGenP.Text = generacionPQ;
            txtSuminis.Text = suminisQ;

            // To double variables
            capPot = Convert.ToDouble(capPotQ);
            distPot = Convert.ToDouble(distPotQ);
            scnmem = Convert.ToDouble(scnMemQ);
            trans = Convert.ToDouble(transQ);
            cenace = Convert.ToDouble(cenaceQ);
            generacionB = Convert.ToDouble(generacionBQ);
            generacionI = Convert.ToDouble(generacionIQ);
            generacionP = Convert.ToDouble(generacionPQ);
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
            double energiaBase = Convert.ToDouble(txtEnergyBase.Text);
            double energiaInter = Convert.ToDouble(txtEnergyInter.Text);
            double energiaPunta = Convert.ToDouble(txtEnergyPunta.Text);
            double demandaBase = Convert.ToDouble(txtDemandaBase.Text);
            double demandaInter = Convert.ToDouble(txtDemandaInter.Text);
            double demandaPunta = Convert.ToDouble(txtDemandaPunta.Text);
            DateTime dateInicio = fechaInicio.Value.Date;
            DateTime dateFinal = fechaFinal.Value.Date; 
            double energiaReactiva = Convert.ToDouble(txtEnergyReact.Text);

            /******************** CALCULUS **************************/

            // Date difference
            TimeSpan tSpan = dateFinal - dateInicio;
            int dias = tSpan.Days;

            // QMensual
            double qMensual = energiaBase + energiaInter + energiaPunta;

            // Factor de potencia
            double factorPot = qMensual / Math.Sqrt(Math.Pow(qMensual, 2) + Math.Pow(energiaReactiva, 2)) * 100;

            // F.P. Bono
            double bonificacion = -((1 - 90 / factorPot) / 4);

            // F.P. Penalización
            double penalizacion = -(3 * ((90 / factorPot) - 1) / 5);

            double factorPotCargo;                  // Para evaluación del factor de potencia
            if (factorPot >= 90)
            {
                factorPotCargo = bonificacion;

            }
            else
            {
                factorPotCargo = penalizacion;
            }

            /******************** SHOW RESULTS **********************/
            txtDays.Text = dias.ToString();
            txtQMensual.Text = qMensual.ToString();
            txtFP.Text = factorPot.ToString();
        }
    }
}
