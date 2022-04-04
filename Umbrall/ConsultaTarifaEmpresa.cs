﻿using MySql.Data.MySqlClient;
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
        string localYear;
        string localMonth;
        string localTarifa;
        string localDiv;

        // Variables for the query response
        double localGenB;
        double localGenI;
        double localGenP;
        double localCapEne;
        double localCapPot;
        double localDistribPot;
        double localScnmem;
        double localTransm;
        double localCenance;
        double localGen;
        double localSuminis;

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
                /*                   The rest of the querys                           */
                /*                                                                    */
                /* Here we make the rest of the querys changing the other parameterd  */

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

                // Passing the values for global variables in this context 
                localGenB = Convert.ToDouble(generacionB);
                localGenI = Convert.ToDouble(generacionI);
                localGenP = Convert.ToDouble(generacionP);
                localCapEne = Convert.ToDouble(capacidadEne);
                localCapPot = Convert.ToDouble(capacidadPot);
                localDistribPot = Convert.ToDouble(distribPot);
                localScnmem = Convert.ToDouble(scnmem);
                localTransm = Convert.ToDouble(transm);
                localCenance = Convert.ToDouble(cenace);
                localGen = Convert.ToDouble(generacion);
                localSuminis = Convert.ToDouble(suminis);

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
                comandoObject.Parameters.AddWithValue("?yearLocal", localYear);
                comandoObject.Parameters.AddWithValue("?monthLocal", localMonth);
                comandoObject.Parameters.AddWithValue("?tarifaLocal", localTarifa);
                comandoObject.Parameters.AddWithValue("?segmento", segmento);
                comandoObject.Parameters.AddWithValue("?concepto", concepto);
                comandoObject.Parameters.AddWithValue("?divLocal", localDiv);
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
            localYear = cmbYearInc.Items[indexYear].ToString();     //Asigned to local variable
        }

        private void cmbMonthInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMonth = cmbMonthInc.SelectedIndex;
            localMonth = cmbMonthInc.Items[indexMonth].ToString();
        }

        private void cmbTarifaInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTarifa = cmbTarifaInc.SelectedIndex;
            localTarifa = cmbTarifaInc.Items[indexTarifa].ToString();
        }

        private void cmbDivInc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexDiv = cmbDivInc.SelectedIndex;
            localDiv = cmbDivInc.Items[indexDiv].ToString();
        }

        private void btnAceptCargos_Click(object sender, EventArgs e)
        {
            // Passing the data to global context
            GlobalParameters.globalYear = localYear;
            GlobalParameters.globalMonth = localMonth;
            GlobalParameters.globalTarifa = localTarifa;
            GlobalParameters.globalDiv = localDiv;
            

            GlobalParameters.globalGenB = localGenB;
            GlobalParameters.globalGenI = localGenI;
            GlobalParameters.globalGenP = localGenP;
            GlobalParameters.globalCapEne = localCapEne;
            GlobalParameters.globalCapPot = localCapPot;
            GlobalParameters.globalDistribPot = localDistribPot;
            GlobalParameters.globalScnmem = localScnmem;
            GlobalParameters.globalTransm = localTransm;
            GlobalParameters.globalCenace = localCenance;
            GlobalParameters.globalGen = localGen;
            GlobalParameters.globalSuminis = localSuminis;


            this.Close();
        }
    }
}
