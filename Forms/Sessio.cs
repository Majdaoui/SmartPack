using SmartPack.Classes;
using SmartPack.Forms;
using System;
using System.Text.Json;
using System.Windows.Forms;

namespace SmartPack
{
    public partial class Sessio : TitleForm
    {
        public Sessio()
        {
            InitializeComponent();
        }

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
            else if (GestioSessins.token != "0" )
            {
                Console.WriteLine("Token: " + GestioSessins.token);
                string id = await dbAPI.getCurrentUser(GestioSessins.token);
                if (!string.IsNullOrEmpty(id) && id != "0")
                {
                    GestioSessins.id = id;
                    if (GestioSessins.role != "ROLE_ADMIN")
                    {
                        Console.WriteLine("id: " + GestioSessins.id);
                        Principal principal = new Principal();
                        principal.Show();
                        this.Close();
                    }
                    else if (GestioSessins.role == "ROLE_ADMIN")
                    {
                        Console.WriteLine("role: " + GestioSessins.role);
                        Servei se = new Servei();
                        se.Show();
                        this.Close();
                    }
                }                
            }
            else
            {
                using (Message messatge = new Message("No s'ha pogut iniciar sessió correctament, ententa'ho de nou més tard.", "error"))
                {
                    messatge.ShowDialog();
                    return;
                }
            }
        }

        private void pregunta_b_Click(object sender, EventArgs e)
        {
            using (RecuperarContrasenya formRContrasenya = new RecuperarContrasenya())
            {
                this.Hide();
                formRContrasenya.ShowDialog();
               
            }
            this.Show();
        }

        private void registrer_b_Click(object sender, EventArgs e)
        {
            using (Alta formAlta = new Alta())
            {
                this.Hide();
                formAlta.ShowDialog();
            }
            this.Show();
        }

        private void Sessio_Load(object sender, EventArgs e)
        {

        }
    }
}
