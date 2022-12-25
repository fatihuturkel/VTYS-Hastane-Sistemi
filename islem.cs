using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_deneme_1
{
    public partial class islem : Form
        
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");
        public islem()
        {
            InitializeComponent();
        }

        private void islem_Load(object sender, EventArgs e)
        {

        }

        private void Listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from islem";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand ekle = new NpgsqlCommand("insert into islem(aciklama,isim,ucret) values (@aciklama,@isim,@ucret)", baglanti);
            ekle.Parameters.AddWithValue("@aciklama", aciklama.Text);
            ekle.Parameters.AddWithValue("@isim", isim.Text);
            ekle.Parameters.AddWithValue("@ucret", int.Parse(ucret.Text));
            baglanti.Open();
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem eklendi.");
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from islem where islemid=@islemid", baglanti);
            komut2.Parameters.AddWithValue("@islemid", int.Parse(islemid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update islem set aciklama=@aciklama,isim=@isim,ucret=@ucret where islemid=@islemid", baglanti);
            komut3.Parameters.AddWithValue("@aciklama",aciklama.Text);
            komut3.Parameters.AddWithValue("@isim", isim.Text);
            komut3.Parameters.AddWithValue("@ucret", int.Parse(ucret.Text));

            komut3.Parameters.AddWithValue("@islemid", int.Parse(islemid.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("İslem güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            baglanti.Close();
            
        }
    }
}
