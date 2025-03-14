using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartPack
{
    partial class Alta
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
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dni_c = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_via = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.porta = new System.Windows.Forms.TextBox();
            this.poblacio = new System.Windows.Forms.Label();
            this.poblacio_t = new System.Windows.Forms.TextBox();
            this.primer_cognom = new System.Windows.Forms.Label();
            this.cognom_p = new System.Windows.Forms.TextBox();
            this.n_via = new System.Windows.Forms.Label();
            this.lplanta = new System.Windows.Forms.Label();
            this.nom_via = new System.Windows.Forms.TextBox();
            this.lcp = new System.Windows.Forms.Label();
            this.planta = new System.Windows.Forms.TextBox();
            this.provincia = new System.Windows.Forms.Label();
            this.cp = new System.Windows.Forms.TextBox();
            this.provincia_t = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bRegistre = new System.Windows.Forms.Button();
            this.r_contrasenya = new System.Windows.Forms.TextBox();
            this.email_t = new System.Windows.Forms.TextBox();
            this.confirmarContrasena = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.rol = new System.Windows.Forms.ComboBox();
            this.l_rol = new System.Windows.Forms.Label();
            this.esEmpresa = new System.Windows.Forms.Label();
            this.cognom_s = new System.Windows.Forms.TextBox();
            this.segon_cognom = new System.Windows.Forms.Label();
            this.contrasenya_t = new System.Windows.Forms.TextBox();
            this.contrasenya = new System.Windows.Forms.Label();
            this.telephon = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.Label();
            this.observacions_t = new System.Windows.Forms.TextBox();
            this.observacions = new System.Windows.Forms.Label();
            this.no_t = new System.Windows.Forms.RadioButton();
            this.si_t = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(178, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(545, 75);
            this.title.TabIndex = 0;
            this.title.Text = "Crear compte";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nom
            // 
            this.nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom.Location = new System.Drawing.Point(188, 200);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(199, 20);
            this.nom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "DIN/NIE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dni_c
            // 
            this.dni_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dni_c.Location = new System.Drawing.Point(188, 225);
            this.dni_c.Name = "dni_c";
            this.dni_c.Size = new System.Drawing.Size(199, 20);
            this.dni_c.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipus de Via";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_via
            // 
            this.t_via.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_via.Location = new System.Drawing.Point(188, 250);
            this.t_via.Name = "t_via";
            this.t_via.Size = new System.Drawing.Size(199, 20);
            this.t_via.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Número";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num
            // 
            this.num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num.Location = new System.Drawing.Point(188, 275);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(199, 20);
            this.num.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Porta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // porta
            // 
            this.porta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.porta.Location = new System.Drawing.Point(188, 301);
            this.porta.Name = "porta";
            this.porta.Size = new System.Drawing.Size(199, 20);
            this.porta.TabIndex = 3;
            // 
            // poblacio
            // 
            this.poblacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.poblacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poblacio.ForeColor = System.Drawing.Color.White;
            this.poblacio.Location = new System.Drawing.Point(55, 326);
            this.poblacio.Name = "poblacio";
            this.poblacio.Size = new System.Drawing.Size(128, 20);
            this.poblacio.TabIndex = 1;
            this.poblacio.Text = "Població";
            this.poblacio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // poblacio_t
            // 
            this.poblacio_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poblacio_t.Location = new System.Drawing.Point(188, 326);
            this.poblacio_t.Name = "poblacio_t";
            this.poblacio_t.Size = new System.Drawing.Size(199, 20);
            this.poblacio_t.TabIndex = 3;
            // 
            // primer_cognom
            // 
            this.primer_cognom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.primer_cognom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primer_cognom.ForeColor = System.Drawing.Color.White;
            this.primer_cognom.Location = new System.Drawing.Point(445, 200);
            this.primer_cognom.Name = "primer_cognom";
            this.primer_cognom.Size = new System.Drawing.Size(171, 20);
            this.primer_cognom.TabIndex = 1;
            this.primer_cognom.Text = "Primer Cognom";
            this.primer_cognom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cognom_p
            // 
            this.cognom_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cognom_p.Location = new System.Drawing.Point(622, 200);
            this.cognom_p.Name = "cognom_p";
            this.cognom_p.Size = new System.Drawing.Size(199, 20);
            this.cognom_p.TabIndex = 3;
            // 
            // n_via
            // 
            this.n_via.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.n_via.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_via.ForeColor = System.Drawing.Color.White;
            this.n_via.Location = new System.Drawing.Point(445, 250);
            this.n_via.Name = "n_via";
            this.n_via.Size = new System.Drawing.Size(171, 20);
            this.n_via.TabIndex = 1;
            this.n_via.Text = "Nom de la Via";
            this.n_via.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lplanta
            // 
            this.lplanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.lplanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lplanta.ForeColor = System.Drawing.Color.White;
            this.lplanta.Location = new System.Drawing.Point(445, 275);
            this.lplanta.Name = "lplanta";
            this.lplanta.Size = new System.Drawing.Size(171, 20);
            this.lplanta.TabIndex = 1;
            this.lplanta.Text = "Planta";
            this.lplanta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nom_via
            // 
            this.nom_via.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom_via.Location = new System.Drawing.Point(622, 250);
            this.nom_via.Name = "nom_via";
            this.nom_via.Size = new System.Drawing.Size(199, 20);
            this.nom_via.TabIndex = 3;
            // 
            // lcp
            // 
            this.lcp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.lcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcp.ForeColor = System.Drawing.Color.White;
            this.lcp.Location = new System.Drawing.Point(445, 301);
            this.lcp.Name = "lcp";
            this.lcp.Size = new System.Drawing.Size(171, 20);
            this.lcp.TabIndex = 1;
            this.lcp.Text = "Codi Postal";
            this.lcp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // planta
            // 
            this.planta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planta.Location = new System.Drawing.Point(623, 275);
            this.planta.Name = "planta";
            this.planta.Size = new System.Drawing.Size(199, 20);
            this.planta.TabIndex = 3;
            // 
            // provincia
            // 
            this.provincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provincia.ForeColor = System.Drawing.Color.White;
            this.provincia.Location = new System.Drawing.Point(445, 326);
            this.provincia.Name = "provincia";
            this.provincia.Size = new System.Drawing.Size(171, 20);
            this.provincia.TabIndex = 1;
            this.provincia.Text = "Provincia";
            this.provincia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cp
            // 
            this.cp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cp.Location = new System.Drawing.Point(622, 301);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(199, 20);
            this.cp.TabIndex = 3;
            // 
            // provincia_t
            // 
            this.provincia_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.provincia_t.Location = new System.Drawing.Point(622, 326);
            this.provincia_t.Name = "provincia_t";
            this.provincia_t.Size = new System.Drawing.Size(199, 20);
            this.provincia_t.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(9, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 7);
            this.panel1.TabIndex = 2;
            // 
            // bRegistre
            // 
            this.bRegistre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bRegistre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bRegistre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bRegistre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bRegistre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegistre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistre.ForeColor = System.Drawing.Color.Black;
            this.bRegistre.Location = new System.Drawing.Point(347, 442);
            this.bRegistre.Name = "bRegistre";
            this.bRegistre.Size = new System.Drawing.Size(136, 44);
            this.bRegistre.TabIndex = 4;
            this.bRegistre.Text = "Registrar";
            this.bRegistre.UseVisualStyleBackColor = false;
            this.bRegistre.Click += new System.EventHandler(this.bRegistre_Click);
            // 
            // r_contrasenya
            // 
            this.r_contrasenya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r_contrasenya.Location = new System.Drawing.Point(622, 376);
            this.r_contrasenya.Name = "r_contrasenya";
            this.r_contrasenya.Size = new System.Drawing.Size(199, 20);
            this.r_contrasenya.TabIndex = 8;
            // 
            // email_t
            // 
            this.email_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_t.Location = new System.Drawing.Point(189, 351);
            this.email_t.Name = "email_t";
            this.email_t.Size = new System.Drawing.Size(199, 20);
            this.email_t.TabIndex = 9;
            // 
            // confirmarContrasena
            // 
            this.confirmarContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.confirmarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarContrasena.ForeColor = System.Drawing.Color.White;
            this.confirmarContrasena.Location = new System.Drawing.Point(445, 376);
            this.confirmarContrasena.Name = "confirmarContrasena";
            this.confirmarContrasena.Size = new System.Drawing.Size(171, 20);
            this.confirmarContrasena.TabIndex = 6;
            this.confirmarContrasena.Text = "Repetir Contrasenya";
            this.confirmarContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(55, 351);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(128, 20);
            this.email.TabIndex = 7;
            this.email.Text = "Email";
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rol
            // 
            this.rol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol.FormattingEnabled = true;
            this.rol.Items.AddRange(new object[] {
            "Administrador",
            "Transportista",
            "Client"});
            this.rol.Location = new System.Drawing.Point(188, 140);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(199, 26);
            this.rol.TabIndex = 12;
            this.rol.SelectedIndexChanged += new System.EventHandler(this.rol_SelectedIndexChanged);
            this.rol.DpiChangedAfterParent += new System.EventHandler(this.bRegistre_Click);
            // 
            // l_rol
            // 
            this.l_rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.l_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_rol.ForeColor = System.Drawing.Color.White;
            this.l_rol.Location = new System.Drawing.Point(54, 141);
            this.l_rol.Name = "l_rol";
            this.l_rol.Size = new System.Drawing.Size(128, 20);
            this.l_rol.TabIndex = 13;
            this.l_rol.Text = "Tipus de compte: ";
            this.l_rol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // esEmpresa
            // 
            this.esEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.esEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esEmpresa.ForeColor = System.Drawing.Color.White;
            this.esEmpresa.Location = new System.Drawing.Point(446, 146);
            this.esEmpresa.Name = "esEmpresa";
            this.esEmpresa.Size = new System.Drawing.Size(171, 20);
            this.esEmpresa.TabIndex = 15;
            this.esEmpresa.Text = "És una empresa?";
            this.esEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cognom_s
            // 
            this.cognom_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cognom_s.Location = new System.Drawing.Point(622, 225);
            this.cognom_s.Name = "cognom_s";
            this.cognom_s.Size = new System.Drawing.Size(199, 20);
            this.cognom_s.TabIndex = 18;
            // 
            // segon_cognom
            // 
            this.segon_cognom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.segon_cognom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segon_cognom.ForeColor = System.Drawing.Color.White;
            this.segon_cognom.Location = new System.Drawing.Point(445, 225);
            this.segon_cognom.Name = "segon_cognom";
            this.segon_cognom.Size = new System.Drawing.Size(171, 20);
            this.segon_cognom.TabIndex = 17;
            this.segon_cognom.Text = "Segon Cognom";
            this.segon_cognom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contrasenya_t
            // 
            this.contrasenya_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contrasenya_t.Location = new System.Drawing.Point(189, 376);
            this.contrasenya_t.Name = "contrasenya_t";
            this.contrasenya_t.Size = new System.Drawing.Size(199, 20);
            this.contrasenya_t.TabIndex = 20;
            // 
            // contrasenya
            // 
            this.contrasenya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.contrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenya.ForeColor = System.Drawing.Color.White;
            this.contrasenya.Location = new System.Drawing.Point(55, 376);
            this.contrasenya.Name = "contrasenya";
            this.contrasenya.Size = new System.Drawing.Size(128, 20);
            this.contrasenya.TabIndex = 19;
            this.contrasenya.Text = "Contrasenya";
            this.contrasenya.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // telephon
            // 
            this.telephon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telephon.Location = new System.Drawing.Point(622, 351);
            this.telephon.MaxLength = 9;
            this.telephon.Name = "telephon";
            this.telephon.Size = new System.Drawing.Size(199, 20);
            this.telephon.TabIndex = 22;
            // 
            // telefon
            // 
            this.telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefon.ForeColor = System.Drawing.Color.White;
            this.telefon.Location = new System.Drawing.Point(445, 351);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(171, 20);
            this.telefon.TabIndex = 21;
            this.telefon.Text = "Telèfon";
            this.telefon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // observacions_t
            // 
            this.observacions_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.observacions_t.Location = new System.Drawing.Point(188, 405);
            this.observacions_t.Name = "observacions_t";
            this.observacions_t.Size = new System.Drawing.Size(633, 20);
            this.observacions_t.TabIndex = 24;
            // 
            // observacions
            // 
            this.observacions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.observacions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacions.ForeColor = System.Drawing.Color.White;
            this.observacions.Location = new System.Drawing.Point(55, 405);
            this.observacions.Name = "observacions";
            this.observacions.Size = new System.Drawing.Size(128, 20);
            this.observacions.TabIndex = 23;
            this.observacions.Text = "Observacions";
            this.observacions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // no_t
            // 
            this.no_t.BackColor = System.Drawing.Color.Transparent;
            this.no_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_t.ForeColor = System.Drawing.Color.Black;
            this.no_t.Location = new System.Drawing.Point(695, 143);
            this.no_t.Name = "no_t";
            this.no_t.Size = new System.Drawing.Size(56, 24);
            this.no_t.TabIndex = 25;
            this.no_t.TabStop = true;
            this.no_t.Text = "NO";
            this.no_t.UseVisualStyleBackColor = false;
            // 
            // si_t
            // 
            this.si_t.BackColor = System.Drawing.Color.Transparent;
            this.si_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.si_t.ForeColor = System.Drawing.Color.Black;
            this.si_t.Location = new System.Drawing.Point(633, 143);
            this.si_t.Name = "si_t";
            this.si_t.Size = new System.Drawing.Size(56, 24);
            this.si_t.TabIndex = 26;
            this.si_t.TabStop = true;
            this.si_t.Text = "SI";
            this.si_t.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Alta
            // 
            this.AcceptButton = this.bRegistre;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::SmartPack.Properties.Resources.freepik__retouch__32632;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(843, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.si_t);
            this.Controls.Add(this.no_t);
            this.Controls.Add(this.observacions_t);
            this.Controls.Add(this.observacions);
            this.Controls.Add(this.telephon);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.contrasenya_t);
            this.Controls.Add(this.contrasenya);
            this.Controls.Add(this.cognom_s);
            this.Controls.Add(this.segon_cognom);
            this.Controls.Add(this.esEmpresa);
            this.Controls.Add(this.l_rol);
            this.Controls.Add(this.rol);
            this.Controls.Add(this.r_contrasenya);
            this.Controls.Add(this.email_t);
            this.Controls.Add(this.confirmarContrasena);
            this.Controls.Add(this.email);
            this.Controls.Add(this.bRegistre);
            this.Controls.Add(this.provincia_t);
            this.Controls.Add(this.poblacio_t);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.porta);
            this.Controls.Add(this.provincia);
            this.Controls.Add(this.poblacio);
            this.Controls.Add(this.planta);
            this.Controls.Add(this.num);
            this.Controls.Add(this.lcp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nom_via);
            this.Controls.Add(this.t_via);
            this.Controls.Add(this.lplanta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dni_c);
            this.Controls.Add(this.n_via);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cognom_p);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.primer_cognom);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.Name = "Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulari d\'alta";
            this.TransparencyKey = System.Drawing.Color.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private Label label2;
        private TextBox nom;
        private Label label3;
        private TextBox dni_c;
        private Label label4;
        private TextBox t_via;
        private Label label5;
        private TextBox num;
        private Label label6;
        private TextBox porta;
        private Label poblacio;
        private TextBox poblacio_t;
        private Label primer_cognom;
        private TextBox cognom_p;
        private Label n_via;
        private Label lplanta;
        private TextBox nom_via;
        private Label lcp;
        private TextBox planta;
        private Label provincia;
        private TextBox cp;
        private TextBox provincia_t;
        private Panel panel1;
        private Button bRegistre;
        private TextBox r_contrasenya;
        private TextBox email_t;
        private Label confirmarContrasena;
        private Label email;
        private ComboBox rol;
        private Label l_rol;
        private Label esEmpresa;
        private TextBox cognom_s;
        private Label segon_cognom;
        private TextBox contrasenya_t;
        private Label contrasenya;
        private TextBox telephon;
        private Label telefon;
        private TextBox observacions_t;
        private Label observacions;
        private RadioButton no_t;
        private RadioButton si_t;
        private PictureBox pictureBox1;
    }
}