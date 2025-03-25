using SmartPack.Classes;
using SmartPack.Forms;
using System;
using System.Text.Json;

namespace SmartPack
{
    public partial class Sessio : TitleForm
    {
        public Sessio()
        {
            InitializeComponent();
            //email_is.Text = "test@example.com";
            //contrasenya_is.Text = "password123";
        }

        private async void Iniciar_sessio_Click(object sender, EventArgs e)
        {
            string temail = email_is.Text.Trim();
            string tcontrasenya = contrasenya_is.Text.Trim();
            if (string.IsNullOrEmpty(temail))
            {
                using (Message msg = new Message("El email no pot estar vuit", "error"))
                {
                    msg.ShowDialog();
                }
                return;
            }
            if (string.IsNullOrEmpty(tcontrasenya))
            {
                using (Message msg = new Message("La contrasenya no pot estar vuida ", "error"))
                {
                    msg.ShowDialog();
                }
                return;
            }

            string data = await dbAPI.UserLogin(temail, tcontrasenya);
            if (!string.IsNullOrEmpty(data))
            {
                GestioSessins.user = temail;
                GestioSessins.password = tcontrasenya;
                using (JsonDocument doc = JsonDocument.Parse(data))
                {
                    string token = doc.RootElement.GetProperty("token").GetString();
                    Console.WriteLine("Token: " + token);
                    GestioSessins.token = token;
                    using (AreaUsuari area = new AreaUsuari())
                    {
                        this.Hide();
                        area.ShowDialog();
                    }
                    this.Close();
                }
            }
        }

        private void pregunta_b_Click(object sender, EventArgs e)
        {
            using (RecuperarContrasenya formRContrasenya = new RecuperarContrasenya())
            {
                formRContrasenya.Show();
                this.Hide();
            }
               this.Show();
        }
        private void registrer_b_Click(object sender, EventArgs e)
        {
            using (Alta formAlta = new Alta())
            {
                formAlta.Show(); 
                this.Hide();
            }
                this.Show();
        }
    }
}
