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
    public partial class LogInDirektor : Form
    {

        public static string UserName = "";
        public static string PassWord = "";
        public LogInDirektor()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text==string.Empty)
            {
                errorProvider1.SetError(txtUsername,"Username mora biti ukucan!");
            }
            else if(txtPassword.Text == string.Empty)
            {
                errorProvider1.SetError(txtPassword, "password mora biti ukucan!");
            }
            else
            { 
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                bool a = DataProvider.CheckUserNameDirektor(username, password);
           

                FormaZaposleni fz = new FormaZaposleni();
                if (a == true)
                {
                    UserName = username;
                    PassWord = password;
                    fz.Show();
                    this.Close();
                }
                 else
                    MessageBox.Show("Pogresan user_name, ili lozinka!");
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            FormSingInDirektor fd = new FormSingInDirektor();
            fd.Show();
        }

        private void LogInDirektor_Load(object sender, EventArgs e)
        {

        }
    }
}
