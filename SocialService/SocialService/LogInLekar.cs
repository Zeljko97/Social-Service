using SocialServiceDataLayer;
using System;
using System.Windows.Forms;
using SocialServiceDataLayer.QueryEntities;

namespace SocialService
{
    public partial class LogInLekar : Form
    {
        public static int radniStaz;
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
                    Zaposleni z = DataProvider.GetZaposlen(userName, password);
                    radniStaz = z.radni_staz;
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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FormSignInLekar f = new FormSignInLekar();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
