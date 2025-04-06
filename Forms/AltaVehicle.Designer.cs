namespace SmartPack
{
    partial class AltaVehicle
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
            this.model_t = new System.Windows.Forms.TextBox();
            this.matricula_t = new System.Windows.Forms.TextBox();
            this.model_l = new System.Windows.Forms.Label();
            this.matricula_l = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.marca_t = new System.Windows.Forms.TextBox();
            this.marca_l = new System.Windows.Forms.Label();
            this.guardar_e = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // model_t
            // 
            this.model_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.model_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_t.Location = new System.Drawing.Point(267, 215);
            this.model_t.Name = "model_t";
            this.model_t.Size = new System.Drawing.Size(199, 24);
            this.model_t.TabIndex = 8;
            // 
            // matricula_t
            // 
            this.matricula_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matricula_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula_t.Location = new System.Drawing.Point(267, 185);
            this.matricula_t.Name = "matricula_t";
            this.matricula_t.Size = new System.Drawing.Size(199, 24);
            this.matricula_t.TabIndex = 7;
            // 
            // model_l
            // 
            this.model_l.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.model_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_l.ForeColor = System.Drawing.Color.White;
            this.model_l.Location = new System.Drawing.Point(134, 215);
            this.model_l.Name = "model_l";
            this.model_l.Size = new System.Drawing.Size(128, 24);
            this.model_l.TabIndex = 5;
            this.model_l.Text = "Model";
            this.model_l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // matricula_l
            // 
            this.matricula_l.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.matricula_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula_l.ForeColor = System.Drawing.Color.White;
            this.matricula_l.Location = new System.Drawing.Point(133, 185);
            this.matricula_l.Name = "matricula_l";
            this.matricula_l.Size = new System.Drawing.Size(128, 24);
            this.matricula_l.TabIndex = 6;
            this.matricula_l.Text = "Matricula";
            this.matricula_l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(8, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 10);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(187, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 75);
            this.label1.TabIndex = 44;
            this.label1.Text = "Alta Vehicle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // marca_t
            // 
            this.marca_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marca_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca_t.Location = new System.Drawing.Point(267, 245);
            this.marca_t.Name = "marca_t";
            this.marca_t.Size = new System.Drawing.Size(199, 24);
            this.marca_t.TabIndex = 10;
            // 
            // marca_l
            // 
            this.marca_l.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.marca_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca_l.ForeColor = System.Drawing.Color.White;
            this.marca_l.Location = new System.Drawing.Point(133, 244);
            this.marca_l.Name = "marca_l";
            this.marca_l.Size = new System.Drawing.Size(128, 24);
            this.marca_l.TabIndex = 46;
            this.marca_l.Text = "Marca";
            this.marca_l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guardar_e
            // 
            this.guardar_e.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guardar_e.AutoSize = true;
            this.guardar_e.BackColor = System.Drawing.Color.OldLace;
            this.guardar_e.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guardar_e.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guardar_e.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guardar_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_e.Location = new System.Drawing.Point(232, 299);
            this.guardar_e.Name = "guardar_e";
            this.guardar_e.Size = new System.Drawing.Size(124, 46);
            this.guardar_e.TabIndex = 11;
            this.guardar_e.Text = "Guardar";
            this.guardar_e.UseVisualStyleBackColor = false;
            this.guardar_e.Click += new System.EventHandler(this.guardar_e_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // AltaVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::SmartPack.Properties.Resources.freepik__retouch__32632;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guardar_e);
            this.Controls.Add(this.marca_t);
            this.Controls.Add(this.marca_l);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.model_t);
            this.Controls.Add(this.matricula_t);
            this.Controls.Add(this.model_l);
            this.Controls.Add(this.matricula_l);
            this.Name = "AltaVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox model_t;
        private System.Windows.Forms.TextBox matricula_t;
        private System.Windows.Forms.Label model_l;
        private System.Windows.Forms.Label matricula_l;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox marca_t;
        private System.Windows.Forms.Label marca_l;
        private System.Windows.Forms.Button guardar_e;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}