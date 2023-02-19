using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Gestion_de_conge__
{
    public class Utilisateur
    {
        private int id;
        private int admin;
        private string nom;
        private string prenom;
        private string login;
        private string password;
        private string cin;

        private SqlConnection cx = new SqlConnection("Data Source=DESKTOP-KERHO5P\\SQLExpress;Initial Catalog=GestionDeConge;Integrated Security=True");



        public SqlConnection getcx(){
            return this.cx;
        }
        public int getId()
        {
            return this.id;
        }
        public void setId(int ID)
        {
            this.id = ID;
        }

        public int getAdmin()
        {
            return this.admin;
        }
        public void setAdmin(int ADMIN)
        {
            this.admin = ADMIN;
        }

      
        public string getnom()
        {
            return this.nom;
        }
        public void setnom(string NOM)
        {
            this.nom = NOM;
        }


        public string getprenom()
        {
            return this.prenom;
        }
        public void setprenom(string PRENOM)
        {
            this.prenom = PRENOM;
        }



        public string getlogin()
        {
            return this.login;
        }
        public void setlogin(string LOGIN)
        {
            this.login = LOGIN;
        }


        public string getpassword()
        {
            return this.password;
        }
        public void setpassword(string PASSWORD)
        {
            this.password = PASSWORD;
        }


        public string getcin()
        {
            return this.cin;
        }
        public void setcin(string CIN)
        {
            this.cin = CIN;
        }

        public void loadDemande(SqlConnection cx, DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();
            if (cx.State == ConnectionState.Open)
                cx.Close();
            cx.Open();
            String userSql = " and U.id=" + this.getId();
            if (this.getAdmin() == 1) userSql = "";
            SqlCommand cmd = new SqlCommand("select * from DemandeDeConge D, utilisateur U where U.id=D.id_utilisateur " + userSql+ "order by D.id desc", cx);
            SqlDataReader reader = cmd.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {
                //dataGridView1.Rows.Add(dr[0],dr[1],dr[2],dr[3],dr[4]);
                dataGridView1.Rows.Add(


                    reader.GetInt32(reader.GetOrdinal("id")),
                    reader.GetDateTime(reader.GetOrdinal("date_debut")),
                    reader.GetDateTime(reader.GetOrdinal("date_fin")),
                    reader.GetString(reader.GetOrdinal("nom")) + " " + reader.GetString(reader.GetOrdinal("prenom")),
                    reader.GetString(reader.GetOrdinal("confirmation"))
                );
                if(reader.GetString(reader.GetOrdinal("confirmation")) != "En Attente")
                {
                    dataGridView1.Rows[x].Cells[5].Value = null;
                    dataGridView1.Rows[x].Cells[5] = new DataGridViewTextBoxCell();
                    dataGridView1.Rows[x].Cells[6].Value = null;
                    dataGridView1.Rows[x].Cells[6] = new DataGridViewTextBoxCell();
                }
                x++;
            }
            cx.Close();
        }
        


    }
}
