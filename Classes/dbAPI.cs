﻿using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI;
using SmartPack.Classes;
using SmartPack.Forms;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPack
{

    public class dbAPI

    {
        public static string GetPassword(string password = "luna1234")
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(password);
            Console.WriteLine("hashed Password: " + hash);
            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, hash);
            if (isPasswordValid)
            {
                Console.WriteLine("Password is correct.");
            }
            else
            {
                Console.WriteLine("Password is incorrect.");
            }
            return hash;
        }

        public static async Task<string> ExecuteDB(object obj, string api)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://localhost:8080/auth/" + api;
                string json = JsonSerializer.Serialize(obj);
                Console.WriteLine(json);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseString = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Response Body: " + responseString);
                    return responseString;
                }
                else
                {
                    Console.WriteLine($"Error login user. Status Code: {response.StatusCode}");
                }
            }
            return null;
        }

        public static async Task<string> UserLogin(string email, string password)
        {
            ClassUsuari usuari = new ClassUsuari();
            usuari.email = email;
            usuari.password = password;
            string st = await ExecuteDB(usuari, "login");
            if (string.IsNullOrEmpty(st))
            {
                using (Message msg = new Message("El email o la contrasenya no és correcte ", "error"))
                {
                    msg.ShowDialog();
                }
            }
            else
            {
                AreaUsuari area = new AreaUsuari();
                area.Show();
            }
            return st;
        }
        private static readonly HttpClient client = new HttpClient();
        public static async Task<bool> SolicitarTokenAsync(string email)
        {

            var requestData = new { email = email };
            string json = JsonSerializer.Serialize(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            string url = "https://tu-servidor.com/api/auth/reset-password";

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Revisa tu correo para obtener el código de recuperación.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                string error = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error al solicitar el token: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        public static async Task<bool> SolicitarRecuperarPassword(string email)
        {
            var requestData = new { email = email };
            string json = JsonSerializer.Serialize(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            string url = "https://tu-servidor.com/api/auth/forgot-password";

            try
            {
                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    string token = await response.Content.ReadAsStringAsync();
                    GestioSessins.token = token;
                    MessageBox.Show("Revisa tu correo para obtener el código de recuperación.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al solicitar el token: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar conectar con el servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}