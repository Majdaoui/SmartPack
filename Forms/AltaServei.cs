using SmartPack.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace SmartPack.Forms
{
    public partial class AltaServei : TitleForm
    {
        /// <summary>
        /// Constructor de la classe Crear un servei
        /// </summary>
        public AltaServei()
        {
            InitializeComponent();
        }

        private bool justClosed = false;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (!justClosed)
            {
                var servei = new Servei();
                servei.Show();
            }
        }

        /// <summary>
        /// Mètode que s'executa quan es fa clic al botó de registre servei
        /// Verifica que tots els camps obligatoris estiguin omplerts
        /// </summary>
        private async void bRegistre_Click(object sender, EventArgs e)
        {
            string detallas = t_detalls.Text;
            string pes = t_pes.Text;
            string altura = t_altura.Text;
            string amplada = t_amplada.Text;
            string profunditat = t_profunditat.Text;
            string nomdestinatari = t_nomDestinatari.Text;
            string telefonDestinatari = t_telefonDestinatari.Text;
            string tipusVia = t_tVia.Text;
            string nomVia = t_nomVia.Text;
            string numero = t_num.Text;
            string codiPostal = t_codipostal.Text;
            string poblacio = t_poblacio.Text;
            string provincia = t_provincia.Text;
            string planta = t_planta.Text;
            string porta = t_porta.Text;


            if (!TotsElsCampsOmplerts(detallas, pes, altura, amplada, profunditat, nomdestinatari, tipusVia, telefonDestinatari, codiPostal, poblacio, provincia, nomVia, numero))
            {
                using (Message message1 = new Message("Si us plau, ompliu tots els camps.", "error"))
                {
                    message1.ShowDialog();
                    return;
                }
            }

            // Validació de números decimals (coma o punt)
            if (!EsDecimalValid(pes) ||
                !EsDecimalValid(altura) ||
                !EsDecimalValid(amplada) ||
                !EsDecimalValid(profunditat))
            {
                using (Message msg = new Message("Els valors de pes, altura, amplada i profunditat han de ser numèrics (poden tenir coma o punt decimal).", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }

            // Validació de codi postal
            if (!EsCodiPostalValid(codiPostal)){
                using (Message msg = new Message("El codi postal no és vàlid. Ha de tenir 5 dígits.", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }

            // Validació de telèfon
            if (!EsTelefonValid(telefonDestinatari))
            {
                using (Message msg = new Message("El telèfon no és vàlid. Ha de tenir entre 9 i 15 dígits.", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }

            // Validació de nom i cognom
            if (!EsNomOCognomValid(nomdestinatari))
            {
                using (Message msg = new Message("El nom del destinatari no és vàlid. Només es permeten lletres i espais.", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }
            if (!EsNomOCognomValid(tipusVia))
            {
                using (Message msg = new Message("El tipus de via no és vàlid. Només es permeten lletres i espais.", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }

            if (!EsNomOCognomValid(nomVia))
            {
                using (Message msg = new Message("El nom de la via no és vàlid. Només es permeten lletres i espais.", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }

            // Validació de població
            if (!EsNomOCognomValid(poblacio))
            {
                using (Message msg = new Message("La població no és vàlida. Només es permeten lletres i espais.", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }

            // Validació de provincia
            if (!EsNomOCognomValid(provincia))
            {
                using (Message msg = new Message("La provincia no és vàlida. Només es permeten lletres i espais.", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }


            // Convertir valors a float (amb punt com separador decimal)
            float pesFloat = float.Parse(pes.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
            string mida = string.Join(", ",
                float.Parse(altura.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture),
                float.Parse(amplada.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture),
                float.Parse(profunditat.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture)
            );
            /*

            string _transportistaId = "0";
            string response = await dbAPI.GetTransportistaPerUsuari(GestioSessins.id, GestioSessins.token);
            
            if(string.IsNullOrEmpty(response) || response == "0")
            {
                using (Message message = new Message("No s'ha pogut obtenir el transportista.", "error"))
                {
                    message.ShowDialog();
                    return;
                }
            }

            if (!string.IsNullOrEmpty(response))
            {
                using (JsonDocument doc = JsonDocument.Parse(response))
                {
                    JsonElement root = doc.RootElement;
                    _transportistaId = root.GetProperty("id").GetInt32().ToString();
                }
            }*/

            // Crear l'objecte servei
            object servei = new
            {
                estat = "ORDENAT",
                usuariId = GestioSessins.id,
                transportistaId = 0,
                paquet = new
                {
                    detalls = detallas,
                    pes = float.Parse(pes),
                    mida = altura + ", " + amplada + ", " + profunditat,
                    nomDestinatari = nomdestinatari,
                    adreçadestinatari = tipusVia + ", " + nomVia + ", " + numero + ", " + planta + ", " + porta + ", " + codiPostal + ", " + poblacio + ", " + provincia,
                    telefondestinatari = telefonDestinatari,
                    codiqr = "",
                }
            };

            // Cridar a l'API per crear el servei
            // Aquí hauries d'afegir el codi per cridar a l'API i passar-li l'objecte servei
            string id = await dbAPI.crearServei(servei, GestioSessins.token);
            if (id != "0")
            {
                using (Message message2 = new Message("Servei registrat correctament.", "info"))
                {
                    message2.ShowDialog();
                }
                justClosed = true;
                Servei servei_ = new Servei();
                servei_.Show();
                this.Close();

            }
            else
            {
                using (Message message3 = new Message("Error al registrar el servei.", "error"))
                {
                    message3.ShowDialog();
                    return;
                }
            }
        }


        /// <summary>
        /// Funció per validar si un text és un número decimal vàlid
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool EsDecimalValid(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;

            // Accepta tant coma com punt com a separador decimal
            return double.TryParse(text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out _);
        }

        /// <summary>
        /// Funció per validar si un text és un codi postal vàlid
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool EsCodiPostalValid(string text)
        {
            return Regex.IsMatch(text, @"^\d{5}$");
        }


        /// <summary>
        /// Funció per validar si un text és un telèfon vàlid
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool EsTelefonValid(string text)
        {
            return Regex.IsMatch(text, @"^\d{9,15}$");
        }


        /// <summary>
        /// Funció per validar si un text és un nom o cognom vàlid
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool EsNomOCognomValid(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Zà-ÿÀ-ßñÑ\s]+$");
        }


        /// <summary>
        /// Funció per validar si un camp obligatori està omplert
        /// </summary>
        /// <param name="camps"></param>
        /// <returns></returns>
        public static bool TotsElsCampsOmplerts(params string[] camps)
        {
            foreach (var camp in camps)
            {
                if (string.IsNullOrWhiteSpace(camp))
                    return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t_detalls.Text = "Roba";
            t_pes.Text = "120";
            t_altura.Text = "25";
            t_amplada.Text = "25";
            t_profunditat.Text = "25";
            t_nomDestinatari.Text = "Loubna Majdaoui";
            t_telefonDestinatari.Text = "603207702";
            t_tVia.Text = "Carrer";
            t_nomVia.Text = "Dom Bosco";
            t_num.Text = "146";
            t_codipostal.Text = "08224";
            t_poblacio.Text = "Terrassa";
            t_provincia.Text = "Barcelona";
            t_planta.Text = "0";
            t_porta.Text = "0";
        }
    }
}
