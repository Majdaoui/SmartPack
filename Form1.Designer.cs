using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartPack
{
    partial class Form_alta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_via = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.porta = new System.Windows.Forms.TextBox();
            this.poblacio = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            this.cognoms = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.telephon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nom_via = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.planta = new System.Windows.Forms.TextBox();
            this.provincia = new System.Windows.Forms.Label();
            this.cp = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bRegistre = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.contrasenya = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.rol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.si = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Cuenta en SmartPack";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label3.Text = "DIN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dni
            // 
            this.dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dni.Location = new System.Drawing.Point(188, 225);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(199, 20);
            this.dni.TabIndex = 3;
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
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(188, 326);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(199, 20);
            this.textBox6.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(445, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cognoms";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // telefon
            // 
            this.telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefon.ForeColor = System.Drawing.Color.White;
            this.telefon.Location = new System.Drawing.Point(445, 225);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(128, 20);
            this.telefon.TabIndex = 1;
            this.telefon.Text = "Telèfon";
            this.telefon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cognoms
            // 
            this.cognoms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cognoms.Location = new System.Drawing.Point(578, 200);
            this.cognoms.Name = "cognoms";
            this.cognoms.Size = new System.Drawing.Size(199, 20);
            this.cognoms.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(445, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nom de la Via";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // telephon
            // 
            this.telephon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telephon.Location = new System.Drawing.Point(578, 225);
            this.telephon.MaxLength = 9;
            this.telephon.Name = "telephon";
            this.telephon.Size = new System.Drawing.Size(199, 20);
            this.telephon.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(445, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Planta";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nom_via
            // 
            this.nom_via.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom_via.Location = new System.Drawing.Point(578, 250);
            this.nom_via.Name = "nom_via";
            this.nom_via.Size = new System.Drawing.Size(199, 20);
            this.nom_via.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(445, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Codi Postal";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // planta
            // 
            this.planta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planta.Location = new System.Drawing.Point(578, 275);
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
            this.provincia.Size = new System.Drawing.Size(128, 20);
            this.provincia.TabIndex = 1;
            this.provincia.Text = "Provincia";
            this.provincia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cp
            // 
            this.cp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cp.Location = new System.Drawing.Point(578, 301);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(199, 20);
            this.cp.TabIndex = 3;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(578, 326);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(199, 20);
            this.textBox12.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(19, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 7);
            this.panel1.TabIndex = 2;
            // 
            // bRegistre
            // 
            this.bRegistre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bRegistre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bRegistre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bRegistre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegistre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistre.Location = new System.Drawing.Point(359, 429);
            this.bRegistre.Name = "bRegistre";
            this.bRegistre.Size = new System.Drawing.Size(96, 33);
            this.bRegistre.TabIndex = 4;
            this.bRegistre.Text = "Registrar";
            this.bRegistre.UseVisualStyleBackColor = true;
            this.bRegistre.Click += new System.EventHandler(this.bRegistre_Click);
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(578, 355);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(199, 20);
            this.textBox13.TabIndex = 8;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(188, 355);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(199, 20);
            this.textBox14.TabIndex = 9;
            // 
            // contrasenya
            // 
            this.contrasenya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.contrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenya.ForeColor = System.Drawing.Color.White;
            this.contrasenya.Location = new System.Drawing.Point(445, 355);
            this.contrasenya.Name = "contrasenya";
            this.contrasenya.Size = new System.Drawing.Size(128, 20);
            this.contrasenya.TabIndex = 6;
            this.contrasenya.Text = "Contrasenya";
            this.contrasenya.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(55, 355);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(128, 20);
            this.email.TabIndex = 7;
            this.email.Text = "Email";
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rol
            // 
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
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(54, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipus de compte: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // no
            // 
            this.no.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(645, 139);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(51, 33);
            this.no.TabIndex = 16;
            this.no.Text = "NO";
            this.no.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(446, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "És una empresa?";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // si
            // 
            this.si.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.si.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.si.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.si.Location = new System.Drawing.Point(594, 139);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(45, 33);
            this.si.TabIndex = 14;
            this.si.Text = "SI";
            this.si.UseVisualStyleBackColor = true;
            // 
            // Form_alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 517);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.si);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rol);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.contrasenya);
            this.Controls.Add(this.email);
            this.Controls.Add(this.bRegistre);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.porta);
            this.Controls.Add(this.provincia);
            this.Controls.Add(this.poblacio);
            this.Controls.Add(this.planta);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nom_via);
            this.Controls.Add(this.t_via);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telephon);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cognoms);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_alta";
            this.Text = "Formulari d\'alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nom;
        private Label label3;
        private TextBox dni;
        private Label label4;
        private TextBox t_via;
        private Label label5;
        private TextBox num;
        private Label label6;
        private TextBox porta;
        private Label poblacio;
        private TextBox textBox6;
        private Label label8;
        private Label telefon;
        private TextBox cognoms;
        private Label label10;
        private TextBox telephon;
        private Label label11;
        private TextBox nom_via;
        private Label label12;
        private TextBox planta;
        private Label provincia;
        private TextBox cp;
        private TextBox textBox12;
        private Panel panel1;
        private Button bRegistre;
        private TextBox textBox13;
        private TextBox textBox14;
        private Label contrasenya;
        private Label email;
        private ComboBox rol;
        private Label label7;
        private CheckBox no;
        private Label label16;
        private CheckBox si;
    }
}