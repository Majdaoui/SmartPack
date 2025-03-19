using MySqlX.XDevAPI;
using SmartPack.Classes;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using SmartPack.Forms;

namespace SmartPack
{
    public partial class RecuperarContrasenya : TitleForm
    {
        public RecuperarContrasenya()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.DoubleBuffered = true;
        }

        private async void R_contrasenya_Click(object sender, EventArgs e)
        {
            string temail_rc = email_rc.Text.Trim();
            if (string.IsNullOrWhiteSpace(temail_rc))
            {
                using (Message msg = new Message("El camp Email no pot estar vuit ", "Error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }
            bool isValidFormat = System.Text.RegularExpressions.Regex.IsMatch(temail_rc, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!isValidFormat)
            {
                using (Message msg = new Message("Format d'email és incorrecte", "Error"))
                {
                    msg.ShowDialog();
                    return;
                }
                //MessageBox.Show("Format d'email és incorrecte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            string exito = await SolicitarRecuperarPassword(temail_rc);
            if (exito != null)
            {
                NewPassword newPassword = new NewPassword(exito);
                newPassword.ShowDialog();
                //MessageBox.Show("Revisa tu correo para obtener el código de recuperación.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static readonly HttpClient client = new HttpClient();
        public static async Task<string> SolicitarRecuperarPassword(string email)
        {
            var requestData = new { email = email };

            string json = JsonSerializer.Serialize(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            string url = "https://tu-servidor.com/api/auth/forgot-password"; // Asegúrate de que la URL sea la correcta

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
        public static async Task<bool> ResetearPassword(string token, string nuevaContrasenya)
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
                    MessageBox.Show("Contraseña restablecida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al restablecer la contraseña: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar conectar con el servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void email_rc_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint()
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click()
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
