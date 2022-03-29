using MySql.Data.MySqlClient;
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
    public partial class ConsultaTarifaEmpresa : Form
    {
        // Variables for the database query
        string yearLocal;
        string monthLocal;
        string tarifaLocal;
        string divLocal;


        public ConsultaTarifaEmpresa()
        {
            InitializeComponent();
        }

        private void btnBuscarTarifa_Click(object sender, EventArgs e)
        {
            progBarQuery.Visible = true;
            
            // Setting the database conection
            string servidor = "bhrpbyquwphyhrkbbpv1-mysql.services.clever-cloud.com";
            string puerto = "3306";
            string usuario = "ubzmsd8brxkjye7t";
            string password = "L9NNoTse1abuYH3NMsFe";
            string bd = "bhrpbyquwphyhrkbbpv1";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" + usuario + "; Password=" + password;

            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader objectReader = null;
            string dataTarifa = null;

            #region horaria
            /*
            if (tarifaLocal == "GDMTH")
            {
                string horarioB = "B";
                string horarioI = "I";
                string horarioP = "P";


                string generacionB = ConsultaCargoTarifa("Generación", "Energía", horarioB, cadenaConexion); // Query Special Function
                string generacionI = ConsultaCargoTarifa("Generación", "Energía", horarioI, cadenaConexion); // Query Special Function
                string generacionP = ConsultaCargoTarifa("Generación", "Energía", horarioP, cadenaConexion); // Query Special Function

                /****************************************************************/
            /*                   The rest of the querys                     */
            /*                                                              */
            /* Here we make the rest of the querys changing only the table  */
            /*
            // Capacidad
            string capacidadEne = ConsultaCargoTarifa("Capacidad", "Energía", "NA", cadenaConexion);    // Energia
            string capacidadPot = ConsultaCargoTarifa("Capacidad", "Potencia", "NA", cadenaConexion);    // Potencia

            // Distribucion
            string distribPot = ConsultaCargoTarifa("Distribución", "Potencia", "NA", cadenaConexion);

            // SCnMEM
            string scnmem = ConsultaCargoTarifa("SCnMEM", "Energía", "NA", cadenaConexion);

            // Transmisión
            string transm = ConsultaCargoTarifa("Transmisión", "Energía", "NA", cadenaConexion);

            // CENACE
            string cenace = ConsultaCargoTarifa("CENACE", "Energía", "NA", cadenaConexion);

            // Generación
            string generacion = ConsultaCargoTarifa("Generación", "Energía", "NA", cadenaConexion);

            // Suministtro

            string suminis = ConsultaCargoTarifa("Suministro", "Usuarios", "NA", cadenaConexion);

            // Show cargos
            txtGenB.Text = generacionB;                                           // Show cargo B
            txtGenI.Text = generacionI;                                           // Show cargo I   
            txtGenP.Text = generacionP;                                           // Show cargo P   
            txtCapEne.Text = capacidadEne;
            txtCapPot.Text = capacidadPot;
            txtDistribPot.Text = distribPot;
            txtScnmem.Text = scnmem;
            txtTransm.Text = transm;
            txtCenace.Text = cenace;
            txtGen.Text = generacion;
            txtSuminis.Text = suminis;

        }
        else
        {
            txtGenB.Text = "Null";
            txtGenI.Text = "Null";
            txtGenP.Text = "Null";
        }*/
            #endregion
            try
            {
                string horarioB = "B";
                string horarioI = "I";
                string horarioP = "P";

                // Generación (B, I, P)
                string generacionB = ConsultaCargoTarifa("Generación", "Energía", horarioB, cadenaConexion); // Query Special Function
                string generacionI = ConsultaCargoTarifa("Generación", "Energía", horarioI, cadenaConexion); // Query Special Function
                string generacionP = ConsultaCargoTarifa("Generación", "Energía", horarioP, cadenaConexion); // Query Special Function
                progBarQuery.Value = 10;

                /****************************************************************/
                /*                   The rest of the querys                     */
                /*                                                              */
                /* Here we make the rest of the querys changing only the table  */

                // Capacidad
                string capacidadEne = ConsultaCargoTarifa("Capacidad", "Energía", "NA", cadenaConexion);    // Energia
                string capacidadPot = ConsultaCargoTarifa("Capacidad", "Potencia", "NA", cadenaConexion);    // Potencia
                progBarQuery.Value = 20;

                // Distribucion
                string distribPot = ConsultaCargoTarifa("Distribución", "Potencia", "NA", cadenaConexion);
                progBarQuery.Value = 50;

                // SCnMEM
                string scnmem = ConsultaCargoTarifa("SCnMEM", "Energía", "NA", cadenaConexion);
                progBarQuery.Value = 60;

                // Transmisión
                string transm = ConsultaCargoTarifa("Transmisión", "Energía", "NA", cadenaConexion);
                progBarQuery.Value = 70;

                // CENACE
                string cenace = ConsultaCargoTarifa("CENACE", "Energía", "NA", cadenaConexion);
                progBarQuery.Value = 80;

                // Generación
                string generacion = ConsultaCargoTarifa("Generación", "Energía", "NA", cadenaConexion);
                progBarQuery.Value = 90;

                // Suministtro
                string suminis = ConsultaCargoTarifa("Suministro", "Usuarios", "NA", cadenaConexion);
                progBarQuery.Value = 100;
                progBarQuery.Visible = false;

                // Show cargos
                txtGenB.Text = generacionB;                                           // Show cargo B
                txtGenI.Text = generacionI;                                           // Show cargo I   
                txtGenP.Text = generacionP;                                           // Show cargo P   
                txtCapEne.Text = capacidadEne;
                txtCapPot.Text = capacidadPot;
                txtDistribPot.Text = distribPot;
                txtScnmem.Text = scnmem;
                txtTransm.Text = transm;
                txtCenace.Text = cenace;
                txtGen.Text = generacion;
                txtSuminis.Text = suminis;
            }
            catch
            {
                MessageBox.Show("Error en la consulta de base de datos"); 
            }
        }

        string ConsultaCargoTarifa(string segmento, string concepto, string horario, string cadenaConnect)
        {
            // Making the conection
            MySqlConnection connectionDB = new MySqlConnection(cadenaConnect);
            /*****************************************************************/
            
            string cargo = null;                            // Creatign the variable for the tarifa charge
            MySqlDataReader myReader = null;                // Creating the object reader
            double cargoValue = 0; 
            try
            {
                // Making the special query for <GMTHO tarifa horaria> FROM generacion
                // Query for the <tarifa horaria basica>
                string queryGDMTH = "SELECT cargo FROM tabla_cargos WHERE año = ?yearLocal AND mes = ?monthLocal AND tarifa = ?tarifaLocal AND segmento = ?segmento AND concepto = ?concepto AND division = ?divLocal AND horario = ?horario";
                MySqlCommand comandoObject = new MySqlCommand(queryGDMTH);
                comandoObject.Parameters.AddWithValue("?yearLocal", yearLocal);
                comandoObject.Parameters.AddWithValue("?monthLocal", monthLocal);
                comandoObject.Parameters.AddWithValue("?tarifaLocal", tarifaLocal);
                comandoObject.Parameters.AddWithValue("?segmento", segmento);
                comandoObject.Parameters.AddWithValue("?concepto", concepto);
                comandoObject.Parameters.AddWithValue("?divLocal", divLocal);
                comandoObject.Parameters.AddWithValue("?horario", horario);

                
                comandoObject.Connection = connectionDB;

                connectionDB.Open();                            // Open conection 
                myReader = comandoObject.ExecuteReader();       // ExecuteReader

                
                while (myReader.Read())
                {
                    cargo = myReader.GetString(0);             // Reading trough the data 
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);        //Mensaje de error
            }
            finally
            {
                connectionDB.Close();
            }
            

            return cargo;
        }
        private void cmbYearInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexYear = cmbYearInc.SelectedIndex;               // Access to the corresponding index from the comboBox
            yearLocal = cmbYearInc.Items[indexYear].ToString();     //Asigned to local variable
        }

        private void cmbMonthInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMonth = cmbMonthInc.SelectedIndex;
            monthLocal = cmbMonthInc.Items[indexMonth].ToString();
        }

        private void cmbTarifaInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTarifa = cmbTarifaInc.SelectedIndex;
            tarifaLocal = cmbTarifaInc.Items[indexTarifa].ToString();
        }

        private void cmbDivInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexDiv = cmbDivInc.SelectedIndex;
            divLocal = cmbDivInc.Items[indexDiv].ToString();
        }
    }
}
