using SmartPack.Classes;
using System;
using System.Diagnostics;

using System.Windows.Forms;

namespace SmartPack.Forms
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class AreaUsuari : TitleForm
    {
        public AreaUsuari()
        {
            InitializeComponent();
        }

        private bool justClosed = false;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (!justClosed)
            {
                var principal = new Principal();
                principal.Show();
            }            
        }

        //Per a mostrar les dades de l'usuari a la finestra
        //Aquest mètode recull les dades de l'usuari i les mostra a la finestra
        //El mètode utilitza la classe ClassUsuari per separar el nom i els cognoms
        //El mètode utilitza la classe dbAPI per obtenir les dades de l'usuari

        private void test(ClassUsuari usuari)
        {
            nom_usuari.Text = usuari.nom;
            usuari.separarCognom();
            cognom_p_usuari.Text = usuari.pcognom;
            cognom_s_usuari.Text = usuari.scognom;
            //dni_usuari.Text = usuari.dni;
            telefon_usuari.Text = usuari.telefon;
            email_usuari.Text = usuari.email;
            usuari.SepararDireccio();
            t_via_usuari.Text = usuari.tvia;
            nom_via_usuari.Text = usuari.nom_via;
            num_usuari.Text = usuari.num;
            planta_usuari.Text = usuari.planta;
            porta_usuari.Text = usuari.porta;
            cp_usuari.Text = usuari.cp;
            poblacio_usuari.Text = usuari.poblacio;
            provincia_usuari.Text = usuari.provincia;
            observacions_usuari.Text = usuari.observacio;
            //Rol_Usuari.Text = usuari.rol;
        }

        //Aquest metoda es crida quan es carrega la finestra
        //Carrega les dades de l'usuari actual i les mostra a la finestra
        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ClassUsuari usuari = await dbAPI.getCurrentUser(GestioSessins.token);
            if (usuari != null)
            {
                test(usuari); 
            }
            else
            {
                MessageBox.Show("No se pudo cargar el usuario.");
            }
        }

        
        private void Bsortir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        //Aquest mètode es crida quan es fa clic al botó "Desactivar usuari"
        //Desactiva l'usuari actual i tanca la finestra
        //Si l'usuari s'ha desactivat correctament, mostra un missatge d'informació
        //Si l'usuari no s'ha desactivat correctament, mostra un missatge d'error
        //El mètode utilitza la classe dbAPI per enviar les dades a la base de dades
        //El mètode utilitza la classe GestioSessins per obtenir l'id i el token de l'usuari
        private async void bDesactivar_Click(object sender, EventArgs e)
        {
            string id = GestioSessins.id;
            if (id != "0")
            {
                string message = await dbAPI.DesactivateUsuari(id, GestioSessins.token);
                if (message == "correctament")
                {
                    Console.WriteLine("correctament: " + message);
                    using (Message messatge = new Message("El seu compte s'ha desactivat correctament", "info"))
                    {
                        messatge.ShowDialog();
                    }
                    justClosed = true;
                    this.Close();
                    Sessio sessio = new Sessio(); 
                    sessio.Show();
                }
                else
                {
                    Console.WriteLine("message: " + message);
                    using (Message messatge = new Message("No s'ha pogut desactivar el Compte", "error"))
                    {
                        messatge.ShowDialog();
                    }
                }
            }
        }

        //Aquest mètode es crida quan es fa clic al botó "Canvi contrasenya"
        //Obre la finestra de canvi de contrasenya
        //Tanca la finestra actual
        private void Bcanvi_contrasenya_Click_1(object sender, EventArgs e)
        {
            CanviContrasenya canviContrasenya = new CanviContrasenya();
            canviContrasenya.Show();
            justClosed = true;
            this.Close();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }


        //Aquest mètode recull les dades dels camps i les envia a la base de dades
        //Si les dades s'han actualitzat correctament, mostra un missatge d'informació
        //Si les dades no s'han actualitzat correctament, mostra un missatge d'error
        //El mètode utilitza la classe dbAPI per enviar les dades a la base de dades
        //El mètode utilitza la classe GestioSessins per obtenir l'id i el token de l'usuari
        private async void bGuardar_Click(object sender, EventArgs e)
        {
            var email = email_usuari.Text;
            var nom = nom_usuari.Text;
            var cognom = cognom_p_usuari.Text + ", " + cognom_s_usuari.Text;
            var telefon = telefon_usuari.Text;
            var adreça = t_via_usuari.Text + ", " + 
                nom_via_usuari.Text + ", " + 
                num_usuari.Text + ", " + 
                planta_usuari.Text + ", " + 
                porta_usuari.Text + ", " + 
                cp_usuari.Text + ", " + 
                poblacio_usuari.Text + ", " + 
                provincia_usuari.Text;
            var observacio = observacions_usuari.Text;
            object userUpdate = new
            {
                email = email,
                nom = nom,
                cognom = cognom,
                telefon = telefon,
                adreça = adreça,
                observacio = observacio,
            };
            string response = await dbAPI.PutUserUpdate(userUpdate, GestioSessins.id, GestioSessins.token);
            if(response != null)
            {
                using (Message messatge = new Message("S'han actualitzat les dades correctament", "info"))
                {
                    Console.WriteLine("Response Body: " + response);
                    messatge.ShowDialog();
                }
            }
            else
            {
                using (Message messatge = new Message("Error al actualitzar les dades", "error"))
                {
                    Console.WriteLine("Response Body: " + response);
                    messatge.ShowDialog();
                }
            }
        }

        //Aquest mètode es crida quan es fa clic al botó "Vehicle"
        //Obre la finestra de vehicle
        //Tanca la finestra actual
        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Show();
            justClosed = true;
            this.Close();
        }
    }
}
