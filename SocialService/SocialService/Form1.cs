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
         
    
          //  DataProvider.AddZaposlen("15165484212312","Ivana", "Stefanovic", 4,"1989-04-15","sestra", 2);
            //dataGridView1.DataSource = DataProvider.GetDomovi();
            DataProvider.DeleteZaposlen("Zeljko", "Stanojevic");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogInDirektor lg = new LogInDirektor();

            lg.Show();
        }
    }
}
