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
    public partial class FormNoviDirektor : Form
    {
        public FormNoviDirektor()
        {
            InitializeComponent();
        }

        private void FormNoviDirektor_Load(object sender, EventArgs e)
        {
            List<Dom> domovi = new List<Dom>();
            domovi = DataProvider.GetDomovi();

            for (int i = 0; i < domovi.Count; i++)
            {
                cbDom.Items.Add(domovi[i].naziv);
            }
        }
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
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string dom = cbDom.SelectedItem.ToString();

            Dom d = new Dom();
            d = DataProvider.GetDom(dom);

            DataProvider.AddDirektor(Properties.Settings.Default.ID_Direktora,txtIme.Text, txtPrezime.Text, d.domID);
            Properties.Settings.Default.ID_Direktora += 1;
            Properties.Settings.Default.Save();

            MessageBox.Show("Uspesno ste uneli podatke.","Uspesan unos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
           
        }
    }
}
