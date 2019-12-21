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
    public partial class FormaZaposleni : Form
    {
        public static int id_doma;
        //pomocno:
        public static Zaposleni prenos;
        public FormaZaposleni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //da bi imao informaciju domID.
            string username = LogInDirektor.UserName;
            string password = LogInDirektor.PassWord;

            List<Direktor> lista = new List<Direktor>();
            lista = DataProvider.GetDirektori();

            Direktor direktor = new Direktor();

            for (int i = 0; i < lista.Count;i++)
            {
                if(lista[i].user_name == username && lista[i].password == password)
                {
                    direktor = lista[i];
                }
            }

            dataGridView1.DataSource = DataProvider.getZaposleniDom(DataProvider.DirektorIdDoma(direktor.ime, direktor.prezime));
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

        //brisanje radi
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[1, indexRow].Value;
            string prezime = (string)dataGridView1[2, indexRow].Value;



            DataProvider.DeleteZaposlen(ime, prezime);

            string username = LogInDirektor.UserName;
            string password = LogInDirektor.PassWord;
            int d = DataProvider.DirektorIdDoma(username, password);
           // dataGridView1.DataSource = DataProvider.GetZaposleni();
            dataGridView1.DataSource = DataProvider.getZaposleniDom(DataProvider.DirektorIdDoma(username, password));
        }

        private void FormaZaposleni_Load(object sender, EventArgs e)
        {
            string username = LogInDirektor.UserName;
            string password = LogInDirektor.PassWord;
            Dom dom = new Dom();

            List<Direktor> lista = new List<Direktor>();
            lista = DataProvider.GetDirektori();

            Direktor direktor = new Direktor();
            for(int i = 0;i<lista.Count;i++)
            {
                if (lista[i].user_name == username && password == password)
                    direktor = lista[i];
            }

            id_doma = DataProvider.DirektorIdDoma(direktor.ime, direktor.prezime);
            dom = DataProvider.GetDomID(id_doma);
            // ovo da proveri username i password direktora i da na osnovu njega vrati DOM u kom je on direktor
            // da bi se u lblDom stampale informacije o domu.
            lblDom.Text = dom.naziv;
            Text = "  Direktor " + direktor.ime + " " + direktor.prezime;
            lblAdresa.Text = dom.adresa;
            lblKapacitet.Text = "Kapacitet doma: " + dom.kapacitet;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //ucita info
            int indexRow = dataGridView1.CurrentRow.Index;
            string ime = (string)dataGridView1[1, indexRow].Value;
            string prezime = (string)dataGridView1[2, indexRow].Value;
            prenos = DataProvider.GetZaposlen(ime, prezime);

            FormUpdateZaposleni fnz = new FormUpdateZaposleni();
            fnz.Show();
        }
    }
}
