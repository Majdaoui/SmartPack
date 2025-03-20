using System;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.Messatge = new System.Windows.Forms.TextBox();
            this.Perfil = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(4, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 7);
            this.panel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(180, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(635, 76);
            this.title.TabIndex = 31;
            this.title.Text = "Benvingut a SmartPack";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Messatge
            // 
            this.Messatge.BackColor = System.Drawing.Color.Bisque;
            this.Messatge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messatge.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Messatge.Location = new System.Drawing.Point(229, 209);
            this.Messatge.Multiline = true;
            this.Messatge.Name = "Messatge";
            this.Messatge.Size = new System.Drawing.Size(395, 102);
            this.Messatge.TabIndex = 34;
            this.Messatge.Text = "Aquest projecte està en construcció.\r\nGràcies per la seva paciència.\r\n\r\n";
            this.Messatge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Perfil
            // 
            this.Perfil.BackColor = System.Drawing.Color.Transparent;
            this.Perfil.Location = new System.Drawing.Point(0, 0);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(827, 24);
            this.Perfil.TabIndex = 35;
            this.Perfil.Text = "El Meu Compte";
            this.Perfil.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Perfil_ItemClicked);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartPack.Properties.Resources.freepik__retouch__32632;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 478);
            this.Controls.Add(this.Messatge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Perfil);
            this.MainMenuStrip = this.Perfil;
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox Messatge;
        private MenuStrip Perfil;
    }
}