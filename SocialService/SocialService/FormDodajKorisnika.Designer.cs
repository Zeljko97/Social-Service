﻿namespace SocialService
{
    partial class FormDodajKorisnika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajKorisnika));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPodnosilacZahteva = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbLicnaPrimanja = new System.Windows.Forms.ComboBox();
            this.txtZdrastvenaKnjizica = new System.Windows.Forms.TextBox();
            this.cbStarosnaOdredba = new System.Windows.Forms.ComboBox();
            this.cbPokretljivost = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtLekovi = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbZenski = new System.Windows.Forms.RadioButton();
            this.rbMuski = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOSIJE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(341, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "KORISNIKA USLUGA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(341, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOCIJALNE ZASTITE";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.txtPodnosilacZahteva);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbLicnaPrimanja);
            this.panel1.Controls.Add(this.txtZdrastvenaKnjizica);
            this.panel1.Controls.Add(this.cbStarosnaOdredba);
            this.panel1.Controls.Add(this.cbPokretljivost);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtLekovi);
            this.panel1.Controls.Add(this.txtJMBG);
            this.panel1.Controls.Add(this.txtPrezime);
            this.panel1.Controls.Add(this.txtIme);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 356);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(649, 102);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(174, 56);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPodnosilacZahteva
            // 
            this.txtPodnosilacZahteva.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPodnosilacZahteva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPodnosilacZahteva.Location = new System.Drawing.Point(292, 119);
            this.txtPodnosilacZahteva.Name = "txtPodnosilacZahteva";
            this.txtPodnosilacZahteva.Size = new System.Drawing.Size(216, 21);
            this.txtPodnosilacZahteva.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(426, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "(Ime Prezime)";
            // 
            // cbLicnaPrimanja
            // 
            this.cbLicnaPrimanja.FormattingEnabled = true;
            this.cbLicnaPrimanja.Items.AddRange(new object[] {
            "penzija",
            "plata",
            "socijalna pomoc"});
            this.cbLicnaPrimanja.Location = new System.Drawing.Point(482, 42);
            this.cbLicnaPrimanja.Name = "cbLicnaPrimanja";
            this.cbLicnaPrimanja.Size = new System.Drawing.Size(216, 21);
            this.cbLicnaPrimanja.TabIndex = 24;
            // 
            // txtZdrastvenaKnjizica
            // 
            this.txtZdrastvenaKnjizica.BackColor = System.Drawing.SystemColors.Menu;
            this.txtZdrastvenaKnjizica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZdrastvenaKnjizica.Location = new System.Drawing.Point(482, 12);
            this.txtZdrastvenaKnjizica.MaxLength = 15;
            this.txtZdrastvenaKnjizica.Name = "txtZdrastvenaKnjizica";
            this.txtZdrastvenaKnjizica.Size = new System.Drawing.Size(216, 21);
            this.txtZdrastvenaKnjizica.TabIndex = 23;
            this.txtZdrastvenaKnjizica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZdrastvenaKnjizica_KeyPress);
            // 
            // cbStarosnaOdredba
            // 
            this.cbStarosnaOdredba.FormattingEnabled = true;
            this.cbStarosnaOdredba.Items.AddRange(new object[] {
            "stara osoba",
            "odrasla osoba"});
            this.cbStarosnaOdredba.Location = new System.Drawing.Point(153, 311);
            this.cbStarosnaOdredba.Name = "cbStarosnaOdredba";
            this.cbStarosnaOdredba.Size = new System.Drawing.Size(208, 21);
            this.cbStarosnaOdredba.TabIndex = 22;
            // 
            // cbPokretljivost
            // 
            this.cbPokretljivost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPokretljivost.FormattingEnabled = true;
            this.cbPokretljivost.Items.AddRange(new object[] {
            "Pokretan",
            "Nepokretan",
            "Pomagala"});
            this.cbPokretljivost.Location = new System.Drawing.Point(153, 285);
            this.cbPokretljivost.Name = "cbPokretljivost";
            this.cbPokretljivost.Size = new System.Drawing.Size(208, 21);
            this.cbPokretljivost.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Aquamarine;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // txtLekovi
            // 
            this.txtLekovi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtLekovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLekovi.Location = new System.Drawing.Point(96, 96);
            this.txtLekovi.Multiline = true;
            this.txtLekovi.Name = "txtLekovi";
            this.txtLekovi.Size = new System.Drawing.Size(180, 86);
            this.txtLekovi.TabIndex = 19;
            this.txtLekovi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLekovi_KeyPress);
            // 
            // txtJMBG
            // 
            this.txtJMBG.BackColor = System.Drawing.SystemColors.Menu;
            this.txtJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJMBG.Location = new System.Drawing.Point(96, 68);
            this.txtJMBG.MaxLength = 13;
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(180, 21);
            this.txtJMBG.TabIndex = 18;
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(96, 40);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(180, 21);
            this.txtPrezime.TabIndex = 17;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.SystemColors.Menu;
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(96, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(180, 21);
            this.txtIme.TabIndex = 16;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(288, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 19);
            this.label14.TabIndex = 15;
            this.label14.Text = "Podnosilac  zahteva";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Starosna odredba:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Pokretljivost:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbZenski);
            this.groupBox1.Controls.Add(this.rbMuski);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 56);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POL";
            // 
            // rbZenski
            // 
            this.rbZenski.AutoSize = true;
            this.rbZenski.Location = new System.Drawing.Point(112, 22);
            this.rbZenski.Name = "rbZenski";
            this.rbZenski.Size = new System.Drawing.Size(66, 21);
            this.rbZenski.TabIndex = 1;
            this.rbZenski.TabStop = true;
            this.rbZenski.Text = "Zenski";
            this.rbZenski.UseVisualStyleBackColor = true;
            // 
            // rbMuski
            // 
            this.rbMuski.AutoSize = true;
            this.rbMuski.Location = new System.Drawing.Point(16, 22);
            this.rbMuski.Name = "rbMuski";
            this.rbMuski.Size = new System.Drawing.Size(63, 21);
            this.rbMuski.TabIndex = 0;
            this.rbMuski.TabStop = true;
            this.rbMuski.Text = "Muski";
            this.rbMuski.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ime:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Datum rodjenja:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Licna primanja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lekovi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Broj Zdravstvene knjizice:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "JMBG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prezime";
            // 
            // FormDodajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(868, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDodajKorisnika";
            this.Text = "Dodavanje novog korisnika doma";
            this.Load += new System.EventHandler(this.FormDodajKorisnika_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbPokretljivost;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtLekovi;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbZenski;
        private System.Windows.Forms.RadioButton rbMuski;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPodnosilacZahteva;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbLicnaPrimanja;
        private System.Windows.Forms.TextBox txtZdrastvenaKnjizica;
        private System.Windows.Forms.ComboBox cbStarosnaOdredba;
        private System.Windows.Forms.Button btnDodaj;
    }
}