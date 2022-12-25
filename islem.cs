using Npgsql;
using System;
using System.Data;
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

        private void Listele_Click(object sender, EventArgs e)
        {
            // list data from islem table and islemekipman table then show it to datagridview
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select islem.islemid,islem.isim,islem.ucret,islem.aciklama,ekipman.isim as ekipmanismi from islem inner join islemekipman on islem.islemid=islemekipman.islemid inner join ekipman on ekipman.ekipmanid=islemekipman.ekipmanid", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand ekle = new NpgsqlCommand("insert into islem(aciklama,isim,ucret) values (@aciklama,@isim,@ucret)", baglanti);
            ekle.Parameters.AddWithValue("@aciklama", aciklama.Text);
            ekle.Parameters.AddWithValue("@isim", isim.Text);
            ekle.Parameters.AddWithValue("@ucret", int.Parse(ucret.Text));
            baglanti.Open();
            ekle.ExecuteNonQuery();

            if (ekipmanid1.Text != "")
            {
                if (ekipmanid2.Text != "")
                {
                    if (ekipmanid3.Text != "")
                    {
                        // insert data to islemekipman table if ekipmanid1,2,3 is not blank
                        for (int i = 0; i < 3; i++)
                        {
                            NpgsqlCommand islemekipman = new NpgsqlCommand("insert into islemekipman (islemid,ekipmanid) values (currval('islem_islemid_seq'),@ekipmanid)", baglanti);
                            if (i == 0)
                                islemekipman.Parameters.AddWithValue("@ekipmanid", Int32.Parse(ekipmanid1.Text));
                            else if (i == 1)
                                islemekipman.Parameters.AddWithValue("@ekipmanid", Int32.Parse(ekipmanid2.Text));
                            else
                                islemekipman.Parameters.AddWithValue("@ekipmanid", Int32.Parse(ekipmanid3.Text));
                            islemekipman.ExecuteNonQuery();
                        }
                        baglanti.Close();
                    }
                    else
                    {
                        // insert data to islemekipman table if ekipmanid1,2 is not blank
                        for (int i = 0; i < 2; i++)
                        {
                            NpgsqlCommand islemekipman = new NpgsqlCommand("insert into islemekipman (islemid,ekipmanid) values (currval('islem_islemid_seq'),@ekipmanid)", baglanti);
                            if (i == 0)
                                islemekipman.Parameters.AddWithValue("@ekipmanid", Int32.Parse(ekipmanid1.Text));
                            else
                                islemekipman.Parameters.AddWithValue("@ekipmanid", Int32.Parse(ekipmanid2.Text));
                            islemekipman.ExecuteNonQuery();

                        }
                        baglanti.Close();
                    }
                }
                else
                {
                    //insert data to islemekipman table if ekipmanid1 is not blank
                    NpgsqlCommand islemekipman = new NpgsqlCommand("insert into islemekipman (islemid,ekipmanid) values (currval('islem_islemid_seq'),@ekipmanid)", baglanti);
                    islemekipman.Parameters.AddWithValue("@ekipmanid1", Int32.Parse(ekipmanid1.Text));
                    islemekipman.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
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
            NpgsqlCommand komut3 = new NpgsqlCommand("update islem set aciklama=@aciklama,isim=@isim,ucret=@ucret where islemid=@islemid", baglanti);
            komut3.Parameters.AddWithValue("@aciklama", aciklama.Text);
            komut3.Parameters.AddWithValue("@isim", isim.Text);
            komut3.Parameters.AddWithValue("@ucret", int.Parse(ucret.Text));

            komut3.Parameters.AddWithValue("@islemid", int.Parse(islemid.Text));
            baglanti.Open();
            komut3.ExecuteNonQuery();
            MessageBox.Show("İslem güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            baglanti.Close();
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            // chech islemid is blank or not
            if (islemid.Text != "")
            {
                // if islemid is not blank then search data from islem table and islemekipman table then show it to datagridview
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select islem.islemid,islem.isim,islem.ucret,islem.aciklama,ekipman.isim as ekipmanismi from islem inner join islemekipman on islem.islemid=islemekipman.islemid inner join ekipman on ekipman.ekipmanid=islemekipman.ekipmanid where islem.islemid=@islemid", baglanti);
                da.SelectCommand.Parameters.AddWithValue("@islemid", int.Parse(islemid.Text));
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen işlemid giriniz.");
            }
        }
    }
}
