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
    public partial class ActionConfirm : Form
    {
        private Utilisateur user = new Utilisateur();
        public ActionConfirm(Utilisateur x)
        {
            InitializeComponent();
            user = x;
        }

        private void ActionConfirm_Load(object sender, EventArgs e)
        {

        }

        private void button_Autoriser_Click(object sender, EventArgs e)
        {
            if (user.getpassword() == textBox_pass.Text)
            {
                this.DialogResult = DialogResult.OK;
            }
            Close();
        }
    }
}
