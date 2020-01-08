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
        private static Zaposleni z;
        public FormSignInLekar()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Niste uneli ime lekara.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Niste uneli prezime lekara.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            z = DataProvider.GetZaposlen(ime, prezime);
            if (z!=null)
            {
                if (z.ime != ime && z.prezime != prezime && z.radno_mesto != "Lekar")
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
            else
                MessageBox.Show("Lekar sa datim imenom i prezimenom ne postoji u bazi podataka.","",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Niste uneli korisnicko ime.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Niste uneli sifru .", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //   string ime = txtIme.Text;
            //  string prezime = txtPrezime.Text;
            string user_name = txtUsername.Text;
              string password = txtPassword.Text;
            DataProvider.UpdateZaposlen(z.ime,z.prezime,z.radni_staz,txtUsername.Text,txtPassword.Text);
            MessageBox.Show("Uspesno ste uneli korisnicko ime i lozinku.","Uspesno uneto korisnicko ime  i lozinka",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }


        #region ogranicenja unosa
        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}
