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
    public partial class FormaZaposleni : Form
    {
        public FormaZaposleni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //da bi imao informaciju domID.
            string username = LogInDirektor.UserName;
            string password = LogInDirektor.PassWord;
            dataGridView1.DataSource = DataProvider.getZaposleniDom(DataProvider.DirektorIdDoma(username, password));
            dataGridView1.Columns["user_name"].Visible = false;
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["domID"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNoviZaposleni fnz = new FormNoviZaposleni();
            fnz.Show();

            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[1, indexRow].Value;
            string prezime = (string)dataGridView1[2, indexRow].Value;



            DataProvider.DeleteZaposlen(ime, prezime);

            dataGridView1.DataSource = DataProvider.GetZaposleni();
        }

        private void FormaZaposleni_Load(object sender, EventArgs e)
        {
            string username = LogInDirektor.UserName;
            string password = LogInDirektor.PassWord;
            Dom dom = new Dom();
            int d = DataProvider.DirektorIdDoma(username, password);
            dom = DataProvider.GetDomID(d);
            // ovo da proveri username i password direktora i da na osnovu njega vrati DOM u kom je on direktor
            // da bi se u lblDom stampale informacije o domu.
            lblDom.Text = dom.naziv;
            lblAdresa.Text = dom.adresa;
            lblKapacitet.Text = "Kapacitet doma: " + dom.kapacitet;
        }
    }
}
