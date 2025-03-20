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

        private void Perfil_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
