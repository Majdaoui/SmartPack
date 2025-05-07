using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPack.Classes
{
    /// <summary>
    /// Classe que representa una factura visualitzada
    /// </summary>
    public class VisualFactura
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Preu { get; set; }             
        public string IVA { get; set; }            
        public string Total { get; set; }            
        public string Data { get; set; }              
        public int ServeiId { get; set; }
        public int UsuariId { get; set; }
        public string UsuariDNI { get; set; }
        public string NomComplet { get; set; }
        public string Adreça { get; set; }
        public string EstatPagament { get; set; }    
        public string MetodePagament { get; set; }


    }
}
