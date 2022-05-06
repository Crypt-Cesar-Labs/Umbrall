using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

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

        double capacidad;               // Capacidad Potencia
        double distribucion;            // Distribución Potencia
        double sncnmem;                  // SCnMEM
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
            capacidad = Convert.ToDouble(capPotQ);
            distribucion = Convert.ToDouble(distPotQ);
            sncnmem = Convert.ToDouble(scnMemQ);
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
            int dias = Calculadora.dateDiff(fechaInicio, fechaFinal);

            // Energy difference
            double energiaDiff = Calculadora.energyDiff(energiaBeg, energiaEnd);

            // Energy Reactive Difference
            double energiaReactDiff = Calculadora.energyReactDiff(energiaReactBeg, energiaReactEnd);

            // F.P
            double factorPot = Calculadora.factorPotencia(energiaDiff, energiaReactDiff);

            // F.P. Bono
            double bonificacion = Calculadora.bonificacion(factorPot);

            // F.P. Penalización
            double penalizacion = Calculadora.penalizacion(factorPot);

            // Para evaluación del factor de potencia
            double factorPotCargo = Calculadora.factorPotCargo(factorPot);

            // Determinar Potencia Eléctrica tomando en cuenta F.C. 2017
            double potenciaMovil = Calculadora.potenciaElectricaMovil(energiaDiff, dias, 0.55);

            // Determinación de potencia eléctrica para distribución
            double kwDistrib = Calculadora.potenciaDistribucion(demanda, potenciaMovil);

            // Determinación de potencia eléctrica para capacidad
            double kwCap = kwDistrib;

            // Suministro
            //double suministroResult = cantidad * suministro;
            double suministroResult = Calculadora.suministro(1, suministro);

            // Distribución
            double distribResult = Calculadora.distribucion(potenciaMovil,distribucion);

            // Transmición
            double transResult = Calculadora.transmision(energiaDiff, trans);

            // Cenace
            //double cenaceResult = energiaDiff * cenace;
            double cenaceResult = Calculadora.cenace(energiaDiff, cenace);

            // Energía 
            // double energiaResult = energiaDiff * generación;
            double energiaResult = Calculadora.energia(energiaDiff, generación);

            // Capacidad
            //double capacidadResult = potenciaMovil * capacidad;
            double capacidadResult = Calculadora.capacidad(potenciaMovil, capacidad);

            // SnCnMEM
            //double sncnmemResult = energiaDiff * scnmem;
            double sncnmemResult = Calculadora.sncnmem(energiaDiff, sncnmem);

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
            txtEnergyReactDiff.Text = energiaReactDiff.ToString();          // Energy React Diff
            txtDias.Text = dias.ToString();                                 // Date diff
            txtQMensual.Text = energiaDiff.ToString();                      // QMensual
            txtFP.Text = factorPot.ToString();                              // F.P.
            txtBono.Text = bonificacion.ToString();                         // Bono
            txtFoult.Text = penalizacion.ToString();                        // Penalizacion
            txtPotMax.Text = (Math.Ceiling(potenciaMovil)).ToString();        // Potencia Max
            txtKWDistrib.Text = (Math.Ceiling(kwDistrib)).ToString();       // Potencia eléctrica para distribución
            txtKWCapacidad.Text = (Math.Ceiling(kwCap)).ToString();         // Potencia eléctrica para capacidad
            txtSumResult.Text = suministroResult.ToString();                // Suministro
            txtDistribResult.Text = distribResult.ToString();               // Distribución
            txtTransResult.Text = transResult.ToString();                   // Transmisión
            txtCenaceResult.Text = cenaceResult.ToString();                 // Cenace
            txtEnergiaResult.Text = energiaResult.ToString();               // Energía                          
            txtCapResult.Text = capacidadResult.ToString();                 // Capacidad
            txtSncnResult.Text = sncnmemResult.ToString();                  // SnCnMEM
            txtSubTotal.Text = subTotal.ToString();                         // subtotal
            txtCargoFijo.Text = suministro.ToString();                      // Cargo fijo
            txtEnergiaDesgTotal.Text = energia.ToString();                  // Energía
            txtBajaTension.Text = dosPorcentBT.ToString();                  // 2% de baja tensión
            txtDerechoAlumbrado.Text = derecho.ToString();                  // Derecho alumbrado
            txtFPDesgTotal.Text = factorPotenciaCalc.ToString();            // Cálculo factor de potencia
            txtTotal.Text = total.ToString();                               // Total
            txtPrecioMedioResult.Text = precioMedio.ToString();                   // Precio Medio
            txtRelCostResult.Text = relCostos.ToString();                  // Relación de costos
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + "O" + ".pdf";
            

            string paginahtml_texto = Properties.Resources.plantillaOrdinaria.ToString();    // Conviertiendo a String la plantilla html proveniente de Resources

            int MaxLength = 5;
            // paginahtml_texto = paginahtml_texto.Replace("@YEAR", año);
            // paginahtml_texto = paginahtml_texto.Replace("@SUMINISTRO", txtSumResult.Text.Substring(0,MaxLength));
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@YEAR", año);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@MES", mes);            
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@TARIFA", tarifa);            
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@DIVISION", div);           
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@SUMINISTRO", txtSumResult.Text);            
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@DISTRIB", txtDistribResult.Text);           
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@TRANS", txtTransResult.Text);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@CENACE", txtCenaceResult.Text);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@ENERGIA", txtEnergiaResult.Text);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@CAPACIDAD", txtCenaceResult.Text);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@SNCNMEM", txtSncnResult.Text);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@SUBTOTAL", txtSubTotal.Text);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@CARGOFIJO", txtCargoFijo.Text);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@SUMENER", txtEnergiaDesgTotal.Text);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@BAJATENS", txtBajaTension.Text);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@DERECHO", txtDerechoAlumbrado.Text);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@TOTAL", txtTotal.Text);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));             // Stay same
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@PREMED", txtPrecioMedioResult.Text);
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@RELCOST", txtRelCostResult.Text);
            


            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create)){
                    // El stream nos ayuda a crear el archivo
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);        // Se define el tamaño y el margen del documento 

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.pimelogosize, System.Drawing.Imaging.ImageFormat.Png);

                    img.ScaleToFit(80, 60);
                    img.Alignment = Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        PdfContentByte content = writer.DirectContent;
                        Rectangle pageBorderRect = new Rectangle(pdfDoc.PageSize);
                        pageBorderRect.Left += pdfDoc.LeftMargin;
                        pageBorderRect.Right -= pdfDoc.RightMargin;
                        pageBorderRect.Top -= pdfDoc.TopMargin;
                        pageBorderRect.Bottom += pdfDoc.BottomMargin;

                        content.SetColorStroke(BaseColor.BLACK);
                        content.Rectangle(pageBorderRect.Left, pageBorderRect.Bottom, pageBorderRect.Width, pageBorderRect.Height);
                        content.Stroke();
                    }

                    pdfDoc.Close();

                    stream.Close();
                }
            }
        }
        string setValue2Doc(string doc, string textPrint, string textValue)
        {
            /* Function for solve the bug about the lenght of the TextBox's texts
             * and the maximun lenght for the text in the pdf's tickets           */

            int maxLengthText = 5;
            if (textValue.Length < maxLengthText)
            {
                maxLengthText = textValue.Length;
            }
            string replacedDoc = doc.Replace(textPrint, textValue.Substring(0, maxLengthText));
            return replacedDoc;
        }

    }
}
