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
    public partial class Login : Form
    {
        private Utilisateur user = new Utilisateur();
        private SqlConnection cx;

        public Login()
        {
            InitializeComponent();
            cx = user.getcx();
            loginText.Text = "admin";
            passwordText.Text = "admin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String connectionString = "Data Source=DESKTOP-KERHO5P\\SQLExpress;Initial Catalog=GestionDeConge;Integrated Security=True";
            //SqlConnection cx = new SqlConnection(connectionString);
            
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from utilisateur where login ='" + loginText.Text + "'and password = '" + passwordText.Text + "' ", cx);
            cx.Open();
            SqlDataReader reader = cmd.ExecuteReader();    
            //SqlDataAdapter da = new SqlDataAdapter("select * from utilisateur where login ='" + loginText.Text + "'and password = '" + passwordText.Text + "' ", cx);
            //da.Fill(dt);
            //if (dt.Rows.Count == 1)
            if(reader.HasRows)
            {
                //Utilisateur user = new Utilisateur();
                while (reader.Read())
                {
                    //MessageBox.Show("" + reader.GetInt32(reader.GetOrdinal("id")) + reader.GetString(1));
                    user.setId(reader.GetInt32(reader.GetOrdinal("id")));
                    user.setnom(reader.GetString(reader.GetOrdinal("nom")));
                    user.setprenom(reader.GetString(reader.GetOrdinal("prenom")));
                    user.setcin(reader.GetString(reader.GetOrdinal("cin")));
                    user.setAdmin(reader.GetInt32(reader.GetOrdinal("admin_user")));
                    user.setlogin(reader.GetString(reader.GetOrdinal("login")));
                    user.setpassword(reader.GetString(reader.GetOrdinal("password")));
                    break;
                }
                // user.setId(5);
                // user.setAdmin(0);
                //("user"+ user.getId()+" -- "+user.getAdmin());

                if (user.getAdmin() == 1)
                {
                    Hide();
                    Administration administration = new Administration(user);
                    administration.ShowDialog();
                    Show();
                }else{
                    Hide();
                    MesDemandes Mesdemandes = new MesDemandes(user);
                    Mesdemandes.ShowDialog();
                    Show();
                    /*var res = demande.DialogResult;
                    if (res == DialogResult.OK)
                    {
                        MessageBox.Show(demande.resultat);
                    }
                    else
                    {
                        MessageBox.Show("---------------- " + demande.resultat);
                    }*/

                }
            }
            else
            {
                MessageBox.Show("login , password  est incorrect ");

            }
            cx.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
