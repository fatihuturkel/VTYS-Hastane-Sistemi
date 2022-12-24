using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace hastane_deneme_1
{
    public partial class Hemsire : Form
    {
        public Hemsire()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");

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
                        NpgsqlCommand updatekisi = new NpgsqlCommand("update kisi set hemsire=@hemsire where tcno=@tcno", baglanti);
                        updatekisi.Parameters.AddWithValue("@hemsire", true);
                        baglanti.Open();
                        updatekisi.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Hemsire kaydı başarıyla eklendi.");
                    }
                    else
                    {
                        baglanti.Close();

                        NpgsqlCommand eklekisi = new NpgsqlCommand("insert into kisi (isim,soyisim,tcno,dogumtarihi,cinsiyet,telno,hemsire) values (@isim,@soyisim,@tcno,@dogumtarihi,@cinsiyet,@telno,@hemsire)", baglanti);
                        eklekisi.Parameters.AddWithValue("@isim", isim_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@soyisim", soyisim_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@dogumtarihi", dogumTarihi_date.Value);
                        eklekisi.Parameters.AddWithValue("@cinsiyet", cinsiyet_combobox.Text);
                        eklekisi.Parameters.AddWithValue("@telno", telNo_textbox.Text);
                        eklekisi.Parameters.AddWithValue("@hemsire", true);
                        baglanti.Open();
                        eklekisi.ExecuteNonQuery();

                        NpgsqlCommand eklehemsire = new NpgsqlCommand("insert into hemsire(kisiid,pozisyon,maas) values(currval('kisi_kisiid_seq'),@pozisyon,@maas)", baglanti);

                        eklehemsire.Parameters.AddWithValue("@pozisyon", pozisyon_textBox.Text);
                        eklehemsire.Parameters.AddWithValue("@maas", Int32.Parse(maas_textBox.Text));
                        eklehemsire.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Hemsire kaydı başarıyla eklendi.");
                    }
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            // delete from hemsire where kisiid = (select kisiid from kisi where tcno = @tcno)

            NpgsqlCommand sil = new NpgsqlCommand("delete from hemsire where kisiid = (select kisiid from kisi where tcno = @tcno)", baglanti);
            sil.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
            baglanti.Open();
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            // list all nurses to datagrid
            string listele = "select kisi.isim,kisi.soyisim,kisi.tcno,kisi.dogumtarihi,kisi.cinsiyet,kisi.telno,hemsire.maas,hemsire,pozisyon from kisi inner join hemsire on kisi.kisiid=hemsire.kisiid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        
    }
}
