using Google.Protobuf.WellKnownTypes;
using SmartPack.Classes;
using SmartPack.Forms;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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

        public static async Task<bool> ExecuteDB(object obj, string api)
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
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error login user. Status Code: {response.StatusCode}");
                }
            }
            return false;
        }

        public static async Task UserLogin(string email, string password)
        {
            ClassUsuari usuari = new ClassUsuari();
            usuari.email = email;
            usuari.password = password;
            bool st = await ExecuteDB(usuari, "login");
            if (!st)
            {
                using (Message msg = new Message("El email o la contrasenya no és correcte ", "error"))
                {
                    msg.ShowDialog();
                }
            }
            else
            {
                Principal principal = new Principal();
                principal.Show();
            }
        }
       
    }
}
