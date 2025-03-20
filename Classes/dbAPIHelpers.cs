using SmartPack.Classes;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SmartPack
{
    internal static class dbAPIHelpers
    {
        private static readonly HttpClient client = new HttpClient();
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
                    using (Message msg = new Message("Revisa tu correo para obtener el código de recuperación.", "info"))
                    {
                        msg.ShowDialog();
                        return token;
                    }
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    using (Message msg = new Message($"Error al solicitar el token: {error}", "error"))
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