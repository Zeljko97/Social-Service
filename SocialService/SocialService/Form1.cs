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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogInDirektor lg = new LogInDirektor();

            lg.Show();
        }

        private void btnSocijalniRadnik_Click(object sender, EventArgs e)
        {
            LogInSocijalniRadnik lg = new LogInSocijalniRadnik();
            lg.Show();


        }

        private void btnLekar_Click(object sender, EventArgs e)
        {
            LogInLekar ll = new LogInLekar();
            ll.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           /* List<Direktor> z = new List<Direktor>();

            z = DataProvider.GetDirektori();
            Direktor d = new Direktor();
            d = DataProvider.GetDirektor("zeljko","mitar");
            MessageBox.Show(d.ime+ " " + d.prezime);
            dataGridView1.DataSource = z;*/


            List<Direktor> lista = new List<Direktor>();
            Direktor direktor = new Direktor();
            direktor = DataProvider.GetDirektor("Zarko", "Petrovic");

            lista.Add(direktor);

            dataGridView1.DataSource = lista;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.Show();
        }
    }
}