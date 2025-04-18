﻿using System;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    public partial class Servei : TitleForm
    {
        public Servei()
        {
            InitializeComponent();
        }
        private bool justClosed = false;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (!justClosed)
            {
                var principal = new Principal();
                principal.Show();
            }
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddServei_Click(object sender, EventArgs e)
        {
            justClosed = true;
            AltaServei altaservei = new AltaServei();
            altaservei.Show();
            this.Close();
        }

        private void consult_Click(object sender, EventArgs e)
        {
            justClosed = true;
            ConsultaServei consultaservei = new ConsultaServei();
            consultaservei.Show();
            this.Close();
        }

        private void ConsultAll_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
