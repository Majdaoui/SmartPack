using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPack.Classes
{
    public class ClassUsuari
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string pcognom { get; set; }
        public string scognom { get; set; }
        public string dni { get; set; }
        public string telefon { get; set; }
        public string tvia { get; set; }
        public string nom_via { get; set; }
        public string num { get; set; }
        public string porta { get; set; }
        public string planta { get; set; }
        public string poblacio { get; set; }
        public string provincia { get; set; }
        public string cp { get; set; }
        public string email { get; set; }
        public string password { get; set; } /*contrasenya */
        public string comentaris { get; set; }
        public string rol { get; set; }
        public bool esEmpresa { get; set; }
        public string si { get; set; }
        public string no { get; set; }
    }
}
