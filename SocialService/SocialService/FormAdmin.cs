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
            for(int i = 0;i<=100;i++)
            {
                cbSpratnost.Items.Add(i);
            }
            for(int i = 0;i<=1000;i++)
            {
                cbKapacitet.Items.Add(i);
                cbZauzeto.Items.Add(i);
            }
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
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            int spratnost = Convert.ToInt32(cbSpratnost.SelectedItem.ToString());
            int kapacitet = Convert.ToInt32(cbKapacitet.SelectedItem.ToString());
            int zauzeto = Convert.ToInt32(cbZauzeto.SelectedItem.ToString());

            DataProvider.AddDom(2,txtNaziv.Text, txtAdresa.Text, spratnost, kapacitet,zauzeto);
           
            List<Dom> domovi = new List<Dom>();

            domovi = DataProvider.GetDomovi();
            dataGridView1.DataSource = domovi;
        }

        private void btnDodajDirektora_Click(object sender, EventArgs e)
        {
            FormNoviDirektor fnd = new FormNoviDirektor();
            fnd.Show();
        }
    }
}
