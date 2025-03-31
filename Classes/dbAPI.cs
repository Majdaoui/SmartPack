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
    public static class dbAPI
    {
        public static async Task<string> altaUser(this object user)
        {
            string url = "http://localhost:8080/auth/registrar";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(user);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (responseBody.Contains("\"description\":"))
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        return doc.RootElement.GetProperty("description").GetString();
                    }
                }
                else if (responseBody.Contains("\"id\":"))
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        return doc.RootElement.GetProperty("id").ToString();
                    }
                }
            }
            return "0";
        }

        public static async Task<string> Login(this object user)
        {
            string url = "http://localhost:8080/auth/login";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(user);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (responseBody.Contains("\"token\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            return doc.RootElement.GetProperty("token").GetString();
                        }
                    }
                }
                else
                {
                    if (responseBody.Contains("desactivat"))
                    {
                        return "desactivat";
                    }
                }
            }
            return "0";
        }

        public static async Task<string> getCurrentUser(this string token)
        {
            string url = "http://localhost:8080/usuari/me";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (responseBody.Contains("\"id\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            return doc.RootElement.GetProperty("id").ToString();
                        }
                    }
                }
            }
            return "0";
        }

        public static async Task<string> forgotPassword(this object data)
        {
            string url = "http://localhost:8080/auth/forgot-password";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(data);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (responseBody.Contains("\"tokenRecovery\":"))
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        return doc.RootElement.GetProperty("tokenRecovery").GetString();
                    }
                }
            }
            return "0";
        }

        public static async Task<string> resetPassword(this object data)
        {
            string url = "http://localhost:8080/auth/reset-password";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(data);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (responseBody.Contains("\"message\":"))
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        return doc.RootElement.GetProperty("message").GetString();
                    }
                }
            }
            return "0";
        }

        public static async Task<string> CreateEmpresa(this object empresa, string token)
        {
            string url = "http://localhost:8080/empresa/create";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(empresa);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (responseBody.Contains("\"description\":"))
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        return doc.RootElement.GetProperty("description").GetString();
                    }
                }
                else if (responseBody.Contains("\"id\":"))
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        return doc.RootElement.GetProperty("id").ToString();
                    }
                }
            }
            return "0";
        }

        public static async Task<string> DesactivateUsuari(this string id, string token)
        {
            string url = "http://localhost:8080/usuari/" + id + "/desactivate";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                var request = new HttpRequestMessage
                {
                    Method = new HttpMethod("PATCH"),
                    RequestUri = new Uri(url),
                    Headers = { { "Accept", "*/*" } }
                };
                HttpResponseMessage response = await client.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    if (responseBody.Contains("\"message\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            var ret = doc.RootElement.GetProperty("message").GetString();
                            if (ret.Contains("correctament."))
                            {
                                return "correctament";
                            }
                        }
                    }
                }
            }
            return "0";
        }
    }
}