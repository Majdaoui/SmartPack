
using System.Windows.Forms;

namespace SmartPack
{
    public partial class AltaEmpresa: TitleForm
    {
        public AltaEmpresa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false; 
            this.MinimizeBox = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void guardar_e_Click(object sender, System.EventArgs e)
        {
            string tcif = cif_e.Text;
            string tnom_e = nom_e.Text;
            string temail = email_e.Text;
            string ttef = tef_e.Text;
            string t_tvia = t_via_e.Text;
            string tnom_via = nom_via_e.Text;
            string t_cp = cp_e.Text;
            string tpoble = poblacio_e.Text;
        }
    }
}
