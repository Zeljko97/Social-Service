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
    public partial class LogInLekar : Form
    {
        public LogInLekar()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
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
                string userName = txtUsername.Text;
                string password = txtPassword.Text;

                bool a = DataProvider.CheckUserNameZaposleni(userName, password);


                FormaLekar fl = new FormaLekar();
                if (a == true)
                {
                    fl.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Pogresan user_name, ili lozinka!");
            }
        }

        private void LogInLekar_Load(object sender, EventArgs e)
        {

        }
    }
}
