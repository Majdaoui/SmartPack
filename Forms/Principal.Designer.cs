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
            this.Serveis = new System.Windows.Forms.Button();
            this.bFactures = new System.Windows.Forms.Button();
            this.bAreaPersonal = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // Serveis
            // 
            this.Serveis.BackColor = System.Drawing.Color.OldLace;
            this.Serveis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Serveis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Serveis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Serveis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Serveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serveis.Location = new System.Drawing.Point(70, 142);
            this.Serveis.Name = "Serveis";
            this.Serveis.Size = new System.Drawing.Size(153, 73);
            this.Serveis.TabIndex = 34;
            this.Serveis.Text = "Serveis";
            this.Serveis.UseVisualStyleBackColor = false;
            this.Serveis.Click += new System.EventHandler(this.bservei_Click);
            // 
            // bFactures
            // 
            this.bFactures.BackColor = System.Drawing.Color.OldLace;
            this.bFactures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFactures.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bFactures.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bFactures.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bFactures.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFactures.Location = new System.Drawing.Point(70, 325);
            this.bFactures.Name = "bFactures";
            this.bFactures.Size = new System.Drawing.Size(153, 73);
            this.bFactures.TabIndex = 35;
            this.bFactures.Text = "Facturació";
            this.bFactures.UseVisualStyleBackColor = false;
            this.bFactures.Click += new System.EventHandler(this.bfactures_Click);
            // 
            // bAreaPersonal
            // 
            this.bAreaPersonal.BackColor = System.Drawing.Color.OldLace;
            this.bAreaPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAreaPersonal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bAreaPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bAreaPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bAreaPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAreaPersonal.Location = new System.Drawing.Point(70, 232);
            this.bAreaPersonal.Name = "bAreaPersonal";
            this.bAreaPersonal.Size = new System.Drawing.Size(153, 73);
            this.bAreaPersonal.TabIndex = 36;
            this.bAreaPersonal.Text = "Area Personal";
            this.bAreaPersonal.UseVisualStyleBackColor = false;
            this.bAreaPersonal.Click += new System.EventHandler(this.personal_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::SmartPack.Properties.Resources.Checking_boxes_amico;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(381, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 324);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 478);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Serveis);
            this.Controls.Add(this.bAreaPersonal);
            this.Controls.Add(this.bFactures);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private Button Serveis;
        private Button bFactures;
        private Button bAreaPersonal;
        private PictureBox pictureBox2;
    }
}