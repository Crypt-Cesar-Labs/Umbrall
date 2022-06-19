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

        public static string year;
        public static string month;
        public static string tarifa;
        public static string div;

        // Local Variables for Cargos

        double capPot;          // Capacidad Potencia
        double distPot;         // Distribución Potencia
        double scnmem;          // SCnMEM
        double trans;           // Transmición
        double cenace;          // CENACE
        double generacion;      // Generación   
        double suministro;      // Suministro

        // Results

        public static double suministroResult;
        public static double distribResult;
        public static double transResult;
        public static double cenaceResult;
        public static double energiaResult;
        public static double capacidadResult;
        public static double sncnmemResult;
        public static double subTotal;
        public static double energia;
        public static double dosPorcentBT;
        public static double derecho;
        public static double factorPotenciaCalc;
        public static double total;
        public static double precioMedio;
        public static double relCostos;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async private void btnSearch_Click(object sender, EventArgs e)
        {
            // Setting the database conection
            string servidor = DataBaseHeader.host;
            int puerto = DataBaseHeader.port;
            string usuario = DataBaseHeader.user;
            string password = DataBaseHeader.password;
            string bd = DataBaseHeader.dataBase;

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; Port=" + puerto.ToString() + "; User Id=" + usuario + "; Password=" + password;
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

        #region ComboBoxes
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
        #endregion

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
            suministroResult = Calculadora.suministro(1, suministro);

            // Distribución
            distribResult = Calculadora.distribucion(potenciaMovil, distPot);

            // Transmición
            transResult = Calculadora.transmision(energiaDiff, trans);

            // Cenace
            //double cenaceResult = energiaDiff * cenace;
            cenaceResult = Calculadora.cenace(energiaDiff, cenace);

            // Energía 
            // double energiaResult = energiaDiff * generación;
            energiaResult = Calculadora.energia(energiaDiff, generacion);

            // Capacidad
            //double capacidadResult = potenciaMovil * capacidad;
            capacidadResult = Calculadora.capacidad(potenciaMovil, capPot);

            // SnCnMEM
            //double sncnmemResult = energiaDiff * scnmem;
            sncnmemResult = Calculadora.sncnmem(energiaDiff, scnmem);

            // SubTotal
            subTotal = suministroResult + distribResult + transResult + cenaceResult + energiaResult + capacidadResult + sncnmemResult;

            /************** Desgloce Total ********************/
            // Energia
            energia = distribResult + transResult + cenaceResult + energiaResult + capacidadResult + sncnmemResult;

            // 2% de baja tensión
            dosPorcentBT = .02 * subTotal;

            // Derecho de alumbrado 
            derecho = 266;

            // Factor de potencia calculo 
            factorPotenciaCalc = factorPotCargo * subTotal;

            // Total
            total = suministro + energia + dosPorcentBT + derecho + factorPotenciaCalc;

            /**************** Relación de costos **************/
            // Precio medio
            precioMedio = total / energiaDiff;

            // Relación de costos
            relCostos = ((capacidadResult + distribResult) / (transResult + cenaceResult + energiaResult + sncnmemResult)) * 100;

            /***********************************************************************************/
            /***********************************************************************************/
            // Showing results
            int lenghtResult = 7;
            txtEnergiaDiff.Text = TextFormater.TextFormatLenght(energiaDiff.ToString(), lenghtResult);                  // Energy diff
            txtReactDiff.Text = TextFormater.TextFormatLenght(reactDiff.ToString(), lenghtResult);                                                                    // Energy React Diff
            txtDays.Text = TextFormater.TextFormatLenght(days.ToString(), lenghtResult);                                                                          // Date diff
            txtQMensual.Text = TextFormater.TextFormatLenght(energiaDiff.ToString(), lenghtResult);                                                                 // QMensual
            txtFp.Text = TextFormater.TextFormatLenght(factorPot.ToString(), lenghtResult);                                                                        // F.P.
            txtBono.Text = TextFormater.TextFormatLenght(bonificacion.ToString(), lenghtResult);                                                                    // Bono
            txtPenal.Text = TextFormater.TextFormatLenght(penalizacion.ToString(), lenghtResult);                                                                   // Penalizacion
            txtMovil.Text = TextFormater.TextFormatLenght((Math.Ceiling(potenciaMovil)).ToString(), lenghtResult);                                                 // Potencia Max
            txtKWDistrib.Text = TextFormater.TextFormatLenght((Math.Ceiling(kwDistrib)).ToString(), lenghtResult);                                                    // Potencia eléctrica para distribución
            txtKWCap.Text = TextFormater.TextFormatLenght((Math.Ceiling(kwCap)).ToString(), lenghtResult);                                                          // Potencia eléctrica para capacidad
            txtPrecioMedio.Text = TextFormater.TextFormatLenght(precioMedio.ToString(), lenghtResult);                                                             // Precio Medio
            txtRelCost.Text = TextFormater.TextFormatLenght(relCostos.ToString(), lenghtResult);                                                                     // Relación de costos

            // Costo General
            txtSumResult.Text = TextFormater.TextFormatLenght(suministroResult.ToString(), lenghtResult);                // Suministro
            txtDistResult.Text = TextFormater.TextFormatLenght(distribResult.ToString(), lenghtResult);                 // Distribución
            txtTransResult.Text = TextFormater.TextFormatLenght(transResult.ToString(), lenghtResult);                   // Transmisión
            txtCenaceResult.Text = TextFormater.TextFormatLenght(cenaceResult.ToString(), lenghtResult);                  // Cenace
            txtEnergiaResult.Text = TextFormater.TextFormatLenght(energiaResult.ToString(), lenghtResult);               // Energía                         
            txtCapResult.Text = TextFormater.TextFormatLenght(capacidadResult.ToString(), lenghtResult);                // Capacidad
            txtScnmemResult.Text = TextFormater.TextFormatLenght(sncnmemResult.ToString(), lenghtResult);                 // SnCnMEM
            txtSubTotal.Text = TextFormater.TextFormatLenght(subTotal.ToString(), lenghtResult);                         // subtotal

            // Desgloce Total
            txtCargoFijo.Text = TextFormater.TextFormatLenght(suministro.ToString(), lenghtResult);                       // Cargo fijo
            txtEnergiaTotal.Text = TextFormater.TextFormatLenght(energia.ToString(), lenghtResult);                       // Energía
            txt2BajaTens.Text = TextFormater.TextFormatLenght(dosPorcentBT.ToString(), lenghtResult);                    // 2% de baja tensión
            txtDerecho.Text = TextFormater.TextFormatLenght(derecho.ToString(), lenghtResult);                            // Derecho alumbrado
            txtFPTotal.Text = TextFormater.TextFormatLenght(factorPotenciaCalc.ToString(), lenghtResult);                // Cálculo factor de potencia
            txtTotal.Text = TextFormater.TextFormatLenght(total.ToString(), lenghtResult);                               // Total
            
        }
    }
}