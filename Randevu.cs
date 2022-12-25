using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_deneme_1
{
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }

        // connectin to db
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");

        private void ekle_Click(object sender, EventArgs e)
        {
            // check if  doktorid_textBox , hastaid_textbox ,tarih_datatimepicker , saat_textbox is not blank
            if (doktorid_textBox.Text != "" && hastaid_textbox.Text != "" )
            {
                // insert data to randevu table
                baglanti.Open();
                NpgsqlCommand ekle = new NpgsqlCommand("insert into randevu (doktorid,hastaid,tarih,saat) values (@doktorid,@hastaid,@tarih,@saat)", baglanti);
                ekle.Parameters.AddWithValue("@doktorid", doktorid_textBox.Text);
                ekle.Parameters.AddWithValue("@hastaid", hastaid_textbox.Text);
                ekle.Parameters.AddWithValue("@tarih", tarih_datetimepicker.Value);
                ekle.Parameters.AddWithValue("@saat", saat_datetimepicker.Value);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Randevu Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
        }  
    }
}
