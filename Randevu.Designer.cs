namespace hastane_deneme_1
{
    partial class Randevu
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
            this.label5 = new System.Windows.Forms.Label();
            this.randevuid_textbox = new System.Windows.Forms.TextBox();
            this.doktorid_textBox = new System.Windows.Forms.TextBox();
            this.hastaid_textbox = new System.Windows.Forms.TextBox();
            this.tarih_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.saat_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Ara = new System.Windows.Forms.Button();
            this.Listele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevu ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktor ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saat:";
            // 
            // randevuid_textbox
            // 
            this.randevuid_textbox.Location = new System.Drawing.Point(207, 49);
            this.randevuid_textbox.Name = "randevuid_textbox";
            this.randevuid_textbox.Size = new System.Drawing.Size(180, 30);
            this.randevuid_textbox.TabIndex = 5;
            // 
            // doktorid_textBox
            // 
            this.doktorid_textBox.Location = new System.Drawing.Point(207, 101);
            this.doktorid_textBox.Name = "doktorid_textBox";
            this.doktorid_textBox.Size = new System.Drawing.Size(180, 30);
            this.doktorid_textBox.TabIndex = 6;
            // 
            // hastaid_textbox
            // 
            this.hastaid_textbox.Location = new System.Drawing.Point(207, 156);
            this.hastaid_textbox.Name = "hastaid_textbox";
            this.hastaid_textbox.Size = new System.Drawing.Size(180, 30);
            this.hastaid_textbox.TabIndex = 7;
            // 
            // tarih_datetimepicker
            // 
            this.tarih_datetimepicker.Checked = false;
            this.tarih_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih_datetimepicker.Location = new System.Drawing.Point(207, 201);
            this.tarih_datetimepicker.Name = "tarih_datetimepicker";
            this.tarih_datetimepicker.Size = new System.Drawing.Size(180, 30);
            this.tarih_datetimepicker.TabIndex = 8;
            this.tarih_datetimepicker.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // saat_datetimepicker
            // 
            this.saat_datetimepicker.CustomFormat = "";
            this.saat_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.saat_datetimepicker.Location = new System.Drawing.Point(207, 245);
            this.saat_datetimepicker.Name = "saat_datetimepicker";
            this.saat_datetimepicker.Size = new System.Drawing.Size(180, 30);
            this.saat_datetimepicker.TabIndex = 9;
            this.saat_datetimepicker.Value = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 281);
            this.dataGridView1.TabIndex = 10;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(464, 49);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(91, 42);
            this.ekle.TabIndex = 69;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.UseWaitCursor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(606, 49);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(101, 42);
            this.Güncelle.TabIndex = 71;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.UseWaitCursor = true;
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(752, 49);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(84, 42);
            this.Sil.TabIndex = 72;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.UseWaitCursor = true;
            // 
            // Ara
            // 
            this.Ara.Location = new System.Drawing.Point(900, 49);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(107, 42);
            this.Ara.TabIndex = 75;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.UseWaitCursor = true;
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(1062, 49);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(86, 42);
            this.Listele.TabIndex = 76;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.UseWaitCursor = true;
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 619);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saat_datetimepicker);
            this.Controls.Add(this.tarih_datetimepicker);
            this.Controls.Add(this.hastaid_textbox);
            this.Controls.Add(this.doktorid_textBox);
            this.Controls.Add(this.randevuid_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Randevu";
            this.Text = "Randevu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox randevuid_textbox;
        private System.Windows.Forms.TextBox doktorid_textBox;
        private System.Windows.Forms.TextBox hastaid_textbox;
        private System.Windows.Forms.DateTimePicker tarih_datetimepicker;
        private System.Windows.Forms.DateTimePicker saat_datetimepicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.Button Listele;
    }
}