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
    public partial class FormKorisnikIzvestaj : Form
    {
        public FormKorisnikIzvestaj()
        {
            InitializeComponent();
        }

        private void FormKorisnikIzvestaj_Load(object sender, EventArgs e)
        {
            Text ="Upisivanje izvestaja za korisnika:"+ FormKorisnici.izvestaj.ime + " " + FormKorisnici.izvestaj.prezime;
            lblDatumUnosaIzvestaja.Text = DateTime.Now.ToString();
            Validation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIzvestaj.Text = "";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIzvestaj.Text))
            {
                MessageBox.Show("Izvestaj mora sadrzati makar jednu recenicu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataProvider.AddIzvestaj(dateTimePicker1.Value.ToString("yyyy-MM-dd"), txtIzvestaj.Text, FormKorisnici.izvestaj.reg_broj);
                MessageBox.Show("Izvestaj je uspesno dodat","Dodavanje uspesno",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtIzvestaj.Text = "";
                
            }
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataProvider.vratiIzvestajeKorisnika(FormKorisnici.izvestaj.reg_broj);
            dataGridView1.Columns["reg_broj"].Visible = false;
            Validation();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string izvestaj = dataGridView1[1, indexRow].Value.ToString();
            string datum = dataGridView1[0, indexRow].Value.ToString();
            MessageBox.Show(izvestaj,datum,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            if (dataGridView1.CurrentRow.Index < 0)
                MessageBox.Show("Nije moguce izvrsiti ovu operaciju","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
                txtIzvestaj.Text= dataGridView1[1, indexRow].Value.ToString();
           // dateTimePicker1.Value = dataGridView1[0, indexRow].Value;
        }
        private void Validation()
        {
            if (dataGridView1.ColumnCount>1)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }
    }
}
