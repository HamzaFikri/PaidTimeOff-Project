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
    public partial class Demande : Form
    {
        public String resultat;
        private Utilisateur user = new Utilisateur();
        private SqlConnection cx;

        public Demande(Utilisateur x)
        {
            InitializeComponent();
            user = x;
            cx = user.getcx();
        }
        
        private void Demande_Load(object sender, EventArgs e)
        {
            user.loadDemande(cx, dataGridView1);
        }
        
        private void button_AjouterDemande_Click(object sender, EventArgs e)
        {
            Hide();
            AjoutDemande ajoutDemande = new AjoutDemande(user);
            ajoutDemande.ShowDialog();
            Show();
            user.loadDemande(cx, dataGridView1);
        }

        private void button_decnx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_MonCompte_Click(object sender, EventArgs e)
        {
            Hide();
            Compte compte = new Compte (user);
            compte.ShowDialog();
            Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.ColumnCount = 5;
            //dataGridView1.Columns[0].Name ="id";
            //dataGridView1.Columns[1].Name ="Date_Debut";
            //dataGridView1.Columns[2].Name ="Dae_Fin";
            //dataGridView1.Columns[3].Name ="id_uulisateur";
            //dataGridView1.Columns[4].Name ="confirmation";
           
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 7 && e.RowIndex >= 0)
            {

                
                //MessageBox.Show(" btn clicked" + e.RowIndex+" " + e.ColumnIndex);
                //id.HeaderText = "rah hamza mafhemch";

                int cellId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                var checkbxRefuser = dataGridView1.Rows[e.RowIndex].Cells[6];
                var checkbxConfirmer = dataGridView1.Rows[e.RowIndex].Cells[5];
                String checkbxRefuserValue = "False";
                String checkbxConfirmerValue = "False";
                String confirmation = "En Attente";

                if (checkbxRefuser.Value != null)
                    checkbxRefuserValue = checkbxRefuser.Value.ToString();
                if (checkbxConfirmer.Value != null)
                    checkbxConfirmerValue = checkbxConfirmer.Value.ToString();
                
                if (checkbxRefuserValue == "True") confirmation = "Refusée";
                if (checkbxConfirmerValue == "True") confirmation = "Accéptée";
                //MessageBox.Show(" refuserValue " + checkbxRefuserValue + " confirmerValue " + checkbxConfirmerValue);
                MessageBox.Show(checkbxRefuserValue + " __ "+ checkbxConfirmerValue + " btn " + confirmation + " -- " + cellId);



                Hide();
                ActionConfirm ac = new ActionConfirm(user);
                ac.ShowDialog();
                Show();
                var res = ac.DialogResult;
                if (res == DialogResult.OK)
                {
                    /* requete update pr la table demandedeconge 
                     * champs confirmation avec la valeur dans la variable confirmation*/

                    cx.Open();
                    SqlCommand cmd = new SqlCommand("update DemandeDeConge set confirmation = '" + confirmation + "' where id = " + cellId, cx);
                    cmd.ExecuteNonQuery();
                    cx.Close();
                    MessageBox.Show("Operation effectuée avec success");
                    user.loadDemande(cx, dataGridView1);
                }
                else
                {
                    MessageBox.Show("Operation échouée");
                }

                //Form1 myform = new Form1();
                //myform.rowid = (int)x;
                //myform.Show();
            }
            
        }


      

       
    }
}
