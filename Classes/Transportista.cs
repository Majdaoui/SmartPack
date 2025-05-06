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
        public static string id { get; set; }
        public static string usuariId { get; set; }
        public static string usuariEmail { get; set; }
        public static string llicencia { get; set; }
        public vehicle vehicle { get; set; }
    }

    public class vehicle
    {
        public static string id { get; set; }
        public static string marca { get; set; }
        public static string model { get; set; }
        public static string matricula { get; set; }
        public static string color { get; set; }
        public static string tipus { get; set; }
    }
}
