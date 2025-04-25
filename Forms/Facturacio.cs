using SmartPack.Classes;
using System;

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
        public Facturacio()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {/*
                tCodi.Text = _factura.Codi;
                tTotal_u.Text = _factura.TotalSenseIVA;
                tPreu.Text = _factura.Preu;
                tdata.Text = _factura.Data;
                tNumero.Text = _factura.Numero;
                tIVA.Text = _factura.IVA;
                tDescripcio.Text = _factura.Descripcio;
                tTotal_IVA.Text = _factura.TotalAmbIVA;
                Dades_Client.Text = _factura.DadesClient;*/
            }
        }
    }
}