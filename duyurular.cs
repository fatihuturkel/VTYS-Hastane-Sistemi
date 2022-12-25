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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace hastane_deneme_1
{
    public partial class duyurular : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");
        public duyurular()
        {
            InitializeComponent();
        }

        private void duyurular_Load(object sender, EventArgs e)
        {

        }

        private void Listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from duyurular";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand ekle = new NpgsqlCommand("insert into duyurular(baslik,aciklama) values (@baslik,@aciklama)", baglanti);
            
            ekle.Parameters.AddWithValue("@baslik",baslik.Text);
            ekle.Parameters.AddWithValue("@aciklama",aciklama.Text);
            baglanti.Open();
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Duyuru eklendi.");
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from duyurular where duyuruid=@duyuruid", baglanti);
            komut2.Parameters.AddWithValue("@duyuruid", int.Parse(duyuruid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Duyuru silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update duyurular set aciklama=@aciklama, baslik=@baslik where duyuruid=@duyuruid", baglanti);

            komut3.Parameters.AddWithValue("@aciklama", aciklama.Text);
            komut3.Parameters.AddWithValue("@baslik", baslik.Text);
          

            komut3.Parameters.AddWithValue("@duyuruid", int.Parse(duyuruid.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Duyuru güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            baglanti.Close();
        }
    }
}
