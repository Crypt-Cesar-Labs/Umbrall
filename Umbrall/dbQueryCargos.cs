using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrall
{
    internal class dbQueryCargos
    {
        /* This class is for set a general Query to consult the database */
        

        // The query method
        public static string ConsultaCargoTarifa(string año, string mes, string tarifa, string segmento, string concepto, string horario, string div, string cadenaConnect)
        {
            // Making the connection 
            MySqlConnection connectionDB = new MySqlConnection(cadenaConnect);
            /*****************************************************/
            string cargo = null;                    // Creating the variable for the tarifa charge 
            MySqlDataReader myReader = null;        // Creating the object reader 

            try
            {
                // Query
                string query = "SELECT cargo FROM tabla_tarifas WHERE año = ?año AND mes = ?mes AND tarifa = ?tarifa AND segmento = ?segmento AND concepto = ?concepto AND division = ?div AND horario = ?horario";

                MySqlCommand comandoObject = new MySqlCommand(query);

                // Parameters
                comandoObject.Parameters.AddWithValue("?año", año);
                comandoObject.Parameters.AddWithValue("?mes", mes);
                comandoObject.Parameters.AddWithValue("?tarifa", tarifa);
                comandoObject.Parameters.AddWithValue("?segmento", segmento);
                comandoObject.Parameters.AddWithValue("?concepto", concepto);
                comandoObject.Parameters.AddWithValue("?div", div);
                comandoObject.Parameters.AddWithValue("?horario", horario);

                comandoObject.Connection = connectionDB;

                connectionDB.Open();                        // Open connection
                myReader = comandoObject.ExecuteReader();   // ExecuteReader
                
                while (myReader.Read())
                {
                    cargo = myReader.GetString(0);          // Reading trough the data
                }

            }catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }
            finally
            {
                connectionDB.Close();
            }

            return cargo;
        }
    }
}
