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
    public partial class sigorta : Form
    {
        public sigorta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //asdasd asdasd
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; database=hastanedb; user Id=postgres; password=Asdasd159");


        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from sigorta";
                
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into sigorta(isim, telNo, adres, mersisNo) values( @p1, @p2, @p3, @p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", isim.Text);
            komut1.Parameters.AddWithValue("@p2", int.Parse(telNo.Text));
            komut1.Parameters.AddWithValue("@p3", adres.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(mersisNo.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sigorta ekleme başarılı bir şekilde gerçekleşti.");






        }
    }
}
