using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = iTextSharp.text.Rectangle;

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
        double sncnmem;          // SCnMEM
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
            sncnmem = Convert.ToDouble(scnMemQ);
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

            double fcGdmth = 0.57;
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
            double dmax = demandMaxFound(demandaBase, demandaInter, demandaPunta);

            // KWDistrib
            double kwDistrib = Math.Min(dmax, kwMaxMovil);

            //// Determinación de potencia eléctrica para la capacidad ////
            double kwCap = Math.Min(demandaPunta, kwMaxMovil);

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
            double genBaseResult = energiaBase *  generacionB;

            // Generación intermedia
            double genInterResult = energiaInter * generacionI;

            // Generación base
            double genPuntaResult = energiaPunta * generacionP;

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
            double precioMedio = total/qMensual;

            // Relación de costo
            double relacionCostos = ((capResult + distribResult) / (transResult + cenaceResult + genBaseResult + genInterResult + genPuntaResult))*100;

            /******************** SHOW RESULTS **********************/
            txtDays.Text = dias.ToString();
            txtQMensual.Text = qMensual.ToString();
            txtFP.Text = factorPot.ToString();
            txtBono.Text = bonificacion.ToString();
            txtPena.Text = penalizacion.ToString();
            txtDmax.Text = dmax.ToString();
            txtKWDist.Text = kwDistrib.ToString();
            txtKWCap.Text = kwCap.ToString();
            txtSumResult.Text = suminisResult.ToString();
            txtDistribResult.Text = distribResult.ToString();
            txtTransResult.Text = transResult.ToString();
            txtCenaceResult.Text = cenaceResult.ToString();
            txtGenBResult.Text = genBaseResult.ToString();
            txtGenIResult.Text = genInterResult.ToString();
            txtGenPResult.Text = genPuntaResult.ToString();
            txtCapResult.Text = capResult.ToString();
            txtSnResult.Text = sncnmemResult.ToString();
            txtSubTotal.Text = subTotal.ToString();
            txtCargoFijoResult.Text = cargoFijoResult.ToString();
            txtEnergyResult.Text = energyResult.ToString();
            txtDosPercentResult.Text = dosPercentResult.ToString();
            txtFPResult.Text = factorPotResult.ToString();
            txtTotal.Text = total.ToString();
            txtPrecioMedioResult.Text = precioMedio.ToString();
            txtRelCostResult.Text = relacionCostos.ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + "H" + ".pdf";


            string paginahtml_texto = Properties.Resources.plantillaHoraria.ToString();    // Conviertiendo a String la plantilla html proveniente de Resources

            const int MaxLength = 5;                                                // Truncando la candena String

            paginahtml_texto = paginahtml_texto.Replace("@YEAR", año);
            paginahtml_texto = paginahtml_texto.Replace("@MES", mes);
            paginahtml_texto = paginahtml_texto.Replace("@TARIFA", tarifa);
            paginahtml_texto = paginahtml_texto.Replace("@DIVISION", div);
            paginahtml_texto = paginahtml_texto.Replace("@SUMINISTRO", txtSumResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@DISTRIB", txtDistribResult.Text.Substring(0, MaxLength));
            //paginahtml_texto = paginahtml_texto.Replace("@TRANS", txtTransResult.Text.Substring(0, MaxLength));
            paginahtml_texto = setValue2Doc(paginahtml_texto, "@TRANS", txtTransResult);
            paginahtml_texto = paginahtml_texto.Replace("@CENACE", txtCenaceResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@GENBASE", txtGenBResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@GENINTER", txtGenIResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@GENPUNTA", txtGenPResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@CAPACIDAD", txtCapResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@SNCNMEM", txtSnResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@SUBTOTAL", txtSubTotal.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@CARGOFIJO", txtCargoFijoResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@SUMENER", txtEnergyResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@BAJATENS", txtDosPercentResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@FACTORPOT", txtDosPercentResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@TOTAL", txtTotal.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            paginahtml_texto = paginahtml_texto.Replace("@PREMED", txtPrecioMedioResult.Text.Substring(0, MaxLength));
            paginahtml_texto = paginahtml_texto.Replace("@RELCOST", txtRelCostResult.Text.Substring(0, MaxLength));


            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    // El stream nos ayuda a crear el archivo
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);        // Se define el tamaño y el margen del documento 

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.pimelogosize, System.Drawing.Imaging.ImageFormat.Png);

                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
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
        string setValue2Doc(string doc, string textPrint, TextBox textValue)
        {
            int maxLengthText = 5;
            if (textValue.Text.Length > maxLengthText){
                maxLengthText = textValue.Text.Length;
            }
            string replacedDoc = doc.Replace(textPrint, textValue.Text.Substring(0,maxLengthText));
            return replacedDoc;
        }
    }
}
