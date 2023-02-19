using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_de_conge__
{
    public partial class MesDemandes : Form
    {
        private Utilisateur user = new Utilisateur();
        private SqlConnection cx;

        public MesDemandes(Utilisateur x)
        {
            InitializeComponent();
            user = x;
            cx = user.getcx();
        }

        private void MesDemandes_Load(object sender, EventArgs e)
        {
            user.loadDemande(cx, dataGridView1);
        }

        private void button_decnx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_MonCompte_Click(object sender, EventArgs e)
        {
            Hide();
            Compte compte = new Compte(user);
            compte.ShowDialog();
            Show();
        }

        private void button_AjouterDemande_Click(object sender, EventArgs e)
        {
            Hide();
            AjoutDemande ajoutDemande = new AjoutDemande(user);
            ajoutDemande.ShowDialog();
            Show();
            user.loadDemande(cx, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
