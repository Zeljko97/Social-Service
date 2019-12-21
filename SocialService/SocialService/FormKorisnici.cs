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
        public FormKorisnici()
        {
            InitializeComponent();
        }

        private void btnUcitajKorisnike_Click(object sender, EventArgs e)
        {
            List<Korisnik> lista = new List<Korisnik>();
            List<Korisnik> listaDoma = new List<Korisnik>();
            lista = DataProvider.getKorisnici();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].domID==id_doma)
                {
                    listaDoma.Add(lista[i]);
                }
            }
            dataGridView1.DataSource = listaDoma;
            dataGridView1.Columns["domID"].Visible = false;
            Prikaz();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[2, indexRow].Value;
            string prezime = (string)dataGridView1[3, indexRow].Value;
            int regBroj = Convert.ToInt32(dataGridView1[0,indexRow].Value); // mora po reg broju!

            DataProvider.DeleteKorisnik(ime, prezime);
            //ovo je dodato ,da bismo imali uvid u promeni zauzetosti i pri brisanju
            d.zauzeto -= 1;
            DataProvider.ZauzetoIncrement(d.naziv,d.domID,d.zauzeto);
            dataGridView1.DataSource = DataProvider.getKorisnici();
            Prikaz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDodajKorisnika fdk = new FormDodajKorisnika();
            fdk.Show();
            

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
            lblKapacitet.Text = "Kapacitet:" + d.kapacitet + "| Zauzeto:" + d.zauzeto;
            Text = "   " + d.naziv;
        }
    }
}
