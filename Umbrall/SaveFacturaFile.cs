using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrall
{
    internal class SaveFacturaFile
    {
        /* This class is for make the save's functions for global access *
         * Include the function for repair the MaxStringLenght's bug     */

        public static string FacturaName(SaveFileDialog saveFileObject, string name = "name_no_especified")
        {
            try
            {

                saveFileObject.FileName = name + ".pdf";

                return saveFileObject.FileName;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
            

        }

        public static string HtmlTemplateOrdin()                                // Select Oraria Template
        {
            return Properties.Resources.plantillaOrdinaria.ToString();      // Select Horaria Template
        }

        public static string HtmlTemplateH()
        {
            return Properties.Resources.plantillaHoraria.ToString();
        }

        public static void CreateFacturaFile(SaveFileDialog saveFileObject, string htmlStringDoc)
        {
            // Ask for OK button 
            if(saveFileObject.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileObject.FileName, FileMode.Create))
                {
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

                    using (StringReader sr = new StringReader(htmlStringDoc))
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

        // Pass Attribute to Doc     PassAttribute2Doc
        public static string PassAttribute2Doc(string doc, string textPrint, string textValue)
        {
            /* Function for solve the bug about the lenght of the TextBox's texts *
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
