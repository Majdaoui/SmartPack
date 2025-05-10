using SmartPack.Classes;
using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartPack.Forms
{
    /// <summary>
    /// Formulari de facturacio
    /// </summary>
    public partial class Facturacio : TitleForm
    {
        /// <summary>
        /// Constructor del formulari de facturacio
        /// </summary>
        public Factura _factura { get; set; }
        /// <summary>
        /// Impressora per imprimir la factura
        /// </summary>
        private System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();

        //public Facturacio() : this(null) { }

        public Facturacio(/*Factura factura*/)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Comprova si el formulari es troba en mode disseny
        /// </summary>
        /// <returns></returns>
        private bool EsModeDisseny()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;
        }

        /// <summary>
        /// Carrega la informació de la factura al formulari si el formulari no es troba en mode disseny
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (EsModeDisseny())
                return;

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
                    using (Message message1 = new Message("Error carregant la factura: " + ex.Message, "error"))
                    {
                        message1.ShowDialog();
                    }
                }
            }
        }

        /// <summary>
        /// Imprimeix la factura actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bImprimirF_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}