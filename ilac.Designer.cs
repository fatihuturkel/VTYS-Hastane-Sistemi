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
            this.ilacidtextbox = new System.Windows.Forms.TextBox();
            this.isimtextbox = new System.Windows.Forms.TextBox();
            this.markatextbox = new System.Windows.Forms.TextBox();
            this.aciklamatextbox = new System.Windows.Forms.TextBox();
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
            this.ilacid.Location = new System.Drawing.Point(16, 39);
            this.ilacid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ilacid.Name = "ilacid";
            this.ilacid.Size = new System.Drawing.Size(134, 48);
            this.ilacid.TabIndex = 0;
            this.ilacid.Text = "ilacid";
            this.ilacid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isim
            // 
            this.isim.BackColor = System.Drawing.Color.White;
            this.isim.Location = new System.Drawing.Point(16, 117);
            this.isim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(134, 39);
            this.isim.TabIndex = 1;
            this.isim.Text = "isim:";
            this.isim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "marka:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 52);
            this.label4.TabIndex = 3;
            this.label4.Text = "aciklama:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilacidtextbox
            // 
            this.ilacidtextbox.Location = new System.Drawing.Point(196, 47);
            this.ilacidtextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ilacidtextbox.Name = "ilacidtextbox";
            this.ilacidtextbox.Size = new System.Drawing.Size(200, 30);
            this.ilacidtextbox.TabIndex = 4;
            // 
            // isimtextbox
            // 
            this.isimtextbox.Location = new System.Drawing.Point(196, 114);
            this.isimtextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isimtextbox.Name = "isimtextbox";
            this.isimtextbox.Size = new System.Drawing.Size(200, 30);
            this.isimtextbox.TabIndex = 5;
            // 
            // markatextbox
            // 
            this.markatextbox.Location = new System.Drawing.Point(196, 189);
            this.markatextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.markatextbox.Name = "markatextbox";
            this.markatextbox.Size = new System.Drawing.Size(200, 30);
            this.markatextbox.TabIndex = 6;
            // 
            // aciklamatextbox
            // 
            this.aciklamatextbox.Location = new System.Drawing.Point(196, 267);
            this.aciklamatextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aciklamatextbox.Name = "aciklamatextbox";
            this.aciklamatextbox.Size = new System.Drawing.Size(200, 30);
            this.aciklamatextbox.TabIndex = 7;
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(416, 91);
            this.Listele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(146, 56);
            this.Listele.TabIndex = 8;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(570, 91);
            this.Ekle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(142, 56);
            this.Ekle.TabIndex = 9;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(742, 91);
            this.Sil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(114, 56);
            this.Sil.TabIndex = 10;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(888, 91);
            this.Güncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(129, 56);
            this.Güncelle.TabIndex = 11;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 359);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 206);
            this.dataGridView1.TabIndex = 12;
            // 
            // ilac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1066, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.aciklamatextbox);
            this.Controls.Add(this.markatextbox);
            this.Controls.Add(this.isimtextbox);
            this.Controls.Add(this.ilacidtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.ilacid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ilac";
            this.Text = "ilac";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ilacid;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ilacidtextbox;
        private System.Windows.Forms.TextBox isimtextbox;
        private System.Windows.Forms.TextBox markatextbox;
        private System.Windows.Forms.TextBox aciklamatextbox;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}