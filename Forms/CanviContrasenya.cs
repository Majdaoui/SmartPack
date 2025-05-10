using SmartPack.Classes;
using System;

namespace SmartPack.Forms
{
    /// <summary>
    /// Formulari per al canvi de contrasenya de l'usuari.
    /// </summary>
    public partial class CanviContrasenya : TitleForm
    {
        /// <summary>
        /// Inicialitza els components del formulari CanviContrasenya.
        /// </summary>
        public CanviContrasenya()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestiona el tancament del formulari. Quan es tanca, obre l'AreaUsuari.
        /// </summary>
        /// <param name="e">Arguments de l'esdeveniment.</param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            AreaUsuari area = new AreaUsuari();
            area.Show();
        }

        /// <summary>
        /// Mètode per guardar la nova contrasenya de l'usuari.
        /// Comprova que la contrasenya compleixi els requisits de seguretat, coincideixi amb la repetició i actualitza l'usuari via API.
        /// Mostra missatges en funció del resultat del procés.
        /// </summary>
        /// <param name="sender">Objecte que ha desencadenat l'esdeveniment.</param>
        /// <param name="e">Arguments de l'esdeveniment del botó.</param>
        private async void guardar_e_Click(object sender, EventArgs e)
        {
            string acontrasenya = contrasenya_a.Text.Trim();
            string ncontrasenya = contrasenya_n.Text.Trim();
            string rcontrasenya = contrasenya_r.Text.Trim();

            // Validació de la nova contrasenya
            if (!Alta.ValidarContrasenya(ncontrasenya))
            {
                Message msg = new Message("La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial", "error");
                msg.ShowDialog();
                return;
            }

            // Comprovació de coincidència
            if (ncontrasenya != rcontrasenya)
            {
                Message msg = new Message("Les contrasenyes no coincideixen", "error");
                msg.ShowDialog();
                return;
            }

            var consulta = new { password = ncontrasenya };

            ClassUsuari usuari = await dbAPI.getCurrentUser(GestioSessins.token);
            if (usuari == null)
            {
                Message msg = new Message("Error al recuperar l'usuari", "info");
                msg.ShowDialog();
                return;
            }

            string id_usuari = usuari.id;
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
        }
    }
}
