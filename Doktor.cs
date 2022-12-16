using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace hastane_deneme_1
{
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastane deneme 3;password=Asdasd159");

        // doctor form , needed tasks are deleting updating and adding doctors to the database  

        // add doctor to database
        private void button1_Click(object sender, EventArgs e)
        {
            // check if tcNo_textbox is not 11 digits
            if (tcno_textbox.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
            }
            else
            {
                // check if tcNo_textbox is not numeric
                if (!tcno_textbox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("TC Kimlik Numarası sadece rakamlardan oluşmalıdır.");
                    MessageBox.Show("deneme2");
                }
                else
                {
                    // check if tcNo is already in the database
                    NpgsqlCommand kontrol = new NpgsqlCommand("select * from doktor where tcno = @tcno", baglanti);
                    kontrol.Parameters.AddWithValue("@tcno", tcno_textbox.Text);
                    baglanti.Open();
                    NpgsqlDataReader oku = kontrol.ExecuteReader();
                    if (oku.Read())
                    {
                        MessageBox.Show("Bu Tc No daha önce kayıt edilmiştir.");
                        baglanti.Close();
                    }
                    else
                    {
                        baglanti.Close();
                        // insert doctor to database
                        NpgsqlCommand ekle = new NpgsqlCommand("insert into doktor (isim,soyisim,tcNo,dogumTarihi,cinsiyet,telNo,doktor) values (@isim,@soyisim,@tcNo,@dogumTarihi,@cinsiyet,@telNo,@doktor)", baglanti);
                        ekle.Parameters.AddWithValue("@isim", isim_textbox.Text);
                        ekle.Parameters.AddWithValue("@soyisim", soyisim_textbox.Text);
                        ekle.Parameters.AddWithValue("@tcNo", tcno_textbox.Text);
                        ekle.Parameters.AddWithValue("@dogumTarihi", dogumTarihi_date.Value);
                        ekle.Parameters.AddWithValue("@cinsiyet", cinsiyet_combobox.Text);
                        ekle.Parameters.AddWithValue("@telNo", telNo_textbox.Text);
                        ekle.Parameters.AddWithValue("@doktor", true);
                        baglanti.Open();
                        ekle.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Doktor başarıyla eklendi.");
                    }
                }
            }
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            // add doctor to the database 
            // check if the doctor is already in the database 
            // if not add it 
            // if yes show a message box 
        }*/
        private void button2_Click(object sender, EventArgs e)
        {
            // delete doctor from the database 
            // check if the doctor is in the database 
            // if yes delete it 
            // if not show a message box 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // update doctor in the database        
            // check if the doctor is in the database 
            // if yes update it 
            // if not show a message box 
        }
    }
}
