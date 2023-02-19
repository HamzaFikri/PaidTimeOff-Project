namespace Gestion_de_conge__
{
    partial class Compte
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
            this.label_actpass = new System.Windows.Forms.Label();
            this.label_newpass = new System.Windows.Forms.Label();
            this.label_conpass = new System.Windows.Forms.Label();
            this.textBox_passact = new System.Windows.Forms.TextBox();
            this.textBox_newpass = new System.Windows.Forms.TextBox();
            this.textBox_conpass = new System.Windows.Forms.TextBox();
            this.button_valider = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_actpass
            // 
            this.label_actpass.AutoSize = true;
            this.label_actpass.Location = new System.Drawing.Point(8, 42);
            this.label_actpass.Name = "label_actpass";
            this.label_actpass.Size = new System.Drawing.Size(86, 13);
            this.label_actpass.TabIndex = 0;
            this.label_actpass.Text = "Passord Actuelle";
            // 
            // label_newpass
            // 
            this.label_newpass.AutoSize = true;
            this.label_newpass.Location = new System.Drawing.Point(8, 81);
            this.label_newpass.Name = "label_newpass";
            this.label_newpass.Size = new System.Drawing.Size(78, 13);
            this.label_newpass.TabIndex = 1;
            this.label_newpass.Text = "New Password";
            // 
            // label_conpass
            // 
            this.label_conpass.AutoSize = true;
            this.label_conpass.Location = new System.Drawing.Point(5, 123);
            this.label_conpass.Name = "label_conpass";
            this.label_conpass.Size = new System.Drawing.Size(97, 13);
            this.label_conpass.TabIndex = 2;
            this.label_conpass.Text = "Confirme Password";
            // 
            // textBox_passact
            // 
            this.textBox_passact.Location = new System.Drawing.Point(108, 39);
            this.textBox_passact.Name = "textBox_passact";
            this.textBox_passact.Size = new System.Drawing.Size(167, 20);
            this.textBox_passact.TabIndex = 3;
            this.textBox_passact.UseSystemPasswordChar = true;
            // 
            // textBox_newpass
            // 
            this.textBox_newpass.Location = new System.Drawing.Point(108, 78);
            this.textBox_newpass.Name = "textBox_newpass";
            this.textBox_newpass.Size = new System.Drawing.Size(167, 20);
            this.textBox_newpass.TabIndex = 4;
            this.textBox_newpass.UseSystemPasswordChar = true;
            // 
            // textBox_conpass
            // 
            this.textBox_conpass.Location = new System.Drawing.Point(108, 120);
            this.textBox_conpass.Name = "textBox_conpass";
            this.textBox_conpass.Size = new System.Drawing.Size(167, 20);
            this.textBox_conpass.TabIndex = 5;
            this.textBox_conpass.UseSystemPasswordChar = true;
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(242, 176);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(94, 31);
            this.button_valider.TabIndex = 6;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(300, 41);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(87, 13);
            this.label_user.TabIndex = 8;
            this.label_user.Text = "Pour Utilisateur : ";
            // 
            // Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 261);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.textBox_conpass);
            this.Controls.Add(this.textBox_newpass);
            this.Controls.Add(this.textBox_passact);
            this.Controls.Add(this.label_conpass);
            this.Controls.Add(this.label_newpass);
            this.Controls.Add(this.label_actpass);
            this.Name = "Compte";
            this.Text = "Compte";
            this.Load += new System.EventHandler(this.Compte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_actpass;
        private System.Windows.Forms.Label label_newpass;
        private System.Windows.Forms.Label label_conpass;
        private System.Windows.Forms.TextBox textBox_passact;
        private System.Windows.Forms.TextBox textBox_newpass;
        private System.Windows.Forms.TextBox textBox_conpass;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_user;
    }
}