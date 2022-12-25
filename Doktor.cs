using Npgsql;
using System;
using System.Linq;
using System.Windows.Forms;

namespace hastane_deneme_1
{
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");

        private void Güncelle_Click(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (Tc_textBox.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
            }
            else
            {
                // check if tcNo_textbox is not numeric
                if (!Tc_textBox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("TC Kimlik Numarası sadece rakamlardan oluşmalıdır.");
                }
                else
                {
                    baglanti.Open();

                    string sql = "select * from kisi where tcno = @tcno";
                    NpgsqlCommand kontrol = new NpgsqlCommand(sql, baglanti);
                    kontrol.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
                    NpgsqlDataReader oku = kontrol.ExecuteReader();

                    if (oku.Read())
                    {
                        baglanti.Close();
                        NpgsqlCommand updatekisi = new NpgsqlCommand("update kisi set doktor=@doktor where tcno=@tcno", baglanti);
                        updatekisi.Parameters.AddWithValue("@doktor", true);
                        baglanti.Open();
                        updatekisi.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Doktor kaydı başarıyla eklendi.");
                    }
                    else
                    {
                        baglanti.Close();

                        NpgsqlCommand eklekisi = new NpgsqlCommand("insert into kisi (isim,soyisim,tcno,dogumtarihi,cinsiyet,telno,doktor) values (@isim,@soyisim,@tcno,@dogumtarihi,@cinsiyet,@telno,@doktor)", baglanti);
                        eklekisi.Parameters.AddWithValue("@isim", isim_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@soyisim", soyisim_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@dogumtarihi", dogumTarihi_date.Value);
                        eklekisi.Parameters.AddWithValue("@cinsiyet", cinsiyet_combobox.Text);
                        eklekisi.Parameters.AddWithValue("@telno", telNo_textbox.Text);
                        eklekisi.Parameters.AddWithValue("@doktor", true);
                        baglanti.Open();
                        eklekisi.ExecuteNonQuery();

                        NpgsqlCommand eklehemsire = new NpgsqlCommand("insert into doktor(kisiid,pozisyon,maas) values(currval('kisi_kisiid_seq'),@pozisyon,@maas)", baglanti);

                        eklehemsire.Parameters.AddWithValue("@pozisyon", pozisyon_textBox.Text);
                        eklehemsire.Parameters.AddWithValue("@maas", Int32.Parse(maas_textBox.Text));
                        eklehemsire.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Doktor kaydı başarıyla eklendi.");
                    }
                }
            }
        }
    }
}
