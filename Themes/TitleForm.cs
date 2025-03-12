using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            set { 
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

        // Dibujar la barra de título
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            int barraAltura = 30; // Ajustado a 30px

            // Dibujar el fondo de la barra de título
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, this.Width, barraAltura),
                Color.DarkBlue,
                Color.LightBlue,
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, new Rectangle(0, 0, this.Width, barraAltura));
            }

            // Posicionar los botones de cerrar y minimizar
            btnCerrar = new Rectangle(this.Width - 45, 5, 30, 20);
            btnMinimizar = new Rectangle(this.Width - 85, 5, 30, 20);

            // Dibujar el borde y los botones
            using (Pen borde = new Pen(Color.White, 2))
            {
                // Botón Cerrar
                using (LinearGradientBrush brushCerrar = new LinearGradientBrush(btnCerrar, Color.Red, Color.DarkRed, LinearGradientMode.Vertical))
                {
                    g.FillRectangle(brushCerrar, btnCerrar);
                    g.DrawRectangle(borde, btnCerrar);
                    g.DrawString("X", new Font("Arial", 10, FontStyle.Bold), Brushes.White, btnCerrar.X + 9, btnCerrar.Y + 3);
                }

                // Botón Minimizar
                using (LinearGradientBrush brushMin = new LinearGradientBrush(btnMinimizar, Color.Gold, Color.Orange, LinearGradientMode.Vertical))
                {
                    g.FillRectangle(brushMin, btnMinimizar);
                    g.DrawRectangle(borde, btnMinimizar);
                    g.DrawString("_", new Font("Arial", 12, FontStyle.Bold), Brushes.White, btnMinimizar.X + 7, btnMinimizar.Y + -7);
                }
            }

            using(SolidBrush sb = new SolidBrush(_borderColor))
            {
                using (Pen p = new Pen(sb, 1))
                {
                    g.DrawRectangle(p, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                }
            }            
        }

        // Función para arrastrar el formulario
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y <= 30 && !btnCerrar.Contains(e.Location) && !btnMinimizar.Contains(e.Location))
            {
                arrastrando = true;
                puntoInicio = new Point(e.X, e.Y);
            }
        }

        // Mover el formulario al arrastrar
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

        // Función para gestionar el clic en los botones de la barra de título
        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnCerrar.Contains(e.Location))
            {
                this.Close();
            }
            else if (btnMinimizar.Contains(e.Location))
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        // Re-dibujar el formulario cuando cambia de tamaño
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Forzamos la actualización de la barra de título
        }
    }
}
