using System;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    public partial class Servei : TitleForm
    {
        public Servei()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddServei_Click(object sender, EventArgs e)
        {
            AltaServei altaservei = new AltaServei();
            altaservei.Show();
            this.Hide();
        }

        private void consult_Click(object sender, EventArgs e)
        {

        }

        private void ConsultAll_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
