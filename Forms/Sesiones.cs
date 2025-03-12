using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPack
{
    public partial class Sesiones: TitleForm
    {
        public Sesiones()
        {
            InitializeComponent();
        }

        private void Iniciar_sessio_Click(object sender, EventArgs e)
        {
            string temail = email_is.Text.Trim();
            string tcontrasenya = contrasenya_is.Text.Trim();
        }

        private void pregunta_b_Click(object sender, EventArgs e)
        {
            RecuperarContrasenya formRContrasenya = new RecuperarContrasenya();
            formRContrasenya.Show();
        }
    }
}
