namespace SocialService
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            this.btnSpisakDomova = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodajDom = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.cbSpratnost = new System.Windows.Forms.ComboBox();
            this.cbKapacitet = new System.Windows.Forms.ComboBox();
            this.cbZauzeto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnDodajDirektora = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDom = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUcitajDirektore = new System.Windows.Forms.Button();
            this.btnKorisnike = new System.Windows.Forms.Button();
            this.NoviDom = new System.Windows.Forms.ToolTip(this.components);
            this.btnObrisiDom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisiDirektora = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnDodajNovogZaposlenog = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpisakDomova
            // 
            this.btnSpisakDomova.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpisakDomova.Location = new System.Drawing.Point(6, 20);
            this.btnSpisakDomova.Name = "btnSpisakDomova";
            this.btnSpisakDomova.Size = new System.Drawing.Size(159, 26);
            this.btnSpisakDomova.TabIndex = 1;
            this.btnSpisakDomova.Text = "Ucitaj domove";
            this.btnSpisakDomova.UseVisualStyleBackColor = true;
            this.btnSpisakDomova.Click += new System.EventHandler(this.btnSpisakDomova_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(6, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(528, 145);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnDodajDom
            // 
            this.btnDodajDom.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajDom.Location = new System.Drawing.Point(601, 20);
            this.btnDodajDom.Name = "btnDodajDom";
            this.btnDodajDom.Size = new System.Drawing.Size(177, 26);
            this.btnDodajDom.TabIndex = 3;
            this.btnDodajDom.Text = "Dodaj novi dom --->";
            this.NoviDom.SetToolTip(this.btnDodajDom, "Pazljivo unesite podatke prilikom dodavanja novog doma u sistem.");
            this.btnDodajDom.UseVisualStyleBackColor = true;
            this.btnDodajDom.Click += new System.EventHandler(this.btnDodajDom_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(86, 15);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 21);
            this.txtNaziv.TabIndex = 4;
            this.txtNaziv.Visible = false;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(86, 42);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 21);
            this.txtAdresa.TabIndex = 5;
            this.txtAdresa.Visible = false;
            // 
            // cbSpratnost
            // 
            this.cbSpratnost.FormattingEnabled = true;
            this.cbSpratnost.Location = new System.Drawing.Point(153, 68);
            this.cbSpratnost.Name = "cbSpratnost";
            this.cbSpratnost.Size = new System.Drawing.Size(33, 23);
            this.cbSpratnost.TabIndex = 6;
            this.cbSpratnost.Visible = false;
            // 
            // cbKapacitet
            // 
            this.cbKapacitet.FormattingEnabled = true;
            this.cbKapacitet.Location = new System.Drawing.Point(128, 100);
            this.cbKapacitet.Name = "cbKapacitet";
            this.cbKapacitet.Size = new System.Drawing.Size(58, 23);
            this.cbKapacitet.TabIndex = 7;
            this.cbKapacitet.Visible = false;
            // 
            // cbZauzeto
            // 
            this.cbZauzeto.FormattingEnabled = true;
            this.cbZauzeto.Location = new System.Drawing.Point(128, 136);
            this.cbZauzeto.Name = "cbZauzeto";
            this.cbZauzeto.Size = new System.Drawing.Size(58, 23);
            this.cbZauzeto.TabIndex = 8;
            this.cbZauzeto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adresa:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Spratnost:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kapacitet:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Trenutno zauzeto:";
            this.label5.Visible = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(24, 164);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(123, 27);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Visible = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnDodajDirektora
            // 
            this.btnDodajDirektora.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajDirektora.Location = new System.Drawing.Point(16, 19);
            this.btnDodajDirektora.Name = "btnDodajDirektora";
            this.btnDodajDirektora.Size = new System.Drawing.Size(159, 26);
            this.btnDodajDirektora.TabIndex = 15;
            this.btnDodajDirektora.Text = "Unesi direktora doma";
            this.btnDodajDirektora.UseVisualStyleBackColor = true;
            this.btnDodajDirektora.Click += new System.EventHandler(this.btnDodajDirektora_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ucitaj zaposlene doma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(14, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dom:";
            // 
            // cbDom
            // 
            this.cbDom.FormattingEnabled = true;
            this.cbDom.Location = new System.Drawing.Point(56, 31);
            this.cbDom.Name = "cbDom";
            this.cbDom.Size = new System.Drawing.Size(121, 21);
            this.cbDom.TabIndex = 18;
            this.cbDom.SelectedIndexChanged += new System.EventHandler(this.cbDom_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnUcitajDirektore
            // 
            this.btnUcitajDirektore.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajDirektore.Location = new System.Drawing.Point(16, 51);
            this.btnUcitajDirektore.Name = "btnUcitajDirektore";
            this.btnUcitajDirektore.Size = new System.Drawing.Size(158, 26);
            this.btnUcitajDirektore.TabIndex = 22;
            this.btnUcitajDirektore.Text = "Ucitaj direktore";
            this.btnUcitajDirektore.UseVisualStyleBackColor = true;
            this.btnUcitajDirektore.Click += new System.EventHandler(this.btnUcitajDirektore_Click);
            // 
            // btnKorisnike
            // 
            this.btnKorisnike.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnike.Location = new System.Drawing.Point(15, 20);
            this.btnKorisnike.Name = "btnKorisnike";
            this.btnKorisnike.Size = new System.Drawing.Size(159, 26);
            this.btnKorisnike.TabIndex = 24;
            this.btnKorisnike.Text = "Ucitaj sve korisnike";
            this.btnKorisnike.UseVisualStyleBackColor = true;
            this.btnKorisnike.Click += new System.EventHandler(this.btnKorisnike_Click);
            // 
            // btnObrisiDom
            // 
            this.btnObrisiDom.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiDom.Location = new System.Drawing.Point(171, 20);
            this.btnObrisiDom.Name = "btnObrisiDom";
            this.btnObrisiDom.Size = new System.Drawing.Size(159, 26);
            this.btnObrisiDom.TabIndex = 30;
            this.btnObrisiDom.Text = "Obrisi dom";
            this.NoviDom.SetToolTip(this.btnObrisiDom, "Pazljivo unesite podatke prilikom dodavanja novog doma u sistem.");
            this.btnObrisiDom.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Controls.Add(this.txtAdresa);
            this.panel1.Controls.Add(this.cbSpratnost);
            this.panel1.Controls.Add(this.cbKapacitet);
            this.panel1.Controls.Add(this.cbZauzeto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(784, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 198);
            this.panel1.TabIndex = 25;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(3, 58);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(756, 153);
            this.dataGridView2.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbDom);
            this.panel2.Location = new System.Drawing.Point(558, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 232);
            this.panel2.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiDirektora);
            this.groupBox1.Controls.Add(this.btnResetuj);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnDodajDirektora);
            this.groupBox1.Controls.Add(this.btnUcitajDirektore);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(16, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 240);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direktori";
            // 
            // btnObrisiDirektora
            // 
            this.btnObrisiDirektora.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiDirektora.Location = new System.Drawing.Point(181, 51);
            this.btnObrisiDirektora.Name = "btnObrisiDirektora";
            this.btnObrisiDirektora.Size = new System.Drawing.Size(159, 26);
            this.btnObrisiDirektora.TabIndex = 24;
            this.btnObrisiDirektora.Text = "Obrisi direktora";
            this.btnObrisiDirektora.UseVisualStyleBackColor = true;
            this.btnObrisiDirektora.Click += new System.EventHandler(this.btnObrisiDirektora_Click);
            // 
            // btnResetuj
            // 
            this.btnResetuj.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetuj.Location = new System.Drawing.Point(181, 19);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(159, 26);
            this.btnResetuj.TabIndex = 23;
            this.btnResetuj.Text = "Resetuj lozinku";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.Location = new System.Drawing.Point(6, 57);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(772, 161);
            this.dataGridView3.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisiDom);
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Controls.Add(this.btnSpisakDomova);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btnDodajDom);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 229);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Domovi:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Controls.Add(this.btnKorisnike);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 488);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1179, 207);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Korisnici";
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView4.Location = new System.Drawing.Point(15, 52);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1158, 149);
            this.dataGridView4.TabIndex = 25;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // btnDodajNovogZaposlenog
            // 
            this.btnDodajNovogZaposlenog.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovogZaposlenog.Location = new System.Drawing.Point(999, 64);
            this.btnDodajNovogZaposlenog.Name = "btnDodajNovogZaposlenog";
            this.btnDodajNovogZaposlenog.Size = new System.Drawing.Size(196, 35);
            this.btnDodajNovogZaposlenog.TabIndex = 0;
            this.btnDodajNovogZaposlenog.Text = "Dodaj novog zaposlenog";
            this.btnDodajNovogZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajNovogZaposlenog.Click += new System.EventHandler(this.btnDodajNovogZaposlenog_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(999, 105);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 35);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update zaposlenog";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.Location = new System.Drawing.Point(999, 23);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(196, 35);
            this.btnObrisi.TabIndex = 21;
            this.btnObrisi.Text = "Obrisi zaposlenog";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1325, 704);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDodajNovogZaposlenog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.ShowIcon = false;
            this.Text = "  Administratorski rezim rada";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSpisakDomova;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodajDom;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.ComboBox cbSpratnost;
        private System.Windows.Forms.ComboBox cbKapacitet;
        private System.Windows.Forms.ComboBox cbZauzeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnDodajDirektora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDom;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnUcitajDirektore;
        private System.Windows.Forms.Button btnKorisnike;
        private System.Windows.Forms.ToolTip NoviDom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObrisiDirektora;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObrisiDom;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDodajNovogZaposlenog;
    }
}