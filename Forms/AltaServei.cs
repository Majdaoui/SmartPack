using SmartPack.Classes;
using System;

namespace SmartPack.Forms
{
    public partial class AltaServei : TitleForm
    {
        public AltaServei()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        private async void bRegistre_Click(object sender, EventArgs e)
        {
            string detallas = t_detalls.Text;
            string pes = t_pes.Text;
            string altura = t_altura.Text;
            string amplada = t_amplada.Text;
            string profunditat = t_profunditat.Text;
            string nomdestinatari = t_nomDestinatari.Text;
            string telefonDestinatari = t_telefonDestinatari.Text;
            string codiqr = t_codiQR.Text;
            string tipusVia = t_tVia.Text;
            string nomVia = t_nomVia.Text;
            string numero = t_num.Text;
            string codiPostal = t_codipostal.Text;
            string poblacio = t_poblacio.Text;
            string provincia = t_provincia.Text;
            string planta = t_planta.Text;
            string porta = t_porta.Text;

            // Validar que no hi hagi camps buits

            if (string.IsNullOrEmpty(detallas) || string.IsNullOrEmpty(pes) || string.IsNullOrEmpty(altura) ||
                string.IsNullOrEmpty(amplada) || string.IsNullOrEmpty(profunditat) || string.IsNullOrEmpty(nomdestinatari) ||
                string.IsNullOrEmpty(tipusVia) || string.IsNullOrEmpty(telefonDestinatari) || string.IsNullOrEmpty(codiPostal) 
                || string.IsNullOrWhiteSpace(poblacio) || string.IsNullOrWhiteSpace(provincia) || string.IsNullOrWhiteSpace(nomVia)
                 || string.IsNullOrWhiteSpace(numero))
            {
                using (Message message1 = new Message("Si us plau, ompliu tots els camps.", "error"))
                {
                    message1.ShowDialog();
                    return;
                }
            }
            else
            {
                // Crear l'objecte servei
                object servei = new
                {
                    estat = "ORDENAT",
                    usuariId = int.Parse(GestioSessins.id),
                    transportistaId = 2,
                    paquet = new
                    {
                        detalls = detallas,
                        pes = float.Parse(pes),
                        mida = altura + ", " + amplada + ", " + profunditat,
                        nomDestinatari = nomdestinatari,
                        adreçadestinatari = tipusVia + ", " + nomVia + ", " + numero + ", " + planta + ", " + porta + ", " + codiPostal + ", " + poblacio + ", " + provincia,
                        telefondestinatari = telefonDestinatari,
                        codiQR = codiqr
                    }
                };

                // Cridar a l'API per crear el servei
                // Aquí hauries d'afegir el codi per cridar a l'API i passar-li l'objecte servei
                string resultat = await dbAPI.crearServei(servei, GestioSessins.token);
                if (resultat != "0")
                {
                    using (Message message2 = new Message("Servei registrat correctament.", "info"))
                    {
                        message2.ShowDialog();
                        return;
                    }
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
        }
      
    }
}
