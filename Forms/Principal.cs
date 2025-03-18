using MySqlX.XDevAPI;
using Mysqlx;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    public partial class Principal : TitleForm
    {
        private static readonly HttpClient clienteHttp = new HttpClient();
        public Principal()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Principal_FormClosing);
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (Message msgBox = new Message("Estàs segur que vols tancar la sessió?", "confirmació"))
            {
                var resultado = msgBox.ShowDialog();

                if (resultado == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    CerrarSesionLocal();
                    LiberarMemoria();
                    Application.Exit();
                }
            }
        }

        private void CerrarSesionLocal()
        {
            Properties.Settings.Default["TokenJWT"] = null;
            Properties.Settings.Default.Save();
        }

        private static void LiberarMemoria()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

    }
}
