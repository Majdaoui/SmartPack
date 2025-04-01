using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPack.Classes
{
    public class ClassUsuari
    {
        public static string id { get; set; }
        public static string email { get; set; }
        public static string nom { get; set; }
        public static string cognom { get; set; }
        public static string telefon { get; set; }
        public static string adreça { get; set; }
        public static string observacions { get; set; }
        public static string empresaId { get; set; }


        public static string dni { get; set; }
        public static string password { get; set; } /*contrasenya */
       
        public static string rol { get; set; }
        
        public static string secret { get; set; }
        public static string token { get; set; }
       

        public static string pcognom { get; set; }
        public static string scognom { get; set; }

        public static string tvia { get; set; }
        public static string nom_via { get; set; }
        public static string num { get; set; }
        public static string porta { get; set; }
        public static string planta { get; set; }
        public static string poblacio { get; set; }
        public static string provincia { get; set; }
        public static string cp { get; set; }

        public bool esEmpresa { get; set; }
        public string si { get; set; }
        public string no { get; set; }

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
