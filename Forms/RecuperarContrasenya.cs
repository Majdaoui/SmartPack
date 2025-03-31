using SmartPack.Classes;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string tsecret = secret_t.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(temail_rc))
            {
                using (Message msg = new Message("El camp Email no pot estar vuit ", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }
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
            string token_recovery = await consulta.forgotPassword();
            Console.WriteLine("Token Recovery: " + token_recovery);
            if (!string.IsNullOrEmpty(token_recovery) && token_recovery != "0")
            {
                using (NewPassword newpassword = new NewPassword(token_recovery))
                {
                    this.Hide();
                    newpassword.ShowDialog();

                }
                this.Close();
            }
        }
       
    }
}
