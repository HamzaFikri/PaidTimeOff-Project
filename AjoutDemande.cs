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
    public partial class AjoutDemande : Form
    {
        private Utilisateur user = new Utilisateur();
        private SqlConnection cx;
        public AjoutDemande(Utilisateur x)
        {
            InitializeComponent();
            user = x;
            cx = user.getcx();
            if (user.getAdmin()==0)
            {
                label_utilisateur.Visible = false;
                comboBox_users.Visible = false;
            }
        }


        private void AjoutDemande_Load(object sender, EventArgs e)
        {
            String[] elems = new String[2];
            cx.Open();
            SqlCommand cmd = new SqlCommand("select * from utilisateur", cx);
            SqlDataReader reader = cmd.ExecuteReader();
            Dictionary<int, String> comboSource = new Dictionary<int, String>();
            while (reader.Read())
            {
                comboSource.Add(reader.GetInt32(reader.GetOrdinal("id")), reader.GetString(reader.GetOrdinal("nom")));
                //elems[0] = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                //elems[1] = reader.GetString(reader.GetOrdinal("nom"));
            }
            comboBox_users.DataSource = new BindingSource(comboSource, null);
            comboBox_users.DisplayMember = "Value";
            comboBox_users.ValueMember = "Key";
                

            cx.Close();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            // Insert Into
            cx.Open();
            int id_user;
            if (user.getAdmin() == 0)
                id_user = user.getId();
            else
                id_user = ((KeyValuePair<int, String>)comboBox_users.SelectedItem).Key;

            String query = "insert into DemandeDeConge (date_debut,date_fin,id_utilisateur) values('" +
                dateTimePicker_debut.Text + "','" + dateTimePicker_fin.Text + "'," + id_user + ")";
            //MessageBox.Show(query);
            SqlCommand cmd = new SqlCommand(query,cx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bien ajouter");
            cx.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
