using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrall
{
    internal class HistoryRegisters
    {
        List<Tuple<float, DateTime>> listEnergyRegisters;

        public HistoryRegisters(List<Tuple<float, DateTime>> listEnergyRegisters)
        {
            this.listEnergyRegisters = listEnergyRegisters;
        }

        public void insertListValue(float energyValue, DateTime dateValue)
        {
            listEnergyRegisters.Add(Tuple.Create(energyValue, dateValue));
        }

        public bool SaveRegistersFile(string file)
        {
            try
            {
                StringBuilder tupleData = new StringBuilder();
                // Header
                tupleData.AppendLine("\"Energía\", \"Fecha\"");
                // StringBuilder formater
                foreach (var registroActual in listEnergyRegisters)
                {
                    tupleData.AppendLine("\"" + registroActual.Item1 + "\",\"" + registroActual.Item2 + "\"");
                }
                // Saving in the file
                System.IO.File.WriteAllText(file, tupleData.ToString());
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;

            }
        }

    }
}
