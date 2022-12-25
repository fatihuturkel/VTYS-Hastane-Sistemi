using System;
using System.Windows.Forms;

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
            this.doktor_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ilac = new System.Windows.Forms.Button();
            this.hasta = new System.Windows.Forms.Button();
            this.envanter = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.islem = new System.Windows.Forms.Button();
            this.hemsire_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doktor_button
            // 
            this.doktor_button.Location = new System.Drawing.Point(295, 200);
            this.doktor_button.Name = "doktor_button";
            this.doktor_button.Size = new System.Drawing.Size(116, 32);
            this.doktor_button.TabIndex = 0;
            this.doktor_button.Text = "Doktor";
            this.doktor_button.UseVisualStyleBackColor = true;
            this.doktor_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "sigorta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ilac
            // 
            this.ilac.Location = new System.Drawing.Point(36, 144);
            this.ilac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ilac.Name = "ilac";
            this.ilac.Size = new System.Drawing.Size(113, 33);
            this.ilac.TabIndex = 2;
            this.ilac.Text = "ilac";
            this.ilac.UseVisualStyleBackColor = true;
            this.ilac.Click += new System.EventHandler(this.ilac_Click);
            // 
            // hasta
            // 
            this.hasta.Location = new System.Drawing.Point(36, 202);
            this.hasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(113, 30);
            this.hasta.TabIndex = 3;
            this.hasta.Text = "Hasta";
            this.hasta.UseVisualStyleBackColor = true;
            this.hasta.Click += new System.EventHandler(this.hasta_Click);
            // 
            // envanter
            // 
            this.envanter.Location = new System.Drawing.Point(36, 259);
            this.envanter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.envanter.Name = "envanter";
            this.envanter.Size = new System.Drawing.Size(108, 33);
            this.envanter.TabIndex = 4;
            this.envanter.Text = "envanter";
            this.envanter.UseVisualStyleBackColor = true;
            this.envanter.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 311);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "ekipman";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // islem
            // 
            this.islem.Location = new System.Drawing.Point(304, 31);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(107, 40);
            this.islem.TabIndex = 6;
            this.islem.Text = "islem";
            this.islem.UseVisualStyleBackColor = true;
            this.islem.Click += new System.EventHandler(this.islem_Click);
            // 
            // hemsire_button
            // 
            this.hemsire_button.Location = new System.Drawing.Point(173, 202);
            this.hemsire_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hemsire_button.Name = "hemsire_button";
            this.hemsire_button.Size = new System.Drawing.Size(104, 30);
            this.hemsire_button.TabIndex = 5;
            this.hemsire_button.Text = "Hemsire";
            this.hemsire_button.UseVisualStyleBackColor = true;
            this.hemsire_button.Click += new System.EventHandler(this.hemsire_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.islem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.hemsire_button);
            this.Controls.Add(this.envanter);
            this.Controls.Add(this.hasta);
            this.Controls.Add(this.ilac);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.doktor_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button doktor_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ilac;
        private System.Windows.Forms.Button hasta;
        private System.Windows.Forms.Button envanter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button islem;
        private System.Windows.Forms.Button hemsire_button;
    }
}

