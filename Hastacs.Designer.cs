namespace hastane_deneme_1
{
    partial class Hastacs
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
            this.isim_textBox = new System.Windows.Forms.TextBox();
            this.soyisim_textBox = new System.Windows.Forms.TextBox();
            this.Tc_textBox = new System.Windows.Forms.TextBox();
            this.dogumTarihi_date = new System.Windows.Forms.DateTimePicker();
            this.cinsiyet_combobox = new System.Windows.Forms.ComboBox();
            this.telNo_textbox = new System.Windows.Forms.TextBox();
            this.sigorta_textBox = new System.Windows.Forms.TextBox();
            this.isim_label = new System.Windows.Forms.Label();
            this.ilacid = new System.Windows.Forms.Label();
            this.tcNo_label = new System.Windows.Forms.Label();
            this.soyisim_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.Listele = new System.Windows.Forms.Button();
            this.Ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 321);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 286);
            this.dataGridView1.TabIndex = 13;
            // 
            // isim_textBox
            // 
            this.isim_textBox.Location = new System.Drawing.Point(181, 15);
            this.isim_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isim_textBox.Name = "isim_textBox";
            this.isim_textBox.Size = new System.Drawing.Size(135, 22);
            this.isim_textBox.TabIndex = 14;
            // 
            // soyisim_textBox
            // 
            this.soyisim_textBox.Location = new System.Drawing.Point(181, 56);
            this.soyisim_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soyisim_textBox.Name = "soyisim_textBox";
            this.soyisim_textBox.Size = new System.Drawing.Size(135, 22);
            this.soyisim_textBox.TabIndex = 15;
            // 
            // Tc_textBox
            // 
            this.Tc_textBox.Location = new System.Drawing.Point(181, 100);
            this.Tc_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tc_textBox.Name = "Tc_textBox";
            this.Tc_textBox.Size = new System.Drawing.Size(135, 22);
            this.Tc_textBox.TabIndex = 16;
            // 
            // dogumTarihi_date
            // 
            this.dogumTarihi_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dogumTarihi_date.Location = new System.Drawing.Point(181, 148);
            this.dogumTarihi_date.Name = "dogumTarihi_date";
            this.dogumTarihi_date.Size = new System.Drawing.Size(135, 22);
            this.dogumTarihi_date.TabIndex = 17;
            this.dogumTarihi_date.UseWaitCursor = true;
            // 
            // cinsiyet_combobox
            // 
            this.cinsiyet_combobox.FormattingEnabled = true;
            this.cinsiyet_combobox.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cinsiyet_combobox.Location = new System.Drawing.Point(181, 197);
            this.cinsiyet_combobox.Name = "cinsiyet_combobox";
            this.cinsiyet_combobox.Size = new System.Drawing.Size(135, 24);
            this.cinsiyet_combobox.TabIndex = 18;
            this.cinsiyet_combobox.Text = "Lütfen Seçiniz.";
            this.cinsiyet_combobox.UseWaitCursor = true;
            // 
            // telNo_textbox
            // 
            this.telNo_textbox.Location = new System.Drawing.Point(181, 238);
            this.telNo_textbox.Name = "telNo_textbox";
            this.telNo_textbox.Size = new System.Drawing.Size(135, 22);
            this.telNo_textbox.TabIndex = 19;
            this.telNo_textbox.UseWaitCursor = true;
            // 
            // sigorta_textBox
            // 
            this.sigorta_textBox.Location = new System.Drawing.Point(181, 279);
            this.sigorta_textBox.Name = "sigorta_textBox";
            this.sigorta_textBox.Size = new System.Drawing.Size(135, 22);
            this.sigorta_textBox.TabIndex = 20;
            this.sigorta_textBox.Text = "Yok";
            this.sigorta_textBox.UseWaitCursor = true;
            // 
            // isim_label
            // 
            this.isim_label.BackColor = System.Drawing.Color.White;
            this.isim_label.Location = new System.Drawing.Point(12, 11);
            this.isim_label.Name = "isim_label";
            this.isim_label.Size = new System.Drawing.Size(126, 31);
            this.isim_label.TabIndex = 21;
            this.isim_label.Text = "İsim:";
            this.isim_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilacid
            // 
            this.ilacid.BackColor = System.Drawing.Color.White;
            this.ilacid.Location = new System.Drawing.Point(12, 148);
            this.ilacid.Name = "ilacid";
            this.ilacid.Size = new System.Drawing.Size(126, 31);
            this.ilacid.TabIndex = 22;
            this.ilacid.Text = "Doğum Tarihi:";
            this.ilacid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcNo_label
            // 
            this.tcNo_label.BackColor = System.Drawing.Color.White;
            this.tcNo_label.Location = new System.Drawing.Point(12, 100);
            this.tcNo_label.Name = "tcNo_label";
            this.tcNo_label.Size = new System.Drawing.Size(126, 31);
            this.tcNo_label.TabIndex = 23;
            this.tcNo_label.Text = "TC NO:";
            this.tcNo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soyisim_label
            // 
            this.soyisim_label.BackColor = System.Drawing.Color.White;
            this.soyisim_label.Location = new System.Drawing.Point(12, 56);
            this.soyisim_label.Name = "soyisim_label";
            this.soyisim_label.Size = new System.Drawing.Size(126, 31);
            this.soyisim_label.TabIndex = 24;
            this.soyisim_label.Text = "Soyisim:";
            this.soyisim_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cinsiyet:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "Telefon Numarası:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sigorta ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(364, 15);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(91, 42);
            this.ekle.TabIndex = 28;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(634, 15);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(84, 42);
            this.Sil.TabIndex = 29;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(490, 15);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(101, 42);
            this.Güncelle.TabIndex = 30;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(923, 15);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(86, 42);
            this.Listele.TabIndex = 31;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // Ara
            // 
            this.Ara.Location = new System.Drawing.Point(776, 15);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(107, 42);
            this.Ara.TabIndex = 75;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.UseWaitCursor = true;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // Hastacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 618);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyisim_label);
            this.Controls.Add(this.tcNo_label);
            this.Controls.Add(this.ilacid);
            this.Controls.Add(this.isim_label);
            this.Controls.Add(this.sigorta_textBox);
            this.Controls.Add(this.telNo_textbox);
            this.Controls.Add(this.cinsiyet_combobox);
            this.Controls.Add(this.dogumTarihi_date);
            this.Controls.Add(this.Tc_textBox);
            this.Controls.Add(this.soyisim_textBox);
            this.Controls.Add(this.isim_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Hastacs";
            this.Text = "Hastacs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox isim_textBox;
        private System.Windows.Forms.TextBox soyisim_textBox;
        private System.Windows.Forms.TextBox Tc_textBox;
        private System.Windows.Forms.DateTimePicker dogumTarihi_date;
        private System.Windows.Forms.ComboBox cinsiyet_combobox;
        private System.Windows.Forms.TextBox telNo_textbox;
        private System.Windows.Forms.TextBox sigorta_textBox;
        private System.Windows.Forms.Label isim_label;
        private System.Windows.Forms.Label ilacid;
        private System.Windows.Forms.Label tcNo_label;
        private System.Windows.Forms.Label soyisim_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Button Ara;
    }
}