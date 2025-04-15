using SmartPack.Classes;
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
            this.tokenRecibido = token;
        }

        private async void R_password_Click(object sender, EventArgs e)
        {
            string password_n = npassword.Text.Trim();
            string password_r = rnpassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(password_n) || string.IsNullOrWhiteSpace(password_r))
            {
                using (Message msg = new Message("Els dos camps de contrasenya són obligatoris.", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }

            if (password_n != password_r)
            {
                using (Message msg = new Message("La repitició de la contrasenya no concideix.", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }
            //GestioSessins.user = "aaahoy@hoy.com";
            var consulta = new
            {
                token = tokenRecibido,
                newPassword = password_n
            };

            string message = await dbAPI.resetPassword(consulta);
            Console.WriteLine("message: " + message);
            if (!string.IsNullOrEmpty(message) && message.Contains("correctament"))
            {
                GestioSessins.password = password_n;
                using (Message messatge = new Message("La nova contrasenya s'ha guardat correctament", "info"))
                {
                    messatge.ShowDialog();
                }
                Sessio sessio = new Sessio();
                sessio.Show();
                this.Close();
            }
            else
            {
                using (Message messatge = new Message("Error durant el procès", "error"))
                {
                    messatge.ShowDialog();
                }
            }
        }
    }
}
