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
    public partial class FormKorisnici : Form
    {
        public static int id_doma; // isto kao i ovamo
        public static Dom d;
        public static Korisnik izvestaj;
        public FormKorisnici()
        {
            InitializeComponent();
        }

        private void btnUcitajKorisnike_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataProvider.getKorisniciDomaAktivnost(id_doma,true);
            dataGridView1.Columns["domID"].Visible = false;
            dataGridView1.Columns["stanje"].Visible = false;
            dataGridView1.Columns["reg_broj"].Visible = false;
            Prikaz();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Promena(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (d.kapacitet == FormKorisnici.d.zauzeto)
            {
                MessageBox.Show("Nije moguce dodati novog korisnika jer je kapacitet doma PUN!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FormDodajKorisnika fdk = new FormDodajKorisnika();
                fdk.Show();
            }
        }

        private void FormKorisnici_Load(object sender, EventArgs e)
        {
            Prikaz();
        }
        private void Prikaz()
        {
            // da bi bi imali informaciju iskljucivo o Domu u kome radi odredjeni Socijalni radnik;
            string username = LogInSocijalniRadnik.UserName;
            string password = LogInSocijalniRadnik.PassWord;

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
            lblAdresaDoma.Text = d.adresa;
            lblNazivDoma.Text = d.naziv;
            lblIme.Text = z.ime;
            lblPrezime.Text = z.prezime;
            lblKapacitet.Text = "Kapacitet:" + d.kapacitet + "\n Zauzeto:" + d.zauzeto;
            Text = "   " + d.naziv;
            label4.Text = DateTime.Now.ToString();
        }

        private void btnUcitajPasivne_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataProvider.getKorisniciDomaAktivnost(id_doma, false);
            dataGridView1.Columns["domID"].Visible = false;
            dataGridView1.Columns["stanje"].Visible = false;
            dataGridView1.Columns["reg_broj"].Visible = false;
            Prikaz();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Da bi izvrsili pretragu neophodno je da unesete ime kako treba.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Da bi izvrsili pretragu neophodno je da unesete prezime kako treba.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;

                List<Korisnik> korisnici = new List<Korisnik>();
                Korisnik k = DataProvider.GetKorisnikDoma(ime,prezime,id_doma);
                korisnici.Add(k);
                dataGridView1.DataSource = korisnici;  
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = dataGridView1[2, indexRow].Value.ToString();
            string prezime = dataGridView1[3, indexRow].Value.ToString();
            Korisnik k = DataProvider.GetKorisnik(ime, prezime);
            string aktivnost = "";
            if (k.stanje==true)
                aktivnost = "aktivi";
            else
                aktivnost = "pasivi";
            MessageBox.Show("Ime: " + ime + "\nPrezime: " + prezime + "\n Ovaj korisnik je u " + aktivnost, "Info", MessageBoxButtons.OK);
        }

        private void btnPretraziJMBG_Click(object sender, EventArgs e)
        {
            if (txtJMBG.Text.Length!=13)
            {
                MessageBox.Show("Niste uneli JMBG kako treba!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtJMBG.Text))
            {
                MessageBox.Show("Morate uneti JMBG!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Korisnik> korisnici = DataProvider.VratiKorisnikeDoma(id_doma);
                List<Korisnik> nadjeno = new List<Korisnik>();
                for (int i = 0; i < korisnici.Count(); i++)
                {
                    if (korisnici[i].jmbg==txtJMBG.Text)
                    {
                        nadjeno.Add(korisnici[i]);
                    }
                }
                dataGridView1.DataSource = nadjeno;
                dataGridView1.Columns["domID"].Visible = false;
                dataGridView1.Columns["stanje"].Visible = false;
            }
        }

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Promena(true);
            
        }
        public void Promena(bool state)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[2, indexRow].Value;
            string prezime = (string)dataGridView1[3, indexRow].Value;
            int regBroj = Convert.ToInt32(dataGridView1[0, indexRow].Value); // mora po reg broju!

            DataProvider.UpdateKorisnik(ime, prezime, state);
            //ovo je dodato ,da bismo imali uvid u promeni zauzetosti i pri brisanju
            if (state==true)
            {
                d.zauzeto += 1;
                MessageBox.Show("Korisnik :" + ime + " " + prezime + " je uspesno prenet u aktivu. \n Ucitajte korisnike ponovo", "Aktivno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                d.zauzeto -= 1;
                MessageBox.Show("Korisnik :" + ime + " " + prezime + " je uspesno prenet u pasivu. \n Ucitajte korisnike ponovo", "Pasivno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DataProvider.ZauzetoIncrement(d.naziv, d.domID, d.zauzeto);
        }

        private void btnIzvestaj_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[2, indexRow].Value;
            string prezime = (string)dataGridView1[3, indexRow].Value;
            int regBroj = Convert.ToInt32(dataGridView1[0, indexRow].Value); // mora po reg broju!

            izvestaj = DataProvider.GetKorisnikDoma(ime,prezime,id_doma); // setujemo, da bi naredna forma mogla da koristi podatke.
            FormKorisnikIzvestaj fki = new FormKorisnikIzvestaj();
            fki.Show();
        }
    }
}
