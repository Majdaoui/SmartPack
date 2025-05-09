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
            this.dataGridViewV = new System.Windows.Forms.DataGridView();
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
            this.t_color = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_tipus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bAssVehiTrans = new System.Windows.Forms.Button();
            this.lTransportista = new System.Windows.Forms.Label();
            this.dataGridViewTT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewV
            // 
            this.dataGridViewV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewV.Location = new System.Drawing.Point(7, 365);
            this.dataGridViewV.Name = "dataGridViewV";
            this.dataGridViewV.Size = new System.Drawing.Size(381, 151);
            this.dataGridViewV.TabIndex = 0;
            this.dataGridViewV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.desctivate_vehicle.Location = new System.Drawing.Point(439, 283);
            this.desctivate_vehicle.Name = "desctivate_vehicle";
            this.desctivate_vehicle.Size = new System.Drawing.Size(165, 44);
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
            this.bCrearVehicle.Location = new System.Drawing.Point(610, 234);
            this.bCrearVehicle.Name = "bCrearVehicle";
            this.bCrearVehicle.Size = new System.Drawing.Size(165, 44);
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
            this.labelID.Location = new System.Drawing.Point(7, 170);
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
            this.update_v.Location = new System.Drawing.Point(439, 234);
            this.update_v.Name = "update_v";
            this.update_v.Size = new System.Drawing.Size(165, 45);
            this.update_v.TabIndex = 79;
            this.update_v.Text = "Modificar Vehicle";
            this.update_v.UseVisualStyleBackColor = false;
            this.update_v.Click += new System.EventHandler(this.update_v_Click);
            // 
            // t_matricula
            // 
            this.t_matricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_matricula.Location = new System.Drawing.Point(140, 248);
            this.t_matricula.Name = "t_matricula";
            this.t_matricula.Size = new System.Drawing.Size(199, 20);
            this.t_matricula.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Matricula";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_model
            // 
            this.t_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_model.Location = new System.Drawing.Point(140, 220);
            this.t_model.Name = "t_model";
            this.t_model.Size = new System.Drawing.Size(199, 20);
            this.t_model.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Model";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_marca
            // 
            this.t_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_marca.Location = new System.Drawing.Point(140, 194);
            this.t_marca.Name = "t_marca";
            this.t_marca.Size = new System.Drawing.Size(199, 20);
            this.t_marca.TabIndex = 73;
            // 
            // nom_u
            // 
            this.nom_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.nom_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_u.ForeColor = System.Drawing.Color.White;
            this.nom_u.Location = new System.Drawing.Point(7, 194);
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
            this.label3.Location = new System.Drawing.Point(7, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Llista de Vehicles";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Crear Un Nou Vehicle";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_color
            // 
            this.t_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_color.Location = new System.Drawing.Point(140, 274);
            this.t_color.Name = "t_color";
            this.t_color.Size = new System.Drawing.Size(199, 20);
            this.t_color.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 86;
            this.label5.Text = "Color";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_tipus
            // 
            this.t_tipus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_tipus.Location = new System.Drawing.Point(140, 303);
            this.t_tipus.Name = "t_tipus";
            this.t_tipus.Size = new System.Drawing.Size(199, 20);
            this.t_tipus.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 88;
            this.label6.Text = "Tipus";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bAssVehiTrans
            // 
            this.bAssVehiTrans.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bAssVehiTrans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bAssVehiTrans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bAssVehiTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bAssVehiTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAssVehiTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAssVehiTrans.ForeColor = System.Drawing.Color.Black;
            this.bAssVehiTrans.Location = new System.Drawing.Point(610, 284);
            this.bAssVehiTrans.Name = "bAssVehiTrans";
            this.bAssVehiTrans.Size = new System.Drawing.Size(165, 44);
            this.bAssVehiTrans.TabIndex = 90;
            this.bAssVehiTrans.Text = "Assignar Vehicle a Transportista";
            this.bAssVehiTrans.UseVisualStyleBackColor = false;
            this.bAssVehiTrans.Click += new System.EventHandler(this.bAssVehiTrans_Click);
            // 
            // lTransportista
            // 
            this.lTransportista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.lTransportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTransportista.ForeColor = System.Drawing.Color.White;
            this.lTransportista.Location = new System.Drawing.Point(394, 342);
            this.lTransportista.Name = "lTransportista";
            this.lTransportista.Size = new System.Drawing.Size(381, 20);
            this.lTransportista.TabIndex = 92;
            this.lTransportista.Text = "Llista de Transportistes";
            this.lTransportista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewTT
            // 
            this.dataGridViewTT.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTT.Location = new System.Drawing.Point(394, 365);
            this.dataGridViewTT.Name = "dataGridViewTT";
            this.dataGridViewTT.Size = new System.Drawing.Size(381, 151);
            this.dataGridViewTT.TabIndex = 91;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.lTransportista);
            this.Controls.Add(this.dataGridViewTT);
            this.Controls.Add(this.bAssVehiTrans);
            this.Controls.Add(this.t_tipus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_color);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.dataGridViewV);
            this.Name = "Vehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transportista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewV;
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
        private System.Windows.Forms.TextBox t_color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_tipus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bAssVehiTrans;
        private System.Windows.Forms.Label lTransportista;
        private System.Windows.Forms.DataGridView dataGridViewTT;
    }
}