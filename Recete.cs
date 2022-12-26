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
    public partial class Recete : Form
    {
        public Recete()
        {
            InitializeComponent();
        }

        // connect to database

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;database=hastanedb;password=Asdasd159");

        private void Ekle_Click(object sender, EventArgs e)
        {
            //add data to recete table. doz,tedaviid,kullanimsikligi,aciklama.

            NpgsqlCommand ekle = new NpgsqlCommand("insert into recete (tedaviid,doz,kullanimsikligi,aciklama) values (@tedaviid,@doz,@kullanimsikligi,@aciklama)", baglanti);
            ekle.Parameters.AddWithValue("@tedaviid", Int32.Parse(tedaviid.Text));
            ekle.Parameters.AddWithValue("@doz", doz.Text);
            ekle.Parameters.AddWithValue("@kullanimsikligi", kullanimsikligi.Text);
            ekle.Parameters.AddWithValue("@aciklama", aciklama.Text);
            baglanti.Open();
            ekle.ExecuteNonQuery();
            

            if (ilacid1_textbox.Text!="")
            {
                if (ilacid2_textbox.Text!="")
                {
                    if (ilacid3_textbox.Text!="")
                    {
                        // insertdata to receteilac table values receteid,ilacid
                        for (int i = 0; i < 3; i++)
                        {
                            NpgsqlCommand receteilac = new NpgsqlCommand("insert into receteilac (receteid,ilacid) values (currval('recete_receteid_seq'),@ilacid)", baglanti);
                            if (i == 0)
                                receteilac.Parameters.AddWithValue("@ilacid", Int32.Parse(ilacid1_textbox.Text));
                            else if (i == 1)
                                receteilac.Parameters.AddWithValue("@ilacid", Int32.Parse(ilacid2_textbox.Text));
                            else
                                receteilac.Parameters.AddWithValue("@ilacid", Int32.Parse(ilacid3_textbox.Text));
                            receteilac.ExecuteNonQuery();
                        }
                        baglanti.Close();
                    }
                    else
                    {
                        // insert data to receteilac table values receteid,ilacid
                        for (int i = 0; i < 2; i++)
                        {
                            NpgsqlCommand receteilac = new NpgsqlCommand("insert into receteilac (receteid,ilacid) values (currval('recete_receteid_seq'),@ilacid)", baglanti);
                            if (i == 0)
                                receteilac.Parameters.AddWithValue("@ilacid", Int32.Parse(ilacid1_textbox.Text));
                            else
                                receteilac.Parameters.AddWithValue("@ilacid", Int32.Parse(ilacid2_textbox.Text));
                            receteilac.ExecuteNonQuery();
                        }
                        baglanti.Close();
                    }
                }
                else
                {
                    NpgsqlCommand receteilac = new NpgsqlCommand("insert into receteilac (receteid,ilacid) values (currval('recete_receteid_seq'),@ilacid)", baglanti);
                    receteilac.Parameters.AddWithValue("@ilacid", Int32.Parse(ilacid1_textbox.Text));
                    receteilac.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            MessageBox.Show("Recete Eklendi");
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            //list all data from recete table and show it to datagridview

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from recete", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from recete where receteid='" + receteid.Text + "'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
