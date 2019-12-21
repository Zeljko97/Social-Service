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
    public partial class FormUpdateZaposleni : Form
    {
        public FormUpdateZaposleni()
        {
            InitializeComponent();
        }

        private void FormUpdateZaposleni_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                cbRadniStaz.Items.Add(i);
            }
            Zaposleni z = FormaZaposleni.prenos;
            txtIme.Text = z.ime;
            txtPrezime.Text = z.prezime;
            txtJMBG.Text = z.jmbg;
            cbRadniStaz.SelectedValue = z.radni_staz.ToString();
            lblRadniStazPret.Text = z.radni_staz.ToString();
            dtpDatumRodjenja.Value = z.datum_rodjenja;
            lblRadnoMestoPret.Text = z.radno_mesto.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // ???? Ne znam da li treba,lako ce obrisemo,ali nismo uzeli u obzir,sta ako se pri unosu podataka o zaposlenom,pogresi
        }
    }
}
