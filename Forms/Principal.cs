using MySqlX.XDevAPI;
using Mysqlx;
using System;
using System.Net.Http;
using System.Windows.Forms;
using SmartPack.Classes;

namespace SmartPack.Forms
{
    public partial class Principal : TitleForm
    {
        public Principal()
        {
            InitializeComponent();           
        }

        private bool justClosed = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Factures factures = new Factures();
            factures.Show();
            justClosed = true;
            this.Close();

            /*
            Facturacio facturacio = new Facturacio();
            facturacio.Show();
            justClosed = true;
            this.Close();*/
        }
      
        private void bservei_Click(object sender, EventArgs e)
        {
            Servei servei = new Servei();
            servei.Open = new Principal();
            servei.Show();
            justClosed = true;
            this.Close();
        }

        private void personal_Click(object sender, EventArgs e)
        {
            AreaUsuari areaUsuari = new AreaUsuari();
            areaUsuari.Show();
            justClosed = true;
            this.Close();
        }
    }
}
