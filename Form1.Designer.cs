namespace hastane_deneme_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ilac = new System.Windows.Forms.Button();
            this.hasta = new System.Windows.Forms.Button();
            this.envanter = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.hemsire_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "sigorta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ilac
            // 
            this.ilac.Location = new System.Drawing.Point(40, 180);
            this.ilac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ilac.Name = "ilac";
            this.ilac.Size = new System.Drawing.Size(127, 41);
            this.ilac.TabIndex = 2;
            this.ilac.Text = "ilac";
            this.ilac.UseVisualStyleBackColor = true;
            this.ilac.Click += new System.EventHandler(this.ilac_Click);
            // 
            // hasta
            // 
            this.hasta.Location = new System.Drawing.Point(40, 252);
            this.hasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(127, 41);
            this.hasta.TabIndex = 3;
            this.hasta.Text = "hasta";
            this.hasta.UseVisualStyleBackColor = true;
            this.hasta.Click += new System.EventHandler(this.hasta_Click);
            // 
            // envanter
            // 
            this.envanter.Location = new System.Drawing.Point(40, 324);
            this.envanter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.envanter.Name = "envanter";
            this.envanter.Size = new System.Drawing.Size(122, 41);
            this.envanter.TabIndex = 4;
            this.envanter.Text = "envanter";
            this.envanter.UseVisualStyleBackColor = true;
            this.envanter.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "ekipman";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // hemsire_button
            // 
            this.hemsire_button.Location = new System.Drawing.Point(193, 202);
            this.hemsire_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hemsire_button.Name = "hemsire_button";
            this.hemsire_button.Size = new System.Drawing.Size(108, 33);
            this.hemsire_button.TabIndex = 5;
            this.hemsire_button.Text = "Hemsire";
            this.hemsire_button.UseVisualStyleBackColor = true;
            this.hemsire_button.Click += new System.EventHandler(this.hemsire_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button3);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hemsire_button);
            this.Controls.Add(this.envanter);
            this.Controls.Add(this.hasta);
            this.Controls.Add(this.ilac);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ilac;
        private System.Windows.Forms.Button hasta;
        private System.Windows.Forms.Button envanter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button hemsire_button;
    }
}

