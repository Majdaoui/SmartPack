using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPack.Classes
{
    public class VisualFactura
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public decimal Preu { get; set; }
        public double IVA { get; set; }
        public DateTime Data { get; set; }
        public int Servei { get; set; }
        public int Usuari { get; set; }
        public bool Pagat { get; set; }
        public string Metode { get; set; }
       
    }
}
