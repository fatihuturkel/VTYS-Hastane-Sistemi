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
            this.Listele = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ekipmanid1 = new System.Windows.Forms.TextBox();
            this.ekipmanid2 = new System.Windows.Forms.TextBox();
            this.ekipmanid3 = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.RichTextBox();
            this.Sil = new System.Windows.Forms.Button();
            this.Ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "islemid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "aciklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "isim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "ucret:";
            // 
            // islemid
            // 
            this.islemid.Location = new System.Drawing.Point(186, 28);
            this.islemid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.islemid.Name = "islemid";
            this.islemid.Size = new System.Drawing.Size(132, 30);
            this.islemid.TabIndex = 4;
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(186, 79);
            this.isim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(132, 30);
            this.isim.TabIndex = 5;
            // 
            // ucret
            // 
            this.ucret.Location = new System.Drawing.Point(186, 126);
            this.ucret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(132, 30);
            this.ucret.TabIndex = 6;
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(1281, 233);
            this.Listele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(116, 53);
            this.Listele.TabIndex = 8;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(1281, 101);
            this.Ekle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(116, 50);
            this.Ekle.TabIndex = 9;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(1070, 245);
            this.Güncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(116, 46);
            this.Güncelle.TabIndex = 11;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Visible = false;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 311);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1395, 220);
            this.dataGridView1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ekipman 1 ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ekipman 2 ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ekipman 3 ID:";
            // 
            // ekipmanid1
            // 
            this.ekipmanid1.Location = new System.Drawing.Point(186, 170);
            this.ekipmanid1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ekipmanid1.Name = "ekipmanid1";
            this.ekipmanid1.Size = new System.Drawing.Size(132, 30);
            this.ekipmanid1.TabIndex = 16;
            // 
            // ekipmanid2
            // 
            this.ekipmanid2.Location = new System.Drawing.Point(186, 214);
            this.ekipmanid2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ekipmanid2.Name = "ekipmanid2";
            this.ekipmanid2.Size = new System.Drawing.Size(132, 30);
            this.ekipmanid2.TabIndex = 17;
            // 
            // ekipmanid3
            // 
            this.ekipmanid3.Location = new System.Drawing.Point(186, 261);
            this.ekipmanid3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ekipmanid3.Name = "ekipmanid3";
            this.ekipmanid3.Size = new System.Drawing.Size(132, 30);
            this.ekipmanid3.TabIndex = 18;
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(564, 12);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(688, 214);
            this.aciklama.TabIndex = 19;
            this.aciklama.Text = "";
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(931, 245);
            this.Sil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(116, 45);
            this.Sil.TabIndex = 10;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Visible = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Ara
            // 
            this.Ara.Location = new System.Drawing.Point(1281, 175);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(116, 42);
            this.Ara.TabIndex = 76;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.UseWaitCursor = true;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 543);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.ekipmanid3);
            this.Controls.Add(this.ekipmanid2);
            this.Controls.Add(this.ekipmanid1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.ucret);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.islemid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "islem";
            this.Text = "islem";
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
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ekipmanid1;
        private System.Windows.Forms.TextBox ekipmanid2;
        private System.Windows.Forms.TextBox ekipmanid3;
        private System.Windows.Forms.RichTextBox aciklama;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Ara;
    }
}