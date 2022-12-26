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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace hastane_deneme_1
{
    public partial class gorusoneri : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");
        public gorusoneri()
        {
            InitializeComponent();
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from gorusoneri";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand ekle = new NpgsqlCommand("insert into gorusoneri(isim,soyisim,aciklama,baslik) values (@isim,@soyisim,@aciklama,@baslik)", baglanti);
            ekle.Parameters.AddWithValue("@isim", isim.Text);
            ekle.Parameters.AddWithValue("@soyisim", soyisim.Text);
            ekle.Parameters.AddWithValue("@aciklama", aciklama.Text);
            ekle.Parameters.AddWithValue("@baslik", baslik.Text);
            
            
            baglanti.Open();
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Görüş ve Öneri eklendi.");
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from gorusoneri where gorusoneriid=@gorusoneriid", baglanti);
            komut2.Parameters.AddWithValue("@gorusoneriid", int.Parse(gorusoneriid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Görüş ve Öneri silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update gorusoneri set isim=@isim,soyisim=@soyisim,baslik=@baslik aciklama=@aciklama where gorusoneriid=@gorusoneriid", baglanti);
           
            komut3.Parameters.AddWithValue("@isim", isim.Text);
            komut3.Parameters.AddWithValue("@soyisim", soyisim.Text);
            komut3.Parameters.AddWithValue("@baslik", baslik.Text);
            komut3.Parameters.AddWithValue("@aciklama", aciklama.Text);
            

            komut3.Parameters.AddWithValue("@gorusoneriid", int.Parse(gorusonerid.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Görüş ve Öneri güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            baglanti.Close();

        }
    }
}
