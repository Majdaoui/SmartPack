using Org.BouncyCastle.Bcpg.Sig;
using SmartPack.Classes;
using System;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        private bool FullClosed = true;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (FullClosed)
            {
                GestioSessins.Logout();
                var session = new Sessio();
                session.Show();
            }
        }

        /// <summary>
        /// Conté la resposta de l'API amb les empreses disponibles.
        /// </summary>
        public string responseEmpresas { get; set; } = "";

        /// <summary>
        /// Fa la petició a l'API i llista totes les empreses disponibles.
        /// </summary>
        public async void list_e_Click(object sender, EventArgs e)
        {
            listEmpreses.Items.Clear();
            update_e.Visible = false;
            desctivate_e.Visible = false;
            bModificarUsuari.Visible = false;
            desassignar_u.Visible = false;
            assignar_u.Visible = false;
            bDesactivarUser.Visible = false;
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
            bModificarUsuari.Visible = true;
            desassignar_u.Visible = true;
            assignar_u.Visible = true;
            bDesactivarUser.Visible = true;
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
                                lIDEmpresa.Text = id;
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
                                lIDUser.Text = id;
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
            var response = await dbAPI.PutEmpresaUpdate(empresa_update, lIDUser.Text, GestioSessins.token);
            Console.WriteLine("Response Body: " + response);
            if (response.Contains("\"id\":"))
            {
                using (Message message1 = new Message("Empresa actualitzada correctament.", "info"))
                {
                    message1.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Desactiva l'empresa seleccionada.
        /// </summary>
        public async void desctivate_e_Click(object sender, EventArgs e)
        {
            var response = await dbAPI.DeactivateEmpresa(lIDUser.Text, GestioSessins.token);
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

        /// <summary>
        /// Obre el formulari d'alta d'empresa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAltaEmpresa_Click(object sender, EventArgs e)
        {
            AltaEmpresa altaEmpresa = new AltaEmpresa();
            altaEmpresa.Option = 1;
            altaEmpresa.Show();
            this.Close();
        }

        /// <summary>
        /// Actualitza les dades de l'usuari seleccionat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bModificarUsuari_Click(object sender, EventArgs e)
        {
            object userUpdate = new
            {
                email = EMAIL_T.Text,
                telefon = TELEFON_T.Text,
            };
            string response = await dbAPI.PutUserUpdate(userUpdate, lIDUser.Text, GestioSessins.token);
            if (response != null)
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

        /// <summary>
        /// Desassigna l'usuari seleccionat de l'empresa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void desassignar_u_Click(object sender, EventArgs e)
        {
            var msg = await dbAPI.EmpresaDesassignarUsuari(lIDUser.Text, GestioSessins.token);
            if(msg == "correctament")
            {
                using (Message message1 = new Message("Usuari desassignat correctament.", "info"))
                {
                    message1.ShowDialog();
                }
            }
            else
            {
                using (Message message1 = new Message("Aquest usuari no está assignat a cap empresa.", "error"))
                {
                    message1.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Assigna l'usuari seleccionat a l'empresa seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void assignar_u_Click(object sender, EventArgs e)
        {
            object assignar = new
            {
                usuariId = lIDUser.Text,
                empresaId = lIDEmpresa.Text,
            };
            string message = await dbAPI.assignarUsuari(assignar, GestioSessins.token);
            if (message.Contains("correctament"))
            {
                Console.WriteLine("Empresa Message: " + message);
                using (Message messatgel = new Message("empresa registrada correctament", "info"))
                {
                    messatgel.ShowDialog();
                }
            }
            else
            {

            } 

        }

        /// <summary>
        /// Desactiva l'usuari seleccionat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bDesactivarUser_Click(object sender, EventArgs e)
        {
            string message = await dbAPI.DesactivateUsuari(lIDUser.Text, GestioSessins.token);
            if (message == "correctament")
            {
                Console.WriteLine("correctament: " + message);
                using (Message messatge = new Message("El seu compte s'ha desactivat correctament", "info"))
                {
                    messatge.ShowDialog();
                }
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

        /// <summary>
        /// Obre el formulari de serveis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bServeis_Click(object sender, EventArgs e)
        {
            Servei servei = new Servei();
            servei.Open = new Administracio();
            servei.Show();
            FullClosed = false;
            this.Close();
        }

        /// <summary>
        /// Obre el formulari de vehicles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bVehicles_Click(object sender, EventArgs e)
        {
            Vehicles vehicle = new Vehicles();
            vehicle.Show();
            vehicle.Open = new Administracio();
            FullClosed = false;
            this.Close();

        }

        /// <summary>
        /// Obre el formulari de factures.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bFactures_Click(object sender, EventArgs e)
        {
            Factures factures = new Factures();
            factures.Open = new Administracio();
            FullClosed = false;
            factures.Show();
            this.Close();
        }

        /// <summary>
        /// Obre el formulari de transportistes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bTransportistes_Click(object sender, EventArgs e)
        {
            Transportistes transportistes = new Transportistes();
            transportistes.Open = new Administracio();
            transportistes.Show();
            FullClosed = false;
            this.Close();
        }

        /// <summary>
        /// Obre el formulari d'assignar servei a transportistes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAssiST_Click(object sender, EventArgs e)
        {
            ServeisTransportistes serveisTransportistes = new ServeisTransportistes();
            serveisTransportistes.Open = new Administracio();
            serveisTransportistes.Show();
            FullClosed = false;
            this.Close();
        }
    }
}
