using SmartPack.Classes;
using SmartPack.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Permissions;
using System.Windows.Forms;

namespace SmartPack
{
    public class TitleForm : Form
    {
        private bool arrastrando = false;
        private Point puntoInicio;

        private Rectangle btnCerrar;
        private Rectangle btnMinimizar;


        private Color _borderColor = Color.Black;
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }


        public TitleForm()
        {
            this.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            this.DoubleBuffered = true;
            this.BackColor = Color.White; // Fondo blanco o el color que prefieras

            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);
            this.MouseClick += new MouseEventHandler(Form_MouseClick);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            int barraAltura = 30; 
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, this.Width, barraAltura),
                Color.DarkBlue,
                Color.LightBlue,
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, new Rectangle(0, 0, this.Width, barraAltura));
            }
            btnCerrar = new Rectangle(this.Width - 45, 5, 30, 20);
            btnMinimizar = new Rectangle(this.Width - 85, 5, 30, 20);

            using (Pen borde = new Pen(Color.White, 2))
            {
                using (LinearGradientBrush brushCerrar = new LinearGradientBrush(btnCerrar, Color.Red, Color.DarkRed, LinearGradientMode.Vertical))
                {
                    g.FillRectangle(brushCerrar, btnCerrar);
                    g.DrawRectangle(borde, btnCerrar);
                    g.DrawString("X", new Font("Arial", 10, FontStyle.Bold), Brushes.White, btnCerrar.X + 9, btnCerrar.Y + 3);
                }

                using (LinearGradientBrush brushMin = new LinearGradientBrush(btnMinimizar, Color.Gold, Color.Orange, LinearGradientMode.Vertical))
                {
                    g.FillRectangle(brushMin, btnMinimizar);
                    g.DrawRectangle(borde, btnMinimizar);
                    g.DrawString("_", new Font("Arial", 12, FontStyle.Bold), Brushes.White, btnMinimizar.X + 7, btnMinimizar.Y + -7);
                }
            }

            using (SolidBrush sb = new SolidBrush(_borderColor))
            {
                using (Pen p = new Pen(sb, 1))
                {
                    g.DrawRectangle(p, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                }
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y <= 30 && !btnCerrar.Contains(e.Location) && !btnMinimizar.Contains(e.Location))
            {
                arrastrando = true;
                puntoInicio = new Point(e.X, e.Y);
            }
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                this.Location = new Point(this.Left + e.X - puntoInicio.X, this.Top + e.Y - puntoInicio.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrando = false;
        }

        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnCerrar.Contains(e.Location))
            {
                using (Message msgBox = new Message("Estàs segur que vols tancar la sessió?", "confirmació"))
                {
                    var resultado = msgBox.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        this.Close();
                        CerrarSesionLocal();
                        LiberarMemoria();
                        Application.Exit();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (btnMinimizar.Contains(e.Location))
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
        private void CerrarSesionLocal()
        {
            GestioSessins.user = null;
            GestioSessins.password = null;
            GestioSessins.token = null;
        }
        private static void LiberarMemoria()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }


        private void InitializeComponent()
        {

        }

        private void TitleForm_Load()
        {

        }
    }
}
