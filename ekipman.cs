using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace hastane_deneme_1
{
    public partial class ekipman : Form

    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");
        public ekipman()
        {
            InitializeComponent();
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            // listele
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from ekipman", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand ekle = new NpgsqlCommand("insert into ekipman(isim,modelnumarasi,bakimsikligi,uretici,urunid) values (@isim,@modelnumarasi,@bakimsikligi,@uretici,@urunid)", baglanti);
            ekle.Parameters.AddWithValue("@isim", isim.Text);
            ekle.Parameters.AddWithValue("@modelnumarasi", modelnumarasi.Text);
            ekle.Parameters.AddWithValue("@bakimsikligi", bakimsikligi.Text);
            ekle.Parameters.AddWithValue("@uretici", uretici.Text);
            ekle.Parameters.AddWithValue("@urunid", int.Parse(urunid.Text));
            baglanti.Open();
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekipman eklendi.");
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from envanter where ekipmanid=@ekipmanid", baglanti);
            komut2.Parameters.AddWithValue("@ekipmanid", int.Parse(ekipmanid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekipman silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update ekipman set isim=@isim,modelnumarasi=@modelnumarasi,bakimsikligi=@bakimsikligi uretici=@uretici, urunid=@urunid where ekipmanid=@ekipmanid", baglanti);

            komut3.Parameters.AddWithValue("@isim", isim.Text);
            komut3.Parameters.AddWithValue("@modelnumarasi", modelnumarasi.Text);
            komut3.Parameters.AddWithValue("@bakimsikligi", bakimsikligi.Text);
            komut3.Parameters.AddWithValue("@uretici", uretici.Text);
            komut3.Parameters.AddWithValue("@urunid", int.Parse(urunid.Text));

            komut3.Parameters.AddWithValue("@ekipmanid", int.Parse(ekipmanid.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show(" Ekipman güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            baglanti.Close();

        }

        private void Ara_Click(object sender, EventArgs e)
        {
            // check ekipman is empty
            if (ekipmanid.Text == "")
            {
                MessageBox.Show("Lütfen aramak istediğiniz ekipman id'sini giriniz.");
            }
            else
            {
                // get data from database and show it in datagridview, where ekipmanid
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from ekipman where ekipmanid=" + ekipmanid.Text, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
        }
    }
}
