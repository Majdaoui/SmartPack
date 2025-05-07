using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPack.Classes
{
    /// <summary>
    /// Classe Transportista
    /// </summary>
    public class Transportista
    {
        public int id { get; set; }
        public int usuariId { get; set; }
        public string usuariEmail { get; set; }
        public string llicencia { get; set; }
        public vehicle vehicle { get; set; }
    }

    public class vehicle
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string model { get; set; }
        public string matricula { get; set; }
        public string color { get; set; }
        public string tipus { get; set; }
    }
}
