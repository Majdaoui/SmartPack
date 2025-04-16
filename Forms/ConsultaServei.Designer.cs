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
            this.bConsulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_rol = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.bCambiarEstado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // bConsulta
            // 
            this.bConsulta.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsulta.ForeColor = System.Drawing.Color.Black;
            this.bConsulta.Location = new System.Drawing.Point(12, 440);
            this.bConsulta.Name = "bConsulta";
            this.bConsulta.Size = new System.Drawing.Size(180, 44);
            this.bConsulta.TabIndex = 113;
            this.bConsulta.Text = "Consultar";
            this.bConsulta.UseVisualStyleBackColor = false;
            this.bConsulta.Click += new System.EventHandler(this.bConsulta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 240);
            this.dataGridView1.TabIndex = 114;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // l_rol
            // 
            this.l_rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.l_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_rol.ForeColor = System.Drawing.Color.White;
            this.l_rol.Location = new System.Drawing.Point(12, 389);
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
            this.cbEstado.Location = new System.Drawing.Point(144, 388);
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
            this.bCambiarEstado.Location = new System.Drawing.Point(597, 389);
            this.bCambiarEstado.Name = "bCambiarEstado";
            this.bCambiarEstado.Size = new System.Drawing.Size(180, 44);
            this.bCambiarEstado.TabIndex = 117;
            this.bCambiarEstado.Text = "Cambiar Estado";
            this.bCambiarEstado.UseVisualStyleBackColor = false;
            this.bCambiarEstado.Click += new System.EventHandler(this.bCambiarEstado_Click);
            // 
            // ConsultaServei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartPack.Properties.Resources.freepik__retouch__32632;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 506);
            this.Controls.Add(this.bCambiarEstado);
            this.Controls.Add(this.l_rol);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bConsulta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConsultaServei";
            this.Text = "ConsultaServei";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adreçaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telèfonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDestinatariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adreçadestinatariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefondestinatariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiqrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_rol;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button bCambiarEstado;
    }
}