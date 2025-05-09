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
            this.bGenerarF = new System.Windows.Forms.Button();
            this.bQR = new System.Windows.Forms.Button();
            this.ImageQR = new System.Windows.Forms.PictureBox();
            this.bEtiqueta = new System.Windows.Forms.Button();
            this.ImageLabel = new System.Windows.Forms.PictureBox();
            this.printEtiqueta = new System.Drawing.Printing.PrintDocument();
            this.bPrint = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLabel)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1008, 10);
            this.panel1.TabIndex = 111;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(159, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(619, 76);
            this.title.TabIndex = 110;
            this.title.Text = "Consultar Servei ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 209);
            this.dataGridView1.TabIndex = 114;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // l_rol
            // 
            this.l_rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.l_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_rol.ForeColor = System.Drawing.Color.White;
            this.l_rol.Location = new System.Drawing.Point(10, 538);
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
            this.cbEstado.Location = new System.Drawing.Point(142, 537);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(179, 26);
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
            this.bCambiarEstado.Location = new System.Drawing.Point(327, 527);
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
            this.dataGridHistorial.Location = new System.Drawing.Point(12, 357);
            this.dataGridHistorial.Name = "dataGridHistorial";
            this.dataGridHistorial.Size = new System.Drawing.Size(749, 164);
            this.dataGridHistorial.TabIndex = 118;
            // 
            // bGenerarF
            // 
            this.bGenerarF.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bGenerarF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bGenerarF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bGenerarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bGenerarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGenerarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGenerarF.ForeColor = System.Drawing.Color.Black;
            this.bGenerarF.Location = new System.Drawing.Point(466, 527);
            this.bGenerarF.Name = "bGenerarF";
            this.bGenerarF.Size = new System.Drawing.Size(130, 44);
            this.bGenerarF.TabIndex = 119;
            this.bGenerarF.Text = "Generar Factura";
            this.bGenerarF.UseVisualStyleBackColor = false;
            this.bGenerarF.Click += new System.EventHandler(this.bGenerarF_Click);
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
            this.bQR.Location = new System.Drawing.Point(602, 527);
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
            this.ImageQR.Location = new System.Drawing.Point(767, 122);
            this.ImageQR.Name = "ImageQR";
            this.ImageQR.Size = new System.Drawing.Size(243, 254);
            this.ImageQR.TabIndex = 121;
            this.ImageQR.TabStop = false;
            this.ImageQR.Visible = false;
            this.ImageQR.DoubleClick += new System.EventHandler(this.ImageQR_DoubleClick);
            // 
            // bEtiqueta
            // 
            this.bEtiqueta.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bEtiqueta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bEtiqueta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bEtiqueta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bEtiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEtiqueta.ForeColor = System.Drawing.Color.Black;
            this.bEtiqueta.Location = new System.Drawing.Point(738, 527);
            this.bEtiqueta.Name = "bEtiqueta";
            this.bEtiqueta.Size = new System.Drawing.Size(109, 44);
            this.bEtiqueta.TabIndex = 122;
            this.bEtiqueta.Text = "Etiqueta";
            this.bEtiqueta.UseVisualStyleBackColor = false;
            this.bEtiqueta.Click += new System.EventHandler(this.bEtiqueta_Click);
            // 
            // ImageLabel
            // 
            this.ImageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageLabel.Location = new System.Drawing.Point(303, 227);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(243, 254);
            this.ImageLabel.TabIndex = 123;
            this.ImageLabel.TabStop = false;
            this.ImageLabel.Visible = false;
            this.ImageLabel.DoubleClick += new System.EventHandler(this.ImageLabel_DoubleClick);
            // 
            // bPrint
            // 
            this.bPrint.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrint.ForeColor = System.Drawing.Color.Black;
            this.bPrint.Location = new System.Drawing.Point(738, 576);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(109, 44);
            this.bPrint.TabIndex = 124;
            this.bPrint.Text = "Imprimir";
            this.bPrint.UseVisualStyleBackColor = false;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.ForeColor = System.Drawing.Color.Black;
            this.bDelete.Location = new System.Drawing.Point(602, 577);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(130, 44);
            this.bDelete.TabIndex = 125;
            this.bDelete.Text = "Eliminar Servei";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // ConsultaServei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 646);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.bEtiqueta);
            this.Controls.Add(this.ImageQR);
            this.Controls.Add(this.bQR);
            this.Controls.Add(this.bGenerarF);
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
            ((System.ComponentModel.ISupportInitialize)(this.ImageLabel)).EndInit();
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
        private System.Windows.Forms.Button bGenerarF;
        private System.Windows.Forms.Button bQR;
        private System.Windows.Forms.PictureBox ImageQR;
        private System.Windows.Forms.Button bEtiqueta;
        private System.Windows.Forms.PictureBox ImageLabel;
        private System.Drawing.Printing.PrintDocument printEtiqueta;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Button bDelete;
    }
}