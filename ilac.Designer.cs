namespace hastane_deneme_1
{
    partial class ilac
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
            this.ilacid = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.Listele = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ilacid
            // 
            this.ilacid.BackColor = System.Drawing.Color.White;
            this.ilacid.Location = new System.Drawing.Point(12, 31);
            this.ilacid.Name = "ilacid";
            this.ilacid.Size = new System.Drawing.Size(100, 39);
            this.ilacid.TabIndex = 0;
            this.ilacid.Text = "ilacid";
            this.ilacid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isim
            // 
            this.isim.BackColor = System.Drawing.Color.White;
            this.isim.Location = new System.Drawing.Point(12, 94);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(100, 31);
            this.isim.TabIndex = 1;
            this.isim.Text = "isim:";
            this.isim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "marka:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "aciklama:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 26);
            this.textBox2.TabIndex = 5;
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(147, 151);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(151, 26);
            this.marka.TabIndex = 6;
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(147, 214);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(151, 26);
            this.aciklama.TabIndex = 7;
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(312, 72);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(109, 45);
            this.Listele.TabIndex = 8;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(427, 72);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(107, 45);
            this.Ekle.TabIndex = 9;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(557, 72);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(85, 45);
            this.Sil.TabIndex = 10;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(666, 72);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(97, 45);
            this.Güncelle.TabIndex = 11;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(798, 165);
            this.dataGridView1.TabIndex = 12;
            // 
            // ilac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.ilacid);
            this.Name = "ilac";
            this.Text = "ilac";
            this.Load += new System.EventHandler(this.ilac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ilacid;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}