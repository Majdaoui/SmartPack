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
        // Funció per obtenir la contrasenya encriptada
        // Retorna la contrasenya encriptada
        // Si la contrasenya és correcta, retorna "Password is correct."
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
        // Funció per executar una petició a la base de dades
        // Retorna la resposta de la base de dades
        // Si la resposta és correcta, retorna la resposta
        // Si la resposta és incorrecta, mostra un missatge d'error
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
        // Funció per obtenir les dades de l'usuari
        // Retorna les dades de l'usuari
        // Si les dades són correctes, retorna les dades de l'usuari
        // Si les dades són incorrectes, mostra un missatge d'error
        // Si les dades són incorrectes, retorna null
        public static async Task<string> UserDB(object obj, string api)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://localhost:8080/usuari/{id}" + api;
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
                    Console.WriteLine($"Error get data user. Status Code: {response.StatusCode}");
                }
            }
            return null;
        }

        // Funció per obtenir les dades de l'empresa
        // Retorna les dades de l'empresa
        // Si les dades són correctes, retorna les dades de l'empresa
        // Si les dades són incorrectes, mostra un missatge d'error, retorna null
        public static async Task<string> EmpresaDB(object obj, string api)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://localhost:8080/empresa/" + api;
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
                    Console.WriteLine($"Error get data user. Status Code: {response.StatusCode}");
                }
            }
            return null;
        }
        // Funció per login de l'usuari
        // Retorna les dades de l'usuari
        // Si les dades són correctes, retorna token de l'usuari
        // Si les dades són incorrectes, mostra un missatge d'error, retorna null
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
                return null;
            }
            return st;
        }

        private static readonly HttpClient client = new HttpClient();

        // Funció per solicitar el token amb elmail
        // Retorna el token de la recuperació de la contrasenya
        // Si les dades són correctes, retorna el token
        // Si les dades són incorrectes, mostra un missatge d'error, retorna null
        public static async Task<string> SolicitarTokenAsync(string email)
        {
            var requestData = new { email = email };
            string json = JsonSerializer.Serialize(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            string url = "https://tu-servidor.com/api/auth/reset-password";
            HttpResponseMessage response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Revisa tu correo para obtener el código de recuperación.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return GestioSessins.token = await response.Content.ReadAsStringAsync();
            }
            else
            {
                string error = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error al solicitar el token: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Funció per recuperar la contrasenya
        // Retorna el token de la recuperació de la contrasenya
        // Si les dades són correctes, retorna el token
        // Si les dades són incorrectes, mostra un missatge d'error, retorna null
        public static async Task<string> SolicitarRecuperarPassword(string email)
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
                    return token;
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al solicitar el token: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar conectar con el servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //
        public static async Task<string> ResetearPassword(string token, string nuevaContrasenya)
        {
            var requestData = new { token = token, password = nuevaContrasenya };
            string json = JsonSerializer.Serialize(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            string url = "https://tu-servidor.com/api/auth/reset-password";
            try
            {
                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    using (Message msg = new Message("Contraseña restablecida correctamente.", "info"))
                    {
                        msg.ShowDialog();
                        return token;
                    }
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    using (Message msg = new Message($"Error al restablecer la contraseña: {error}", "error"))
                    {
                        msg.ShowDialog();
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                using (Message msg = new Message($"Error al intentar conectar con el servidor: {ex.Message}", "error"))
                {
                    msg.ShowDialog();
                    return null;
                }
            }
        }
    }
}