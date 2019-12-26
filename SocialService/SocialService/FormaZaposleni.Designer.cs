namespace SocialService
{
    partial class FormaZaposleni
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaZaposleni));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDom = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.btnPretraziImePrezime = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSocijalniRadnik = new System.Windows.Forms.RadioButton();
            this.rbLekar = new System.Windows.Forms.RadioButton();
            this.rbMedicinskaSestra = new System.Windows.Forms.RadioButton();
            this.rbDomar = new System.Windows.Forms.RadioButton();
            this.btnPronadjiRB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(11, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(638, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Spisak zaposlenih";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDom
            // 
            this.lblDom.AutoSize = true;
            this.lblDom.Font = new System.Drawing.Font("Lucida Bright", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDom.Location = new System.Drawing.Point(26, 12);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(84, 40);
            this.lblDom.TabIndex = 4;
            this.lblDom.Text = "lbl1";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.Location = new System.Drawing.Point(29, 52);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(66, 22);
            this.lblAdresa.TabIndex = 5;
            this.lblAdresa.Text = "label1";
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKapacitet.Location = new System.Drawing.Point(29, 74);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(66, 22);
            this.lblKapacitet.TabIndex = 6;
            this.lblKapacitet.Text = "label1";
            // 
            // btnPretraziImePrezime
            // 
            this.btnPretraziImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziImePrezime.Location = new System.Drawing.Point(59, 68);
            this.btnPretraziImePrezime.Name = "btnPretraziImePrezime";
            this.btnPretraziImePrezime.Size = new System.Drawing.Size(98, 32);
            this.btnPretraziImePrezime.TabIndex = 7;
            this.btnPretraziImePrezime.Text = "Pronadji";
            this.btnPretraziImePrezime.UseVisualStyleBackColor = true;
            this.btnPretraziImePrezime.Click += new System.EventHandler(this.btnPretraziImePrezime_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPrezime);
            this.panel1.Controls.Add(this.txtIme);
            this.panel1.Controls.Add(this.btnPretraziImePrezime);
            this.panel1.Location = new System.Drawing.Point(655, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 109);
            this.panel1.TabIndex = 8;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(96, 9);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(113, 21);
            this.txtIme.TabIndex = 8;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(96, 41);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(113, 21);
            this.txtPrezime.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prezime";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(650, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pretrazivanje zahteva precizan unos podataka:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnPronadjiRB);
            this.panel2.Controls.Add(this.rbDomar);
            this.panel2.Controls.Add(this.rbMedicinskaSestra);
            this.panel2.Controls.Add(this.rbLekar);
            this.panel2.Controls.Add(this.rbSocijalniRadnik);
            this.panel2.Location = new System.Drawing.Point(655, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 134);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pretrazivanje na osnovu radnog mesta:";
            // 
            // rbSocijalniRadnik
            // 
            this.rbSocijalniRadnik.AutoSize = true;
            this.rbSocijalniRadnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSocijalniRadnik.Location = new System.Drawing.Point(16, 13);
            this.rbSocijalniRadnik.Name = "rbSocijalniRadnik";
            this.rbSocijalniRadnik.Size = new System.Drawing.Size(117, 17);
            this.rbSocijalniRadnik.TabIndex = 12;
            this.rbSocijalniRadnik.TabStop = true;
            this.rbSocijalniRadnik.Text = "Socijalni Radnik";
            this.rbSocijalniRadnik.UseVisualStyleBackColor = true;
            // 
            // rbLekar
            // 
            this.rbLekar.AutoSize = true;
            this.rbLekar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLekar.Location = new System.Drawing.Point(16, 36);
            this.rbLekar.Name = "rbLekar";
            this.rbLekar.Size = new System.Drawing.Size(57, 17);
            this.rbLekar.TabIndex = 13;
            this.rbLekar.TabStop = true;
            this.rbLekar.Text = "Lekar";
            this.rbLekar.UseVisualStyleBackColor = true;
            // 
            // rbMedicinskaSestra
            // 
            this.rbMedicinskaSestra.AutoSize = true;
            this.rbMedicinskaSestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedicinskaSestra.Location = new System.Drawing.Point(16, 59);
            this.rbMedicinskaSestra.Name = "rbMedicinskaSestra";
            this.rbMedicinskaSestra.Size = new System.Drawing.Size(127, 17);
            this.rbMedicinskaSestra.TabIndex = 14;
            this.rbMedicinskaSestra.TabStop = true;
            this.rbMedicinskaSestra.Text = "Medicinska sestra";
            this.rbMedicinskaSestra.UseVisualStyleBackColor = true;
            // 
            // rbDomar
            // 
            this.rbDomar.AutoSize = true;
            this.rbDomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDomar.Location = new System.Drawing.Point(16, 82);
            this.rbDomar.Name = "rbDomar";
            this.rbDomar.Size = new System.Drawing.Size(61, 17);
            this.rbDomar.TabIndex = 15;
            this.rbDomar.TabStop = true;
            this.rbDomar.Text = "Domar";
            this.rbDomar.UseVisualStyleBackColor = true;
            // 
            // btnPronadjiRB
            // 
            this.btnPronadjiRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronadjiRB.Location = new System.Drawing.Point(59, 105);
            this.btnPronadjiRB.Name = "btnPronadjiRB";
            this.btnPronadjiRB.Size = new System.Drawing.Size(98, 26);
            this.btnPronadjiRB.TabIndex = 16;
            this.btnPronadjiRB.Text = "Pronadji";
            this.btnPronadjiRB.UseVisualStyleBackColor = true;
            this.btnPronadjiRB.Click += new System.EventHandler(this.btnPronadjiRB_Click);
            // 
            // FormaZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(891, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKapacitet);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblDom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormaZaposleni";
            this.Load += new System.EventHandler(this.FormaZaposleni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDom;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.Button btnPretraziImePrezime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbDomar;
        private System.Windows.Forms.RadioButton rbMedicinskaSestra;
        private System.Windows.Forms.RadioButton rbLekar;
        private System.Windows.Forms.RadioButton rbSocijalniRadnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPronadjiRB;
    }
}