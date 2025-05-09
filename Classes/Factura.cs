using System;

namespace SmartPack.Classes
{
    /// <summary>
    /// Representa una factura con información detallada sobre el servicio, usuario y estado de pago.
    /// </summary>
    public class Factura
    {
        /// <summary>
        /// Identificador único de la factura.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Número de la factura.
        /// </summary>
        public string numFactura { get; set; }

        /// <summary>
        /// Precio base del servicio.
        /// </summary>
        public double preu { get; set; }

        /// <summary>
        /// Porcentaje de IVA aplicado al precio base.
        /// </summary>
        public double iva { get; set; }

        /// <summary>
        /// Total a pagar incluyendo IVA.
        /// </summary>
        public double total { get; set; }

        /// <summary>
        /// Fecha de emisión de la factura.
        /// </summary>
        public DateTime data { get; set; }

        /// <summary>
        /// Identificador del servicio asociado a la factura.
        /// </summary>
        public int serveiId { get; set; }

        /// <summary>
        /// Identificador del usuario asociado a la factura.
        /// </summary>
        public int usuariId { get; set; }

        /// <summary>
        /// DNI del usuario asociado a la factura.
        /// </summary>
        public string usuariDni { get; set; }

        /// <summary>
        /// Nombre completo del usuario asociado a la factura.
        /// </summary>
        public string usuariNomComplet { get; set; }

        /// <summary>
        /// Dirección del usuario asociado a la factura.
        /// </summary>
        public string usuariAdreça { get; set; }

        /// <summary>
        /// Indica si la factura ha sido pagada.
        /// </summary>
        public bool pagat { get; set; }

        /// <summary>
        /// Método de pago utilizado para la factura.
        /// </summary>
        public string metodePagament { get; set; }
    }
}