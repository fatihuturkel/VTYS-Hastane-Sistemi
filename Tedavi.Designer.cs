namespace hastane_deneme_1
{
    partial class Tedavi
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
            this.Listele = new System.Windows.Forms.Button();
            this.Ara = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tarih_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.hastaid_textbox = new System.Windows.Forms.TextBox();
            this.doktorid_textBox = new System.Windows.Forms.TextBox();
            this.tedaviid_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ucret_textBox = new System.Windows.Forms.TextBox();
            this.aciklama_ricttextbox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.islemid1 = new System.Windows.Forms.TextBox();
            this.islemid2 = new System.Windows.Forms.TextBox();
            this.islemid3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hemsire_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(1223, 288);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(107, 42);
            this.Listele.TabIndex = 92;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.UseWaitCursor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // Ara
            // 
            this.Ara.Location = new System.Drawing.Point(1223, 240);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(107, 42);
            this.Ara.TabIndex = 91;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.UseWaitCursor = true;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(1056, 296);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(107, 42);
            this.Sil.TabIndex = 90;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.UseWaitCursor = true;
            this.Sil.Visible = false;
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(943, 296);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(107, 42);
            this.Güncelle.TabIndex = 89;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.UseWaitCursor = true;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(1223, 192);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(107, 42);
            this.ekle.TabIndex = 88;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.UseWaitCursor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 250);
            this.dataGridView1.TabIndex = 87;
            // 
            // tarih_datetimepicker
            // 
            this.tarih_datetimepicker.Checked = false;
            this.tarih_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih_datetimepicker.Location = new System.Drawing.Point(253, 179);
            this.tarih_datetimepicker.Name = "tarih_datetimepicker";
            this.tarih_datetimepicker.Size = new System.Drawing.Size(180, 30);
            this.tarih_datetimepicker.TabIndex = 85;
            this.tarih_datetimepicker.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // hastaid_textbox
            // 
            this.hastaid_textbox.Location = new System.Drawing.Point(253, 134);
            this.hastaid_textbox.Name = "hastaid_textbox";
            this.hastaid_textbox.Size = new System.Drawing.Size(180, 30);
            this.hastaid_textbox.TabIndex = 84;
            // 
            // doktorid_textBox
            // 
            this.doktorid_textBox.Location = new System.Drawing.Point(253, 79);
            this.doktorid_textBox.Name = "doktorid_textBox";
            this.doktorid_textBox.Size = new System.Drawing.Size(180, 30);
            this.doktorid_textBox.TabIndex = 83;
            // 
            // tedaviid_textbox
            // 
            this.tedaviid_textbox.Location = new System.Drawing.Point(253, 27);
            this.tedaviid_textbox.Name = "tedaviid_textbox";
            this.tedaviid_textbox.Size = new System.Drawing.Size(180, 30);
            this.tedaviid_textbox.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 81;
            this.label5.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 80;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 79;
            this.label3.Text = "Hasta ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "Doktor ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Tedavi ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 93;
            this.label6.Text = "Ücret:";
            // 
            // ucret_textBox
            // 
            this.ucret_textBox.Location = new System.Drawing.Point(253, 228);
            this.ucret_textBox.Name = "ucret_textBox";
            this.ucret_textBox.Size = new System.Drawing.Size(180, 30);
            this.ucret_textBox.TabIndex = 94;
            // 
            // aciklama_ricttextbox
            // 
            this.aciklama_ricttextbox.Location = new System.Drawing.Point(676, 24);
            this.aciklama_ricttextbox.Name = "aciklama_ricttextbox";
            this.aciklama_ricttextbox.Size = new System.Drawing.Size(506, 170);
            this.aciklama_ricttextbox.TabIndex = 96;
            this.aciklama_ricttextbox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 25);
            this.label7.TabIndex = 97;
            this.label7.Text = "Kullanılan İslem 1 ID:";
            // 
            // islemid1
            // 
            this.islemid1.Location = new System.Drawing.Point(676, 209);
            this.islemid1.Name = "islemid1";
            this.islemid1.Size = new System.Drawing.Size(180, 30);
            this.islemid1.TabIndex = 98;
            // 
            // islemid2
            // 
            this.islemid2.Location = new System.Drawing.Point(676, 260);
            this.islemid2.Name = "islemid2";
            this.islemid2.Size = new System.Drawing.Size(180, 30);
            this.islemid2.TabIndex = 99;
            // 
            // islemid3
            // 
            this.islemid3.Location = new System.Drawing.Point(676, 308);
            this.islemid3.Name = "islemid3";
            this.islemid3.Size = new System.Drawing.Size(180, 30);
            this.islemid3.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 101;
            this.label8.Text = "Hemsire ID:";
            // 
            // hemsire_textBox
            // 
            this.hemsire_textBox.Location = new System.Drawing.Point(253, 277);
            this.hemsire_textBox.Name = "hemsire_textBox";
            this.hemsire_textBox.Size = new System.Drawing.Size(180, 30);
            this.hemsire_textBox.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 257);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 25);
            this.label9.TabIndex = 103;
            this.label9.Text = "Kullanılan İslem 2 ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 308);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 25);
            this.label10.TabIndex = 104;
            this.label10.Text = "Kullanılan İslem 3 ID:";
            // 
            // Tedavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 634);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hemsire_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.islemid3);
            this.Controls.Add(this.islemid2);
            this.Controls.Add(this.islemid1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aciklama_ricttextbox);
            this.Controls.Add(this.ucret_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tarih_datetimepicker);
            this.Controls.Add(this.hastaid_textbox);
            this.Controls.Add(this.doktorid_textBox);
            this.Controls.Add(this.tedaviid_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tedavi";
            this.Text = "Tedavi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker tarih_datetimepicker;
        private System.Windows.Forms.TextBox hastaid_textbox;
        private System.Windows.Forms.TextBox doktorid_textBox;
        private System.Windows.Forms.TextBox tedaviid_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ucret_textBox;
        private System.Windows.Forms.RichTextBox aciklama_ricttextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox islemid1;
        private System.Windows.Forms.TextBox islemid2;
        private System.Windows.Forms.TextBox islemid3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hemsire_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}