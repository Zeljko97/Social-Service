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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUcitajKorisnike = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUcitajKorisnike
            // 
            this.btnUcitajKorisnike.Location = new System.Drawing.Point(31, 26);
            this.btnUcitajKorisnike.Name = "btnUcitajKorisnike";
            this.btnUcitajKorisnike.Size = new System.Drawing.Size(145, 45);
            this.btnUcitajKorisnike.TabIndex = 1;
            this.btnUcitajKorisnike.Text = "Ucitaj korisnike doma";
            this.btnUcitajKorisnike.UseVisualStyleBackColor = true;
            this.btnUcitajKorisnike.Click += new System.EventHandler(this.btnUcitajKorisnike_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(31, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "OBRISI";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 542);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUcitajKorisnike);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKorisnici";
            this.Text = "FormKorisnici";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUcitajKorisnike;
        private System.Windows.Forms.Button btnDelete;
    }
}