﻿using SmartPack.Classes;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
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

        private void test(ClassUsuari usuari)
        {
            nom_usuari.Text = usuari.nom;
            usuari.separarCognom();
            cognom_p_usuari.Text = usuari.pcognom;
            cognom_s_usuari.Text = usuari.scognom;
            dni_usuari.Text = usuari.dni;
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
            Rol_Usuari.Text = usuari.rol;
        }

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
            if (!string.IsNullOrEmpty(id) && id != "0")
            {
                string message = await dbAPI.DesactivateUsuari(id, GestioSessins.token);
                if (message == "correctament")
                {
                    Console.WriteLine("correctament: " + message);
                    using (Message messatge = new Message("El seu compte s'ha desactivat correctament", "info"))
                    {
                        messatge.ShowDialog();
                    }
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

        private void Bcanvi_contrasenya_Click_1(object sender, EventArgs e)
        {
            CanviContrasenya canviContrasenya = new CanviContrasenya();
            canviContrasenya.Show();
            this.Hide();
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
    }
}
