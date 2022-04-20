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
    public partial class CalculadoraManualHoraria : Form
    {
        public CalculadoraManualHoraria()
        {
            InitializeComponent();
        }

        // Local Variables for Cargos

        double capEnergy;       // Capacidad Energía
        double capPot;          // Capacidad Potencia
        double distPot;         // Distribución Potencia
        double scnmem;          // SCnMEM
        double trans;           // Transmición
        double cenace;          // CENACE
        double generacionB;     // Generación B
        double generaciónI;     // Generación I
        double generaciónP;     // Generación P    
        double generación;      // Generación
        double suministro;      // Suministro
    }
}
