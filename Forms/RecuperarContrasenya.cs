using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SmartPack
{
    public partial class RecuperarContrasenya: TitleForm
    {
        public RecuperarContrasenya()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.DoubleBuffered = true;
        }

        private void R_contrasenya_Click(object sender, EventArgs e)
        {
            string temail_rc = email_rc.Text.Trim();
            if (string.IsNullOrWhiteSpace(temail_rc))
            {
                MessageBox.Show("El camp Email no pot estar vuit ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isValidFormat = System.Text.RegularExpressions.Regex.IsMatch(temail_rc, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!isValidFormat)
            {
                MessageBox.Show("Format d'email és incorrecte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
