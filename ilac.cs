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
    

    public partial class ilac : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");
        public ilac()
        {
            InitializeComponent();
        }

        private void ilac_Load(object sender, EventArgs e)
        {

        }

        private void Listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from ilac";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand ekle = new NpgsqlCommand("insert into ilac (isim,marka,aciklama) values (@isim,@marka,@aciklama)", baglanti);
            ekle.Parameters.AddWithValue("@isim", isim.Text);
            ekle.Parameters.AddWithValue("@marka", marka.Text);
            ekle.Parameters.AddWithValue("@aciklama", aciklama.Text);
            baglanti.Open();
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlaç eklendi.");
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from ilac where ilacid=@ilacid", baglanti);
            komut2.Parameters.AddWithValue("@ilacid", Convert.ToInt32(ilacid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlac silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update ilac set  isim=@isim,marka=@marka,aciklama=@aciklama where ilacid=@ilacid", baglanti);
            komut3.Parameters.AddWithValue("@isim", isim.Text);
            komut3.Parameters.AddWithValue("@marka", marka.Text);
            komut3.Parameters.AddWithValue("@aciklama", aciklama.Text);
            komut3.Parameters.AddWithValue("@ilacid", int.Parse(ilacid.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("İlac güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            baglanti.Close();

        }
    }
}
