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
    public partial class AjoutUtilisateur : Form
    {
        private Utilisateur user = new Utilisateur();
        private SqlConnection cx;
        public AjoutUtilisateur()
        {
            InitializeComponent();
            cx = user.getcx();
        }
        //SqlConnection cx = new SqlConnection("Data Source=DESKTOP-KERHO5P\\SQLExpress;Initial Catalog=GestionDeConge;Integrated Security=True");


        private void button_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            int isadmin=0;
            if (is_admin.Checked == true) isadmin = 1;

            //String connectionString = "Data Source=DESKTOP-KERHO5P\\SQLExpress;Initial Catalog=GestionDeConge;Integrated Security=True";
            //SqlConnection cx = new SqlConnection(connectionString);
            //DataTable dt = new DataTable();
            SqlCommand cmd;
            cmd = new SqlCommand("select * from utilisateur where login ='" + textBox_login.Text + "'and password = '" + textBox_password.Text  + "' ", cx);
            cx.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show(" login et pass ont deja été affécter a un autre utilisateur !! ");
            }
            else
            {
                
                //cx.Open();
                cmd = new SqlCommand("insert into utilisateur (nom,login,password,admin_user,cin,prenom) values('" + textBox_nom.Text + "','" + textBox_login.Text + "','" + textBox_password.Text + "'," + isadmin + ",'" + textBox_cin.Text + "','" + textBox_prenom.Text + "')", cx);
                cmd.ExecuteNonQuery();
                cx.Close();
                MessageBox.Show("bien ajouter");
                Close();
            }

        }

        private void AjoutUtilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}
