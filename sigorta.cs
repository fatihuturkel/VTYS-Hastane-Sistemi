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

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");


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
            // takes data from textboxes and inserts them to the database

            NpgsqlCommand ekle = new NpgsqlCommand("insert into sigorta (sigortaid,isim,telno,adress,mersisno) values (@sigortaid,@isim,@telNo,@adress,@mersisNo)", baglanti);
            ekle.Parameters.AddWithValue("@isim", isim.Text);
            ekle.Parameters.AddWithValue("@telNo", telNo.Text);
            ekle.Parameters.AddWithValue("@adress", adres.Text);
            ekle.Parameters.AddWithValue("@mersisNo", mersisNo.Text);
            baglanti.Open();
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sigorta eklendi.");
            
        }

        private void sigorta_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)


        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from sigorta where sigortaid=@sigortaid", baglanti);
            komut2.Parameters.AddWithValue("@sigortaid",int.Parse(sigortaid).Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sigorta silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
