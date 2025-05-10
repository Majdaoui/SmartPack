using System;
using System.Windows.Forms;
using SmartPack.Forms;

namespace SmartPack
{
    /// <summary>
    /// Classe que representa el formulari de recuperació de contrasenya.
    /// </summary>
    public partial class RecuperarContrasenya : TitleForm
    {
        /// <summary>
        /// Constructor del formulari de recuperació de contrasenya.
        /// </summary>
        public RecuperarContrasenya()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.DoubleBuffered = true;
        }

        /// <summary>
        /// Mètode que s'executa quan es fa clic al botó de recuperar contrasenya.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void R_contrasenya_Click(object sender, EventArgs e)
        {
            string temail_rc = email_rc.Text.Trim();
            string tsecret = secret_t.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(temail_rc))
            {
                using (Message msg = new Message("El camp Email no pot estar vuit ", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }
            // Comprovació del format de l'email
            bool isValidFormat = System.Text.RegularExpressions.Regex.IsMatch(temail_rc, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!isValidFormat)
            {
                using (Message msg = new Message("Format d'email és incorrecte", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }

            object consulta = new
            {
                email = temail_rc,
                secret = tsecret
            };
            string token_recovery = await dbAPI.forgotPassword(consulta);
            Console.WriteLine("Token Recovery: " + token_recovery);
            if (!string.IsNullOrEmpty(token_recovery) && token_recovery != "0")
            {
                NewPassword newpassword = new NewPassword(token_recovery);
                newpassword.Show();
                this.Close();
            }
            else
            {
                using (Message msg = new Message("El camp Email o la paraula secreta és incorrecte", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }
        }
       
    }
}
