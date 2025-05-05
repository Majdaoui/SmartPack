using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPack.Classes
{
    public class VisualServei
    {
        public int ID { get; set; }
        public string Estat { get; set; }
        public string Detalls { get; set; }
        public float Pes { get; set; }
        public string Mida { get; set; }
        public string Destinatari { get; set; }
        public string Adreça { get; set; }
        public string Telefon { get; set; }
        public int? TransportistaID { get; set; }
        public int UsuariID { get; set; }
    }

}
