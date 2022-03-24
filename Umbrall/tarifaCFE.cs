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
    public partial class tarifaCFE : Form
    {

        //Se crean las variables para la consulta a la base datos
        public int year;
        public string month;
        public string div;
        public string cat;

        public tarifaCFE()
        {
            InitializeComponent();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceYear = cmbYear.SelectedIndex;

            string dbSearchYear = cmbYear.Items[indiceYear].ToString();

            //Se altera la variable global con los valores locales 
            year = int.Parse(dbSearchYear);
            GlobalParameters.globalYear = year.ToString();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceMonth = cmbMonth.SelectedIndex;

            string dbSearchMonth = cmbMonth.Items[indiceMonth].ToString();

            //Se altera la variable global con los valores locales 
            month = dbSearchMonth;
            GlobalParameters.globalMonth = month;
        }


        private void cmbDiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceDiv = cmbDiv.SelectedIndex;

            string dbSearchDiv = cmbDiv.Items[indiceDiv].ToString();

            //Se altera la variable global con los valores locales 
            div = dbSearchDiv;
            GlobalParameters.globalDiv = div;
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceCat = cmbCat.SelectedIndex;

            string dbSearchCat = cmbCat.Items[indiceCat].ToString();

            //Se altera la variable global con los valores locales 
            cat = dbSearchCat;
            GlobalParameters.globalTarifa = cat;
        }

        private void btnBuscarTarifa_Click(object sender, EventArgs e)
        {
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
                //Se genera el Query
                //string consulta = "SELECT valor FROM tarifas where año = " + year + " and division = " + div + ";";
                //string consString = String.Format("SELECT valor FROM tarifas WHERE año = {0} and mes = {1} and division = {2} and categoria = {3}", year, month, div, cat);

                string query = "SELECT valor FROM tarifas WHERE año = ?year AND mes = ?month AND division = ?div AND categoria = ?cat";
                MySqlCommand comandoObject = new MySqlCommand(query);
                comandoObject.Parameters.AddWithValue("?year", year);
                comandoObject.Parameters.AddWithValue("?month", month);
                comandoObject.Parameters.AddWithValue("?div", div);
                comandoObject.Parameters.AddWithValue("?cat", cat);
                comandoObject.Connection = conexionBD;
                conexionBD.Open();
                objectReader = comandoObject.ExecuteReader();

                //Para leer el dato
                while(objectReader.Read())
                {
                    dataTarifa += objectReader.GetString(0);
                }
                MessageBox.Show(dataTarifa);
                GlobalParameters.globalValue = float.Parse(dataTarifa);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);        //Mensaje de error
            }
            //MessageBox.Show("Año = " + year + "\nMes = " + month + "\nDivision = " + div + "\nCategoria = " + cat);
            finally
            {
                conexionBD.Close();         //Se cierra la conexion
            }
        }

    }
}
