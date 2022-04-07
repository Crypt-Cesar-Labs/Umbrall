using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrall
{
    internal class HistoryRegisters
    {
        List<Tuple<double, DateTime>> listRegisters;

        public HistoryRegisters(List<Tuple<double, DateTime>> listRegisters)
        {
            this.listRegisters = listRegisters;
        }

    }
}
