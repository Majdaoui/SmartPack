namespace SmartPack.Forms
{
    partial class ModificarServei
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
            this.UpdateServei = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.u_provincia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.u_poblacio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.u_codipostal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.u_porta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.u_planta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.u_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.u_nomVia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.u_codiQR = new System.Windows.Forms.TextBox();
            this.qr = new System.Windows.Forms.Label();
            this.u_telefonDestinatari = new System.Windows.Forms.TextBox();
            this.tefdestinatari = new System.Windows.Forms.Label();
            this.u_tVia = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.Label();
            this.u_nomDestinatari = new System.Windows.Forms.TextBox();
            this.nomdestinatari = new System.Windows.Forms.Label();
            this.u_profunditat = new System.Windows.Forms.TextBox();
            this.l_profunditat = new System.Windows.Forms.Label();
            this.u_altura = new System.Windows.Forms.TextBox();
            this.l_altura = new System.Windows.Forms.Label();
            this.u_amplada = new System.Windows.Forms.TextBox();
            this.l_aplada = new System.Windows.Forms.Label();
            this.u_pes = new System.Windows.Forms.TextBox();
            this.l_pes = new System.Windows.Forms.Label();
            this.u_detall = new System.Windows.Forms.TextBox();
            this.l_detalls = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateServei
            // 
            this.UpdateServei.BackColor = System.Drawing.Color.AntiqueWhite;
            this.UpdateServei.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpdateServei.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UpdateServei.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UpdateServei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateServei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateServei.ForeColor = System.Drawing.Color.Black;
            this.UpdateServei.Location = new System.Drawing.Point(285, 519);
            this.UpdateServei.Name = "UpdateServei";
            this.UpdateServei.Size = new System.Drawing.Size(180, 44);
            this.UpdateServei.TabIndex = 124;
            this.UpdateServei.Text = "Actualitzar Servei";
            this.UpdateServei.UseVisualStyleBackColor = false;
            this.UpdateServei.Click += new System.EventHandler(this.UpdateServei_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 135);
            this.dataGridView1.TabIndex = 121;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(2, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 10);
            this.panel1.TabIndex = 120;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(142, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(463, 76);
            this.title.TabIndex = 119;
            this.title.Text = "Consultar Servei un Servei";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // u_provincia
            // 
            this.u_provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_provincia.Location = new System.Drawing.Point(561, 480);
            this.u_provincia.Name = "u_provincia";
            this.u_provincia.Size = new System.Drawing.Size(160, 20);
            this.u_provincia.TabIndex = 139;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(393, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 158;
            this.label9.Text = "Provincia";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_poblacio
            // 
            this.u_poblacio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_poblacio.Location = new System.Drawing.Point(561, 454);
            this.u_poblacio.Name = "u_poblacio";
            this.u_poblacio.Size = new System.Drawing.Size(160, 20);
            this.u_poblacio.TabIndex = 138;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(393, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 157;
            this.label8.Text = "Població";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_codipostal
            // 
            this.u_codipostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_codipostal.Location = new System.Drawing.Point(561, 428);
            this.u_codipostal.Name = "u_codipostal";
            this.u_codipostal.Size = new System.Drawing.Size(160, 20);
            this.u_codipostal.TabIndex = 137;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(393, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 156;
            this.label7.Text = "Codi Postal";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_porta
            // 
            this.u_porta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_porta.Location = new System.Drawing.Point(561, 402);
            this.u_porta.Name = "u_porta";
            this.u_porta.Size = new System.Drawing.Size(160, 20);
            this.u_porta.TabIndex = 136;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(393, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 155;
            this.label6.Text = "Porta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_planta
            // 
            this.u_planta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_planta.Location = new System.Drawing.Point(561, 376);
            this.u_planta.Name = "u_planta";
            this.u_planta.Size = new System.Drawing.Size(160, 20);
            this.u_planta.TabIndex = 135;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(393, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 154;
            this.label5.Text = "Planta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_num
            // 
            this.u_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_num.Location = new System.Drawing.Point(561, 350);
            this.u_num.Name = "u_num";
            this.u_num.Size = new System.Drawing.Size(160, 20);
            this.u_num.TabIndex = 134;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(393, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 153;
            this.label4.Text = "Numero";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_nomVia
            // 
            this.u_nomVia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_nomVia.Location = new System.Drawing.Point(561, 324);
            this.u_nomVia.Name = "u_nomVia";
            this.u_nomVia.Size = new System.Drawing.Size(160, 20);
            this.u_nomVia.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(393, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 152;
            this.label3.Text = "Nom de la via";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_codiQR
            // 
            this.u_codiQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_codiQR.Location = new System.Drawing.Point(225, 350);
            this.u_codiQR.Name = "u_codiQR";
            this.u_codiQR.Size = new System.Drawing.Size(160, 20);
            this.u_codiQR.TabIndex = 150;
            // 
            // qr
            // 
            this.qr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.qr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qr.ForeColor = System.Drawing.Color.White;
            this.qr.Location = new System.Drawing.Point(57, 350);
            this.qr.Name = "qr";
            this.qr.Size = new System.Drawing.Size(148, 20);
            this.qr.TabIndex = 151;
            this.qr.Text = "Codi QR";
            this.qr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_telefonDestinatari
            // 
            this.u_telefonDestinatari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_telefonDestinatari.Location = new System.Drawing.Point(225, 480);
            this.u_telefonDestinatari.Name = "u_telefonDestinatari";
            this.u_telefonDestinatari.Size = new System.Drawing.Size(160, 20);
            this.u_telefonDestinatari.TabIndex = 131;
            // 
            // tefdestinatari
            // 
            this.tefdestinatari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.tefdestinatari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tefdestinatari.ForeColor = System.Drawing.Color.White;
            this.tefdestinatari.Location = new System.Drawing.Point(57, 480);
            this.tefdestinatari.Name = "tefdestinatari";
            this.tefdestinatari.Size = new System.Drawing.Size(148, 20);
            this.tefdestinatari.TabIndex = 147;
            this.tefdestinatari.Text = "telefon Distinatari";
            this.tefdestinatari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_tVia
            // 
            this.u_tVia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_tVia.Location = new System.Drawing.Point(561, 298);
            this.u_tVia.Name = "u_tVia";
            this.u_tVia.Size = new System.Drawing.Size(160, 20);
            this.u_tVia.TabIndex = 132;
            // 
            // adress
            // 
            this.adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress.ForeColor = System.Drawing.Color.White;
            this.adress.Location = new System.Drawing.Point(393, 298);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(148, 20);
            this.adress.TabIndex = 146;
            this.adress.Text = "Tipus de via";
            this.adress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_nomDestinatari
            // 
            this.u_nomDestinatari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_nomDestinatari.Location = new System.Drawing.Point(225, 454);
            this.u_nomDestinatari.Name = "u_nomDestinatari";
            this.u_nomDestinatari.Size = new System.Drawing.Size(160, 20);
            this.u_nomDestinatari.TabIndex = 130;
            // 
            // nomdestinatari
            // 
            this.nomdestinatari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.nomdestinatari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomdestinatari.ForeColor = System.Drawing.Color.White;
            this.nomdestinatari.Location = new System.Drawing.Point(57, 454);
            this.nomdestinatari.Name = "nomdestinatari";
            this.nomdestinatari.Size = new System.Drawing.Size(148, 20);
            this.nomdestinatari.TabIndex = 145;
            this.nomdestinatari.Text = "Nom Destinatari";
            this.nomdestinatari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_profunditat
            // 
            this.u_profunditat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_profunditat.Location = new System.Drawing.Point(225, 402);
            this.u_profunditat.Name = "u_profunditat";
            this.u_profunditat.Size = new System.Drawing.Size(160, 20);
            this.u_profunditat.TabIndex = 129;
            // 
            // l_profunditat
            // 
            this.l_profunditat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.l_profunditat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_profunditat.ForeColor = System.Drawing.Color.White;
            this.l_profunditat.Location = new System.Drawing.Point(57, 402);
            this.l_profunditat.Name = "l_profunditat";
            this.l_profunditat.Size = new System.Drawing.Size(148, 20);
            this.l_profunditat.TabIndex = 144;
            this.l_profunditat.Text = "Profunditat en cm";
            this.l_profunditat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_altura
            // 
            this.u_altura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_altura.Location = new System.Drawing.Point(225, 376);
            this.u_altura.Name = "u_altura";
            this.u_altura.Size = new System.Drawing.Size(160, 20);
            this.u_altura.TabIndex = 127;
            // 
            // l_altura
            // 
            this.l_altura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.l_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_altura.ForeColor = System.Drawing.Color.White;
            this.l_altura.Location = new System.Drawing.Point(57, 376);
            this.l_altura.Name = "l_altura";
            this.l_altura.Size = new System.Drawing.Size(148, 20);
            this.l_altura.TabIndex = 143;
            this.l_altura.Text = "Altura en cm";
            this.l_altura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_amplada
            // 
            this.u_amplada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_amplada.Location = new System.Drawing.Point(225, 428);
            this.u_amplada.Name = "u_amplada";
            this.u_amplada.Size = new System.Drawing.Size(160, 20);
            this.u_amplada.TabIndex = 128;
            // 
            // l_aplada
            // 
            this.l_aplada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.l_aplada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_aplada.ForeColor = System.Drawing.Color.White;
            this.l_aplada.Location = new System.Drawing.Point(57, 428);
            this.l_aplada.Name = "l_aplada";
            this.l_aplada.Size = new System.Drawing.Size(148, 20);
            this.l_aplada.TabIndex = 142;
            this.l_aplada.Text = "Amplada en cm";
            this.l_aplada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_pes
            // 
            this.u_pes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_pes.Location = new System.Drawing.Point(225, 324);
            this.u_pes.Name = "u_pes";
            this.u_pes.Size = new System.Drawing.Size(160, 20);
            this.u_pes.TabIndex = 126;
            // 
            // l_pes
            // 
            this.l_pes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.l_pes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_pes.ForeColor = System.Drawing.Color.White;
            this.l_pes.Location = new System.Drawing.Point(57, 324);
            this.l_pes.Name = "l_pes";
            this.l_pes.Size = new System.Drawing.Size(148, 20);
            this.l_pes.TabIndex = 141;
            this.l_pes.Text = "Pes en grams";
            this.l_pes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // u_detall
            // 
            this.u_detall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_detall.Location = new System.Drawing.Point(225, 298);
            this.u_detall.Name = "u_detall";
            this.u_detall.Size = new System.Drawing.Size(160, 20);
            this.u_detall.TabIndex = 125;
            // 
            // l_detalls
            // 
            this.l_detalls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.l_detalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_detalls.ForeColor = System.Drawing.Color.White;
            this.l_detalls.Location = new System.Drawing.Point(57, 298);
            this.l_detalls.Name = "l_detalls";
            this.l_detalls.Size = new System.Drawing.Size(148, 20);
            this.l_detalls.TabIndex = 140;
            this.l_detalls.Text = "Detalls";
            this.l_detalls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbID
            // 
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbID.Location = new System.Drawing.Point(12, 298);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(35, 20);
            this.tbID.TabIndex = 159;
            this.tbID.Visible = false;
            // 
            // ModificarServei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(788, 579);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.u_provincia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.u_poblacio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.u_codipostal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.u_porta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.u_planta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.u_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.u_nomVia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.u_codiQR);
            this.Controls.Add(this.qr);
            this.Controls.Add(this.u_telefonDestinatari);
            this.Controls.Add(this.tefdestinatari);
            this.Controls.Add(this.u_tVia);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.u_nomDestinatari);
            this.Controls.Add(this.nomdestinatari);
            this.Controls.Add(this.u_profunditat);
            this.Controls.Add(this.l_profunditat);
            this.Controls.Add(this.u_altura);
            this.Controls.Add(this.l_altura);
            this.Controls.Add(this.u_amplada);
            this.Controls.Add(this.l_aplada);
            this.Controls.Add(this.u_pes);
            this.Controls.Add(this.l_pes);
            this.Controls.Add(this.u_detall);
            this.Controls.Add(this.l_detalls);
            this.Controls.Add(this.UpdateServei);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ModificarServei";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarServei";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateServei;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox u_provincia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox u_poblacio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox u_codipostal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox u_porta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox u_planta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox u_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox u_nomVia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox u_codiQR;
        private System.Windows.Forms.Label qr;
        private System.Windows.Forms.TextBox u_telefonDestinatari;
        private System.Windows.Forms.Label tefdestinatari;
        private System.Windows.Forms.TextBox u_tVia;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.TextBox u_nomDestinatari;
        private System.Windows.Forms.Label nomdestinatari;
        private System.Windows.Forms.TextBox u_profunditat;
        private System.Windows.Forms.Label l_profunditat;
        private System.Windows.Forms.TextBox u_altura;
        private System.Windows.Forms.Label l_altura;
        private System.Windows.Forms.TextBox u_amplada;
        private System.Windows.Forms.Label l_aplada;
        private System.Windows.Forms.TextBox u_pes;
        private System.Windows.Forms.Label l_pes;
        private System.Windows.Forms.TextBox u_detall;
        private System.Windows.Forms.Label l_detalls;
        private System.Windows.Forms.TextBox tbID;
    }
}