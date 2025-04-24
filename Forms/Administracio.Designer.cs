using System.Windows.Forms;

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
            this.label2 = new System.Windows.Forms.Label();
            this.NOM_T = new System.Windows.Forms.Label();
            this.COGNOMS_T = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lIDEmpresa = new System.Windows.Forms.Label();
            this.lIDUser = new System.Windows.Forms.Label();
            this.TELEFON_T = new System.Windows.Forms.TextBox();
            this.EMAIL_T = new System.Windows.Forms.TextBox();
            this.lTipusdeCompte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bAltaEmpresa = new System.Windows.Forms.Button();
            this.bDesactivarUser = new System.Windows.Forms.Button();
            this.bModificarUsuari = new System.Windows.Forms.Button();
            this.bServeis = new System.Windows.Forms.Button();
            this.bTransportistes = new System.Windows.Forms.Button();
            this.bVehicles = new System.Windows.Forms.Button();
            this.bFactures = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.assignar_u.Location = new System.Drawing.Point(184, 627);
            this.assignar_u.Name = "assignar_u";
            this.assignar_u.Size = new System.Drawing.Size(164, 45);
            this.assignar_u.TabIndex = 22;
            this.assignar_u.Text = "Assignar un usuari a una empresa";
            this.assignar_u.UseVisualStyleBackColor = false;
            this.assignar_u.Visible = false;
            this.assignar_u.Click += new System.EventHandler(this.assignar_u_Click);
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
            this.desassignar_u.Location = new System.Drawing.Point(12, 628);
            this.desassignar_u.Name = "desassignar_u";
            this.desassignar_u.Size = new System.Drawing.Size(164, 44);
            this.desassignar_u.TabIndex = 25;
            this.desassignar_u.Text = "Desassignar usuari a empresa";
            this.desassignar_u.UseVisualStyleBackColor = false;
            this.desassignar_u.Visible = false;
            this.desassignar_u.Click += new System.EventHandler(this.desassignar_u_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listUsauris);
            this.panel1.Controls.Add(this.usuari_a);
            this.panel1.Controls.Add(this.llist_u);
            this.panel1.Location = new System.Drawing.Point(372, 197);
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
            this.listUsauris.SelectedIndexChanged += new System.EventHandler(this.listUsauris_SelectedIndexChanged);
            // 
            // usuari_a
            // 
            this.usuari_a.AutoSize = true;
            this.usuari_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuari_a.Location = new System.Drawing.Point(68, 10);
            this.usuari_a.Name = "usuari_a";
            this.usuari_a.Size = new System.Drawing.Size(131, 18);
            this.usuari_a.TabIndex = 25;
            this.usuari_a.Text = "Gestió d\'usuaris";
            this.usuari_a.Click += new System.EventHandler(this.usuari_a_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listEmpreses);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.list_e);
            this.panel2.Location = new System.Drawing.Point(647, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 352);
            this.panel2.TabIndex = 28;
            // 
            // listEmpreses
            // 
            this.listEmpreses.FormattingEnabled = true;
            this.listEmpreses.Location = new System.Drawing.Point(8, 86);
            this.listEmpreses.Name = "listEmpreses";
            this.listEmpreses.Size = new System.Drawing.Size(263, 251);
            this.listEmpreses.TabIndex = 32;
            this.listEmpreses.SelectedIndexChanged += new System.EventHandler(this.listEmpreses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 10);
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
            this.list_e.Size = new System.Drawing.Size(261, 31);
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
            this.desctivate_e.Location = new System.Drawing.Point(423, 576);
            this.desctivate_e.Name = "desctivate_e";
            this.desctivate_e.Size = new System.Drawing.Size(164, 44);
            this.desctivate_e.TabIndex = 29;
            this.desctivate_e.Text = "Desactivar Empresa";
            this.desctivate_e.UseVisualStyleBackColor = false;
            this.desctivate_e.Visible = false;
            this.desctivate_e.Click += new System.EventHandler(this.desctivate_e_Click);
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
            this.update_e.Location = new System.Drawing.Point(593, 576);
            this.update_e.Name = "update_e";
            this.update_e.Size = new System.Drawing.Size(164, 45);
            this.update_e.TabIndex = 28;
            this.update_e.Text = "Modificar Empresa";
            this.update_e.UseVisualStyleBackColor = false;
            this.update_e.Visible = false;
            this.update_e.Click += new System.EventHandler(this.update_e_Click);
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nom";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NOM_T
            // 
            this.NOM_T.BackColor = System.Drawing.Color.Transparent;
            this.NOM_T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NOM_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_T.Location = new System.Drawing.Point(161, 88);
            this.NOM_T.Name = "NOM_T";
            this.NOM_T.Size = new System.Drawing.Size(174, 30);
            this.NOM_T.TabIndex = 33;
            this.NOM_T.Text = "...";
            this.NOM_T.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // COGNOMS_T
            // 
            this.COGNOMS_T.BackColor = System.Drawing.Color.Transparent;
            this.COGNOMS_T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.COGNOMS_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COGNOMS_T.Location = new System.Drawing.Point(161, 119);
            this.COGNOMS_T.Name = "COGNOMS_T";
            this.COGNOMS_T.Size = new System.Drawing.Size(174, 30);
            this.COGNOMS_T.TabIndex = 35;
            this.COGNOMS_T.Text = "...";
            this.COGNOMS_T.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 30);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cognoms";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lIDEmpresa);
            this.panel3.Controls.Add(this.lIDUser);
            this.panel3.Controls.Add(this.TELEFON_T);
            this.panel3.Controls.Add(this.EMAIL_T);
            this.panel3.Controls.Add(this.lTipusdeCompte);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.COGNOMS_T);
            this.panel3.Controls.Add(this.NOM_T);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 352);
            this.panel3.TabIndex = 36;
            // 
            // lIDEmpresa
            // 
            this.lIDEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lIDEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIDEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDEmpresa.Location = new System.Drawing.Point(169, 10);
            this.lIDEmpresa.Name = "lIDEmpresa";
            this.lIDEmpresa.Size = new System.Drawing.Size(166, 30);
            this.lIDEmpresa.TabIndex = 47;
            this.lIDEmpresa.Text = "ID";
            this.lIDEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lIDEmpresa.Visible = false;
            // 
            // lIDUser
            // 
            this.lIDUser.BackColor = System.Drawing.Color.Transparent;
            this.lIDUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIDUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDUser.Location = new System.Drawing.Point(6, 10);
            this.lIDUser.Name = "lIDUser";
            this.lIDUser.Size = new System.Drawing.Size(157, 30);
            this.lIDUser.TabIndex = 46;
            this.lIDUser.Text = "ID";
            this.lIDUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lIDUser.Visible = false;
            // 
            // TELEFON_T
            // 
            this.TELEFON_T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TELEFON_T.Location = new System.Drawing.Point(161, 185);
            this.TELEFON_T.Name = "TELEFON_T";
            this.TELEFON_T.Size = new System.Drawing.Size(174, 20);
            this.TELEFON_T.TabIndex = 45;
            // 
            // EMAIL_T
            // 
            this.EMAIL_T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EMAIL_T.Location = new System.Drawing.Point(161, 157);
            this.EMAIL_T.Name = "EMAIL_T";
            this.EMAIL_T.Size = new System.Drawing.Size(174, 20);
            this.EMAIL_T.TabIndex = 44;
            // 
            // lTipusdeCompte
            // 
            this.lTipusdeCompte.BackColor = System.Drawing.Color.Transparent;
            this.lTipusdeCompte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lTipusdeCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipusdeCompte.Location = new System.Drawing.Point(161, 57);
            this.lTipusdeCompte.Name = "lTipusdeCompte";
            this.lTipusdeCompte.Size = new System.Drawing.Size(174, 30);
            this.lTipusdeCompte.TabIndex = 43;
            this.lTipusdeCompte.Text = "...";
            this.lTipusdeCompte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 30);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tipus de Compte";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 30);
            this.label8.TabIndex = 38;
            this.label8.Text = "Telèfon";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 30);
            this.label6.TabIndex = 36;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bAltaEmpresa
            // 
            this.bAltaEmpresa.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bAltaEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bAltaEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bAltaEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bAltaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAltaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAltaEmpresa.ForeColor = System.Drawing.Color.Black;
            this.bAltaEmpresa.Location = new System.Drawing.Point(763, 576);
            this.bAltaEmpresa.Name = "bAltaEmpresa";
            this.bAltaEmpresa.Size = new System.Drawing.Size(164, 45);
            this.bAltaEmpresa.TabIndex = 37;
            this.bAltaEmpresa.Text = "Alta Empresa";
            this.bAltaEmpresa.UseVisualStyleBackColor = false;
            this.bAltaEmpresa.Click += new System.EventHandler(this.bAltaEmpresa_Click);
            // 
            // bDesactivarUser
            // 
            this.bDesactivarUser.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bDesactivarUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bDesactivarUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bDesactivarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bDesactivarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDesactivarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDesactivarUser.ForeColor = System.Drawing.Color.Black;
            this.bDesactivarUser.Location = new System.Drawing.Point(184, 576);
            this.bDesactivarUser.Name = "bDesactivarUser";
            this.bDesactivarUser.Size = new System.Drawing.Size(164, 45);
            this.bDesactivarUser.TabIndex = 39;
            this.bDesactivarUser.Text = "Desactivar Usuari";
            this.bDesactivarUser.UseVisualStyleBackColor = false;
            this.bDesactivarUser.Visible = false;
            this.bDesactivarUser.Click += new System.EventHandler(this.bDesactivarUser_Click);
            // 
            // bModificarUsuari
            // 
            this.bModificarUsuari.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bModificarUsuari.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bModificarUsuari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bModificarUsuari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bModificarUsuari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModificarUsuari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificarUsuari.ForeColor = System.Drawing.Color.Black;
            this.bModificarUsuari.Location = new System.Drawing.Point(12, 576);
            this.bModificarUsuari.Name = "bModificarUsuari";
            this.bModificarUsuari.Size = new System.Drawing.Size(164, 45);
            this.bModificarUsuari.TabIndex = 38;
            this.bModificarUsuari.Text = "Modificar Usuari";
            this.bModificarUsuari.UseVisualStyleBackColor = false;
            this.bModificarUsuari.Visible = false;
            this.bModificarUsuari.Click += new System.EventHandler(this.bModificarUsuari_Click);
            // 
            // bServeis
            // 
            this.bServeis.BackColor = System.Drawing.Color.Transparent;
            this.bServeis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bServeis.FlatAppearance.BorderSize = 5;
            this.bServeis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bServeis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bServeis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bServeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bServeis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bServeis.Location = new System.Drawing.Point(12, 139);
            this.bServeis.Name = "bServeis";
            this.bServeis.Size = new System.Drawing.Size(186, 45);
            this.bServeis.TabIndex = 40;
            this.bServeis.Text = "Serveis";
            this.bServeis.UseVisualStyleBackColor = false;
            this.bServeis.Click += new System.EventHandler(this.bServeis_Click);
            // 
            // bTransportistes
            // 
            this.bTransportistes.BackColor = System.Drawing.Color.Transparent;
            this.bTransportistes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bTransportistes.FlatAppearance.BorderSize = 5;
            this.bTransportistes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bTransportistes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bTransportistes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bTransportistes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTransportistes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bTransportistes.Location = new System.Drawing.Point(204, 139);
            this.bTransportistes.Name = "bTransportistes";
            this.bTransportistes.Size = new System.Drawing.Size(186, 45);
            this.bTransportistes.TabIndex = 40;
            this.bTransportistes.Text = "Transportistes";
            this.bTransportistes.UseVisualStyleBackColor = false;
            // 
            // bVehicles
            // 
            this.bVehicles.BackColor = System.Drawing.Color.Transparent;
            this.bVehicles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bVehicles.FlatAppearance.BorderSize = 5;
            this.bVehicles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bVehicles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bVehicles.Location = new System.Drawing.Point(396, 139);
            this.bVehicles.Name = "bVehicles";
            this.bVehicles.Size = new System.Drawing.Size(186, 45);
            this.bVehicles.TabIndex = 40;
            this.bVehicles.Text = "Vehicles";
            this.bVehicles.UseVisualStyleBackColor = false;
            this.bVehicles.Click += new System.EventHandler(this.bVehicles_Click);
            // 
            // bFactures
            // 
            this.bFactures.BackColor = System.Drawing.Color.Transparent;
            this.bFactures.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bFactures.FlatAppearance.BorderSize = 5;
            this.bFactures.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bFactures.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bFactures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bFactures.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFactures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bFactures.Location = new System.Drawing.Point(588, 139);
            this.bFactures.Name = "bFactures";
            this.bFactures.Size = new System.Drawing.Size(186, 45);
            this.bFactures.TabIndex = 40;
            this.bFactures.Text = "Factures";
            this.bFactures.UseVisualStyleBackColor = false;
            // 
            // Administracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.bFactures);
            this.Controls.Add(this.bVehicles);
            this.Controls.Add(this.bTransportistes);
            this.Controls.Add(this.bServeis);
            this.Controls.Add(this.bDesactivarUser);
            this.Controls.Add(this.bModificarUsuari);
            this.Controls.Add(this.bAltaEmpresa);
            this.Controls.Add(this.panel3);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        public System.Windows.Forms.ListBox listEmpreses;
        public System.Windows.Forms.ListBox listUsauris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NOM_T;
        private System.Windows.Forms.Label COGNOMS_T;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lTipusdeCompte;
        private System.Windows.Forms.TextBox EMAIL_T;
        private System.Windows.Forms.TextBox TELEFON_T;
        private System.Windows.Forms.Label lIDUser;
        private Button bAltaEmpresa;
        private Button bDesactivarUser;
        private Button bModificarUsuari;
        private Label lIDEmpresa;
        private Button bServeis;
        private Button bTransportistes;
        private Button bVehicles;
        private Button bFactures;
        //public ListBox LlistaEmpreses => listEmpreses;
    }
}