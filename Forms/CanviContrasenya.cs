using SmartPack.Classes;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SmartPack.Forms
{
    public partial class CanviContrasenya : TitleForm
    {
        public CanviContrasenya()
        {
            InitializeComponent();
        }

        private async void guardar_e_Click(object sender, EventArgs e)
        {
            string acontrasenya = contrasenya_a.Text.Trim();
            string ncontrasenya = contrasenya_n.Text.Trim();
            string rcontrasenya = contrasenya_r.Text.Trim();
            if (!Alta.ValidarContrasenya(ncontrasenya))
            {
                Message msg = new Message("La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial", "error");
                msg.ShowDialog();
               return;
            }
            if (ncontrasenya != rcontrasenya)
            {
                Message msg = new Message("Les contrasenyes no coincideixen", "error");
                msg.ShowDialog();
                return;
            }
            //GestioSessins.user = "aaahoy@hoy.com";
            var consulta = new
            {
                email = GestioSessins.user
            };           
            string data = await dbAPI.ExecuteDB(consulta, "forgot-password");
            if (!string.IsNullOrEmpty(data))
            {
                string[] parts = data.Split(':');
                string _token = parts[1].Trim();
                var req = new { token = _token, newPassword = ncontrasenya };
                string respond = await dbAPI.ExecuteDB(req, "reset-password");
                if (!string.IsNullOrEmpty(respond))
                {
                    GestioSessins.password = ncontrasenya;
                    Message messatge = new Message("La nova contrasenya s'ha guardat correctament", "info");
                    messatge.ShowDialog();
                    AreaUsuari areaUsuari = new AreaUsuari();
                    areaUsuari.Show();
                    this.Close();

                }
            }
        }
    }
}
