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

        private void FormSingInDirektor_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;

            string user_name = txtUsername.Text;
            string password = txtPassword.Text;

            DataProvider.UpdateDirektor(ime, prezime, user_name, password);
            MessageBox.Show("Uspesno ste uneli korisnicko ime i lozinku.");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
