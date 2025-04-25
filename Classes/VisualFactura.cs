using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPack.Classes
{
    /// <summary>
    /// Classe que representa una factura visualitzada
    /// </summary>
    public class VisualFactura
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Preu { get; set; }
        public string IVA { get; set; }
        public string Data { get; set; }
        public int Servei { get; set; }
        public int Usuari { get; set; }
        public bool Pagat { get; set; }
        public string Metode { get; set; }
        public string Codi { get; set; }
        public string Descripcio { get; set; }
        public string DadesClient { get; set; }
        public string TotalSenseIVA { get; set; }
        public string TotalAmbIVA { get; set; }


    }
}
