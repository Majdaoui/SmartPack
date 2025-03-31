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

            object user = new
            {
                email = temail,
                password = tcontrasenya,
            };
            string token = await user.Login();
            if (token == "desactivat")
            {
                Console.WriteLine("Usuari desactivat");
                return;
            }
            else if (token != "0")
            {
                Console.WriteLine("Token: " + token);
                string id = await token.getCurrentUser();
                if (id != "0")
                {
                    Console.WriteLine("id: " + id);
                    GestioSessins.token = token;
                    GestioSessins.id = id;
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
                this.Hide();
                formRContrasenya.ShowDialog();
               
            }
            this.Show();
        }

        private void registrer_b_Click(object sender, EventArgs e)
        {
            using (Alta formAlta = new Alta())
            {
                this.Hide();
                formAlta.ShowDialog();
            }
            this.Show();
        }
    }
}
