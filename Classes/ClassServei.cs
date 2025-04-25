using System.Text.Json.Serialization;
using static SmartPack.dbAPI;

namespace SmartPack.Classes
{
    /// <summary>
    /// Classe que representa un servei
    /// </summary>
    public class ClassServeiOLD
    {
        [JsonConverter(typeof(IntToStringConverter))]
        public string idServei { get; set; }
        public string detalls { get; set; }
        public float pes { get; set; }
        public string mida { get; set; }
        public string amplada { get; set; }
        public string alçada { get; set; }
        public string profunditat { get; set; }
        public string nomDestinatari { get; set; }
        public string adreçaDestinatari { get; set; }
        public string telefonDestinatari { get; set; }
        public string codiQR { get; set; }
        public string tipusVia { get; set; }
        public string nomVia { get; set; }
        public string numero { get; set; }
        public string planta { get; set; }
        public string porta { get; set; }
        public string codiPostal { get; set; }
        public string poblacio { get; set; }
        public string provincia { get; set; }
        public string estat { get; set; }
        public string usuariId { get; set; }
        public string transportistaId { get; set; }

    }

    /// <summary>
    /// Classe que representa un paquet
    /// </summary>
    public class Paquet
    {
        public int id { get; set; }
        public string detalls { get; set; }
        public float pes { get; set; }
        public string mida { get; set; }
        public string nomDestinatari { get; set; }
        public string adreçadestinatari { get; set; }
        public string telefondestinatari { get; set; }
        public string codiqr { get; set; }
    }

    /// <summary>
    /// Classe que representa un servei
    /// </summary>
    public class ClassServei
    {
        public int id { get; set; }
        public string estat { get; set; }
        public int usuariId { get; set; }
        public int transportistaId { get; set; }
        public Paquet paquet { get; set; }
    }
}
