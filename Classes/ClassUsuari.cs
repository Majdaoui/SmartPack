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
        public string adreça { get; set; }
        public string secret { get; set; }
        public string token { get; set; }
        public string cognom { get; set; }

        public void SepararDireccio()
        {
            if (!string.IsNullOrEmpty(adreça))
            {
                var partes = adreça.Split(',');
                if (partes.Length >= 3)
                {
                    tvia = partes[0].Trim();
                    nom_via = partes[1].Trim();
                    num = partes[2].Trim();
                    planta = partes.Length > 3 ? partes[3].Trim() : "";
                    porta = partes.Length > 4 ? partes[4].Trim() : "";
                    cp = partes.Length > 5 ? partes[5].Trim() : "";
                    poblacio = partes.Length > 6 ? partes[6].Trim() : "";
                    provincia = partes.Length > 7 ? partes[7].Trim() : "";
                }
            }
        }

        public void separarCognom()
        {
            if (!string.IsNullOrEmpty(scognom))
            {
                var partes = scognom.Split(',');
                if (partes.Length >= 2)
                {
                    pcognom = partes[0].Trim();
                    scognom = partes[1].Trim();
                }
            }
        }
    }
}
