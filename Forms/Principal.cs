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

        private void button2_Click(object sender, EventArgs e)
        {

        }
      
        private void bservei_Click(object sender, EventArgs e)
        {
            Servei servei = new Servei();
            servei.Show();
            this.Close();
        }

        private void personal_Click(object sender, EventArgs e)
        {
            AreaUsuari areaUsuari = new AreaUsuari();
            areaUsuari.Show();
            this.Close();
        }
    }
}
