namespace hastane_deneme_1
{
    partial class envanter
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
            this.urunid = new System.Windows.Forms.TextBox();
            this.ucret = new System.Windows.Forms.TextBox();
            this.tedarikci = new System.Windows.Forms.TextBox();
            this.adet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "urunid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ucret:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "tedarikci:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "adet:";
            // 
            // urunid
            // 
            this.urunid.Location = new System.Drawing.Point(137, 88);
            this.urunid.Name = "urunid";
            this.urunid.Size = new System.Drawing.Size(100, 26);
            this.urunid.TabIndex = 4;
            // 
            // ucret
            // 
            this.ucret.Location = new System.Drawing.Point(137, 128);
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(100, 26);
            this.ucret.TabIndex = 5;
            // 
            // tedarikci
            // 
            this.tedarikci.Location = new System.Drawing.Point(137, 176);
            this.tedarikci.Name = "tedarikci";
            this.tedarikci.Size = new System.Drawing.Size(100, 26);
            this.tedarikci.TabIndex = 6;
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(137, 219);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(100, 26);
            this.adet.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 36);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(808, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 36);
            this.button4.TabIndex = 11;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(967, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // envanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.tedarikci);
            this.Controls.Add(this.ucret);
            this.Controls.Add(this.urunid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "envanter";
            this.Text = "envanter";
            this.Load += new System.EventHandler(this.envanter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urunid;
        private System.Windows.Forms.TextBox ucret;
        private System.Windows.Forms.TextBox tedarikci;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}