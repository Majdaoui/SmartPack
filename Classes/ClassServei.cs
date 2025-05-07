using System.Text.Json.Serialization;
using static SmartPack.dbAPI;

namespace SmartPack.Classes
{
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
        public int? transportistaId { get; set; }
        public Paquet paquet { get; set; }
    }
}
