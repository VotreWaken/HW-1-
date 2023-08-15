/*
Main 
*/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp31.Models
{
    public class DataBase
    {
        SqlConnection connection = null;

        public DataBase()
        {
            this.connection = new SqlConnection();
            this.connection.ConnectionString = ConfigurationManager.ConnectionStrings["VegetablesAndFruits"].ConnectionString;
            this.connection.Open();
        }
        public void Show()
        {
            List<VegetableFruitsModel> res = new List<VegetableFruitsModel>();

            string req = "Select * from VegetablesAndFruits";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(new VegetableFruitsModel()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Type = reader.GetString(2),
                        color = reader.GetString(3),
                        calories = reader.GetInt32(4)
                    });
                }
            }
            reader.Close();

            foreach (var vegetable in res)
            {
                Console.WriteLine(vegetable.ToString());
            }
        }
        public void ShowName()
        {
            List<string> res = new List<string>();

            string req = "Select Name from VegetablesAndFruits";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            foreach (var vegetable in res)
            {
                Console.WriteLine(vegetable.ToString());
            }
        }
        public void ShowColors()
        {
            List<string> res = new List<string>();

            string req = "Select Color from VegetablesAndFruits group by Color";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            foreach (var vegetable in res)
            {
                Console.WriteLine(vegetable.ToString());
            }
        }
        public void MaxCalories()
        {
            string query = "Select MAX(Calories) from VegetablesAndFruits";
            SqlCommand cmd = new SqlCommand(query, connection);
            Console.WriteLine("Max Calories: " + cmd.ExecuteScalar().ToString());
        }

        public void MinCalories()
        {
            string query = "Select MIN(Calories) from VegetablesAndFruits";
            SqlCommand cmd = new SqlCommand(query, connection);
            Console.WriteLine("Min Calories: " + cmd.ExecuteScalar().ToString());
        }

        public void AvgCalories()
        {
            string query = "Select AVG(Calories) from VegetablesAndFruits";
            SqlCommand cmd = new SqlCommand(query, connection);
            Console.WriteLine("Average Calories: " + cmd.ExecuteScalar().ToString());
        }

        public void ShowCountVegetables()
        {
            string query = "Select Count(VegetablesAndFruits.Type) from VegetablesAndFruits Where VegetablesAndFruits.Type = 'Овощи'";
            SqlCommand cmd = new SqlCommand(query, connection);
            Console.WriteLine("Vegetable Count: " + cmd.ExecuteScalar().ToString());
        }

        public void ShowCountFruits()
        {
            string query = "Select Count(VegetablesAndFruits.Type) from VegetablesAndFruits Where VegetablesAndFruits.Type = 'Фрукт'";
            SqlCommand cmd = new SqlCommand(query, connection);
            Console.WriteLine("Fruits Count: " + cmd.ExecuteScalar().ToString());
        }

        // Fix
        public void ShowCountFruitsAndVegetablesByChooseColor(string color)
        {
            string query = $"select count(P.Color) from VegetablesAndFruits as P where P.[Type]='Овощ' and P.Color='{color}' group by P.[Type]";
            SqlCommand cmd = new SqlCommand(query, connection);
            object _countV = cmd.ExecuteScalar();

            cmd.CommandText = $"select count(P.Color) from VegetablesAndFruits as P where P.[Type]='Фрукт' and P.Color='{color}' group by P.[Type]";
            object _countF = cmd.ExecuteScalar();

            if (_countV != null)
            {
                Console.WriteLine("Count Vegetable: " + _countV.ToString());
            }

            if (_countF != null)
            {
                Console.WriteLine("Count Fruits: " + _countF.ToString());
            }

        }

        public void ShowCountEveryColor()
        {
            List<string> res = new List<string>();

            string req = "Select VegetablesAndFruits.Color, Count(Name) from VegetablesAndFruits Group by Color ";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            foreach (var vegetable in res)
            {
                Console.WriteLine(vegetable.ToString());
            }
        }

        public void ShowFruitsVegetablesUnderCalories()
        {
            List<string> res = new List<string>();

            string req = "Select Name from VegetablesAndFruits Where Calories < 15";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            foreach (var vegetable in res)
            {
                Console.WriteLine(vegetable.ToString());
            }
        }

        public void ShowFruitsVegetablesUpperCalories()
        {
            List<string> res = new List<string>();

            string req = "Select Name from VegetablesAndFruits Where Calories > 10";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            foreach (var vegetable in res)
            {
                Console.WriteLine(vegetable.ToString());
            }
        }

        public void ShowFruitsVegetablesByDiapasonCalories()
        {
            List<string> res = new List<string>();

            string req = "Select Name from VegetablesAndFruits Where Calories > 15 AND Calories < 25";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            foreach (var vegetable in res)
            {
                Console.WriteLine(vegetable.ToString());
            }
        }

        public void ShowFruitsVegetablesWithRedYellowColor()
        {
            List<string> res = new List<string>();

            string req = "Select Name from VegetablesAndFruits Where Color = 'Красный' or Color = 'Желтый'";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            foreach (var vegetable in res)
            {
                Console.WriteLine(vegetable.ToString());
            }
        }
    }
}
