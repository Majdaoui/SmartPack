using SmartPack.Classes;
using System;

namespace SmartPack.Forms
{
    /// <summary>
    /// Formulari de facturacio
    /// </summary>
    public partial class Facturacio : TitleForm
    {
        private Factura _factura;
        //VisualFactura _factura = new VisualFactura();
        /// <summary>
        /// Constructor del formulari de facturacio
        /// </summary>
        public Facturacio(Factura factura)
        {
            InitializeComponent();
            _factura = factura;
        }

        /// <summary>
        /// Carrega les dades de la factura i les mostra en el formulari
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode && _factura != null)
            {
                tCodi.Text = _factura.numFactura;
                tTotal_u.Text = _factura.preu.ToString("F2"); // Total sense IVA
                tPreu.Text = _factura.preu.ToString("F2");
                tdata.Text = _factura.data.ToShortDateString(); // O format que vulguis
                tNumero.Text = _factura.id.ToString();
                tIVA.Text = _factura.iva.ToString("F2");
                tTotal_IVA.Text = _factura.total.ToString("F2");
                tDescripcio.Text = $"Servei #{_factura.serveiId}";
                Dades_Client.Text = $"{_factura.usuariNomComplet}\n{_factura.usuariDni}\n{_factura.usuariAdreça}";
            }
        }
    }
}