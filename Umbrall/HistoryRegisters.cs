using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrall
{
    internal class HistoryRegisters
    {
        List<Tuple<double, DateTime>> listEnergyRegisters;

        public HistoryRegisters(List<Tuple<double, DateTime>> listEnergyRegisters)
        {
            this.listEnergyRegisters = listEnergyRegisters;
        }

    }
}
