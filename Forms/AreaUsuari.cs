using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    public partial class AreaUsuari: TitleForm
    {
        public AreaUsuari()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.DoubleBuffered = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Bcanvi_contrasenya_Click(object sender, EventArgs e)
        {
            CanviContrasenya canviContrasenya = new CanviContrasenya();
            canviContrasenya.ShowDialog();
        }
    }
}
