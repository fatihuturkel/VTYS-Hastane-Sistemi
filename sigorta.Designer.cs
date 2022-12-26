namespace hastane_deneme_1
{
    partial class sigorta
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
            this.listele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mersisNo = new System.Windows.Forms.TextBox();
            this.telNo = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sigortaid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(929, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(606, 39);
            this.listele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(94, 48);
            this.listele.TabIndex = 3;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "isim:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "telNo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "adres:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "mersisNo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mersisNo
            // 
            this.mersisNo.Location = new System.Drawing.Point(157, 101);
            this.mersisNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mersisNo.Name = "mersisNo";
            this.mersisNo.Size = new System.Drawing.Size(157, 22);
            this.mersisNo.TabIndex = 8;
            // 
            // telNo
            // 
            this.telNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.telNo.Location = new System.Drawing.Point(157, 63);
            this.telNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telNo.Name = "telNo";
            this.telNo.Size = new System.Drawing.Size(157, 22);
            this.telNo.TabIndex = 9;
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(157, 33);
            this.isim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(157, 22);
            this.isim.TabIndex = 10;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(157, 134);
            this.adres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(157, 22);
            this.adres.TabIndex = 11;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(354, 39);
            this.ekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(101, 48);
            this.ekle.TabIndex = 12;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(483, 39);
            this.sil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(87, 48);
            this.sil.TabIndex = 13;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.button3_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(746, 33);
            this.guncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(107, 54);
            this.guncelle.TabIndex = 14;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "sigortaid";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "sigortaid:";
            // 
            // sigortaid
            // 
            this.sigortaid.Location = new System.Drawing.Point(157, 7);
            this.sigortaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sigortaid.Name = "sigortaid";
            this.sigortaid.Size = new System.Drawing.Size(157, 22);
            this.sigortaid.TabIndex = 16;
            // 
            // sigorta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 452);
            this.Controls.Add(this.sigortaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.telNo);
            this.Controls.Add(this.mersisNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sigorta";
            this.Text = "sigorta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mersisNo;
        private System.Windows.Forms.TextBox telNo;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sigortaid;
        private System.Windows.Forms.Button ekle;
    }
}