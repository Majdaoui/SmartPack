namespace SmartPack.Forms
{
    partial class Facturacio
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tdata = new System.Windows.Forms.TextBox();
            this.tNumero = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tTotal_IVA = new System.Windows.Forms.TextBox();
            this.tDescripcio = new System.Windows.Forms.TextBox();
            this.tIVA = new System.Windows.Forms.TextBox();
            this.tTotal_u = new System.Windows.Forms.TextBox();
            this.tPreu = new System.Windows.Forms.TextBox();
            this.tCodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_data = new System.Windows.Forms.Label();
            this.l_numero = new System.Windows.Forms.Label();
            this.Dades_Client = new System.Windows.Forms.Label();
            this.Dades_Empresa = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel5.Location = new System.Drawing.Point(3, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(675, 7);
            this.panel5.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(3, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(163, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(349, 75);
            this.title.TabIndex = 32;
            this.title.Text = "Facturació";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tdata);
            this.groupBox1.Controls.Add(this.tNumero);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.l_data);
            this.groupBox1.Controls.Add(this.l_numero);
            this.groupBox1.Controls.Add(this.Dades_Client);
            this.groupBox1.Controls.Add(this.Dades_Empresa);
            this.groupBox1.Controls.Add(this.logo);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 444);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // tdata
            // 
            this.tdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tdata.Location = new System.Drawing.Point(157, 135);
            this.tdata.Multiline = true;
            this.tdata.Name = "tdata";
            this.tdata.Size = new System.Drawing.Size(122, 23);
            this.tdata.TabIndex = 21;
            // 
            // tNumero
            // 
            this.tNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tNumero.Location = new System.Drawing.Point(157, 107);
            this.tNumero.Multiline = true;
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(122, 24);
            this.tNumero.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tTotal_IVA);
            this.panel1.Controls.Add(this.tDescripcio);
            this.panel1.Controls.Add(this.tIVA);
            this.panel1.Controls.Add(this.tTotal_u);
            this.panel1.Controls.Add(this.tPreu);
            this.panel1.Controls.Add(this.tCodi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(24, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 277);
            this.panel1.TabIndex = 18;
            // 
            // tTotal_IVA
            // 
            this.tTotal_IVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tTotal_IVA.Location = new System.Drawing.Point(512, 235);
            this.tTotal_IVA.Multiline = true;
            this.tTotal_IVA.Name = "tTotal_IVA";
            this.tTotal_IVA.Size = new System.Drawing.Size(103, 31);
            this.tTotal_IVA.TabIndex = 26;
            // 
            // tDescripcio
            // 
            this.tDescripcio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tDescripcio.Location = new System.Drawing.Point(132, 41);
            this.tDescripcio.Multiline = true;
            this.tDescripcio.Name = "tDescripcio";
            this.tDescripcio.Size = new System.Drawing.Size(127, 40);
            this.tDescripcio.TabIndex = 25;
            // 
            // tIVA
            // 
            this.tIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tIVA.Location = new System.Drawing.Point(385, 41);
            this.tIVA.Multiline = true;
            this.tIVA.Name = "tIVA";
            this.tIVA.Size = new System.Drawing.Size(111, 40);
            this.tIVA.TabIndex = 24;
            // 
            // tTotal_u
            // 
            this.tTotal_u.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tTotal_u.Location = new System.Drawing.Point(496, 41);
            this.tTotal_u.Multiline = true;
            this.tTotal_u.Name = "tTotal_u";
            this.tTotal_u.Size = new System.Drawing.Size(119, 40);
            this.tTotal_u.TabIndex = 23;
            // 
            // tPreu
            // 
            this.tPreu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPreu.Location = new System.Drawing.Point(258, 41);
            this.tPreu.Multiline = true;
            this.tPreu.Name = "tPreu";
            this.tPreu.Size = new System.Drawing.Size(127, 40);
            this.tPreu.TabIndex = 21;
            // 
            // tCodi
            // 
            this.tCodi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tCodi.Location = new System.Drawing.Point(10, 41);
            this.tCodi.Multiline = true;
            this.tCodi.Name = "tCodi";
            this.tCodi.Size = new System.Drawing.Size(122, 40);
            this.tCodi.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.GhostWhite;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(385, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "IVA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(368, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Amb IVA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.GhostWhite;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(259, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(132, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripció";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(493, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Unitat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_data
            // 
            this.l_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_data.Location = new System.Drawing.Point(23, 135);
            this.l_data.Name = "l_data";
            this.l_data.Size = new System.Drawing.Size(128, 23);
            this.l_data.TabIndex = 11;
            this.l_data.Text = "Data: ";
            this.l_data.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_numero
            // 
            this.l_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_numero.Location = new System.Drawing.Point(23, 107);
            this.l_numero.Name = "l_numero";
            this.l_numero.Size = new System.Drawing.Size(128, 23);
            this.l_numero.TabIndex = 9;
            this.l_numero.Text = "Número: ";
            this.l_numero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Dades_Client
            // 
            this.Dades_Client.AllowDrop = true;
            this.Dades_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dades_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dades_Client.ForeColor = System.Drawing.Color.Navy;
            this.Dades_Client.Location = new System.Drawing.Point(371, 19);
            this.Dades_Client.Name = "Dades_Client";
            this.Dades_Client.Size = new System.Drawing.Size(283, 80);
            this.Dades_Client.TabIndex = 2;
            this.Dades_Client.UseCompatibleTextRendering = true;
            // 
            // Dades_Empresa
            // 
            this.Dades_Empresa.AllowDrop = true;
            this.Dades_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dades_Empresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dades_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dades_Empresa.ForeColor = System.Drawing.Color.Navy;
            this.Dades_Empresa.Location = new System.Drawing.Point(91, 16);
            this.Dades_Empresa.Name = "Dades_Empresa";
            this.Dades_Empresa.Size = new System.Drawing.Size(192, 80);
            this.Dades_Empresa.TabIndex = 1;
            this.Dades_Empresa.Text = "SmartPack \r\nNIF:  49459155R \r\nEmail: smartpack@smartpack.com\r\nTef.: 603207702\r\nAd" +
    "reça: Carrer Dom Bosco 146 \r\n              08224 Terrassa Barcelona\r\n";
            this.Dades_Empresa.UseCompatibleTextRendering = true;
            // 
            // logo
            // 
            this.logo.Image = global::SmartPack.Properties.Resources.logo_icono_blau;
            this.logo.Location = new System.Drawing.Point(17, 19);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(68, 68);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Facturacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Name = "Facturacio";
            this.Text = "Facturacio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label Dades_Empresa;
        private System.Windows.Forms.Label Dades_Client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_data;
        private System.Windows.Forms.Label l_numero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tCodi;
        private System.Windows.Forms.TextBox tTotal_u;
        private System.Windows.Forms.TextBox tPreu;
        private System.Windows.Forms.TextBox tdata;
        private System.Windows.Forms.TextBox tNumero;
        private System.Windows.Forms.TextBox tIVA;
        private System.Windows.Forms.TextBox tDescripcio;
        private System.Windows.Forms.TextBox tTotal_IVA;
    }
}