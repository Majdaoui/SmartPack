using System;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    public partial class CanviContrasenya : TitleForm
    {
        public CanviContrasenya()
        {
            InitializeComponent();
        }

        private void guardar_e_Click(object sender, EventArgs e)
        {
            string acontrasenya = contrasenya_a.Text.Trim();
            string ncontrasenya = contrasenya_n.Text.Trim();
            string rcontrasenya = contrasenya_r.Text.Trim();
            if (!Alta.ValidarContrasenya(ncontrasenya))
            {
                Message msg = new Message("La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial", "Error");
                msg.ShowDialog();
                //MessageBox.Show("La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ncontrasenya != rcontrasenya)
            {
                Message msg = new Message("Les contrasenyes no coincideixen", "Error");
                msg.ShowDialog();
                //MessageBox.Show("Les contrasenyes no coincideixen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var contrasenya = new
            {
                contrasenya = ncontrasenya
            };
            Message messatge = new Message("La nova contrasenya s'ha guardat correctament", "info");
            messatge.ShowDialog();
        }
    }
}
