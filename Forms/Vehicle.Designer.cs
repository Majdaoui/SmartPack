﻿namespace SmartPack.Forms
{
    partial class Vehicle
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
            this.t_marca = new System.Windows.Forms.TextBox();
            this.nom_u = new System.Windows.Forms.Label();
            this.t_model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.desactivar_v = new System.Windows.Forms.Button();
            this.update_v = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.t_tipus = new System.Windows.Forms.TextBox();
            this.ltipus = new System.Windows.Forms.Label();
            this.t_color = new System.Windows.Forms.TextBox();
            this.lcolor = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // t_marca
            // 
            this.t_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_marca.Location = new System.Drawing.Point(148, 181);
            this.t_marca.Name = "t_marca";
            this.t_marca.Size = new System.Drawing.Size(199, 20);
            this.t_marca.TabIndex = 49;
            // 
            // nom_u
            // 
            this.nom_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.nom_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_u.ForeColor = System.Drawing.Color.White;
            this.nom_u.Location = new System.Drawing.Point(15, 181);
            this.nom_u.Name = "nom_u";
            this.nom_u.Size = new System.Drawing.Size(128, 20);
            this.nom_u.TabIndex = 48;
            this.nom_u.Text = "Marca";
            this.nom_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_model
            // 
            this.t_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_model.Location = new System.Drawing.Point(148, 213);
            this.t_model.Name = "t_model";
            this.t_model.Size = new System.Drawing.Size(199, 20);
            this.t_model.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Model";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_matricula
            // 
            this.t_matricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_matricula.Location = new System.Drawing.Point(148, 243);
            this.t_matricula.Name = "t_matricula";
            this.t_matricula.Size = new System.Drawing.Size(199, 20);
            this.t_matricula.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Matricula";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // desactivar_v
            // 
            this.desactivar_v.BackColor = System.Drawing.Color.AntiqueWhite;
            this.desactivar_v.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.desactivar_v.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.desactivar_v.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.desactivar_v.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desactivar_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desactivar_v.ForeColor = System.Drawing.Color.Black;
            this.desactivar_v.Location = new System.Drawing.Point(385, 275);
            this.desactivar_v.Name = "desactivar_v";
            this.desactivar_v.Size = new System.Drawing.Size(179, 44);
            this.desactivar_v.TabIndex = 69;
            this.desactivar_v.Text = "Disactivar Vehicle";
            this.desactivar_v.UseVisualStyleBackColor = false;
            this.desactivar_v.Click += new System.EventHandler(this.desactivar_v_Click);
            // 
            // update_v
            // 
            this.update_v.BackColor = System.Drawing.Color.AntiqueWhite;
            this.update_v.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.update_v.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.update_v.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.update_v.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_v.ForeColor = System.Drawing.Color.Black;
            this.update_v.Location = new System.Drawing.Point(385, 222);
            this.update_v.Name = "update_v";
            this.update_v.Size = new System.Drawing.Size(179, 45);
            this.update_v.TabIndex = 70;
            this.update_v.Text = "Modificar Vehicle";
            this.update_v.UseVisualStyleBackColor = false;
            this.update_v.Click += new System.EventHandler(this.update_v_Click);
            // 
            // labelID
            // 
            this.labelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(15, 146);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(128, 20);
            this.labelID.TabIndex = 71;
            this.labelID.Text = "ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelID.Visible = false;
            // 
            // t_tipus
            // 
            this.t_tipus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_tipus.Location = new System.Drawing.Point(148, 299);
            this.t_tipus.Name = "t_tipus";
            this.t_tipus.Size = new System.Drawing.Size(199, 20);
            this.t_tipus.TabIndex = 75;
            // 
            // ltipus
            // 
            this.ltipus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ltipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltipus.ForeColor = System.Drawing.Color.White;
            this.ltipus.Location = new System.Drawing.Point(15, 299);
            this.ltipus.Name = "ltipus";
            this.ltipus.Size = new System.Drawing.Size(128, 20);
            this.ltipus.TabIndex = 74;
            this.ltipus.Text = "Tipus";
            this.ltipus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_color
            // 
            this.t_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_color.Location = new System.Drawing.Point(148, 269);
            this.t_color.Name = "t_color";
            this.t_color.Size = new System.Drawing.Size(199, 20);
            this.t_color.TabIndex = 73;
            // 
            // lcolor
            // 
            this.lcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.lcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcolor.ForeColor = System.Drawing.Color.White;
            this.lcolor.Location = new System.Drawing.Point(15, 269);
            this.lcolor.Name = "lcolor";
            this.lcolor.Size = new System.Drawing.Size(128, 20);
            this.lcolor.TabIndex = 72;
            this.lcolor.Text = "Color";
            this.lcolor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel5.Location = new System.Drawing.Point(6, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(589, 10);
            this.panel5.TabIndex = 77;
            this.panel5.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(148, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(444, 75);
            this.title.TabIndex = 76;
            this.title.Text = "Gestió Vehicle";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.UseWaitCursor = true;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 343);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.t_tipus);
            this.Controls.Add(this.ltipus);
            this.Controls.Add(this.t_color);
            this.Controls.Add(this.lcolor);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.update_v);
            this.Controls.Add(this.desactivar_v);
            this.Controls.Add(this.t_matricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_marca);
            this.Controls.Add(this.nom_u);
            this.Name = "Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_marca;
        private System.Windows.Forms.Label nom_u;
        private System.Windows.Forms.TextBox t_model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button desactivar_v;
        private System.Windows.Forms.Button update_v;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox t_tipus;
        private System.Windows.Forms.Label ltipus;
        private System.Windows.Forms.TextBox t_color;
        private System.Windows.Forms.Label lcolor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
    }
}