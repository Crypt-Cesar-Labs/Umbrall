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
    public partial class CalculadoraHorariaGui : Form
    {
        // Variables for the database query

        string year;
        string month;
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

        public CalculadoraHorariaGui()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async private void btnSearch_Click(object sender, EventArgs e)
        {
 
            // Setting the database conection
            string servidor = "bhrpbyquwphyhrkbbpv1-mysql.services.clever-cloud.com";
            string puerto = "3306";
            string usuario = "ubzmsd8brxkjye7t";
            string password = "L9NNoTse1abuYH3NMsFe";
            string bd = "bhrpbyquwphyhrkbbpv1";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" + usuario + "; Password=" + password;
            progBarSearch.Visible = true;


            // Capacidad
            string capPotQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Capacidad", "Potencia", "NA", div, cadenaConexion);
            progBarSearch.Value = 100 / 7;

            // Distribución 
            string distPotQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Distribución", "Potencia", "NA", div, cadenaConexion);
            progBarSearch.Value = 100 / 6;

            // SCnMEN
            string scnMemQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "SCnMEM", "Energía", "NA", div, cadenaConexion);
            progBarSearch.Value = 100 / 5;

            // Transmisión
            string transQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Transmisión", "Energía", "NA", div, cadenaConexion);
            progBarSearch.Value = 100 / 4;

            // CENACE
            string cenaceQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "CENACE", "Energía", "NA", div, cadenaConexion);
            progBarSearch.Value = 100 / 3;

            // Generación 
            string horarioB = "B";
            string horarioI = "I";
            string horarioP = "P";

            // Generación (B, I, P)
            string generacionBQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Generación", "Energía", horarioB, div, cadenaConexion); // Query Special Function
            string generacionIQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Generación", "Energía", horarioI, div, cadenaConexion); // Query Special Function
            string generacionPQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Generación", "Energía", horarioP, div, cadenaConexion); // Query Special Function
            progBarSearch.Value = 100 / 2;

            // Suministro
            string suminisQ = dbQueryCargos.ConsultaCargoTarifa(year, month, tarifa, "Suministro", "Usuarios", "NA", div, cadenaConexion);
            

            progBarSearch.Value = 100 / 1;

            await Task.Delay(2000);

            progBarSearch.Visible = false;

            // Showing
            txtCapPot.Text = capPotQ;
            txtDistPot.Text = distPotQ;
            txtScnmem.Text = scnMemQ;
            txtTrans.Text = transQ;
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

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexYear = comboBoxYear.SelectedIndex;       // Access to the corresponding index from the comboBox
            year = comboBoxYear.Items[indexYear].ToString();
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int indexMonth = comboBoxMonth.SelectedIndex;

            month = comboBoxMonth.Items[indexMonth].ToString();
            
        }
        private void comboBoxTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTarifa = comboBoxTarifa.SelectedIndex;

            tarifa = comboBoxTarifa.Items[indexTarifa].ToString();
        }

        private void comboBoxDiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexDiv = comboBoxDiv.SelectedIndex;

            div = comboBoxDiv.Items[indexDiv].ToString();
        }

        
    }
    
}
