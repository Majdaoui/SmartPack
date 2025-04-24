using System;

namespace SmartPack.Classes
{
    public class Factura
    {
        public int id { get; set; }
        public string numFactura { get; set; }
        public decimal preu { get; set; }
        public double iva { get; set; }
        public DateTime data { get; set; }
        public int serveiId { get; set; }
        public int usuariId { get; set; }
        public bool pagat { get; set; }
        public string metodePagament { get; set; }
        public Factura() { }
      
    }
}
/*
 "id": 0,
 "numFactura": "string",
 "preu": 0,
 "iva": 0,
 "data": "2025-04-23T10:02:25.795Z",
 "serveiId": 0,
 "usuariId": 0,
 "pagat": true,
 "metodePagament": "string"
*/