namespace SocialService
{
    partial class FormKorisnici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKorisnici));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUcitajKorisnike = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNazivDoma = new System.Windows.Forms.Label();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.lblAdresaDoma = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnUcitajPasivne = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPretraziJMBG = new System.Windows.Forms.Button();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Aqua;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(926, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnUcitajKorisnike
            // 
            this.btnUcitajKorisnike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajKorisnike.Location = new System.Drawing.Point(12, 132);
            this.btnUcitajKorisnike.Name = "btnUcitajKorisnike";
            this.btnUcitajKorisnike.Size = new System.Drawing.Size(155, 45);
            this.btnUcitajKorisnike.TabIndex = 1;
            this.btnUcitajKorisnike.Text = "Ucitaj korisnike doma";
            this.btnUcitajKorisnike.UseVisualStyleBackColor = true;
            this.btnUcitajKorisnike.Click += new System.EventHandler(this.btnUcitajKorisnike_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(173, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Obrisi Korisnika";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(173, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj Novog korisnika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblPrezime);
            this.panel1.Controls.Add(this.lblIme);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 114);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.lblNazivDoma);
            this.panel2.Controls.Add(this.lblKapacitet);
            this.panel2.Controls.Add(this.lblAdresaDoma);
            this.panel2.Location = new System.Drawing.Point(273, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 106);
            this.panel2.TabIndex = 5;
            // 
            // lblNazivDoma
            // 
            this.lblNazivDoma.AutoSize = true;
            this.lblNazivDoma.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivDoma.Location = new System.Drawing.Point(122, 10);
            this.lblNazivDoma.Name = "lblNazivDoma";
            this.lblNazivDoma.Size = new System.Drawing.Size(88, 21);
            this.lblNazivDoma.TabIndex = 2;
            this.lblNazivDoma.Text = "label1";
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKapacitet.Location = new System.Drawing.Point(122, 61);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(88, 21);
            this.lblKapacitet.TabIndex = 4;
            this.lblKapacitet.Text = "label1";
            // 
            // lblAdresaDoma
            // 
            this.lblAdresaDoma.AutoSize = true;
            this.lblAdresaDoma.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresaDoma.Location = new System.Drawing.Point(122, 35);
            this.lblAdresaDoma.Name = "lblAdresaDoma";
            this.lblAdresaDoma.Size = new System.Drawing.Size(88, 21);
            this.lblAdresaDoma.TabIndex = 3;
            this.lblAdresaDoma.Text = "label1";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.ForeColor = System.Drawing.Color.Red;
            this.lblPrezime.Location = new System.Drawing.Point(26, 64);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(84, 36);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "label1";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.Color.Red;
            this.lblIme.Location = new System.Drawing.Point(26, 32);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(84, 36);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "label1";
            // 
            // btnUcitajPasivne
            // 
            this.btnUcitajPasivne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajPasivne.Location = new System.Drawing.Point(12, 182);
            this.btnUcitajPasivne.Name = "btnUcitajPasivne";
            this.btnUcitajPasivne.Size = new System.Drawing.Size(155, 45);
            this.btnUcitajPasivne.TabIndex = 5;
            this.btnUcitajPasivne.Text = "Ucitaj Korisnike Pasive";
            this.btnUcitajPasivne.UseVisualStyleBackColor = true;
            this.btnUcitajPasivne.Click += new System.EventHandler(this.btnUcitajPasivne_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.btnPretrazi);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(334, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretrazivanje zahteva prezicno unosenje podataka:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(40, 92);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(102, 23);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(76, 66);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 3;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(76, 40);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(207)))), ((int)(((byte)(235)))));
            this.groupBox2.Controls.Add(this.btnPretraziJMBG);
            this.groupBox2.Controls.Add(this.txtJMBG);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(532, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 115);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretrazivanje na osnovu JMBG korisnika:";
            // 
            // btnPretraziJMBG
            // 
            this.btnPretraziJMBG.Location = new System.Drawing.Point(79, 86);
            this.btnPretraziJMBG.Name = "btnPretraziJMBG";
            this.btnPretraziJMBG.Size = new System.Drawing.Size(88, 23);
            this.btnPretraziJMBG.TabIndex = 2;
            this.btnPretraziJMBG.Text = "Pretrazi:";
            this.btnPretraziJMBG.UseVisualStyleBackColor = true;
            this.btnPretraziJMBG.Click += new System.EventHandler(this.btnPretraziJMBG_Click);
            // 
            // txtJMBG
            // 
            this.txtJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJMBG.Location = new System.Drawing.Point(79, 37);
            this.txtJMBG.MaxLength = 13;
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(141, 22);
            this.txtJMBG.TabIndex = 1;
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "label1";
            // 
            // FormKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(950, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUcitajPasivne);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUcitajKorisnike);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKorisnici";
            this.Load += new System.EventHandler(this.FormKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUcitajKorisnike;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNazivDoma;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.Label lblAdresaDoma;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnUcitajPasivne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPretraziJMBG;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}