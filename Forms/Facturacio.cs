using SmartPack.Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartPack.Forms
{
    /// <summary>
    /// Formulari de facturacio
    /// </summary>
    public partial class Facturacio : TitleForm
    {
        
        //VisualFactura _factura = new VisualFactura();
        /// <summary>
        /// Constructor del formulari de facturacio
        /// </summary>
        protected Factura _factura;

        public Facturacio()
        {
            InitializeComponent();
        }

        public Facturacio(Factura factura) : this()
        {
            _factura = factura;
        }

        /// <summary>
        /// Carrega les dades de la factura i les mostra en el formulari
        /// </summary>
        /// <param name="e"></param>
        protected void OnLoadx(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode && _factura != null)
            {
                tCodi.Text = _factura.numFactura;
                tTotal_u.Text = _factura.preu.ToString("F2");
                tPreu.Text = _factura.preu.ToString("F2");
                tdata.Text = _factura.data.ToShortDateString();
                tNumero.Text = _factura.id.ToString();
                tIVA.Text = _factura.iva.ToString("F2");
                tTotal_IVA.Text = _factura.total.ToString("F2");
                tDescripcio.Text = $"Servei #{_factura.serveiId}";
                Dades_Client.Text = $"{_factura.usuariNomComplet}\n{_factura.usuariDni}\n{_factura.usuariAdreça}";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }
                
            if (_factura != null)
            {
                try
                {
                    tCodi.Text = _factura.numFactura;
                    tTotal_u.Text = _factura.preu.ToString("F2");
                    tPreu.Text = _factura.preu.ToString("F2");
                    tdata.Text = _factura.data.ToShortDateString();
                    tNumero.Text = _factura.id.ToString();
                    tIVA.Text = _factura.iva.ToString("F2");
                    tTotal_IVA.Text = _factura.total.ToString("F2");
                    tDescripcio.Text = $"Servei #{_factura.serveiId}";
                    Dades_Client.Text = $"{_factura.usuariNomComplet}\n{_factura.usuariDni}\n{_factura.usuariAdreça}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error carregant la factura: " + ex.Message);
                }
            }
        }
    }
}