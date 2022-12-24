namespace hastane_deneme_1
{
    partial class islem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.islemid = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.TextBox();
            this.ucret = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.Listele = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "islemid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "aciklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "isim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ucret:";
            // 
            // islemid
            // 
            this.islemid.Location = new System.Drawing.Point(140, 36);
            this.islemid.Name = "islemid";
            this.islemid.Size = new System.Drawing.Size(100, 26);
            this.islemid.TabIndex = 4;
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(140, 120);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(100, 26);
            this.isim.TabIndex = 5;
            // 
            // ucret
            // 
            this.ucret.Location = new System.Drawing.Point(140, 168);
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(100, 26);
            this.ucret.TabIndex = 6;
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(140, 74);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(100, 26);
            this.aciklama.TabIndex = 7;
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(289, 46);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(106, 39);
            this.Listele.TabIndex = 8;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(430, 46);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(94, 39);
            this.Ekle.TabIndex = 9;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(557, 46);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(88, 39);
            this.Sil.TabIndex = 10;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(684, 46);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(83, 39);
            this.Güncelle.TabIndex = 11;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(796, 170);
            this.dataGridView1.TabIndex = 12;
            // 
            // islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.ucret);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.islemid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "islem";
            this.Text = "islem";
            this.Load += new System.EventHandler(this.islem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox islemid;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox ucret;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}