﻿using SmartPack.Classes;
using System;
using System.Text.Json;

namespace SmartPack.Forms
{
    /// <summary>
    /// Formulari per a la gestió d'empreses i usuaris des del panell d'administració.
    /// </summary>
    public partial class Administracio : TitleForm
    {
        /// <summary>
        /// Constructor per inicialitzar els components del formulari.
        /// </summary>
        public Administracio()
        {
            InitializeComponent();
        }

        private void usuari_a_Click(object sender, EventArgs e)
        {
            // Acció pendent d'implementació
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Acció pendent d'implementació
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Acció pendent d'implementació
        }

        public string responseEmpresas { get; set; } = "";

        /// <summary>
        /// Fa la petició a l'API i llista totes les empreses disponibles.
        /// </summary>
        public async void list_e_Click(object sender, EventArgs e)
        {
            listEmpreses.Items.Clear();
            update_e.Visible = false;
            desctivate_e.Visible = false;
            object user = new
            {
                email = GestioSessins.email,
                password = GestioSessins.password,
            };
            var state = await dbAPI.Login(user);
            if (state)
            {
                responseEmpresas = await dbAPI.getAllEmpresas(GestioSessins.token);
                Console.WriteLine("Response Body: " + responseEmpresas);
                using (JsonDocument doc = JsonDocument.Parse(responseEmpresas))
                {
                    if (doc.RootElement.GetArrayLength() > 0)
                    {
                        var array = doc.RootElement.EnumerateArray();
                        foreach (JsonElement item in array)
                        {
                            var id = item.GetProperty("id").ToString();
                            var nom = item.GetProperty("nom").ToString();
                            var nif = item.GetProperty("nif").ToString();
                            Console.WriteLine("nom: " + nom);
                            listEmpreses.Items.Add(id + ":" + "Nom: " + nom + ", " + " Nif: " + nif);
                        }
                    }
                }
            }
        }

        public string responseUsauris { get; set; } = "";

        /// <summary>
        /// Fa la petició a l'API i llista tots els usuaris disponibles.
        /// </summary>
        public async void llist_u_Click(object sender, EventArgs e)
        {
            listUsauris.Items.Clear();
            update_e.Visible = false;
            desctivate_e.Visible = false;
            object user = new
            {
                email = GestioSessins.email,
                password = GestioSessins.password,
            };
            var state = await dbAPI.Login(user);
            if (state)
            {
                responseUsauris = await dbAPI.getAllUsers(GestioSessins.token);
                Console.WriteLine("Response Body: " + responseUsauris);
                using (JsonDocument doc = JsonDocument.Parse(responseUsauris))
                {
                    if (doc.RootElement.GetArrayLength() > 0)
                    {
                        var array = doc.RootElement.EnumerateArray();
                        foreach (JsonElement item in array)
                        {
                            var id = item.GetProperty("id").ToString();
                            var nom = item.GetProperty("nom").ToString();
                            var email = item.GetProperty("email").ToString();
                            Console.WriteLine("email: " + email);
                            listUsauris.Items.Add(id + ":" + "Nom: " + nom + ", " + " Email: " + email);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Omple les dades de l'empresa seleccionada de la llista.
        /// </summary>
        public void listEmpreses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lTipusdeCompte.Text = "Empresa";
            if (listEmpreses.SelectedItem != null)
            {
                string selectedItem = listEmpreses.SelectedItem.ToString();
                string[] parts = selectedItem.Split(new[] { ":" }, StringSplitOptions.None);
                string _id = parts[0];
                Console.WriteLine("ID: " + _id);
                using (JsonDocument doc = JsonDocument.Parse(responseEmpresas))
                {
                    if (doc.RootElement.GetArrayLength() > 0)
                    {
                        var array = doc.RootElement.EnumerateArray();
                        foreach (JsonElement item in array)
                        {
                            var id = item.GetProperty("id") + "";
                            if (_id == id)
                            {
                                listUsauris.SelectedIndex = -1;
                                lID.Text = id;
                                NOM_T.Text = item.GetProperty("nom").ToString();
                                COGNOMS_T.Text = "";
                                EMAIL_T.Text = item.GetProperty("email").ToString();
                                TELEFON_T.Text = item.GetProperty("telefon").ToString();
                                update_e.Visible = true;
                                desctivate_e.Visible = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Omple les dades de l'usuari seleccionat de la llista.
        /// </summary>
        public void listUsauris_SelectedIndexChanged(object sender, EventArgs e)
        {
            lTipusdeCompte.Text = "Usauri";
            if (listUsauris.SelectedItem != null)
            {
                string selectedItem = listUsauris.SelectedItem.ToString();
                string[] parts = selectedItem.Split(new[] { ":" }, StringSplitOptions.None);
                string _id = parts[0];
                Console.WriteLine("ID: " + _id);
                using (JsonDocument doc = JsonDocument.Parse(responseUsauris))
                {
                    if (doc.RootElement.GetArrayLength() > 0)
                    {
                        var array = doc.RootElement.EnumerateArray();
                        foreach (JsonElement item in array)
                        {
                            var id = item.GetProperty("id") + "";
                            if (_id == id)
                            {
                                listEmpreses.SelectedIndex = -1;
                                lID.Text = id;
                                NOM_T.Text = item.GetProperty("nom").ToString();
                                COGNOMS_T.Text = item.GetProperty("cognom").ToString();
                                EMAIL_T.Text = item.GetProperty("email").ToString();
                                TELEFON_T.Text = item.GetProperty("telefon").ToString();
                                update_e.Visible = false;
                                desctivate_e.Visible = false;
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Actualitza les dades de l'empresa seleccionada.
        /// </summary>
        public async void update_e_Click(object sender, EventArgs e)
        {
            object empresa_update = new
            {
                email = EMAIL_T.Text,
                telefon = TELEFON_T.Text,
            };
            var response = await dbAPI.PutEmpresaUpdate(empresa_update, lID.Text, GestioSessins.token);
            Console.WriteLine("Response Body: " + response);
        }

        /// <summary>
        /// Desactiva l'empresa seleccionada.
        /// </summary>
        public async void desctivate_e_Click(object sender, EventArgs e)
        {
            var response = await dbAPI.DeactivateEmpresa(lID.Text, GestioSessins.token);
            if (string.IsNullOrEmpty(response)) return;
            Console.WriteLine("Response Body: " + response);
            if (response.Contains("correctament"))
            {
                using (Message message1 = new Message("Empresa desactivada correctament.", "info"))
                {
                    message1.ShowDialog();
                }
            }
        }
    }
}
