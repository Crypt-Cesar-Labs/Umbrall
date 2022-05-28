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
    public partial class CalculadoraHorariaGui : Form
    {
        // Variables for the database query

        string year;
        string month;
        string tarifa;
        string div;

        // Local Variables for Cargos

        double capPot;          // Capacidad Potencia
        double distPot;         // Distribución Potencia
        double sncnmem;         // SCnMEM
        double trans;           // Transmición
        double cenace;          // CENACE
        double generacionB;     // Generación B
        double generacionI;     // Generación I
        double generacionP;     // Generación P    
        double suministro;      // Suministro

        public CalculadoraHorariaGui()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async private void btnSearch_Click(object sender, EventArgs e)
        {
 
            // Setting the database conection
            string servidor = "bhrpbyquwphyhrkbbpv1-mysql.services.clever-cloud.com";
            string puerto = "3306";
            string usuario = "ubzmsd8brxkjye7t";
            string password = "L9NNoTse1abuYH3NMsFe";
            string bd = "bhrpbyquwphyhrkbbpv1";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" + usuario + "; Password=" + password;
            progBarSearch.Visible = true;


            // Capacidad
            string capPotQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Capacidad", "Potencia", "NA", div, cadenaConexion);
            progBarSearch.Value = 100 / 7;

            // Distribución 
            string distPotQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Distribución", "Potencia", "NA", div, cadenaConexion);
            progBarSearch.Value = 100 / 6;

            // SCnMEN
            string scnMemQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "SCnMEM", "Energía", "NA", div, cadenaConexion);
            progBarSearch.Value = 100 / 5;

            // Transmisión
            string transQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Transmisión", "Energía", "NA", div, cadenaConexion);
            progBarSearch.Value = 100 / 4;

            // CENACE
            string cenaceQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "CENACE", "Energía", "NA", div, cadenaConexion);
            progBarSearch.Value = 100 / 3;

            // Generación 
            string horarioB = "B";
            string horarioI = "I";
            string horarioP = "P";

            // Generación (B, I, P)
            string generacionBQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Generación", "Energía", horarioB, div, cadenaConexion); // Query Special Function
            string generacionIQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Generación", "Energía", horarioI, div, cadenaConexion); // Query Special Function
            string generacionPQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Generación", "Energía", horarioP, div, cadenaConexion); // Query Special Function
            progBarSearch.Value = 100 / 2;

            // Suministro
            string suminisQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Suministro", "Usuarios", "NA", div, cadenaConexion);
            

            progBarSearch.Value = 100 / 1;

            await Task.Delay(2000);

            progBarSearch.Visible = false;

            // Showing
            txtCapPot.Text = capPotQ;
            txtDistPot.Text = distPotQ;
            txtScnmem.Text = scnMemQ;
            txtTrans.Text = transQ;
            txtCenace.Text = cenaceQ;
            txtGenB.Text = generacionBQ;
            txtGenI.Text = generacionIQ;
            txtGenP.Text = generacionPQ;
            txtSuminis.Text = suminisQ;

            // To double variables
            capPot = Convert.ToDouble(capPotQ);
            distPot = Convert.ToDouble(distPotQ);
            sncnmem = Convert.ToDouble(scnMemQ);
            trans = Convert.ToDouble(transQ);
            cenace = Convert.ToDouble(cenaceQ);
            generacionB = Convert.ToDouble(generacionBQ);
            generacionI = Convert.ToDouble(generacionIQ);
            generacionP = Convert.ToDouble(generacionPQ);
            suministro = Convert.ToDouble(suminisQ);
  
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexYear = comboBoxYear.SelectedIndex;       // Access to the corresponding index from the comboBox
            year = comboBoxYear.Items[indexYear].ToString();
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int indexMonth = comboBoxMonth.SelectedIndex;

            month = comboBoxMonth.Items[indexMonth].ToString();
            
        }
        private void comboBoxTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTarifa = comboBoxTarifa.SelectedIndex;

            tarifa = comboBoxTarifa.Items[indexTarifa].ToString();
        }

        private void comboBoxDiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexDiv = comboBoxDiv.SelectedIndex;

            div = comboBoxDiv.Items[indexDiv].ToString();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Getting the variables
            double energiaB = Convert.ToDouble(txtEnergiaB.Text);
            double energiaI = Convert.ToDouble(txtEnergiaI.Text);
            double energiaP = Convert.ToDouble(txtEnergiaP.Text);
            double demandaB = Convert.ToDouble(txtDemandaB.Text);
            double demandaI = Convert.ToDouble(txtDemandaI.Text);
            double demandaP = Convert.ToDouble(txtDemandaP.Text);

            DateTime dateTimeBeg = dateBegin.Value.Date;
            DateTime dateTimeEnd = dateEnd.Value.Date;

            double eReactiva = Convert.ToDouble(txtEReactiva.Text);

            double fcGdmth = 0.57;
            /******************** CALCULUS **************************/

            // Date difference
            TimeSpan tSpan = dateTimeEnd - dateTimeBeg;
            int dias = tSpan.Days;

            // QMensual
            double qMensual = energiaB + energiaI + energiaP;

            // Factor de potencia
            double factorPot = qMensual / Math.Sqrt(Math.Pow(qMensual, 2) + Math.Pow(eReactiva, 2)) * 100;

            // F.P. Bono
            double bonificacion = -((1 - 90 / factorPot) / 4);

            // F.P. Penalización
            double penalizacion = (3 * ((90 / factorPot) - 1) / 5);

            double factorPotCargo;                  // Para evaluación del factor de potencia
            if (factorPot >= 90)
            {
                factorPotCargo = bonificacion;

            }
            else
            {
                factorPotCargo = penalizacion;
            }

            ///// Potencia electrica tomando en cuenta F.C. 2017 /////
            //
            double kwMaxMovil = qMensual / (24 * dias * fcGdmth) + 0.5;


            ///// Potencia eléctrica para distribución /////////
            // Dmax
            double dmax = demandMaxFound(demandaB, demandaI, demandaP);

            // KWDistrib
            double kwDistrib = Math.Min(dmax, kwMaxMovil);

            //// Determinación de potencia eléctrica para la capacidad ////
            double kwCap = Math.Min(demandaP, kwMaxMovil);

            ///////////// COSTOS GENERALES /////////////////

            // Suministro
            double suminisResult = 1 * suministro;

            // Distribución
            double distribResult = kwDistrib * distPot;

            // Transimición
            double transResult = qMensual * trans;

            // CENACE
            double cenaceResult = qMensual * cenace;

            // Generación base
            double genBaseResult = energiaB * generacionB;

            // Generación intermedia
            double genInterResult = energiaI * generacionI;

            // Generación base
            double genPuntaResult = energiaP * generacionP;

            // Capacidad
            double capResult = kwCap * capPot;

            // SnCnMeM
            double sncnmemResult = qMensual * sncnmem;

            // SubTotal
            double subTotal = suminisResult + distribResult + transResult + cenaceResult + genBaseResult + genInterResult + genPuntaResult + capResult + sncnmemResult;

            ////////////// DESGLOCE TOTAL //////////////
            ///

            // Cargo Fijo
            double cargoFijoResult = suminisResult;

            // Energia
            double energyResult = distribResult + transResult + cenaceResult + genBaseResult + genInterResult + genPuntaResult + capResult + sncnmemResult;

            // 2% de baja tensión
            double dosPercentResult = 0.02 * subTotal;

            // Cargo factor de potencia
            double factorPotResult = factorPotCargo * subTotal;

            // Total
            double total = cargoFijoResult + energyResult + dosPercentResult + factorPotResult;

            // Precio medio 
            double precioMedio = total / qMensual;

            // Relación de costo
            double relacionCostos = ((capResult + distribResult) / (transResult + cenaceResult + genBaseResult + genInterResult + genPuntaResult)) * 100;

            /******************** SHOW RESULTS **********************/
            txtDays.Text = dias.ToString();
            txtQMensual.Text = qMensual.ToString();
            txtFP.Text = factorPot.ToString();
            txtBono.Text = bonificacion.ToString();
            txtPenal.Text = penalizacion.ToString();
            txtDmax.Text = dmax.ToString();
            txtKWDist.Text = kwDistrib.ToString();
            txtKWCap.Text = kwCap.ToString();

            // Coste General 
            txtSumResult.Text = suminisResult.ToString();
            txtDistResult.Text = distribResult.ToString();
            txtTransResult.Text = transResult.ToString();
            txtCenaceResult.Text = cenaceResult.ToString();
            txtCapResult.Text = capResult.ToString();
            txtGenBResult.Text = genBaseResult.ToString();
            txtGenIResult.Text = genInterResult.ToString();
            txtGenPResult.Text = genPuntaResult.ToString();
            txtSncResult.Text = sncnmemResult.ToString();
            txtSubTotal.Text = subTotal.ToString();

            // Desgloce Total
            txtCargoFijo.Text = cargoFijoResult.ToString();
            txtEnergy.Text = energyResult.ToString();
            txtDosPercent.Text = dosPercentResult.ToString();
            txtFPTotal.Text = factorPotResult.ToString();
            txtTotal.Text = total.ToString();
            txtPrecioMedio.Text = precioMedio.ToString();
            txtRelCost.Text = relacionCostos.ToString();
        }

        double demandMaxFound(double baseDemand, double interDemand, double puntaDemand)
        {
            // Resive tres valores para la demanda y devuelve el mayor

            double demandaMaxima = 0;

            if (baseDemand > interDemand)
            {
                if (baseDemand > puntaDemand)
                {
                    demandaMaxima = baseDemand;
                }
                else if (puntaDemand > baseDemand)
                {
                    demandaMaxima = puntaDemand;
                }
            }
            else if (interDemand > baseDemand)
            {
                if (interDemand > puntaDemand)
                {
                    demandaMaxima = interDemand;
                }
                else if (puntaDemand > interDemand)
                {
                    demandaMaxima = puntaDemand;
                }
            }
            else if (puntaDemand > baseDemand)
            {
                if (puntaDemand > interDemand)
                {
                    demandaMaxima = puntaDemand;
                }
                else if (interDemand > puntaDemand)
                {
                    demandaMaxima = interDemand;
                }
            }
            return demandaMaxima;
        }
    }
    
}
