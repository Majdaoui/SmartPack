using SmartPack.Classes;
using System;

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
                Message msg = new Message("La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial", "Error");
                msg.ShowDialog();
               return;
            }
            if (ncontrasenya != rcontrasenya)
            {
                Message msg = new Message("Les contrasenyes no coincideixen", "Error");
                msg.ShowDialog();
                return;
            }
            string data = await dbAPI.UserLogin(GestioSessins.token, ncontrasenya);
            if (!string.IsNullOrEmpty(data))
            {
                GestioSessins.password = ncontrasenya;
                Message messatge = new Message("La nova contrasenya s'ha guardat correctament", "info");
                messatge.ShowDialog();
            }
        }
    }
}
