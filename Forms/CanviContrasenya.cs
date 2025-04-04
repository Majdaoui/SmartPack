using SmartPack.Classes;
using System;
using System.Security.Principal;
using System.Threading.Tasks;
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

        //Metode per a canviar la contrasenya
        //Aquest mètode comprova que la contrasenya sigui vàlida i la canvia
        //Si la contrasenya no és vàlida, mostra un missatge d'error
        //Si la contrasenya no coincideix amb la repetició de la contrasenya, mostra un missatge d'error
        //Si la contrasenya s'ha canviat correctament, mostra un missatge d'informació i redirigeix a l'usuari a l'AreaUsuari
        //Si la contrasenya no s'ha canviat correctament, mostra un missatge d'error
        private async void guardar_e_Click(object sender, EventArgs e)
        {
            //Recollim les dades dels camps
            string acontrasenya = contrasenya_a.Text.Trim();
            string ncontrasenya = contrasenya_n.Text.Trim();
            string rcontrasenya = contrasenya_r.Text.Trim();
            //Comprovem la contrasenya com a mínim ha de tenir 8 caràcters, una lletra majúscula, un número i un caràcter especial
            //Si no compleix amb aquestes característiques mostrem un missatge d'error
            if (!Alta.ValidarContrasenya(ncontrasenya))
            {
                Message msg = new Message("La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial", "error");
                msg.ShowDialog();
                return;
            }
            //Comprovem que la contrasenya consisteixi amb la repetició de la contrasenya
            //Si no coincideixen mostrem un missatge d'error
            if (ncontrasenya != rcontrasenya)
            {
                Message msg = new Message("Les contrasenyes no coincideixen", "error");
                msg.ShowDialog();
                return;
            }
            //GestioSessins.user = "aaahoy@hoy.com";
            var consulta = new
            {
                password = ncontrasenya
            };
            string id_usuari = await dbAPI.getCurrentUser(GestioSessins.token);
            string resultado = await dbAPI.UpdateUser(GestioSessins.token, id_usuari, consulta);
            if (resultado != "0")
            {
                Message msg = new Message("La contrasenya s'ha canviat correctament", "info");
                msg.ShowDialog();
                this.Close();
            }
            else
            {
                Message msg = new Message("Error al canviar la contrasenya", "error");
                msg.ShowDialog();
            }


            /*
            //Fem una crida a la API per a obtenir el token
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
                    using (AreaUsuari areaUsuari = new AreaUsuari())
                    {
                        areaUsuari.Show();
                        this.Hide();
                    }
                }
            }
            */
        }
    }
}
