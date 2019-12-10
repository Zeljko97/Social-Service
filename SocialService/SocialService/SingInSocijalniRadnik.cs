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
    public partial class SingInSocijalniRadnik : Form
    {
        Zaposleni socRadnik;

        public SingInSocijalniRadnik()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;

           socRadnik = DataProvider.GetZaposlen(ime, prezime);

            if (socRadnik == null)
                MessageBox.Show("Pogresno uneto ime!");
            else if(socRadnik.user_name != null && socRadnik.password != null)
            {
                MessageBox.Show("Korisnicko ime vec postoji!");
            }
            else
            {
                txtUsername.Visible = true;
                txtPassword.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                btnSingIn.Visible = true;


               
            }
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            int radni_staz = socRadnik.radni_staz;
            DataProvider.UpdateZaposlen(ime, prezime,radni_staz, userName, password);
            MessageBox.Show("Uspesno ste uneli korisnicko ime i lozinku.");
        }
    }
}
