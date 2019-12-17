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

            for(int i = 0;i<domovi.Count;i++)
            {
                cbDom.Items.Add(domovi[i].naziv);
            }


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string domStr = cbDom.SelectedItem.ToString();
            List<Dom> dom = new List<Dom>();
            dom = DataProvider.GetDom(domStr);
            int domID = dom[0].domID;

            int radniStaz = Convert.ToInt32(cbRadniStaz.SelectedItem.ToString());
            string datum = dtpDatumRodjenja.Value.ToString("yyyy-MM-dd");
          
            DataProvider.AddZaposlen(txtJMBG.Text, txtIme.Text, txtPrezime.Text, radniStaz,datum, cbRadnoMesto.Text, domID);

            FormaZaposleni fz = new FormaZaposleni();
            fz.Show();
            this.Close();
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
