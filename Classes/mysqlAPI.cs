using MySql.Data.MySqlClient;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SmartPack
{
    public class mysqlAPI
    {
        private static string connectionString = "Server=localhost;Port=3306;Database=smartpack;User=root;Password=;";
        public static async Task<bool> ExecuteDB(object obj, string api)
        {
            string json = JsonSerializer.Serialize(obj);
            Console.WriteLine(json);
            var dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            return false;
        }

        public static void isEmail(object obj)
        {
            dynamic data = obj;
            Console.WriteLine(data.email);
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");
                    string insertQuery = "select email from usuari where email=@email";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", data.email);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public static void instararUsari(object user)
        {
            dynamic u = user;
            Console.WriteLine(u.nom);

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    string insertQuery = "INSERT INTO usuari (id, nom, pcognom, scognom, dni, telefon, tvia, nom_via, num, planta, porta, cp, poblacio, provincia, email, password, comentaris) " +
                        "VALUES (null, @nom, @pcognom, @scognom, @dni, @telefon, @tvia, @nom_via, @num, @planta, @porta, @cp, @poblacio, @provincia, @email, @password, @comentaris)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@value1", "SomeValue1");
                        cmd.Parameters.AddWithValue("@value2", "SomeValue2");
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Data inserted successfully!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}