using System;

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

        private void Iniciar_sessio_Click(object sender, EventArgs e)
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
            _ = dbAPI.UserLogin(temail, tcontrasenya);
        }

        private void pregunta_b_Click(object sender, EventArgs e)
        {
            RecuperarContrasenya formRContrasenya = new RecuperarContrasenya();
            formRContrasenya.Show();
        }
        private void registrer_b_Click(object sender, EventArgs e)
        {
            Alta formAlta = new Alta();
            formAlta.Show();
        }
    }
}
