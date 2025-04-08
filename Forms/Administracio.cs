﻿using SmartPack.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Text.Json.JsonElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SmartPack.Forms
{
    public partial class Administracio : TitleForm
    {
        public Administracio()
        {
            InitializeComponent();
        }

        private void usuari_a_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private string responseEmpresas { get; set; } = "";

        private async void list_e_Click(object sender, EventArgs e)
        {
            listEmpreses.Items.Clear();
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


        private string responseUsauris { get; set; } = "";

        private async void llist_u_Click(object sender, EventArgs e)
        {
            listUsauris.Items.Clear();
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
                            listUsauris.Items.Add(id + ":" + "Nom: " + nom + ", "+ " Email: " + email);
                        }
                    }
                }
            }
        }

        private void listEmpreses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lTipusdeCompte.Text = "Empresa";
            if(listEmpreses.SelectedItem != null)
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
                                NOM_T.Text = item.GetProperty("nom").ToString();
                                COGNOMS_T.Text = "";
                                EMAIL_T.Text = item.GetProperty("email").ToString();
                                TELEFON_T.Text = item.GetProperty("telefon").ToString();
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void listUsauris_SelectedIndexChanged(object sender, EventArgs e)
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
                                NOM_T.Text = item.GetProperty("nom").ToString();
                                COGNOMS_T.Text = item.GetProperty("cognom").ToString();
                                EMAIL_T.Text = item.GetProperty("email").ToString();
                                TELEFON_T.Text = item.GetProperty("telefon").ToString();
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
