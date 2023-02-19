using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_conge__
{
    public partial class Administration : Form
    {/**/
        private Utilisateur user = new Utilisateur();
        public Administration(Utilisateur x)
        {
            InitializeComponent();
            user = x;
            //MessageBox.Show(" -- "+ x.getAdmin());
        }

        private void button_ajoututilisateur_Click(object sender, EventArgs e)
        {
            Hide();
            AjoutUtilisateur f = new AjoutUtilisateur();
            f.ShowDialog();
            Show();
        }

        private void button_sedeconecter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Administration_Load(object sender, EventArgs e)
        {

        }

        private void button_Compte_Click(object sender, EventArgs e)
        {
            Hide();
            Compte f = new Compte(user);
            f.ShowDialog();
            Show();
        }

        private void button_listedemande_Click(object sender, EventArgs e)
        {
            Hide();
            Demande f = new Demande(user);
            f.ShowDialog();
            Show();
        }
    }
}
