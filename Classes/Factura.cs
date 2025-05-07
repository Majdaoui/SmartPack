using System;

namespace SmartPack.Classes
{
    public class Factura
    {
        public int id { get; set; }
        public string numFactura { get; set; }
        public double preu { get; set; }
        public double iva { get; set; }
        public double total { get; set; }
        public DateTime data { get; set; }
        public int serveiId { get; set; }
        public int usuariId { get; set; }
        public string usuariDni { get; set; }
        public string usuariNomComplet { get; set; }
        public string usuariAdreça { get; set; }
        public bool pagat { get; set; }
        public string metodePagament { get; set; }

    }
}