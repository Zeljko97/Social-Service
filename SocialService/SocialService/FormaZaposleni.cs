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

        private void btnPretraziImePrezime_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == string.Empty)
            {
                errorProvider1.SetError(txtIme, "Morate uneti Ime zaposlenog da bi pretrazivanje bilo omoguceno!");
            }
            else if (txtPrezime.Text == string.Empty)
            {
                errorProvider1.SetError(txtPrezime, "Morate uneti Prezime zaposlenog da bi pretrazivanje bilo omoguceno!");

            }
            else
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;

                Zaposleni z = DataProvider.GetZaposlen(ime, prezime);
                if (z==null)
                {
                    MessageBox.Show("Nije pronadjena zaposlena osoba sa zadatim imenom i prezimenom!","Neuspesno pretrazivanje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    List<Zaposleni> zaposleni = new List<Zaposleni>();
                    zaposleni.Add(z);
                    dataGridView1.DataSource = zaposleni;
                }
                
            }
        }

        private void btnPronadjiRB_Click(object sender, EventArgs e)
        {
            string radnoMesto = "";
            if (rbSocijalniRadnik.Checked == true)
            {
                radnoMesto = "Socijalni radnik";
            }
            else if (rbLekar.Checked == true)
            {
                radnoMesto = "Lekar";
            }
            else if (rbMedicinskaSestra.Checked == true)
            {
                radnoMesto = "Medicinska sestra";
            }
            else if (rbDomar.Checked == true)
            {
                radnoMesto = "Domar";
            }
            else
            {
                MessageBox.Show("Niste selektovali radno mesto!","Nije moguce obaviti pretragu!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            List<Zaposleni> zaposleni = new List<Zaposleni>();
            List<Zaposleni> pretrazeno = new List<Zaposleni>();

            zaposleni = DataProvider.GetZaposleni(); // vrati sve korisnike
            for (int i = 0; i < zaposleni.Count(); i++)
            {
                if (zaposleni[i].radno_mesto==radnoMesto)
                {
                    pretrazeno.Add(zaposleni[i]);
                }
            }
            dataGridView1.DataSource = pretrazeno;


        }
    }
}
