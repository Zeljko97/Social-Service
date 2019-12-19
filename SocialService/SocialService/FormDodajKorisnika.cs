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
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string jmbg = txtJMBG.Text;
            string lekovi = txtLekovi.Text;

            string pol = "";

            if(rbMuski.Checked == true)
            {
                pol = "Muski";
            }
            else if(rbZenski.Checked == true)
            {
                pol = "Zenski";
            }

            
            string datum = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string pokretljivost = cbPokretljivost.SelectedItem.ToString();
            string starosnaOdredba = cbStarosnaOdredba.SelectedItem.ToString();
            string brojKnjizice = txtZdrastvenaKnjizica.Text;
            string licna_primanja = cbLicnaPrimanja.SelectedItem.ToString();
            string podnosilac_zahteva = txtPodnosilacZahteva.Text;

            string nazivDoma = cbDomovi.SelectedItem.ToString();
            Dom  dom = DataProvider.GetDom(nazivDoma);
            int id = Properties.Settings.Default.ID_korisnik;

            DataProvider.AddKorisnik(id, jmbg, ime, prezime, datum, pol, starosnaOdredba, licna_primanja, brojKnjizice, "", pokretljivost, lekovi, podnosilac_zahteva, dom.domID);

            
            MessageBox.Show("Uspesno dodat korisnik","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //kada uspesno ubaci korisnika,uveca se id :
            Properties.Settings.Default.ID_korisnik += 1;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void FormDodajKorisnika_Load(object sender, EventArgs e)
        {
            List<Dom> domovi = new List<Dom>();
            domovi = DataProvider.GetDomovi();

            for (int i = 0; i < domovi.Count; i++)
            {
                cbDomovi.Items.Add(domovi[i].naziv);
            }
        }
    }
}
