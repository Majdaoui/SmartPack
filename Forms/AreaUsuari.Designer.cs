namespace SmartPack.Forms
{
    partial class AreaUsuari
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
            this.observacions_usuari = new System.Windows.Forms.TextBox();
            this.observacions_u = new System.Windows.Forms.Label();
            this.telefon_usuari = new System.Windows.Forms.TextBox();
            this.telefon_u = new System.Windows.Forms.Label();
            this.cognom_s_usuari = new System.Windows.Forms.TextBox();
            this.s_cognom_u = new System.Windows.Forms.Label();
            this.email_usuari = new System.Windows.Forms.TextBox();
            this.email_u = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
            this.provincia_usuari = new System.Windows.Forms.TextBox();
            this.poblacio_usuari = new System.Windows.Forms.TextBox();
            this.cp_usuari = new System.Windows.Forms.TextBox();
            this.porta_usuari = new System.Windows.Forms.TextBox();
            this.provincia_u = new System.Windows.Forms.Label();
            this.poblacio_u = new System.Windows.Forms.Label();
            this.planta_usuari = new System.Windows.Forms.TextBox();
            this.num_usuari = new System.Windows.Forms.TextBox();
            this.lcp_u = new System.Windows.Forms.Label();
            this.porta_u = new System.Windows.Forms.Label();
            this.nom_via_usuari = new System.Windows.Forms.TextBox();
            this.t_via_usuari = new System.Windows.Forms.TextBox();
            this.lplanta_u = new System.Windows.Forms.Label();
            this.num_u = new System.Windows.Forms.Label();
            this.n_via_u = new System.Windows.Forms.Label();
            this.tvia_u = new System.Windows.Forms.Label();
            this.cognom_p_usuari = new System.Windows.Forms.TextBox();
            this.nom_usuari = new System.Windows.Forms.TextBox();
            this.p_cognom_u = new System.Windows.Forms.Label();
            this.nom_u = new System.Windows.Forms.Label();
            this.bDesactivar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Bcanvi_contrasenya = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(13, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 7);
            this.panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(16, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(182, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(545, 76);
            this.title.TabIndex = 28;
            this.title.Text = "Àrea Personal";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // observacions_usuari
            // 
            this.observacions_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.observacions_usuari.Location = new System.Drawing.Point(185, 328);
            this.observacions_usuari.Name = "observacions_usuari";
            this.observacions_usuari.Size = new System.Drawing.Size(199, 20);
            this.observacions_usuari.TabIndex = 66;
            this.observacions_usuari.TextChanged += new System.EventHandler(this.observacions_usuari_TextChanged);
            // 
            // observacions_u
            // 
            this.observacions_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.observacions_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacions_u.ForeColor = System.Drawing.Color.White;
            this.observacions_u.Location = new System.Drawing.Point(52, 328);
            this.observacions_u.Name = "observacions_u";
            this.observacions_u.Size = new System.Drawing.Size(128, 20);
            this.observacions_u.TabIndex = 65;
            this.observacions_u.Text = "Observacions";
            this.observacions_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // telefon_usuari
            // 
            this.telefon_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefon_usuari.Location = new System.Drawing.Point(606, 328);
            this.telefon_usuari.MaxLength = 9;
            this.telefon_usuari.Name = "telefon_usuari";
            this.telefon_usuari.Size = new System.Drawing.Size(199, 20);
            this.telefon_usuari.TabIndex = 64;
            // 
            // telefon_u
            // 
            this.telefon_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.telefon_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefon_u.ForeColor = System.Drawing.Color.White;
            this.telefon_u.Location = new System.Drawing.Point(429, 328);
            this.telefon_u.Name = "telefon_u";
            this.telefon_u.Size = new System.Drawing.Size(171, 20);
            this.telefon_u.TabIndex = 63;
            this.telefon_u.Text = "Telèfon";
            this.telefon_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cognom_s_usuari
            // 
            this.cognom_s_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cognom_s_usuari.Location = new System.Drawing.Point(606, 202);
            this.cognom_s_usuari.Name = "cognom_s_usuari";
            this.cognom_s_usuari.Size = new System.Drawing.Size(199, 20);
            this.cognom_s_usuari.TabIndex = 60;
            // 
            // s_cognom_u
            // 
            this.s_cognom_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.s_cognom_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_cognom_u.ForeColor = System.Drawing.Color.White;
            this.s_cognom_u.Location = new System.Drawing.Point(429, 202);
            this.s_cognom_u.Name = "s_cognom_u";
            this.s_cognom_u.Size = new System.Drawing.Size(171, 20);
            this.s_cognom_u.TabIndex = 59;
            this.s_cognom_u.Text = "Segon Cognom";
            this.s_cognom_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // email_usuari
            // 
            this.email_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_usuari.Location = new System.Drawing.Point(185, 303);
            this.email_usuari.Name = "email_usuari";
            this.email_usuari.Size = new System.Drawing.Size(199, 20);
            this.email_usuari.TabIndex = 57;
            // 
            // email_u
            // 
            this.email_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.email_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_u.ForeColor = System.Drawing.Color.White;
            this.email_u.Location = new System.Drawing.Point(51, 303);
            this.email_u.Name = "email_u";
            this.email_u.Size = new System.Drawing.Size(128, 20);
            this.email_u.TabIndex = 55;
            this.email_u.Text = "Email";
            this.email_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.email_u.Click += new System.EventHandler(this.email_u_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.ForeColor = System.Drawing.Color.Black;
            this.bGuardar.Location = new System.Drawing.Point(265, 439);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(136, 44);
            this.bGuardar.TabIndex = 53;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // provincia_usuari
            // 
            this.provincia_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.provincia_usuari.Location = new System.Drawing.Point(606, 303);
            this.provincia_usuari.Name = "provincia_usuari";
            this.provincia_usuari.Size = new System.Drawing.Size(199, 20);
            this.provincia_usuari.TabIndex = 50;
            // 
            // poblacio_usuari
            // 
            this.poblacio_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poblacio_usuari.Location = new System.Drawing.Point(184, 278);
            this.poblacio_usuari.Name = "poblacio_usuari";
            this.poblacio_usuari.Size = new System.Drawing.Size(199, 20);
            this.poblacio_usuari.TabIndex = 49;
            this.poblacio_usuari.TextChanged += new System.EventHandler(this.poblacio_usuari_TextChanged);
            // 
            // cp_usuari
            // 
            this.cp_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cp_usuari.Location = new System.Drawing.Point(606, 278);
            this.cp_usuari.Name = "cp_usuari";
            this.cp_usuari.Size = new System.Drawing.Size(199, 20);
            this.cp_usuari.TabIndex = 52;
            // 
            // porta_usuari
            // 
            this.porta_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.porta_usuari.Location = new System.Drawing.Point(184, 253);
            this.porta_usuari.Name = "porta_usuari";
            this.porta_usuari.Size = new System.Drawing.Size(199, 20);
            this.porta_usuari.TabIndex = 51;
            // 
            // provincia_u
            // 
            this.provincia_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.provincia_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provincia_u.ForeColor = System.Drawing.Color.White;
            this.provincia_u.Location = new System.Drawing.Point(429, 303);
            this.provincia_u.Name = "provincia_u";
            this.provincia_u.Size = new System.Drawing.Size(171, 20);
            this.provincia_u.TabIndex = 34;
            this.provincia_u.Text = "Provincia";
            this.provincia_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // poblacio_u
            // 
            this.poblacio_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.poblacio_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poblacio_u.ForeColor = System.Drawing.Color.White;
            this.poblacio_u.Location = new System.Drawing.Point(51, 278);
            this.poblacio_u.Name = "poblacio_u";
            this.poblacio_u.Size = new System.Drawing.Size(128, 20);
            this.poblacio_u.TabIndex = 35;
            this.poblacio_u.Text = "Població";
            this.poblacio_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // planta_usuari
            // 
            this.planta_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planta_usuari.Location = new System.Drawing.Point(607, 252);
            this.planta_usuari.Name = "planta_usuari";
            this.planta_usuari.Size = new System.Drawing.Size(199, 20);
            this.planta_usuari.TabIndex = 44;
            // 
            // num_usuari
            // 
            this.num_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_usuari.Location = new System.Drawing.Point(184, 227);
            this.num_usuari.Name = "num_usuari";
            this.num_usuari.Size = new System.Drawing.Size(199, 20);
            this.num_usuari.TabIndex = 43;
            // 
            // lcp_u
            // 
            this.lcp_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.lcp_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcp_u.ForeColor = System.Drawing.Color.White;
            this.lcp_u.Location = new System.Drawing.Point(429, 278);
            this.lcp_u.Name = "lcp_u";
            this.lcp_u.Size = new System.Drawing.Size(171, 20);
            this.lcp_u.TabIndex = 36;
            this.lcp_u.Text = "Codi Postal";
            this.lcp_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // porta_u
            // 
            this.porta_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.porta_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porta_u.ForeColor = System.Drawing.Color.White;
            this.porta_u.Location = new System.Drawing.Point(51, 253);
            this.porta_u.Name = "porta_u";
            this.porta_u.Size = new System.Drawing.Size(128, 20);
            this.porta_u.TabIndex = 31;
            this.porta_u.Text = "Porta";
            this.porta_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nom_via_usuari
            // 
            this.nom_via_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom_via_usuari.Location = new System.Drawing.Point(606, 227);
            this.nom_via_usuari.Name = "nom_via_usuari";
            this.nom_via_usuari.Size = new System.Drawing.Size(199, 20);
            this.nom_via_usuari.TabIndex = 48;
            // 
            // t_via_usuari
            // 
            this.t_via_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_via_usuari.Location = new System.Drawing.Point(184, 202);
            this.t_via_usuari.Name = "t_via_usuari";
            this.t_via_usuari.Size = new System.Drawing.Size(199, 20);
            this.t_via_usuari.TabIndex = 45;
            // 
            // lplanta_u
            // 
            this.lplanta_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.lplanta_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lplanta_u.ForeColor = System.Drawing.Color.White;
            this.lplanta_u.Location = new System.Drawing.Point(429, 252);
            this.lplanta_u.Name = "lplanta_u";
            this.lplanta_u.Size = new System.Drawing.Size(171, 20);
            this.lplanta_u.TabIndex = 32;
            this.lplanta_u.Text = "Planta";
            this.lplanta_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_u
            // 
            this.num_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.num_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_u.ForeColor = System.Drawing.Color.White;
            this.num_u.Location = new System.Drawing.Point(51, 227);
            this.num_u.Name = "num_u";
            this.num_u.Size = new System.Drawing.Size(128, 20);
            this.num_u.TabIndex = 33;
            this.num_u.Text = "Número";
            this.num_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // n_via_u
            // 
            this.n_via_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.n_via_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_via_u.ForeColor = System.Drawing.Color.White;
            this.n_via_u.Location = new System.Drawing.Point(429, 227);
            this.n_via_u.Name = "n_via_u";
            this.n_via_u.Size = new System.Drawing.Size(171, 20);
            this.n_via_u.TabIndex = 37;
            this.n_via_u.Text = "Nom de la Via";
            this.n_via_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tvia_u
            // 
            this.tvia_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.tvia_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvia_u.ForeColor = System.Drawing.Color.White;
            this.tvia_u.Location = new System.Drawing.Point(51, 202);
            this.tvia_u.Name = "tvia_u";
            this.tvia_u.Size = new System.Drawing.Size(128, 20);
            this.tvia_u.TabIndex = 40;
            this.tvia_u.Text = "Tipus de Via";
            this.tvia_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cognom_p_usuari
            // 
            this.cognom_p_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cognom_p_usuari.Location = new System.Drawing.Point(606, 177);
            this.cognom_p_usuari.Name = "cognom_p_usuari";
            this.cognom_p_usuari.Size = new System.Drawing.Size(199, 20);
            this.cognom_p_usuari.TabIndex = 46;
            // 
            // nom_usuari
            // 
            this.nom_usuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom_usuari.Location = new System.Drawing.Point(185, 176);
            this.nom_usuari.Name = "nom_usuari";
            this.nom_usuari.Size = new System.Drawing.Size(199, 20);
            this.nom_usuari.TabIndex = 47;
            // 
            // p_cognom_u
            // 
            this.p_cognom_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.p_cognom_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_cognom_u.ForeColor = System.Drawing.Color.White;
            this.p_cognom_u.Location = new System.Drawing.Point(429, 177);
            this.p_cognom_u.Name = "p_cognom_u";
            this.p_cognom_u.Size = new System.Drawing.Size(171, 20);
            this.p_cognom_u.TabIndex = 38;
            this.p_cognom_u.Text = "Primer Cognom";
            this.p_cognom_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nom_u
            // 
            this.nom_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.nom_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_u.ForeColor = System.Drawing.Color.White;
            this.nom_u.Location = new System.Drawing.Point(52, 176);
            this.nom_u.Name = "nom_u";
            this.nom_u.Size = new System.Drawing.Size(128, 20);
            this.nom_u.TabIndex = 41;
            this.nom_u.Text = "Nom";
            this.nom_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bDesactivar
            // 
            this.bDesactivar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bDesactivar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bDesactivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bDesactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDesactivar.ForeColor = System.Drawing.Color.Black;
            this.bDesactivar.Location = new System.Drawing.Point(429, 439);
            this.bDesactivar.Name = "bDesactivar";
            this.bDesactivar.Size = new System.Drawing.Size(179, 44);
            this.bDesactivar.TabIndex = 68;
            this.bDesactivar.Text = "Disactivar Compta";
            this.bDesactivar.UseVisualStyleBackColor = false;
            this.bDesactivar.Click += new System.EventHandler(this.bDesactivar_Click);
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
            this.button1.Location = new System.Drawing.Point(636, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 44);
            this.button1.TabIndex = 76;
            this.button1.Text = "Vehicle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bcanvi_contrasenya
            // 
            this.Bcanvi_contrasenya.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Bcanvi_contrasenya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bcanvi_contrasenya.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Bcanvi_contrasenya.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Bcanvi_contrasenya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcanvi_contrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcanvi_contrasenya.ForeColor = System.Drawing.Color.Black;
            this.Bcanvi_contrasenya.Location = new System.Drawing.Point(37, 439);
            this.Bcanvi_contrasenya.Name = "Bcanvi_contrasenya";
            this.Bcanvi_contrasenya.Size = new System.Drawing.Size(191, 44);
            this.Bcanvi_contrasenya.TabIndex = 69;
            this.Bcanvi_contrasenya.Text = "Canviar Contrasenya";
            this.Bcanvi_contrasenya.UseVisualStyleBackColor = false;
            this.Bcanvi_contrasenya.Click += new System.EventHandler(this.Bcanvi_contrasenya_Click_1);
            // 
            // AreaUsuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartPack.Properties.Resources.freepik__retouch__32632;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bcanvi_contrasenya);
            this.Controls.Add(this.bDesactivar);
            this.Controls.Add(this.observacions_usuari);
            this.Controls.Add(this.observacions_u);
            this.Controls.Add(this.telefon_usuari);
            this.Controls.Add(this.telefon_u);
            this.Controls.Add(this.cognom_s_usuari);
            this.Controls.Add(this.s_cognom_u);
            this.Controls.Add(this.email_usuari);
            this.Controls.Add(this.email_u);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.provincia_usuari);
            this.Controls.Add(this.poblacio_usuari);
            this.Controls.Add(this.cp_usuari);
            this.Controls.Add(this.porta_usuari);
            this.Controls.Add(this.provincia_u);
            this.Controls.Add(this.poblacio_u);
            this.Controls.Add(this.planta_usuari);
            this.Controls.Add(this.num_usuari);
            this.Controls.Add(this.lcp_u);
            this.Controls.Add(this.porta_u);
            this.Controls.Add(this.nom_via_usuari);
            this.Controls.Add(this.t_via_usuari);
            this.Controls.Add(this.lplanta_u);
            this.Controls.Add(this.num_u);
            this.Controls.Add(this.n_via_u);
            this.Controls.Add(this.tvia_u);
            this.Controls.Add(this.cognom_p_usuari);
            this.Controls.Add(this.nom_usuari);
            this.Controls.Add(this.p_cognom_u);
            this.Controls.Add(this.nom_u);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Name = "AreaUsuari";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AreaUsuari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox observacions_usuari;
        private System.Windows.Forms.Label observacions_u;
        private System.Windows.Forms.TextBox telefon_usuari;
        private System.Windows.Forms.Label telefon_u;
        private System.Windows.Forms.TextBox cognom_s_usuari;
        private System.Windows.Forms.Label s_cognom_u;
        private System.Windows.Forms.TextBox email_usuari;
        private System.Windows.Forms.Label email_u;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox provincia_usuari;
        private System.Windows.Forms.TextBox poblacio_usuari;
        private System.Windows.Forms.TextBox cp_usuari;
        private System.Windows.Forms.TextBox porta_usuari;
        private System.Windows.Forms.Label provincia_u;
        private System.Windows.Forms.Label poblacio_u;
        private System.Windows.Forms.TextBox planta_usuari;
        private System.Windows.Forms.TextBox num_usuari;
        private System.Windows.Forms.Label lcp_u;
        private System.Windows.Forms.Label porta_u;
        private System.Windows.Forms.TextBox nom_via_usuari;
        private System.Windows.Forms.TextBox t_via_usuari;
        private System.Windows.Forms.Label lplanta_u;
        private System.Windows.Forms.Label num_u;
        private System.Windows.Forms.Label n_via_u;
        private System.Windows.Forms.Label tvia_u;
        private System.Windows.Forms.TextBox cognom_p_usuari;
        private System.Windows.Forms.TextBox nom_usuari;
        private System.Windows.Forms.Label p_cognom_u;
        private System.Windows.Forms.Label nom_u;
        private System.Windows.Forms.Button bDesactivar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bcanvi_contrasenya;
    }
}