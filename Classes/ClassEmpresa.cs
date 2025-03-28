using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPack.Classes
{
    class ClassEmpresa
    {
        public string cif { get; set; }
        public string nom_empresa { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public string tvia { get; set; }
        public string carrer { get; set; }
        public string cp { get; set; }
        public string poblacio { get; set; }
        public string provincia { get; set; }
        public string comentaris { get; set; }

        public string adreça { get; set; }

        public void SepararDireccio()
        {
            if (!string.IsNullOrEmpty(adreça))
            {
                var partes = adreça.Split(',');
                if (partes.Length >= 3)
                {
                    tvia = partes[0].Trim();
                    carrer = partes[1].Trim();
                    cp = partes[2].Trim();
                    poblacio = partes.Length > 3 ? partes[3].Trim() : "";
                    provincia = partes.Length > 4 ? partes[4].Trim() : "";
                }
            }
        }


    }
}
