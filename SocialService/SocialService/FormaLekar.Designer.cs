namespace SocialService
{
    partial class FormaLekar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSpisakPacijenata = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblObavestenje = new System.Windows.Forms.Label();
            this.lblZdravlje = new System.Windows.Forms.Label();
            this.lblLekovi = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtZdravlje = new System.Windows.Forms.TextBox();
            this.txtLekovi = new System.Windows.Forms.TextBox();
            this.labelaIme = new System.Windows.Forms.Label();
            this.labelaPrezime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ttPronadjiImePrezime = new System.Windows.Forms.ToolTip(this.components);
            this.btnPronadjiKnjizica = new System.Windows.Forms.Button();
            this.ttUpis = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBrojKnjizice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(15, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(669, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSpisakPacijenata
            // 
            this.btnSpisakPacijenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpisakPacijenata.Location = new System.Drawing.Point(12, 65);
            this.btnSpisakPacijenata.Name = "btnSpisakPacijenata";
            this.btnSpisakPacijenata.Size = new System.Drawing.Size(132, 33);
            this.btnSpisakPacijenata.TabIndex = 1;
            this.btnSpisakPacijenata.Text = "Spisak pacijenata";
            this.btnSpisakPacijenata.UseVisualStyleBackColor = true;
            this.btnSpisakPacijenata.Click += new System.EventHandler(this.btnSpisakPacijenata_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pronadji pacijenta:";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(76, 31);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(123, 21);
            this.txtIme.TabIndex = 4;
            this.txtIme.TextChanged += new System.EventHandler(this.txtImePrezime_TextChanged);
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(76, 58);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(123, 21);
            this.txtPrezime.TabIndex = 5;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            // 
            // btnPronadji
            // 
            this.btnPronadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronadji.Location = new System.Drawing.Point(76, 85);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(123, 23);
            this.btnPronadji.TabIndex = 6;
            this.btnPronadji.Text = "Pronadji";
            this.ttPronadjiImePrezime.SetToolTip(this.btnPronadji, "Precizno uneti ime i prezime pacijenta da bi pretraga bila ispravna");
            this.btnPronadji.UseVisualStyleBackColor = true;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezime:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPronadji);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIme);
            this.panel1.Controls.Add(this.txtPrezime);
            this.panel1.Location = new System.Drawing.Point(711, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 117);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // lblObavestenje
            // 
            this.lblObavestenje.AutoSize = true;
            this.lblObavestenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObavestenje.Location = new System.Drawing.Point(14, 111);
            this.lblObavestenje.Name = "lblObavestenje";
            this.lblObavestenje.Size = new System.Drawing.Size(363, 16);
            this.lblObavestenje.TabIndex = 11;
            this.lblObavestenje.Text = "Duplim klikom na korisnika,omogucena je izmena podataka";
            // 
            // lblZdravlje
            // 
            this.lblZdravlje.AutoSize = true;
            this.lblZdravlje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZdravlje.Location = new System.Drawing.Point(3, 63);
            this.lblZdravlje.Name = "lblZdravlje";
            this.lblZdravlje.Size = new System.Drawing.Size(144, 16);
            this.lblZdravlje.TabIndex = 12;
            this.lblZdravlje.Text = "Zdravstveno stanje:";
            // 
            // lblLekovi
            // 
            this.lblLekovi.AutoSize = true;
            this.lblLekovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLekovi.Location = new System.Drawing.Point(3, 167);
            this.lblLekovi.Name = "lblLekovi";
            this.lblLekovi.Size = new System.Drawing.Size(58, 16);
            this.lblLekovi.TabIndex = 13;
            this.lblLekovi.Text = "Lekovi:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(6, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 31);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Upis";
            this.ttUpis.SetToolTip(this.btnUpdate, "Omogucite izmenu podataka izabranog korisnika");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtZdravlje
            // 
            this.txtZdravlje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZdravlje.Location = new System.Drawing.Point(6, 82);
            this.txtZdravlje.Multiline = true;
            this.txtZdravlje.Name = "txtZdravlje";
            this.txtZdravlje.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtZdravlje.Size = new System.Drawing.Size(236, 82);
            this.txtZdravlje.TabIndex = 15;
            // 
            // txtLekovi
            // 
            this.txtLekovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLekovi.Location = new System.Drawing.Point(6, 186);
            this.txtLekovi.Multiline = true;
            this.txtLekovi.Name = "txtLekovi";
            this.txtLekovi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLekovi.Size = new System.Drawing.Size(236, 82);
            this.txtLekovi.TabIndex = 16;
            // 
            // labelaIme
            // 
            this.labelaIme.AutoSize = true;
            this.labelaIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaIme.Location = new System.Drawing.Point(3, 33);
            this.labelaIme.Name = "labelaIme";
            this.labelaIme.Size = new System.Drawing.Size(13, 18);
            this.labelaIme.TabIndex = 17;
            this.labelaIme.Text = ".";
            // 
            // labelaPrezime
            // 
            this.labelaPrezime.AutoSize = true;
            this.labelaPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaPrezime.Location = new System.Drawing.Point(3, 9);
            this.labelaPrezime.Name = "labelaPrezime";
            this.labelaPrezime.Size = new System.Drawing.Size(13, 18);
            this.labelaPrezime.TabIndex = 18;
            this.labelaPrezime.Text = ".";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.txtLekovi);
            this.panel2.Controls.Add(this.labelaIme);
            this.panel2.Controls.Add(this.labelaPrezime);
            this.panel2.Controls.Add(this.lblZdravlje);
            this.panel2.Controls.Add(this.lblLekovi);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtZdravlje);
            this.panel2.Location = new System.Drawing.Point(690, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 308);
            this.panel2.TabIndex = 19;
            // 
            // btnPronadjiKnjizica
            // 
            this.btnPronadjiKnjizica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronadjiKnjizica.Location = new System.Drawing.Point(41, 85);
            this.btnPronadjiKnjizica.Name = "btnPronadjiKnjizica";
            this.btnPronadjiKnjizica.Size = new System.Drawing.Size(123, 23);
            this.btnPronadjiKnjizica.TabIndex = 10;
            this.btnPronadjiKnjizica.Text = "Pronadji";
            this.ttPronadjiImePrezime.SetToolTip(this.btnPronadjiKnjizica, "Precizno uneti ime i prezime pacijenta da bi pretraga bila ispravna");
            this.btnPronadjiKnjizica.UseVisualStyleBackColor = true;
            this.btnPronadjiKnjizica.Click += new System.EventHandler(this.btnPronadjiKnjizica_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.btnPronadjiKnjizica);
            this.panel3.Controls.Add(this.txtBrojKnjizice);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(476, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 117);
            this.panel3.TabIndex = 20;
            // 
            // txtBrojKnjizice
            // 
            this.txtBrojKnjizice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojKnjizice.Location = new System.Drawing.Point(17, 59);
            this.txtBrojKnjizice.Name = "txtBrojKnjizice";
            this.txtBrojKnjizice.Size = new System.Drawing.Size(162, 21);
            this.txtBrojKnjizice.TabIndex = 9;
            this.txtBrojKnjizice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojKnjizice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Broj knjizice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pronadji pacijenta:";
            // 
            // FormaLekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 459);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblObavestenje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSpisakPacijenata);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormaLekar";
            this.ShowIcon = false;
            this.Text = "FormaLekar";
            this.Load += new System.EventHandler(this.FormaLekar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSpisakPacijenata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblObavestenje;
        private System.Windows.Forms.TextBox txtLekovi;
        private System.Windows.Forms.TextBox txtZdravlje;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblLekovi;
        private System.Windows.Forms.Label lblZdravlje;
        private System.Windows.Forms.Label labelaIme;
        private System.Windows.Forms.Label labelaPrezime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip ttPronadjiImePrezime;
        private System.Windows.Forms.ToolTip ttUpis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPronadjiKnjizica;
        private System.Windows.Forms.TextBox txtBrojKnjizice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}