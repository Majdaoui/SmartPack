using SmartPack.Classes;
using SmartPack.Forms;
using System;
using System.Text.Json;

namespace SmartPack
{
    /// <summary>
    /// Formulari Sessio
    /// </summary>
    public partial class Sessio : TitleForm
    {
        /// <summary>
        /// Constructor del formulari de sessió.
        /// </summary>
        public Sessio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mètode que s'executa quan es tanca el formulari de sessió.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        /// <summary>
        /// Mètode que s'executa quan es fa clic al botó d'iniciar sessió.
        /// Comprova si els camps d'email i contrasenya estan buits.
        /// Si ho estan, mostra un missatge d'error.
        /// Si no, intenta iniciar sessió amb les dades proporcionades.
        /// Si el rol es admin, obre el formulari d'administració.
        /// Si el rol és deliveryman o usuari, obre el formulari Principal.
        /// Si l'usuari no existeix, mostra un missatge d'error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Iniciar_sessio_Click(object sender, EventArgs e)
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

            object user = new
            {
                email = temail,
                password = tcontrasenya,
            };
            bool state = await dbAPI.Login(user);
            
            if (GestioSessins.desactivat)
            {
                Console.WriteLine("Usuari desactivat");
                using (Message messatge = new Message("Compte desactivat, contacta amb el servei tècnic.", "error"))
                {
                    messatge.ShowDialog();
                    return;
                }
            }
            else if (!string.IsNullOrEmpty(GestioSessins.token) && GestioSessins.token != "0" )
            {
                Console.WriteLine("Token: " + GestioSessins.token);
                ClassUsuari usuari = await dbAPI.getCurrentUser(GestioSessins.token);
                if(usuari == null)
                {
                    using (Message messatge = new Message("No s'ha pogut iniciar sessió correctament, ententa'ho de nou més tard.", "error"))
                    {
                        messatge.ShowDialog();
                        return;
                    }
                }
                string id = usuari.id;
                if (!string.IsNullOrEmpty(id) && id != "0")
                {
                    GestioSessins.usuariId = id;
                    GestioSessins.id = id;
                    GestioSessins.email = temail;
                    GestioSessins.password = tcontrasenya;
                    if (GestioSessins.role != "ROLE_ADMIN")
                    {
                        Console.WriteLine("id: " + GestioSessins.id);
                        if (GestioSessins.role == "ROLE_DELIVERYMAN")
                        {
                            string response = await dbAPI.GetTransportistaPerUsuari(GestioSessins.id, GestioSessins.token);
                            if (!string.IsNullOrEmpty(response))
                            {
                                using (JsonDocument doc = JsonDocument.Parse(response))
                                {
                                    JsonElement root = doc.RootElement;
                                    GestioSessins.transportistaId = root.GetProperty("id").GetInt32().ToString();
                                }
                            }
                        }
                        Principal principal = new Principal();
                        principal.Show();
                        this.Close();
                    }
                    else if (GestioSessins.role == "ROLE_ADMIN")
                    {
                        Console.WriteLine("role: " + GestioSessins.role);
                        Administracio se = new Administracio();
                        se.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                using (Message messatge = new Message("El usuari o contrasenya és incorrecta", "error"))
                {
                    messatge.ShowDialog();
                    return;
                }
            }
        }

        /// <summary>
        /// Mètode que s'executa quan es fa clic al botó de recuperar contrasenya.
        /// Obre el formulari de recuperació de contrasenya.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pregunta_b_Click(object sender, EventArgs e)
        {
            RecuperarContrasenya formRContrasenya = new RecuperarContrasenya();
            formRContrasenya.Show();
            this.Close();
        }

        /// <summary>
        /// Mètode que s'executa quan es fa clic al botó de registre.
        /// Obre el formulari d'alta d'usuari.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrer_b_Click(object sender, EventArgs e)
        {
            Alta formAlta = new Alta();
            formAlta.Show();
            this.Close();
        }

        private void Sessio_Load(object sender, EventArgs e)
        {

        }
    }
}
