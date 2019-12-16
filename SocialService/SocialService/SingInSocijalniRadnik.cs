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
            //string ime = txtIme.Text;
            //string prezime = txtPrezime.Text;

        //   socRadnik = DataProvider.GetZaposlen(ime, prezime);
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = dataGridView1[1, indexRow].Value.ToString();
            string prezime = dataGridView1[2,indexRow].Value.ToString();

            socRadnik = DataProvider.GetZaposlen(ime, prezime);

            if (socRadnik == null)
                MessageBox.Show("Pogresno uneto ime!");
            else if(socRadnik.radno_mesto != "Socijalni radnik")
            {
                MessageBox.Show("Nije moguc pristup.");
            }
            else if(socRadnik.user_name != "" && socRadnik.password != "")
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
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = dataGridView1[1, indexRow].Value.ToString();
            string prezime = dataGridView1[2, indexRow].Value.ToString();

            
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            int radni_staz = socRadnik.radni_staz;
            DataProvider.UpdateZaposlen(ime, prezime,radni_staz, userName, password);
            MessageBox.Show("Uspesno ste uneli korisnicko ime i lozinku.");
        }

        private void SingInSocijalniRadnik_Load(object sender, EventArgs e)
        {
            List<Zaposleni> zaposleni = new List<Zaposleni>();

            zaposleni = DataProvider.GetZaposleni();

            List<Zaposleni> socRadnici = new List<Zaposleni>();
            for(int i = 0;i<zaposleni.Count; i++)
            {
                if (zaposleni[i].radno_mesto == "Socijalni radnik")
                    socRadnici.Add(zaposleni[i]);
            }

            dataGridView1.DataSource = socRadnici;
           
            dataGridView1.Columns["user_name"].Visible = false;
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["domID"].Visible = false;
            dataGridView1.Columns["datum_rodjenja"].Visible = false;

        }
    }
}
