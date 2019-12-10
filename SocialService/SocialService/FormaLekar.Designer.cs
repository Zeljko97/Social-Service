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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSpisakPacijenata = new System.Windows.Forms.Button();
            this.btnIzvestaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtIzvestaj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSpisakPacijenata
            // 
            this.btnSpisakPacijenata.Location = new System.Drawing.Point(27, 23);
            this.btnSpisakPacijenata.Name = "btnSpisakPacijenata";
            this.btnSpisakPacijenata.Size = new System.Drawing.Size(114, 49);
            this.btnSpisakPacijenata.TabIndex = 1;
            this.btnSpisakPacijenata.Text = "Spisak pacijenata";
            this.btnSpisakPacijenata.UseVisualStyleBackColor = true;
            this.btnSpisakPacijenata.Click += new System.EventHandler(this.btnSpisakPacijenata_Click);
            // 
            // btnIzvestaj
            // 
            this.btnIzvestaj.Location = new System.Drawing.Point(27, 107);
            this.btnIzvestaj.Name = "btnIzvestaj";
            this.btnIzvestaj.Size = new System.Drawing.Size(114, 51);
            this.btnIzvestaj.TabIndex = 2;
            this.btnIzvestaj.Text = "Novi izvestaj";
            this.btnIzvestaj.UseVisualStyleBackColor = true;
            this.btnIzvestaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pronadji pacijenta:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(300, 56);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(141, 20);
            this.txtIme.TabIndex = 4;
            this.txtIme.TextChanged += new System.EventHandler(this.txtImePrezime_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(462, 56);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(145, 20);
            this.txtPrezime.TabIndex = 5;
            // 
            // btnPronadji
            // 
            this.btnPronadji.Location = new System.Drawing.Point(637, 46);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(75, 23);
            this.btnPronadji.TabIndex = 6;
            this.btnPronadji.Text = "Pronadji";
            this.btnPronadji.UseVisualStyleBackColor = true;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezime:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(27, 375);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Visible = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtIzvestaj
            // 
            this.txtIzvestaj.Location = new System.Drawing.Point(27, 179);
            this.txtIzvestaj.Multiline = true;
            this.txtIzvestaj.Name = "txtIzvestaj";
            this.txtIzvestaj.Size = new System.Drawing.Size(379, 161);
            this.txtIzvestaj.TabIndex = 11;
            this.txtIzvestaj.Visible = false;
            this.txtIzvestaj.TextChanged += new System.EventHandler(this.txtIzvestaj_TextChanged);
            // 
            // FormaLekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 434);
            this.Controls.Add(this.txtIzvestaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzvestaj);
            this.Controls.Add(this.btnSpisakPacijenata);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormaLekar";
            this.Text = "FormaLekar";
            this.Load += new System.EventHandler(this.FormaLekar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSpisakPacijenata;
        private System.Windows.Forms.Button btnIzvestaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtIzvestaj;
    }
}