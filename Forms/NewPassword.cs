using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SmartPack.Forms
{
    public partial class NewPassword : TitleForm
    {
        private string tokenRecibido;
        public NewPassword(string token)
        {
            InitializeComponent();
            tokenRecibido = token;
        }

        private async void R_password_Click(object sender, EventArgs e)
        {
            string password_n = npassword.Text.Trim();
            string password_r = rnpassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(password_n) || string.IsNullOrWhiteSpace(password_r))
            {
                using (Message msg = new Message("Ambos campos de contraseña son obligatorios.", "Error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }

            if (password_n != password_r)
            {
                using (Message msg = new Message("Las contraseñas no coinciden.", "Error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }
            bool exito = await RestablecerPassword(tokenRecibido, password_n);
            if (exito)
            {
                using (Message msg = new Message("Contraseña restablecida correctamente.", "Éxito"))
                {
                    msg.ShowDialog();
                    this.Close();
                }
            }
        }
        private static readonly HttpClient client = new HttpClient();
        public static async Task<bool> RestablecerPassword(string token, string nuevaContrasenya)
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
                    return true;
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    using (Message msg = new Message($"Error al restablecer la contraseña: {error}", "Error"))
                    {
                        msg.ShowDialog();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                using (Message msg = new Message($"Error al intentar conectar con el servidor: {ex.Message}", "Error"))
                {
                    msg.ShowDialog();
                    return false;
                }
            }
        }
    }
}
