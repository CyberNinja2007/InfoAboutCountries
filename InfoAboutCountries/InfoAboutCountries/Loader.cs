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
        private SqlDataAdapter _adapter;
        private string _url;

        public Loader()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString); 
        } 
        
        public Loader(string url)
        {
            _url = url;
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString); 
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
        
        private DataTable LoadAllCountriesFromDB()
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
                _adapter = new SqlDataAdapter(selectAll, sqlConnection);
                
                _adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            sqlConnection.Close();

            return ds.Tables[0];
        }

        private DataTable LoadCountryFromURL()
        {
            string resultJSON;
            List<Country> country;
            DataTable resultTable = Creator.CreateCountryTable();

            using (WebClient wc = new WebClient())
            {
                try
                {
                    resultJSON = wc.DownloadString(_url);
                    country = JsonConvert.DeserializeObject<List<Country>>(resultJSON);
                    resultTable.Rows.Add(country[0].name,country[0].alpha2Code,country[0].capital,country[0].area,country[0].population,country[0].region);
                    return resultTable;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        
        public void LoadCountryToDB(DataTable newData)
        {
            int capital;
            int region;

            sqlConnection.Open();
            
            capital = !CheckCapital(newData.Rows[0][2].ToString().Trim())
                ? InsertCapital(newData.Rows[0][2].ToString().Trim()) : GetCapital(newData.Rows[0][2].ToString().Trim());
            
            region = !CheckRegion(newData.Rows[0][5].ToString().Trim())
                ? InsertRegion(newData.Rows[0][5].ToString().Trim()) : GetRegion(newData.Rows[0][5].ToString().Trim());

            if (!CheckCountry(newData.Rows[0][0].ToString().Trim()))
            {
                InsertCountry(newData.Rows[0], capital, region);
            }
            else
            {
                UpdateCountry(newData.Rows[0],capital,region);
            }

            MessageBox.Show("Успешно добавлено!","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            
            sqlConnection.Close();
        }

        private void UpdateCountry(DataRow country, int capital, int region)
        {
            try
            {
                string updateOld = 
                    "UPDATE Countries.Страны SET Название=@Название,Код_страны=@Код_страны,Столица=@Столица,Площадь=@Площадь,Население=@Население,Регион=@Регион "+
                    "WHERE Название = @Название";
                SqlCommand update = new SqlCommand(updateOld,sqlConnection);
            
                update.Parameters.AddWithValue("@Название", country[0].ToString().Trim());
                update.Parameters.AddWithValue("@Код_страны", country[1].ToString().Trim());
                update.Parameters.AddWithValue("@Столица", capital);
                update.Parameters.AddWithValue("@Площадь", country[3].ToString().Trim());
                update.Parameters.AddWithValue("@Население", country[4].ToString().Trim());
                update.Parameters.AddWithValue("@Регион", region);
            
                update.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool CheckCountry(string country)
        {
            bool haveCountry = false;
            
            string findCountry = 
                $"SELECT * FROM Countries.Страны WHERE Countries.Страны.Название = '{country}'";
            SqlCommand find = new SqlCommand(findCountry,sqlConnection);

            SqlDataReader sqlDataReader = find.ExecuteReader();

            if (sqlDataReader.Read())
            {
                haveCountry = true;
            }
            
            sqlDataReader.Close();
            
            return haveCountry;
        }

        private void InsertCountry(DataRow country, int capital, int region)
        {
            try
            {
                string insertNew = 
                    "INSERT INTO Countries.Страны VALUES (@Название,@Код_страны,@Столица,@Площадь,@Население,@Регион)";
                SqlCommand insert = new SqlCommand(insertNew,sqlConnection);
            
                insert.Parameters.AddWithValue("@Название", country[0].ToString());
                insert.Parameters.AddWithValue("@Код_страны", country[1].ToString());
                insert.Parameters.AddWithValue("@Столица", capital);
                insert.Parameters.AddWithValue("@Площадь", country[3].ToString());
                insert.Parameters.AddWithValue("@Население", country[4].ToString());
                insert.Parameters.AddWithValue("@Регион", region);
            
                insert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool CheckRegion(string region)
        {
            bool haveRegion = false;
            
            string findRegion = 
                $"SELECT * FROM Countries.Регионы WHERE Countries.Регионы.Название = '{region}'";
            SqlCommand find = new SqlCommand(findRegion,sqlConnection);

            SqlDataReader sqlDataReader = find.ExecuteReader();

            if (sqlDataReader.Read())
            {
                haveRegion = true;
            }
            
            sqlDataReader.Close();
            
            return haveRegion;
        }

        private int InsertRegion(string region)
        {
            
            string insertcapital = 
                $"INSERT INTO Countries.Регионы VALUES('{region}')";
            SqlCommand insert = new SqlCommand(insertcapital,sqlConnection);

            insert.ExecuteNonQuery();

            return GetRegion(region);
        }

        private int GetRegion(string region)
        {
            int regionID = 0;
            
            string findRegion = 
                $"SELECT * FROM Countries.Регионы WHERE Countries.Регионы.Название = '{region}'";
            SqlCommand find = new SqlCommand(findRegion,sqlConnection);

            SqlDataReader sqlDataReader = find.ExecuteReader();

            while (sqlDataReader.Read())
            {
                regionID = (int)sqlDataReader.GetValue(0);
            }
            
            sqlDataReader.Close();
            
            return regionID;
        }

        private bool CheckCapital(string capital)
        {
            bool haveCapital = false;
            
            string findCapital = 
                $"SELECT * FROM Countries.Города WHERE Countries.Города.Название = '{capital}'";
            SqlCommand find = new SqlCommand(findCapital,sqlConnection);

            SqlDataReader sqlDataReader = find.ExecuteReader();

            if (sqlDataReader.Read())
            {
                haveCapital = true;
            }
            
            sqlDataReader.Close();
            
            return haveCapital;
        }

        private int InsertCapital(string capital)
        {
            
            string insertcapital = 
                $"INSERT INTO Countries.Города VALUES('{capital}')";
            SqlCommand insert = new SqlCommand(insertcapital,sqlConnection);

            insert.ExecuteNonQuery();

            return GetCapital(capital);
        }

        private int GetCapital(string capital)
        {
            int capitalID = 0;
            
            string findCapital = 
                $"SELECT * FROM Countries.Города WHERE Countries.Города.Название = '{capital}'";
            SqlCommand find = new SqlCommand(findCapital,sqlConnection);

            SqlDataReader sqlDataReader = find.ExecuteReader();

            while (sqlDataReader.Read())
            {
                capitalID = (int)sqlDataReader.GetValue(0);
            }
            
            sqlDataReader.Close();
            
            return capitalID;
        }
    }
}