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
                ekle.Parameters.AddWithValue("@doktorid", Int32.Parse(doktorid_textBox.Text));
                ekle.Parameters.AddWithValue("@hastaid", Int32.Parse(hastaid_textbox.Text));
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

        private void Güncelle_Click(object sender, EventArgs e)
        {
            // check if  randevuid_textbox
            if (randevuid_textbox.Text != "")
            {
                // update randevu table
                baglanti.Open();
                NpgsqlCommand guncelle = new NpgsqlCommand("update randevu set doktorid=@doktorid,hastaid=@hastaid,tarih=@tarih,saat=@saat where randevuid=@randevuid", baglanti);
                guncelle.Parameters.AddWithValue("@randevuid", Int32.Parse(randevuid_textbox.Text));
                guncelle.Parameters.AddWithValue("@doktorid", Int32.Parse(doktorid_textBox.Text));
                guncelle.Parameters.AddWithValue("@hastaid", Int32.Parse(hastaid_textbox.Text));
                guncelle.Parameters.AddWithValue("@tarih", tarih_datetimepicker.Value);
                guncelle.Parameters.AddWithValue("@saat", saat_datetimepicker.Value);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Randevu Başarıyla Güncellendi");
            }
            else
            {
                MessageBox.Show("Lütfen Randevu ID'sini Giriniz");
            }
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            //list all data from randevu table to datagridview
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from randevu", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            //check if randevuid_textbox is not blank
            if (randevuid_textbox.Text != "")
            {
                //list data from randevu table to datagridview
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from randevu where randevuid=" + randevuid_textbox.Text + "", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Randevu ID'sini Giriniz");
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            //check if randevuid_textbox is not blank
            if (randevuid_textbox.Text != "")
            {
                //delete data from randevu table
                baglanti.Open();
                NpgsqlCommand sil = new NpgsqlCommand("delete from randevu where randevuid=@randevuid", baglanti);
                sil.Parameters.AddWithValue("@randevuid", Int32.Parse(randevuid_textbox.Text));
                sil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Randevu Başarıyla Silindi");
            }
            else
            {
                MessageBox.Show("Lütfen Randevu ID'sini Giriniz");
            }
        }
    }
}
