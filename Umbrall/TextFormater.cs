using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrall
{
    internal class TextFormater
    {
        /// <summary>
        /// Function for fonat the attribute and pass to doc
        /// </summary>
        /// <param name="doc">Document</param>
        /// <param name="textPrint">Text variable in the document</param>
        /// <param name="textValue">Parameter for set on de document</param>
        /// <returns></returns>
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

        /// <summary>
        /// Limit the lenght to show in the results
        /// </summary>
        /// <param name="text">text for limit</param>
        /// <returns></returns>
        public static string TextFormatLenght(string text, int lenght)
        {
            string resultText;
            if (text.Length < lenght)
            {
                lenght = text.Length;
            }
            resultText = text.Substring(0, lenght);

            return resultText;
        }

        
    }
}
