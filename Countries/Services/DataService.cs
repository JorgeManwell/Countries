namespace Countries.Services
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.SQLite;
    using System.IO;
    public class DataService
    {
        private SQLiteConnection connection;

        private SQLiteCommand command;

        private DialogService dialogService;

        public DataService()
        {
            dialogService = new DialogService();

            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }

            var path = @"Data\Countries.sqlite";

            try
            {
                connection = new SQLiteConnection("DataSource=" + path);
                connection.Open();

                string sqlcommand = "create table if not exists countries(Name varchar(250), Capital varchar(250), Region varchar(250), Subregion varchar(250), Population int, Gini varchar(250), Flag varchar(250))";

                command = new SQLiteCommand(sqlcommand, connection);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Error", e.Message);
            }
        }

        public void SaveData(List<Country> Countries)
        {
            try
            {
                foreach (var country in Countries)
                {
                    string sql = string.Format("insert into Countries (Name, Capital, Region, Subregion, Population, Gini, Flag) values('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}')", 
                        country.Name.Replace("'", " "), country.Capital.Replace("'", " "), country.Region.Replace("'", " "), country.Subregion.Replace("'", " "), country.Population, country.Gini, country.Flag.Replace("'", " "));

                    command = new SQLiteCommand(sql, connection);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Error", e.Message);
            }
        }

        public List<Country> GetData()
        {
            List<Country> countries = new List<Country>();

            try
            {
                string sql = "select Name, Capital, Region, Subregion, Population, Gini, Flag from Countries";

                command = new SQLiteCommand(sql,connection);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    countries.Add(new Country
                    {
                        Name = (string)reader["Name"],
                        Capital = (string)reader["Capital"],
                        Region = (string)reader["Region"],
                        Subregion = (string)reader["Subregion"],
                        Population = (int)reader["Population"],
                        Gini = (string)reader["Gini"],
                        Flag = (string)reader["Flag"],
                    });
                }
                connection.Close();

                return countries;
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Error", e.Message);
                return null;
            }
        }

        public void DeleteData()
        {
            try
            {
                string sql = "delete from Countries";

                command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Error", e.Message);
            }
        }
    }
}
