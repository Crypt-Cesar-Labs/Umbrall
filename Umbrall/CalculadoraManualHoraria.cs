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
        double generacionB;     // Generación B
        double generaciónI;     // Generación I
        double generaciónP;     // Generación P    
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
            txtGen.Text = generacionQ;
            txtSum.Text = suminisQ;

            // To double variables
            capPotencia = Convert.ToDouble(capPotQ);
            distPotencia = Convert.ToDouble(distPotQ);
            scnmem = Convert.ToDouble(scnMemQ);
            trans = Convert.ToDouble(transQ);
            cenace = Convert.ToDouble(cenaceQ);
            generación = Convert.ToDouble(generacionQ);
            suministro = Convert.ToDouble(suminisQ);
        }
    }
}
