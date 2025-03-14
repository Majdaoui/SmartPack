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
    public partial class Message: TitleForm
    {
        public Message(string msg, string tipy)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.DoubleBuffered = true;
            this.message_l.Text = msg;
            this.message_l.TextAlign = ContentAlignment.MiddleCenter;
            picIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (tipy.ToLower())
            {
                case "error":
                    picIcono.Image = Properties.Resources.iconError;
                    this.BackColor = Color.Red;
                    acceptar.Text = "OK";
                    acceptar.Visible = true;
                    cancelar.Visible = false;
                    break;
                case "confirmacio":
                    picIcono.Image = Properties.Resources.iconConfirm;
                    this.BackColor = Color.Green;
                    cancelar.Visible = true;
                    cancelar.Text = "Cancelar";
                    acceptar.Text = "Aceptar";
                    acceptar.Visible = true;
                    break;
                case "advertencia":
                    picIcono.Image = Properties.Resources.iconAdv;
                    this.BackColor = Color.Orange;
                    acceptar.Text = "OK";
                    acceptar.Visible = true;
                    cancelar.Visible = false;
                    break;
                case "info":
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
        private void acceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
