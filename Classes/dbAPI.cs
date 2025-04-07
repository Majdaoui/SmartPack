using SmartPack.Classes;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SmartPack
{
    public static class dbAPI
    {
        //Funció per a registrar un usuari a la base de dades
        //Retorna l'id de l'usuari si s'ha registrat correctament
        //Retorna la descripció de l'error si no s'ha pogut registrar
        //Retorna "0" si hi ha hagut un error inesperat
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

        //Funció per a fer login a la base de dades
        //Retorna el token de l'usuari si s'ha fet login correctament
        //Retorna "desactivat" si l'usuari està desactivat
        //Retorna "0" si hi ha hagut un error inesperat

        public static async Task<bool> Login(this object user)
        {
            int count = 0;
            string url = "http://localhost:8080/auth/login";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(user);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (responseBody.Contains("\"token\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            GestioSessins.token = doc.RootElement.GetProperty("token").GetString();
                            count++;
                        }
                    }
                    
                    if (responseBody.Contains("\"role\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            GestioSessins.role = doc.RootElement.GetProperty("role").GetString();
                            count++;
                        }
                    }
                }
                else
                {
                    if (responseBody.Contains("desactivat"))
                    {
                        GestioSessins.desactivat = true;
                        return false;
                    }
                }
            }            
            return (count >= 2);
        }

        //Funció per a obtenir les dades de l'usuari actual
        //Retorna un string amb l'id de l'usuari
        //Retorna "0" si hi ha hagut un error inesperat
        public static async Task<string> getCurrentUser(this string token)
        {
            string url = "http://localhost:8080/usuari/me";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ClassUsuari usuari = new ClassUsuari();
                    int count = 0;
                    if (responseBody.Contains("\"id\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            usuari.id = doc.RootElement.GetProperty("id").GetInt32().ToString();
                            count++;
                        }
                    }
                    if (responseBody.Contains("\"email\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            usuari.email = doc.RootElement.GetProperty("email").ToString();
                            count++;
                        }
                    }
                    if (responseBody.Contains("\"nom\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            usuari.nom = doc.RootElement.GetProperty("nom").ToString();
                            count++;
                        }
                    }
                    if (responseBody.Contains("\"cognom\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            usuari.cognom = doc.RootElement.GetProperty("cognom").ToString();
                            count++;
                        }
                    }
                    if (responseBody.Contains("\"telefon\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            usuari.telefon = doc.RootElement.GetProperty("telefon").ToString();
                            count++;
                        }
                    }
                    if (responseBody.Contains("\"adreça\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            usuari.adreça = doc.RootElement.GetProperty("adreça").ToString();
                            count++;
                        }
                    }
                    if (responseBody.Contains("\"observacio\":"))
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            usuari.observacio = doc.RootElement.GetProperty("observacio").ToString();
                            count++;
                        }
                    }
                    if(count >= 7)
                    {
                        return usuari.id;
                    }
                }
            }
            return "0";
        }

        //Funció per eecuperar la contrasenya de l'usuari
        //Retorna el token de recuperació si email i la paraulña secreta es correcte
        //Retorna "0" si hi ha hagut un error inesperat
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

        //Funció per a canviar la contrasenya de l'usuari
        //Retorna "correctament" si s'ha canviat la contrasenya correctament
        //Retorna "0" si hi ha hagut un error inesperat
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

        //Funció per REGISTRE EMPRESA
        //Retorna l'id de l'empresa si s'ha registrat correctament
        //Retorna la descripció de l'error si no s'ha pogut registrar
        //Retorna "0" si hi ha hagut un error inesperat
        public static async Task<string> CreateEmpresa(this object empresa, string token)
        {
            GestioSessins.empresaId = "0";
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
                        GestioSessins.empresaId = doc.RootElement.GetProperty("id").GetInt32().ToString();
                        return GestioSessins.empresaId;
                    }
                }
            }
            return "0";
        }

        //Funció per desactivar usuari
        //Retorna "correctament" si s'ha desactivat l'usuari correctament
        //Retorna "0" si hi ha hagut un error inesperat
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

        public static async Task<ClassUsuari> GetUserByID(string id)
        {
            string url = "http://localhost:8080/usuari/" + id;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GestioSessins.token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ClassUsuari usuari = JsonSerializer.Deserialize<ClassUsuari>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return usuari;
                }
            }
            return null;
        }

        public static async Task<string> UpdateUser(string token, string userId, object user)
        {
            string url = $"http://localhost:8080/usuari/{userId}"; // URL con el ID del usuario

            using (HttpClient client = new HttpClient())
            {
                // Añadir token en el header
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");

                // Serializar el objeto usuario a JSON
                string json = JsonSerializer.Serialize(user);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                // Enviar la petición PUT
                HttpResponseMessage response = await client.PutAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"Response: {responseBody}");

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Response: successfully " + responseBody);
                    return responseBody;
                }
                else
                {
                    return "0";
                }
            }
        }


        public static async Task<string> getAllEmpresas(this string token)
        {
            string url = "http://localhost:8080/empresa/list";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    return responseBody;
            }
            return null;
        }

        public static async Task<string> assignarUsuari(this object data, string token)
        {
            string url = "http://localhost:8080/empresa/assignar-usuari";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(data);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task<string> getAllUsers(string token)
        {
            string url = "http://localhost:8080/usuari/list";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    return responseBody;
            }
            return null;
        }

        public class IntToStringConverter : JsonConverter<string>
        {
            public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.Number)
                {
                    return reader.GetInt32().ToString(); // Convierte el número a string
                }
                else if (reader.TokenType == JsonTokenType.String)
                {
                    return reader.GetString();
                }
                throw new JsonException("Unexpected token type");
            }

            public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value);
            }
        }

        public static async Task<string> crearTransportista(object transportista, string token)
        {
            string url = "http://localhost:8080/transportista/crear";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(transportista);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (responseBody.Contains("\"id\":"))
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        Transportista.id = doc.RootElement.GetProperty("id").GetInt32().ToString();
                        return Transportista.id;
                    }
                }
            }
            return "0";
        }

        public static async Task<string> crearServei(object servei, string token)
        {
            string url = "http://localhost:8080/servei/crear";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(servei);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (responseBody.Contains("\"id\":"))
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        return doc.RootElement.GetProperty("id").GetString();
                    }
                }
            }
            return "0";
        }

        public static async Task<string> crearVehicle(object vehicle, string token)
        {
            string url = "http://localhost:8080/vehicle/crear";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(vehicle);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (responseBody.Contains("\"id\":"))
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        string id = doc.RootElement.GetProperty("id").GetInt32().ToString();
                        return id;
                    }
                }
            }
            return "0";
        }

        public static async Task<string> assignarVehicleTransportista(string transportistaId, string vehicleId, string token)
        {
            string url = $"http://localhost:8080/transportista/{transportistaId}/assignar-vehicle/{vehicleId}";

            using (HttpClient client = new HttpClient())
            {
                // Afegim el token al header
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // No cal cos (body) per aquesta crida POST
                HttpResponseMessage response = await client.PostAsync(url, null);
                string responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Vehicle assignat correctament.");
                    return "OK";
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    Console.WriteLine(responseBody);
                    return "error";
                }
            }
        }


    }
}