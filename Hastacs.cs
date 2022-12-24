using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace hastane_deneme_1
{
    public partial class Hastacs : Form
    {
        public Hastacs()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");

        private void ekle_Click(object sender, System.EventArgs e)
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
                        NpgsqlCommand updatekisi = new NpgsqlCommand("update kisi set hasta=@hasta where tcno=@tcno", baglanti);
                        updatekisi.Parameters.AddWithValue("@hasta", true);
                        baglanti.Open();
                        updatekisi.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Hasta kaydı başarıyla eklendi.");
                    }
                    else
                    {
                        baglanti.Close();

                        NpgsqlCommand eklekisi = new NpgsqlCommand("insert into kisi (isim,soyisim,tcno,dogumtarihi,cinsiyet,telno,hasta) values (@isim,@soyisim,@tcno,@dogumtarihi,@cinsiyet,@telno,@hasta)", baglanti);
                        eklekisi.Parameters.AddWithValue("@isim", isim_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@soyisim", soyisim_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@dogumtarihi", dogumTarihi_date.Value);
                        eklekisi.Parameters.AddWithValue("@cinsiyet", cinsiyet_combobox.Text);
                        eklekisi.Parameters.AddWithValue("@telno", telNo_textbox.Text);
                        eklekisi.Parameters.AddWithValue("@hasta", true);
                        baglanti.Open();
                        eklekisi.ExecuteNonQuery();

                        NpgsqlCommand eklehasta = new NpgsqlCommand("insert into hasta(kisiid,sigortaid) values(currval('kisi_kisiid_seq'),@sigortaid)", baglanti);
                        if (sigorta_textBox.Text == "Yok")
                            eklehasta.Parameters.AddWithValue("@sigortaid", 0);
                        else
                            eklehasta.Parameters.AddWithValue("@sigortaid", Int32.Parse(sigorta_textBox.Text));
                        eklehasta.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Hasta kaydı başarıyla eklendi.");
                    }
                }
            }
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // select isim soyiisim and tc from kisi
            string listele = "select kisi.isim,kisi.soyisim,kisi.tcno,kisi.dogumtarihi,kisi.cinsiyet,kisi.telno,hasta.sigortaid from kisi inner join hasta on kisi.kisiid=hasta.kisiid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            // delete from kisi where tcno = @tcno
            baglanti.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from kisi where tcno=@tcno", baglanti);
            sil.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}

