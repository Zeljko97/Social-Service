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
    public partial class FormNoviZaposleni : Form
    {
        public FormNoviZaposleni()
        {
            InitializeComponent();
        }

        private void FormNoviZaposleni_Load(object sender, EventArgs e)
        {
            for(int i=0;i<40;i++)
            {
                cbRadniStaz.Items.Add(i);
            }
            List<Dom> domovi = new List<Dom>();
            domovi = DataProvider.GetDomovi();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
            {
                return;
            }
            else
            {
                int radniStaz = Convert.ToInt32(cbRadniStaz.SelectedItem.ToString());
                string datum = dtpDatumRodjenja.Value.ToString("yyyy-MM-dd");
                DataProvider.AddZaposlen(txtJMBG.Text, txtIme.Text, txtPrezime.Text, radniStaz, datum, cbRadnoMesto.Text, FormaZaposleni.id_doma);

                this.Close(); // zatvori formu za dodavanje i opet otvori formu za Zaposlene
                FormaZaposleni fz = new FormaZaposleni();
                fz.Show();
            }
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
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
        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //mislim da je bolje da ima 1 funkcija koja cekira sve
        private bool CheckValidation()
        {
            if (cbRadniStaz.SelectedItem == null)
            {
                MessageBox.Show("Niste naveli godinu radnog staza!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Niste upisali ime", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Niste upisali prezime", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (String.IsNullOrEmpty(txtJMBG.Text))
            {
                MessageBox.Show("Niste upisali JMBG!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
    }
}
