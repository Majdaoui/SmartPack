using SmartPack.Classes;
using System;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    public partial class Servei : TitleForm
    {
        public TitleForm Open { get; set; } = null;

        public Servei()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (GestioSessins.role == "ROLE_USER" || GestioSessins.role == "ROLE_DELIVERYMAN")
            {
                AddServei.Visible = true;
            }
            else
            {
                AddServei.Visible = false;
            }
        }

        private bool justClosed = false;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (!justClosed)
            {
                if(Open != null)
                {
                    Open.Show();
                }
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
            consultaservei.Open = Open;
            consultaservei.Show();
            this.Close();
        }

        private void ConsultAll_Click(object sender, EventArgs e)
        {
            justClosed = true;
            ServeisFinalitzats serveisFinalitzats = new ServeisFinalitzats();
            serveisFinalitzats.Show();
            this.Close();            
        }

        private void update_Click(object sender, EventArgs e)
        {
            justClosed = true;
            ModificarServei modificarServei = new ModificarServei();
            modificarServei.Show();
            this.Close();
        }
    }
}
