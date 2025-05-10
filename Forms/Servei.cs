using SmartPack.Classes;
using System;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    /// <summary>
    /// Formulari de serveis
    /// </summary>
    public partial class Servei : TitleForm
    {
        public TitleForm Open { get; set; } = null;

        /// <summary>
        /// Constructor del formulari de serveis
        /// </summary>
        public Servei()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carrega el formulari i les dades del servei en el datagrid
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (GestioSessins.role == "ROLE_USER" || GestioSessins.role == "ROLE_DELIVERYMAN" || GestioSessins.role == "ROLE_ADMIN")
            {
                AddServei.Visible = true;
            }
            else
            {
                AddServei.Visible = false;
            }
        }

        private bool justClosed = false;

        /// <summary>
        /// Al tancar el formulari, obre el formulari de Administrador
        /// </summary>
        /// <param name="e"></param>
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

        /// <summary>
        /// Obre el formulari d'alta de servei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddServei_Click(object sender, EventArgs e)
        {
            justClosed = true;
            AltaServei altaservei = new AltaServei();
            altaservei.Show();
            this.Close();
        }

        /// <summary>
        /// Obre el formulari de consulta de serveis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consult_Click(object sender, EventArgs e)
        {
            justClosed = true;
            ConsultaServei consultaservei = new ConsultaServei();
            consultaservei.Open = Open;
            consultaservei.Show();
            this.Close();
        }

        /// <summary>
        /// Obre el formulari de consulta de serveis finalitzats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultAll_Click(object sender, EventArgs e)
        {
            justClosed = true;
            ServeisFinalitzats serveisFinalitzats = new ServeisFinalitzats();
            serveisFinalitzats.Show();
            this.Close();            
        }

        /// <summary>
        /// Obre el formulari de modificació de servei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_Click(object sender, EventArgs e)
        {
            justClosed = true;
            ModificarServei modificarServei = new ModificarServei();
            modificarServei.Show();
            this.Close();
        }
    }
}
