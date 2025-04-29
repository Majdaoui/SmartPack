namespace SmartPack.Forms
{
    partial class ConsultaServei
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_rol = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.bCambiarEstado = new System.Windows.Forms.Button();
            this.dataGridHistorial = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bQR = new System.Windows.Forms.Button();
            this.ImageQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageQR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(2, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 10);
            this.panel1.TabIndex = 111;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(142, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(463, 76);
            this.title.TabIndex = 110;
            this.title.Text = "Consultar Servei un Servei";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 171);
            this.dataGridView1.TabIndex = 114;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // l_rol
            // 
            this.l_rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.l_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_rol.ForeColor = System.Drawing.Color.White;
            this.l_rol.Location = new System.Drawing.Point(10, 517);
            this.l_rol.Name = "l_rol";
            this.l_rol.Size = new System.Drawing.Size(128, 25);
            this.l_rol.TabIndex = 116;
            this.l_rol.Text = "Tipus de compte: ";
            this.l_rol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "ORDENAT",
            "ENVIAT",
            "TRANSIT",
            "ENTREGAT",
            "NO_ENTREGAT",
            "RETORNAT"});
            this.cbEstado.Location = new System.Drawing.Point(142, 516);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(199, 26);
            this.cbEstado.TabIndex = 115;
            this.cbEstado.Text = "ORDENAT";
            // 
            // bCambiarEstado
            // 
            this.bCambiarEstado.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bCambiarEstado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bCambiarEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bCambiarEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCambiarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCambiarEstado.ForeColor = System.Drawing.Color.Black;
            this.bCambiarEstado.Location = new System.Drawing.Point(372, 506);
            this.bCambiarEstado.Name = "bCambiarEstado";
            this.bCambiarEstado.Size = new System.Drawing.Size(133, 44);
            this.bCambiarEstado.TabIndex = 117;
            this.bCambiarEstado.Text = "Canviar Estat";
            this.bCambiarEstado.UseVisualStyleBackColor = false;
            this.bCambiarEstado.Click += new System.EventHandler(this.bCambiarEstado_Click);
            // 
            // dataGridHistorial
            // 
            this.dataGridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorial.Location = new System.Drawing.Point(12, 319);
            this.dataGridHistorial.Name = "dataGridHistorial";
            this.dataGridHistorial.Size = new System.Drawing.Size(765, 182);
            this.dataGridHistorial.TabIndex = 118;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(511, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 44);
            this.button1.TabIndex = 119;
            this.button1.Text = "Pagar Servei";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bQR
            // 
            this.bQR.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bQR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQR.ForeColor = System.Drawing.Color.Black;
            this.bQR.Location = new System.Drawing.Point(647, 506);
            this.bQR.Name = "bQR";
            this.bQR.Size = new System.Drawing.Size(130, 44);
            this.bQR.TabIndex = 120;
            this.bQR.Text = "Codi QR";
            this.bQR.UseVisualStyleBackColor = false;
            this.bQR.Click += new System.EventHandler(this.bQR_Click);
            // 
            // ImageQR
            // 
            this.ImageQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageQR.Location = new System.Drawing.Point(337, 142);
            this.ImageQR.Name = "ImageQR";
            this.ImageQR.Size = new System.Drawing.Size(178, 171);
            this.ImageQR.TabIndex = 121;
            this.ImageQR.TabStop = false;
            this.ImageQR.Visible = false;
            // 
            // ConsultaServei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 563);
            this.Controls.Add(this.ImageQR);
            this.Controls.Add(this.bQR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridHistorial);
            this.Controls.Add(this.bCambiarEstado);
            this.Controls.Add(this.l_rol);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConsultaServei";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaServei";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adreçaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telèfonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDestinatariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adreçadestinatariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefondestinatariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiqrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_rol;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button bCambiarEstado;
        private System.Windows.Forms.DataGridView dataGridHistorial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bQR;
        private System.Windows.Forms.PictureBox ImageQR;
    }
}