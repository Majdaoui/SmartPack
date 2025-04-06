namespace SmartPack.Forms
{
    partial class Administracio
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
            this.assignar_u = new System.Windows.Forms.Button();
            this.llist_u = new System.Windows.Forms.Button();
            this.desassignar_u = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listUsauris = new System.Windows.Forms.ListBox();
            this.usuari_a = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listEmpreses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_e = new System.Windows.Forms.Button();
            this.desctivate_e = new System.Windows.Forms.Button();
            this.update_e = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // assignar_u
            // 
            this.assignar_u.BackColor = System.Drawing.Color.AntiqueWhite;
            this.assignar_u.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.assignar_u.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.assignar_u.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.assignar_u.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignar_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignar_u.ForeColor = System.Drawing.Color.Black;
            this.assignar_u.Location = new System.Drawing.Point(206, 148);
            this.assignar_u.Name = "assignar_u";
            this.assignar_u.Size = new System.Drawing.Size(164, 45);
            this.assignar_u.TabIndex = 22;
            this.assignar_u.Text = "Assignar un usuari a una empresa";
            this.assignar_u.UseVisualStyleBackColor = false;
            this.assignar_u.Visible = false;
            this.assignar_u.Click += new System.EventHandler(this.button1_Click);
            // 
            // llist_u
            // 
            this.llist_u.BackColor = System.Drawing.Color.AntiqueWhite;
            this.llist_u.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llist_u.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.llist_u.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.llist_u.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.llist_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llist_u.ForeColor = System.Drawing.Color.Black;
            this.llist_u.Location = new System.Drawing.Point(7, 42);
            this.llist_u.Name = "llist_u";
            this.llist_u.Size = new System.Drawing.Size(255, 31);
            this.llist_u.TabIndex = 24;
            this.llist_u.Text = "Llista d\'usauris";
            this.llist_u.UseVisualStyleBackColor = false;
            this.llist_u.Click += new System.EventHandler(this.llist_u_Click);
            // 
            // desassignar_u
            // 
            this.desassignar_u.BackColor = System.Drawing.Color.AntiqueWhite;
            this.desassignar_u.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.desassignar_u.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.desassignar_u.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.desassignar_u.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desassignar_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desassignar_u.ForeColor = System.Drawing.Color.Black;
            this.desassignar_u.Location = new System.Drawing.Point(36, 149);
            this.desassignar_u.Name = "desassignar_u";
            this.desassignar_u.Size = new System.Drawing.Size(164, 44);
            this.desassignar_u.TabIndex = 25;
            this.desassignar_u.Text = "Desassignar usuari a empresa";
            this.desassignar_u.UseVisualStyleBackColor = false;
            this.desassignar_u.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.listUsauris);
            this.panel1.Controls.Add(this.usuari_a);
            this.panel1.Controls.Add(this.llist_u);
            this.panel1.Location = new System.Drawing.Point(36, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 352);
            this.panel1.TabIndex = 27;
            // 
            // listUsauris
            // 
            this.listUsauris.FormattingEnabled = true;
            this.listUsauris.Location = new System.Drawing.Point(7, 86);
            this.listUsauris.Name = "listUsauris";
            this.listUsauris.Size = new System.Drawing.Size(255, 251);
            this.listUsauris.TabIndex = 33;
            // 
            // usuari_a
            // 
            this.usuari_a.AutoSize = true;
            this.usuari_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuari_a.Location = new System.Drawing.Point(19, 11);
            this.usuari_a.Name = "usuari_a";
            this.usuari_a.Size = new System.Drawing.Size(131, 18);
            this.usuari_a.TabIndex = 25;
            this.usuari_a.Text = "Gestió d\'usuaris";
            this.usuari_a.Click += new System.EventHandler(this.usuari_a_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.listEmpreses);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.list_e);
            this.panel2.Location = new System.Drawing.Point(316, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 352);
            this.panel2.TabIndex = 28;
            // 
            // listEmpreses
            // 
            this.listEmpreses.FormattingEnabled = true;
            this.listEmpreses.Location = new System.Drawing.Point(10, 86);
            this.listEmpreses.Name = "listEmpreses";
            this.listEmpreses.Size = new System.Drawing.Size(275, 251);
            this.listEmpreses.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gestió d\'empresa";
            // 
            // list_e
            // 
            this.list_e.BackColor = System.Drawing.Color.AntiqueWhite;
            this.list_e.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.list_e.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.list_e.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.list_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_e.ForeColor = System.Drawing.Color.Black;
            this.list_e.Location = new System.Drawing.Point(10, 42);
            this.list_e.Name = "list_e";
            this.list_e.Size = new System.Drawing.Size(275, 31);
            this.list_e.TabIndex = 24;
            this.list_e.Text = "Llista d\'empreses";
            this.list_e.UseVisualStyleBackColor = false;
            this.list_e.Click += new System.EventHandler(this.list_e_Click);
            // 
            // desctivate_e
            // 
            this.desctivate_e.BackColor = System.Drawing.Color.AntiqueWhite;
            this.desctivate_e.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.desctivate_e.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.desctivate_e.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.desctivate_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desctivate_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desctivate_e.ForeColor = System.Drawing.Color.Black;
            this.desctivate_e.Location = new System.Drawing.Point(546, 149);
            this.desctivate_e.Name = "desctivate_e";
            this.desctivate_e.Size = new System.Drawing.Size(164, 44);
            this.desctivate_e.TabIndex = 29;
            this.desctivate_e.Text = "Desactivar Empresa";
            this.desctivate_e.UseVisualStyleBackColor = false;
            this.desctivate_e.Visible = false;
            // 
            // update_e
            // 
            this.update_e.BackColor = System.Drawing.Color.AntiqueWhite;
            this.update_e.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.update_e.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.update_e.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.update_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_e.ForeColor = System.Drawing.Color.Black;
            this.update_e.Location = new System.Drawing.Point(376, 148);
            this.update_e.Name = "update_e";
            this.update_e.Size = new System.Drawing.Size(164, 45);
            this.update_e.TabIndex = 28;
            this.update_e.Text = "Modificar Empresa";
            this.update_e.UseVisualStyleBackColor = false;
            this.update_e.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel5.Location = new System.Drawing.Point(4, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(923, 7);
            this.panel5.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(167, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(711, 75);
            this.title.TabIndex = 29;
            this.title.Text = "Administració SmartPack";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Administracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartPack.Properties.Resources.freepik__retouch__32632;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.desctivate_e);
            this.Controls.Add(this.update_e);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.assignar_u);
            this.Controls.Add(this.desassignar_u);
            this.Controls.Add(this.panel1);
            this.Name = "Administracio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administració";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button assignar_u;
        private System.Windows.Forms.Button llist_u;
        private System.Windows.Forms.Button desassignar_u;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usuari_a;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button list_e;
        private System.Windows.Forms.Button desctivate_e;
        private System.Windows.Forms.Button update_e;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListBox listEmpreses;
        private System.Windows.Forms.ListBox listUsauris;
    }
}