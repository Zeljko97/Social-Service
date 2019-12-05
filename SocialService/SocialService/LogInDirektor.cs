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
        public LogInDirektor()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool a = DataProvider.CheckUserNameDirektor(username, password);
           

            FormaZaposleni fz = new FormaZaposleni();
            if (a == true)
            {
                fz.Show();
                this.Close();
            }
            else
                MessageBox.Show("Pogresan user_name, ili lozinka!");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
