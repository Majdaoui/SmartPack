namespace SmartPack.Forms
{
    partial class ServeisTransportistes
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
            this.dataGridViewServei = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTrans = new System.Windows.Forms.DataGridView();
            this.bAssignarServie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewServei
            // 
            this.dataGridViewServei.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewServei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServei.Location = new System.Drawing.Point(12, 132);
            this.dataGridViewServei.Name = "dataGridViewServei";
            this.dataGridViewServei.Size = new System.Drawing.Size(943, 150);
            this.dataGridViewServei.TabIndex = 0;
            this.dataGridViewServei.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServei_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 10);
            this.panel1.TabIndex = 114;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(141, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(834, 76);
            this.title.TabIndex = 113;
            this.title.Text = "Assignar Serveis a Transportista";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTrans
            // 
            this.dataGridViewTrans.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrans.Location = new System.Drawing.Point(12, 288);
            this.dataGridViewTrans.Name = "dataGridViewTrans";
            this.dataGridViewTrans.Size = new System.Drawing.Size(943, 150);
            this.dataGridViewTrans.TabIndex = 115;
            // 
            // bAssignarServie
            // 
            this.bAssignarServie.BackColor = System.Drawing.Color.Transparent;
            this.bAssignarServie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bAssignarServie.FlatAppearance.BorderSize = 5;
            this.bAssignarServie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bAssignarServie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bAssignarServie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAssignarServie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAssignarServie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bAssignarServie.Location = new System.Drawing.Point(817, 457);
            this.bAssignarServie.Name = "bAssignarServie";
            this.bAssignarServie.Size = new System.Drawing.Size(138, 45);
            this.bAssignarServie.TabIndex = 116;
            this.bAssignarServie.Text = "Assignar Servie";
            this.bAssignarServie.UseVisualStyleBackColor = false;
            this.bAssignarServie.Click += new System.EventHandler(this.bAssignarServie_Click);
            // 
            // ServeisTransportistes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 564);
            this.Controls.Add(this.bAssignarServie);
            this.Controls.Add(this.dataGridViewTrans);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewServei);
            this.Name = "ServeisTransportistes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServeisTransportistes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewServei;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewTrans;
        private System.Windows.Forms.Button bAssignarServie;
    }
}