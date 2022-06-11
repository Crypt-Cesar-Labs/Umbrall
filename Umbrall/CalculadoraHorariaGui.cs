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

        public static string year;
        public static string month;
        public static string tarifa;
        public static string div;

        
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

        
        // Results

        public static double suminisResult;
        public static double distribResult;
        public static double transResult;
        public static double cenaceResult;
        public static double genBaseResult;
        public static double genInterResult;
        public static double genPuntaResult;
        public static double capResult;
        public static double sncnmemResult;
        public static double subTotal;
        public static double cargoFijoResult;
        public static double energyResult;
        public static double dosPercentResult;
        public static double factorPotResult;
        public static double total;
        public static double precioMedio;
        public static double relacionCostos;

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
            string servidor = DataBaseHeader.host;
            string puerto = DataBaseHeader.port;
            string usuario = DataBaseHeader.user;
            string password = DataBaseHeader.password;
            string bd = DataBaseHeader.dataBase;

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

        #region ComboBoxes
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
        #endregion

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
            suminisResult = 1 * suministro;

            // Distribución
            distribResult = kwDistrib * distPot;

            // Transimición
            transResult = qMensual * trans;

            // CENACE
            cenaceResult = qMensual * cenace;

            // Generación base
            genBaseResult = energiaB * generacionB;

            // Generación intermedia
            genInterResult = energiaI * generacionI;

            // Generación base
            genPuntaResult = energiaP * generacionP;

            // Capacidad
            capResult = kwCap * capPot;

            // SnCnMeM
            sncnmemResult = qMensual * sncnmem;

            // SubTotal
            subTotal = suminisResult + distribResult + transResult + cenaceResult + genBaseResult + genInterResult + genPuntaResult + capResult + sncnmemResult;

            ////////////// DESGLOCE TOTAL //////////////
            ///

            // Cargo Fijo
            cargoFijoResult = suminisResult;

            // Energia
            energyResult = distribResult + transResult + cenaceResult + genBaseResult + genInterResult + genPuntaResult + capResult + sncnmemResult;

            // 2% de baja tensión
            dosPercentResult = 0.02 * subTotal;

            // Cargo factor de potencia
            factorPotResult = factorPotCargo * subTotal;

            // Total
            total = cargoFijoResult + energyResult + dosPercentResult + factorPotResult;

            // Precio medio 
            precioMedio = total / qMensual;

            // Relación de costo
            relacionCostos = ((capResult + distribResult) / (transResult + cenaceResult + genBaseResult + genInterResult + genPuntaResult)) * 100;


            /******************** SHOW RESULTS **********************/
            int lenghtResult = 7;
            txtDays.Text = TextFormater.TextFormatLenght(dias.ToString(), lenghtResult);
            txtQMensual.Text = TextFormater.TextFormatLenght(qMensual.ToString(), lenghtResult);
            txtFP.Text = TextFormater.TextFormatLenght(factorPot.ToString(), lenghtResult); 
            txtBono.Text = TextFormater.TextFormatLenght(bonificacion.ToString(), lenghtResult);
            txtPenal.Text = TextFormater.TextFormatLenght(penalizacion.ToString(), lenghtResult);
            txtDmax.Text = TextFormater.TextFormatLenght(dmax.ToString(), lenghtResult);
            txtKWDist.Text = TextFormater.TextFormatLenght(kwDistrib.ToString(), lenghtResult);
            txtKWCap.Text = TextFormater.TextFormatLenght(kwDistrib.ToString(), lenghtResult);

            // Coste General 
            txtSumResult.Text = TextFormater.TextFormatLenght(suminisResult.ToString(), lenghtResult);
            txtDistResult.Text = TextFormater.TextFormatLenght(distribResult.ToString(), lenghtResult);
            txtTransResult.Text = TextFormater.TextFormatLenght(transResult.ToString(), lenghtResult); 
            txtCenaceResult.Text = TextFormater.TextFormatLenght(cenaceResult.ToString(), lenghtResult); 
            txtCapResult.Text = TextFormater.TextFormatLenght(capResult.ToString(), lenghtResult); 
            txtGenBResult.Text = TextFormater.TextFormatLenght(genBaseResult.ToString(), lenghtResult); 
            txtGenIResult.Text = TextFormater.TextFormatLenght(genInterResult.ToString(), lenghtResult); 
            txtGenPResult.Text = TextFormater.TextFormatLenght(genPuntaResult.ToString(), lenghtResult); 
            txtSncResult.Text = TextFormater.TextFormatLenght(sncnmemResult.ToString(), lenghtResult); 
            txtSubTotal.Text = 

            // Desgloce Total
            txtCargoFijo.Text = TextFormater.TextFormatLenght(cargoFijoResult.ToString(), lenghtResult);
            txtEnergy.Text = TextFormater.TextFormatLenght(energyResult.ToString(), lenghtResult);
            txtDosPercent.Text = TextFormater.TextFormatLenght(dosPercentResult.ToString(), lenghtResult); 
            txtFPTotal.Text = TextFormater.TextFormatLenght(factorPotResult.ToString(), lenghtResult); 
            txtTotal.Text = TextFormater.TextFormatLenght(total.ToString(), lenghtResult); 
            txtPrecioMedio.Text = TextFormater.TextFormatLenght(precioMedio.ToString(), lenghtResult); 
            txtRelCost.Text = TextFormater.TextFormatLenght(relacionCostos.ToString(), lenghtResult); 
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
