using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPack.Classes
{
    public class HistorialServei
    {
        public int id { get; set; }
        public int serveId { get; set; }
        public int tranpostistaId { get; set; }
        public string estat { get; set; }
        public string descripcioCanvi { get; set; }
        public string adreçaDestinatari { get; set; }
        public string tipusCanvi { get; set; }
        public DateTime dataCanvi { get; set; }
    }

}


/*
  "id": 0,
    "serveId": 0,
    "tranpostistaId": 0,
    "estat": "string",
    "descripcioCanvi": "string",
    "adreçaDestinatari": "string",
    "tipusCanvi": "string",
    "dataCanvi": "2025-04-22T11:42:47.100Z"
 
 
 */