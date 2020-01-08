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
        #region pomocne
        public static string ime = "";
        public static string prezime = "";
        public static Zaposleni prenos;
        public List<Dom> lista = new List<Dom>();
        public List<Direktor> DIREKTORI = new List<Direktor>();
        #endregion
        public FormAdmin()
        {
            InitializeComponent();
           
        }
        #region Direktori
        private void btnDodajDirektora_Click(object sender, EventArgs e)
        {
            FormNoviDirektor fnd = new FormNoviDirektor();
            fnd.Show();
            UcitajDirektore(); // refresh
        }
        private void btnUcitajDirektore_Click(object sender, EventArgs e)
        {
            UcitajDirektore();
        }
        private void btnObrisiDirektora_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[1, indexRow].Value;
            string prezime = (string)dataGridView1[2, indexRow].Value;
            Direktor d = DataProvider.GetDirektor(ime, prezime);
            if (d == null)
            {
                MessageBox.Show("Nije moguce izvrsiti operaciju brisanja!");
                return;
            }
            else
            {
                DataProvider.DeleteDirektor(ime, prezime);
                MessageBox.Show("Uspesno je obrisan direktor " + ime + " " + prezime, "Brisanje uspesno!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajDirektore(); // refresh
            }
        }
        private void UcitajDirektore()
        {
            DIREKTORI = DataProvider.GetDirektori();
            dataGridView1.DataSource = DIREKTORI;
            dataGridView1.Columns["id"].Visible = false;
        }
        private void btnResetuj_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[1, indexRow].Value;
            string prezime = (string)dataGridView1[2, indexRow].Value;
            Direktor d = DataProvider.GetDirektor(ime, prezime);
            DataProvider.UpdateDirektor(ime, prezime, "", "");
            MessageBox.Show("Username i password direktora " + ime + " " + prezime + " su uspesno resetovani.", "Resetovanje uspesno.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UcitajDirektore();
        }


        #endregion
        #region Domovi
        private void btnSpisakDomova_Click(object sender, EventArgs e)
        {
            UcitajDomove();
        }
        private void UcitajDomove()
        {
            lista = DataProvider.GetDomovi();
            dataGridView3.DataSource = lista;
            cbDom.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                cbDom.Items.Add(lista[i].naziv);
            }
        }
        private void btnDodajDom_Click(object sender, EventArgs e)
        {
            vidljivost(true);
        }
        private void vidljivost(bool s)
        {
            label1.Visible = s;
            label2.Visible = s;
            label3.Visible = s;
            label4.Visible = s;
            label5.Visible = s;
            txtAdresa.Visible = s;
            txtNaziv.Visible = s;
            cbKapacitet.Visible = s;
            cbSpratnost.Visible = s;
            cbZauzeto.Visible = s;
            btnDodaj.Visible = s;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cbKapacitet.SelectedItem == null)
            {
                errorProvider1.SetError(cbKapacitet, "Neophodno uneti!");
                return;
            }
            else if (cbSpratnost.SelectedItem == null)
            {
                errorProvider1.SetError(cbSpratnost, "Neophodno uneti!");
                return;
            }

            int spratnost = Convert.ToInt32(cbSpratnost.SelectedItem.ToString());
            int kapacitet = Convert.ToInt32(cbKapacitet.SelectedItem.ToString());

            if (txtNaziv.Text == "")
            {
                errorProvider1.SetError(txtNaziv, "Neophodno uneti naziv!!");
                return;
            }

            DataProvider.AddDom(Properties.Settings.Default.ID_dom, txtNaziv.Text, txtAdresa.Text, spratnost, kapacitet, 0);
            List<Dom> domovi = new List<Dom>();

            domovi = DataProvider.GetDomovi();
            dataGridView3.DataSource = domovi;
            Properties.Settings.Default.ID_dom += 1;
            Properties.Settings.Default.Save();

            MessageBox.Show("Dom " + txtNaziv.Text + " je uspesno dodat", "Adresa doma:" + txtAdresa.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            UcitajDomove();
            vidljivost(false);
            cbSpratnost.SelectedItem = null;
            cbKapacitet.SelectedItem = null;
            txtNaziv.Text = "";
            txtAdresa.Text = "";
        }
        private void btnObrisiDom_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView3.CurrentRow.Index;
            string naziv = (string)dataGridView3[1, indexRow].Value;
            int domID = Convert.ToInt32(dataGridView3[0, indexRow].Value);
            Dom d = DataProvider.GetDom(naziv);
            if (d == null)
            {
                MessageBox.Show("Nije moguce izvrsiti operaciju brisanja!");
                return;
            }
            else
            {
                DataProvider.DeleteDirektoreDoma(domID);
                DataProvider.DeleteKorisnikeDoma(domID);
                DataProvider.DeleteZaposleneDoma(domID);
                DataProvider.DeleteDom(naziv, domID);
                MessageBox.Show(naziv + " dom:" + domID + " je uspesno obrisan!", "Uspesno brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajDomove(); // refresh domove
            }
        }

        #endregion
        #region Zaposleni
        private void btnDodajNovogZaposlenog_Click(object sender, EventArgs e)
        {
            FormNoviZaposleni fnz = new FormNoviZaposleni();
            fnz.Show();
        }
        private void button1_Click(object sender, EventArgs e) // button za brisanje zaposlenog
        {
            int indexRow = dataGridView2.CurrentRow.Index;
            string ime = (string)dataGridView2[1, indexRow].Value;
            string prezime = (string)dataGridView2[2, indexRow].Value;
            DataProvider.DeleteZaposlen(ime, prezime);
            //nije bas optimalno stalno ucitavati listu, ali s obzirom da lista ne moze biti velika u ovom sistemu
            //nece biti problema
            string nazivDoma = cbDom.SelectedItem.ToString();
            Dom dom = DataProvider.GetDom(nazivDoma);
            List<Zaposleni> listaZaposleni = new List<Zaposleni>();
            listaZaposleni = DataProvider.GetZaposleni();

            List<Zaposleni> listaZaposleni1 = new List<Zaposleni>();
            for (int i = 0; i < listaZaposleni.Count; i++)
            {
                if (listaZaposleni[i].domID == dom.domID)
                    listaZaposleni1.Add(listaZaposleni[i]);
            }
            dataGridView2.DataSource = listaZaposleni1;
            dataGridView2.Columns["user_name"].Visible = false;
            dataGridView2.Columns["password"].Visible = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e) // zaposleni
        {
            /* int indexRow = dataGridView1.CurrentRow.Index;
             ime = dataGridView1[1, indexRow].Value.ToString();
             prezime = dataGridView1[2, indexRow].Value.ToString() ;

             FormUpdateZaposleni fuz = new FormUpdateZaposleni();
             fuz.Show();*/

            //ucita info
            int indexRow = dataGridView2.CurrentRow.Index;
            string ime = (string)dataGridView2[1, indexRow].Value;
            string prezime = (string)dataGridView2[2, indexRow].Value;
            prenos = DataProvider.GetZaposlen(ime, prezime);

            FormUpdateZaposleni fnz = new FormUpdateZaposleni();
            fnz.Show();
        }
        private void cbDom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDom.SelectedItem == null)
            {
                errorProvider1.SetError(cbDom, "Neophodno je izabrati dom!");
                return;
            }
            string nazivDoma = cbDom.SelectedItem.ToString();
            Dom dom = DataProvider.GetDom(nazivDoma);
            List<Zaposleni> listaZaposleni = DataProvider.GetZaposleni();
            List<Zaposleni> listaZaposleni1 = new List<Zaposleni>();
            for (int i = 0; i < listaZaposleni.Count; i++)
            {
                if (listaZaposleni[i].domID == dom.domID)
                    listaZaposleni1.Add(listaZaposleni[i]);
            }
            dataGridView2.DataSource = listaZaposleni1;
            dataGridView2.Columns["user_name"].Visible = false;
            dataGridView2.Columns["password"].Visible = false;
        }

        #endregion
        #region Korisnici
        private void btnKorisnike_Click(object sender, EventArgs e)
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            korisnici = DataProvider.getKorisnici();
            dataGridView4.DataSource = korisnici;
        }
        private void btnPretraziKorisnika_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtImeKorisnika.Text))
            {
                MessageBox.Show("Morate uneti ime korisnika!", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (String.IsNullOrEmpty(txtPrezimeKorisnika.Text))
            {
                MessageBox.Show("Morate uneti ime korisnika!", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                string ime = txtImeKorisnika.Text;
                string prezime = txtPrezimeKorisnika.Text;
                List<Korisnik> korisnici = new List<Korisnik>();
                Korisnik k = DataProvider.GetKorisnik(ime, prezime);
                if (k != null)
                {
                    korisnici.Add(k);
                    dataGridView4.DataSource = korisnici;
                    txtImeKorisnika.Text = "";
                    txtPrezimeKorisnika.Text = "";
                }
            }
        }
        #endregion

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
            List<Dom> listaDomova = new List<Dom>();
            listaDomova = DataProvider.GetDomovi();
            for (int i = 0; i < listaDomova.Count; i++)
            {
                cbDom.Items.Add(listaDomova[i].naziv);
            }
        }


        #region ogranicenja unosa
        private void txtImeKorisnika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPrezimeKorisnika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtAdresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}
