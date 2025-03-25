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
            using (Servei servei = new Servei())
            {
                servei.ShowDialog();
                this.Hide();
            }
            this.Show();
        }

        private void personal_Click(object sender, EventArgs e)
        {
            using( AreaUsuari areaUsuari = new AreaUsuari())
            {
                areaUsuari.ShowDialog();
                this.Hide();
            }
            this.Show();
        }
    }
}
