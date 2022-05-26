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
    public partial class CalculadoraOrdinariaGui : Form
    {
        public CalculadoraOrdinariaGui()
        {
            InitializeComponent();
        }

        // Variables for the database query

        string year;
        string month;
        string tarifa;
        string div;

        // Local Variables for Cargos

        double capPot;          // Capacidad Potencia
        double distPot;         // Distribución Potencia
        double scnmem;          // SCnMEM
        double trans;           // Transmición
        double cenace;          // CENACE
        double generacion;      // Generación   
        double suministro;      // Suministro

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
            string generacionQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Generación", "Energía", "NA", div, cadenaConexion);
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
            txtGen.Text = generacionQ;
            txtSum.Text = suminisQ;

            // To double variables
            capPot = Convert.ToDouble(capPotQ);
            distPot = Convert.ToDouble(distPotQ);
            scnmem = Convert.ToDouble(scnMemQ);
            trans = Convert.ToDouble(transQ);
            cenace = Convert.ToDouble(cenaceQ);
            generacion = Convert.ToDouble(generacionQ);
            suministro = Convert.ToDouble(suminisQ);
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexYear = cbYear.SelectedIndex;       // Access to the corresponding index from the comboBox
            year = cbYear.Items[indexYear].ToString();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMonth = cbMonth.SelectedIndex;

            month = cbMonth.Items[indexMonth].ToString();
        }

        private void cbTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTarifa = cbTarifa.SelectedIndex;

            tarifa = cbTarifa.Items[indexTarifa].ToString();
        }

        private void cbDiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexDiv = cbDiv.SelectedIndex;

            div = cbDiv.Items[indexDiv].ToString();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Getting the variables
            double energiaBeg = Convert.ToDouble(txtEnergiaBeg.Text);
            double energiaEnd = Convert.ToDouble(txtEnergiaEnd.Text);
            double reactBeg = Convert.ToDouble(txtReactBeg.Text);
            double reactEnd = Convert.ToDouble(txtReactEnd.Text);
            DateTime dateTimeBeg = dateBegin.Value.Date;
            DateTime dateTimeEnd = dateEnd.Value.Date;
            double demanda = Convert.ToDouble(txtDemanda.Text);

            /***************************************************************************************/
            // Operating

            // Date difference
            int days = Calculadora.dateDiff(dateTimeBeg, dateTimeEnd);

            // Energy difference
            double energiaDiff = Calculadora.energyDiff(energiaBeg, energiaEnd);

            // Energy Reactive Difference
            double reactDiff = Calculadora.energyReactDiff(reactBeg, reactEnd);

            // F.P
            double factorPot = Calculadora.factorPotencia(energiaDiff, reactDiff);

            // F.P. Bono
            double bonificacion = Calculadora.bonificacion(factorPot);

            // F.P. Penalización
            double penalizacion = Calculadora.penalizacion(factorPot);

            // Para evaluación del factor de potencia
            double factorPotCargo = Calculadora.factorPotCargo(factorPot);

            // Determinar Potencia Eléctrica tomando en cuenta F.C. 2017
            double potenciaMovil = Calculadora.potenciaElectricaMovil(energiaDiff, days, 0.55);

            // Determinación de potencia eléctrica para distribución
            double kwDistrib = Calculadora.potenciaDistribucion(demanda, potenciaMovil);

            // Determinación de potencia eléctrica para capacidad
            double kwCap = kwDistrib;

            // Suministro
            //double suministroResult = cantidad * suministro;
            double suministroResult = Calculadora.suministro(1, suministro);

            // Distribución
            double distribResult = Calculadora.distribucion(potenciaMovil, distPot);

            // Transmición
            double transResult = Calculadora.transmision(energiaDiff, trans);

            // Cenace
            //double cenaceResult = energiaDiff * cenace;
            double cenaceResult = Calculadora.cenace(energiaDiff, cenace);

            // Energía 
            // double energiaResult = energiaDiff * generación;
            double energiaResult = Calculadora.energia(energiaDiff, generacion);

            // Capacidad
            //double capacidadResult = potenciaMovil * capacidad;
            double capacidadResult = Calculadora.capacidad(potenciaMovil, capPot);

            // SnCnMEM
            //double sncnmemResult = energiaDiff * scnmem;
            double sncnmemResult = Calculadora.sncnmem(energiaDiff, scnmem);

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
            double factorPotenciaCalc = factorPotCargo * subTotal;

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
            txtReactDiff.Text = reactDiff.ToString();          // Energy React Diff
            txtDays.Text = days.ToString();                                 // Date diff
            txtQMensual.Text = energiaDiff.ToString();                      // QMensual
            txtFp.Text = factorPot.ToString();                              // F.P.
            txtBono.Text = bonificacion.ToString();                         // Bono
            txtPenal.Text = penalizacion.ToString();                        // Penalizacion
            txtMovil.Text = (Math.Ceiling(potenciaMovil)).ToString();        // Potencia Max
            txtKWDistrib.Text = (Math.Ceiling(kwDistrib)).ToString();       // Potencia eléctrica para distribución
            txtKWCap.Text = (Math.Ceiling(kwCap)).ToString();         // Potencia eléctrica para capacidad
            txtPrecioMedio.Text = precioMedio.ToString();                   // Precio Medio
            txtRelCost.Text = relCostos.ToString();                  // Relación de costos

            // Costo General
            txtSumResult.Text = suministroResult.ToString();                // Suministro
            txtDistResult.Text = distribResult.ToString();                  // Distribución
            txtTransResult.Text = transResult.ToString();                   // Transmisión
            txtCenaceResult.Text = cenaceResult.ToString();                 // Cenace
            txtEnergiaResult.Text = energiaResult.ToString();               // Energía                         
            txtCapResult.Text = capacidadResult.ToString();                 // Capacidad
            txtScnmemResult.Text = sncnmemResult.ToString();                  // SnCnMEM
            txtSubTotal.Text = subTotal.ToString();                         // subtotal

            // Desgloce Total
            txtCargoFijo.Text = suministro.ToString();                      // Cargo fijo
            txtEnergiaTotal.Text = energia.ToString();                  // Energía
            txt2BajaTens.Text = dosPorcentBT.ToString();                  // 2% de baja tensión
            txtDerecho.Text = derecho.ToString();                  // Derecho alumbrado
            txtFPTotal.Text = factorPotenciaCalc.ToString();            // Cálculo factor de potencia
            txtTotal.Text = total.ToString();                               // Total
            
        }
    }
}
