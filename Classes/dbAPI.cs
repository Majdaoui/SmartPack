using SmartPack.Classes;
using SmartPack.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPack
{
    /// <summary>
    /// Classe per a gestionar les peticions a la base de dades
    /// </summary>
    public static class dbAPI
    {
        /// <summary>
        /// Funció per a registrar un usuari a la base de dades
        /// Retorna l'id de l'usuari si s'ha registrat correctament
        /// Retorna la descripció de l'error si no s'ha pogut registrar
        /// Retorna "0" si hi ha hagut un error inesperat
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Funció per a fer login a la base de dades
        /// Retorna el token de l'usuari si s'ha fet login correctament
        /// Retorna "desactivat" si l'usuari està desactivat
        /// Retorna "0" si hi ha hagut un error inesperat
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Funció per a obtenir les dades de l'usuari actual
        /// Retorna un string amb l'id de l'usuari
        /// Retorna "0" si hi ha hagut un error inesperat
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<ClassUsuari> getCurrentUser(this string token)
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
                    if (count >= 7)
                    {
                        return usuari;
                    }
                }
            }
            return null;
        }


        /// <summary>
        /// Funció per a recuperar la contrasenya de l'usuari
        /// Retorna el token de recuperació si email i la paraula secreta es correcte
        /// Retorna "0" si hi ha hagut un error inesperat
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Funció per a canviar la contrasenya de l'usuari
        /// Retorna "correctament" si s'ha canviat la contrasenya correctament
        /// Retorna "0" si hi ha hagut un error inesperat
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Funció per a crear una empresa
        /// Retorna l'id de l'empresa si s'ha registrat correctament
        /// Retorna la descripció de l'error si no s'ha pogut registrar
        /// Retorna "0" si hi ha hagut un error inesperat
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="token"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Funció per desactivar un usuari
        /// Retorna "correctament" si s'ha desactivat l'usuari correctament
        /// Retorna "0" si hi ha hagut un error inesperat
        /// </summary>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
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

        /// <summary>
        /// funció per obtenir un usuari per id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Funció per actualitzar un usuari
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Funció per obtenir totes les empreses
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Funció per assignar un usuari a una empresa
        /// </summary>
        /// <param name="data"></param>
        /// <param name="token"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Funció per obtenir tots els usuaris
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Converter per convertir un int a string
        /// </summary>
        public class IntToStringConverter : JsonConverter<string>
        {
            /// <summary>
            /// Llegeix un valor JSON i el converteix a string
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            /// <exception cref="JsonException"></exception>
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

            /// <summary>
            /// Escriu un valor string com a JSON
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="value"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value);
            }
        }


        /// <summary>
        /// Funció per a crear un transportista
        /// </summary>
        /// <param name="transportista"></param>
        /// <param name="token"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Funció per a crear un servei
        /// </summary>
        /// <param name="servei"></param>
        /// <param name="token"></param>
        /// <returns></returns>
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
                Console.WriteLine($"CrearServei.ResponseBody: {responseBody}");
                if (responseBody.Contains("\"id\":"))
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        return doc.RootElement.GetProperty("id").GetInt32().ToString();
                    }
                }
            }
            return "0";
        }

        /// ORDENAT, ENVIAT, TRANSIT, ENTREGAT, NO_ENTREGAT, RETORNAT
        /// 

        public static async Task<string> canviEstatServei(this string id, string _estat, string token)
        {
            string url = "http://localhost:8080/servei/" + id + "/" + "estat";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var jsonBody = JsonSerializer.Serialize(new { estat = _estat });

                var request = new HttpRequestMessage
                {
                    Method = new HttpMethod("PATCH"),
                    RequestUri = new Uri(url),
                    Headers = { { "Accept", "*/*" } },
                    Content = new StringContent(jsonBody, Encoding.UTF8, "application/json")
                };
                HttpResponseMessage response = await client.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (response.IsSuccessStatusCode)
                {
                    if (responseBody.Contains("\"id\":"))
                    {
                        return "correctament";
                    }
                }
            }
            return "0";
        }

        /// <summary>
        /// Funció per obtenir un servei per id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<List<ClassServei>> getServeiPerId(string id)
        {
            List<ClassServei> serveis = null;
            string url = "http://localhost:8080/servei/usuari/" + id;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GestioSessins.token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (!string.IsNullOrEmpty(responseBody) && responseBody != "[]")
                    {

                        serveis = JsonSerializer.Deserialize<List<ClassServei>>(responseBody, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });


                        return serveis;
                    }
                }
            }
            return null;
        }


        /// <summary>
        /// Funció per actualitzar un servei
        /// </summary>
        /// <param name="servei"></param>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<string> PutUpdateServeiPerId(object servei, string id, string token)
        {
            string url = "http://localhost:8080/servei/" + id;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(servei);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response: {responseBody}");
                return responseBody;
            }
        }


        /// <summary>
        /// Funció per obtenir els serveis d'un transportista
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public static async Task<List<ClassServei>> getServeiTransportista(string id)
        {
            List<ClassServei> serveis = null;
            string url = "http://localhost:8080/servei/transportista/" + id;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GestioSessins.token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (!string.IsNullOrEmpty(responseBody) && responseBody != "[]")
                    {

                        serveis = JsonSerializer.Deserialize<List<ClassServei>>(responseBody, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                        return serveis;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Funció per a crear un vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="token"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Funció per assignar un vehicle a un transportista
        /// </summary>
        /// <param name="transportistaId"></param>
        /// <param name="vehicleId"></param>
        /// <param name="token"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Funció per actualitzar un usuari
        /// </summary>
        /// <param name="user"></param>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<string> PutUserUpdate(object user, string id, string token)
        {
            string url = "http://localhost:8080/usuari/" + id;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(user);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }


        /// <summary>
        /// Funció per actualitzar una empresa
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<string> PutEmpresaUpdate(object empresa, string id, string token)
        {
            string url = "http://localhost:8080/empresa/" + id;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(empresa);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response: {responseBody}");
                return responseBody;
            }
        }


        /// <summary>
        /// Funció per desactivar una empresa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<string> DeactivateEmpresa(string id, string token)
        {
            string url = "http://localhost:8080/empresa/" + id + "/desactivate";
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
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Console.WriteLine($"Request failed: {response.StatusCode}");
                }
            }
            return null;
        }

        /// <summary>
        /// Funció per actualitzar un vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<string> PutVehicleUpdate(object vehicle, string id, string token)
        {
            string url = "http://localhost:8080/vehicle/" + id;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(vehicle);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response vehicle: {responseBody}");
                return responseBody;
            }
        }

        /// <summary>
        /// Funció per obtenir el transportista d'un usuari
        /// </summary>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<string> GetTransportistaPerUsuari(string id, string token)
        {
            string url = "http://localhost:8080/transportista/usuari/" + id;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"GetTransportistaPerUsuari.ResponseBody: {responseBody}");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    return responseBody;
            }
            return null;
        }


        /// <summary>
        /// Funció per desactivar un vehicle
        /// </summary>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<string> DesactivarVehicle(string id, string token)
        {
            string url = "http://localhost:8080/vehicle/" + id + "/desactivate";
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

        /// <summary>
        /// Funció per desassignar un usuari d'una empresa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<string> EmpresaDesassignarUsuari(this string id, string token)
        {
            string url = "http://localhost:8080/empresa/desassignar-usuari/" + id;
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
                else
                {
                    if (responseBody.Contains("no està assignat"))
                    {
                        return "no-assignat";
                    }
                }
            }
            return "0";
        }

        /// <summary>
        /// Funció per obtenir el historial d'un servei
        /// </summary>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<List<HistorialServei>> getServeiHistorial(this string id, string token)
        {
            string url = "http://localhost:8080/servei/" + id + "/historial";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (responseBody.Contains("\"id\":"))
                    {
                        List<HistorialServei> historial = JsonSerializer.Deserialize<List<HistorialServei>>(responseBody);
                        return historial;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Funció per obtenir tots els serveis
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<List<ClassServei>> getServeiLlist(string token)
        {
            string url = "http://localhost:8080/servei/list";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (responseBody.Contains("\"id\":"))
                    {
                        List<ClassServei> vs = JsonSerializer.Deserialize<List<ClassServei>>(responseBody);
                        return vs;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Funció per obtenir tots els vehicles
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<List<ClassVehicle>> getVehicleLlist(string token)
        {
            string url = "http://localhost:8080/vehicle";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (responseBody.Contains("\"id\":"))
                    {
                        List<ClassVehicle> vehicle = JsonSerializer.Deserialize<List<ClassVehicle>>(responseBody, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                        return vehicle;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Funció per generar una factura
        /// </summary>
        /// <param name="factura"></param>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<string> generarFactura(this object factura, string id, string token)
        {
            string url = "http://localhost:8080/factura/generar/" + id;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                string json = JsonSerializer.Serialize(factura);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"CrearServei.ResponseBody: {responseBody}");
                if (responseBody.Contains("\"id\":"))
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        return doc.RootElement.GetProperty("id").GetInt32().ToString();
                    }
                }
            }
            return "0";
        }

        /// <summary>
        /// Funció per obtenir totes les factures
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<List<Factura>> getFactures(string id)
        {
            List<Factura> factures = null;
            string url = "http://localhost:8080/factura/list";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GestioSessins.token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"responseBody: {responseBody}");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (!string.IsNullOrEmpty(responseBody) && responseBody != "[]")
                    {
                        factures = JsonSerializer.Deserialize<List<Factura>>(responseBody, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                        return factures;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Funció per pagar una factura
        /// </summary>
        /// <param name="id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<string> facturaPagar(string id, string token)
        {
            string url = $"http://localhost:8080/factura/{id}/pagar"; // URL con el ID del usuario
            using (HttpClient client = new HttpClient())
            {
                // Añadir token en el header
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                HttpResponseMessage response = await client.PutAsync(url, null);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response: {responseBody}");
                return responseBody;
            }
        }

        /// <summary>
        /// Funció per obtenir el QR d'un servei
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<string> generarQR(string id)
        {
            string url = $"http://localhost:8080/servei/{id}/regenerar-qr";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GestioSessins.token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");

                // POST, no GET!
                HttpResponseMessage response = await client.PostAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"QR generat: {responseBody}");
                    return responseBody;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return null;
                }
            }
        }


        /// <summary>
        /// Funció per mostrar l'etiqueta d'un servei
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<Image> ServeiEtiqueta(string id)
        {
            string url = $"http://localhost:8080/servei/{id}/etiqueta";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GestioSessins.token);
                client.DefaultRequestHeaders.Add("Accept", "*/*");

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error en llegir la imatge: {ex.Message}");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return null;
                }
            }
        }


    }
}