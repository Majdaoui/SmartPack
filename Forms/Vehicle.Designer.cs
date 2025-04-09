namespace SmartPack.Forms
{
    partial class Vehicle
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
            this.t_marca = new System.Windows.Forms.TextBox();
            this.nom_u = new System.Windows.Forms.Label();
            this.t_model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.desactivar_v = new System.Windows.Forms.Button();
            this.update_v = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t_marca
            // 
            this.t_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_marca.Location = new System.Drawing.Point(164, 94);
            this.t_marca.Name = "t_marca";
            this.t_marca.Size = new System.Drawing.Size(199, 20);
            this.t_marca.TabIndex = 49;
            // 
            // nom_u
            // 
            this.nom_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.nom_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_u.ForeColor = System.Drawing.Color.White;
            this.nom_u.Location = new System.Drawing.Point(31, 94);
            this.nom_u.Name = "nom_u";
            this.nom_u.Size = new System.Drawing.Size(128, 20);
            this.nom_u.TabIndex = 48;
            this.nom_u.Text = "Marca";
            this.nom_u.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_model
            // 
            this.t_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_model.Location = new System.Drawing.Point(164, 126);
            this.t_model.Name = "t_model";
            this.t_model.Size = new System.Drawing.Size(199, 20);
            this.t_model.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Model";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_matricula
            // 
            this.t_matricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_matricula.Location = new System.Drawing.Point(164, 156);
            this.t_matricula.Name = "t_matricula";
            this.t_matricula.Size = new System.Drawing.Size(199, 20);
            this.t_matricula.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Matricula";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // desactivar_v
            // 
            this.desactivar_v.BackColor = System.Drawing.Color.AntiqueWhite;
            this.desactivar_v.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.desactivar_v.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.desactivar_v.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.desactivar_v.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desactivar_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desactivar_v.ForeColor = System.Drawing.Color.Black;
            this.desactivar_v.Location = new System.Drawing.Point(401, 132);
            this.desactivar_v.Name = "desactivar_v";
            this.desactivar_v.Size = new System.Drawing.Size(179, 44);
            this.desactivar_v.TabIndex = 69;
            this.desactivar_v.Text = "Disactivar Vehicle";
            this.desactivar_v.UseVisualStyleBackColor = false;
            this.desactivar_v.Click += new System.EventHandler(this.desactivar_v_Click);
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
            this.update_v.Location = new System.Drawing.Point(401, 79);
            this.update_v.Name = "update_v";
            this.update_v.Size = new System.Drawing.Size(179, 45);
            this.update_v.TabIndex = 70;
            this.update_v.Text = "Modificar Vehicle";
            this.update_v.UseVisualStyleBackColor = false;
            this.update_v.Click += new System.EventHandler(this.update_v_Click);
            // 
            // labelID
            // 
            this.labelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(31, 59);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(128, 20);
            this.labelID.TabIndex = 71;
            this.labelID.Text = "ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelID.Visible = false;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 224);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.update_v);
            this.Controls.Add(this.desactivar_v);
            this.Controls.Add(this.t_matricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_marca);
            this.Controls.Add(this.nom_u);
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_marca;
        private System.Windows.Forms.Label nom_u;
        private System.Windows.Forms.TextBox t_model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button desactivar_v;
        private System.Windows.Forms.Button update_v;
        private System.Windows.Forms.Label labelID;
    }
}