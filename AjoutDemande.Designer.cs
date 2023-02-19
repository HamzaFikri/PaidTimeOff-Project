namespace Gestion_de_conge__
{
    partial class AjoutDemande
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_utilisateur = new System.Windows.Forms.Label();
            this.dateTimePicker_debut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_fin = new System.Windows.Forms.DateTimePicker();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.comboBox_users = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Debut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Fin";
            // 
            // label_utilisateur
            // 
            this.label_utilisateur.AutoSize = true;
            this.label_utilisateur.Location = new System.Drawing.Point(46, 130);
            this.label_utilisateur.Name = "label_utilisateur";
            this.label_utilisateur.Size = new System.Drawing.Size(58, 13);
            this.label_utilisateur.TabIndex = 3;
            this.label_utilisateur.Text = "Au nom de";
            // 
            // dateTimePicker_debut
            // 
            this.dateTimePicker_debut.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_debut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_debut.Location = new System.Drawing.Point(114, 62);
            this.dateTimePicker_debut.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_debut.Name = "dateTimePicker_debut";
            this.dateTimePicker_debut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_debut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_debut.TabIndex = 8;
            this.dateTimePicker_debut.Value = new System.DateTime(2018, 1, 30, 20, 45, 20, 0);
            // 
            // dateTimePicker_fin
            // 
            this.dateTimePicker_fin.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_fin.Location = new System.Drawing.Point(114, 92);
            this.dateTimePicker_fin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_fin.Name = "dateTimePicker_fin";
            this.dateTimePicker_fin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fin.TabIndex = 9;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(215, 196);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_Ajouter.TabIndex = 10;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(58, 196);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 11;
            this.button_close.Text = "Annuler";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // comboBox_users
            // 
            this.comboBox_users.FormattingEnabled = true;
            this.comboBox_users.Location = new System.Drawing.Point(115, 127);
            this.comboBox_users.Name = "comboBox_users";
            this.comboBox_users.Size = new System.Drawing.Size(199, 21);
            this.comboBox_users.TabIndex = 12;
            // 
            // AjoutDemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 261);
            this.Controls.Add(this.comboBox_users);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.dateTimePicker_fin);
            this.Controls.Add(this.dateTimePicker_debut);
            this.Controls.Add(this.label_utilisateur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AjoutDemande";
            this.Text = "AjoutDemande";
            this.Load += new System.EventHandler(this.AjoutDemande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_utilisateur;
        private System.Windows.Forms.DateTimePicker dateTimePicker_debut;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fin;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ComboBox comboBox_users;
    }
}