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
    
    public partial class envanter : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");
        public envanter()
        {
            InitializeComponent();
        }

        private void envanter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from envanter";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlCommand ekle = new NpgsqlCommand("insert into envanter(ucret,tedarikci,adet) values (@ucret,@tedarikci,@adet)", baglanti);
            ekle.Parameters.AddWithValue("@ucret", int.Parse(ucret.Text));
            ekle.Parameters.AddWithValue("@tedarikci", tedarikci.Text);
            ekle.Parameters.AddWithValue("@adet", int.Parse(adet.Text));
            baglanti.Open();
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Envanter eklendi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from envanter where urunid=@urunid", baglanti);
            komut2.Parameters.AddWithValue("@urunid", int.Parse(urunid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Envanter silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update envanter set ucret=@ucret,tedarikci=@tedarikci,adet=@adet where urunid=@urunaid", baglanti);
            komut3.Parameters.AddWithValue("@ucret", int.Parse(ucret.Text));
            komut3.Parameters.AddWithValue("@tedarikci", tedarikci.Text);
            komut3.Parameters.AddWithValue("@adet", int.Parse(adet.Text));
           
            komut3.Parameters.AddWithValue("@urunid", int.Parse(urunid.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("İlaç güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            baglanti.Close();

        }
    }
}
