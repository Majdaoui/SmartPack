using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    /// <summary>
    /// Formulari SplashScreen
    /// </summary>
    public partial class SplashScreen : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        /// <summary>
        /// Constructor del formulari de SplashScreen.
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
            this.MouseDown += Form_MouseDown;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            timerLoad.Start();
        }

    
        int i = 0;

        /// <summary>
        /// Després d'un temps determinat, es tanca el formulari de SplashScreen i s'obre el formulari de Sessio.
        /// amb un efecte de puntets que apareixen a la part superior del formulari.
        /// dona una sensació de càrrega.
        /// per carregar el formulari de sessió.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerLoad_Tick(object sender, EventArgs e)
        {
            title.Text += ".";
            i++;
            if (i > 3)
            {
                timerLoad.Stop();
                Sessio sessio = new Sessio();
                sessio.Show();
                this.Close();
            }
        }
    }
}
