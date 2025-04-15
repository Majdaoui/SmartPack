using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPack.Classes
{
    internal class ClassServei
    {
        public ClassServei() { }
        public static string idServei { get; set; }
        public static string detalls { get; set; }
        public static float pes { get; set; }
        public static string mida { get; set; }
        public static string amplada { get; set; }
        public static string alçada { get; set; }
        public static string profunditat { get; set; }
        public static string nomDestinatari { get; set; }
        public static string adreçaDestinatari { get; set; }
        public static string telefonDestinatari { get; set; }
        public static string codiQR { get; set; }
        public static string tipusVia { get; set; }
        public static string nomVia { get; set; }
        public static string numero { get; set; }
        public static string planta { get; set; }
        public static string porta { get; set; }
        public static string codiPostal { get; set; }
        public static string poblacio { get; set; }
        public static string provincia { get; set; }
        public static string estat { get; set; }
        public static string usuariId { get; set; }
        public static string transportistaId { get; set; }

    }

    /*
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
     
     
     */
}
