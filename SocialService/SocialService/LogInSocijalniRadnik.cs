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
        //pomocnoL
        public static string UserName = "";
        public static string PassWord = "";

        public LogInSocijalniRadnik()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsername, "Korisnicko ime mora biti ukucano!");
            }
            else if (txtPassword.Text == string.Empty)
            {
                errorProvider1.SetError(txtPassword, "Lozinka mora biti ukucana!");
            }
            else
            {
                UserName = txtUsername.Text;
                PassWord = txtPassword.Text;
                bool a = DataProvider.CheckUserNameZaposleni(UserName, PassWord);

                FormKorisnici fz = new FormKorisnici();
                if (a == true)
                {
                    fz.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Pogresno korisnicko ime ili lozinka!","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            SingInSocijalniRadnik f = new SingInSocijalniRadnik();
            f.Show();
        }

        private void LogInSocijalniRadnik_Load(object sender, EventArgs e)
        {

        }
    }
}
