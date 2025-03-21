﻿using System.Drawing;
using System;

namespace SmartPack
{
    partial class RecuperarContrasenya
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.email_rc = new System.Windows.Forms.TextBox();
            this.R_contrasenya = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(9, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 10);
            this.panel1.TabIndex = 52;
            //this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
           // this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(182, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 75);
            this.label1.TabIndex = 51;
            this.label1.Text = "Recuperar Contrasenya";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::SmartPack.Properties.Resources.user;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(143, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            //this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // email_rc
            // 
            this.email_rc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.email_rc.ForeColor = System.Drawing.Color.Gray;
            this.email_rc.Location = new System.Drawing.Point(193, 176);
            this.email_rc.Multiline = true;
            this.email_rc.Name = "email_rc";
            this.email_rc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email_rc.Size = new System.Drawing.Size(220, 35);
            this.email_rc.TabIndex = 63;
            this.email_rc.Text = "Email";
           // this.email_rc.TextChanged += new System.EventHandler(this.email_rc_TextChanged);
            // 
            // R_contrasenya
            // 
            this.R_contrasenya.AutoSize = true;
            this.R_contrasenya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.R_contrasenya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.R_contrasenya.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.R_contrasenya.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.R_contrasenya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_contrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_contrasenya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.R_contrasenya.Location = new System.Drawing.Point(193, 228);
            this.R_contrasenya.Name = "R_contrasenya";
            this.R_contrasenya.Size = new System.Drawing.Size(220, 44);
            this.R_contrasenya.TabIndex = 65;
            this.R_contrasenya.Text = "Enviar";
            this.R_contrasenya.UseVisualStyleBackColor = false;
            this.R_contrasenya.Click += new System.EventHandler(this.R_contrasenya_Click);
            // 
            // RecuperarContrasenya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartPack.Properties.Resources.freepik__retouch__32632;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 331);
            this.Controls.Add(this.R_contrasenya);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.email_rc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "RecuperarContrasenya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R_Contrasenya";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox email_rc;
        private System.Windows.Forms.Button R_contrasenya;

        private void Email_Enter(object sender, EventArgs e)
        {
            if (email_rc.Text == "Email")
            {
                email_rc.Text = "";
                email_rc.ForeColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_rc.Text))
            {
                email_rc.Text = "Email";
                email_rc.ForeColor = Color.Gray;
            }
        }
    }
}