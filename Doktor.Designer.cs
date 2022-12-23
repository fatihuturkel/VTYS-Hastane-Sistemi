namespace hastane_deneme_1
{
    partial class Doktor
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.isim_textbox = new System.Windows.Forms.TextBox();
            this.soyisim_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcno_textbox = new System.Windows.Forms.TextBox();
            this.telNo_textbox = new System.Windows.Forms.TextBox();
            this.dogumTarihi_date = new System.Windows.Forms.DateTimePicker();
            this.cinsiyet_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1177, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 570);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsim:";
            this.label1.UseWaitCursor = true;
            // 
            // isim_textbox
            // 
            this.isim_textbox.Location = new System.Drawing.Point(848, 68);
            this.isim_textbox.Name = "isim_textbox";
            this.isim_textbox.Size = new System.Drawing.Size(258, 28);
            this.isim_textbox.TabIndex = 3;
            this.isim_textbox.UseWaitCursor = true;
            // 
            // soyisim_textbox
            // 
            this.soyisim_textbox.Location = new System.Drawing.Point(848, 105);
            this.soyisim_textbox.Name = "soyisim_textbox";
            this.soyisim_textbox.Size = new System.Drawing.Size(258, 28);
            this.soyisim_textbox.TabIndex = 4;
            this.soyisim_textbox.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyisim:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cinsiyet:";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doğum Tarihi:";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(700, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "TC Kimlik No:";
            this.label5.UseWaitCursor = true;
            // 
            // tcno_textbox
            // 
            this.tcno_textbox.Location = new System.Drawing.Point(848, 139);
            this.tcno_textbox.Name = "tcno_textbox";
            this.tcno_textbox.Size = new System.Drawing.Size(258, 28);
            this.tcno_textbox.TabIndex = 9;
            this.tcno_textbox.UseWaitCursor = true;
            // 
            // telNo_textbox
            // 
            this.telNo_textbox.Location = new System.Drawing.Point(848, 243);
            this.telNo_textbox.Name = "telNo_textbox";
            this.telNo_textbox.Size = new System.Drawing.Size(258, 28);
            this.telNo_textbox.TabIndex = 10;
            this.telNo_textbox.UseWaitCursor = true;
            // 
            // dogumTarihi_date
            // 
            this.dogumTarihi_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dogumTarihi_date.Location = new System.Drawing.Point(848, 173);
            this.dogumTarihi_date.Name = "dogumTarihi_date";
            this.dogumTarihi_date.Size = new System.Drawing.Size(258, 28);
            this.dogumTarihi_date.TabIndex = 11;
            this.dogumTarihi_date.UseWaitCursor = true;
            // 
            // cinsiyet_combobox
            // 
            this.cinsiyet_combobox.FormattingEnabled = true;
            this.cinsiyet_combobox.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cinsiyet_combobox.Location = new System.Drawing.Point(848, 207);
            this.cinsiyet_combobox.Name = "cinsiyet_combobox";
            this.cinsiyet_combobox.Size = new System.Drawing.Size(258, 30);
            this.cinsiyet_combobox.TabIndex = 12;
            this.cinsiyet_combobox.Text = "Lütfen Seçiniz.";
            this.cinsiyet_combobox.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefon No:";
            this.label6.UseWaitCursor = true;
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 753);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cinsiyet_combobox);
            this.Controls.Add(this.dogumTarihi_date);
            this.Controls.Add(this.telNo_textbox);
            this.Controls.Add(this.tcno_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soyisim_textbox);
            this.Controls.Add(this.isim_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Doktor";
            this.Text = "Doktor";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isim_textbox;
        private System.Windows.Forms.TextBox soyisim_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tcno_textbox;
        private System.Windows.Forms.TextBox telNo_textbox;
        private System.Windows.Forms.DateTimePicker dogumTarihi_date;
        private System.Windows.Forms.ComboBox cinsiyet_combobox;
        private System.Windows.Forms.Label label6;
    }
}