using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPack.Classes
{

    /// <summary>
    /// Classe GestioSessins
    /// </summary>
    public class GestioSessins
    {
        public static string empresaId { get; set; } = "0";
        public static string usuariId { get; set; } = "0";
        public static string id { get; set; } = "0";
        public static string user { get; set; } = "0";
        public static string email { get; set; } = "";
        public static string password { get; set; } = "";
        public static string token { get; set; } = "";
        public static string role { get; set; } = "";
        public static bool desactivat { get; set; } = false;
        public static string transportistaId { get; set; } = "";
        public static void Logout()
        {
            GestioSessins.user = null;
            GestioSessins.password = null;
            GestioSessins.token = null;
        }
    }
}