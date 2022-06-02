using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Umbrall
{
    internal class ShowingParameters
    {
        private static Thread showParamThread; 
        public static void StartShow()
        {
            showParamThread = new Thread(ShowProc);
            showParamThread.Start();
        }

        private static void ShowProc()
        {
            while (true)
            {
                Console.WriteLine("Mostrando datos desde el Thread {0} ", showParamThread.ManagedThreadId);

            }
        }

        private void ShowingParams()
        {
            MonitorGui.txtVrms
        }
        public static void StopShow()
        {

        }
    }
}
