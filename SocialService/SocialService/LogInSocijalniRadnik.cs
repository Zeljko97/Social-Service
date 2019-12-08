using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocialServiceDataLayer;
using SocialServiceDataLayer.QueryEntities;

namespace SocialService
{
    public partial class LogInSocijalniRadnik : Form
    {
        public LogInSocijalniRadnik()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool a = DataProvider.CheckUserNameZaposleni(username, password);


            FormKorisnici fz = new FormKorisnici();
            if (a == true)
            {
                fz.Show();
                this.Close();
            }
            else
                MessageBox.Show("Pogresan user_name, ili lozinka!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            //SingInSocijalniRadnik f = new SingInSocijalniRadnik();
           // f.Show();
        }
    }
}
