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
    public partial class ekipman : Form
        
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");
        public ekipman()
        {
            InitializeComponent();
        }

        private void ekipman_Load(object sender, EventArgs e)
        {

        }

        private void Listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from ekipman";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand ekle = new NpgsqlCommand("insert into ekipman(isim,modelnumarasi,bakimsikligi,uretici,urunid) values (@isim,@modelnumarasi,@bakimsikligi,@uretici,@urunid)", baglanti);
            ekle.Parameters.AddWithValue("@isim", isim.Text);
            ekle.Parameters.AddWithValue("@modelnumarasi", modelnumarasi.Text);
            ekle.Parameters.AddWithValue("@bakimsikligi", bakimsikligi.Text);
            ekle.Parameters.AddWithValue("@uretici", uretici.Text);
            ekle.Parameters.AddWithValue("@urunid",int.Parse( urunid.Text));
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
    }
}
