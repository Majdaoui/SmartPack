using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartPack
{
    /// <summary>
    /// Classe que representa un formulari de missatge personalitzat.
    /// </summary>
    public partial class Message: TitleForm
    {
        /// <summary>
        /// Inicialitza els components del formulari Message.
        /// </summary>
        private void Init()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.DoubleBuffered = true;
            picIcono.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        /// <summary>
        /// Constructor del formulari Message.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="tipy"></param>
        public Message(string msg, string tipy)
        {
            Init();
            if (!string.IsNullOrEmpty(msg) && !string.IsNullOrEmpty(tipy))
            {
                SetMessage(msg, tipy);
            }
        }

        /// <summary>
        /// Estableix el missatge i el tipus de missatge a mostrar al formulari.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="tipy"></param>
        public void SetMessage(string msg, string tipy)
        {
            this.message_l.Text = msg;
            var l = acceptar.Location;
            switch (tipy.ToLower())
            {
                case "error":
                    picIcono.Image = Properties.Resources.iconError;
                    this.BackColor = Color.Red;
                    acceptar.Text = "OK";
                    acceptar.Visible = true;
                    cancelar.Visible = false;
                    acceptar.Location = new Point((this.Width / 2 - acceptar.Width / 2), l.Y);
                    break;
                case "confirmacio":
                    acceptar.Location = l;
                    picIcono.Image = Properties.Resources.iconConfirm;
                    this.BackColor = Color.Green;
                    cancelar.Visible = true;
                    cancelar.Text = "Cancelar";
                    acceptar.Text = "Aceptar";
                    acceptar.Visible = true;
                    break;
                case "advertencia":
                    acceptar.Location = new Point((this.Width / 2 - acceptar.Width / 2), l.Y);
                    picIcono.Image = Properties.Resources.iconAdv;
                    this.BackColor = Color.Orange;
                    acceptar.Text = "OK";
                    acceptar.Visible = true;
                    cancelar.Visible = false;
                    break;
                case "info":
                    acceptar.Location = new Point((this.Width / 2 - acceptar.Width / 2), l.Y);
                    picIcono.Image = Properties.Resources.iconInfo;
                    this.BackColor = Color.Blue;
                    acceptar.Text = "OK";
                    acceptar.Visible = true;
                    cancelar.Visible = false;
                    break;
                default:
                    picIcono.Image = Properties.Resources.iconInfo;
                    this.BackColor = Color.Blue;
                    break;
            }
        }

        /// <summary>
        /// Maneja l'esdeveniment de clic del botó "Aceptar".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Maneja l'esdeveniment de clic del botó "Cancelar".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
