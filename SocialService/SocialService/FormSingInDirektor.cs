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
    public partial class FormSingInDirektor : Form
    {
        public FormSingInDirektor()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Niste uneli ime direktora.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Niste uneli prezime direktora.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;

            Direktor direktor = new Direktor();
            direktor = DataProvider.GetDirektor(ime, prezime);

            if(direktor.ime != ime && direktor.prezime != prezime)
            {
                MessageBox.Show("Vase ime ne postoji u sistemu.");
            }
            else if(direktor.user_name != "" && direktor.password != "")
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
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Niste uneli korisnicko ime.","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Niste uneli sifru .", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string user_name = txtUsername.Text;
            string password = txtPassword.Text;
            DataProvider.UpdateDirektor(ime, prezime, user_name, password);
            MessageBox.Show("Uspesno ste uneli korisnicko ime i lozinku.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close(); // zatvorimo formu
            }
        }

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
    }
}
