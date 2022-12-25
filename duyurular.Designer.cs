namespace hastane_deneme_1
{
    partial class duyurular
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
            this.baslik = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.Listele = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.duyuruid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "baslik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "aciklama:";
            // 
            // baslik
            // 
            this.baslik.Location = new System.Drawing.Point(163, 108);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(100, 26);
            this.baslik.TabIndex = 2;
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(163, 149);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(100, 26);
            this.aciklama.TabIndex = 3;
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(301, 53);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(116, 34);
            this.Listele.TabIndex = 4;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(423, 55);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(116, 32);
            this.Ekle.TabIndex = 5;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(545, 53);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(116, 34);
            this.Sil.TabIndex = 6;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(667, 54);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(116, 32);
            this.Güncelle.TabIndex = 7;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(798, 178);
            this.dataGridView1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "duyuruid";
            // 
            // duyuruid
            // 
            this.duyuruid.Location = new System.Drawing.Point(163, 58);
            this.duyuruid.Name = "duyuruid";
            this.duyuruid.Size = new System.Drawing.Size(100, 26);
            this.duyuruid.TabIndex = 10;
            // 
            // duyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.duyuruid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "duyurular";
            this.Text = "duyurular";
            this.Load += new System.EventHandler(this.duyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baslik;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox duyuruid;
    }
}