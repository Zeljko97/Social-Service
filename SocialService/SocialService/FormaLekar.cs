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
        public FormaLekar()
        {
            InitializeComponent();
        }

        private void btnSpisakPacijenata_Click(object sender, EventArgs e)
        {
            List<Korisnik> pacijenti = DataProvider.getKorisnici();
            dataGridView1.DataSource = pacijenti;
            
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;

            Korisnik korisnik = DataProvider.GetKorisnik(ime, prezime);

            List<Korisnik> korisnici = new List<Korisnik>();
            korisnici.Add(korisnik);
            dataGridView1.DataSource = korisnici;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIzvestaj.Visible = true;
            btnDodaj.Visible = true;

            
        }

        private void FormaLekar_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
           // int izvestaj_id = (int)dataGridView1[14, indexRow].Value;

            int reg_broj = (int)dataGridView1[0, indexRow].Value;

            string aktivnost = txtIzvestaj.Text;

            


            DateTime datum = DateTime.Today;       
            string d1 = datum.ToString("yyyy-MM-dd");
          
            
            DataProvider.AddIzvestaj(d1, aktivnost, reg_broj);
            MessageBox.Show("Uneli ste novi izvestaj.");
     
            
          
        }

        private void txtIzvestaj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
