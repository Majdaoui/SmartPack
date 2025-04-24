namespace SmartPack.Forms
{
    partial class Vehicles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.desctivate_vehicle = new System.Windows.Forms.Button();
            this.bCrearVehicle = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.update_v = new System.Windows.Forms.Button();
            this.t_matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_marca = new System.Windows.Forms.TextBox();
            this.nom_u = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 117);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // desctivate_vehicle
            // 
            this.desctivate_vehicle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.desctivate_vehicle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.desctivate_vehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.desctivate_vehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.desctivate_vehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desctivate_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desctivate_vehicle.ForeColor = System.Drawing.Color.Black;
            this.desctivate_vehicle.Location = new System.Drawing.Point(240, 347);
            this.desctivate_vehicle.Name = "desctivate_vehicle";
            this.desctivate_vehicle.Size = new System.Drawing.Size(179, 44);
            this.desctivate_vehicle.TabIndex = 30;
            this.desctivate_vehicle.Text = "Desactivar Vehicle";
            this.desctivate_vehicle.UseVisualStyleBackColor = false;
            this.desctivate_vehicle.Click += new System.EventHandler(this.desctivate_vehicle_Click);
            // 
            // bCrearVehicle
            // 
            this.bCrearVehicle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bCrearVehicle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bCrearVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bCrearVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bCrearVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCrearVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearVehicle.ForeColor = System.Drawing.Color.Black;
            this.bCrearVehicle.Location = new System.Drawing.Point(610, 348);
            this.bCrearVehicle.Name = "bCrearVehicle";
            this.bCrearVehicle.Size = new System.Drawing.Size(179, 44);
            this.bCrearVehicle.TabIndex = 31;
            this.bCrearVehicle.Text = "Crear Vehicle";
            this.bCrearVehicle.UseVisualStyleBackColor = false;
            this.bCrearVehicle.Click += new System.EventHandler(this.bCrearVehicle_Click);
            // 
            // labelID
            // 
            this.labelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(7, 208);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(128, 20);
            this.labelID.TabIndex = 80;
            this.labelID.Text = "ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelID.Visible = false;
            // 
            // update_v
            // 
            this.update_v.BackColor = System.Drawing.Color.AntiqueWhite;
            this.update_v.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.update_v.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.update_v.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.update_v.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_v.ForeColor = System.Drawing.Color.Black;
            this.update_v.Location = new System.Drawing.Point(425, 347);
            this.update_v.Name = "update_v";
            this.update_v.Size = new System.Drawing.Size(179, 45);
            this.update_v.TabIndex = 79;
            this.update_v.Text = "Modificar Vehicle";
            this.update_v.UseVisualStyleBackColor = false;
            this.update_v.Click += new System.EventHandler(this.update_v_Click);
            // 
            // t_matricula
            // 
            this.t_matricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_matricula.Location = new System.Drawing.Point(140, 305);
            this.t_matricula.Name = "t_matricula";
            this.t_matricula.Size = new System.Drawing.Size(199, 20);
            this.t_matricula.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Matricula";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_model
            // 
            this.t_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_model.Location = new System.Drawing.Point(140, 275);
            this.t_model.Name = "t_model";
            this.t_model.Size = new System.Drawing.Size(199, 20);
            this.t_model.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Model";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_marca
            // 
            this.t_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_marca.Location = new System.Drawing.Point(140, 243);
            this.t_marca.Name = "t_marca";
            this.t_marca.Size = new System.Drawing.Size(199, 20);
            this.t_marca.TabIndex = 73;
            // 
            // nom_u
            // 
            this.nom_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.nom_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_u.ForeColor = System.Drawing.Color.White;
            this.nom_u.Location = new System.Drawing.Point(7, 243);
            this.nom_u.Name = "nom_u";
            this.nom_u.Size = new System.Drawing.Size(128, 20);
            this.nom_u.TabIndex = 72;
            this.nom_u.Text = "Marca";
            this.nom_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(7, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 7);
            this.panel1.TabIndex = 82;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmartPack.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(165, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(545, 75);
            this.title.TabIndex = 81;
            this.title.Text = "Gestió Vehicles";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(345, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Llista de Vehicles";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Crear Un Nou Vehicle";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.update_v);
            this.Controls.Add(this.t_matricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_marca);
            this.Controls.Add(this.nom_u);
            this.Controls.Add(this.bCrearVehicle);
            this.Controls.Add(this.desctivate_vehicle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transportista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button desctivate_vehicle;
        private System.Windows.Forms.Button bCrearVehicle;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button update_v;
        private System.Windows.Forms.TextBox t_matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_marca;
        private System.Windows.Forms.Label nom_u;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}