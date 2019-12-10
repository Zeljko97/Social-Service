﻿using System;
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
    public partial class FormKorisnici : Form
    {
        public FormKorisnici()
        {
            InitializeComponent();
        }

        private void btnUcitajKorisnike_Click(object sender, EventArgs e)
        {
            List<Korisnik> lista = new List<Korisnik>();
            lista = DataProvider.getKorisnici();

            dataGridView1.DataSource = lista;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[2, indexRow].Value;
            string prezime = (string)dataGridView1[3, indexRow].Value;



            DataProvider.DeleteKorisnik(ime, prezime);

            dataGridView1.DataSource = DataProvider.getKorisnici();
        }
    }
}