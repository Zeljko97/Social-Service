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
            this.btnDodajNovogZaposlenog = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajNovogZaposlenog
            // 
            this.btnDodajNovogZaposlenog.Location = new System.Drawing.Point(12, 22);
            this.btnDodajNovogZaposlenog.Name = "btnDodajNovogZaposlenog";
            this.btnDodajNovogZaposlenog.Size = new System.Drawing.Size(145, 23);
            this.btnDodajNovogZaposlenog.TabIndex = 0;
            this.btnDodajNovogZaposlenog.Text = "Dodaj novog zaposlenog";
            this.btnDodajNovogZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajNovogZaposlenog.Click += new System.EventHandler(this.btnDodajNovogZaposlenog_Click);
            // 
            // btnSpisakDomova
            // 
            this.btnSpisakDomova.Location = new System.Drawing.Point(11, 125);
            this.btnSpisakDomova.Name = "btnSpisakDomova";
            this.btnSpisakDomova.Size = new System.Drawing.Size(145, 23);
            this.btnSpisakDomova.TabIndex = 1;
            this.btnSpisakDomova.Text = "Ucitaj domove";
            this.btnSpisakDomova.UseVisualStyleBackColor = true;
            this.btnSpisakDomova.Click += new System.EventHandler(this.btnSpisakDomova_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 223);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnDodajDom
            // 
            this.btnDodajDom.Location = new System.Drawing.Point(11, 185);
            this.btnDodajDom.Name = "btnDodajDom";
            this.btnDodajDom.Size = new System.Drawing.Size(145, 23);
            this.btnDodajDom.TabIndex = 3;
            this.btnDodajDom.Text = "Dodaj novi dom";
            this.btnDodajDom.UseVisualStyleBackColor = true;
            this.btnDodajDom.Click += new System.EventHandler(this.btnDodajDom_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(123, 223);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 4;
            this.txtNaziv.Visible = false;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(123, 250);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 5;
            this.txtAdresa.Visible = false;
            // 
            // cbSpratnost
            // 
            this.cbSpratnost.FormattingEnabled = true;
            this.cbSpratnost.Location = new System.Drawing.Point(123, 287);
            this.cbSpratnost.Name = "cbSpratnost";
            this.cbSpratnost.Size = new System.Drawing.Size(33, 21);
            this.cbSpratnost.TabIndex = 6;
            this.cbSpratnost.Visible = false;
            // 
            // cbKapacitet
            // 
            this.cbKapacitet.FormattingEnabled = true;
            this.cbKapacitet.Location = new System.Drawing.Point(123, 319);
            this.cbKapacitet.Name = "cbKapacitet";
            this.cbKapacitet.Size = new System.Drawing.Size(44, 21);
            this.cbKapacitet.TabIndex = 7;
            this.cbKapacitet.Visible = false;
            // 
            // cbZauzeto
            // 
            this.cbZauzeto.FormattingEnabled = true;
            this.cbZauzeto.Location = new System.Drawing.Point(123, 355);
            this.cbZauzeto.Name = "cbZauzeto";
            this.cbZauzeto.Size = new System.Drawing.Size(44, 21);
            this.cbZauzeto.TabIndex = 8;
            this.cbZauzeto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adresa:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Spratnost:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kapacitet:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Trenutno zauzeto:";
            this.label5.Visible = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(123, 393);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnDodajDirektora
            // 
            this.btnDodajDirektora.Location = new System.Drawing.Point(11, 51);
            this.btnDodajDirektora.Name = "btnDodajDirektora";
            this.btnDodajDirektora.Size = new System.Drawing.Size(145, 23);
            this.btnDodajDirektora.TabIndex = 15;
            this.btnDodajDirektora.Text = "Unesi direktora doma";
            this.btnDodajDirektora.UseVisualStyleBackColor = true;
            this.btnDodajDirektora.Click += new System.EventHandler(this.btnDodajDirektora_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 428);
            this.Controls.Add(this.btnDodajDirektora);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbZauzeto);
            this.Controls.Add(this.cbKapacitet);
            this.Controls.Add(this.cbSpratnost);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnDodajDom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSpisakDomova);
            this.Controls.Add(this.btnDodajNovogZaposlenog);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajNovogZaposlenog;
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
    }
}