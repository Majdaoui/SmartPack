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
           
            string respond = await dbAPI.ExecuteDB(consulta, "reset-password");
            if (!string.IsNullOrEmpty(respond))
            {
                GestioSessins.password = password_n;
                Message messatge = new Message("La nova contrasenya s'ha guardat correctament", "info");
                messatge.ShowDialog();
                AreaUsuari areaUsuari = new AreaUsuari();
                areaUsuari.Show();
                this.Hide();

            }
        }
    }
}
