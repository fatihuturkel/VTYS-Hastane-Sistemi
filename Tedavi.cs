using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace hastane_deneme_1
{
    public partial class Tedavi : Form
    {
        public Tedavi()
        {
            InitializeComponent();
        }

        //connect to db
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");

        private void ekle_Click(object sender, EventArgs e)
        {
            //check if  doktorid_texBox , hastaid_textbox , aciklama_richtextbox , ucret_textbox is not blank
            if (hastaid_textbox.Text != "" && doktorid_textBox.Text != "" && ucret_textBox.Text != "" && aciklama_ricttextbox.Text != "")
            {
                //insert data to tedavi table
                baglanti.Open();
                NpgsqlCommand ekletedavi = new NpgsqlCommand("insert into tedavi (hastaid,doktorid,tarih,aciklama,ucret,hemsireid) values (@hastaid,@doktorid,@tarih,@aciklama,@ucret,@hemsireid)", baglanti);
                ekletedavi.Parameters.AddWithValue("@doktorid", Int32.Parse(doktorid_textBox.Text));
                ekletedavi.Parameters.AddWithValue("@hastaid", Int32.Parse(hastaid_textbox.Text));
                ekletedavi.Parameters.AddWithValue("@ucret", Int32.Parse(ucret_textBox.Text));
                ekletedavi.Parameters.AddWithValue("@aciklama", aciklama_ricttextbox.Text);
                ekletedavi.Parameters.AddWithValue("@tarih", tarih_datetimepicker.Value);
                if (hemsire_textBox.Text != "")
                    ekletedavi.Parameters.AddWithValue("@hemsireid", Int32.Parse(hemsire_textBox.Text));
                else
                    ekletedavi.Parameters.AddWithValue("@hemsireid", 0);
                ekletedavi.ExecuteNonQuery();

                if (islemid1.Text != "")
                {
                    if (islemid2.Text != "")
                    {
                        if (islemid3.Text != "")
                        {
                            //insert data to tedaviislem table if islemid1,2,3 is not blank
                            for (int i = 0; i < 3; i++)
                            {
                                NpgsqlCommand tedaviislemekle = new NpgsqlCommand("insert into tedaviislem(tedaviid,islemid) values(currval('tedavi_tedaviid_seq'),@islemid)", baglanti);
                                if (i == 0)
                                    tedaviislemekle.Parameters.AddWithValue("@islemid", Int32.Parse(islemid1.Text));
                                else if (i == 1)
                                    tedaviislemekle.Parameters.AddWithValue("@islemid", Int32.Parse(islemid2.Text));
                                else
                                    tedaviislemekle.Parameters.AddWithValue("@islemid", Int32.Parse(islemid3.Text));
                                tedaviislemekle.ExecuteNonQuery();
                            }
                            baglanti.Close();
                        }
                        else
                        {
                            // insert data to tedaviislem table if islemid,2 is not blank
                            for (int i = 0; i < 2; i++)
                            {
                                NpgsqlCommand tedaviislemekle = new NpgsqlCommand("insert into tedaviislem(tedaviid,islemid) values(currval('tedavi_tedaviid_seq'),@islemid)", baglanti);
                                if (i == 0)
                                    tedaviislemekle.Parameters.AddWithValue("@islemid", Int32.Parse(islemid1.Text));
                                else
                                    tedaviislemekle.Parameters.AddWithValue("@islemid", Int32.Parse(islemid2.Text));
                                tedaviislemekle.ExecuteNonQuery();
                            }
                            baglanti.Close();
                        }
                    }
                    else
                    {
                        //insert data to tedaviislem table if islemid is not blank
                        NpgsqlCommand tedaviislemekle = new NpgsqlCommand("insert into tedaviislem(tedaviid,islemid) values(currval('tedavi_tedaviid_seq'),@islemid)", baglanti);
                        tedaviislemekle.Parameters.AddWithValue("@islemid", Int32.Parse(islemid1.Text));
                        tedaviislemekle.ExecuteNonQuery();
                        baglanti.Close();
                    }
                }
                
                baglanti.Close();
                /*if (MessageBox.Show("Tedavi Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
                */
                MessageBox.Show("Tedavi Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            //list all data from tedavi inner join tedaviislem on tedaviislem.tedaviid=tedavi.tedaviid
            baglanti.Open();
            string command = "select tedavi.tedaviid,tedavi.doktorid,tedavi.hastaid,tedavi.tarih,tedavi.aciklama,tedavi.ucret,tedavi.hemsireid,islem.islemid,islem.isim as islemismi from tedavi inner join tedaviislem on tedaviislem.tedaviid=tedavi.tedaviid inner join islem on tedaviislem.islemid=islem.islemid ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            //check if tedaviid is blank or not
            if (tedaviid_textbox.Text!="")
            {
                baglanti.Open();
                string command = "select tedavi.tedaviid,tedavi.doktorid,tedavi.hastaid,tedavi.tarih,tedavi.aciklama,tedavi.ucret,tedavi.hemsireid,islem.islemid,islem.isim as islemismi from tedavi inner join tedaviislem on tedaviislem.tedaviid=tedavi.tedaviid inner join islem on tedaviislem.islemid=islem.islemid where tedavi.tedaviid=@tedaviid";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@tedaviid", int.Parse(tedaviid_textbox.Text));
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir tedavid giriniz.");
            }
        }
    }
}
