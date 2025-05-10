using MySqlX.XDevAPI;
using Mysqlx;
using System;
using System.Net.Http;
using System.Windows.Forms;
using SmartPack.Classes;

namespace SmartPack.Forms
{
    /// <summary>
    /// Formulari Principal
    /// </summary>
    public partial class Principal : TitleForm
    {
        /// <summary>
        /// Constructor del formulari principal
        /// </summary>
        public Principal()
        {
            InitializeComponent();           
        }

        /// <summary>
        /// Mètode que s'executa quan es tanca el formulari
        /// </summary>
        private bool justClosed = false;

        /// <summary>
        /// Mètode que s'executa quan es tanca la finestra
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if(!justClosed)
            {
                GestioSessins.Logout();
                var session = new Sessio();
                session.Show();
            }            
        }

        /// <summary>
        /// Mètode que obre el formulari de factures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bfactures_Click(object sender, EventArgs e)
        {
            Factures factures = new Factures();
            factures.Open = new Principal();
            factures.Show();
            justClosed = true;
            this.Close();

            /*
            Facturacio facturacio = new Facturacio();
            facturacio.Show();
            justClosed = true;
            this.Close();*/
        }

        /// <summary>
        /// Mètode que obre el formulari de serveis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bservei_Click(object sender, EventArgs e)
        {
            Servei servei = new Servei();
            servei.Open = new Principal();
            servei.Show();
            justClosed = true;
            this.Close();
        }

        /// <summary>
        /// Mètode que obre el formulari de l'area personal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personal_Click(object sender, EventArgs e)
        {
            AreaUsuari areaUsuari = new AreaUsuari();
            areaUsuari.Show();
            justClosed = true;
            this.Close();
        }
    }
}
