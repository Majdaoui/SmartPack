using SmartPack.Classes;
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


        

        private async void list_e_Click(object sender, EventArgs e)
        {
            listEmpreses.Items.Clear();
            object user = new
            {
                email = "nemo.it@live.com",
                password = "@Nemo1234",
            };
            var state = await dbAPI.Login(user);
            if (state)
            {
                var response = await dbAPI.getAllEmpresas(GestioSessins.token);
                Console.WriteLine("Response Body: " + response);

                using (JsonDocument doc = JsonDocument.Parse(response))
                {
                    if (doc.RootElement.GetArrayLength() > 0)
                    {
                        var array = doc.RootElement.EnumerateArray();
                        foreach (JsonElement item in array)
                        {
                            var nom = item.GetProperty("nom").ToString();
                            var nif = item.GetProperty("nif").ToString();

                            Console.WriteLine("nom: " + nom);
                            listEmpreses.Items.Add(nom + ", " + nif);

                        }

                        

                    }
                    
                    
                }


            }
        }
    }
}
