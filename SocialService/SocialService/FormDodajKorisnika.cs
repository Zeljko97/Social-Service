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
    public partial class FormDodajKorisnika : Form
    {
        public FormDodajKorisnika()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         

           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
            {
                return;
            }
            else
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string jmbg = txtJMBG.Text;
                string lekovi = txtLekovi.Text;

                string pol = "";

                if (rbMuski.Checked == true)
                {
                    pol = "Muski";
                }
                else if (rbZenski.Checked == true)
                {
                    pol = "Zenski";
                }
                string datum = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string pokretljivost = cbPokretljivost.SelectedItem.ToString();
                string starosnaOdredba = cbStarosnaOdredba.SelectedItem.ToString();
                string brojKnjizice = txtZdrastvenaKnjizica.Text;
                string licna_primanja = cbLicnaPrimanja.SelectedItem.ToString();
                string podnosilac_zahteva = txtPodnosilacZahteva.Text;

               // string nazivDoma = cbDomovi.SelectedItem.ToString();
               // Dom dom = DataProvider.GetDom(nazivDoma);
                int id = Properties.Settings.Default.ID_korisnik;                
                

                DataProvider.AddKorisnik(id, jmbg, ime, prezime, datum, pol, starosnaOdredba, licna_primanja, brojKnjizice, "", pokretljivost, lekovi, podnosilac_zahteva, FormKorisnici.id_doma);
                MessageBox.Show("Uspesno dodat korisnik", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //kada uspesno ubaci korisnika,uveca se id :
                Properties.Settings.Default.ID_korisnik += 1;
                Properties.Settings.Default.Save();
                // ovo sam dodao za zauzetost
                FormKorisnici.d.zauzeto += 1;
                DataProvider.ZauzetoIncrement(FormKorisnici.d.naziv, FormKorisnici.id_doma, FormKorisnici.d.zauzeto);
                this.Close();
            }
        }

        private void FormDodajKorisnika_Load(object sender, EventArgs e)
        {
            List<Dom> domovi = new List<Dom>();
            domovi = DataProvider.GetDomovi();
        }

        #region validation
        //Da ne puca program:
        private bool CheckValidation()
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Ime nije uneto!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Prezime nije uneto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(txtJMBG.Text))
            {
                MessageBox.Show("JMBG nije uneto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (rbMuski.Checked==false && rbZenski.Checked==false)
            {
                MessageBox.Show("Morati izabrati pol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(txtPodnosilacZahteva.Text))
            {
                MessageBox.Show("Mora neko podneti zahtev!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(txtZdrastvenaKnjizica.Text))
            {
                MessageBox.Show("Broj knjizice je neophodan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (FormKorisnici.d.kapacitet == FormKorisnici.d.zauzeto)
            {
                MessageBox.Show("Nije moguce dodati novog korisnika jer je kapacitet doma PUN!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }
        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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

        private void txtLekovi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtZdrastvenaKnjizica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}
