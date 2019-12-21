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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDom = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajNovogZaposlenog
            // 
            this.btnDodajNovogZaposlenog.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovogZaposlenog.Location = new System.Drawing.Point(700, 130);
            this.btnDodajNovogZaposlenog.Name = "btnDodajNovogZaposlenog";
            this.btnDodajNovogZaposlenog.Size = new System.Drawing.Size(173, 31);
            this.btnDodajNovogZaposlenog.TabIndex = 0;
            this.btnDodajNovogZaposlenog.Text = "Dodaj novog zaposlenog";
            this.btnDodajNovogZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajNovogZaposlenog.Click += new System.EventHandler(this.btnDodajNovogZaposlenog_Click);
            // 
            // btnSpisakDomova
            // 
            this.btnSpisakDomova.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpisakDomova.Location = new System.Drawing.Point(10, 91);
            this.btnSpisakDomova.Name = "btnSpisakDomova";
            this.btnSpisakDomova.Size = new System.Drawing.Size(186, 35);
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
            this.dataGridView1.Location = new System.Drawing.Point(218, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(455, 338);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnDodajDom
            // 
            this.btnDodajDom.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajDom.Location = new System.Drawing.Point(10, 156);
            this.btnDodajDom.Name = "btnDodajDom";
            this.btnDodajDom.Size = new System.Drawing.Size(186, 37);
            this.btnDodajDom.TabIndex = 3;
            this.btnDodajDom.Text = "Dodaj novi dom";
            this.btnDodajDom.UseVisualStyleBackColor = true;
            this.btnDodajDom.Click += new System.EventHandler(this.btnDodajDom_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(98, 223);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 4;
            this.txtNaziv.Visible = false;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(98, 250);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 5;
            this.txtAdresa.Visible = false;
            // 
            // cbSpratnost
            // 
            this.cbSpratnost.FormattingEnabled = true;
            this.cbSpratnost.Location = new System.Drawing.Point(165, 276);
            this.cbSpratnost.Name = "cbSpratnost";
            this.cbSpratnost.Size = new System.Drawing.Size(33, 21);
            this.cbSpratnost.TabIndex = 6;
            this.cbSpratnost.Visible = false;
            // 
            // cbKapacitet
            // 
            this.cbKapacitet.FormattingEnabled = true;
            this.cbKapacitet.Location = new System.Drawing.Point(140, 308);
            this.cbKapacitet.Name = "cbKapacitet";
            this.cbKapacitet.Size = new System.Drawing.Size(58, 21);
            this.cbKapacitet.TabIndex = 7;
            this.cbKapacitet.Visible = false;
            // 
            // cbZauzeto
            // 
            this.cbZauzeto.FormattingEnabled = true;
            this.cbZauzeto.Location = new System.Drawing.Point(140, 344);
            this.cbZauzeto.Name = "cbZauzeto";
            this.cbZauzeto.Size = new System.Drawing.Size(58, 21);
            this.cbZauzeto.TabIndex = 8;
            this.cbZauzeto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 223);
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
            this.label2.Location = new System.Drawing.Point(24, 253);
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
            this.label3.Location = new System.Drawing.Point(24, 279);
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
            this.label4.Location = new System.Drawing.Point(24, 311);
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
            this.label5.Location = new System.Drawing.Point(24, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Trenutno zauzeto:";
            this.label5.Visible = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(59, 380);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(98, 23);
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
            this.btnDodajDirektora.Location = new System.Drawing.Point(10, 22);
            this.btnDodajDirektora.Name = "btnDodajDirektora";
            this.btnDodajDirektora.Size = new System.Drawing.Size(187, 35);
            this.btnDodajDirektora.TabIndex = 15;
            this.btnDodajDirektora.Text = "Unesi direktora doma";
            this.btnDodajDirektora.UseVisualStyleBackColor = true;
            this.btnDodajDirektora.Click += new System.EventHandler(this.btnDodajDirektora_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(697, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ucitaj zaposlene doma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(697, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dom:";
            // 
            // cbDom
            // 
            this.cbDom.FormattingEnabled = true;
            this.cbDom.Location = new System.Drawing.Point(700, 71);
            this.cbDom.Name = "cbDom";
            this.cbDom.Size = new System.Drawing.Size(121, 21);
            this.cbDom.TabIndex = 18;
            this.cbDom.SelectedIndexChanged += new System.EventHandler(this.cbDom_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(700, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 30);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update zaposlenog";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.Location = new System.Drawing.Point(700, 223);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(173, 32);
            this.btnObrisi.TabIndex = 21;
            this.btnObrisi.Text = "Obrisi zaposlenog";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 428);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbDom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDom;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnObrisi;
    }
}