using System;

namespace SmartPack
{
    public partial class Sessio : TitleForm
    {
        public Sessio()
        {
            InitializeComponent();
        }

        private void Iniciar_sessio_Click(object sender, EventArgs e)
        {
            string temail = email_is.Text.Trim();
            string tcontrasenya = contrasenya_is.Text.Trim();

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
