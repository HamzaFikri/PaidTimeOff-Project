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
    public partial class Compte : Form
    {
        private Utilisateur user = new Utilisateur();
        private SqlConnection cx;
        public Compte(Utilisateur x)
        {
            InitializeComponent();
            user = x;
            cx = user.getcx();
            //MessageBox.Show(user.getpassword());
        }

        private void Compte_Load(object sender, EventArgs e)
        {
            label_user.Text += user.getnom();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            /*SqlDataAdapter sda = new SqlDataAdapter("select password from utilisateur where password ='"+textBox_passact.Text+"' ",cx);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count.ToString() == "1")*/

            if (user.getpassword() == textBox_passact.Text)
            {
                if (textBox_newpass.Text == textBox_conpass.Text)
                {
                    cx.Open();
                    SqlCommand cmd = new SqlCommand("update utilisateur set password = '" + textBox_conpass.Text + "' where password = '" + textBox_passact.Text + "'", cx);
                    cmd.ExecuteNonQuery();
                    cx.Close();
                    MessageBox.Show("successfully");
                    Close();
                }
                else
                {
                    MessageBox.Show("les champs \"password\" et \"password confirmation\" doivent être identiques");
                    //Close();
                }

                /*Hide();
                Demande demande = new Demande(user);
                demande.ShowDialog();
                Show();*/
            }
            else
            {
                MessageBox.Show("Vous n'avez pas le droit d'executer cette opération !!");
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
