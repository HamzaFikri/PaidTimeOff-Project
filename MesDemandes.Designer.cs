namespace Gestion_de_conge__
{
    partial class MesDemandes
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
            this.button_MonCompte = new System.Windows.Forms.Button();
            this.button_decnx = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_AjouterDemande = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_utilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirmation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_MonCompte
            // 
            this.button_MonCompte.Location = new System.Drawing.Point(327, 265);
            this.button_MonCompte.Name = "button_MonCompte";
            this.button_MonCompte.Size = new System.Drawing.Size(218, 43);
            this.button_MonCompte.TabIndex = 7;
            this.button_MonCompte.Text = "Mon Compte";
            this.button_MonCompte.UseVisualStyleBackColor = true;
            this.button_MonCompte.Click += new System.EventHandler(this.button_MonCompte_Click);
            // 
            // button_decnx
            // 
            this.button_decnx.Location = new System.Drawing.Point(7, 269);
            this.button_decnx.Name = "button_decnx";
            this.button_decnx.Size = new System.Drawing.Size(142, 25);
            this.button_decnx.TabIndex = 6;
            this.button_decnx.Text = "Se déconnecter";
            this.button_decnx.UseVisualStyleBackColor = true;
            this.button_decnx.Click += new System.EventHandler(this.button_decnx_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Date_Debut,
            this.Date_Fin,
            this.id_utilisateur,
            this.Confirmation,
            this.btn});
            this.dataGridView1.Location = new System.Drawing.Point(7, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 256);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_AjouterDemande
            // 
            this.button_AjouterDemande.Location = new System.Drawing.Point(709, 269);
            this.button_AjouterDemande.Name = "button_AjouterDemande";
            this.button_AjouterDemande.Size = new System.Drawing.Size(142, 25);
            this.button_AjouterDemande.TabIndex = 4;
            this.button_AjouterDemande.Text = "Ajouter Demande";
            this.button_AjouterDemande.UseVisualStyleBackColor = true;
            this.button_AjouterDemande.Click += new System.EventHandler(this.button_AjouterDemande_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Date_Debut
            // 
            this.Date_Debut.HeaderText = "Date_Debut";
            this.Date_Debut.Name = "Date_Debut";
            // 
            // Date_Fin
            // 
            this.Date_Fin.HeaderText = "Date_Fin";
            this.Date_Fin.Name = "Date_Fin";
            // 
            // id_utilisateur
            // 
            this.id_utilisateur.HeaderText = "Demande de ";
            this.id_utilisateur.Name = "id_utilisateur";
            // 
            // Confirmation
            // 
            this.Confirmation.HeaderText = "Confirmation";
            this.Confirmation.Name = "Confirmation";
            // 
            // btn
            // 
            this.btn.HeaderText = "annuler";
            this.btn.Name = "btn";
            this.btn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MesDemandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 320);
            this.Controls.Add(this.button_MonCompte);
            this.Controls.Add(this.button_decnx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_AjouterDemande);
            this.Name = "MesDemandes";
            this.Text = "MesDemandes";
            this.Load += new System.EventHandler(this.MesDemandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_MonCompte;
        private System.Windows.Forms.Button button_decnx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_utilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Confirmation;
        private System.Windows.Forms.DataGridViewButtonColumn btn;
        private System.Windows.Forms.Button button_AjouterDemande;
    }
}