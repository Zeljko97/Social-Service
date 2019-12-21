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
        /*    for (int i = 0; i < 40; i++)
            {
                cbRadniStaz.Items.Add(i);
            }
         * */
            Zaposleni z = FormAdmin.prenos;
            lblIme.Text = z.ime;
            lblPrezime.Text = z.prezime;
            txtJMBG.Text = z.jmbg;
            //cbRadniStaz.SelectedValue = z.radni_staz.ToString();
          //  cbRadniStaz.Text = z.radni_staz.ToString();
            lblRadniStazPret.Text = z.radni_staz.ToString();
            dtpDatumRodjenja.Value = z.datum_rodjenja;
            lblRadnoMestoPret.Text = z.radno_mesto.ToString();
            cbRadnoMesto.Text = z.radno_mesto.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
     
            int radniStaz = Convert.ToInt32(lblRadniStazPret.Text);
            string radnoMesto =  cbRadnoMesto.SelectedItem.ToString();
            string datum = dtpDatumRodjenja.Value.ToString("yyyy-MM-dd");
         
            DataProvider.UpdateZaposlenAll(lblIme.Text, lblPrezime.Text, txtJMBG.Text, datum, radniStaz, radnoMesto);
            this.Close();
        }
    }
}
