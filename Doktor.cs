using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace hastane_deneme_1
{
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");

        private void Güncelle_Click(object sender, EventArgs e)
        {
            //update 
            if (Tc_textBox.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
            }
            else
            {
                // check if tcNo_textbox is not numeric
                if (!Tc_textBox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("TC Kimlik Numarası sadece rakamlardan oluşmalıdır.");
                }
                else
                {
                    //update kisi
                    NpgsqlCommand updatekisi = new NpgsqlCommand("update kisi set isim=@isim,soyisim=@soyisim,dogumtarihi=@dogumtarihi,cinsiyet=@cinsiyet,telno=@telno where tcno=@tcno", baglanti);
                    updatekisi.Parameters.AddWithValue("@isim", isim_textBox.Text);
                    updatekisi.Parameters.AddWithValue("@soyisim", soyisim_textBox.Text);
                    updatekisi.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
                    updatekisi.Parameters.AddWithValue("@dogumtarihi", dogumTarihi_date.Value);
                    updatekisi.Parameters.AddWithValue("@cinsiyet", cinsiyet_combobox.Text);
                    updatekisi.Parameters.AddWithValue("@telno", telNo_textbox.Text);
                    baglanti.Open();
                    updatekisi.ExecuteNonQuery();
                    baglanti.Close();

                    //update doktor where doktor.kisiid = (select kisiid from kisi where tcno = @tcno)
                    NpgsqlCommand updatedoktor = new NpgsqlCommand("update doktor set pozisyon=@pozisyon,maas=@maas where doktor.kisiid = (select kisiid from kisi where tcno = @tcno)", baglanti);
                    updatedoktor.Parameters.AddWithValue("@pozisyon", pozisyon_textBox.Text);
                    updatedoktor.Parameters.AddWithValue("@maas", Int32.Parse(maas_textBox.Text));
                    updatedoktor.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
                    baglanti.Open();
                    updatedoktor.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Doktor kaydı başarıyla güncellendi.");
                }
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (Tc_textBox.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
            }
            else
            {
                // check if tcNo_textbox is not numeric
                if (!Tc_textBox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("TC Kimlik Numarası sadece rakamlardan oluşmalıdır.");
                }
                else
                {
                    baglanti.Open();

                    string sql = "select * from kisi where tcno = @tcno";
                    NpgsqlCommand kontrol = new NpgsqlCommand(sql, baglanti);
                    kontrol.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
                    NpgsqlDataReader oku = kontrol.ExecuteReader();

                    if (oku.Read())
                    {
                        baglanti.Close();
                        NpgsqlCommand updatekisi = new NpgsqlCommand("update kisi set doktor=@doktor where tcno=@tcno", baglanti);
                        updatekisi.Parameters.AddWithValue("@doktor", true);
                        baglanti.Open();
                        updatekisi.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Doktor kaydı başarıyla eklendi.");
                    }
                    else
                    {
                        baglanti.Close();

                        NpgsqlCommand eklekisi = new NpgsqlCommand("insert into kisi (isim,soyisim,tcno,dogumtarihi,cinsiyet,telno,doktor) values (@isim,@soyisim,@tcno,@dogumtarihi,@cinsiyet,@telno,@doktor)", baglanti);
                        eklekisi.Parameters.AddWithValue("@isim", isim_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@soyisim", soyisim_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
                        eklekisi.Parameters.AddWithValue("@dogumtarihi", dogumTarihi_date.Value);
                        eklekisi.Parameters.AddWithValue("@cinsiyet", cinsiyet_combobox.Text);
                        eklekisi.Parameters.AddWithValue("@telno", telNo_textbox.Text);
                        eklekisi.Parameters.AddWithValue("@doktor", true);
                        baglanti.Open();
                        eklekisi.ExecuteNonQuery();

                        NpgsqlCommand eklehemsire = new NpgsqlCommand("insert into doktor(kisiid,pozisyon,maas) values(currval('kisi_kisiid_seq'),@pozisyon,@maas)", baglanti);

                        eklehemsire.Parameters.AddWithValue("@pozisyon", pozisyon_textBox.Text);
                        eklehemsire.Parameters.AddWithValue("@maas", Int32.Parse(maas_textBox.Text));
                        eklehemsire.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Doktor kaydı başarıyla eklendi.");
                    }
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {

            //checking tc no
            if (Tc_textBox.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
            }
            else
            {
                // check if tcNo_textbox is not numeric
                if (!Tc_textBox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("TC Kimlik Numarası sadece rakamlardan oluşmalıdır.");
                }
                else
                {
                    //delete from doktor where doktor.kisiid = (select kisiid from kisi where tcno = @tcno)
                    NpgsqlCommand deletedoktor = new NpgsqlCommand("delete from doktor where doktor.kisiid=(select kisiid from kisi where tcno=@tcno)", baglanti);
                    deletedoktor.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
                    baglanti.Open();
                    deletedoktor.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            //checking tc no
            if (Tc_textBox.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
            }
            else
            {
                // check if tcNo_textbox is not numeric
                if (!Tc_textBox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("TC Kimlik Numarası sadece rakamlardan oluşmalıdır.");
                }
                else
                {
                    //list a nurse to datagrid where  inner join doktor on kisi.kisiid=doktor.kisiid
                    string ara = "select kisi.kisiid,kisi.isim,kisi.soyisim,kisi.tcno,kisi.dogumtarihi,kisi.cinsiyet,kisi.telno,doktor.pozisyon,doktor.maas from kisi inner join doktor on kisi.kisiid=doktor.kisiid where tcno=@tcno";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(ara, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@tcno", Tc_textBox.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    baglanti.Close();
                }
            }
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            //list all doktorcs to datagrid

            string listele = "select kisi.kisiid,kisi.isim,kisi.soyisim,kisi.tcno,kisi.dogumtarihi,kisi.cinsiyet,kisi.telno,doktor.pozisyon,doktor.maas from kisi inner join doktor on kisi.kisiid=doktor.kisiid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
