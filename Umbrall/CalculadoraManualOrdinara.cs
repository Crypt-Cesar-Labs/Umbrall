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

        // Local Variables for Cargos

        double capEnergy;       // Capacidad Energía
        double capPot;          // Capacidad Potencia
        double distPot;         // Distribución Potencia
        double scnmem;          // SCnMEM
        double trans;           // Transmición
        double cenace;          // CENACE
        double generación;      // Generación
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

            string capEne = dbQueryCargos.ConsultaCargoTarifa(año);
        }

        private void cmbYearInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexYear = cmbYearInc.SelectedIndex;       // Access to the corresponding index from the comboBox
            año = cmbYearInc.Items[indexYear].ToString();
        }

        private void cmbMonthInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMes = cmbMonthInc.SelectedIndex        
        }
    }
}
