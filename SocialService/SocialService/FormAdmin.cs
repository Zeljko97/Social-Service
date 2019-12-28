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
    public partial class FormAdmin : Form
    {

        public static string ime = "";
        public static string prezime = "";
        public static Zaposleni prenos;

        public FormAdmin()
        {
            InitializeComponent();
           
        }

        private void btnDodajNovogZaposlenog_Click(object sender, EventArgs e)
        {
            FormNoviZaposleni fnz = new FormNoviZaposleni();
            fnz.Show();
        }

        private void btnSpisakDomova_Click(object sender, EventArgs e)
        {
            List<Dom> lista = new List<Dom>();

            lista = DataProvider.GetDomovi();
            dataGridView1.DataSource = lista;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            for(int i = 0;i<=5;i++)
            {
                cbSpratnost.Items.Add(i);
            }
            for(int i = 0;i<=500;i++)
            {
                cbKapacitet.Items.Add(i);
                cbZauzeto.Items.Add(i);
            }
            Refresh();



        }

        private void btnDodajDom_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtAdresa.Visible = true;
            txtNaziv.Visible = true;
            cbKapacitet.Visible = true;
            cbSpratnost.Visible = true;
            cbZauzeto.Visible = true;
            btnDodaj.Visible = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(cbKapacitet.SelectedItem == null)
            {
                errorProvider1.SetError(cbKapacitet, "Neophodno uneti!");
                return;
            }
            else if(cbSpratnost.SelectedItem == null)
            {
                errorProvider1.SetError(cbSpratnost, "Neophodno uneti!");
                return;
            }
            else if(cbZauzeto.SelectedItem == null)
            {
                errorProvider1.SetError(cbZauzeto, "Neophodno uneti!");
                return;
            }

            int spratnost = Convert.ToInt32(cbSpratnost.SelectedItem.ToString());
            int kapacitet = Convert.ToInt32(cbKapacitet.SelectedItem.ToString());
            int zauzeto = Convert.ToInt32(cbZauzeto.SelectedItem.ToString());

        if(txtNaziv.Text == "")
            {
                errorProvider1.SetError(txtNaziv, "Neophodno uneti naziv!");
                return;
            }

            DataProvider.AddDom(Properties.Settings.Default.ID_dom,txtNaziv.Text, txtAdresa.Text, spratnost, kapacitet,0);
            List<Dom> domovi = new List<Dom>();

            domovi = DataProvider.GetDomovi();
            dataGridView1.DataSource = domovi;
            Properties.Settings.Default.ID_dom += 1;
            Properties.Settings.Default.Save();
        }

        private void btnDodajDirektora_Click(object sender, EventArgs e)
        {
            FormNoviDirektor fnd = new FormNoviDirektor();
            fnd.Show();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           /* int indexRow = dataGridView1.CurrentRow.Index;
            ime = dataGridView1[1, indexRow].Value.ToString();
            prezime = dataGridView1[2, indexRow].Value.ToString() ;

            FormUpdateZaposleni fuz = new FormUpdateZaposleni();
            fuz.Show();*/

            //ucita info
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[1, indexRow].Value;
            string prezime = (string)dataGridView1[2, indexRow].Value;
            prenos = DataProvider.GetZaposlen(ime, prezime);

            FormUpdateZaposleni fnz = new FormUpdateZaposleni();
            fnz.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[1, indexRow].Value;
            string prezime = (string)dataGridView1[2, indexRow].Value;
            DataProvider.DeleteZaposlen(ime, prezime);

            //nije bas optimalno stalno ucitavati listu, ali s obzirom da lista ne moze biti velika u ovom sistemu
            //nece biti problema
            string nazivDoma = cbDom.SelectedItem.ToString();
            Dom dom = new Dom();
            dom = DataProvider.GetDom(nazivDoma);

            List<Zaposleni> listaZaposleni = new List<Zaposleni>();
            listaZaposleni = DataProvider.GetZaposleni();


            List<Zaposleni> listaZaposleni1 = new List<Zaposleni>();
            for (int i = 0; i < listaZaposleni.Count; i++)
            {
                if (listaZaposleni[i].domID == dom.domID)
                    listaZaposleni1.Add(listaZaposleni[i]);
            }

            dataGridView1.DataSource = listaZaposleni1;

            dataGridView1.Columns["user_name"].Visible = false;
            dataGridView1.Columns["password"].Visible = false;
        }

        private void cbDom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDom.SelectedItem == null)
            {
                errorProvider1.SetError(cbDom, "Neophodno je izabrati dom!");
                return;
            }
            string nazivDoma = cbDom.SelectedItem.ToString();
            Dom dom = new Dom();
            dom = DataProvider.GetDom(nazivDoma);

            List<Zaposleni> listaZaposleni = new List<Zaposleni>();
            listaZaposleni = DataProvider.GetZaposleni();


            List<Zaposleni> listaZaposleni1 = new List<Zaposleni>();
            for (int i = 0; i < listaZaposleni.Count; i++)
            {
                if (listaZaposleni[i].domID == dom.domID)
                    listaZaposleni1.Add(listaZaposleni[i]);
            }

            dataGridView1.DataSource = listaZaposleni1;

            dataGridView1.Columns["user_name"].Visible = false;
            dataGridView1.Columns["password"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Zaposleni> zaposleni = new List<Zaposleni>();
            zaposleni = DataProvider.GetZaposleni();
            dataGridView1.DataSource = zaposleni;
        }

        private void btnUcitajDirektore_Click(object sender, EventArgs e)
        {
            List<Direktor> direktori = new List<Direktor>();
            direktori = DataProvider.GetDirektori();
            dataGridView1.DataSource = direktori;
            dataGridView1.Columns["id"].Visible = false;

        }

        private void btnKorisnike_Click(object sender, EventArgs e)
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            korisnici = DataProvider.getKorisnici();
            dataGridView1.DataSource = korisnici;
        }
        private void Refresh()
        {
            List<Dom> listaDomova = new List<Dom>();
            listaDomova = DataProvider.GetDomovi();

            for (int i = 0; i < listaDomova.Count; i++)
            {
                cbDom.Items.Add(listaDomova[i].naziv);
            }
           // Properties.Settings.Default.ID_dom = listaDomova.Count();
        }
    }
}
