using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace InfoAboutCountries
{
    public class Loader
    {
        private SqlConnection sqlConnection;
        private string connectionString;
        private string _url;

        public Loader()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString); 
        } 
        
        public Loader(string url)
        {
            _url = url;
        }

        public DataTable LoadData()
        {
            if (!String.IsNullOrEmpty(_url))
            {
                return LoadCountryFromURL();
            }
            else
            {
                return LoadAllCountriesFromDB();
            }
        }
        
        public DataTable LoadAllCountriesFromDB()
        { 
            sqlConnection.Open();
            DataSet ds = new DataSet();
            string selectAll = 
                "SELECT T.Название, T.Код_страны, T.Столица, T.Площадь, T.Население, Countries.Регионы.Название AS Регион FROM Countries.Регионы " + 
                "JOIN(SELECT Countries.Страны.Название, Countries.Страны.Код_страны, Countries.Города.Название AS Столица, Countries.Страны.Площадь, " +
                "Countries.Страны.Население, Countries.Страны.Регион FROM Countries.Страны JOIN Countries.Города " +
                "ON Countries.Страны.Столица = Countries.Города.ID) AS T ON T.Регион = Регионы.ID";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectAll, sqlConnection);
                
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            return ds.Tables[0];
        }

        public DataTable LoadCountryFromURL()
        {
            string resultJSON;
            List<Country> country;
            DataTable resultTable = CreateCountryTable();

            using (WebClient wc = new WebClient())
            {
                try
                {
                    resultJSON = wc.DownloadString(_url);
                    country = JsonConvert.DeserializeObject<List<Country>>(resultJSON);
                    resultTable.Rows.Add(country[0].name,country[0].alpha2Code,country[0].capital,country[0].area,country[0].population,country[0].region);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            return resultTable;
        }

        public DataTable CreateCountryTable()
        {
            DataTable resultTable = new DataTable();
            
            resultTable.Columns.Add("Название");
            resultTable.Columns.Add("Код_страны");
            resultTable.Columns.Add("Столица");
            resultTable.Columns.Add("Площадь");
            resultTable.Columns.Add("Население");
            resultTable.Columns.Add("Регион");

            return resultTable;
        }
    }
}