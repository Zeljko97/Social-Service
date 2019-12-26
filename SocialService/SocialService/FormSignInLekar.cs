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
    public partial class FormSignInLekar : Form
    {
        public FormSignInLekar()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;

             Zaposleni z = new Zaposleni();
            z = DataProvider.GetZaposlen(ime, prezime);

            if (z.ime != ime && z.prezime != prezime && z.radno_mesto!="Lekar" )
            {
                MessageBox.Show("Vase ime ne postoji u sistemu!");
            }

            else if (z.user_name != "" && z.password != "")
            {
                MessageBox.Show("Korisnicko ime i lozinka su vec uneti!");
            }
            else
            {
                label4.Visible = true;
                label5.Visible = true;
                txtUsername.Visible = true;
                txtPassword.Visible = true;
                btnUnesi.Visible = true;
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
         //   string ime = txtIme.Text;
          //  string prezime = txtPrezime.Text;
          //  string user_name = txtUsername.Text;
          //  string password = txtPassword.Text;
            DataProvider.UpdateZaposlen(txtIme.Text,txtPrezime.Text,LogInLekar.radniStaz,txtUsername.Text,txtPassword.Text);
            MessageBox.Show("Uspesno ste uneli korisnicko ime i lozinku.","Uspesno unet Username i password",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
