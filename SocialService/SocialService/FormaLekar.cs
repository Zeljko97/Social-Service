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
    public partial class FormaLekar : Form
    {
        //moramo da dodamo
        public static int id_doma; // isto kao i ovamo
        public static Dom d;
        public static Korisnik izvestaj;

        public FormaLekar()
        {
            InitializeComponent();
        }

        private void btnSpisakPacijenata_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataProvider.getKorisniciDomaAktivnost(id_doma, true);
            dataGridView1.Columns["domID"].Visible = false;
            dataGridView1.Columns["stanje"].Visible = false;
            dataGridView1.Columns["reg_broj"].Visible = false;
            dataGridView1.Columns["licna_primanja"].Visible = false;
            dataGridView1.Columns["podnosilac_zahteva"].Visible = false;
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Niste uneli ime!","IME FALI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Niste uneli prezime!", "Prezime FALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            Korisnik korisnik = DataProvider.GetKorisnikDoma(ime, prezime,id_doma);
            List<Korisnik> korisnici = new List<Korisnik>();
            korisnici.Add(korisnik);
            dataGridView1.DataSource = korisnici;
            dataGridView1.Columns["domID"].Visible = false;
            dataGridView1.Columns["stanje"].Visible = false;
            dataGridView1.Columns["reg_broj"].Visible = false;
            dataGridView1.Columns["licna_primanja"].Visible = false;
            dataGridView1.Columns["podnosilac_zahteva"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormaLekar_Load(object sender, EventArgs e)
        {
            Prikaz();
            Vidljivost(false);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
        }

        private void txtIzvestaj_TextChanged(object sender, EventArgs e)
        {

        }
        #region validation
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
        private void txtBrojKnjizice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void Prikaz()
        {
            // da bi bi imali informaciju iskljucivo o Domu u kome radi odredjeni Socijalni radnik;
            string username = LogInLekar.UserName;
            string password = LogInLekar.PassWord;

            List<Zaposleni> lista = new List<Zaposleni>();
            lista = DataProvider.GetZaposleni();
            Zaposleni z = new Zaposleni();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].user_name == username && lista[i].password == password)
                    z = lista[i];
            }
            id_doma = DataProvider.ZaposleniIdDoma(z.ime, z.prezime);
            d = DataProvider.GetDomID(id_doma);
            Text = " Dom:  " + d.naziv + "   Lekar  " + z.ime + " " + z.prezime;
            label4.Text = d.naziv;
        }

        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void Vidljivost(bool s)
        {
            lblLekovi.Visible = s;
            lblZdravlje.Visible = s;
            btnUpdate.Visible = s;
            txtLekovi.Visible = s;
            txtZdravlje.Visible = s;
            labelaIme.Visible = s;
            labelaPrezime.Visible = s;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Vidljivost(false);
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = dataGridView1[2, indexRow].Value.ToString();
            string prezime = dataGridView1[3, indexRow].Value.ToString();
            string zdravlje = txtZdravlje.Text;
            string lekovi = txtLekovi.Text;
            DataProvider.UpdateKorisnik(ime, prezime, zdravlje, lekovi);
            MessageBox.Show("Uspesno su promenjeni podaci korisnika " + ime + " " + prezime,"Uspesna promena",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string zdravlje = dataGridView1[9, indexRow].Value.ToString();
            string lekovi = dataGridView1[11, indexRow].Value.ToString();
            Vidljivost(true);
            txtLekovi.Text = lekovi;
            txtZdravlje.Text = zdravlje;
            labelaIme.Text= dataGridView1[2, indexRow].Value.ToString();
            labelaPrezime.Text= dataGridView1[3, indexRow].Value.ToString();
        }

        private void btnPronadjiKnjizica_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBrojKnjizice.Text))
            {
                    MessageBox.Show("Niste uneli broj_knjizice!", "IME FALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string br = txtBrojKnjizice.Text;
                List<Korisnik> lista = DataProvider.getKorisniciDomaAktivnost(id_doma, true); // vrati sve aktivne korisnike
                List<Korisnik> nadjeno = new List<Korisnik>();
                for (int i = 0; i < lista.Count(); i++)
                {
                    if (lista[i].br_zdravstvene_knjizice == br)
                    {
                        nadjeno.Add(lista[i]);
                    }
                }
                dataGridView1.DataSource = nadjeno;
                dataGridView1.Columns["domID"].Visible = false;
                dataGridView1.Columns["stanje"].Visible = false;
                dataGridView1.Columns["reg_broj"].Visible = false;
                dataGridView1.Columns["licna_primanja"].Visible = false;
                dataGridView1.Columns["podnosilac_zahteva"].Visible = false;
            }
        }

        
    }
}
