namespace hastane_deneme_1
{
    partial class Recete
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
            this.Ara = new System.Windows.Forms.Button();
            this.doz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Güncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.Listele = new System.Windows.Forms.Button();
            this.kullanimsikligi = new System.Windows.Forms.TextBox();
            this.tedaviid = new System.Windows.Forms.TextBox();
            this.receteid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aciklama = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ilacid1_textbox = new System.Windows.Forms.TextBox();
            this.ilacid2_textbox = new System.Windows.Forms.TextBox();
            this.ilacid3_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ara
            // 
            this.Ara.Location = new System.Drawing.Point(1028, 159);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(137, 51);
            this.Ara.TabIndex = 96;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.UseWaitCursor = true;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // doz
            // 
            this.doz.Location = new System.Drawing.Point(215, 67);
            this.doz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.doz.Name = "doz";
            this.doz.Size = new System.Drawing.Size(132, 30);
            this.doz.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 94;
            this.label7.Text = "Doz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 92;
            this.label6.Text = "Tedavi ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 352);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1196, 182);
            this.dataGridView1.TabIndex = 91;
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(685, 252);
            this.Güncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(126, 53);
            this.Güncelle.TabIndex = 90;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Visible = false;
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(848, 252);
            this.Sil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(114, 53);
            this.Sil.TabIndex = 89;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Visible = false;
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(1028, 67);
            this.Ekle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(136, 53);
            this.Ekle.TabIndex = 88;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(1028, 252);
            this.Listele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(137, 53);
            this.Listele.TabIndex = 87;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // kullanimsikligi
            // 
            this.kullanimsikligi.Location = new System.Drawing.Point(215, 111);
            this.kullanimsikligi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kullanimsikligi.Name = "kullanimsikligi";
            this.kullanimsikligi.Size = new System.Drawing.Size(132, 30);
            this.kullanimsikligi.TabIndex = 85;
            // 
            // tedaviid
            // 
            this.tedaviid.Location = new System.Drawing.Point(215, 159);
            this.tedaviid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tedaviid.Name = "tedaviid";
            this.tedaviid.Size = new System.Drawing.Size(132, 30);
            this.tedaviid.TabIndex = 84;
            // 
            // receteid
            // 
            this.receteid.Location = new System.Drawing.Point(215, 20);
            this.receteid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.receteid.Name = "receteid";
            this.receteid.Size = new System.Drawing.Size(132, 30);
            this.receteid.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Açıklama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "Kullanım Sıklığı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 79;
            this.label1.Text = "Reçete ID:";
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(215, 202);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(389, 137);
            this.aciklama.TabIndex = 97;
            this.aciklama.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 98;
            this.label3.Text = "İlaç ID 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 99;
            this.label5.Text = "İlaç ID 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 100;
            this.label8.Text = "İlaç ID 3:";
            // 
            // ilacid1_textbox
            // 
            this.ilacid1_textbox.Location = new System.Drawing.Point(613, 25);
            this.ilacid1_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ilacid1_textbox.Name = "ilacid1_textbox";
            this.ilacid1_textbox.Size = new System.Drawing.Size(132, 30);
            this.ilacid1_textbox.TabIndex = 101;
            // 
            // ilacid2_textbox
            // 
            this.ilacid2_textbox.Location = new System.Drawing.Point(613, 67);
            this.ilacid2_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ilacid2_textbox.Name = "ilacid2_textbox";
            this.ilacid2_textbox.Size = new System.Drawing.Size(132, 30);
            this.ilacid2_textbox.TabIndex = 102;
            // 
            // ilacid3_textbox
            // 
            this.ilacid3_textbox.Location = new System.Drawing.Point(613, 111);
            this.ilacid3_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ilacid3_textbox.Name = "ilacid3_textbox";
            this.ilacid3_textbox.Size = new System.Drawing.Size(132, 30);
            this.ilacid3_textbox.TabIndex = 103;
            // 
            // Recete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 541);
            this.Controls.Add(this.ilacid3_textbox);
            this.Controls.Add(this.ilacid2_textbox);
            this.Controls.Add(this.ilacid1_textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.doz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.kullanimsikligi);
            this.Controls.Add(this.tedaviid);
            this.Controls.Add(this.receteid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Recete";
            this.Text = "Recete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.TextBox doz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.TextBox kullanimsikligi;
        private System.Windows.Forms.TextBox tedaviid;
        private System.Windows.Forms.TextBox receteid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox aciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ilacid1_textbox;
        private System.Windows.Forms.TextBox ilacid2_textbox;
        private System.Windows.Forms.TextBox ilacid3_textbox;
    }
}