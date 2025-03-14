using MySql.Data.MySqlClient;
using System;

namespace SmartPack
{
    public class mysqlAPI
    {
        private static string connectionString = "Server=localhost;Port=3306;Database=smartpack;User=root;Password=;";
        public static void test()
        {

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");
                    /*
                    string insertQuery = "INSERT INTO your_table_name (column1, column2) VALUES (@value1, @value2)";
                    using (var cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@value1", "SomeValue1");
                        cmd.Parameters.AddWithValue("@value2", "SomeValue2");
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Data inserted successfully!");
                    }
                    */
                    string query_usuari = @"
                            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'usuari')
                            BEGIN
                                CREATE TABLE usuari (
                                    ID INT PRIMARY KEY,
                                    nom VARCHAR(100) not null,
                                    pcognom VARCHAR(100) not null,
                                    scognom VARCHAR(100),
                                    dni VARCHAR(9) not null,
                                    telefon VARCHAR(15) not null,
                                    tvia VARCHAR(100) not null,
                                    carrer VARCHAR(100) not null,
                                    numero INT not null,
                                    pis VARCHAR(10),
                                    porta VARCHAR(10),
                                    codipostal VARCHAR(5) not null,
                                    poblacio VARCHAR(100) not null,
                                    provincia VARCHAR(100) not null,
                                    email VARCHAR(255) not null,
                                    contrasenya VARCHAR(255) not null,
                                    comentaris VARCHAR(255)
                                )
                            END";
                    using (var cmd = new MySqlCommand(query_usuari, connection))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Table created successfully or already exists!");
                    }
                    string query_empresa = @"
                            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'empresa')
                            BEGIN
                                CREATE TABLE empresa (
                                    ID INT PRIMARY KEY,
                                    nom_empresa VARCHAR(100) not null,
                                    cif VARCHAR(9) not null,
                                    telefon VARCHAR(15) not null,
                                    tvia VARCHAR(100) not null,
                                    carrer VARCHAR(100) not null,
                                    numero INT not null,
                                    codipostal VARCHAR(5) not null,
                                    poblacio VARCHAR(100) not null,
                                    provincia VARCHAR(100) not null,
                                    email VARCHAR(255) not null,
                                    comentaris VARCHAR(255)
                                )
                            END";
                    using (var cmd = new MySqlCommand(query_empresa, connection))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Table created successfully or already exists!");
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

                    string insertQuery = "INSERT INTO your_table_name (column1, column2) VALUES (@value1, @value2)";
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