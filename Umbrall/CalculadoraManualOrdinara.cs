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

        double capPotencia;             // Capacidad Potencia
        double distPotencia;            // Distribución Potencia
        double scnmem;                  // SCnMEM
        double trans;                   // Transmición
        double cenace;                  // CENACE
        double generación;              // Generación
        double suministro;              // Suministro

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
            cenace = Convert.ToDouble(cenaceQ);
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
            double fcGdmto = 0.55;
            double cantidad = 1;

            // Getting the variables
            double energiaBeg = Convert.ToDouble(txtEnergyBeg.Text);
            double energiaEnd = Convert.ToDouble(txtEnergyEnd.Text);
            double energiaReactBeg = Convert.ToDouble(txtKvarBeg.Text);
            double energiaReactEnd = Convert.ToDouble(txtKvarEnd.Text);
            DateTime fechaInicio = dateInicio.Value.Date;
            DateTime fechaFinal = dateFinal.Value.Date;
            double demanda = Convert.ToDouble(txtDemandaKW.Text);

            /***************************************************************************************/  
            // Operating
            
            // Date difference
            TimeSpan tSpan = fechaFinal - fechaInicio;
            int dias = tSpan.Days; 

            // Energy difference
            double energiaDiff = energiaEnd - energiaBeg;
            double energiaReactDiff = energiaReactEnd - energiaReactBeg;

            // F.P
            double factorPot = energiaDiff / Math.Sqrt(Math.Pow(energiaDiff, 2) + Math.Pow(energiaReactDiff,2)) * 100;

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

            // Determinar Potencia Eléctrica tomando en cuenta F.C. 2017
            double potenciaMax = energiaDiff / (24 * dias * fcGdmto);

            // Determinación de potencia eléctrica para distribución
            double kwDistrib = Math.Min(demanda, potenciaMax);

            // Determinación de potencia eléctrica para capacidad
            double kwCap = Math.Min(demanda, potenciaMax);

            // Suministro
            double suministroResult = cantidad * suministro;

            // Distribución
            double distribResult = potenciaMax * distPotencia;

            // Transmición
            double transResult = energiaDiff * trans;

            // Cenace
            double cenaceResult = energiaDiff * cenace;

            // Energía 
            double energiaResult = energiaDiff * generación;

            // Capacidad
            double capacidadResult = potenciaMax * capPotencia;

            // SnCnMEM
            double sncnmemResult = energiaDiff * scnmem;

            // SubTotal
            double subTotal = suministroResult + distribResult + transResult + cenaceResult + energiaResult + capacidadResult + sncnmemResult; 

            /************** Desgloce Total ********************/
            // Energia
            double energia = distribResult + transResult + cenaceResult + energiaResult + capacidadResult + sncnmemResult;

            // 2% de baja tensión
            double dosPorcentBT = .02 * subTotal;

            // Derecho de alumbrado 
            double derecho = 266;

            // Factor de potencia calculo 
            double factorPotenciaCalc = bonificacion * subTotal;

            // Total
            double total = suministro + energia + dosPorcentBT + derecho + factorPotenciaCalc;

            /**************** Relación de costos **************/
            // Precio medio
            double precioMedio = total / energiaDiff;

            // Relación de costos
            double relCostos = ((capacidadResult + distribResult) / (transResult + cenaceResult + energiaResult + sncnmemResult)) * 100;

            /***********************************************************************************/
            /***********************************************************************************/
            // Showing results
            txtEnergiaDiff.Text = energiaDiff.ToString();                   // Energy diff
            txtEnergyReactDiff.Text = energiaReactDiff.ToString();          // Energy React Diff
            txtDias.Text = dias.ToString();                                 // Date diff
            txtQMensual.Text = energiaDiff.ToString();                      // QMensual
            txtFP.Text = factorPot.ToString();                              // F.P.
            txtBono.Text = bonificacion.ToString();                         // Bono
            txtFoult.Text = penalizacion.ToString();                        // Penalizacion
            txtPotMax.Text = (Math.Ceiling(potenciaMax)).ToString();        // Potencia Max
            txtKWDistrib.Text = (Math.Ceiling(kwDistrib)).ToString();       // Potencia eléctrica para distribución
            txtKWCapacidad.Text = (Math.Ceiling(kwCap)).ToString();         // Potencia eléctrica para capacidad
            txtSumResult.Text = suministroResult.ToString();                // Suministro
            txtDistribResult.Text = distribResult.ToString();               // Distribución
            txtTransResult.Text = transResult.ToString();                   // Transmisión
            txtCenaceResult.Text = cenaceResult.ToString();                 // Cenace
            txtEnergiaResult.Text = energiaResult.ToString();               // Energía                          
            txtCapResult.Text = capacidadResult.ToString();                 // Capacidad
            txtSncnResult.Text = sncnmemResult.ToString();                  // SnCnMEM
            txtSubTotal.Text = subTotal.ToString();                         // total
            txtCargoFijo.Text = suministro.ToString();                      // Cargo fijo
            txtEnergiaDesgTotal.Text = energia.ToString();                  // Energía
            txtBajaTension.Text = dosPorcentBT.ToString();                  // 2% de baja tensión
            txtDerechoAlumbrado.Text = derecho.ToString();                  // Derecho alumbrado
            txtFPDesgTotal.Text = factorPotenciaCalc.ToString();            // Cálculo factor de potencia
            txtTotal.Text = total.ToString();                               // Total
            txtPrecioMedio.Text = precioMedio.ToString();                   // Precio Medio
            txtRelacionCostos.Text = relCostos.ToString();                  // Relación de costos
        }

    }
}
